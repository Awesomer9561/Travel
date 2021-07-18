using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travel.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Homepage : ContentPage
    {
        ObservableCollection<string> places { get; set; }
        public Homepage()
        {
            InitializeComponent();
            places = new ObservableCollection<string>()
            {
                "","","","","","",""
            };
            Vizag.ItemsSource = places;
            Bengaluru.ItemsSource = places;
            Mumbai.ItemsSource = places;
            Shimla.ItemsSource = places;
            Kolkata.ItemsSource = places;
        }

        private void placeSelected(object sender, SelectionChangedEventArgs e)
        {
            Navigation.PushAsync(new Pages.Details_Page.Bengaluru());
        }
    }
}