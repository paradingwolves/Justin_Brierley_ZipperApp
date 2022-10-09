using System;
using System.ComponentModel.DataAnnotations;

namespace ZipperApp.Models
{
    public class Zipper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Material { get; set; }
        public string TeethSize { get; set; }
        public string Colour { get; set; }
        public decimal Price { get; set; }
    }
}