using GestionProject.services.ProdactApi.models.Dtos;

namespace GestionProject.services.ProdactApi.Repository
{
    public interface IEmployeRepository
    {
        Task<IEnumerable<EmplpoyeDto>> GetEmploye();
        Task<EmplpoyeDto> GetEmplpoyeById(int productId);
        Task<EmplpoyeDto> CreateUpdateEmplpoye(EmplpoyeDto emplpoyeDto);
        Task<bool> DeleteEmplpoye(int employeId);
    }
}
