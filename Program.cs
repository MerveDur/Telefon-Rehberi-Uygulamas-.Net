// See https://aka.ms/new-console-template for more information
using System.Collections;
#nullable disable // String null olabilir uyarısı engelleme

namespace HelloWorld
{
    class Menu
    {
        public void getMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(6) Çıkış Yapmak");
        }
    }
    class kisi
    {
        private string isim;
        private string soyisim;
        private string telefonNumber;
        
        public kisi()
        {
    
        }      
        public kisi(string ad,string soyad,string num)
        {
            isim=ad;
            soyisim=soyad;
            telefonNumber=num;
        }
        public string getIsim() {
            return this.isim;
        }

        public void setIsim(string isim) {
            this.isim = isim;
        }

        public string getSoyisim() {
            return this.soyisim;
        }
        public void setSoyisim(string soyisim) {
            this.soyisim = soyisim;
        }

        public string getTelefonNumber() {
            return this.telefonNumber;
        }
        public void setTelefonNumber(string telefonNumber) {
            this.telefonNumber = telefonNumber;
        }
    }
    class telefonRehberi
    {
        private List<kisi> rehber;

        public telefonRehberi()
        {
            kisi k1=new kisi("Merve","Dur","123456789");
            kisi k2=new kisi("Ali","Demir","495264598");
            kisi k3=new kisi("Ayşe","Ay","4874989");
            kisi k4=new kisi("Nazlı","Güneş","98856256");
            kisi k5=new kisi("Erdal","Yılmaz","1429825984");
            rehber=new List<kisi>();
            rehber.Add(k1);
            rehber.Add(k2);
            rehber.Add(k3);
            rehber.Add(k4);
            rehber.Add(k5);
        }
        public List<kisi> GetRehber()
        {
            return this.rehber;
        }
        public void setRehber(List<kisi> rehber)
        {
            this.rehber = rehber;
        }
        public void numaraKAydet()
        {
            string tempİsim,tempSoyisim,num;
            Console.Write("Lütfen isim giriniz             : ");
            tempİsim=Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          :");
            tempSoyisim=Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz :");
            num=Console.ReadLine();
            kisi k=new kisi(tempİsim,tempSoyisim,num);
            if(k!=null)
            {
                rehber.Add(k);
                Console.WriteLine(tempİsim+" İsimli kişi kaydedildi ...");
                Console.WriteLine("Tekrar seçim yapınız! ");
            }
            else
                Console.WriteLine("Kişi kaydedilemedi tekrar deneyiniz ! ");
        }
        public void numaraSil()
        {
            string tempİsim,select;
            int num=0,flag=0,find=0;

            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            tempİsim=Console.ReadLine();
            for(int i=0;i<rehber.Count;i++)
            {
                if(GetRehber()[i].getIsim()==tempİsim || GetRehber()[i].getSoyisim()==tempİsim)
                {
                    Console.Write(tempİsim+" isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                     select=Console.ReadLine();
                    if(select=="y")
                    {
                        rehber.RemoveAt(i);
                        i=rehber.Count;
                        Console.WriteLine("Silme işlemi gerçekleştirildi tekrar seçim yapınız! ");
                    }
                    find=1;
                }
            }
            if(find==0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                while(flag==0)
                {
                    num=Convert.ToInt32(Console.ReadLine());
                    if(num==1)
                    {
                        flag=1;
                        Console.WriteLine("Tekrar seçim yapınız! ");
                        break;
                    }
                    else if(num==2)
                    {
                        flag=1;
                        Console.WriteLine("İşlem iptal edildi tekrar seçim yapınız! ");
                        numaraSil();

                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız tekrar ddeneyin! ");
                    }
                }
            }
        }
        public void numaraGüncelle()
        {
            string tempİsim,select,telefonNum;
            int num=0,flag=0,find=0;

            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            tempİsim=Console.ReadLine();
            for(int i=0;i<rehber.Count;i++)
            {

                if(GetRehber()[i].getIsim()==tempİsim || GetRehber()[i].getSoyisim()==tempİsim)
                {
                    Console.Write(tempİsim+" isimli kişinin numarasını güncellenmek için onaylıyor musunuz ?(y/n)");
                    select=Console.ReadLine();
                    if(select=="y")
                    {
                        telefonNum=Console.ReadLine();
                        rehber.ElementAt(i).setTelefonNumber(telefonNum);
                        i=rehber.Count;
                        Console.WriteLine("Güncelleme işlemi gerçekleştirildi tekrar seçim yapınız! ");

                    }
                    find=1;  
                }
            }
            if(find==0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                while(flag==0)
                {
                    num=Convert.ToInt32(Console.ReadLine());
                    if(num==1)
                    {
                        flag=1;
                        Console.WriteLine("Tekrar seçim yapınız! ");
                        break;
                    }
                    else if(num==2)
                    {
                        flag=1;
                        Console.WriteLine("İşlem iptal edildi tekrar seçim yapınız! ");
                        numaraGüncelle();

                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız tekrar ddeneyin! ");
                    }
                }
            }
        }
        public void rehberiListele()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach(kisi person in rehber)
            {
                Console.WriteLine(" İsim: "+ person.getIsim());
                Console.WriteLine(" Soyisim: "+ person.getSoyisim());
                Console.WriteLine(" Telefon Numarası: "+ person.getTelefonNumber());
                Console.WriteLine();
            }
        }
        public void numaraAra()
        {
            int num=0;
            string tempİsim;

            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("*İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("*Telefon numarasına göre arama yapmak için: (2)");
            num=Convert.ToInt32(Console.ReadLine());
            if(num==1)
            {
                Console.WriteLine("Arama yapmak istediğiniz kişinin ismini ya da soyismini giriniz: ");
                tempİsim=Console.ReadLine();
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                foreach(kisi person in rehber)
                {
                    if(person.getIsim()==tempİsim || person.getSoyisim()==tempİsim)
                    {
                        Console.WriteLine("İsim: "+ person.getIsim());
                        Console.WriteLine("Soyisim: "+ person.getSoyisim());
                        Console.WriteLine("Telefon Numarası: "+ person.getTelefonNumber());
                    }
                }  
            }  
            else if(num==2)
            {
                Console.WriteLine("Arama yapmak istediğiniz kişinin numarasını giriniz: ");
                tempİsim=Console.ReadLine();
                Console.WriteLine("Arama Sonuçlarınız:");
                Console.WriteLine("**********************************************");
                foreach(kisi person in rehber)
                {
                    if(person.getTelefonNumber()==tempİsim)
                    {
                        Console.WriteLine("İsim: "+ person.getIsim());
                        Console.WriteLine("Soyisim: "+ person.getSoyisim());
                        Console.WriteLine("Telefon Numarası: "+ person.getTelefonNumber());
                    }
                }  
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız tekrar ddeneyin! ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu=new Menu();
            int selection=0;
            telefonRehberi rehberim=new telefonRehberi();

            while(selection!=6)
            {
                menu.getMenu();
                selection=Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        rehberim.numaraKAydet();
                        break;
                    case 2:
                        rehberim.numaraSil();
                        break;
                    case 3:
                        rehberim.numaraGüncelle();
                        break;
                    case 4:
                        rehberim.rehberiListele();
                        break;
                    case 5:
                        rehberim.numaraAra();
                        break;  
                    case 6:
                        break;  
                    default :
                        Console.WriteLine("Try Again!");
                        break;
                }
            }       
        }
    }
}
