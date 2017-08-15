using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacePage.Models
{
    public class User
    {
        public string UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name
        {
            get
            {
                return String.Concat(FirstName, LastName);
            }
            set
            {
                var split = value.Split(' ');
                FirstName = split[0];
                LastName = split[1];
            }
        }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        public LocationData Location { get; set; } = new LocationData();
        public ProfilePicture picture { get; set; }

    }
}
