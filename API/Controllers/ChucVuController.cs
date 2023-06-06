using _1.DAL.Context;
using _1.DAL.DomainClass;
using ASM_CS5.IRepositories;
using ASM_CS5.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/chucvu")]
    [ApiController]
    public class ChucVuController : ControllerBase
    {
        public IAllRepositories<ChucVu> _irepos;
        FpolyDBContext _dbContext;

        public ChucVuController()
        {
            _dbContext = new FpolyDBContext();
            AllRepositories<ChucVu> repos = new AllRepositories<ChucVu>(_dbContext,_dbContext.ChucVus);
            _irepos = repos;


        }
        [HttpGet("Show-ChucVu")]
        public IEnumerable<ChucVu> GetAllChucVu()
        {
            return _irepos.GetAll();
        }

        [HttpGet("{id}")]
        public ChucVu Get(Guid id)
        {
            return _irepos.GetAll().First(p => p.Id == id);
        }

        [HttpPost("Create-ChucVu")]
        public bool CreateChucVu(string Ma, string Ten, int? TrangThai)
        {
            ChucVu chucvu = new ChucVu();
            chucvu.Ma = Ma;
            chucvu.Ten = Ten;
            chucvu.TrangThai =TrangThai;
            return _irepos.CreateItem(chucvu);
        }

        [HttpPut("edit-Chucvu-{id}")]
        public bool UpdateChucVu(Guid id, string Ma, string Ten, int? TrangThai)
        {
            ChucVu chucvu = _irepos.GetAll().FirstOrDefault(p => p.Id == id);
            chucvu.Ma = Ma;
            chucvu.Ten = Ten;
            chucvu.TrangThai = TrangThai;
            return _irepos.UpdateItem(chucvu);
        }
        [HttpDelete("Delete-ChucVu-/{id}")]
        public bool Delete(Guid id)
        {
            ChucVu chucvu = _irepos.GetAll().FirstOrDefault(p => p.Id == id);
            return _irepos.DeleteItem(chucvu);
        }
    }
}
