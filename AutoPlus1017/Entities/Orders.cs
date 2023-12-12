using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPlus1017.Entities
{
    public class Orders
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Моля въведи ID-то на потребителя")]
        [Display(Name = "ID на потребителя")]
        public string UsersId { get; set; }
        
        [Display(Name = "ID-та на потребители")]
        public Users Users { get; set; }
        [Display(Name = "ID на автомобила")]
        public int CarId { get; set; }

        
        [Display(Name = "Кола")]
        public Car Car { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата на поръчката")]
        
        
        public DateTime OrderCreateDate { get; set; }
    }
}
