using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Interfaces;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Domain.Domain;

namespace Adapter.Map
{
    public class MapperLaboratorio : IMapperLaboratorio
    {
        public ResponseLaboratorioDTO MapperToDTO(string mensagem, string codretorno)
        {
            ResponseLaboratorioDTO response = new ResponseLaboratorioDTO();
            response.Mensagem = mensagem;
            response.codRetorno = codretorno;
            return response;
        }

        public laboratorio MapperToEntity(RequestLaboratorioDTO ent)
        {
            laboratorio response = new laboratorio();
            response.status = true;
            response.nome = ent.nome;
            response.endereco = ent.endereco;
            return response;
        }

        public ResponseLaboratorioCompletoDTO MapperToEntityPorId(laboratorio ent)
        {
            ResponseLaboratorioCompletoDTO response = new ResponseLaboratorioCompletoDTO();

            response.nome = ent.nome;
            response.endereco = ent.endereco;
            return response;
        }

        public IEnumerable<ResponseLaboratorioCompletoDTO> MapperToEntityTodos(IEnumerable<laboratorio> ent)
        {
            List<ResponseLaboratorioCompletoDTO> responseFinal = new List<ResponseLaboratorioCompletoDTO>();
            foreach (var item in ent)
            {
                ResponseLaboratorioCompletoDTO response = new ResponseLaboratorioCompletoDTO();
                response.nome = item.nome;
                response.endereco = item.endereco;
                responseFinal.Add(response);
            }
            return responseFinal;
        }
    }
}
