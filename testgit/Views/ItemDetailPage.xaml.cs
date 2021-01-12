using System.ComponentModel;
using testgit.ViewModels;
using Xamarin.Forms;

namespace testgit.Views
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