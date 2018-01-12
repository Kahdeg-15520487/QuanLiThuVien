using System;

namespace DataAccess.DataObject {
	/// <summary>
	/// thông tin mượn sách được lưu trong bảng TTMuonSach
	/// </summary>
	public class ThongTinMuonSach {
		public Sach Sach { get; set; }
		public DocGia DocGia { get; set; }
		public DateTime NgayMuon { get; set; }
	}
}
