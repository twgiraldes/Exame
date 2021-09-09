using Adapter.Interfaces;
using Application.Interface;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Core.Interface.Services;
using System.Collections.Generic;
using System.Linq;

namespace Application.Service
{
    public class ApplicationExame : IApplicationExame
    {

        public readonly IServiceExame _serviceExame;
        public readonly IMapperExame _mapperExame;

        public ApplicationExame(IServiceExame serviceExame, IMapperExame mapperExame)
        {
            _serviceExame = serviceExame;
            _mapperExame = mapperExame;
        }

        public ResponseExameDTO Add(RequestExameDTO obj)
        {
            ResponseExameDTO response = new ResponseExameDTO();
            if (obj != null)
            {
                try
                {
                    _serviceExame.Add(_mapperExame.MapperToEntity(obj));
                    response = _mapperExame.MapperToDTO("objeto gravado", "201");
                }
                catch
                {
                    response = _mapperExame.MapperToDTO("erro ao gravar o objeto", "422");
                }
            }
            else
            {
                response = _mapperExame.MapperToDTO("objeto em branco", "400");
            }
            return response;
        }

      

        public IEnumerable<ResponseExameCompletoDTO> buscaTodos()
        {
         

            var busca = _serviceExame.buscaAtivos();

            if (busca == null)
                return new List<ResponseExameCompletoDTO>();

            return _mapperExame.MapperToEntityTodos(busca);
        }
        public IEnumerable<ResponseExameCompletoDTO> buscaTodosPorNome(string nome)
        {


            var busca = _serviceExame.buscaPorNome( nome);

            if (busca == null)
                return new List<ResponseExameCompletoDTO>();

            return _mapperExame.MapperToEntityTodos(busca);
        }
        public ResponseExameDTO Desativar(RequestBaseBuscaPorId obj)
        {
           

            ResponseExameDTO response = new ResponseExameDTO();
            if (obj != null)
            {
                try
                {
                    var exame = _serviceExame.buscaPorId(obj.id);
                    exame.status = false;
                    _serviceExame.Update(exame);
                    response = _mapperExame.MapperToDTO("objeto atualizado", "201");
                }
                catch
                {
                    response = _mapperExame.MapperToDTO("erro ao atualizar o objeto", "422");
                }
            }
            else
                response = _mapperExame.MapperToDTO("objeto em branco", "400");

            return response;
        }

        public ResponseExameDTO Update(RequestExameUpdateDTO obj)
        {
            ResponseExameDTO response = new ResponseExameDTO();
            if (obj != null)
            {
                try
                {
                    var exame = _serviceExame.buscaPorId(obj.Id);
                    exame.nome = obj.nome;
                    exame.tipo = obj.tipo;
                    _serviceExame.Update(exame);
                    response = _mapperExame.MapperToDTO("objeto atualizado", "201");
                }
                catch
                {
                    response = _mapperExame.MapperToDTO("erro ao atualizar o objeto", "422");
                }
            }
            else
                response = _mapperExame.MapperToDTO("objeto em branco", "400");

            return response;
        }

       
    }
}
