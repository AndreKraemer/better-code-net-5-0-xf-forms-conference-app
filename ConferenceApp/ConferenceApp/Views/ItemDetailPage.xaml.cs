using ConferenceApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ConferenceApp.Views
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