using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Domain
{
    public class BaseEntity
    {
        [Key]
        public long id { get; set; }
    }
}
