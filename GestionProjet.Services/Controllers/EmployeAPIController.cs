using GestionProject.services.ProdactApi.models.Dtos;
using GestionProject.services.ProdactApi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GestionProjet.Services.ProjectAPI.Controllers
{
    [Route("api/employe")]
    public class EmployeAPIController : ControllerBase
    {
        protected ResponseDto _response;
        private IEmployeRepository _employeRepository;
        public EmployeAPIController(IEmployeRepository employeRepository)
        {
            this._employeRepository = employeRepository;
            this._response = new ResponseDto();
        }

        [HttpGet]
        public async Task<object> Get()
        {
          try
            {
                IEnumerable<EmplpoyeDto> projectDtos = await _employeRepository.GetEmploye();
                _response.Result = projectDtos;
               
            }
                catch (Exception ex)
                 {
                   _response.IsSuccess = false;
                  _response.ErrorMessages
                      = new List<string>() { ex.ToString() };
                   }
            return _response;
        }

            [HttpGet]
            [Route("{id}")]
            public async Task<object> Get(int id)
            {
              try
               {
                    EmplpoyeDto employeDto = await _employeRepository.GetEmplpoyeById(id);
                    _response.Result = employeDto;
                   
               }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages
                         = new List<string>() { ex.ToString() };
                }
            return _response;
        }


            [HttpPost]
            [Authorize]
            public async Task<object> Post([FromBody] EmplpoyeDto emplpoyeDto)
            {
                try
                {
                    EmplpoyeDto model = await _employeRepository.CreateUpdateEmplpoye(emplpoyeDto);
                    _response.Result = model;
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages
                         = new List<string>() { ex.ToString() };
                }
                return _response;
            }


            [HttpPut]
            [Authorize]
            public async Task<object> Put([FromBody] EmplpoyeDto emplpoyeDto)
            {
                try
                {
                    EmplpoyeDto model = await _employeRepository.CreateUpdateEmplpoye(emplpoyeDto);
                    _response.Result = model;
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages
                         = new List<string>() { ex.ToString() };
                }
                return _response;
            }

            [HttpDelete]
            [Authorize(Roles = "Admin")]
            [Route("{id}")]
            public async Task<object> Delete(int id)
            {
                try
                {
                    bool isSuccess = await _employeRepository.DeleteEmplpoye(id);
                    _response.Result = isSuccess;
                }
                catch (Exception ex)
                {
                    _response.IsSuccess = false;
                    _response.ErrorMessages
                         = new List<string>() { ex.ToString() };
                }
                return _response;
            }
        }
    }

