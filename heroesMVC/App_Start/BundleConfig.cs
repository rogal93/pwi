using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace heroesMVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Theme/js/skorka").Include(
                "~/Theme/js/jquery.js",
                "~/Theme/js/jqBootstrapValidation.js",
                "~/Theme/js/agency.js",
                "~/Theme/js/cbpAnimatedHeader.js",
                "~/Theme/js/classie.js",
                "~/Theme/js/contact_me.js",
                "~/Theme/js/bootstrap.js",
                "~/Theme/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Theme/css/style").Include(
                "~/Theme/css/bootstrap.css",
                "~/Theme/css/bootstrap.min.css",
                "~/Theme/css/agency.css",
                "~/Theme/css/myStyleSheet.css"));
        }
    }
}
