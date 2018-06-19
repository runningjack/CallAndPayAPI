using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public IEnumerable<CustomerViewModel> ListCustomers()
        {
            IQueryable<Customer> customers = GetAll();
            IQueryable<CustomerViewModel> allCustomers = from c in customers
                                                         select new CustomerViewModel()
                                                               {
                                                                   Id = c.Id,
                                                                   FirstName = c.FirstName,
                                                                   LastName = c.LastName,
                                                                   MiddleName = c.MiddleName,
                                                                   Company = c.Company,
                                                                   Address = c.Address,
                                                                   CityId = c.CityId,
                                                                   StateId = c.StateId,
                                                                   Phone = c.Phone,
                                                                   Email = c.Email,
                                                                   Gender = c.Gender,
                                                                   TitleId = c.TitleId,
                                                                   Occupation = c.Occupation,
                                                                   Pin = c.Pin,
                                                                   Picture = c.Picture,
                                                                   Password = c.Password,
                                                                   AgentId = c.AgentId,
                                                                   CreatedAt = c.CreatedAt,
                                                                   UpdatedAt = c.UpdatedAt,
                                                                   CreatedBy = c.CreatedBy,
                                                               };
            return allCustomers;
        }

        public Customer FindById(int id)
        {
            return GetById(id);
        }

        public int Create(Customer customer)
        {
            customer.CreatedAt = DateTime.Now;
            customer.UpdatedAt = DateTime.Now;
            return Insert(customer);
        }

        public int Modify(Customer customer)
        {
            customer.UpdatedAt = DateTime.Now;
            return Update(customer);
        }

        public int Remove(Customer account)
        {
            return Delete(account);
        }
    }
}
