using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using VI.Models;

namespace VI.ApiControllers
{
    public class CityController : ApiController
    {
        public IEnumerable<City> Get(int id)
        {
            var db = new EmpDbContext();
            return db.Cities.Where(x => x.StateId == id).ToList();
        }
    }
}