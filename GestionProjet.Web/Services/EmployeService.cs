using GestionProjet.Web.Models;
using GestionProjet.Web.Services.IServices;

namespace GestionProjet.Web.Services
{
    public class EmployeService : BaseService, IEmployeService
    {
        private readonly IHttpClientFactory _httpClient;
        

        public EmployeService(IHttpClientFactory httpClient) : base(httpClient)
        {
            _httpClient = httpClient;
        }

        public ResponseDto ResponseModel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public async Task<T> CreateEmployeAsync<T>(EmployeDto employeDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = employeDto,
                Url = SD.EmployeAPIBase + "/api/employe",
                AccessToken = ""

            }
              );
        }

        public async Task<T> DeleteEmployeAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.EmployeAPIBase + "/api/employe/" + id,
                AccessToken = ""

            }
              );
        }

        public async Task<T> GetAllEmployeAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.EmployeAPIBase + "/api/employe",
                AccessToken=""

            }
                );
        }

        public async Task<T> GetEmployeByIdAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.EmployeAPIBase + "/api/employe/" + id,
                AccessToken = ""

            }
              );
        }

        public async Task<T> UpdateEmployeAsync<T>(EmployeDto employeDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = employeDto,
                Url = SD.EmployeAPIBase + "/api/employe",
                AccessToken = ""

            }
               );
        }
    }
}
