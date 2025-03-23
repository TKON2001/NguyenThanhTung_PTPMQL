using System;
using System.ComponentModel.DataAnnotations;  // ✅ Bổ sung thư viện

namespace MvcMovie.Models
{
    public class DaiLy
    {
        [Key]  // ✅ Xác định khóa chính
        public string MaDaiLy { get; set; }

        public required string TenDaiLy { get; set; }
        public required string DiaChi { get; set; }
        public required string NguoiDaiDien { get; set; }
        public required string DienThoai { get; set; }
        public required string MaHTPP { get; set; }

        // Khóa ngoại liên kết với HeThongPhanPhoi
        public HeThongPhanPhoi? HeThongPhanPhoi { get; set; }

        public DaiLy()
        {
            MaDaiLy = GenerateMaDaiLy();
        }

        private string GenerateMaDaiLy()
        {
            return "DL-" + Guid.NewGuid().ToString("N").Substring(6).ToUpper();
        }
    }
}