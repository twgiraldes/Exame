using System;
using System.Collections.Generic;
using System.Text;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Domain.Domain;

namespace Adapter.Interfaces
{
    public interface IMapperExame
    {
        exame MapperToEntity(RequestExameDTO ent);

        ResponseExameDTO MapperToDTO(string mensagem, string codretorno);

        IEnumerable<ResponseExameCompletoDTO> MapperToEntityTodos(IEnumerable<exame> ent);

        ResponseExameCompletoDTO MapperToEntityPorId(exame ent);
    }
}
