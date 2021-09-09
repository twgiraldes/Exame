using System;
using System.Collections.Generic;
using System.Text;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Domain.Domain;

namespace Adapter.Interfaces
{
    public interface IMapperLaboratorio
    {
        laboratorio MapperToEntity(RequestLaboratorioDTO ent);

        ResponseLaboratorioDTO MapperToDTO(string mensagem, string codretorno);

        IEnumerable<ResponseLaboratorioCompletoDTO> MapperToEntityTodos(IEnumerable<laboratorio> ent);

        ResponseLaboratorioCompletoDTO MapperToEntityPorId(laboratorio ent);
    }
}
