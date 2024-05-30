using static Csharpadvanced2024.Models.Location;
namespace Csharpadvanced2024.Models.DTOs
{
    public class SearchRequestDTO
    {
        public FeaturesEnum? Features { get; set; }
        public LocationType? Type { get; set; }
        public int? Rooms { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
    }
}