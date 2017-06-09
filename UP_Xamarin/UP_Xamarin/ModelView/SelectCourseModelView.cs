using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UP_Xamarin.ApplicantService;
using UP_Xamarin.Models;
using Xamarin.Forms;
using static Android.Media.Audiofx.BassBoost;
using static Android.Provider.UserDictionary;

namespace UP_Xamarin.ModelView
{
    class SelectCourseModelView
    {
        private SelectCourse Course = new SelectCourse();
        private List<SelectCourse> _CourseList = new List<SelectCourse>();

        public List<SelectCourse> CourseList
        {
            get
            {
                return _CourseList;
            }
            set
            {
                _CourseList = value;
            }
        }
        /// <summary>
        /// </summary>
        /// Get and Set a new user then 
        public SelectCourse SelectedCourse
        {
            get
            {
                return Course;
            }
            set
            {
                Course = value;
            }
        }

        public Command PostCourseCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var CourseService = new SelectCourseService();
                    await CourseService.PostCourseAsync(SelectedCourse);
                });
            }
        }


        public Command PutCourseCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var CourseService = new SelectCourseService();
                    await CourseService.PutCourseAsync(SelectedCourse.Id, SelectedCourse);
                });
            }
        }

        public Command DeleteCourseCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var CourseService = new SelectCourseService();
                    await CourseService.DeleteCourseAsync(SelectedCourse.Id, SelectedCourse);
                });
            }
        }

        private async Task GetcourseList()
        {
            var courseList = new SelectCourseService();

            _CourseList = await courseList.GetCourseAsync();
        }
        
    }
}
