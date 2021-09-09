using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Domain
{
    public class exame : BaseEntity
    {
   
        [StringLength(100)]
        public string nome { get; set; }
        [StringLength(20)]
        public string  tipo { get; set; }
        public bool status { get; set; }

    }
}
