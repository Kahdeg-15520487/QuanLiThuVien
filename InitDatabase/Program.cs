using System;
using System.IO;
using System.Collections.Generic;

using Newtonsoft.Json;

using DataAccess;
using DataAccess.DataObject;

namespace InitDatabase {
	class Program {
		class docgia {
			public string hoten { get; set; }
			public DateTime ngaysinh { get; set; }
			public string diachi { get; set; }
			public string email { get; set; }
			public string loaidocgia { get; set; }
			public DateTime ngaylapthe { get; set; }
			public DateTime ngayhethan { get; set; }
			public int tongno { get; set; }
		}

		class sach {
			public string tensach { get; set; }
			public string theloai { get; set; }
			public string tacgia { get; set; }
			public int namxb { get; set; }
			public string nxb { get; set; }
			public DateTime ngaynhapsach { get; set; }
			public int trigia { get; set; }
		}
		static void Main(string[] args) {
			string databasepath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"..\..\..\Build");

			databasepath = Path.Combine(databasepath, "thuvien.db");
			Console.WriteLine(databasepath);
			Database.InitDatabase(databasepath, "lala");
			Database.DropDatabase("lala");
			
			var datadocgia = JsonConvert.DeserializeObject<List<docgia>>(Properties.Resources.docgia);
			var datasach = JsonConvert.DeserializeObject<List<sach>>(Properties.Resources.sach);

			//insert loại đọc giả
			List<string> tenloaidocgia = new List<string>();
			foreach (var dg in datadocgia) {
				if (!tenloaidocgia.Contains(dg.loaidocgia)) {
					tenloaidocgia.Add(dg.loaidocgia);
				}
			}
			foreach (var tldg in tenloaidocgia) {
				Database.AddLoaiDocGia(new LoaiDocGia() {
					TenLoaiDocGia = tldg,
					GhiChu = string.Empty
				});
			}

			//insert đọc giả
			List<DocGia> docgia = new List<DocGia>();
			foreach (var dg in datadocgia) {
				DocGia temp = new DocGia() {
					MaTheDG = RandomIdGenerator.GetBase36(10),
					HoTen = dg.hoten,
					NgaySinh = dg.ngaysinh,
					DiaChi = dg.diachi,
					Email = dg.email,
					LoaiDG = new LoaiDocGia() { TenLoaiDocGia = dg.loaidocgia, GhiChu = string.Empty },
					NgayLapThe = dg.ngaylapthe,
					NgayHetHan = dg.ngayhethan,
					TongNo = dg.tongno
				};
				docgia.Add(temp);
			}

			foreach (var dg in docgia) {
				Database.AddDocGia(dg);
			}

			//insert theloai
			List<string> tentheloai = new List<string>();
			foreach (var s in datasach) {
				if (!tentheloai.Contains(s.theloai)) {
					tentheloai.Add(s.theloai);
				}
			}
			foreach (var ttl in tentheloai) {
				Database.AddTheLoai(new TheLoai() {
					TenTheLoai = ttl,
					GhiChu = string.Empty
				});
			}

			//insert tacgia
			List<string> tentacgia = new List<string>();
			foreach (var s in datasach) {
				if (!tentacgia.Contains(s.tacgia)) {
					tentacgia.Add(s.tacgia);
				}
			}
			foreach (var ttg in tentacgia) {
				Database.AddTacGia(new TacGia() {
					TenTacGia = ttg,
					GhiChu = string.Empty
				});
			}

			//insert sách
			List<Sach> sach = new List<Sach>();
			foreach (var s in datasach) {
				Sach temp = new Sach() {
					MaSach = RandomIdGenerator.GetBase36(10),
					TenSach = s.tensach,
					TheLoai = new TheLoai() { TenTheLoai = s.theloai },
					TacGia = new TacGia() { TenTacGia = s.tacgia },
					NamXB = s.namxb,
					NXB = s.nxb,
					NgayNhap = s.ngaynhapsach,
					TriGia = s.trigia,
					TinhTrang = string.Empty
				};
				sach.Add(temp);
			}

			foreach (var s in sach) {
				Database.AddSach(s);
			}

			Console.WriteLine("Xong");
			Console.ReadLine();
		}
	}
}
