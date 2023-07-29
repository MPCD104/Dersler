using Kariyer.Kutuphane.Business.Abstracts;
using Kariyer.Kutuphane.DataAccess.Repository.Abstracts;
using Kariyer.Kutuphane.Entities;

namespace Kariyer.Kutuphane.Business
{
    public class KitapManager : IKitapManager
    {
        private readonly IKitapRepository kitapRepository;

        public KitapManager(IKitapRepository kitapRepository)
        {
            this.kitapRepository = kitapRepository;
        }

        public List<Kitap> GetKitapList()
        {
            return kitapRepository.GetAll();
        }
    }
}
