using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerAccountRepository : BaseRepository<CustomerAccount>
    {
        public IEnumerable<CustomerAccountViewModel> ListCustomerAccounts()
        {
            IQueryable<CustomerAccount> customerAccounts = GetAll();
            IQueryable<CustomerAccountViewModel> allCustomerAccounts = from c in customerAccounts
                                                    select new CustomerAccountViewModel()
                                                    {
                                                        Id = c.Id,
                                                        CustomerId = c.CustomerId,
                                                        ProductId = c.ProductId,
                                                    };
            return allCustomerAccounts;
        }

        public CustomerAccount FindById(int id)
        {
            return GetById(id);
        }

        public int Create(CustomerAccount customerAccount)
        {
            return Insert(customerAccount);
        }

        public int Update(CustomerAccount customerAccount)
        {
            return Update(customerAccount);
        }
    }
}
