using LojaVirtual.Interfaces;
using LojaVirtual.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductViewModelService _productViewModelService;

        public ProductsController(IProductViewModelService productViewModelService)
        {
            _productViewModelService = productViewModelService;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<ProductViewModel>> GetProduct(string filter, string sortOrder)
        {
            var productList = _productViewModelService.GetAll(filter, sortOrder);
            return Ok(productList);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<ProductViewModel> Get(int id)
        {
            var viewModel = _productViewModelService.Get(id);
            if (viewModel == null)
            {
                return NotFound();
            }

            return Ok(viewModel);
        }

        // POST: api/Products
        [HttpPost]
        public IActionResult Create(ProductViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productViewModelService.Insert(viewModel);
                    return Ok();
                }

                return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productViewModelService.Update(viewModel);
                    return Ok();
                }

                return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productViewModelService.Delete(id);
                    return Ok();
                }

                return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
