using Luca_Ramona_Georgiana_Lab10.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Luca_Ramona_Georgiana_Lab10.Views
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