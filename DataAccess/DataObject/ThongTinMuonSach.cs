using System;
using LiteDB;

namespace DataAccess.DataObject {
	/// <summary>
	/// thông tin mượn sách được lưu trong bảng TTMuonSach
	/// </summary>
	public class ThongTinMuonSach {
		[BsonRef("Sach")]
		public Sach Sach { get; set; }
		[BsonRef("DocGia")]
		public DocGia DocGia { get; set; }
		public DateTime NgayMuon { get; set; }
	}
}
