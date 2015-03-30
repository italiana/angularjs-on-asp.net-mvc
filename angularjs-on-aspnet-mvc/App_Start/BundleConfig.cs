using System.Web;
using System.Web.Optimization;

namespace angularjs_on_aspnet_mvc
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundle/angularjs").Include(
                    "~/Scripts/angular-route.js",
                    "~/Script/"
                ));

            bundles.Add(new ScriptBundle("~/bundle/app").Include(
                    "~/App/app.js"
                ).Include(
                    "~/App/landingPage/landingPageController.js",
                    "~/App/viz/vizController.js"
                ));
            BundleTable.EnableOptimizations = true;
        }
    }
}
