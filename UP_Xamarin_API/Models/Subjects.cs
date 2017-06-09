using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UP_Xamarin_API.Models
{
    public class Subjects
    {
        [Key]
        public int Id { get; set; }
        public List<string> subjCode { get; set; }
        public List<string> subjName { get; set; }
        public List<float> subjCost { get; set; }
        
    }
}