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
    public class ExameController
    {
        private readonly IApplicationExame _applicationExame;

        public ExameController(IApplicationExame applicationExame)
        {
            _applicationExame = applicationExame;
        }

        [HttpPost("~/adicionaExame")]
        public ResponseExameDTO adicionaExame([FromBody] RequestExameDTO obj)
        {
            return _applicationExame.Add(obj);
        }

        [HttpPut("~/atualizaExame")]
        public ResponseExameDTO atualizaExame([FromBody] RequestExameUpdateDTO obj)
        {
            return _applicationExame.Update(obj);
        }

        [HttpGet("~/buscatodosExamesAtivos")]
        public List<ResponseExameCompletoDTO> buscatodosExames()
        {
            return (List<ResponseExameCompletoDTO>)_applicationExame.buscaTodos();
        }

       

        [HttpPut("~/desativarExame")]
        public ResponseExameDTO desativarLaboratorio([FromBody] RequestBaseBuscaPorId obj)
        {
            return _applicationExame.Desativar(obj);
        }
    }
}
