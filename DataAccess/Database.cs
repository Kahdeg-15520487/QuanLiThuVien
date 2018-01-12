using LiteDB;

using DataAccess.DataObject;
using System.Linq;
using System.Linq.Expressions;
using System;

namespace DataAccess {
	public static class Database {
		static string DatabasePath = "";
		static string Secret = "";

		#region Init
		public static void InitDatabase(string path, string secret) {
			DatabasePath = path;
			Secret = secret;

			var mapper = BsonMapper.Global;

			mapper.Entity<DocGia>()
				  .Id(x => x.MaTheDG)
				  .DbRef(x => x.LoaiDG, "LoaiDocGia");

			mapper.Entity<LoaiDocGia>()
				  .Id(x => x.TenLoaiDocGia);

			mapper.Entity<PhieuThuTien>()
				  .Id(x => x.MaPhieuThu)
				  .DbRef(x => x.DocGia, "DocGia");

			mapper.Entity<PhieuTraSach>()
				  .Id(x => x.MaPhieuTraSach)
				  .DbRef(x => x.DocGia, "DocGia");

			mapper.Entity<Sach>()
				  .Id(x => x.MaSach)
				  .DbRef(x => x.TacGia, "TacGia")
				  .DbRef(x => x.TheLoai, "TheLoai");

			mapper.Entity<TacGia>()
				  .Id(x => x.TenTacGia);

			mapper.Entity<TheLoai>()
				  .Id(x => x.TenTheLoai);

			mapper.Entity<QuyDinh>()
				  .Id(x => x.MaQuyDinh);

			mapper.Entity<SachTra>()
				  .DbRef(x => x.PhieuTraSach, "PhieuTraSach")
				  .DbRef(x => x.Sach, "Sach");

			mapper.Entity<ThongTinMuonSach>()
				  .DbRef(x => x.Sach, "Sach")
				  .DbRef(x => x.DocGia, "DocGia");
		}
		#endregion

		public static void DropDatabase(string secret) {
			if (Secret == secret) {
				using (var db = new LiteDatabase(DatabasePath)) {
					var collectionNames = db.GetCollectionNames().ToList();
					foreach (var collectionName in collectionNames) {
						db.DropCollection(collectionName);
					}
				}
			}
		}

		#region DocGia
		/// <summary>
		/// truy xuất thông tin đọc giả từ database
		/// </summary>
		public static DocGia GetDocGia(string mathedocgia) {
			DocGia result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<DocGia>("DocGia")
						   .Include(x => x.LoaiDG)
						   .FindOne(x => x.MaTheDG == mathedocgia);
			}
			return result;
		}

		/// <summary>
		/// truy xuất thông tin đọc giả từ database
		/// </summary>
		public static DocGia GetDocGia(Expression<Func<DocGia, bool>> dieukienloc) {
			DocGia result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<DocGia>("DocGia")
						   .Include(x => x.LoaiDG)
						   .FindOne(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin đọc giả vào database
		/// </summary>
		public static bool SetDocGia(DocGia docGia) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<DocGia>("DocGia").Update(docGia);
			}
			return result;
		}

		/// <summary>
		/// thêm thông tin đọc giả vào database
		/// </summary>
		public static void AddDocGia(DocGia docGia) {
			using (var db = new LiteDatabase(DatabasePath)) {
				db.GetCollection<DocGia>("DocGia").Insert(docGia);
			}
		}

		/// <summary>
		/// xóa thông tin đọc giả khỏi database
		/// </summary>
		public static bool RemoveDocGia(string mathedocgia) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<DocGia>("DocGia").Delete(x => x.MaTheDG == mathedocgia) > 0;
			}
			return result;
		}
		#endregion

		#region Sach
		/// <summary>
		/// truy xuất thông tin sách từ database
		/// </summary>
		public static Sach GetSach(string masach) {
			Sach result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<Sach>("Sach")
						   .Include(x => x.TheLoai)
						   .Include(x => x.TacGia)
						   .FindOne(x => x.MaSach == masach);
			}
			return result;
		}

		/// <summary>
		/// truy xuất thông tin sách từ database
		/// </summary>
		public static Sach GetSach(Expression<Func<Sach, bool>> dieukienloc) {
			Sach result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<Sach>("Sach")
						   .Include(x => x.TheLoai)
						   .Include(x => x.TacGia)
						   .FindOne(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin sách vào database
		/// </summary>
		public static bool SetDocGia(Sach sach) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<Sach>("Sach").Update(sach);
			}
			return result;
		}

		/// <summary>
		/// thêm thông tin sách vào database
		/// </summary>
		public static void AddSach(Sach sach) {
			using (var db = new LiteDatabase(DatabasePath)) {
				db.GetCollection<Sach>("Sach").Insert(sach);
			}
		}

		/// <summary>
		/// xóa thông tin sách khỏi database
		/// </summary>
		public static bool RemoveSach(string masach) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<Sach>("Sach").Delete(x => x.MaSach == masach) > 0;
			}
			return result;
		}
		#endregion

		#region TacGia
		/// <summary>
		/// truy xuất thông tin tác giả từ database
		/// </summary>
		public static TacGia GetTacGia(string maTacGia) {
			TacGia result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<TacGia>("TacGia")
						   .FindOne(x => x.TenTacGia == maTacGia);
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin tác giả vào database
		/// </summary>
		public static bool SetDocGia(TacGia TacGia) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<TacGia>("TacGia").Update(TacGia);
			}
			return result;
		}

		/// <summary>
		/// thêm thông tin tác giả vào database
		/// </summary>
		public static void AddTacGia(TacGia TacGia) {
			using (var db = new LiteDatabase(DatabasePath)) {
				db.GetCollection<TacGia>("TacGia").Insert(TacGia);
			}
		}

		/// <summary>
		/// xóa thông tin tác giả khỏi database
		/// </summary>
		public static bool RemoveTacGia(string maTacGia) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<TacGia>("TacGia").Delete(x => x.TenTacGia == maTacGia) > 0;
			}
			return result;
		}
		#endregion

		#region QuyDinh
		/// <summary>
		/// truy xuất thông tin quy định từ database
		/// </summary>
		public static QuyDinh GetQuyDinh(string maQuyDinh) {
			QuyDinh result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<QuyDinh>("QuyDinh")
						   .FindOne(x => x.MaQuyDinh == maQuyDinh);
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin quy định vào database
		/// </summary>
		public static bool SetDocGia(QuyDinh QuyDinh) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<QuyDinh>("QuyDinh").Update(QuyDinh);
			}
			return result;
		}

		/// <summary>
		/// thêm thông tin quy định vào database
		/// </summary>
		public static void AddQuyDinh(QuyDinh QuyDinh) {
			using (var db = new LiteDatabase(DatabasePath)) {
				db.GetCollection<QuyDinh>("QuyDinh").Insert(QuyDinh);
			}
		}

		/// <summary>
		/// xóa thông tin quy định khỏi database
		/// </summary>
		public static bool RemoveQuyDinh(string maQuyDinh) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<QuyDinh>("QuyDinh").Delete(x => x.MaQuyDinh == maQuyDinh) > 0;
			}
			return result;
		}
		#endregion

		#region TheLoai
		/// <summary>
		/// truy xuất thông tin thể loại từ database
		/// </summary>
		public static TheLoai GetTheLoai(string tenTheLoai) {
			TheLoai result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<TheLoai>("TheLoai")
						   .FindOne(x => x.TenTheLoai == tenTheLoai);
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin thể loại vào database
		/// </summary>
		public static bool SetDocGia(TheLoai TheLoai) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<TheLoai>("TheLoai").Update(TheLoai);
			}
			return result;
		}

		/// <summary>
		/// thêm thông tin thể loại vào database
		/// </summary>
		public static void AddTheLoai(TheLoai TheLoai) {
			using (var db = new LiteDatabase(DatabasePath)) {
				db.GetCollection<TheLoai>("TheLoai").Insert(TheLoai);
			}
		}

		/// <summary>
		/// xóa thông tin thể loại khỏi database
		/// </summary>
		public static bool RemoveTheLoai(string tenTheLoai) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<TheLoai>("TheLoai").Delete(x => x.TenTheLoai == tenTheLoai) > 0;
			}
			return result;
		}
		#endregion

		#region LoaiDocGia
		/// <summary>
		/// truy xuất thông tin loại đọc giả từ database
		/// </summary>
		public static LoaiDocGia GetLoaiDocGia(string tenLoaiDocGia) {
			LoaiDocGia result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<LoaiDocGia>("LoaiDocGia")
						   .FindOne(x => x.TenLoaiDocGia == tenLoaiDocGia);
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin loại đọc giả vào database
		/// </summary>
		public static bool SetDocGia(LoaiDocGia LoaiDocGia) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<LoaiDocGia>("LoaiDocGia").Update(LoaiDocGia);
			}
			return result;
		}

		/// <summary>
		/// thêm thông tin loại đọc giả vào database
		/// </summary>
		public static void AddLoaiDocGia(LoaiDocGia LoaiDocGia) {
			using (var db = new LiteDatabase(DatabasePath)) {
				db.GetCollection<LoaiDocGia>("LoaiDocGia").Insert(LoaiDocGia);
			}
		}

		/// <summary>
		/// xóa thông tin loại đọc giả khỏi database
		/// </summary>
		public static bool RemoveLoaiDocGia(string tenLoaiDocGia) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<LoaiDocGia>("LoaiDocGia").Delete(x => x.TenLoaiDocGia == tenLoaiDocGia) > 0;
			}
			return result;
		}
		#endregion


	}
}
