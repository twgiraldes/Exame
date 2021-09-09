using Adapter.Interfaces;
using Application.Interface;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Core.Interface.Services;
using System.Collections.Generic;
using System.Linq;

namespace Application.Service
{
    public class ApplicationLaboratorio : IApplicationLaboratorio
    {

        public readonly IServicelaboratorio _serviceLaboratorio;
        public readonly IMapperLaboratorio _mapperLaboratorio;

        public ApplicationLaboratorio(IServicelaboratorio serviceLaboratorio, IMapperLaboratorio mapperLaboratorio)
        {
            _serviceLaboratorio = serviceLaboratorio;
            _mapperLaboratorio = mapperLaboratorio;
        }

        public ResponseLaboratorioDTO Add(RequestLaboratorioDTO obj)
        {
            ResponseLaboratorioDTO response = new ResponseLaboratorioDTO();
            if (obj != null)
            {
                try
                {
                    _serviceLaboratorio.Add(_mapperLaboratorio.MapperToEntity(obj));
                    response = _mapperLaboratorio.MapperToDTO("objeto gravado", "201");
                }
                catch
                {
                    response = _mapperLaboratorio.MapperToDTO("erro ao gravar o objeto", "422");
                }
            }
            else
            {
                response = _mapperLaboratorio.MapperToDTO("objeto em branco", "400");
            }
            return response;
        }

      

        public IEnumerable<ResponseLaboratorioCompletoDTO> buscaTodos()
        {
          

            var busca = _serviceLaboratorio.buscaAtivos();

            if (busca == null)
                return new List<ResponseLaboratorioCompletoDTO>();

            return _mapperLaboratorio.MapperToEntityTodos(busca);
        }

        public IEnumerable<ResponseLaboratorioCompletoDTO> buscaTodosPorNome(string nome)
        {


            var busca = _serviceLaboratorio.buscaPorNome(nome);

            if (busca == null)
                return new List<ResponseLaboratorioCompletoDTO>();

            return _mapperLaboratorio.MapperToEntityTodos(busca);
        }

        public IEnumerable<ResponseLaboratorioCompletoDTO> buscaTodosPorExame(string nomeExame)
        {


            var busca = _serviceLaboratorio.buscaPorExame(nomeExame);

            if (busca == null)
                return new List<ResponseLaboratorioCompletoDTO>();

            return _mapperLaboratorio.MapperToEntityTodos(busca);
        }

        public ResponseLaboratorioDTO Desativar(RequestBaseBuscaPorId obj)
        {
            ResponseLaboratorioDTO response = new ResponseLaboratorioDTO();
            if (obj != null)
            {
                try
                {
                    var lab = _serviceLaboratorio.buscaPorId(obj.id);
                    lab.status = false;
                    _serviceLaboratorio.Update(lab);
                    response = _mapperLaboratorio.MapperToDTO("objeto atualizado", "201");
                }
                catch
                {
                    response = _mapperLaboratorio.MapperToDTO("erro ao atualizar o objeto", "422");
                }
            }
            else
                response = _mapperLaboratorio.MapperToDTO("objeto em branco", "400");

            return response;
        }

        public ResponseLaboratorioDTO Update(RequestLaboratorioUpdateDTO obj)
        {
            ResponseLaboratorioDTO response = new ResponseLaboratorioDTO();
            if (obj != null)
            {
                try
                {
                    var lab = _serviceLaboratorio.buscaPorId(obj.Id);
                    lab.nome = obj.nome;
                    lab.endereco = obj.endereco;

                    _serviceLaboratorio.Update(lab);
                    response = _mapperLaboratorio.MapperToDTO("objeto atualizado", "201");
                }
                catch
                {
                    response = _mapperLaboratorio.MapperToDTO("erro ao atualizar o objeto", "422");
                }
            }
            else
                response = _mapperLaboratorio.MapperToDTO("objeto em branco", "400");

            return response;
        }


    }
}
