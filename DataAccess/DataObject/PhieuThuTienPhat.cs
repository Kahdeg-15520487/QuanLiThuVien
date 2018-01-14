namespace DataAccess.DataObject {
	/// <summary>
	/// phiếu thu tiền phạt được lưu trong bảng PhieuThuTienPhat
	/// </summary>
	public class PhieuThuTienPhat {
		public string MaPhieuThuTienPhat { get; set; }
		public DocGia DocGia { get; set; }
		public int SoTienThu { get; set; }
	}
}
