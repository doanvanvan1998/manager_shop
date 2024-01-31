using ManagerShop.Model;
using ManagerShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace ManagerShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IBookServices bookServices;

        public HomeController(IBookServices bookServices)
        {
            this.bookServices = bookServices;
        }

        [HttpGet(Name = "GetHomePage")]
        public String HomePage()
        {
            return "helllo";
        }
        [HttpGet]
        [Route("/save")]
        public async Task<IActionResult>  Save()
        {
            List<Book> list_book = bookServices.getAll();
            return Ok(list_book);
        }

    }
}
