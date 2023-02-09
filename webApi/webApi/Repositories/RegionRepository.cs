using Microsoft.EntityFrameworkCore;
using webApi.Data;
using webApi.Models.Domain;

namespace webApi.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly WebApiDbContext webApiDbContext;

        public RegionRepository(WebApiDbContext webApiDbContext)
        {
            this.webApiDbContext = webApiDbContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await webApiDbContext.Regions.ToListAsync();
        }
    }
}
