using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication2
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Код, выполняемый при запуске приложения
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
    //public class Payment
    //{
    //    public int PaymentId { get; set; }
    //    public int CustomerId { get; set; }
    //    public string PaymentDate { get; set; }
    //    public float Sum { get; set; }
    //}
    //class UserContext : DbContext
    //{
    //    public UserContext()
    //        : base("DbConnection")
    //    { }

    //    public DbSet<Payment> Payments { get; set; }
    //}

}