using AutoMapper;
using MusicApp.Core.Entities;
using MusicApplication.Core.Models;
using MusicApplication.Requests.Category;
using MusicApplication.Requests.Zaposlenik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplication.Backoffice.AutoMapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Zaposlenik, ZaposlenikModel>().ReverseMap();
            CreateMap<Zaposlenik, EmployeeUpsertRequest>().ReverseMap();
            CreateMap<ZaposlenikModel, EmployeeSearchRequest>().ReverseMap();

            CreateMap<Kategorija, KategorijaModel>().ReverseMap();
            CreateMap<Kategorija, CategoryUpsertRequest>().ReverseMap();
            CreateMap<KategorijaModel, CategorySearchRequest>().ReverseMap();
        }

    }
}
