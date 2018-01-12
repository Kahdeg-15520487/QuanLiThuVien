using System;
using LiteDB;

namespace DataAccess.DataObject {
	/// <summary>
	/// đối tượng Độc Giả được lưu trong bảng DocGia
	/// </summary>
	public class DocGia {
		[BsonId]
		public string MaTheDG { get; set; }
		public string HoTen { get; set; }
		public DateTime NgaySinh { get; set; }
		public string DiaChi { get; set; }
		public string Email { get; set; }
		[BsonRef("LoaiDocGia")]
		public LoaiDocGia LoaiDG { get; set; }
		public DateTime NgayLapThe { get; set; }
		public DateTime NgayHetHan { get; set; }
		public int TongNo { get; set; }
	}
}
