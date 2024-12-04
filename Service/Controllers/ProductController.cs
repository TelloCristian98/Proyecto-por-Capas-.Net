using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using BLL;
using Entities;
using SLC;

namespace Service.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateProducts(Products products)
        {
            var product = _productService.CreateProducts(products);
            return Ok(product);
        }

        [System.Web.Http.HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var isDeleted = _productService.Delete(id);
            return Ok(isDeleted);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult Filter(string filterName)
        {
            var products = _productService.Filter(filterName);
            return Ok(products);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult RetrieveById(int id)
        {
            var product = _productService.RetrieveById(id);
            return Ok(product);
        }

        [System.Web.Http.HttpPut]
        public IHttpActionResult Update(Products product)
        {
            var isUpdated = _productService.Update(product);
            return Ok(isUpdated);
        }
    }
}
