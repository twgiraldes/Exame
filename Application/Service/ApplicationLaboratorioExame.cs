using Adapter.Interfaces;
using Application.Interface;
using ApplicationDTO.RequestDTO;
using ApplicationDTO.ResponseDTO;
using Core.Interface.Services;
using System.Collections.Generic;
using System.Linq;

namespace Application.Service
{
    public class ApplicationLaboratorioExame : IApplicationLaboratorioExame
    {

        public readonly IServicelaboratorioExame _serviceLaboratorioExame;
        public readonly IMapperLaboratorioExame _mapperLaboratorioExame;

        public ApplicationLaboratorioExame(IServicelaboratorioExame serviceLaboratorioExame, IMapperLaboratorioExame mapperLaboratorioExame)
        {
            _serviceLaboratorioExame = serviceLaboratorioExame;
            _mapperLaboratorioExame = mapperLaboratorioExame;
        }

        public ResponseLaboratorioExameDTO Add(RequestLaboratorioExameDTO obj)
        {
            ResponseLaboratorioExameDTO response = new ResponseLaboratorioExameDTO();
            if (obj != null)
            {
                try
                {
                    _serviceLaboratorioExame.Add(_mapperLaboratorioExame.MapperToEntity(obj));
                    response = _mapperLaboratorioExame.MapperToDTO("objeto gravado", "201");
                }
                catch
                {
                    response = _mapperLaboratorioExame.MapperToDTO("erro ao gravar o objeto", "422");
                }
            }
            else
            {
                response = _mapperLaboratorioExame.MapperToDTO("objeto em branco", "400");
            }
            return response;
        }

     

        public ResponseLaboratorioExameDTO remove(RequestLaboratorioExameDTO obj)
        {
         
            ResponseLaboratorioExameDTO response = new ResponseLaboratorioExameDTO();
            if (obj != null)
            {
                try
                {
                    var labExame = _serviceLaboratorioExame.buscaLaboratorioExame(obj.idLaboratorio, obj.idExame);
                    _serviceLaboratorioExame.Remove(_mapperLaboratorioExame.MapperToEntity(obj));
                    response = _mapperLaboratorioExame.MapperToDTO("objeto removido", "201");
                }
                catch
                {
                    response = _mapperLaboratorioExame.MapperToDTO("erro ao remover o objeto", "422");
                }
            }
            else
                response = _mapperLaboratorioExame.MapperToDTO("objeto em branco", "400");

            return response;
        }
    }
}
