using Luca_Ramona_Georgiana_Lab10.ViewModels;
using Luca_Ramona_Georgiana_Lab10.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Luca_Ramona_Georgiana_Lab10
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
