using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_DemoProject
{
    public class CustomerController
    {
        public ActionResult getCustomers(int id)
        {
            if (id == 0)
                return new NotFound();
            return new Ok();
        }
    }
    public class ActionResult { }
    public class Ok : ActionResult { }
    public class NotFound : ActionResult { }
}
