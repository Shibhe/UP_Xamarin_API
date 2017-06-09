using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UP_Xamarin.ApplicantService;
using UP_Xamarin.Models;
using Xamarin.Forms;

namespace UP_Xamarin.ModelView
{
    class ModelView 
    {
        private ApplicantModel Applicant = new ApplicantModel();
        private List<ApplicantModel> _ApplicantList = new List<ApplicantModel>();   

        public List<ApplicantModel> ApplicantList
        {
            get
            {
                return _ApplicantList;
            }
            set
            {
                _ApplicantList = value;
            }
        }
        /// <summary>
        /// </summary>
        /// Get and Set a new user then 
        public ApplicantModel addApplicant
        {
            get
            {
                return Applicant;
            }
            set
            {
                Applicant = value;
            }
        }

        public Command PostCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var appliService = new applicantService();
                    await appliService.PostApplicantAsync(addApplicant);
                });
            }
        }

       
        public Command PutCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var appliService = new applicantService();
                    await appliService.PutApplicantAsync(addApplicant.AppID, addApplicant);
                });
            }
        }

        public Command DeleteCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var appliService = new applicantService();
                    await appliService.PutApplicantAsync(addApplicant.AppID, addApplicant);
                });
            }
        }

        //public event PropertyChangedEventHandler PropertyChanged;
    }
}
