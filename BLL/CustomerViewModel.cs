using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int? TitleId { get; set; }
        public string Occupation { get; set; }
        public string Pin { get; set; }
        public string Picture { get; set; }
        public string Password { get; set; }
        public int? AgentId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual AgentMerchant AgentMerchant { get; set; }
        public virtual City City { get; set; }
        public virtual State State { get; set; }
    }
}
