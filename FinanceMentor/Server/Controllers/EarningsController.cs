using System.Collections;
using System.Collections.Generic;
using FinanceMentor.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FinanceMentor.Server.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class EarningsController
    {
        private readonly IRepository<Earning> _earningRepository;

        public EarningsController(IRepository<Earning> earningRepository)
        {
            _earningRepository = earningRepository;
        }

        [HttpGet]
        public IEnumerable<Earning> Get()
        {
            return _earningRepository.GetAll()
                .OrderBy(earning => earning.Date);
        }
    }
}