using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travel.Pages.Details_Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bengaluru : ContentPage
    {
        ObservableCollection<string> photos { get; set; }
        public Bengaluru()
        {
            InitializeComponent();
            photos = new ObservableCollection<string>() { "Vizag", "bengaluru", "Shimla", "Kolkata" };
            ImageCollectionCarousel.ItemsSource = photos;
        }

        private void GotoLocaion(object sender, EventArgs e)
        {

        }
    }
}