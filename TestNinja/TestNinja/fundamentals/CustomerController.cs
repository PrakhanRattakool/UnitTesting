namespace TestNinja.Fundamentals
{
    public class CustomerController
    {
        public ActionResult GetCustomer(int id)
        {
            if (id == 0)
                return new NotFound();

            return new ok();
        }
    }

    public class ActionResult { }
    
    public class NotFound : ActionResult { }

    public class ok : ActionResult { }
}