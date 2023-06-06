using _1.DAL.Context;
using _1.DAL.DomainClass;
using ASM_CS5.IRepositories;
using ASM_CS5.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/kichco")]
    [ApiController]
    public class KichCoController : ControllerBase
    {
        public IAllRepositories<KichCo> _irepos;
        FpolyDBContext _dbContext;

        public KichCoController()
        {
            _dbContext = new FpolyDBContext();
            AllRepositories<KichCo> repos = new AllRepositories<KichCo>(_dbContext, _dbContext.KichCos);
            _irepos = repos;


        }
        [HttpGet("Show-KichCo")]
        public IEnumerable<KichCo> GetKichCos()
        {
            return _irepos.GetAll();
        }

        [HttpGet("{id}")]
        public KichCo Get(Guid id)
        {
            return _irepos.GetAll().First(p => p.Id == id);
        }

        [HttpPost("Create-KichCo")]
        public bool CreateKichCo(string Ma, string Size, decimal? Cm ,int? TrangThai)
        {
            KichCo kichco = new KichCo();
            kichco.Ma = Ma;
            kichco.Size = Size;
            kichco.Cm = Cm;
            kichco.TrangThai = TrangThai;
            return _irepos.CreateItem(kichco);
        }

        [HttpPut("edit-Kichco-{id}")]
        public bool UpdateKichCo(Guid id, string Ma, string Size, decimal? Cm ,int? TrangThai)
        {
            KichCo kichco = _irepos.GetAll().FirstOrDefault(p => p.Id == id);
            kichco.Ma = Ma;
            kichco.Size = Size;
            kichco.Cm = Cm;
            kichco.TrangThai = TrangThai;
            return _irepos.UpdateItem(kichco);
        }
        [HttpDelete("Delete-KichCo-/{id}")]
        public bool Delete(Guid id)
        {
            KichCo kichco = _irepos.GetAll().FirstOrDefault(p => p.Id == id);
            return _irepos.DeleteItem(kichco);
        }
    }
}
