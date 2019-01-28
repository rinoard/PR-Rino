ALTER TABLE Dosen
ALTER COLUMN Nama_Dosen VarChar(200)

SELECT Mahasiswa.Kode_Mahasiswa ,Mahasiswa.Nama_Mahasiswa ,Jurusan .Nama_Jurusan ,Agama.Deskripsi 
FROM ((Mahasiswa 
INNER JOIN Jurusan ON Mahasiswa.Kode_Jurusan = Jurusan .Kode_Jurusan )
INNER JOIN Agama ON Mahasiswa.Kode_Agama  = Agama .Kode_Agama )

SELECT Mahasiswa.*, Jurusan .Status_Jurusan 
FROM (Mahasiswa
JOIN Jurusan ON Mahasiswa .Kode_Jurusan =Jurusan .Kode_Jurusan )
Where Jurusan .Status_Jurusan ='Non Aktif'

SELECT Mahasiswa.*, Jurusan .Status_Jurusan ,Nilai .Nilai 
FROM ((Mahasiswa
JOIN Jurusan ON Mahasiswa .Kode_Jurusan =Jurusan .Kode_Jurusan )
JOIN Nilai ON Mahasiswa .Kode_Mahasiswa =Nilai .Kode_Mahasiswa )
Where Jurusan .Status_Jurusan ='Aktif'AND Nilai > 80

SELECT * FROM Jurusan 
WHERE Nama_Jurusan LIKE '%sistem%'

SELECT Nama_Mahasiswa, COUNT(*) FROM Nilai 
INNER JOIN Mahasiswa ON Nilai.Kode_Mahasiswa = Mahasiswa.Kode_Mahasiswa
GROUP BY Nama_Mahasiswa
HAVING COUNT(*) >=2;

CREATE VIEW Tampil AS
	SELECT Mahasiswa .Kode_Mahasiswa ,Mahasiswa .Nama_Mahasiswa ,Jurusan .Nama_Jurusan ,Agama .Deskripsi as Agama,Dosen .Nama_Dosen ,Jurusan .Status_Jurusan ,Type_Dosen .Deskripsi 
	FROM ((((Mahasiswa 
	JOIN Jurusan ON Mahasiswa.Kode_Jurusan =Jurusan .Kode_Jurusan) 
	JOIN Agama ON Mahasiswa .Kode_Agama =Agama .Kode_Agama )
	LEFT JOIN Dosen ON Jurusan .Kode_Jurusan =Dosen .Kode_Jurusan )
	LEFT JOIN Type_Dosen ON Dosen .Kode_Type_Dosen =Type_Dosen .Kode_Type_Dosen )
	WHERE Nama_Mahasiswa LIKE '%Budi%'

SELECT * From Tampil
