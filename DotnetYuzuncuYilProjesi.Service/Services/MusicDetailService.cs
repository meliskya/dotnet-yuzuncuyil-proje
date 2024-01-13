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
    public class MusicDetailService : Service<MusicDetail>, IMusicDetailService
    {
        public MusicDetailService(IGenericRepository<MusicDetail> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
