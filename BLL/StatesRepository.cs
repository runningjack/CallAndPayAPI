using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class StatesRepository : BaseRepository<State>
    {
        public IEnumerable<StatesViewModel> ListStates()
        {
            IQueryable<State> states = GetAll();
            IQueryable<StatesViewModel> allStates = from c in states
                                              select new StatesViewModel()
                                              {
                                                  States = c.States,
                                                  CreatedAt = c.CreatedAt,
                                                  CreatedBy = c.CreatedBy,
                                                  Id = c.Id
                                              };
            return allStates;
        }

        public State FindById(int id)
        {
            return GetById(id);
        }

        public int Create(State state)
        {
            return Insert(state);
        }

        public int Update(State state)
        {
            return Update(state);
        }
    }
}
