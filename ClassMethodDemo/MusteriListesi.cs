using System.Net.WebSockets;

Musteri musteri1 = new Musteri();

musteri1.TcKimlikNo = "10541948254";
musteri1.MusteriAdi = "Kaan";
musteri1.MusteriSoyadi = "Demirel";

Musteri musteri2 = new Musteri();

musteri2.TcKimlikNo = "10524748741";
musteri2.MusteriAdi = "Nejat";
musteri2.MusteriSoyadi = "Keskin";


Musteri musteri3 = new Musteri();

musteri3.TcKimlikNo = "10335946114";
musteri3.MusteriAdi = "Selin";
musteri3.MusteriSoyadi = "Soylu";




MusteriManager musterimanager = new MusteriManager();
Musteri[] musteriler = new Musteri[] { };




musterimanager.Ekle(musteri1);
musterimanager.Sil(musteri2);
musterimanager.Listele(musteri3);
















