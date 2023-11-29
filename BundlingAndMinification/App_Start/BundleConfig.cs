using System.Web;
using System.Web.Optimization;

namespace BundlingAndMinification
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations= true;
            bundles.UseCdn= true;

            var mainJS = new ScriptBundle("~/main-js");
            mainJS.IncludeDirectory("~/wwwroot/General" , "*.js");

            var accountJS = new ScriptBundle("~/account-js");
            accountJS.IncludeDirectory("~/wwwroot/account", "*.js");

            var jquery = new ScriptBundle("~/jquery", "https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js");
            
            jquery.Include("~/Scripts/jquery-{version}.js");
            jquery.CdnFallbackExpression = "window.jQuery";
            
            bundles.Add(mainJS);
            bundles.Add(accountJS);
            bundles.Add(jquery);

            var bootstrap = new StyleBundle("~/bootstrap", "https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.4.1/js/bootstrap.min.js");
            bootstrap.Include("~/Content/bootstrap.css");
            var mainCss = new StyleBundle("~/main-css");
            mainCss.Include("~/content/Site.css");

            bundles.Add(bootstrap);
            bundles.Add(mainCss);

            // mainJS.Include("~/wwwroot/General/app*");
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
        }
    }
}
