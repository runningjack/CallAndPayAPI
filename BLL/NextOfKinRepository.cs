using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NextOfKinRepository : BaseRepository<NextOfKin>
    {
        public IEnumerable<NextOfKinViewModel> ListCustomerNextOfKins()
        {
            IQueryable<NextOfKin> nextOfKins = GetAll();
            IQueryable<NextOfKinViewModel> allNextOfKins = from c in nextOfKins
                                                           select new NextOfKinViewModel()
                                                         {
                                                             Id = c.Id,
                                                             CustomerId = c.CustomerId,
                                                             FirstName = c.FirstName,
                                                             LastName = c.LastName,
                                                             Address = c.Address,
                                                             Phone = c.Phone,
                                                             Email = c.Email,
                                                             Gender = c.Gender,
                                                             Relationship = c.Relationship,
                                                             KeySalt = c.KeySalt,
                                                             
                                                         };
            return allNextOfKins;
        }

        public NextOfKin FindById(int id)
        {
            return GetById(id);
        }

        public int Create(NextOfKin nextOfKin)
        {
            return Insert(nextOfKin);
        }

        public int Modify(NextOfKin nextOfKin)
        {
            return Update(nextOfKin);
        }

        public int Remove(NextOfKin nextOfKin)
        {
            return Delete(nextOfKin);
        }
    }
}
