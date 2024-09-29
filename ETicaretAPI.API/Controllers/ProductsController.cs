using ETicaretAPI.Application.Abstraction;
using ETicaretAPI.Application.Features.Commands.Product.CreateProuct;
using ETicaretAPI.Application.Features.Commands.Product.RemoveProduct;
using ETicaretAPI.Application.Features.Commands.Product.UpdateProduct;
using ETicaretAPI.Application.Features.Queries.Product.GetAllProduct;
using ETicaretAPI.Application.Features.Queries.Product.GetByIdProduct;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Application.RequestParamters;
using ETicaretAPI.Application.Services;
using ETicaretAPI.Application.ViewModals.Products;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        readonly IFileService _fileService;
        //readonly IFileWriteRepository _fileWriteRepository;
        //readonly IFileReadRepository _fileReadRepository;
        //readonly IProductImageFileReadRepository _productImageFileReadRepository;
        //readonly IProductImageFileWriteRepository _productImageFileWriteRepository;
        //readonly IInvoiceFileReadRepository _invoiceFileReadRepository;
        //readonly IInvoiceFileWriteRepository _invoiceFileWriteRepository;

        readonly IMediator _mediator;


        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;
       

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IWebHostEnvironment webHostEnvironment, IFileService fileService, IMediator mediator)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _webHostEnvironment = webHostEnvironment;
            _mediator = mediator;
            //_fileService = fileService;
            //_fileWriteRepository = fileWriteRepository;
            //_fileReadRepository = fileReadRepository;
            //_productImageFileReadRepository = productImageFileReadRepository;
            //_productImageFileWriteRepository = productImageFileWriteRepository;
            //_invoiceFileReadRepository = invoiceFileReadRepository;
            //_invoiceFileWriteRepository = invoiceFileWriteRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest)
        {
         GetAllProductQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
          return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute]GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
         GetByIdProductQueryResponse response = await _mediator.Send(getByIdProductQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommandRequest createProductCommandRequest)
        {
          CreateProductCommandResponse response = await _mediator.Send(createProductCommandRequest);
          return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody]UpdateProductCommandRequest updateProductCommandRequest)
        {
          
          UpdateProductCommandResponse response = await _mediator.Send(updateProductCommandRequest);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveProductCommandRequest removeProductCommandRequest)
        {
         RemoveProductCommandResponse response = await _mediator.Send(removeProductCommandRequest);
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload()
        {
           await _fileService.UploadAsync("resource/products-images", Request.Form.Files);
            //_productImageFileWriteRepository.AddRangeAsync(datas.Select(d => new ProductImageFile()
            //{
            //    FileName = d.fileName,
            //    Path = d.path
            //}).ToList());
            //await _productImageFileWriteRepository.SaveAsync();
            return Ok();
        }
    } 
}
