using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepo
    {
        public AccountMember CheckLogin(string email, string password); 

        public List<ArtTattooStyleDTO> GetArtTattooStyles();

        public List<ArtTattooService> GetServices();

        public List<ArtTattooStyleDTO> SearchStylesByDescription(string description);

        public List<ArtTattooStyleDTO> SearchStylesByLocation(string location);

        public void DeleteAStyle(int styleId);

        public void AddAStyle(ArtTattooStyle style);
    }
}
