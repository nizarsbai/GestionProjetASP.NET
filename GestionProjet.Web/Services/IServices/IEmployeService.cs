using GestionProjet.Web.Models;

namespace GestionProjet.Web.Services.IServices
{
    public interface IEmployeService:IBaseService
    {
        Task<T> GetAllEmployeAsync<T>();
        Task<T> GetEmployeByIdAsync<T>(int id);
        Task<T> CreateEmployeAsync<T>(EmployeDto employeDto);
        Task<T> UpdateEmployeAsync<T>(EmployeDto employeDto);
        Task<T> DeleteEmployeAsync<T>(int id);
    }
}
