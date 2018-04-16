using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AgentDeviceRepository : BaseRepository<AgentDevice>
    {
        public IEnumerable<AgentDeviceViewModel> ListAgentDevices()
        {
            IQueryable<AgentDevice> agentDevices = GetAll();
            IQueryable<AgentDeviceViewModel> allAgentDevices = from c in agentDevices
                                                     select new AgentDeviceViewModel()
                                                     {
                                                         Id = c.Id,
                                                         AgentId = c.AgentId,
                                                         AppKey = c.AppKey,
                                                         DeviceId = c.DeviceId,
                                                         DeviceMode = c.DeviceMode,
                                                         PlaceOfOperation = c.PlaceOfOperation,
                                                         OperationGpsLocation = c.OperationGpsLocation,
                                                         OnlineStatus = c.OnlineStatus,
                                                         Password = c.Password,
                                                         Status = c.Status,
                                                         CreatedAt = c.CreatedAt,
                                                         UpdatedAt = c.UpdatedAt,
                                                         CreatedBy = c.CreatedBy,
                                                     };
            return allAgentDevices;
        }

        public AgentDevice FindById(int id)
        {
            return GetById(id);
        }

        public int Create(AgentDevice agentDevice)
        {
            return Insert(agentDevice);
        }

        public int Update(AgentDevice agentDevice)
        {
            return Update(agentDevice);
        }
    }
}
