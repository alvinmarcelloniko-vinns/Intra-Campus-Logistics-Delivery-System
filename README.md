# Aplikasi Pemesanan Layanan Pengiriman Antar Gedung

Proyek ini adalah aplikasi desktop berbasis Windows Form yang digunakan untuk melakukan simulasi transaksi pemesanan layanan pengiriman barang (kurir internal) antar gedung. Aplikasi ini dikembangkan menggunakan bahasa pemrograman **Visual Basic (VB.NET)** pada Visual Studio.

## 📊 Fitur Utama Aplikasi
- **Pemilihan Rute Pengiriman:** Memilih lokasi "Gedung Asal" dan "Gedung Tujuan" melalui komponen drop-down (*ComboBox*).
- **Variasi Jenis Layanan:** Menyediakan pilihan kategori barang yang akan dikirim, meliputi Makanan, Bunga, dan Dokumen.
- **Kalkulasi Biaya & Diskon:** Menghitung harga dasar pengiriman, persentase diskon yang didapatkan, serta total biaya akhir yang harus dibayar berdasarkan jumlah barang yang diinput secara otomatis.
- **Manajemen Input Data:** Form dilengkapi dengan kontrol validasi jumlah barang menggunakan komponen *NumericUpDown* serta tombol aksi untuk memesan dan keluar dari aplikasi.

## 🛠️ Lingkungan Pengembangan & Teknologi
- **Bahasa Pemrograman:** Visual Basic .NET (VB.NET)
- **IDE:** Visual Studio
- **Framework:** .NET Framework

## 📂 Berkas Utama Proyek
Sesuai dengan struktur berkas internal aplikasi, berikut fungsinya:
- `Form1.vb` ➔ Menyimpan seluruh logika kode program (*source code*) utama untuk penentuan harga layanan rute gedung, perhitungan diskon, dan fungsi tombol aksi.
- `Form1.Designer.vb` ➔ Menyimpan struktur tata letak komponen visual antarmuka form aplikasi.
- `WindowsApplication2.vbproj` ➔ Berkas konfigurasi utama proyek Visual Basic.
