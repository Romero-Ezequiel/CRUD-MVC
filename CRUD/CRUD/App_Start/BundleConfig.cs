using System.Web;
using System.Web.Optimization;

namespace CRUD
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));



            //Plugins en los bundles le agrego el nombre y el contenido
            // el nombre seria "~/Content/Plugins/css" que puede ser cualquier cosa respetando el formato
            bundles.Add(new StyleBundle("~/Content/Plugins/css").Include(
                      "~/Content/DataTable/css/jquery.dataTables.min.css",
                      "~/Content/fontawesome/css/all.css"));

            bundles.Add(new StyleBundle("~/Content/Plugins/js").Include(
              "~/Content/DataTable/js/jquery.dataTables.min.js",
              "~/Content/fontawesome/js/all.js"));

        }
    }
}
