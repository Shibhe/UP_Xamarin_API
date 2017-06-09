using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UP_Xamarin_API.Models
{
    public class Apply
    {
        [Key]
        public int AppID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string IDNo { get; set; }
        public string Initials { get; set; }
        public string Gender { get; set; }
        public string mStatus { get; set; }
        public string HLanguage { get; set; }
        public string PrevSchool { get; set; }
        public string ExamNum { get; set; }
        public string Title { get; set; }
    }
}