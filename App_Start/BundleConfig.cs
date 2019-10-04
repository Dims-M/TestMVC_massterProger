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
        /// </summary>~
        /// <param name="bundles"></param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            //в обьект bundles(пакеты) добавляем нужные элементы скритов, ссs и другие. И теперь в независимости от версии и при обновлении будут запускатся самыемновые версии.
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            //jquery Validation и jquery.unobtrusive
            //Validation - Этот плагин jQuery делает простую проверку формы на стороне клиента тривиальной, предлагая множество опций для настройки. 
            //unobtrusive - работа с нтм5 и его элемантаи
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.unobtrusive*",
                                                                        "~/Scripts/jquery.validate*"));
            
            //Modernizr-это небольшая и простая библиотека JavaScript, которая помогает вам использовать преимущества новых веб-технологий (CSS3, HTML5)
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-{version}.js"));
           
            // работа с бодстрам стиля и сss
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/Content/css").Include("~/Content/bootstrap.css"));
            bundles.Add(new ScriptBundle("~/Content/css").Include("~/Content/Site.css"));
            //bundles.Add(new ScriptBundle("~/Content/css").Include("~/Content/bootstrap.css",
            //                                                      "~/Content/Site.css"));
        }
    }
}