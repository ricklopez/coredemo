using coredemo.dal.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coredemo.contracts.Repositories;
using coredemo.model;

namespace coredemo.services
{
    public class ProductsService
    {
        private readonly IBaseRepository<Product> _productRepository;

        public ProductsService(IBaseRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IList<Product> GetAllProducts()
        {
           return _productRepository.GetAll().ToList();
        }

        public Product GetByProductById(int id)
        {
            return _productRepository.GetByID(id);
        }

        public void CreateNewProduct(Product product)
        {
            _productRepository.Add(product);
        }

        public void UpdateProduct(int id, Product product)
        {
            product.ProductId = id;
            _productRepository.Update(product);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.Delete(id);
        }


    }
}
