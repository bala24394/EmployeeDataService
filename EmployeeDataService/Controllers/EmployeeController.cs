using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeDataService.Controllers
{
    public class EmployeeController : ApiController
    {
        [Authorize]
        public IEnumerable<Employee> GET()
        {
            using (EmployeeEntities entities = new EmployeeEntities())
            {
                return entities.Employees.ToList();
            }

        }

    }
}
