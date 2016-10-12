namespace TourPoc.Web.ViewModels.Home
{
    using TourPoc.Data.Models;
    using TourPoc.Web.Infrastructure.Mapping;

    public class JokeCategoryViewModel : IMapFrom<JokeCategory>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
