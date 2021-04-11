using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using DigitalAssetManager.Api.Core;
using DigitalAssetManager.Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DigitalAssetManager.Api.Features
{
    public class GetDigitalAssetById
    {
        public class Request: IRequest<Response>
        {
            public Guid DigitalAssetId { get; set; }
        }

        public class Response: ResponseBase
        {
            public DigitalAssetDto DigitalAsset { get; set; }
        }

        public class Handler: IRequestHandler<Request, Response>
        {
            private readonly IDigitalAssetManagerDbContext _context;
        
            public Handler(IDigitalAssetManagerDbContext context)
                => _context = context;
        
            public async Task<Response> Handle(Request request, CancellationToken cancellationToken)
            {
                return new () {
                    DigitalAsset = (await _context.DigitalAssets.SingleOrDefaultAsync()).ToDto()
                };
            }
            
        }
    }
}
