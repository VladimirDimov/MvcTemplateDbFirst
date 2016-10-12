namespace TourPoc.Web.Areas.Admin.Models
{
    using System.Collections.Generic;

    public class TranslationModel
    {
        public string Title { get; set; }

        public Dictionary<string, string> Translations { get; set; }
    }
}
