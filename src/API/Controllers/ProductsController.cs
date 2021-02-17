using Application.Products;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ProductsController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> List()
        {
            return HandleResult(await Mediator.Send(new List.Query()));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            return HandleResult(await Mediator.Send(new Create.Command { Product = product }));
        }
    }
}
