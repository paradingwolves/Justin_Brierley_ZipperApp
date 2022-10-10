using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ZipperApp.Data;
using System;
using System.Linq;

namespace ZipperApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ZipperAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ZipperAppContext>>()))
            {
                // Look for any movies.
                if (context.Zipper.Any())
                {
                    return;   // DB has been seeded
                }

                context.Zipper.AddRange(
                    new Zipper
                    {
                        Name = "Ziplo",
                        Material = "Gold",
                        Category = "Fashion",
                        Colour = "Gold",
                        TeethSize = "small",
                        Price = 299.99M
                    },
                    new Zipper
                    {
                        Name = "Ziplo Medium",
                        Material = "Gold",
                        Category = "Fashion",
                        Colour = "Gold",
                        TeethSize = "medium",
                        Price = 349.99M
                    },
                    new Zipper
                    {
                        Name = "Ziplo Large",
                        Material = "Gold",
                        Category = "Fashion",
                        Colour = "Gold",
                        TeethSize = "large",
                        Price = 399.99M
                    },

                    new Zipper
                    {
                        Name = "Zypnotic",
                        Material = "Crystal",
                        Category = "Magic",
                        Colour = "Purple",
                        TeethSize = "medium",
                        Price = 9999.99M
                    },

                    new Zipper
                    {
                        Name = "Zippin'",
                        Material = "Plastic",
                        Category = "Sandwich Bag",
                        Colour = "Red",
                        TeethSize = "none",
                        Price = .05M
                    },

                    new Zipper
                    {
                        Name = "ZipIts",
                        Material = "aluminum",
                        Category = "Recreational",
                        Colour = "Grey",
                        TeethSize = "small",
                        Price = 8.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}