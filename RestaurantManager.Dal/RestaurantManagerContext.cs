using Microsoft.EntityFrameworkCore;

namespace RestaurantManager.Dal
{
    public class RestaurantManagerContext : DbContext
    {
        public RestaurantManagerContext (DbContextOptions<RestaurantManagerContext> options)
            : base(options)
        {
        }
        
    }
}
