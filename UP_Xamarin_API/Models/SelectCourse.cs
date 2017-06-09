using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UP_Xamarin_API.Models
{
    public class SelectCourse
    {
        [Key]
        public int Id { get; set; }
        public List<string> code { get; set; }
        public List<string> courseName { get; set; }
        public List<int> AcademicPeriod { get; set; }
        public List<string> courseFacult { get; set; }
        public List<string> AcademicMonth { get; set; }
        public List<string> courseAvailability { get; set; }
        public string studentNumber { get; set; }
    }
}