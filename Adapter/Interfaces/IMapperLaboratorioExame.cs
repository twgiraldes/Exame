using System;
using System.Collections.Generic;
using System.Text;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Domain.Domain;

namespace Adapter.Interfaces
{
    public interface IMapperLaboratorioExame
    {
        laboratorioExame MapperToEntity(RequestLaboratorioExameDTO ent);

        ResponseLaboratorioExameDTO MapperToDTO(string mensagem, string codretorno);

        IEnumerable<ResponseLaboratorioExameCompletoDTO> MapperToEntityTodos(IEnumerable<laboratorioExame> ent);

        ResponseLaboratorioExameCompletoDTO MapperToEntityPorId(laboratorioExame ent);
    }
}
