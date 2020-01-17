using System.Web;
using System.Web.Optimization;

namespace WalletWebUtility.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.4.1.min.js",
                        "~/Scripts/jquery-3.4.1.intellisense.js"));

            bundles.Add(new ScriptBundle("~/bundles/customScripts").Include(
                        "~/Scripts/main.js",
                        "~/Scripts/MyScripts.js",
                        "~/Scripts/modal-loading.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/Scripts/bootstrap*",
                         "~/Scripts/modernizr-*"));




            //-------------For CSS --------------------

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap*",
                      "~/Content/modal-loading.css",
                      "~/Content/modal-loading-animate.css",
                      "~/Content/Style.css"));

        }
    }
}