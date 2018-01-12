using LiteDB;

namespace DataAccess.DataObject {
	/// <summary>
	/// phiếu thu tiền được lưu trong bảng PhieuThuTien
	/// </summary>
	public class PhieuThuTien {
		[BsonId]
		public string MaPhieuThu { get; set; }
		[BsonRef("DocGia")]
		public DocGia DocGia { get; set; }
		public int SoTienThu { get; set; }
	}
}
