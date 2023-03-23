using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
        public string WorkDepartment { get; set; }
        public int WorkLocationID { get; set; }
        public WorkLocation WorkLocation { get; set; }
    }
}
