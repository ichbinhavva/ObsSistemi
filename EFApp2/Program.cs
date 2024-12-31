namespace EFApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //INSERT
            /*
            var ogr = new Ogrenci { Ad = "asdklasdf", Soyad = "asdgsadg", Numara = "345" };

            //DbContext'ten bir nesne oluşturuyoruz ki içindeki yapıyı kullanabilelim, oradaki dbset'imize
            using (var ctx = new OkulDbContext())
            {
                ctx.Ogrenciler.Add(ogr);
                //Ramdeki bir nesneyi ram deki bir dbset e atmış olduk.
                int sonuc = ctx.SaveChanges();
                Console.WriteLine(sonuc > 0 ? "İşlem Başarılı" : "İşlem Başarısız!");
            }
            */




            // UPDATE
            /*
            using (var ctx = new OkulDbContext())
            {
                var ogr = ctx.Ogrenciler.Find(2); //id si 2 olan ogrenciyi bul diyoruz
                ogr.Numara = "789";
                ctx.Entry(ogr).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.SaveChanges();
            }
            */





            //SELECT
            /*
            using (var ctx = new OkulDbContext())
            {
                //Burası sebebiyle Ogrenci.cs e ToString override ı yaptık. Override öncesinde sadece veri tipini veriyordu tostring de.
                var lst = ctx.Ogrenciler.ToList();
                foreach(var item in lst)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            */



            //DELETE

            using (var ctx = new OkulDbContext())
            {
                var ogr = ctx.Ogrenciler.Find(1);
                ctx.Ogrenciler.Remove(ogr);
                ctx.SaveChanges();
            }

        }
    }
}

//savechanges metodu DbContext metodu içinden geliyor.
//Her entity nin bir state i olur. dbset oluşturunca state column u oluşturuyor kendisi ve bizim yapmak istediğimiz işlemlerin ne işlemi olduğunu state column u bilgisini tutuyor. Ardından save changes yapınca ram de tutulan dbsetler state leri de sayesinde gereken işlemleri database e gerçekleştiriyor. State deki işlemin crud komutunu diyelim, kendisi yazıyor. Şart varsa onu ekliyormuşuz zaten şuan görmedik ama belirtince onu da ekliyormuş.
//Dispose edilmeyen şeyler olabilir çünkü bu framework onu yapmıyor. Dispose u direkt olarak aşağıya yazmak olmuyordu hatırla, using kullanımı gerekiyor.
//SQL server Profiler ile sql de gerçekleşip, arkada olup biten etkinlikleri detaylıca kontrol edebiliyoruz derste komutu çalıştırınca hocayla oradan da çalışan komutu takip ettik, ne yazdığını gördük. Framework gerçekten de kendisi bir komut çizdi ve orada görüyoruz.
//EntityState bir enum muş
//Find() id ye odaklanıp onda verilen sayıyı arıyor. Eğer başka bir şeye odaklanıp onda arama yapmak isteseydik where metodunu kullanmamız gerekirdi(hoca örnekle gösterdi orada da lambda ve o harfli o delegate dediği yapıyı kullanıp bir o nun bir sütununa göre eşitlik koşulu koydu. Başka sütun yoktu id üzerinden yaptık galiba)


//.net versiyonu entity framework için önemli olabiliyormuş. NuGet de paket indirirken açtığın versiyonun pakette var olan en son halini indir.
//Entity Framework dediğimiz yapı tek bir dll dosyası olsa tek bir referans göstermeyle hallederdik. NuGetse birsürü paket ve dll barındıran yapıları tek bir yerde toplayıp kolayca ulaşabilmemizi sağlıyor.
//Tüm veritabanlarına bağlananı istersen sonunda .SqlServer olanı değil olmayanı seçmelisin.
//Projenin bağımlılıklarını(dependencies) görmek için proje altındaki dependencies kısmında
//.dll ve bu tarz dosyalarla bağlantı kurmamız projemiz için bir bağımlılık anlamına geliyor. Bağımlılığı tanımlayan şey dosya olarak projenin içinde bulunmayan ve ihtiyaç duyulan bir kod parçacığının dışarıdan alınması. Kendimiz bir dll yazıp erişince o da bir bağımlılık çünkü proje içinde yazılmış bir şey çağrılmıyor hazırlanmış bir dosyaya erişim var dll olayı da bu sanırsam


//Paketlerle uğraşma olayını kolaylaştıran bir durumda sanallaştırmadaki bu container olayı. Oraya da bağlanıyor konu bi çalışırken bak buraya.
//Öylesine meraktan: Dependencies Hell i araştır.


//Bu haftanın(12. haftanın) konusu entity framework.

/*
 * Her nesne entity(varlık) değildir.
 * Frameworkler bir şeyleri yapabilmek için hazır kodlar sağlar.
 * Entity Framework verisel işlemleri daha hızlı ve sade bir şekilde yapabilmemizi sağlayan bir framework.
 * Büyük firmalar küçük startupları ve girişimleri satın alıyor(entity framework örnektir)
 * 
 * Entity ->DbSet->SaveChanges()->DB
 * 
 * Veritabanlarındaki tabloların bellekteki karşılığına dbset diyoruz.
 * dbsetin tipi bizim varlığımızda oluyor. DbSet<Ogrenci> gibi
 * Entity state otomatik oluşur, her entitynin bir statei(durumu) olur. Added, modified, deleted gibi durum değişiklikleri not alınır.
 * Entityleri dbsetler üzerinden işlem yaparak etkili bir şekilde kontorl yapar değişiklik yaparız. Ardından SaveChanges() çalıştığında EntityState lere bakaraktan gerekli işlem üzerine otomatik olarak sorgu yazar ve işlemi database üzerinde execute eder.
 * 
 * Connection, sqlcomment, sql komutlarını yazmak, ve diğer ekstra işlemleri biz entity framework sayesinde yapmaktan kurtuluyoruz.
 * Entity framework dispose yapmıyor 
 * codefirst, databasefirst olarak iki yaklaşım var. Önce database i yapıp sonra model classları/entityleri vs. yazmak databasefirst yaklaşımı. İlk yazılım tarafından başlayıp sonra database e girmekse codefirst yaklaşımı.
 * 
 * Entity framework gibi teknoloji araçlarının ismi ORM(Object Relational Mapping) Tool dur. 
 * Microsoft un ORM si Entity Framework
 * Javanın ORM si Hibernet gibi
 * 
 * 
 * EF Code First
 * --------------
 * EntityFrameworkCore.SqlServer
 * EntityFrameworkCore.Tools --> EF ile alakalı komutları kullanmamızı sağladı olmasa bu migration ı felan yapamıyorduk nuget cli ından.
 * Model(Entity) Class
 * DbContext class
 * add-migration
 * 
 */