using System.Web.Optimization;

namespace Ideact.Web.Application
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/assets/js/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/assets/js/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/theme").Include(
                        "~/assets/js/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css/bootstrap").Include(
                      "~/assets/css/bootstrap.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/Content/css/font-awesome").Include(
                      "~/assets/css/font-awesome.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/Content/css/theme").Include(
                      "~/assets/css/custom.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/Content/css/animate").Include(
                      "~/assets/css/animate.css", new CssRewriteUrlTransform()));
        }
    }
}