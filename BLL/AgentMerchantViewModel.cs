using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AgentMerchantViewModel
    {
        public int Id { get; set; }
        public string AppKey { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public int? City { get; set; }
        public int? State { get; set; }
        public string DeviceNumber { get; set; }
        public string DeviceMacAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool? Status { get; set; }
        public bool? IsView { get; set; }
        public string UserName { get; set; }
        public string Picture { get; set; }
        public string KeySalt { get; set; }
        public string Pin { get; set; }
        public string Password { get; set; }
        public string PlaceOfOperation { get; set; }
        public string OperationGpsLocation { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
