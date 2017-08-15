using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacePage.Models
{
    public class ProfilePicture
    {
        public int ProfilePictureId { get; set; }
        public string fileExtension { get; set; }
        public byte[] profilePicture { get; set; }
    }
}
