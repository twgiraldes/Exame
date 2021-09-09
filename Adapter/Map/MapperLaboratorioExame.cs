using System;
using System.Collections.Generic;
using System.Text;
using Adapter.Interfaces;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Domain.Domain;

namespace Adapter.Map
{
    public class MapperLaboratorioExame : IMapperLaboratorioExame
    {
        public ResponseLaboratorioExameDTO MapperToDTO(string mensagem, string codretorno)
        {
            ResponseLaboratorioExameDTO response = new ResponseLaboratorioExameDTO();
            response.Mensagem = mensagem;
            response.codRetorno = codretorno;
            return response;
        }

        public laboratorioExame MapperToEntity(RequestLaboratorioExameDTO ent)
        {
            laboratorioExame response = new laboratorioExame();
         
            response.IdExame = ent.idExame;
            response.IdLaboratorio = ent.idLaboratorio;
            return response;
        }

        public ResponseLaboratorioExameCompletoDTO MapperToEntityPorId(laboratorioExame ent)
        {
            ResponseLaboratorioExameCompletoDTO response = new ResponseLaboratorioExameCompletoDTO();

          //  response. = ent.nome;
         //   response.endereco = ent.endereco;
            return response;
        }

        public IEnumerable<ResponseLaboratorioExameCompletoDTO> MapperToEntityTodos(IEnumerable<laboratorioExame> ent)
        {
            List<ResponseLaboratorioExameCompletoDTO> responseFinal = new List<ResponseLaboratorioExameCompletoDTO>();
            foreach (var item in ent)
            {
                ResponseLaboratorioExameCompletoDTO response = new ResponseLaboratorioExameCompletoDTO();
             //   response.nome = item.nome;
             //   response.endereco = item.endereco;
                responseFinal.Add(response);
            }
            return responseFinal;
        }
    }
}
