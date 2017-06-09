using Plugin.RestClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UP_Xamarin.Models;

namespace UP_Xamarin.ApplicantService
{
    class applicantService
    {
        //This Method add a student/applicant
        public async Task PostApplicantAsync(ApplicantModel model)
        {
            RestClient<ApplicantModel> restClient = new RestClient<ApplicantModel>();

            var applicant = await restClient.PostAsync(model);
        }

        //This method will return the List of Applicant/Students
        public async Task<List<ApplicantModel>> GetApplicantAsync()
        {
            RestClient<ApplicantModel> restClient = new RestClient<ApplicantModel>();

            var applicantList = await restClient.GetAsync();

            return applicantList;
        }

        //This method will PUT Applicant/Students 
        public async Task PutApplicantAsync(int id, ApplicantModel model)
        {
            RestClient<ApplicantModel> restClient = new RestClient<ApplicantModel>();

            var applicant = await restClient.PutAsync(id, model);
        }

        //Authorize = Admin
        public async Task DeleteApplicantAsync(int id, ApplicantModel model)
        {
            RestClient<ApplicantModel> restClient = new RestClient<ApplicantModel>();

            var applicant = await restClient.DeleteAsync(id, model);
        }
    }
}
