using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CargoConnect.Application.Services.Interfaces;

namespace CargoConnect.Application.Services.Implementations
{
    public class MappingService : IMappingService
    {
        IMapper _mapper;

        public MappingService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TDest Map<TSource, TDest>(TSource source)
        {
            return _mapper.Map<TSource, TDest>(source);
        }
    }
}
