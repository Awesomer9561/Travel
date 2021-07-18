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
    public partial class Vizag : ContentPage
    {
        ObservableCollection<string> places { get; set; }
        public Vizag()
        {
            InitializeComponent();
            places = new ObservableCollection<string>()
            {
                "","","","","","",""
            };
            placesCollectioView.ItemsSource = places;

        }
    }
}