using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{

    public class Product
    {
        [BindNever]
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Max number of characters is 20")]
        public string Name { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "The price can not be a negative value.")]
        public int Price { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Shelf { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Number of items can not be a negative value.")]
        public int Count { get; set; }

        [StringLength(30, ErrorMessage = "Max number of characters is 30")]
        public string Description { get; set; }
    }
}
