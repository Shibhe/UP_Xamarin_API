using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UP_Xamarin.ModelView;
using UP_Xamarin.Views.ChooseCourse;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UP_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseCourseView : ContentPage
    {
        SelectCourseModelView list = new SelectCourseModelView();
        public ChooseCourseView()
        {
            InitializeComponent();
        }

        private async void CourseList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ViewList());
        }

        private void SearchBar_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
           
        }

        public class searItem
        {
            public string SName
            {
                get;
                set;
            }
        }

        //void OnSearchBarTextChanged(object sender, TextChangedEventArgs args)
        //{
        //    FilterNames();
        //}
        //void OnSearchBarButtonPressed(object sender, EventArgs args)
        //{
        //    FilterNames();
        //}
        //private void FilterNames()
        //{
        //    string filter = Search.Text;
           
        //    if (string.IsNullOrWhiteSpace(filter))
        //    {
                
        //    }
        //    else
        //    {
        //        list.ItemsSource = list.Where(x => x.SName.ToLower().Contains(filter.ToLower()));
        //    }
        //    list.EndRefresh();
        //}
    }
}
