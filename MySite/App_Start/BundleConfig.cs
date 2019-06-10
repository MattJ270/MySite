using System.Web;
using System.Web.Optimization;


namespace MySite.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles( BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/bootstrap.bundle.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/download").Include(
                "~/Scripts/ResumeViews.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/custom.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}