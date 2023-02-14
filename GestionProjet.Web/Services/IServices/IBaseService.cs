using GestionProjet.Web.Models;

namespace GestionProjet.Web.Services.IServices
{
    public interface IBaseService :IDisposable
    {
        public ResponseDto ResponseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
