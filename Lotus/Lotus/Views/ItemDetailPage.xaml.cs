using Lotus.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lotus.Views
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