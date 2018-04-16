using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeviceRepository : BaseRepository<Device>
    {
        public IEnumerable<DeviceViewModel> ListDevices()
        {
            IQueryable<Device> devices = GetAll();
            IQueryable<DeviceViewModel> allDevices = from c in devices
                                                    select new DeviceViewModel()
                                                    {
                                                        Id = c.Id,
                                                        DeviceMacAddress = c.DeviceMacAddress,
                                                        OSType = c.OSType,
                                                        OSVersion = c.OSVersion,
                                                        IMEINumber = c.IMEINumber,
                                                        HasCardReader = c.HasCardReader,
                                                        HasCamera = c.HasCamera,
                                                        HasPrinter = c.HasPrinter,
                                                        HasNFC = c.HasNFC,
                                                        Status = c.Status,
                                                        CreatedAt = c.CreatedAt,
                                                        UpdatedAt = c.UpdatedAt,
                                                        CreatedBy = c.CreatedBy,
                                                    };
            return allDevices;
        }

        public Device FindById(int id)
        {
            return GetById(id);
        }

        public int Create(Device device)
        {
            return Insert(device);
        }

        public int Update(State state)
        {
            return Update(state);
        }
    }
}
