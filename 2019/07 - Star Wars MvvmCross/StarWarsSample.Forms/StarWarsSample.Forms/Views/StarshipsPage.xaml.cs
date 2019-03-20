﻿using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using StarWarsSample.Core.ViewModels;

namespace StarWarsSample.Forms.UI.Views
{
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Detail, WrapInNavigationPage = true, NoHistory = true)]
    public partial class StarshipsPage : MvxContentPage<StarshipsViewModel>
    {
        public StarshipsPage()
        {
            InitializeComponent();
        }
    }
}