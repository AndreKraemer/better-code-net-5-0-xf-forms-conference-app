using ConferenceApp.ViewModels;
using ConferenceApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ConferenceApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
        }


    }
}
