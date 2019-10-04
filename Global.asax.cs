using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
<<<<<<< HEAD

=======
>>>>>>> parent of dfbded6... РЅРµ  СЂР°Р±РѕС‚Р°РµС‚ СЃРµСЂРІРµСЂ Р±РµСЃРєРѕРЅРµС‡РЅР°СЏ Р·Р°РіСЂСѓР·РєР°
//using TestMVC.App_Start;

namespace TestMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //подключение пакетов из апп дата.
            App_Start.BundleConfig.RegisterBundles(BundleTable.Bundles); // подключение настроек по умолчанию.
           // BundleConfig.RegisterBundles(BundleTable.Bundles); // подключение настроек по умолчанию.


        }
    }
}
