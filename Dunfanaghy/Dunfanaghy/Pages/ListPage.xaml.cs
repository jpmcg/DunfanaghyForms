using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dunfanaghy.Helpers;
using Xamarin.Forms;

namespace Dunfanaghy.Pages
{
    public partial class ListPage : ContentPage
    {
        public ListPage(string category)
        {
            InitializeComponent();
            this.BindingContext = new {category = category};
            ListView1.BindingContext = GetVenues().Where(p => p.Category == category);
        }

        public List<Place> GetVenues()
        {
            return PlacesHelper.GetPlaces();
        }

        private void ListView1_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selected = e.SelectedItem as Place;
            if (selected != null)
            {
                Navigation.PushAsync(new PlacePage(selected));
            }
        }
    }

    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public List<string> Description { get; set; }
        public string ImageUrl { get; set; }
        public List<VenueImage> Images { get; set; }

        public Place()
        {
            Description = new List<string>();
            Images = new List<VenueImage>();
        }
    }

    public class VenueImage
    {
        public string Url { get; set; }
    }
}
