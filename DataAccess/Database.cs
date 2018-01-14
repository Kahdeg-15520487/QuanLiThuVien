using LiteDB;

using DataAccess.DataObject;
using System.Linq;
using System.Linq.Expressions;
using System;
using System.Collections.Generic;

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
				  .Id(x => x.MaPhieuThuTien)
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

		#region bảng phụ
		#region TacGia
		/// <summary>
		/// truy xuất thông tin tác giả từ database
		/// </summary>
		public static TacGia GetTacGia(string tenTacGia) {
			TacGia result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<TacGia>("TacGia")
						   .FindOne(x => x.TenTacGia == tenTacGia);
			}
			return result;
		}

		/// <summary>
		/// truy xuất thông tin tác giả từ database
		/// </summary>
		public static TacGia GetTacGia(Expression<Func<TacGia, bool>> dieukienloc) {
			TacGia result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<TacGia>("TacGia")
						   .FindOne(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin tác giả vào database
		/// </summary>
		public static bool SetTacGia(TacGia TacGia) {
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
		public static bool RemoveTacGia(string tenTacGia) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<TacGia>("TacGia").Delete(x => x.TenTacGia == tenTacGia) > 0;
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
		/// truy xuất thông tin thể loại từ database
		/// </summary>
		public static TheLoai GetTheLoai(Expression<Func<TheLoai, bool>> dieukienloc) {
			TheLoai result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<TheLoai>("TheLoai")
						   .FindOne(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin thể loại vào database
		/// </summary>
		public static bool SetTheLoai(TheLoai TheLoai) {
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
		public static bool RemoveTheLoai(string maTheLoai) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<TheLoai>("TheLoai").Delete(x => x.TenTheLoai == maTheLoai) > 0;
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
		/// truy xuất thông tin quy định từ database
		/// </summary>
		public static QuyDinh GetQuyDinh(Expression<Func<QuyDinh, bool>> dieukienloc) {
			QuyDinh result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<QuyDinh>("QuyDinh")
						   .FindOne(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin quy định vào database
		/// </summary>
		public static bool SetQuyDinh(QuyDinh QuyDinh) {
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
		/// truy xuất thông tin loại đọc giả từ database
		/// </summary>
		public static LoaiDocGia GetLoaiDocGia(Expression<Func<LoaiDocGia, bool>> dieukienloc) {
			LoaiDocGia result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<LoaiDocGia>("LoaiDocGia")
						   .FindOne(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin loại đọc giả vào database
		/// </summary>
		public static bool SetLoaiDocGia(LoaiDocGia LoaiDocGia) {
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
		#endregion

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
		/// truy xuất thông tin đọc giả từ database
		/// </summary>
		public static IEnumerable<DocGia> GetDocGias(Expression<Func<DocGia, bool>> dieukienloc) {
			IEnumerable<DocGia> result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<DocGia>("DocGia")
						   .Include(x => x.LoaiDG)
						   .Find(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// truy xuất tất cả thông tin đọc giả từ database
		/// </summary>
		public static IEnumerable<DocGia> GetAllDocGia() {
			IEnumerable<DocGia> result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<DocGia>("DocGia")
						   .Include(x => x.LoaiDG)
						   .FindAll();
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
		public static Sach GetSach(string maSach) {
			Sach result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<Sach>("Sach")
						   .Include(x => x.TacGia)
						   .Include(x => x.TheLoai)
						   .FindOne(x => x.MaSach == maSach);
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
						   .Include(x => x.TacGia)
						   .Include(x => x.TheLoai)
						   .FindOne(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// truy xuất thông tin sách từ database
		/// </summary>
		public static IEnumerable<Sach> GetSachs(Expression<Func<Sach, bool>> dieukienloc) {
			IEnumerable<Sach> result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<Sach>("Sach")
						   .Include(x => x.TacGia)
						   .Include(x => x.TheLoai)
						   .Find(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// truy xuất tất cả thông tin sách từ database
		/// </summary>
		public static IEnumerable<Sach> GetAllSach() {
			IEnumerable<Sach> result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<Sach>("Sach")
						   .Include(x => x.TacGia)
						   .Include(x => x.TheLoai)
						   .FindAll();
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin sách vào database
		/// </summary>
		public static bool SetSach(Sach Sach) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<Sach>("Sach").Update(Sach);
			}
			return result;
		}

		/// <summary>
		/// thêm thông tin sách vào database
		/// </summary>
		public static void AddSach(Sach Sach) {
			using (var db = new LiteDatabase(DatabasePath)) {
				db.GetCollection<Sach>("Sach").Insert(Sach);
			}
		}

		/// <summary>
		/// xóa thông tin sách khỏi database
		/// </summary>
		public static bool RemoveSach(string matheSach) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<Sach>("Sach").Delete(x => x.MaSach == matheSach) > 0;
			}
			return result;
		}
		#endregion

		#region PhieuThuTien
		/// <summary>
		/// truy xuất thông tin phiếu thu tiền từ database
		/// </summary>
		public static PhieuThuTien GetPhieuThuTien(string maPhieuThuTien) {
			PhieuThuTien result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<PhieuThuTien>("PhieuThuTien")
						   .Include(x => x.DocGia)
						   .FindOne(x => x.MaPhieuThuTien == maPhieuThuTien);
			}
			return result;
		}

		/// <summary>
		/// truy xuất thông tin phiếu thu tiền từ database
		/// </summary>
		public static PhieuThuTien GetPhieuThuTien(Expression<Func<PhieuThuTien, bool>> dieukienloc) {
			PhieuThuTien result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<PhieuThuTien>("PhieuThuTien")
						   .Include(x => x.DocGia)
						   .FindOne(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// truy xuất thông tin phiếu thu tiền từ database
		/// </summary>
		public static IEnumerable<PhieuThuTien> GetPhieuThuTiens(Expression<Func<PhieuThuTien, bool>> dieukienloc) {
			IEnumerable<PhieuThuTien> result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<PhieuThuTien>("PhieuThuTien")
						   .Include(x => x.DocGia)
						   .Find(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// truy xuất tất cả thông tin phiếu thu tiền từ database
		/// </summary>
		public static IEnumerable<PhieuThuTien> GetAllPhieuThuTien() {
			IEnumerable<PhieuThuTien> result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<PhieuThuTien>("PhieuThuTien")
						   .Include(x => x.DocGia)
						   .FindAll();
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin phiếu thu tiền vào database
		/// </summary>
		public static bool SetPhieuThuTien(PhieuThuTien PhieuThuTien) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<PhieuThuTien>("PhieuThuTien").Update(PhieuThuTien);
			}
			return result;
		}

		/// <summary>
		/// thêm thông tin phiếu thu tiền vào database
		/// </summary>
		public static void AddPhieuThuTien(PhieuThuTien PhieuThuTien) {
			using (var db = new LiteDatabase(DatabasePath)) {
				db.GetCollection<PhieuThuTien>("PhieuThuTien").Insert(PhieuThuTien);
			}
		}

		/// <summary>
		/// xóa thông tin phiếu thu tiền khỏi database
		/// </summary>
		public static bool RemovePhieuThuTien(string maPhieuThuTien) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<PhieuThuTien>("PhieuThuTien").Delete(x => x.MaPhieuThuTien == maPhieuThuTien) > 0;
			}
			return result;
		}
		#endregion

		#region PhieuTraSach
		/// <summary>
		/// truy xuất thông tin phiếu trả sách từ database
		/// </summary>
		public static PhieuTraSach GetPhieuTraSach(string maPhieuTraSach) {
			PhieuTraSach result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<PhieuTraSach>("PhieuTraSach")
						   .Include(x => x.DocGia)
						   .FindOne(x => x.MaPhieuTraSach == maPhieuTraSach);
			}
			return result;
		}

		/// <summary>
		/// truy xuất thông tin phiếu trả sách từ database
		/// </summary>
		public static PhieuTraSach GetPhieuTraSach(Expression<Func<PhieuTraSach, bool>> dieukienloc) {
			PhieuTraSach result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<PhieuTraSach>("PhieuTraSach")
						   .Include(x => x.DocGia)
						   .FindOne(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// truy xuất thông tin phiếu trả sách từ database
		/// </summary>
		public static IEnumerable<PhieuTraSach> GetPhieuTraSachs(Expression<Func<PhieuTraSach, bool>> dieukienloc) {
			IEnumerable<PhieuTraSach> result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<PhieuTraSach>("PhieuTraSach")
						   .Include(x => x.DocGia)
						   .Find(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// truy xuất tất cả thông tin phiếu trả sách từ database
		/// </summary>
		public static IEnumerable<PhieuTraSach> GetAllPhieuTraSach() {
			IEnumerable<PhieuTraSach> result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<PhieuTraSach>("PhieuTraSach")
						   .Include(x => x.DocGia)
						   .FindAll();
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin phiếu trả sách vào database
		/// </summary>
		public static bool SetPhieuTraSach(PhieuTraSach PhieuTraSach) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<PhieuTraSach>("PhieuTraSach").Update(PhieuTraSach);
			}
			return result;
		}

		/// <summary>
		/// thêm thông tin phiếu trả sách vào database
		/// </summary>
		public static void AddPhieuTraSach(PhieuTraSach PhieuTraSach) {
			using (var db = new LiteDatabase(DatabasePath)) {
				db.GetCollection<PhieuTraSach>("PhieuTraSach").Insert(PhieuTraSach);
			}
		}

		/// <summary>
		/// xóa thông tin phiếu trả sách khỏi database
		/// </summary>
		public static bool RemovePhieuTraSach(string maPhieuTraSach) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<PhieuTraSach>("PhieuTraSach").Delete(x => x.MaPhieuTraSach == maPhieuTraSach) > 0;
			}
			return result;
		}
		#endregion

		#region SachTra
		/// <summary>
		/// truy xuất thông tin sách trả từ database
		/// </summary>
		public static SachTra GetSachTra(string maPhieuTraSach, string maSach) {
			SachTra result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<SachTra>("SachTra")
						   .Include(x => x.PhieuTraSach)
						   .Include(x => x.Sach)
						   .FindOne(x => x.PhieuTraSach.MaPhieuTraSach == maPhieuTraSach && x.Sach.MaSach == maSach);
			}
			return result;
		}

		/// <summary>
		/// truy xuất thông tin sách trả từ database
		/// </summary>
		public static SachTra GetSachTra(Expression<Func<SachTra, bool>> dieukienloc) {
			SachTra result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<SachTra>("SachTra")
						   .Include(x => x.PhieuTraSach)
						   .Include(x => x.Sach)
						   .FindOne(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// truy xuất thông tin sách trả từ database
		/// </summary>
		public static IEnumerable<SachTra> GetSachTras(Expression<Func<SachTra, bool>> dieukienloc) {
			IEnumerable<SachTra> result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<SachTra>("SachTra")
						   .Include(x => x.PhieuTraSach)
						   .Include(x => x.Sach)
						   .Find(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// truy xuất tất cả thông tin sách trả từ database
		/// </summary>
		public static IEnumerable<SachTra> GetAllSachTra() {
			IEnumerable<SachTra> result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<SachTra>("SachTra")
						   .Include(x => x.PhieuTraSach)
						   .Include(x => x.Sach)
						   .FindAll();
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin sách trả vào database
		/// </summary>
		public static bool SetSachTra(SachTra SachTra) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<SachTra>("SachTra").Update(SachTra);
			}
			return result;
		}

		/// <summary>
		/// thêm thông tin sách trả vào database
		/// </summary>
		public static void AddSachTra(SachTra SachTra) {
			using (var db = new LiteDatabase(DatabasePath)) {
				db.GetCollection<SachTra>("SachTra").Insert(SachTra);
			}
		}

		/// <summary>
		/// xóa thông tin sách trả khỏi database
		/// </summary>
		public static bool RemoveSachTra(string maPhieuTraSach, string maSach) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<SachTra>("SachTra").Delete(x => x.PhieuTraSach.MaPhieuTraSach == maPhieuTraSach && x.Sach.MaSach == maSach) > 0;
			}
			return result;
		}
		#endregion

		#region ThongTinMuonSach
		/// <summary>
		/// truy xuất thông tin mượn sách từ database
		/// </summary>
		public static ThongTinMuonSach GetThongTinMuonSach(string maTheDocGia, string maSach) {
			ThongTinMuonSach result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<ThongTinMuonSach>("ThongTinMuonSach")
						   .Include(x => x.DocGia)
						   .Include(x => x.Sach)
						   .FindOne(x => x.DocGia.MaTheDG == maTheDocGia && x.Sach.MaSach == maSach);
			}
			return result;
		}

		/// <summary>
		/// truy xuất thông tin mượn sách từ database
		/// </summary>
		public static ThongTinMuonSach GetThongTinMuonSach(Expression<Func<ThongTinMuonSach, bool>> dieukienloc) {
			ThongTinMuonSach result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<ThongTinMuonSach>("ThongTinMuonSach")
						   .Include(x => x.DocGia)
						   .Include(x => x.Sach)
						   .FindOne(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// truy xuất thông tin mượn sách từ database
		/// </summary>
		public static IEnumerable<ThongTinMuonSach> GetThongTinMuonSachs(Expression<Func<ThongTinMuonSach, bool>> dieukienloc) {
			IEnumerable<ThongTinMuonSach> result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<ThongTinMuonSach>("ThongTinMuonSach")
						   .Include(x => x.DocGia)
						   .Include(x => x.Sach)
						   .Find(dieukienloc);
			}
			return result;
		}

		/// <summary>
		/// truy xuất tất cả thông tin mượn sách từ database
		/// </summary>
		public static IEnumerable<ThongTinMuonSach> GetAllThongTinMuonSach() {
			IEnumerable<ThongTinMuonSach> result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<ThongTinMuonSach>("ThongTinMuonSach")
						   .Include(x => x.DocGia)
						   .Include(x => x.Sach)
						   .FindAll();
			}
			return result;
		}

		/// <summary>
		/// cập nhật thông tin mượn sách vào database
		/// </summary>
		public static bool SetThongTinMuonSach(ThongTinMuonSach ThongTinMuonSach) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<ThongTinMuonSach>("ThongTinMuonSach").Update(ThongTinMuonSach);
			}
			return result;
		}

		/// <summary>
		/// thêm thông tin mượn sách vào database
		/// </summary>
		public static void AddThongTinMuonSach(ThongTinMuonSach ThongTinMuonSach) {
			using (var db = new LiteDatabase(DatabasePath)) {
				db.GetCollection<ThongTinMuonSach>("ThongTinMuonSach").Insert(ThongTinMuonSach);
			}
		}

		/// <summary>
		/// xóa thông tin mượn sách khỏi database
		/// </summary>
		public static bool RemoveThongTinMuonSach(string maTheDocGia, string maSach) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<ThongTinMuonSach>("ThongTinMuonSach").Delete(x => x.DocGia.MaTheDG == maTheDocGia && x.Sach.MaSach == maSach) > 0;
			}
			return result;
		}
		#endregion
	}
}
