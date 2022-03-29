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

        public string UsersId { get; set; }
        public Users Users { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Order")]
        public DateTime OrderCreateDate { get; set; }
    }
}
