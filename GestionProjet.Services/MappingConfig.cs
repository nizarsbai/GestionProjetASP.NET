using AutoMapper;
using GestionProject.services.ProdactApi.models.Dtos;
using GestionProjet.Services.ProjectAPI.Models;

namespace GestionProjet.Services.ProjectAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<EmplpoyeDto, Employe>();
                config.CreateMap<Employe, EmplpoyeDto>();
            });
            return mappingConfig;
        }
    }
}
