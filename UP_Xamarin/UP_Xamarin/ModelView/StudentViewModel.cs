using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UP_Xamarin.ApplicantService;
using UP_Xamarin.Models;
using Xamarin.Forms;

namespace UP_Xamarin.ModelView
{
    public class StudentViewModel
    {
        LoginModel loginDetails = new LoginModel();
        StudentLoginService student = new StudentLoginService();
        public Command LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await student.LoginAsync(loginDetails.Username, loginDetails.Password);
                });
            }
        }
    } 
}
