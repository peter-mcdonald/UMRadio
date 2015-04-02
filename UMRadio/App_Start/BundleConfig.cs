using System.Web.Optimization;

namespace UMRadio.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var siteScripts = new ScriptBundle("~/bundles/site");
            siteScripts.Include("~/Scripts/jquery-2.1.3.js");

            bundles.Add(siteScripts);

            var siteCss = new StyleBundle("~/Content/css");
            siteCss.Include("~/Content/site.css");

            bundles.Add(siteCss);

#if !DEBUG 
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}