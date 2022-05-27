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
        [Required(ErrorMessage = "Моля въведи марката на автомобила")]
        [Display(Name = "Марка")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Моля въведи модела на автомобила")]
        [Display(Name = "Модел")]
        public string Model { get; set; }
        
        [Required(ErrorMessage = "Моля въведи описание за автомобила")]
        [Display(Name = "Описание")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Моля въведи годината на автомобила")]
        [Display(Name = "Година на производство")]
        public int YearProduction { get; set; }
        
        [Required(ErrorMessage = "Моля въведи цвета на автомобила")]
        [Display(Name = "Цвят")]
        public string Color { get; set; }
        [Required(ErrorMessage = "Моля въведи цена на автомобила")]
        [Display(Name = "Цена")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Моля въведи какво е състоянието на автомобила")]
        [Display(Name = "Състояние на автомобила")]
        public TypeCondition Condition { get; set; }
        [Required(ErrorMessage = "Моля въведи  инжекциона на автомобила")]
        [Display(Name = "Вид гориво")]
        public TypeFuel Fuel { get; set; }
        [Required(ErrorMessage = "Моля въведи конските сили на автомобила")]
        [Display(Name = "Конски сили")]
        public int HorsePowers { get; set; }
        [Required(ErrorMessage = "Моля въведи снимка на автомобила")]
        [Display(Name = "Път към снимката")]
        public string ThumbnailImagePath { get; set; }
    }
}
