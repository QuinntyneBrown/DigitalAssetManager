using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using DigitalAssetManager.Api.Core;
using DigitalAssetManager.Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DigitalAssetManager.Api.Features
{
    public class GetDigitalAssets
    {
        public class Request: IRequest<Response> { }

        public class Response: ResponseBase
        {
            public List<DigitalAssetDto> DigitalAssets { get; set; }
        }

        public class Handler: IRequestHandler<Request, Response>
        {
            private readonly IDigitalAssetManagerDbContext _context;
        
            public Handler(IDigitalAssetManagerDbContext context)
                => _context = context;
        
            public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
            {
                return new () {
                    DigitalAssets = await _context.DigitalAssets.Select(x => x.ToDto()).ToListAsync()
                };
            }
            
        }
    }
}
