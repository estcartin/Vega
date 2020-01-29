using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega.Core.Models;
using Vega.Core.Models.Resources;
using Vega.Persistence;

namespace Vega.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly VegaDbContext _dbContext;
        private readonly IMapper _mapper;

        public FeaturesController(VegaDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        // GET: api/Features
        [HttpGet]
        public async Task<IEnumerable<KeyValuePairResource>> GetFeatures()
        {
            var features = await _dbContext.Features.ToListAsync();
            return _mapper.Map<List<Feature>, List<KeyValuePairResource>>(features);
        }
    }
}