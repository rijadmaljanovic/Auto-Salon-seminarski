using AutoMapper;
using MusicApp.Core.Entities;
using MusicApp.Infrastructure;
using MusicApplication.Core.Models;
using MusicApplication.Infrastructure.Repositories.Base;
using MusicApplication.Requests.Category;
using System.Collections.Generic;
using System.Linq;

namespace MusicApplication.Infrastructure.Repositories.Categories
{
    public class CategoriesRepository : BaseRepository<KategorijaModel, CategorySearchRequest, Kategorija, CategoryUpsertRequest, CategoryUpsertRequest>
    {
        private readonly IMapper _mapper;
        public CategoriesRepository(DatabaseContext databaseContext, IMapper mapper) : base(databaseContext, mapper)
        {
            _mapper = mapper;
        }
        public override IEnumerable<KategorijaModel> Get()
        {
            var query = _databaseContext.Kategorija.AsQueryable();
            return _mapper.Map<IEnumerable<KategorijaModel>>(query.ToList());
        }


    }
}
