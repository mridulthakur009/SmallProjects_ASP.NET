using System.Web;
using System.Web.Optimization;

namespace _6.MVC_MulTable_Val_MulLayout_PartialView_
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/ContentYeti/css").Include(
                      "~/Content/bootstrap-yeti.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/ContentDarkly/css").Include(
                      "~/Content/bootstrap-darkly.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/ContentLumen/css").Include(
                      "~/Content/bootstrap-lumen.css",
                      "~/Content/site.css"));
        }
    }
}
