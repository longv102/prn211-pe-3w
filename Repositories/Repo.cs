using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class Repo : IRepo
    {
        public void AddAStyle(ArtTattooStyle style) => DAO.Instance.AddAStyle(style);

        public AccountMember CheckLogin(string email, string password) => DAO.Instance.CheckLogin(email, password);

        public void DeleteAStyle(int styleId)
            => DAO.Instance.DeleteAStyle(styleId);

        public List<ArtTattooStyleDTO> GetArtTattooStyles() => DAO.Instance.GetArtTattooStyles();

        public List<ArtTattooService> GetServices() => DAO.Instance.GetServices();

        public List<ArtTattooStyleDTO> SearchStylesByDescription(string description)
            => DAO.Instance.SearchStylesByDescription(description);

        public List<ArtTattooStyleDTO> SearchStylesByLocation(string location)
            => DAO.Instance.SearchStylesByLocation(location);
    }
}
