using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPlus1017.Entities
{
    public class Car
    {
        public int Id { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int YearProduction { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        public TypeCondition Condition { get; set; }
        [Required]
        public TypeFuel Fuel { get; set; }
        [Required]
        public int HorsePowers { get; set; }
        [Required]
        [Display(Name = "Thumbnal Image Path")]
        public string ThumbnailImagePath { get; set; }
    }
}
