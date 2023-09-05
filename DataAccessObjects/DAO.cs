using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class DAO
    {
        private DAO() { }
        private static readonly object instanceLock = new object();
        private static DAO instance;
        public static DAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new DAO();
                    }
                    return instance;
                }
            }
        }

        public AccountMember CheckLogin(string email, string password)
        {
            try
            {
                AccountMember member = null;
                var context = new ArtTattoo2023DBContext();
                member = context.AccountMembers.
                    FirstOrDefault(mem => mem.EmailAddress.Equals(email) && mem.Password.Equals(password));
                return member;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ArtTattooStyleDTO> GetArtTattooStyles()
        {
            try
            {
                List<ArtTattooStyleDTO> styles = null;
                var context = new ArtTattoo2023DBContext();
                styles = context.ArtTattooStyles.Select(s => new ArtTattooStyleDTO()
                {
                    TattooStyleId = s.TattooStyleId,
                    TattooStyleName = s.TattooStyleName,
                    StyleDescription = s.StyleDescription,
                    StylePrice = s.StylePrice,
                    TattooLocation = s.TattooLocation,
                    ServiceId = s.ServiceId,
                    ServiceName = s.Service.ServiceName
                }).ToList();
                return styles;
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ArtTattooService> GetServices()
        {
            try
            {
                List<ArtTattooService> services = null;
                var context = new ArtTattoo2023DBContext();
                services = context.ArtTattooServices.ToList();
                return services;
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ArtTattooStyleDTO> SearchStylesByLocation(string location)
        {
            try
            {
                List<ArtTattooStyleDTO> styles = null;
                var context = new ArtTattoo2023DBContext();
                styles = context.ArtTattooStyles.Select(s => new ArtTattooStyleDTO()
                {
                    TattooStyleId = s.TattooStyleId,
                    TattooStyleName = s.TattooStyleName,
                    StyleDescription = s.StyleDescription,
                    StylePrice = s.StylePrice,
                    TattooLocation = s.TattooLocation,
                    ServiceId = s.ServiceId,
                    ServiceName = s.Service.ServiceName
                }).Where(s => s.TattooLocation.Contains(location)).ToList();
                return styles;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ArtTattooStyleDTO> SearchStylesByDescription(string description)
        {
            try
            {
                List<ArtTattooStyleDTO> styles = null;
                var context = new ArtTattoo2023DBContext();
                styles = context.ArtTattooStyles.Select(s => new ArtTattooStyleDTO()
                {
                    TattooStyleId = s.TattooStyleId,
                    TattooStyleName = s.TattooStyleName,
                    StyleDescription = s.StyleDescription,
                    StylePrice = s.StylePrice,
                    TattooLocation = s.TattooLocation,
                    ServiceId = s.ServiceId,
                    ServiceName = s.Service.ServiceName
                }).Where(s => s.StyleDescription.Contains(description)).ToList();
                return styles;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteAStyle(int styleId)
        {
            try
            {
                var context = new ArtTattoo2023DBContext();
                ArtTattooStyle deletedStyle = context.ArtTattooStyles.Find(styleId);
                if (deletedStyle != null)
                {
                    context.ArtTattooStyles.Remove(deletedStyle);
                    context.SaveChanges();
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddAStyle(ArtTattooStyle style)
        {
            try
            {
                var context = new ArtTattoo2023DBContext();
                if (style.TattooStyleId < 100) throw new Exception("Field required!");
                bool checkDuplicate = context.ArtTattooStyles.Any(s => s.TattooStyleId ==  style.TattooStyleId);
                if (checkDuplicate) throw new Exception("Duplicate of ID!");
                if (style.StylePrice < 0 || style.StylePrice > 4000000) throw new Exception("Price error!");
                if (style.StyleDescription == null) throw new Exception("Field required!");
                if (style.TattooLocation == null) throw new Exception("Field required!");
                if (style.ServiceId == null) throw new Exception("Field required!");
                bool checkUpper = char.IsUpper(style.TattooStyleName, 0);
                if (checkUpper == false || style.TattooStyleName.Trim().Length < 10 || style.TattooStyleName.Trim().Length > 80)
                    throw new Exception("Style name error!");
                context.ArtTattooStyles.Add(style);
                context.SaveChanges();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
