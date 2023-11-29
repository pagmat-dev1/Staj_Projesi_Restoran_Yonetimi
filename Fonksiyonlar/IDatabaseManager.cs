
namespace Staj_Projesi_Restoran_Yonetimi.Fonksiyonlar
{
    public interface IDatabaseManager
    {
        Task<Meyve> GetMeyveById(int id);
    }
}