using AutoMapper;
using GestionProject.services.ProdactApi.models.Dtos;
using GestionProject.services.ProdactApi.Repository;
using GestionProjet.Services.ProductAPI.DbContexts;
using GestionProjet.Services.ProjectAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionProject.Services.ProductAPI.Repository
{
   
    public class EmployeRepository : IEmployeRepository
    {
        private readonly ApplicationDbContext _db;

        private IMapper _mapper;
        public EmployeRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<EmplpoyeDto> CreateUpdateEmplpoye(EmplpoyeDto emplpoyeDto)
        {
            Employe emplpoye = _mapper.Map<EmplpoyeDto, Employe>(emplpoyeDto);
            if (emplpoye.employeId > 0)
            {
                _db.Employes.Update(emplpoye);
            }
            else
            {
                _db.Employes.Add(emplpoye);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Employe, EmplpoyeDto>(emplpoye);
        }

        public async Task<bool> DeleteEmplpoye(int employeId)
        {
            try
            {
                Employe employe = await _db.Employes.FirstOrDefaultAsync(u => u.employeId == employeId);
                if (employe == null)
                {
                    return false;
                }
                _db.Employes.Remove(employe);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<EmplpoyeDto>> GetEmploye()
        {
            List<Employe> employeList = await _db.Employes.ToListAsync();


            return _mapper.Map<List<EmplpoyeDto>>(employeList);
        }

        public async Task<EmplpoyeDto> GetEmplpoyeById(int employeId)
        {
            Employe employe = await _db.Employes.Where(x => x.employeId == employeId).FirstOrDefaultAsync();

            return _mapper.Map<EmplpoyeDto>(employe);
        }
    }
}
