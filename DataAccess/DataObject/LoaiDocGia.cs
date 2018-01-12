using LiteDB;

namespace DataAccess.DataObject {
	/// <summary>
	/// loại độc giả được lưu trong bảng LoaiDocGia
	/// </summary>
	public class LoaiDocGia {
		[BsonId]
		public string LoaiDG { get; set; }
		public string GhiChu { get; set; }
	}
}
