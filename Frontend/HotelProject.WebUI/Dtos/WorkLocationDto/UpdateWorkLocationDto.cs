using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.WorkLocationDto
{
    public class UpdateWorkLocationDto
    {
        public int WorkLocationID { get; set; }
        public string WorkLocationName { get; set; }
        public string WorkLocationCity { get; set; }
    }
}
