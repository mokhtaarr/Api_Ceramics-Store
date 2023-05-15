﻿using AutoMapper;
using DAL.interfaces;
using DAL.Repository;
using DAL.Repository.Models;
using DAL.Sepecifications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Dtos;
using StoreApi.Helpers;

namespace StoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseApiController
    {
        //private readonly MoDbContext _db;
        private readonly IProductRepository _ProductRepository;
        private readonly IGenericRepository<SrBrand> _ProductBrandRepository;
        private readonly IGenericRepository<MsItemCategory> _ProductCategoryRepository;
        private readonly IGenericRepository<MsItemCard> _ProductCardRepository;
        private readonly IMapper _mapper;
        public ProductController(IProductRepository ProductRepository, IGenericRepository<SrBrand> ProductBrandRepository, 
            IGenericRepository<MsItemCategory> ProductCategoryRepository, IGenericRepository<MsItemCard> ProductCardRepository, IMapper mapper)
        {
           _ProductRepository = ProductRepository;
            _ProductBrandRepository = ProductBrandRepository;
            _ProductCategoryRepository = ProductCategoryRepository;
            _ProductCardRepository = ProductCardRepository;
            _mapper = mapper;
        }
       

        [HttpGet]
        public async Task<ActionResult<Pagination<ProductDto>>> GetAllProduct([FromQuery]ProductSpecParams productParams)
        {
            var spec = new ProducctWithTypesAndBrandsSpecification(productParams);
            var countSpec = new ProductWithFiltersForCountSepecification(productParams);

            var totalItems = await _ProductCardRepository.CountAsync(countSpec);

            var products = await _ProductCardRepository.ListAsync(spec);
            var data = _mapper.Map<IReadOnlyList<MsItemCard>, IReadOnlyList<ProductDto>>(products);

            return Ok(new Pagination<ProductDto>(productParams.PageIndex, productParams.PageSize, totalItems, data));
        }

        [HttpGet("id")]
        public async Task<ActionResult<ProductDto>>  GetProductById(int id) 
        {
            var spec = new ProducctWithTypesAndBrandsSpecification(id);
            var prd = await _ProductCardRepository.GetEntityWithSpec(spec);
            return _mapper.Map<MsItemCard, ProductDto>(prd);
           
        }

        [HttpGet("Brands")]
        public async Task<IActionResult> GetProductBrands()
        {
            return Ok(await _ProductBrandRepository.ListAllAsync());
        }

        [HttpGet("Types")]
        public async Task<IActionResult> GetProductTypes()
        {
           return Ok(await _ProductCategoryRepository.ListAllAsync());
        }


    }
}
