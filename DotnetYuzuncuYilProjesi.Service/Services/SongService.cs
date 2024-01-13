using DotnetYuzuncuYilProjesi.Core;
using DotnetYuzuncuYilProjesi.Core.Repositories;
using DotnetYuzuncuYilProjesi.Core.Services;
using DotnetYuzuncuYilProjesi.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Service.Services
{
    public class SongService : Service<Song>, ISongService
    {
        public SongService(IGenericRepository<Song> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
