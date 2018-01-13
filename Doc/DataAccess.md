## `Database`

```csharp
public static class DataAccess.Database

```

Static Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | AddDocGia(`DocGia` docGia) | thêm thông tin đọc giả vào database | 
| `void` | AddLoaiDocGia(`LoaiDocGia` LoaiDocGia) | thêm thông tin loại đọc giả vào database | 
| `void` | AddPhieuThuTien(`PhieuThuTien` PhieuThuTien) | thêm thông tin phiếu thu tiền vào database | 
| `void` | AddPhieuTraSach(`PhieuTraSach` PhieuTraSach) | thêm thông tin phiếu trả sách vào database | 
| `void` | AddQuyDinh(`QuyDinh` QuyDinh) | thêm thông tin quy định vào database | 
| `void` | AddSach(`Sach` Sach) | thêm thông tin sách vào database | 
| `void` | AddSachTra(`SachTra` SachTra) | thêm thông tin sách trả vào database | 
| `void` | AddTacGia(`TacGia` TacGia) | thêm thông tin tác giả vào database | 
| `void` | AddTheLoai(`TheLoai` TheLoai) | thêm thông tin thể loại vào database | 
| `void` | AddThongTinMuonSach(`ThongTinMuonSach` ThongTinMuonSach) | thêm thông tin mượn sách vào database | 
| `void` | DropDatabase(`String` secret) |  | 
| `DocGia` | GetDocGia(`String` mathedocgia) | truy xuất thông tin đọc giả từ database | 
| `DocGia` | GetDocGia(`Expression<Func<DocGia, Boolean>>` dieukienloc) | truy xuất thông tin đọc giả từ database | 
| `IEnumerable<DocGia>` | GetDocGias(`Expression<Func<DocGia, Boolean>>` dieukienloc) | truy xuất thông tin đọc giả từ database | 
| `LoaiDocGia` | GetLoaiDocGia(`String` tenLoaiDocGia) | truy xuất thông tin loại đọc giả từ database | 
| `LoaiDocGia` | GetLoaiDocGia(`Expression<Func<LoaiDocGia, Boolean>>` dieukienloc) | truy xuất thông tin loại đọc giả từ database | 
| `PhieuThuTien` | GetPhieuThuTien(`String` maPhieuThuTien) | truy xuất thông tin phiếu thu tiền từ database | 
| `PhieuThuTien` | GetPhieuThuTien(`Expression<Func<PhieuThuTien, Boolean>>` dieukienloc) | truy xuất thông tin phiếu thu tiền từ database | 
| `IEnumerable<PhieuThuTien>` | GetPhieuThuTiens(`Expression<Func<PhieuThuTien, Boolean>>` dieukienloc) | truy xuất thông tin phiếu thu tiền từ database | 
| `PhieuTraSach` | GetPhieuTraSach(`String` maPhieuTraSach) | truy xuất thông tin phiếu trả sách từ database | 
| `PhieuTraSach` | GetPhieuTraSach(`Expression<Func<PhieuTraSach, Boolean>>` dieukienloc) | truy xuất thông tin phiếu trả sách từ database | 
| `IEnumerable<PhieuTraSach>` | GetPhieuTraSachs(`Expression<Func<PhieuTraSach, Boolean>>` dieukienloc) | truy xuất thông tin phiếu trả sách từ database | 
| `QuyDinh` | GetQuyDinh(`String` maQuyDinh) | truy xuất thông tin quy định từ database | 
| `QuyDinh` | GetQuyDinh(`Expression<Func<QuyDinh, Boolean>>` dieukienloc) | truy xuất thông tin quy định từ database | 
| `Sach` | GetSach(`String` maSach) | truy xuất thông tin sách từ database | 
| `Sach` | GetSach(`Expression<Func<Sach, Boolean>>` dieukienloc) | truy xuất thông tin sách từ database | 
| `IEnumerable<Sach>` | GetSachs(`Expression<Func<Sach, Boolean>>` dieukienloc) | truy xuất thông tin sách từ database | 
| `SachTra` | GetSachTra(`String` maPhieuTraSach, `String` maSach) | truy xuất thông tin sách trả từ database | 
| `SachTra` | GetSachTra(`Expression<Func<SachTra, Boolean>>` dieukienloc) | truy xuất thông tin sách trả từ database | 
| `IEnumerable<SachTra>` | GetSachTras(`Expression<Func<SachTra, Boolean>>` dieukienloc) | truy xuất thông tin sách trả từ database | 
| `TacGia` | GetTacGia(`String` tenTacGia) | truy xuất thông tin tác giả từ database | 
| `TacGia` | GetTacGia(`Expression<Func<TacGia, Boolean>>` dieukienloc) | truy xuất thông tin tác giả từ database | 
| `TheLoai` | GetTheLoai(`String` tenTheLoai) | truy xuất thông tin thể loại từ database | 
| `TheLoai` | GetTheLoai(`Expression<Func<TheLoai, Boolean>>` dieukienloc) | truy xuất thông tin thể loại từ database | 
| `ThongTinMuonSach` | GetThongTinMuonSach(`String` maTheDocGia, `String` maSach) | truy xuất thông tin mượn sách từ database | 
| `ThongTinMuonSach` | GetThongTinMuonSach(`Expression<Func<ThongTinMuonSach, Boolean>>` dieukienloc) | truy xuất thông tin mượn sách từ database | 
| `IEnumerable<ThongTinMuonSach>` | GetThongTinMuonSachs(`Expression<Func<ThongTinMuonSach, Boolean>>` dieukienloc) | truy xuất thông tin mượn sách từ database | 
| `void` | InitDatabase(`String` path, `String` secret) |  | 
| `Boolean` | RemoveDocGia(`String` mathedocgia) | xóa thông tin đọc giả khỏi database | 
| `Boolean` | RemoveLoaiDocGia(`String` tenLoaiDocGia) | xóa thông tin loại đọc giả khỏi database | 
| `Boolean` | RemovePhieuThuTien(`String` maPhieuThuTien) | xóa thông tin phiếu thu tiền khỏi database | 
| `Boolean` | RemovePhieuTraSach(`String` maPhieuTraSach) | xóa thông tin phiếu trả sách khỏi database | 
| `Boolean` | RemoveQuyDinh(`String` maQuyDinh) | xóa thông tin quy định khỏi database | 
| `Boolean` | RemoveSach(`String` matheSach) | xóa thông tin sách khỏi database | 
| `Boolean` | RemoveSachTra(`String` maPhieuTraSach, `String` maSach) | xóa thông tin sách trả khỏi database | 
| `Boolean` | RemoveTacGia(`String` tenTacGia) | xóa thông tin tác giả khỏi database | 
| `Boolean` | RemoveTheLoai(`String` maTheLoai) | xóa thông tin thể loại khỏi database | 
| `Boolean` | RemoveThongTinMuonSach(`String` maTheDocGia, `String` maSach) | xóa thông tin mượn sách khỏi database | 
| `Boolean` | SetDocGia(`DocGia` docGia) | cập nhật thông tin đọc giả vào database | 
| `Boolean` | SetLoaiDocGia(`LoaiDocGia` LoaiDocGia) | cập nhật thông tin loại đọc giả vào database | 
| `Boolean` | SetPhieuThuTien(`PhieuThuTien` PhieuThuTien) | cập nhật thông tin phiếu thu tiền vào database | 
| `Boolean` | SetPhieuTraSach(`PhieuTraSach` PhieuTraSach) | cập nhật thông tin phiếu trả sách vào database | 
| `Boolean` | SetQuyDinh(`QuyDinh` QuyDinh) | cập nhật thông tin quy định vào database | 
| `Boolean` | SetSach(`Sach` Sach) | cập nhật thông tin sách vào database | 
| `Boolean` | SetSachTra(`SachTra` SachTra) | cập nhật thông tin sách trả vào database | 
| `Boolean` | SetTacGia(`TacGia` TacGia) | cập nhật thông tin tác giả vào database | 
| `Boolean` | SetTheLoai(`TheLoai` TheLoai) | cập nhật thông tin thể loại vào database | 
| `Boolean` | SetThongTinMuonSach(`ThongTinMuonSach` ThongTinMuonSach) | cập nhật thông tin mượn sách vào database | 


## `RandomIdGenerator`

```csharp
public static class DataAccess.RandomIdGenerator

```

Static Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | GetBase36(`Int32` length) |  | 
| `String` | GetBase62(`Int32` length) |  | 


