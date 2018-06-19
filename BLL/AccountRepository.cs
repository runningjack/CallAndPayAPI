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

        public  Account GetByAccountNumber(string title)
        {
            IQueryable<Account> accounts = GetAll();
            Account account =  (from e in accounts
                    where e.AccountNumber == title
                    select e).SingleOrDefault();
            return account;
        }

        public int Create(Account account)
        {
            account.AccountNumber = generateAccount();
            account.CreatedAt = DateTime.Now;
            account.UpdatedAt = DateTime.Now;
            account.Balance = 0;
            account.LedgerBalance = 0;
           
            return Insert(account);
        }

        public int Modify(Account account)
        {
            account.UpdatedAt = DateTime.Now;
            return Update(account);
        }

        public int Remove(Account account)
        {
            return Delete(account);
        }



        private string generateAccount()
        {
            Random R = new Random();
            return ((long)R.Next(0, 100000) * (long)R.Next(0, 100000)).ToString().PadLeft(10, '0');
        }
    }
}
