using System;
using LiteDB;

namespace DataAccess.DataObject {
	/// <summary>
	/// thông tin sách được lưu trong bảng Sach
	/// </summary>
	public class Sach {
		[BsonId]
		public string MaSach { get; set; }
		public string TenSach { get; set; }
		[BsonRef("TheLoai")]
		public TheLoai TheLoai { get; set; }
		[BsonRef("TacGia")]
		public TacGia TacGia { get; set; }
		public int NamXB { get; set; }
		public string NXB { get; set; }
		public DateTime NgayNhap { get; set; }
		public int TriGia { get; set; }
		public string TinhTrang { get; set; }
	}
}
