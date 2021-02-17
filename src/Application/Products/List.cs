using Application.Core;
using Domain;
using Infrastructure.Contracts;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Products
{
    public class List
    {
        public class Query : IRequest<Result<List<Product>>> { }

        public class Handler : IRequestHandler<Query, Result<List<Product>>>
        {
            private readonly IProductRepository _productRepository;

            public Handler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<Result<List<Product>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var data = await _productRepository.GetProductsAsync();

                return Result<List<Product>>.Success(data);
            }
        }
    }
}
