using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ZipperApp.Models
{
    public class ZipperCategoryViewModel
    {
        public List<Zipper> Zippers { get; set; }
        public SelectList Category { get; set; }
        public string ZipperCategory { get; set; }
        public string SearchString { get; set; }
    }
}