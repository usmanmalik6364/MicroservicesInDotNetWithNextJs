using CarAuctionSite.AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarAuctionSite.AuctionService.Data
{
    public class AuctionDbContext : DbContext
    {
        public AuctionDbContext(DbContextOptions<AuctionDbContext> options) : base(options)
        {
        }

        public DbSet<Auction> Auctions { get; set; }
    }
}
