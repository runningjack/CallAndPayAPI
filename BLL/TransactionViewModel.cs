using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TransactionViewModel
    {
        public int Id { get; set; }
        public string TransId { get; set; }
        public string Description { get; set; }
        public string AccountNumber { get; set; }
        public int? AccountId { get; set; }
        public string TransType { get; set; }
        public string LedgerType { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
