using AutoMapper;
using OnionArchitectureDemo.Application.Dtos;
using OnionArchitectureDemo.Application.Features.Commands.CreateProduct;
using OnionArchitectureDemo.Application.Features.Queries.GetProductById;
using OnionArchitectureDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureDemo.Application.Mapping
{
    public class GeneralMapping: Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, ProductViewDto>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, GetProductByIdViewModel>().ReverseMap();
        }
    }
}
