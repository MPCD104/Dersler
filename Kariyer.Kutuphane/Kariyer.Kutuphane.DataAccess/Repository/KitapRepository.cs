using Kariyer.Kutuphane.DataAccess.Context;
using Kariyer.Kutuphane.DataAccess.Repository.Abstracts;
using Kariyer.Kutuphane.DataAccess.Repository.GenericRepository;
using Kariyer.Kutuphane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Kutuphane.DataAccess.Repository
{
    public class KitapRepository : GenericRepository<Kitap>, IKitapRepository
    {
        public KitapRepository(KariyerKutuphaneContext kariyerKutuphaneContext) 
            : base(kariyerKutuphaneContext)
        {
        }

        public List<Kitap> GetByKitapName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
