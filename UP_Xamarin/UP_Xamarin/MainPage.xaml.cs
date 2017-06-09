using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UP_Xamarin.Views.Application;
using Xamarin.Forms;

namespace UP_Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClickApply(object sender, EventArgs e)
        {
            //Redirect the user to Application form
            await Navigation.PushModalAsync(new ApplyView());
        }
    }
}
