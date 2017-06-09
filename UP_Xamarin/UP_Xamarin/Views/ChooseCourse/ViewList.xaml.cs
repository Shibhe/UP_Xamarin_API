using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UP_Xamarin.Views.ChooseCourse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewList : ContentPage
    {
        public ViewList()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ChooseCourseView());
        }
    }
}
