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
    public class LaboratorioController
    {
        private readonly IApplicationLaboratorio _applicationLaboratorio;

        public LaboratorioController(IApplicationLaboratorio applicationLaboratorio)
        {
            _applicationLaboratorio = applicationLaboratorio;
        }

        [HttpPost("~/adicionaLaboratorio")]
        public ResponseLaboratorioDTO adicionaLaboratorio([FromBody] RequestLaboratorioDTO obj)
        {
            return _applicationLaboratorio.Add(obj);
        }

        [HttpPut("~/atualizaLaboratorio")]
        public ResponseLaboratorioDTO atualizaLaboratorio([FromBody] RequestLaboratorioUpdateDTO obj)
        {
            return _applicationLaboratorio.Update(obj);
        }

        [HttpGet("~/buscatodosLaboratoriosAtivos")]
        public List<ResponseLaboratorioCompletoDTO> buscatodosLaboratorios()
        {
            return (List<ResponseLaboratorioCompletoDTO>)_applicationLaboratorio.buscaTodos();
        }

        [HttpGet("~/buscaLaboratoriosPorNome")]
        public List<ResponseLaboratorioCompletoDTO> buscaExamePorNome(string nome)
        {
            return (List<ResponseLaboratorioCompletoDTO>)_applicationLaboratorio.buscaTodosPorNome(nome);
        }

        [HttpGet("~/buscaLaboratoriosPorExame")]
        public List<ResponseLaboratorioCompletoDTO> buscaLabPorExame(string nome)
        {
            return (List<ResponseLaboratorioCompletoDTO>)_applicationLaboratorio.buscaTodosPorExame(nome);
        }
        [HttpPut("~/desativarLaboratorio")]
        public ResponseLaboratorioDTO desativarLaboratorio([FromBody] RequestBaseBuscaPorId obj)
        {
            return _applicationLaboratorio.Desativar(obj);
        }
    }
}
