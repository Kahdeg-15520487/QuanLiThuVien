﻿namespace DataAccess.DataObject {
	/// <summary>
	/// phiếu thu tiền được lưu trong bảng PhieuThuTien
	/// </summary>
	public class PhieuThuTien {
		public string MaPhieuThuTien { get; set; }
		public DocGia DocGia { get; set; }
		public int SoTienThu { get; set; }
	}
}
