using System.Web.Http;
using VI.Models;
using VI.ViewModels;

namespace VI.ApiControllers
{
    public class EmployeeController : ApiController
    {
        private EmpDbContext db = new EmpDbContext();

        public IHttpActionResult Post([FromBody]EmployeeViewModel e)
        {
            var emp = new Employee()
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                Address = e.Address,
                Zip = e.Zip,
                CountryId = e.CountryId,
                StateId = e.StateId,
                CityId = e.CityId
            };
            emp.PayMaster.Add(new PayMaster()
            {
                Basic = e.Basic,
                HRA = e.HRA,
                DA = e.DA
            });

            db.Employees.Add(emp);
            db.SaveChanges();
            return Ok();
        }
    }
}