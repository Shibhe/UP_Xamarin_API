using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UP_Xamarin.Views.Login;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UP_Xamarin.Views.Application
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApplyView : ContentPage
    {
        public ApplyView()
        {
            InitializeComponent();
        }

        public async void Login_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new LoginView());
        }
    }
}
