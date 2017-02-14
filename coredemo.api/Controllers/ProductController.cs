using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coredemo.dal.Repositories;
using coredemo.model;
using coredemo.model.ViewModels;
using coredemo.services;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace coredemo.api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ProductsService _productService;

        public ProductController(ProductsService productsService)
        {
            _productService = productsService;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAllProducts();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetByProductById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Product prod)
        {
            if (ModelState.IsValid)
                _productService.CreateNewProduct(prod);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product prod)
        {
            prod.ProductId = id;
            if (ModelState.IsValid)
                _productService.UpdateProduct(id, prod);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
