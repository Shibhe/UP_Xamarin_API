using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UP_Xamarin_API.Controllers
{
    public class StudentLogin
    {
        [Key]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int Id { get; set; }
    }

}