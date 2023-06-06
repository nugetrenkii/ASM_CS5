using _1.DAL.Context;
using _1.DAL.DomainClass;
using ASM_CS5.IRepositories;
using ASM_CS5.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/chatlieu")]
    [ApiController]
    public class ChatlieuController : ControllerBase
    {
        public IAllRepositories<ChatLieu> _irepos;
        FpolyDBContext _dbContext;

        public ChatlieuController()
        {
            _dbContext = new FpolyDBContext();
            AllRepositories<ChatLieu> repos = new AllRepositories<ChatLieu>(_dbContext, _dbContext.ChatLieus);
            _irepos = repos;

        }
        [HttpGet("Show-Chatlieu")]
        public IEnumerable<ChatLieu> GetChatLieus()
        {
            return _irepos.GetAll();
        }

        [HttpGet("{id}")]
        public ChatLieu Get(Guid id)
        {
            return _irepos.GetAll().First(p => p.Id == id);
        }

        [HttpPost("Create-Chatlieu")]
        public bool CreateChatLieu(string Ma, string Ten, int? TrangThai)
        {
            ChatLieu chatlieu = new ChatLieu();
            chatlieu.Ma = Ma;
            chatlieu.Ten = Ten;
            chatlieu.TrangThai = TrangThai;
            return _irepos.CreateItem(chatlieu);

        }

        [HttpPut("edit-ChatLieu-{id}")]
        public bool UpdateChatlieu(Guid id, string Ma, string Ten, int? TrangThai)
        {
            ChatLieu chatlieu = _irepos.GetAll().FirstOrDefault(p => p.Id == id);
            chatlieu.Ma = Ma;
            chatlieu.Ten = Ten;
            chatlieu.TrangThai = TrangThai;
            return _irepos.UpdateItem(chatlieu);
        }
        [HttpDelete("Delete-ChatLieu-/{id}")]
        public bool Delete(Guid id)
        {
            ChatLieu chatlieu = _irepos.GetAll().FirstOrDefault(p => p.Id == id);
            return _irepos.DeleteItem(chatlieu);
        }
    }
}
