using Custom_program.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Custom_program.Views
{
    public partial class ItemDetailPage : ContentPage
    {   

        
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}