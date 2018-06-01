using System;
using System.IO;
using System.Collections.Generic;

using Newtonsoft.Json;

using DataAccess;
using DataAccess.DataObject;
using Utility.CommandLine;

namespace InitDatabase
{
    class Program
    {
        class docgia
        {
            public string hoten { get; set; }
            public DateTime ngaysinh { get; set; }
            public string diachi { get; set; }
            public string email { get; set; }
            public string loaidocgia { get; set; }
            public DateTime ngaylapthe { get; set; }
            public DateTime ngayhethan { get; set; }
            public int tongno { get; set; }
        }

        class sach
        {
            public string tensach { get; set; }
            public string theloai { get; set; }
            public string tacgia { get; set; }
            public int namxb { get; set; }
            public string nxb { get; set; }
            public DateTime ngaynhapsach { get; set; }
            public int trigia { get; set; }
        }

        class quydinh
        {
            public string maquydinh { get; set; }
            public string tenquydinh { get; set; }
            public string noidungquydinh { get; set; }
        }

        public enum DataFormat
        {
            CSV = 0,
            csv = 0,
            JSON = 1,
            json = 1
        }

        [Argument('o', "out")]
        public static string databasepath { get; set; } = "";

        [Argument('e', "secret")]
        public static string secret { get; set; } = "secret";

        [Argument('t', "type")]
        public static DataFormat dataformat { get; set; } = DataFormat.JSON;

        [Argument('d', "docgia")]
        public static string docgiadatapath { get; set; } = null;

        [Argument('s', "sach")]
        public static string sachdatapath { get; set; } = null;

        [Argument('q', "quydinh")]
        public static string quydinhdatapath { get; set; } = null;

        [Argument('a', "append")]
        public static bool append { get; set; } = false;

        private static List<docgia> datadocgia = null;
        private static List<sach> datasach = null;
        private static List<quydinh> dataquydinh = null;

        static void Main(string[] args)
        {
            //string databasepath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"..\..\..\Build");

            if (args.Length == 0)
            {
                PrintHelp();
                return;
            }

            Arguments.Populate();

            if (!File.Exists(docgiadatapath))
            {
                datadocgia = new List<docgia>();
            }
            else
            {
                datadocgia = JsonConvert.DeserializeObject<List<docgia>>(File.ReadAllText(docgiadatapath));
            }

            if (!File.Exists(sachdatapath))
            {
                datasach = new List<sach>();
            }
            else
            {
                datasach = JsonConvert.DeserializeObject<List<sach>>(File.ReadAllText(sachdatapath));
            }

            if (!File.Exists(quydinhdatapath))
            {
                dataquydinh = new List<quydinh>();
            }
            else
            {
                dataquydinh = JsonConvert.DeserializeObject<List<quydinh>>(File.ReadAllText(quydinhdatapath));
            }

            //databasepath = Path.Combine(databasepath, "thuvien.db");

            Console.WriteLine(databasepath + " " + secret);
            Database.InitDatabase(databasepath, secret);

            if (!append)
            {
                Database.DropDatabase("secret");
            }

            if (dataquydinh != null)
            {
                //insert quy định
                Console.WriteLine("inserting quydinh");
                foreach (var qd in dataquydinh)
                {
                    Database.AddQuyDinh(new QuyDinh()
                    {
                        MaQuyDinh = qd.maquydinh,
                        TenQuiDinh = qd.tenquydinh,
                        NoiDungQuiDinh = qd.noidungquydinh
                    });
                }
            }
            //var qdcount = 0;
            //Database.AddQuyDinh(new QuyDinh()
            //{
            //    MaQuyDinh = qdcount++.ToString(),
            //    TenQuiDinh = "TuoiToithieu",
            //    NoiDungQuiDinh = "18"
            //});

            //Database.AddQuyDinh(new QuyDinh()
            //{
            //    MaQuyDinh = qdcount++.ToString(),
            //    TenQuiDinh = "TuoiToida",
            //    NoiDungQuiDinh = "55"
            //});

            //Database.AddQuyDinh(new QuyDinh()
            //{
            //    MaQuyDinh = qdcount++.ToString(),
            //    TenQuiDinh = "ThoihanThe",
            //    NoiDungQuiDinh = "6"
            //});

            //Database.AddQuyDinh(new QuyDinh()
            //{
            //    MaQuyDinh = qdcount++.ToString(),
            //    TenQuiDinh = "NamXuatban",
            //    NoiDungQuiDinh = "8"
            //});

            //Database.AddQuyDinh(new QuyDinh()
            //{
            //    MaQuyDinh = qdcount++.ToString(),
            //    TenQuiDinh = "SoluongSachDuocMuon",
            //    NoiDungQuiDinh = "5"
            //});

            //Database.AddQuyDinh(new QuyDinh()
            //{
            //    MaQuyDinh = qdcount++.ToString(),
            //    TenQuiDinh = "SoNgaymuonToida",
            //    NoiDungQuiDinh = "4"
            //});

            //Database.AddQuyDinh(new QuyDinh()
            //{
            //    MaQuyDinh = qdcount++.ToString(),
            //    TenQuiDinh = "TienPhatTraTre",
            //    NoiDungQuiDinh = "1000"
            //});

            if (datadocgia != null)
            {
                //insert loại đọc giả
                //insert đọc giả
                List<string> tenloaidocgia = new List<string>();
                List<DocGia> docgia = new List<DocGia>();
                using (var progress = new ProgressBar())
                {
                    var count = 0;
                    Console.Write("Parsing datadocgia");
                    foreach (var dg in datadocgia)
                    {
                        if (!tenloaidocgia.Contains(dg.loaidocgia))
                        {
                            tenloaidocgia.Add(dg.loaidocgia);
                        }
                        DocGia temp = new DocGia()
                        {
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
                        progress.Report((double)count++ / datadocgia.Count);
                    }
                }
                Console.WriteLine();
                foreach (var tldg in tenloaidocgia)
                {
                    try
                    {
                        Database.AddLoaiDocGia(new LoaiDocGia()
                        {
                            TenLoaiDocGia = tldg,
                            GhiChu = string.Empty
                        });
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                using (var progress = new ProgressBar())
                {
                    var count = 0;
                    Console.Write("Inserting parsed docgia into database");
                    foreach (var dg in docgia)
                    {
                        Database.AddDocGia(dg);
                        progress.Report((double)count++ / docgia.Count);
                    }
                }
                Console.WriteLine();
            }

            if (datasach != null)
            {
                //insert theloai
                //insert tacgia
                //insert sách
                List<string> tentheloai = new List<string>();
                List<string> tentacgia = new List<string>();
                List<Sach> sach = new List<Sach>();
                using (var progress = new ProgressBar())
                {
                    var count = 0;
                    Console.Write("Parsing datasach");
                    foreach (var s in datasach)
                    {
                        if (!tentheloai.Contains(s.theloai))
                        {
                            tentheloai.Add(s.theloai);
                        }
                        if (!tentacgia.Contains(s.tacgia))
                        {
                            tentacgia.Add(s.tacgia);
                        }
                        Sach temp = new Sach()
                        {
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
                        progress.Report((double)count++ / datasach.Count);
                    }
                }
                Console.WriteLine();
                foreach (var ttl in tentheloai)
                {
                    Database.AddTheLoai(new TheLoai()
                    {
                        TenTheLoai = ttl,
                        GhiChu = string.Empty
                    });
                }
                foreach (var ttg in tentacgia)
                {
                    Database.AddTacGia(new TacGia()
                    {
                        TenTacGia = ttg,
                        GhiChu = string.Empty
                    });
                }
                using (var progress = new ProgressBar())
                {
                    var count = 0;
                    Console.Write("Inserting parsed sach into database");
                    foreach (var s in sach)
                    {
                        Database.AddSach(s);
                        progress.Report((double)count++ / sach.Count);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static void PrintHelp()
        {
            Console.WriteLine("-o|--out <database's file path>");
            Console.WriteLine("-e|--secret <database's password>");
            Console.WriteLine("-d|--docgia <docgia data's filepath>");
            Console.WriteLine("-s|--sach <sach data's filepath>");
            Console.WriteLine("-q|--quydinh <quydinh data's filepath>");
            Console.WriteLine("-a|--append add data to the database without drop it");
        }
    }
}
