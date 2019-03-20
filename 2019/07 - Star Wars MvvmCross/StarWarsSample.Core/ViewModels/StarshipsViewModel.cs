using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using StarWarsSample.Core.Models;
using StarWarsSample.Core.Services.Interfaces;
using StarWarsSample.Core.ViewModelResults;

namespace StarWarsSample.Core.ViewModels
{
    public class StarshipsViewModel : BaseViewModel
    {
        private readonly IStarshipService _starshipService;
        private readonly IMvxNavigationService _navigationService;

        private string _nextPage;

        public StarshipsViewModel(
            IStarshipService starshipService,
            IMvxNavigationService navigationService)
        {
            _starshipService = starshipService;
            _navigationService = navigationService;

            Starships = new MvxObservableCollection<Starship>();

            StarshipSelectedCommand = new MvxAsyncCommand<Starship>(StarshipSelected);
            FetchStarshipsCommand = new MvxCommand(
                () =>
                {
                    if (!string.IsNullOrEmpty(_nextPage))
                    {
                        FetchStarshipsTask = MvxNotifyTask.Create(LoadStarships);
                        RaisePropertyChanged(() => FetchStarshipsTask);
                    }
                });
            RefreshStarshipsCommand = new MvxCommand(RefreshStarships);
        }

        // MvvmCross Lifecycle
        public override Task Initialize()
        {
            LoadStarshipsTask = MvxNotifyTask.Create(LoadStarships);

            return Task.FromResult(0);
        }

        // MVVM Properties
        public MvxNotifyTask LoadStarshipsTask { get; private set; }

        public MvxNotifyTask FetchStarshipsTask { get; private set; }

        private MvxObservableCollection<Starship> _starships;
        public MvxObservableCollection<Starship> Starships
        {
            get
            {
                return _starships;
            }
            set
            {
                _starships = value;
                RaisePropertyChanged(() => Starships);
            }
        }

        // MVVM Commands
        public IMvxCommand<Starship> StarshipSelectedCommand { get; private set; }
        public IMvxCommand FetchStarshipsCommand { get; private set; }
        public IMvxCommand RefreshStarshipsCommand { get; private set; }

        // Private methods
        private async Task LoadStarships()
        {
            var result = await _starshipService.GetStarhipsAsync(_nextPage);

            if (string.IsNullOrEmpty(_nextPage))
            {
                Starships.Clear();
                Starships.AddRange(result.Results);
            }
            else
            {
                Starships.AddRange(result.Results);
            }

            _nextPage = result.Next;
        }

        private async Task StarshipSelected(Starship selectedStarship)
        {
            var result = await _navigationService.Navigate<StarshipViewModel, Starship, DestructionResult<Starship>>(selectedStarship);

            if (result != null && result.Destroyed)
            {
                var starship = Starships.FirstOrDefault(p => p.Name == result.Entity.Name);
                if (starship != null)
                    Starships.Remove(starship);
            }
        }

        private void RefreshStarships()
        {
            _nextPage = null;

            LoadStarshipsTask = MvxNotifyTask.Create(LoadStarships);
            RaisePropertyChanged(() => LoadStarshipsTask);
        }
    }
}
