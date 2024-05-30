using Csharpadvanced2024.Data;
using Csharpadvanced2024.Models;
using Csharpadvanced2024.Models.DTOs;
using Csharpadvanced2024.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Csharpadvanced2024.Services
{
    public class SearchService : ISearchService
    {
        private readonly AppDbContext _context;
        private readonly ILocationRepo _locationRepo;
        public SearchService(ILocationRepo locationRepo, AppDbContext context)
        {
            _locationRepo = locationRepo;
            _context = context;
        }
        public async Task<IEnumerable<Location>> SearchLocationsAsync(SearchRequestDTO searchRequestDTO, CancellationToken cancellationToken)
        {
            var query = _context.Locations.AsQueryable();

            if (searchRequestDTO.Features.HasValue)
            {
                query = query.Where(l => l.Features.HasFlag((Location.FeaturesEnum)searchRequestDTO.Features));
            }

            if (searchRequestDTO.Type.HasValue)
            {
                query = query.Where(l => l.Type == (Location.LocationType)searchRequestDTO.Type);
            }

            if (searchRequestDTO.Rooms.HasValue)
            {
                query = query.Where(l => l.Rooms == searchRequestDTO.Rooms);
            }

            if (searchRequestDTO.MaxPrice.HasValue)
            {
                query = query.Where(l => l.PricePerDay <= searchRequestDTO.MaxPrice);
            }

            if (searchRequestDTO.MinPrice.HasValue)
            {
                query = query.Where(l => l.PricePerDay >= searchRequestDTO.MinPrice);
            }

            var locations = await query.ToListAsync(cancellationToken);
            return locations;
        }
    }
}
