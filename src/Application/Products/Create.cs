using Application.Core;
using Domain;
using Infrastructure.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Products
{
    public class Create
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Product Product { get; set; }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly IProductRepository _productRepository;

            public Handler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var result = await _productRepository.CreateProductAsync(request.Product);

                if (!result) return Result<Unit>.Failure("Failed to create product, check your data");

                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}
