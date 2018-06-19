using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AgentMerchantRepository : BaseRepository<AgentMerchant>
    {
        public IEnumerable<AgentMerchantViewModel> ListAgentMerchants()
        {
            IQueryable<AgentMerchant> agentMerchants = GetAll();
            IQueryable<AgentMerchantViewModel> allAgentMerchants = from c in agentMerchants
                                                                   select new AgentMerchantViewModel()
                                                                   {
                                                                       Id = c.Id,
                                                                       AppKey = c.AppKey,
                                                                       Company = c.Company,
                                                                       Description = c.Description,
                                                                       Location = c.Location,
                                                                       Address = c.Address,
                                                                       City = c.City,
                                                                       State = c.State,
                                                                       PlaceOfOperation = c.PlaceOfOperation,
                                                                       OperationGpsLocation = c.OperationGpsLocation,
                                                                       DeviceNumber = c.DeviceNumber,
                                                                       DeviceMacAddress = c.DeviceMacAddress,
                                                                       Phone = c.Phone,
                                                                       Email = c.Email,
                                                                       Password = c.Password,
                                                                       IsView = c.IsView,
                                                                       UserName = c.UserName,
                                                                       Picture = c.Picture,
                                                                       KeySalt = c.KeySalt,
                                                                       Pin = c.Pin,
                                                                       Status = c.Status,
                                                                       CreatedAt = c.CreatedAt,
                                                                       UpdatedAt = c.UpdatedAt,
                                                                       CreatedBy = c.CreatedBy,
                                                                   };
            return allAgentMerchants;
        }

        public AgentMerchant FindById(int id)
        {
            return GetById(id);
        }

        public int Create(AgentMerchant agentDevice)
        {
            return Insert(agentDevice);
        }

        public int Modify(AgentMerchant agentDevice)
        {
            return Update(agentDevice);
        }

    }
}
