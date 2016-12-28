using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Dunfanaghy.Pages
{
    public partial class PlacePage : ContentPage
    {
        public PlacePage(Place place)
        {
            InitializeComponent();
            this.BindingContext = place;

            StackLayout1.Children.Add(new Label
            {
                Text = place.Name,
                FontSize = 24,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            });

            foreach (var description in place.Description)
            {
                StackLayout1.Children.Add(new Label { Text = description, FontSize = 12 });
            }
        }
    }
}
