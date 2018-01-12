using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LiteDB;

using DataAccess.DataObject;

namespace DataAccess
{
    public static class Database
    {
		public static string DatabasePath = "";

		/// <summary>
		/// truy xuất thông tin đọc giả từ database
		/// </summary>
		public static DocGia GetDocGia(string mathedocgia) {
			DocGia result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<DocGia>("DocGia").FindOne(x => x.MaTheDG == mathedocgia);
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
		public static bool AddDocGia(DocGia docGia) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<DocGia>("DocGia").Insert(docGia);
			}
			return result;
		}

		/// <summary>
		/// truy xuất thông tin sách từ database
		/// </summary>
		public static Sach GetSach(string masach) {
			Sach result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<Sach>("Sach").FindOne(x => x.MaSach == masach);
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
		public static bool AddSach(Sach sach) {
			bool result;
			using (var db = new LiteDatabase(DatabasePath)) {
				result = db.GetCollection<Sach>("Sach").Insert(sach);
			}
			return result;
		}
	}
}
