using System.Web.Optimization;

namespace WebUI.App_Start
{
    public class BundleConfig
    {
        private const string GentelellaJsSrc = "~/Content/gentelella-1.1.0/js/{0}";
        private const string GentelellaCssSrc = "";
        private const string BootstrapJsSrc = "";
        private const string BootstrapCssSrc = "";


        public static void RegisterBundles(BundleCollection bundles)
        {
            //jquery
            bundles.Add(new ScriptBundle("~/scripts/jquery").Include(
               "~/scripts/jquery-{version}.js"));

            //nprogress
            bundles.Add(new ScriptBundle(string.Format(GentelellaJsSrc, "nprogress")).Include(
                string.Format(GentelellaJsSrc, "nprogress.js")));


            //bootstrap
            bundles.Add(new ScriptBundle("~/scripts/ace/js/bootstrap").Include(
                ""));

            //gauge
            bundles.Add(new ScriptBundle("~/scripts/ace/js/gauge").Include(
                "gauge.min.js"));

            //bootstrap_progress 
            bundles.Add(new ScriptBundle("~/scripts/ace/js/bootstrap-progress").Include(
                "bootstrap-progressbar.min.js"));

            //icheck
            bundles.Add(new ScriptBundle("~/scripts/ace/js/icheck").Include(
                "icheck"));

            //ace plugin
            bundles.Add(new ScriptBundle("~/scripts/ace/js/ace-plugin-scripts").Include(
                "ace-elements.min.js",
                "ace.min.js"));


        }
    }
}