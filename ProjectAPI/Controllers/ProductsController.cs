using BusinessLayer.Abstract;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productManager;

        public ProductsController(IProductService productManager)
        {
            _productManager = productManager;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return _productManager.GetList().ToList();
        }

        // GET api/<ProductsController>/1
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            if (id < 1)
                return BadRequest();

            if (_productManager.GetList().Where(a => a.Id == id).Count() == 0)
                return NotFound();
            else

                try
                {
                    return _productManager.GetByID(id);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

        }

        // POST api/<ProductsController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Product product)
        {
            return _productManager.Add(product);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, Product product)
        {
            return _productManager.Update(product);
        }

        // DELETE api/<ProductsController>/2
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _productManager.Delete(id);
        }


    }
}
