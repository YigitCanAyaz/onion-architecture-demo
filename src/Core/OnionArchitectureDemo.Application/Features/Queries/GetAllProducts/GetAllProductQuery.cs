using AutoMapper;
using MediatR;
using OnionArchitectureDemo.Application.Dtos;
using OnionArchitectureDemo.Application.Interfaces.Repository;
using OnionArchitectureDemo.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureDemo.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery: IRequest<ServiceResponse<List<ProductViewDto>>>
    {

        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<ProductViewDto>>>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public GetAllProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var products = await _productRepository.GetAllAsync();

                var viewModel = _mapper.Map<List<ProductViewDto>>(products);

                return new ServiceResponse<List<ProductViewDto>>(viewModel);
            }
        }
    }
}
