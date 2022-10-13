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
                        Price = 299.99M,
                        Rating = 9.5M,
                        Image = "~/img/"
                    },
                    new Zipper
                    {
                        Name = "Ziplo Medium",
                        Material = "Gold",
                        Category = "Fashion",
                        Colour = "Gold",
                        TeethSize = "medium",
                        Price = 349.99M,
                        Rating = 8.9M
                    },
                    new Zipper
                    {
                        Name = "Ziplo Large",
                        Material = "Gold",
                        Category = "Fashion",
                        Colour = "Gold",
                        TeethSize = "large",
                        Price = 399.99M,
                        Rating = 9.25M
                    },

                    new Zipper
                    {
                        Name = "Zypnotic",
                        Material = "Crystal",
                        Category = "Magic",
                        Colour = "Purple",
                        TeethSize = "medium",
                        Price = 9999.99M,
                        Rating = 9.9M
                    },

                    new Zipper
                    {
                        Name = "Zippin'",
                        Material = "Plastic",
                        Category = "Sandwich Bag",
                        Colour = "Red",
                        TeethSize = "none",
                        Price = .05M,
                        Rating = 5.5M
                    },
                    new Zipper
                    {
                        Name = "Standard Jean Zipper",
                        Material = "Nylon",
                        Category = "Fashion",
                        Colour = "Brown",
                        TeethSize = "small",
                        Price = 3.45M,
                        Rating = 7.5M
                    },
                    new Zipper
                    {
                        Name = "Sweater Zipper",
                        Material = "Nylon",
                        Category = "Fashion",
                        Colour = "black",
                        TeethSize = "small",
                        Price = 3.65M,
                        Rating = 8.12M
                    },
                    new Zipper
                    {
                        Name = "Shoe Zipper",
                        Material = "Polyester",
                        Category = "Fashion",
                        Colour = "black",
                        TeethSize = "extra-small",
                        Price = 1.65M,
                        Rating = 7.65M
                    },
                    new Zipper
                    {
                        Name = "Boot Zipper",
                        Material = "Polyester",
                        Category = "Fashion",
                        Colour = "black",
                        TeethSize = "small",
                        Price = 2.05M,
                        Rating = 9.5M
                    },

                    new Zipper
                    {
                        Name = "ZipIts",
                        Material = "Polyester",
                        Category = "Fashion",
                        Colour = "White",
                        TeethSize = "small",
                        Price = 1.99M,
                        Rating = 8.69M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}