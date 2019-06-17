using System.Web.Optimization;


namespace MySite.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles( BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery", "https://code.jquery.com/jquery-3.4.1.min.js")
                .Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bunbles/bootstrapJs", "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/js/bootstrap.bundle.min.js")
                .Include("~/Scripts/bootstrap.bundle.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/download").Include(
                "~/Scripts/ResumeViews.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/custom.css"));

            bundles.Add(new StyleBundle("~/bundles/bootstrapCss", "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.3.1/css/bootstrap.min.css")
                .Include("~/Content/bootstrap.css"));
#if !debug
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}