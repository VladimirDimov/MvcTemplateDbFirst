namespace TourPoc.Web.Areas.Admin.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web.Mvc;
    using DataTables;
    using Models;
    using Multilingual;

    public class TranslationsController : Controller
    {
        private const string TranslationsRelativePath = "~/resources/translations.json";

        public ActionResult Index()
        {
            return this.View();
        }

        [DataTable]
        public ActionResult GetTranslations()
        {
            var translationsResourceProvider = TranslationsResourceProvider.Instance(this.Server.MapPath(TranslationsRelativePath), "en");

            var translations = new List<TranslationModel>();
            foreach (var title in translationsResourceProvider.Translations.Keys)
            {
                translations.Add(new TranslationModel
                {
                    Title = title,
                    Translations = translationsResourceProvider.Translations[title]
                });
            }

            return this.View(translations.AsQueryable());
        }

        public ActionResult AddTranslation(string title)
        {
            var translationsResourceProvider = TranslationsResourceProvider.Instance(this.Server.MapPath(TranslationsRelativePath), "en");
            translationsResourceProvider.AddTranslation(title);

            return new HttpStatusCodeResult(200);
        }

        public ActionResult UpdateTranslation(string title, string language, string translation)
        {
            var translationsResourceProvider = TranslationsResourceProvider.Instance(this.Server.MapPath(TranslationsRelativePath), "en");
            translationsResourceProvider[title, language] = translation;

            return new HttpStatusCodeResult(200);
        }

        public ActionResult RemoveTranslation(string title, string language)
        {
            var translationsResourceProvider = TranslationsResourceProvider.Instance(this.Server.MapPath(TranslationsRelativePath), "en");
            if (title == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); // 400
            }
            else
            {
                translationsResourceProvider.Delete(title, language);
            }

            return new HttpStatusCodeResult(200);
        }
    }
}
