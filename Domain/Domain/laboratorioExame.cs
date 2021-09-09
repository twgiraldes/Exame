using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Domain
{
    public class laboratorioExame : BaseEntity
    {
     
        public long IdLaboratorio { get; set; }
        public long IdExame { get; set; }

    }
}
