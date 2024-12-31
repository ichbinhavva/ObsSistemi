using Microsoft.EntityFrameworkCore;//kalıtım sonucu eklendi

namespace EFApp
{
    internal class OkulDbContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; } //Ogrenciler isminde tablo oluşturacak DbSet i iyi anlamalısın.

        //Connectionstring belirtmemiz gerek usta, böyle olmaz onsuz ne yapar bu kodlar.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=OkulDbSube1EF; Integrated Security=true; TrustServerCertificate=true");//Bu database ismiyle kendi yaratacak

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Ogrenci>().Property(o => o.Numara).HasColumnType("varchar").HasMaxLength(10).IsRequired();
        }


    }
}

//DbContext classı: EF içerisinde veritabanı işlemlerini yapmak için kullanılan class. Örn. CRUD işlemleri. Her projenin ayrı bir DbContext classı olmalıdır. Her projenin DB'si kendisine özgüdür.
//DbContext bir database e yöneliyor, her database için bir dbcontext tarzında bir olay var.
//Code First yaptığımız için veritabanımız yok bu ilk aşamalarda
//DbSet: DB'deki tabloları bellekte temsil eder. Generic yapılardır dolayısıyla hangi entity tipinde oluşturulursa o tipteki alanları içerir. Db için sorguları çalıştırmak için kullanılır. Örn. Ogrenci tipi için, OgrenciId, Ad, Soyad, Numara.

//TEntityler sadece class olabilir --> bu yazıyı(where kısmını) DbSet üstüne gelince gördük. Generic yapılar, koleksiyonlar vs. konularda eksiklerin var bunları tespit edip çalış.

//Migration Classları: EF Code First tekniğinde, kod ile yapılan işlemlerin DB'ye aktarılması için gerekli olan classlardır. Bu classlar her kod değişiminde oluşturulmalıdır. Migration class'ı oluşturmak için add-migration komutu kullanılır.

//Migration tanımı yaparken bu bir class olacağı için isme dikkat etmekte fayda var. Class komutu yazınca gelen yazılara dikkat et. Build etti onu farket, bir hata varsa mesela migration yapma onu gider vs.

//Önemli: Belirli değişiklikler sonrasında projeyi build etmelisin. Bunu yapmadığın durumda örneğin proje build olmadığı için nuget cli ındaki bir hareketin eski proje haline göre baz alınarak çalışmaya çalışır gibi gibi gibi bir durum var.

//Code First yaklaşımında database e DOKUNMUYORUZ. Bu yaklaşımda migration ve database ayarları/uğraşları code tarafından yapılıyor


//data annotations sonraki hafta konusu. İki teknik var birşeyleri değiştirmek için. Artı crud işlemlerine bakıcaz.