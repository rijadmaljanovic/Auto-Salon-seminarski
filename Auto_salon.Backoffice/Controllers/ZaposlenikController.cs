using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MusicApp.Core.Entities;
using MusicApp.Infrastructure;
using MusicApplication.Core.Models;
using MusicApplication.Infrastructure.Repositories.Base;
using MusicApplication.Requests.Zaposlenik;

namespace MusicApplication.Backoffice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZaposlenikController : BaseController<ZaposlenikModel, EmployeeSearchRequest, EmployeeUpsertRequest, EmployeeUpsertRequest>
    {
        public ZaposlenikController(IBaseRepository<ZaposlenikModel, EmployeeSearchRequest, EmployeeUpsertRequest, EmployeeUpsertRequest> repository) : base(repository)
        {
        }
    }
}
