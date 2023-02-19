using GestionProjet.Web.Models;
using GestionProjet.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GestionProjet.Web.Controllers
{
    public class EmployeController : Controller
    {
        private IEmployeService _employeService;
        public EmployeController(IEmployeService employeService)
        {
            _employeService = employeService;
        }
        //[Area("Employe/EmployeIndex.cshtml")]
        
        public async Task<IActionResult> EmployeIndex()
        {
            List<EmployeDto> list = new List<EmployeDto>();
            var response =await _employeService.GetAllEmployeAsync<ResponseDto>();
            if (response != null && response.isSuccess)
            {
                list = JsonConvert.DeserializeObject<List<EmployeDto>>(Convert.ToString(response.Result));
                
            }
            //list =JsonConvert.DeserializeObject<List<EmployeDto>>(Convert.ToString(response.Result));
            return View(list);
        }
        
        //[Area("Employe")]
        public async Task<IActionResult> EmployeCreate()
        {
            return View();
        }
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EmployeCreate(EmployeDto model)

        {
            var response=await _employeService.CreateEmployeAsync<EmployeDto>(model);
            if (response!=null && response.isSuccess)
                return RedirectToAction(nameof(EmployeIndex));
            return View(model);
        }

        public async Task<IActionResult> EmployeEdit(int employeId)
        {
            if (ModelState.IsValid)
            {
                var response = await _employeService.GetEmployeByIdAsync<ResponseDto>(employeId);

                if (response != null && response.isSuccess)
                {
                    EmployeDto model = JsonConvert.DeserializeObject<EmployeDto>(Convert.ToString(response.Result));
                    return View(model);
                }
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EmployeEdit(EmployeDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _employeService.UpdateEmployeAsync<ResponseDto>(model);

                if (response != null && response.isSuccess)
                {
                    return RedirectToAction(nameof(EmployeIndex));
                }
            }
            return View(model);
        }

        public async Task<IActionResult> EmployeDelete(int employeId)
        {
            if (ModelState.IsValid)
            {
                var response = await _employeService.GetEmployeByIdAsync<ResponseDto>(employeId);

                if (response != null && response.isSuccess)
                {
                    EmployeDto model = JsonConvert.DeserializeObject<EmployeDto>(Convert.ToString(response.Result));
                    return View(model);
                }
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EmployeDelete(EmployeDto model)
        {
            if (ModelState.IsValid)
            {
                var response = await _employeService.DeleteEmployeAsync<ResponseDto>(model.EmployeId);

                if (response.isSuccess)
                {
                    return RedirectToAction(nameof(EmployeIndex));
                }
            }
            return View(model);
        }

    }
}
