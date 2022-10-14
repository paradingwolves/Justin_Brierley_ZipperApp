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
                        ProductImage = "Ziplo.jpg"
                    },
                    new Zipper
                    {
                        Name = "Ziplo Medium",
                        Material = "Gold",
                        Category = "Fashion",
                        Colour = "Gold",
                        TeethSize = "medium",
                        Price = 349.99M,
                        Rating = 8.9M,
                        ProductImage = "ZiploM.jpg"
                    },
                    new Zipper
                    {
                        Name = "Ziplo Large",
                        Material = "Gold",
                        Category = "Fashion",
                        Colour = "Gold",
                        TeethSize = "large",
                        Price = 399.99M,
                        Rating = 9.25M,
                        ProductImage = "ZiploL.jpg"
                    },

                    new Zipper
                    {
                        Name = "Zypnotic",
                        Material = "Animation",
                        Category = "Magic",
                        Colour = "Brown",
                        TeethSize = "medium",
                        Price = 9999.99M,
                        Rating = 9.9M,
                        ProductImage = "Zypnotic.png"
                    },

                    new Zipper
                    {
                        Name = "Zippin'",
                        Material = "Silver",
                        Category = "Fashion",
                        Colour = "Silver",
                        TeethSize = "small",
                        Price = .05M,
                        Rating = 5.5M,
                        ProductImage = "zippin.jpg"
                    },
                    new Zipper
                    {
                        Name = "Standard Jean Zipper",
                        Material = "Nylon",
                        Category = "Fashion",
                        Colour = "Silver",
                        TeethSize = "small",
                        Price = 0.45M,
                        Rating = 7.5M,
                        ProductImage = "jeanzipper.jpg"
                    },
                    new Zipper
                    {
                        Name = "Purse Zipper",
                        Material = "Nylon",
                        Category = "Fashion",
                        Colour = "black",
                        TeethSize = "small",
                        Price = 3.65M,
                        Rating = 8.12M,
                        ProductImage = "pursezipper.jpg"
                    },
                    new Zipper
                    {
                        Name = "Jacket Zipper",
                        Material = "Polyester",
                        Category = "Fashion",
                        Colour = "Brown",
                        TeethSize = "medium",
                        Price = 1.65M,
                        Rating = 7.65M,
                        ProductImage = "jacketzipper.jpg"
                    },
                    new Zipper
                    {
                        Name = "Wallet Zipper",
                        Material = "Polyester",
                        Category = "Fashion",
                        Colour = "Brown",
                        TeethSize = "small",
                        Price = 2.05M,
                        Rating = 9.5M,
                        ProductImage = "wallet.jpg"
                    },

                    new Zipper
                    {
                        Name = "ZipIts",
                        Material = "Polyester",
                        Category = "Fashion",
                        Colour = "White",
                        TeethSize = "small",
                        Price = .49M,
                        Rating = 8.69M,
                        ProductImage = "zipits.png"
                    }
                ); ;
                context.SaveChanges();
            }
        }
    }
}