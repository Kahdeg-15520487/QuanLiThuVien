using LiteDB;

namespace DataAccess.DataObject {
	/// <summary>
	/// thể loại được lưu trong bảng TheLoai
	/// </summary>
	public class TheLoai {
		[BsonId]
		public string TenTheLoai { get; set; }
		public string GhiChu { get; set; }
	}
}
