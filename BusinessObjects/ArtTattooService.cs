using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class ArtTattooService
    {
        public ArtTattooService()
        {
            ArtTattooStyles = new HashSet<ArtTattooStyle>();
        }

        public string ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceNote { get; set; }
        public string ServiceAddress { get; set; }
        public string TelephoneNumber { get; set; }

        public virtual ICollection<ArtTattooStyle> ArtTattooStyles { get; set; }
    }
}
