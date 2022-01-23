using Microsoft.AspNetCore.Mvc;
using Nozama.Models.Repositories;
using Nozama.Models.Services;

namespace Nozama.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult List()
        {
            try
            {
                var livros = _bookRepository.Listar();
                return View(livros);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
