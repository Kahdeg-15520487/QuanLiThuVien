using LiteDB;

namespace DataAccess.DataObject {
	/// <summary>
	/// tác giả được lưu trong bảng TacGia
	/// </summary>
	public class TacGia {
		[BsonId]
		public string MaTacGia { get; set; }
		public string TenTacGia { get; set; }
		public string GhiChu { get; set; }
	}
}
