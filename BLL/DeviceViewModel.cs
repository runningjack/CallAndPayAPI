using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeviceViewModel
    {
        public int Id { get; set; }
        public string DeviceMacAddress { get; set; }
        public string OSType { get; set; }
        public string OSVersion { get; set; }
        public string IMEINumber { get; set; }
        public bool? HasCardReader { get; set; }
        public bool? HasCamera { get; set; }
        public bool? HasPrinter { get; set; }
        public bool? HasNFC { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
