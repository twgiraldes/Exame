using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Domain
{
    public class laboratorio : BaseEntity
    {
      
        [StringLength(100)]
        public string nome { get; set; }
        [StringLength(500)]
        public string  endereco { get; set; }
        public bool status { get; set; }

    }
}
