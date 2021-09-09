using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Interfaces;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Domain.Domain;

namespace Adapter.Map
{
    public class MapperExame : IMapperExame
    {
        public ResponseExameDTO MapperToDTO(string mensagem, string codretorno)
        {
            ResponseExameDTO response = new ResponseExameDTO();
              response.mensagem = mensagem;
            response.codretorno = codretorno;
            return response;
        }

        public exame MapperToEntity(RequestExameDTO ent)
        {
            exame response = new exame();
            response.status = true;
            response.nome = ent.nome;
            response.tipo = ent.tipo;
            return response;
        }

        public ResponseExameCompletoDTO MapperToEntityPorId(exame ent)
        {
            ResponseExameCompletoDTO response = new ResponseExameCompletoDTO();

            response.nome = ent.nome;
            response.tipo = ent.tipo;
            return response;
        }

        public IEnumerable<ResponseExameCompletoDTO> MapperToEntityTodos(IEnumerable<exame> ent)
        {
            List<ResponseExameCompletoDTO> responseFinal = new List<ResponseExameCompletoDTO>();
            foreach (var item in ent)
            {
                ResponseExameCompletoDTO response = new ResponseExameCompletoDTO();
                response.nome = item.nome;
                response.tipo = item.tipo;
                responseFinal.Add(response);
            }
            return responseFinal;
        }
    }
}
