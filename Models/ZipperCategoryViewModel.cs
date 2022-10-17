using Microsoft.AspNetCore.Http; // Allows access to IFormFile
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZipperApp.Models
{
    public class ZipperCategoryViewModel
    {
        public List<Zipper> Zippers { get; set; }
        public SelectList Category { get; set; }
        public string ZipperCategory { get; set; }
        public string SearchString { get; set; }
        //[Display(Name = "Product Image")]
       // public IFormFile ProductImage { get; set; }
    }
}