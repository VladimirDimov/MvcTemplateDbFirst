namespace TourPoc.Web
{
    using System.Web.Optimization;

    public static class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterScripts(bundles);
            RegisterStyles(bundles);
        }

        private static void RegisterScripts(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/HeadJS")
                .Include("~/Scripts/modernizr.js"));

            bundles.Add(new Bundle("~/bundles/bottomJS")
                .Include(
                        "~/Scripts/jquery.js",
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/jquery.validate.unobtrusive.js",
                        "~/Scripts/slimmenu.js",
                        "~/Scripts/bootstrap-datepicker.js",
                        "~/Scripts/bootstrap-timepicker.js",
                        "~/Scripts/nicescroll.js",
                        "~/Scripts/dropit.js",
                        "~/Scripts/ionrangeslider.js",
                        "~/Scripts/icheck.js",
                        "~/Scripts/fotorama.js",
                        "~/Scripts/typeahead.js",
                        "~/Scripts/card-payment.js",
                        "~/Scripts/magnific.js",
                        "~/Scripts/owl-carousel.js",
                        "~/Scripts/fitvids.js",
                        "~/Scripts/tweet.js",
                        "~/Scripts/countdown.js",
                        "~/Scripts/gridrotator.js",
                        "~/assets/datatableserverside/datatable.js",
                        "~/Scripts/custom.js"));
        }

        private static void RegisterStyles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css")
                    .Include(
                                "~/Content/bootstrap.css",
                                "~/Content/bootstrap-table.css",
                                "~/Content/font-awesome.css",
                                "~/Content/icomoon.css",
                                "~/Content/styles.css",
                                "~/Content/mystyles.css"));
        }
    }
}
