using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using System.Collections.Generic;

namespace Application.Interface
{
    public interface IApplicationLaboratorio
    {
        ResponseLaboratorioDTO Add(RequestLaboratorioDTO obj);

        ResponseLaboratorioDTO Update(RequestLaboratorioUpdateDTO obj);

        IEnumerable<ResponseLaboratorioCompletoDTO> buscaTodos();
        IEnumerable<ResponseLaboratorioCompletoDTO> buscaTodosPorNome(string nome);
         IEnumerable<ResponseLaboratorioCompletoDTO> buscaTodosPorExame(string nomeExame);
        ResponseLaboratorioDTO Desativar(RequestBaseBuscaPorId obj);
    }
}
