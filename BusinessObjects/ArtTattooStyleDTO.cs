using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class ArtTattooStyleDTO
    {
        public int TattooStyleId { get; set; }
        public string TattooStyleName { get; set; }
        public string StyleDescription { get; set; }
        public double? StylePrice { get; set; }
        public string TattooLocation { get; set; }
        public string ServiceId { get; set; }
        public string ServiceName { get; set; }
    }
}
