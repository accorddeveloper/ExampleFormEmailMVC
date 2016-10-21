using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace ExampleFormEmailMVC.App_Start
{
    public class BundleConfig
    {
       public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            var jqueryCdnPath = "https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js";
            var tetherCdnPath = "https://cdnjs.cloudflare.com/ajax/libs/tether/1.3.7/js/tether.min.js";
            var bootstrapCdnPath = "https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.5/js/bootstrap.min.js";

            bundles.Add(new ScriptBundle("~/bundles/jquery", 
                jqueryCdnPath).Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/tether",tetherCdnPath).Include("~/Scripts/tether/tether.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap", bootstrapCdnPath).Include("~/Scripts/bootstrap.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}