using LiteDB;

namespace DataAccess.DataObject {
	/// <summary>
	/// thông tin sách được trả được lưu trong bảng SachTra
	/// </summary>
	public class SachTra {
		[BsonRef("PhieuTraSach")]
		public PhieuTraSach PhieuTraSach { get; set; }
		[BsonRef("Sach")]
		public Sach Sach { get; set; }
		public int SoNgayMuon { get; set; }
		public int TienPhat { get; set; }
	}
}
