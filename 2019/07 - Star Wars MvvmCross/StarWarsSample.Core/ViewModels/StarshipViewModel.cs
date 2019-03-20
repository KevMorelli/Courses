using System.Threading.Tasks;
using Acr.UserDialogs;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using StarWarsSample.Core.Models;
using StarWarsSample.Core.MvxInteraction;
using StarWarsSample.Core.ViewModelResults;

namespace StarWarsSample.Core.ViewModels
{
    public class StarshipViewModel : BaseViewModel<Starship, DestructionResult<Starship>>
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly IUserDialogs _userDialogs;

        public StarshipViewModel(IMvxNavigationService navigationService, IUserDialogs userDialogs)
        {
            _navigationService = navigationService;
            _userDialogs = userDialogs;

            DestroyStarshipCommand = new MvxAsyncCommand(DestroyStarship);
        }

        public override void Prepare(Starship parameter)
        {
            Starship = parameter;
        }

        // MvvmCross Lifecycle
        public override Task Initialize()
        {
            return Task.FromResult(0);
        }

        // MVVM Properties
        private Starship _starship;
        public Starship Starship
        {
            get
            {
                return _starship;
            }
            set
            {
                _starship = value;
                RaisePropertyChanged(() => Starship);
            }
        }

        public MvxInteraction<DestructionAction> Interaction { get; set; } = new MvxInteraction<DestructionAction>();

        // MVVM Commands
        public IMvxCommand DestroyStarshipCommand { get; private set; }

        // Private methods

        private async Task DestroyStarship()
        {
            var destroy = await _userDialogs.ConfirmAsync(new ConfirmConfig
            {
                Title = "Destroy Starship",
                Message = "Sir, are you sure you want to destroy this ship?",
                OkText = "YES",
                CancelText = "No"
            });

            if (!destroy)
                return;

            var request = new DestructionAction
            {
                OnDestroyed = () => _navigationService.Close(
                    this,
                    new DestructionResult<Starship>
                    {
                        Entity = Starship,
                        Destroyed = true
                    })
            };

            Interaction.Raise(request);
        }
    }
}
