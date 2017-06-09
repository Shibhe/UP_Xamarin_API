using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UP_Xamarin_API.Models
{
    public class UP_XamarinContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public UP_XamarinContext() : base("name=UP_XamarinContext")
        {
        }

        public System.Data.Entity.DbSet<UP_Xamarin_API.Models.Apply> Applies { get; set; }

        public System.Data.Entity.DbSet<UP_Xamarin_API.Controllers.StudentLogin> StudentLogins { get; set; }

        public System.Data.Entity.DbSet<UP_Xamarin_API.Models.SelectCourse> SelectCourses { get; set; }

        public System.Data.Entity.DbSet<UP_Xamarin_API.Models.Subjects> Subjects { get; set; }
    }
}
