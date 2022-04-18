using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Custom_program.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {

        }

        public ICommand OpenWebCommand { get; }
    }
}