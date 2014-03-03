using System.Web;
using System.Web.Optimization;

namespace WhosGiggin
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
            //            "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/whosgiggin.jquery.validate.overrides.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                   "~/Scripts/moment.min.js",
                "~/Scripts/bootstrap-datetimepicker.min.js"
             
                ));
            bundles.Add(new ScriptBundle("~/bundles/whosgiggin").Include(
                "~/Scripts/whosgiggin.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //supports old browsers with bootstrap
            bundles.Add(new ScriptBundle("~/bundles/oldIEBrowsersSupport").Include(
            "~/Scripts/respond.js",
            "~/Scripts/html5shiv.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/Content/Bootstrap/bootstrap.css",
                    "~/Content/Bootstrap/bootstrap-theme.css",
                    "~/Content/bootstrap-datetimepicker.min.css",
                    "~/Content/site.css"
                ));




        }
    }
}