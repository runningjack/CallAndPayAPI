using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TransactionRepository : BaseRepository<Transaction>
    {
        public IEnumerable<TransactionViewModel> ListTransactions()
        {
            IQueryable<Transaction> transactions = GetAll();
            IQueryable<TransactionViewModel> allTransactions = from c in transactions
                                                       select new TransactionViewModel()
                                                       {
                                                           Id = c.Id,
                                                           TransId = c.TransId,
                                                           TransType = c.TransType,
                                                           Description = c.Description,
                                                           AccountId = c.AccountId,
                                                           AccountNumber = c.AccountNumber,
                                                           Amount = c.Amount,
                                                           LedgerType = c.LedgerType,
                                                           CreatedAt = c.CreatedAt,
                                                           UpdatedAt = c.UpdatedAt,


                                                       };
            return allTransactions;
        }

        public Transaction FindById(int id)
        {
            return GetById(id);
        }

        public int Create(Transaction transaction)
        {
            return Insert(transaction);
        }

        public int Modify(Transaction transaction)
        {
            return Update(transaction);
        }

        public int Remove(Transaction transaction)
        {
            return Delete(transaction);
        }
    }
}
