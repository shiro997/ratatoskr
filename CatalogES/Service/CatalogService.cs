using AutoMapper;
using CatalogES.Model;
using CatalogES.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogES.Service
{
    public class CatalogService
    {
        private ICatalogRepository _repo;
        private ILogger _logger;
        private IMapper _mapper;

        public CatalogService(CatalogContext context, IMapper mapper)
        {
            _logger = new LoggerFactory().CreateLogger<CatalogService>();
            _repo = new CatalogRepository(context);
            _mapper = mapper;
        }
    }
}
