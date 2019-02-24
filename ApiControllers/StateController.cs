using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using VI.Models;

namespace VI.ApiControllers
{
    public class StateController : ApiController
    {
        public IEnumerable<State> Get(int id)
        {
            var db = new EmpDbContext();
            return db.States.Where(x => x.CountryId == id).ToList();
        }

    }
}