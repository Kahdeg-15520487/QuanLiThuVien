## `Database`

```csharp
public static class DataAccess.Database

```

| Type | Name | Summary | 
| ---- | ---- | ------- | 
| `void` | InitDatabase(`String` path, `String` secret) | khởi tạo thông tin database | 
| `void` | DropDatabase(`String` secret) | xóa toàn bộ database | 

| Type | Name | Summary | 
| ---- | ---- | ------- | 
| `void` | AddDocGia(`DocGia` docGia) | thêm thông tin đọc giả vào database | 
| `DocGia` | GetDocGia(`String` mathedocgia) | truy xuất thông tin đọc giả từ database | 
| `DocGia` | GetDocGia(`Expression<Func<DocGia, Boolean>>` dieukienloc) | truy xuất thông tin đọc giả từ database | 
| `IEnumerable<DocGia>` | GetDocGias(`Expression<Func<DocGia, Boolean>>` dieukienloc) | truy xuất thông tin đọc giả từ database | 
| `Boolean` | SetDocGia(`DocGia` docGia) | cập nhật thông tin đọc giả vào database | 
| `Boolean` | RemoveDocGia(`String` mathedocgia) | xóa thông tin đọc giả khỏi database | 

| Type | Name | Summary | 
| ---- | ---- | ------- | 
| `void` | AddLoaiDocGia(`LoaiDocGia` LoaiDocGia) | thêm thông tin loại đọc giả vào database | 
| `LoaiDocGia` | GetLoaiDocGia(`String` tenLoaiDocGia) | truy xuất thông tin loại đọc giả từ database | 
| `LoaiDocGia` | GetLoaiDocGia(`Expression<Func<LoaiDocGia, Boolean>>` dieukienloc) | truy xuất thông tin loại đọc giả từ database | 
| `Boolean` | SetLoaiDocGia(`LoaiDocGia` LoaiDocGia) | cập nhật thông tin loại đọc giả vào database | 
| `Boolean` | RemoveLoaiDocGia(`String` tenLoaiDocGia) | xóa thông tin loại đọc giả khỏi database | 

| Type | Name | Summary | 
| ---- | ---- | ------- | 
| `void` | AddPhieuThuTien(`PhieuThuTien` PhieuThuTien) | thêm thông tin phiếu thu tiền vào database | 
| `PhieuThuTien` | GetPhieuThuTien(`String` maPhieuThuTien) | truy xuất thông tin phiếu thu tiền từ database | 
| `PhieuThuTien` | GetPhieuThuTien(`Expression<Func<PhieuThuTien, Boolean>>` dieukienloc) | truy xuất thông tin phiếu thu tiền từ database | 
| `IEnumerable<PhieuThuTien>` | GetPhieuThuTiens(`Expression<Func<PhieuThuTien, Boolean>>` dieukienloc) | truy xuất thông tin phiếu thu tiền từ database | 
| `Boolean` | SetPhieuThuTien(`PhieuThuTien` PhieuThuTien) | cập nhật thông tin phiếu thu tiền vào database | 
| `Boolean` | RemovePhieuThuTien(`String` maPhieuThuTien) | xóa thông tin phiếu thu tiền khỏi database | 

| Type | Name | Summary | 
| ---- | ---- | ------- | 
| `void` | AddPhieuTraSach(`PhieuTraSach` PhieuTraSach) | thêm thông tin phiếu trả sách vào database | 
| `PhieuTraSach` | GetPhieuTraSach(`String` maPhieuTraSach) | truy xuất thông tin phiếu trả sách từ database | 
| `PhieuTraSach` | GetPhieuTraSach(`Expression<Func<PhieuTraSach, Boolean>>` dieukienloc) | truy xuất thông tin phiếu trả sách từ database | 
| `IEnumerable<PhieuTraSach>` | GetPhieuTraSachs(`Expression<Func<PhieuTraSach, Boolean>>` dieukienloc) | truy xuất thông tin phiếu trả sách từ database | 
| `Boolean` | SetPhieuTraSach(`PhieuTraSach` PhieuTraSach) | cập nhật thông tin phiếu trả sách vào database | 
| `Boolean` | RemovePhieuTraSach(`String` maPhieuTraSach) | xóa thông tin phiếu trả sách khỏi database | 

| Type | Name | Summary | 
| ---- | ---- | ------- | 
| `void` | AddQuyDinh(`QuyDinh` QuyDinh) | thêm thông tin quy định vào database | 
| `QuyDinh` | GetQuyDinh(`String` maQuyDinh) | truy xuất thông tin quy định từ database | 
| `QuyDinh` | GetQuyDinh(`Expression<Func<QuyDinh, Boolean>>` dieukienloc) | truy xuất thông tin quy định từ database | 
| `Boolean` | SetQuyDinh(`QuyDinh` QuyDinh) | cập nhật thông tin quy định vào database | 
| `Boolean` | RemoveQuyDinh(`String` maQuyDinh) | xóa thông tin quy định khỏi database | 

| Type | Name | Summary | 
| ---- | ---- | ------- | 
| `void` | AddSach(`Sach` Sach) | thêm thông tin sách vào database | 
| `Sach` | GetSach(`String` maSach) | truy xuất thông tin sách từ database | 
| `Sach` | GetSach(`Expression<Func<Sach, Boolean>>` dieukienloc) | truy xuất thông tin sách từ database | 
| `IEnumerable<Sach>` | GetSachs(`Expression<Func<Sach, Boolean>>` dieukienloc) | truy xuất thông tin sách từ database | 
| `Boolean` | SetSach(`Sach` Sach) | cập nhật thông tin sách vào database | 
| `Boolean` | RemoveSach(`String` matheSach) | xóa thông tin sách khỏi database | 

| Type | Name | Summary | 
| ---- | ---- | ------- | 
| `void` | AddSachTra(`SachTra` SachTra) | thêm thông tin sách trả vào database | 
| `SachTra` | GetSachTra(`String` maPhieuTraSach, `String` maSach) | truy xuất thông tin sách trả từ database | 
| `SachTra` | GetSachTra(`Expression<Func<SachTra, Boolean>>` dieukienloc) | truy xuất thông tin sách trả từ database | 
| `IEnumerable<SachTra>` | GetSachTras(`Expression<Func<SachTra, Boolean>>` dieukienloc) | truy xuất thông tin sách trả từ database | 
| `Boolean` | SetSachTra(`SachTra` SachTra) | cập nhật thông tin sách trả vào database | 
| `Boolean` | RemoveSachTra(`String` maPhieuTraSach, `String` maSach) | xóa thông tin sách trả khỏi database | 

| Type | Name | Summary | 
| ---- | ---- | ------- | 
| `void` | AddTacGia(`TacGia` TacGia) | thêm thông tin tác giả vào database | 
| `TacGia` | GetTacGia(`String` tenTacGia) | truy xuất thông tin tác giả từ database | 
| `TacGia` | GetTacGia(`Expression<Func<TacGia, Boolean>>` dieukienloc) | truy xuất thông tin tác giả từ database | 
| `Boolean` | SetTacGia(`TacGia` TacGia) | cập nhật thông tin tác giả vào database | 
| `Boolean` | RemoveTacGia(`String` tenTacGia) | xóa thông tin tác giả khỏi database | 

| Type | Name | Summary | 
| ---- | ---- | ------- | 
| `void` | AddTheLoai(`TheLoai` TheLoai) | thêm thông tin thể loại vào database | 
| `TheLoai` | GetTheLoai(`String` tenTheLoai) | truy xuất thông tin thể loại từ database | 
| `TheLoai` | GetTheLoai(`Expression<Func<TheLoai, Boolean>>` dieukienloc) | truy xuất thông tin thể loại từ database | 
| `Boolean` | SetTheLoai(`TheLoai` TheLoai) | cập nhật thông tin thể loại vào database | 
| `Boolean` | RemoveTheLoai(`String` maTheLoai) | xóa thông tin thể loại khỏi database | 

| Type | Name | Summary | 
| ---- | ---- | ------- | 
| `void` | AddThongTinMuonSach(`ThongTinMuonSach` ThongTinMuonSach) | thêm thông tin mượn sách vào database | 
| `ThongTinMuonSach` | GetThongTinMuonSach(`String` maTheDocGia, `String` maSach) | truy xuất thông tin mượn sách từ database | 
| `ThongTinMuonSach` | GetThongTinMuonSach(`Expression<Func<ThongTinMuonSach, Boolean>>` dieukienloc) | truy xuất thông tin mượn sách từ database | 
| `IEnumerable<ThongTinMuonSach>` | GetThongTinMuonSachs(`Expression<Func<ThongTinMuonSach, Boolean>>` dieukienloc) | truy xuất thông tin mượn sách từ database | 
| `Boolean` | SetThongTinMuonSach(`ThongTinMuonSach` ThongTinMuonSach) | cập nhật thông tin mượn sách vào database | 
| `Boolean` | RemoveThongTinMuonSach(`String` maTheDocGia, `String` maSach) | xóa thông tin mượn sách khỏi database | 
