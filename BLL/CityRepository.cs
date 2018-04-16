using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CityRepository : BaseRepository<City>
    {
        public IEnumerable<CityViewModel> ListCities()
        {
            IQueryable<City> cities = GetAll();
            IQueryable<CityViewModel> allCities = from c in cities
                                                    select new CityViewModel()
                                                    {
                                                        Cities = c.Cities,
                                                        StateId = c.StateId,
                                                        CreatedBy = c.CreatedBy,
                                                        CreatedAt = c.CreatedAt,
                                                        Id = c.Id
                                                    };
            return allCities;
        }


        public City FindById(int id)
        {
            return GetById(id);
        }

        public int Create(City city)
        {
            return Insert(city);
        }
    }
}
