using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountRepository : BaseRepository<Account>
    {
        public IEnumerable<AccountViewModel> ListAccounts()
        {
            IQueryable<Account> accounts = GetAll();
            IQueryable<AccountViewModel> allAccounts = from c in accounts
                                                       select new AccountViewModel()
                                                           {
                                                               Id = c.Id,
                                                               CustomerId = c.CustomerId,
                                                               AccountTitle = c.AccountTitle,
                                                               AccountNumber = c.AccountNumber,
                                                               LedgerBalance = c.LedgerBalance,
                                                               Balance = c.Balance,
                                                               StartDate = c.StartDate,
                                                               EndDate = c.EndDate,
                                                               CreatedAt = c.CreatedAt,
                                                               UpdatedAt = c.UpdatedAt,
                                                               Transactions = c.Transactions,
                                                               

                                                           };
            return allAccounts;
        }

        public Account FindById(int id)
        {
            return GetById(id);
        }

        public int Create(Account account)
        {
            return Insert(account);
        }

        public int Update(Account account)
        {
            return Update(account);
        }
    }
}
