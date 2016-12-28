using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Dunfanaghy.Pages
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var source = e as TappedEventArgs;
            if (source != null)
            {
                var param = source.Parameter;
                Navigation.PushAsync(new ListPage(param as string));
            }

        }
    }
}
