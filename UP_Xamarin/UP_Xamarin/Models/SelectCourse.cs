using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_Xamarin.Models
{
    public class SelectCourse
    {
        public int Id { get; set; }
        public List<string> code { get; set; }
        public List<string> courseName { get; set; }
        public List<int> AcademicPeriod { get; set; }
        public List<string> courseFacult { get; set; }
        public List<string> AcademicMonth { get; set; }
        public List<string> courseAvailability { get; set; }
        public List<int> prefer { get; set; }
        public string studentNumber { get; set; }
    }
}
