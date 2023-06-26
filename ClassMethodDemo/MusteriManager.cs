using System.Security.Cryptography.X509Certificates;

class MusteriManager
{

    public void Ekle(Musteri musteri)
    {
       
       
        Console.WriteLine(musteri.TcKimlikNo + " : " + "Kimlik nolu " + "  " + musteri.MusteriAdi + " " + 
            musteri.MusteriSoyadi + " " + "isimli müşteri eklenmiştir.");
        
        
       
        

    }

    public void Sil(Musteri musteri)
    {

        Console.WriteLine(musteri.TcKimlikNo + " : " + "Kimlik nolu " + "  " + musteri.MusteriAdi + " " +
            musteri.MusteriSoyadi + " " + "isimli müşteri silinmiştir.");
       
     

       

    }

    public void Listele(Musteri musteri)
    {

        Console.WriteLine(musteri.TcKimlikNo +" " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi +" " + 
            " isimli müşteri listelenmiştir.");




    }



}