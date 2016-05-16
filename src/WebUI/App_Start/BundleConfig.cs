using System.Web.Optimization;

namespace WebUI
{
    public class BundleConfig
    {
        private const string GentelellaSrc = "~/Content/components/gentelella/production/{0}/{1}";


        public static void RegisterBundles(BundleCollection bundles)
        {
            /*js*/

            //jquery
            bundles.Add(new ScriptBundle(string.Format(GentelellaSrc, "js", "jquery")).Include(
                string.Format(GentelellaSrc, "js", "jquery.min.js")));

            //nprogress
            bundles.Add(new ScriptBundle(string.Format(GentelellaSrc, "js", "nprogress")).Include(
                string.Format(GentelellaSrc, "js", "nprogress.js")));

            //bootstrap
            bundles.Add(new ScriptBundle(string.Format(GentelellaSrc, "js", "bootstrap")).Include(
              string.Format(GentelellaSrc, "js", "bootstrap.min.js")));

            //custom
            bundles.Add(new ScriptBundle(string.Format(GentelellaSrc, "js", "custom")).Include(
             string.Format(GentelellaSrc, "js", "custom.js")));

            // js gentelella
            bundles.Add(new ScriptBundle(string.Format(GentelellaSrc, "js", "gentelella")).Include(
                //gauge
                string.Format(GentelellaSrc, "js/gauge", "gauge.min.js"),
                //progressbar
                string.Format(GentelellaSrc, "js/progressbar", "bootstrap-progressbar.min.js"),
                //icheck
                string.Format(GentelellaSrc, "js/icheck", "icheck.min.js"),
                //daterangepicker.js
                string.Format(GentelellaSrc, "js/moment", "moment.min.js"),
                string.Format(GentelellaSrc, "js/datepicker", "daterangepicker.js"),
                //chart
                string.Format(GentelellaSrc, "js/chartjs", "chart.min.js"),
                //custom
                string.Format(GentelellaSrc, "js/custom", "custom.js")
                ));

            //flot js
            bundles.Add(new ScriptBundle(string.Format(GentelellaSrc, "js", "flot")).Include(
                string.Format(GentelellaSrc, "js", "excanvas.min.js"),
                string.Format(GentelellaSrc, "js/flot", "jquery.flot.js"),
                string.Format(GentelellaSrc, "js/flot", "jquery.flot.pie.js"),
                string.Format(GentelellaSrc, "js/flot", "jquery.flot.orderBars.js"),
                string.Format(GentelellaSrc, "js/flot", "jquery.flot.time.min.js"),
                string.Format(GentelellaSrc, "js/flot", "date.js"),
                string.Format(GentelellaSrc, "js/flot", "jquery.flot.spline.js"),
                string.Format(GentelellaSrc, "js/flot", "jquery.flot.stack.js"),
                string.Format(GentelellaSrc, "js/flot", "curvedLines.js"),
                string.Format(GentelellaSrc, "js/flot", "jquery.flot.resize.js")
                ));

            //excanvas
            bundles.Add(new ScriptBundle(string.Format(GentelellaSrc, "js", "excanvas")).Include(
                string.Format(GentelellaSrc, "js/maps", "js/excanvas.min.js")
                ));

            //worldmap
            bundles.Add(new ScriptBundle(string.Format(GentelellaSrc, "js", "maps")).Include(
                string.Format(GentelellaSrc, "js/maps", "jquery-jvectormap-2.0.3.min.js"),
                string.Format(GentelellaSrc, "js/maps", "gdp-data.js"),
                string.Format(GentelellaSrc, "js/maps", "jquery-jvectormap-world-mill-en.js"),
                string.Format(GentelellaSrc, "js/maps", "jquery-jvectormap-us-aea-en.js")
            ));

            //pace
            bundles.Add(new ScriptBundle(string.Format(GentelellaSrc, "js", "pace")).Include(
                string.Format(GentelellaSrc, "js/pace", "pace.min.js")
                ));

            //js/skycons/skycons.min.js
            bundles.Add(new ScriptBundle(string.Format(GentelellaSrc, "js", "skycons")).Include(
                string.Format(GentelellaSrc, "js/skycons", "skycons.min.js")
                ));


            /*css*/

            //Bootstrap core CSS 
            bundles.Add(new StyleBundle(string.Format(GentelellaSrc, "css", "bootstrap")).Include(
                string.Format(GentelellaSrc, "css", "bootstrap.min.css"),
                //fonts/css/font-awesome.min.css
                string.Format(GentelellaSrc, "fonts/css", "font-awesome.min.css"),
                //css/animate.min.css
                string.Format(GentelellaSrc, "css", "animate.min.css")
                ));

            //Custom styling plus plugins
            bundles.Add(new StyleBundle(string.Format(GentelellaSrc, "css", "custom")).Include(
                string.Format(GentelellaSrc, "css", "custom.css"),
                string.Format(GentelellaSrc, "css/maps/", "jquery-jvectormap-2.0.3.css"),
                string.Format(GentelellaSrc, "css/icheck/flat", "green.css"),
                string.Format(GentelellaSrc, "css", "floatexamples.css")
                ));

        }
    }
}