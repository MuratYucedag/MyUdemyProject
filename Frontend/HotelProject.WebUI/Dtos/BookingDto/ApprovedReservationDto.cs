using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.BookingDto
{
    public class ApprovedReservationDto
    {
        public int BookingID { get; set; }
        public string Status { get; set; }
    }
}
