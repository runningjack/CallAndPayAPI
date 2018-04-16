using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AgentDeviceViewModel
    {
        public int Id { get; set; }
        public string AgentId { get; set; }
        public string AppKey { get; set; }
        public string DeviceId { get; set; }
        public string DeviceMode { get; set; }
        public string PlaceOfOperation { get; set; }
        public string OperationGpsLocation { get; set; }
        public string Status { get; set; }
        public bool? OnlineStatus { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string Password { get; set; }
    }
}
