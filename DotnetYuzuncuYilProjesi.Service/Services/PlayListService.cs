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
    public class PlayListService : Service<PlayList>, IPlayListService
    {
        public PlayListService(IGenericRepository<PlayList> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
