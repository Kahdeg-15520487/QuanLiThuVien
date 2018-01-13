## `DocGia`

đối tượng Độc Giả được lưu trong bảng DocGia
```csharp
public class DataAccess.DataObject.DocGia

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | DiaChi |  | 
| `String` | Email |  | 
| `String` | HoTen |  | 
| `LoaiDocGia` | LoaiDG |  | 
| `String` | MaTheDG |  | 
| `DateTime` | NgayHetHan |  | 
| `DateTime` | NgayLapThe |  | 
| `DateTime` | NgaySinh |  | 
| `Int32` | TongNo |  | 


## `LoaiDocGia`

```csharp
public class DataAccess.DataObject.LoaiDocGia

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | GhiChu |  | 
| `String` | TenLoaiDocGia |  | 


## `PhieuThuTien`

phiếu thu tiền được lưu trong bảng PhieuThuTien
```csharp
public class DataAccess.DataObject.PhieuThuTien

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `DocGia` | DocGia |  | 
| `String` | MaPhieuThuTien |  | 
| `Int32` | SoTienThu |  | 


## `PhieuTraSach`

phiếu trả sách được lưu trong bảng PhieuTraSach
```csharp
public class DataAccess.DataObject.PhieuTraSach

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `DocGia` | DocGia |  | 
| `String` | MaPhieuTraSach |  | 
| `DateTime` | NgayTra |  | 
| `Int32` | TienPhatKyNay |  | 


## `QuyDinh`

quy định được lưu trong bảng QuyDinh
```csharp
public class DataAccess.DataObject.QuyDinh

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | GhiChu |  | 
| `String` | MaQuyDinh |  | 
| `String` | NoiDungQuiDinh |  | 
| `String` | TenQuiDinh |  | 


## `Sach`

thông tin sách được lưu trong bảng Sach
```csharp
public class DataAccess.DataObject.Sach

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | MaSach |  | 
| `Int32` | NamXB |  | 
| `DateTime` | NgayNhap |  | 
| `String` | NXB |  | 
| `Int32` | SoLuong |  | 
| `TacGia` | TacGia |  | 
| `String` | TenSach |  | 
| `TheLoai` | TheLoai |  | 
| `String` | TinhTrang |  | 
| `Int32` | TriGia |  | 


## `SachTra`

thông tin sách được trả được lưu trong bảng SachTra
```csharp
public class DataAccess.DataObject.SachTra

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `PhieuTraSach` | PhieuTraSach |  | 
| `Sach` | Sach |  | 
| `Int32` | SoNgayMuon |  | 
| `Int32` | TienPhat |  | 


## `TacGia`

tác giả được lưu trong bảng TacGia
```csharp
public class DataAccess.DataObject.TacGia

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | GhiChu |  | 
| `String` | TenTacGia |  | 


## `TheLoai`

thể loại được lưu trong bảng TheLoai
```csharp
public class DataAccess.DataObject.TheLoai

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | GhiChu |  | 
| `String` | TenTheLoai |  | 


## `ThongTinMuonSach`

thông tin mượn sách được lưu trong bảng TTMuonSach
```csharp
public class DataAccess.DataObject.ThongTinMuonSach

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `DocGia` | DocGia |  | 
| `DateTime` | NgayMuon |  | 
| `Sach` | Sach |  | 


