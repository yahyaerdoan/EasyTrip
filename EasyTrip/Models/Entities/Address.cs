using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTrip.Models.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AddressLane { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
    }
}