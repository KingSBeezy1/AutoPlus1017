using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPlus1017.Entities
{
    public enum TypeCondition
    {
        [Display(Name = "Чисто нов")]
        ЧистоНов,
        [Display(Name = "Използван")]
        Използван
    }
}
