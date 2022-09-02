namespace NLayerApp.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        // UnitOfWork
        // EFCore'da repository'lerde yapılan tüm değişikler SaveChanges metodu çağırılmadan veritabanına kaydedilmez.
        // EFCore tüm verileri Memory'de kaydeder. Eğer SaveChanges metodu başarılı olursa değişiklikler vetibanına yansıtılır.
        // Eğer başarısız olursa tüm değişiklikler geri alınır.
        // UnitOfWork yapısı bir Transaction yapısıdır. Repository'lerde yapılan tüm değişiklikleri yönetmek için kullanılır. 
        Task? CommitAsync();
        void Commit();
    }
}
