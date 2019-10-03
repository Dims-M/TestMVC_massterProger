using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace TestMVC.App_Start
{
    public class BundleConfig
    {
        /// <summary>
        /// Класс по привязки "графических пакетов" стилей, css и т.д.
        /// </summary>
        /// <param name="bundles"></param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            //в обьект bundles(пакеты) добавляем нужные элементы скритов, ссs и другие. И теперь в независимости от версии и при обновлении будут запускатся самыемновые версии.
            bundles.Add(new ScriptBundle("`/bundles/jquery").Include("`/Scripts/jquery-{version}.js"));
           
            //
            bundles.Add(new ScriptBundle("`/bundles/jqueryval").Include("`/Scripts/jquery.unobtrusiv*.",
                "`jquery.validate*"));
            //
            bundles.Add(new ScriptBundle("`/bundles/modernizr").Include("`/Scripts/modernizr-*"));
            // работа с бодстрам стиля и сss
            bundles.Add(new ScriptBundle("`/bundles/bootstrap").Include("`/Scripts/bootstrap.js",
                "`/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("`/Content/css").Include("`/Content/bootstrap.css",
                "`/Content/site.css"));
        }
    }
}