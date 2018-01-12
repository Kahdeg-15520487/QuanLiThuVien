using System;
using LiteDB;

namespace DataAccess.DataObject {
	/// <summary>
	/// phiếu trả sách được lưu trong bảng PhieuTraSach
	/// </summary>
	public class PhieuTraSach {
		[BsonId]
		public string MaPhieuTraSach { get; set; }
		[BsonRef("DocGia")]
		public DocGia DocGia { get; set; }
		public DateTime NgayTra { get; set; }
		public int TienPhatKyNay { get; set; }
	}
}
