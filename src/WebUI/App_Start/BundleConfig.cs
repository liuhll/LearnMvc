using System.Web.Optimization;

namespace WebUI.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //jquery
            bundles.Add(new ScriptBundle("~/scripts/jquery").Include(
               "~/scripts/jquery-{version}.js"));

            //ace-extra
            bundles.Add(new ScriptBundle("~/scripts/ace/js/ace-extra").Include(
                "ace-extra.min.js"));

            //bootstrap
            bundles.Add(new ScriptBundle("~/scripts/ace/js/bootstrap").Include(
                ""));

            //page specific plugin scripts
            bundles.Add(new ScriptBundle("~/scripts/ace/js/plugin-scripts").Include(
                "bootstrap-tag.min.js",
                "jquery.hotkeys.min.js",
                "bootstrap-wysiwyg.min.js"));
            
            //ace plugin
            bundles.Add(new ScriptBundle("~/scripts/ace/js/ace-plugin-scripts").Include(
                "ace-elements.min.js",
                "ace.min.js"));


        }
    }
}