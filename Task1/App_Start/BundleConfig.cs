using System.Web;
using System.Web.Optimization;

namespace Task1
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

            bundles.Add(new ScriptBundle("~/bundles/chart").Include(
                "~/Scripts/apexcharts.min.js",
                "~/Scripts/chartsRendering.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatable").Include(
                "~/Scripts/jquery.dataTables.min.js",
                "~/Scripts/dataTables.bootstrap4.min.js",
                "~/Scripts/dataTables.buttons.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/stringFormat").Include(
                      "~/Scripts/string.format.js"));

            bundles.Add(new Bundle("~/bundles/ckeditor").Include(
                "~/ckeditor5-build-classic/ckeditor.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                "~/Scripts/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/font-awesome").Include(
                "~/Scripts/font-awesome-4.7.js"));

            bundles.Add(new ScriptBundle("~/bundles/aos").Include(
                "~/aos/node_modules/aos/dist/aos.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/masonry").Include(
                "~/Content/masonry.css"));

            bundles.Add(new StyleBundle("~/Content/datatable").Include(
                "~/Content/jquery.dataTables.min.css"));

            bundles.Add(new StyleBundle("~/Content/aos").Include(
                "~/aos/node_modules/aos/dist/aos.css"));
        }
    }
}
