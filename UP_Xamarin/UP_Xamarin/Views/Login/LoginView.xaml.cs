using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UP_Xamarin.Views.Application;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UP_Xamarin.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public async void Apply_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new ApplyView());
        }
    }
}
