using _1.DAL.Context;
using _1.DAL.DomainClass;
using ASM_CS5.IRepositories;
using ASM_CS5.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/mausac")]
    [ApiController]
    public class MauSacController : ControllerBase
    {
        public IAllRepositories<MauSac> _irepos;
        FpolyDBContext _dbContext;

        public MauSacController()
        {
            _dbContext = new FpolyDBContext();
            AllRepositories<MauSac> repos = new AllRepositories<MauSac>(_dbContext, _dbContext.MauSacs);
            _irepos = repos;


        }
        [HttpGet("Show-MauSac")]
        public IEnumerable<MauSac> GetMauSacs()
        {
            return _irepos.GetAll();
        }

        [HttpGet("{id}")]
        public MauSac Get(Guid id)
        {
            return _irepos.GetAll().First(p => p.Id == id);
        }

        [HttpPost("Create-MauSac")]
        public bool CreateMauSac(string Ma, string Ten, int? TrangThai)
        {
            MauSac mausac = new MauSac();
            mausac.Ma = Ma;
            mausac.Ten = Ten;
            mausac.TrangThai = TrangThai;
            return _irepos.CreateItem(mausac);
        }

        [HttpPut("edit-MauSac-{id}")]
        public bool UpdateMauSac(Guid id, string Ma, string Ten, int? TrangThai)
        {
            MauSac mausac = _irepos.GetAll().FirstOrDefault(p => p.Id == id);
            mausac.Ma = Ma;
            mausac.Ten = Ten;
            mausac.TrangThai = TrangThai;
            return _irepos.UpdateItem(mausac);
        }
        [HttpDelete("Delete-MauSac-/{id}")]
        public bool Delete(Guid id)
        {
            MauSac mausac = _irepos.GetAll().FirstOrDefault(p => p.Id == id);
            return _irepos.DeleteItem(mausac);
        }
    }
}
