using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using System.Collections.Generic;

namespace Application.Interface
{
    public interface IApplicationLaboratorioExame
    {
        ResponseLaboratorioExameDTO Add(RequestLaboratorioExameDTO obj);

        ResponseLaboratorioExameDTO remove(RequestLaboratorioExameDTO obj);


    }
}
