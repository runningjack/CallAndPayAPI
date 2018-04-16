using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountViewModel
    {
        public AccountViewModel()
        {
            this.Transactions = new HashSet<Transaction>();
        }
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string AccountTitle { get; set; }
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
        public decimal? LedgerBalance { get; set; }
        public decimal? Balance { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
