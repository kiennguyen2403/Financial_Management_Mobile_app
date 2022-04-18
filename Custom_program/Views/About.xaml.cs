using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Custom_program.Views
{
    public partial class AboutPage : ContentPage
    {   

        Account account = new Account();
        public AboutPage()
        {
            InitializeComponent();
         
               
        }

       

        private void Balance_represent_BindingContextChanged(object sender, EventArgs e)
        {
            Balance_represent.Text = account.Balance.ToString()+ "$";
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }
    }
}