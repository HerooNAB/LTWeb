
using NgoAnBinh_Lab456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NgoAnBinh_Lab456.ViewModels
{
    public class CoursesViewModel
    {
        

        public IEnumerable<ApplicationUser> Follows { get; set; }

        public IEnumerable<Following> Fl { get; set; }


        
       
    }
}