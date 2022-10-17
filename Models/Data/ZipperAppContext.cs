using Microsoft.EntityFrameworkCore;
using ZipperApp.Models;

namespace ZipperApp.Data
{
    public class ZipperAppContext : DbContext
    {
        public ZipperAppContext(DbContextOptions<ZipperAppContext> options)
            : base(options)
        {
        }

        public DbSet<Zipper> Zipper { get; set; }
    }
}