using System.Web;
using System.Web.Optimization;
using System.Web.UI.WebControls;

namespace MY_DEMO_BLOG
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css", "~/Content/kwicks-slider.css", "~/Content/ie.css", "~/Content/responsive.css", "~/Content/docs.css", "~/Content/touchTouch.css"
                      , "~/Content/zocial.css", "~/Content/bootstrap-social.css", "~/Content/font-awesome.css"));

            bundles.Add(new ScriptBundle("~/Scripts/_references.js"));

            bundles.Add(new ScriptBundle("~/Scripts/custom.js"));

            bundles.Add(new ScriptBundle("~/Scripts/html5.js"));

            bundles.Add(new ScriptBundle("~/Scripts/superfish.js"));

            bundles.Add(new ScriptBundle("~/Scripts/touchTouch.jquery.js"));
            bundles.Add(new ScriptBundle("~/Scripts/touchTouch.jquery.js"));


        }
    }
}
