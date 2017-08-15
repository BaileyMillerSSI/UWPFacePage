using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacePage.Models
{
    public class LocationData
    {
        public int LocationId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public string Street { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}
