using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using System.Collections.Generic;

namespace Application.Interface
{
    public interface IApplicationExame
    {
        ResponseExameDTO Add(RequestExameDTO obj);

        ResponseExameDTO Update(RequestExameUpdateDTO obj);

        IEnumerable<ResponseExameCompletoDTO> buscaTodos();
        IEnumerable<ResponseExameCompletoDTO> buscaTodosPorNome(string nome);
        ResponseExameDTO Desativar(RequestBaseBuscaPorId obj);
    }
}
