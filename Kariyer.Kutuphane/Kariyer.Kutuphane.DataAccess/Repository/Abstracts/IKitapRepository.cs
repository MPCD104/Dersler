using Kariyer.Kutuphane.DataAccess.Repository.GenericRepository;
using Kariyer.Kutuphane.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kariyer.Kutuphane.DataAccess.Repository.Abstracts
{
    public interface IKitapRepository : IGenericRepository<Kitap>
    {
        List<Kitap> GetByKitapName(string name);
    }
}
