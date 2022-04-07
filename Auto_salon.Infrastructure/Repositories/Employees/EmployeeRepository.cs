using AutoMapper;
using MusicApp.Core.Entities;
using MusicApp.Infrastructure;
using MusicApplication.Core.Models;
using MusicApplication.Infrastructure.Repositories.Base;
using MusicApplication.Requests.Zaposlenik;
using System.Collections.Generic;
using System.Linq;

namespace MusicApplication.Infrastructure.Repositories.Songs
{
    public class EmployeeRepository : BaseRepository<ZaposlenikModel, EmployeeSearchRequest, Zaposlenik, EmployeeUpsertRequest, EmployeeUpsertRequest>
    {
        private readonly IMapper _mapper;
        
        public EmployeeRepository(DatabaseContext databaseContext, IMapper mapper) : base(databaseContext, mapper)
        {
            _mapper = mapper;
        }
        public List<string> All()
        {
            List<string> mailovi = new List<string>();
            foreach (var item in _databaseContext.Zaposlenik)
            {
                mailovi.Add(item.Adresa);
            }
            return mailovi;
        }
        public override IEnumerable<ZaposlenikModel> Get()
        {
            var result = _databaseContext.Zaposlenik.ToList();

            return _mapper.Map<IEnumerable<ZaposlenikModel>>(result);
        }
        public override IEnumerable<ZaposlenikModel> Search(EmployeeSearchRequest request)
        {
            var query = _databaseContext.Zaposlenik.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Name))
            {
                query = query.Where(x => x.Ime.ToLower().Contains(request.Name.ToLower()));
            }

            return _mapper.Map<IEnumerable<ZaposlenikModel>>(query.ToList());
        }

    }
}
