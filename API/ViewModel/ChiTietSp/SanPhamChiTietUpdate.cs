using _1.DAL.DomainClass;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace API.ViewModel.ChiTietSp
{
    public class SanPhamChiTietUpdate
    {
        public SanPhamChiTietUpdate()
        {
            Selected= new List<string>();
        }
        public Guid Id { get; set; }
        public Guid? IdSp { get; set; }
        public Guid? IdMauSac { get; set; }
        public Guid? IdKichCo { get; set; }
        public Guid? IdChatLieu { get; set; }
        public string MaQr { get; set; }
        public string BaoHanh { get; set; }
        public string MoTa { get; set; }
        public int? SoLuongTon { get; set; }
        public decimal? GiaNhap { get; set; }
        public decimal? GiaBan { get; set; }
        public int? TrangThaiKhuyenMai { get; set; }
        public int? TrangThai { get; set; }
        public virtual ICollection<Anh> Anhs { get; set; }
        public IList<string> Selected { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IList<IFormFile> ImageFile { get; set; }
    }
}
