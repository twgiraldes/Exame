using Application.Interface;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LaboratorioExameController
    {
        private readonly IApplicationLaboratorioExame _applicationLaboratorioExame;

        public LaboratorioExameController(IApplicationLaboratorioExame applicationLaboratorioExame)
        {
            _applicationLaboratorioExame = applicationLaboratorioExame;
        }

        [HttpPost("~/adicionaLaboratorioExame")]
        public ResponseLaboratorioExameDTO adicionaLaboratorioExame([FromBody] RequestLaboratorioExameDTO obj)
        {
            return _applicationLaboratorioExame.Add(obj);
        }

        [HttpPut("~/RemoveLaboratorioExame")]
        public ResponseLaboratorioExameDTO RemoveLaboratorioExame([FromBody] RequestLaboratorioExameDTO obj)
        {
            return _applicationLaboratorioExame.Add(obj);
        }

    }
}
