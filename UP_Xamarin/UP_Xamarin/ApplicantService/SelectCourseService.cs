using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UP_Xamarin.Models;

namespace UP_Xamarin.ApplicantService
{
    class SelectCourseService
    {
        public async Task PostCourseAsync(SelectCourse model)
        {
            RestClient<SelectCourse> restClient = new RestClient<SelectCourse>();

            var Course = await restClient.PostAsync(model);
        }

        //This method will return the List of Courses you selected
        public async Task<List<SelectCourse>> GetCourseAsync()
        {
            RestClient<SelectCourse> restClient = new RestClient<SelectCourse>();

            var CourseList = await restClient.GetAsync();

            return CourseList;
        }

        //This method will PUT new course
        public async Task PutCourseAsync(int id, SelectCourse model)
        {
            RestClient<SelectCourse> restClient = new RestClient<SelectCourse>();

            var Course = await restClient.PutAsync(id, model);
        }

        //Delete Course
        public async Task DeleteCourseAsync(int id, SelectCourse model)
        {
            RestClient<SelectCourse> restClient = new RestClient<SelectCourse>();

            var Course = await restClient.DeleteAsync(id, model);
        }
    }
}
