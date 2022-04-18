using Custom_program.ViewModels;
using Custom_program.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Custom_program
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
           
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
