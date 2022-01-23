using Nozama.Models.DTOS;
using Nozama.Models.Repositories;

namespace Nozama.Models.Services
{
    public class BookService : InterfaceBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {     
        _bookRepository = bookRepository;
        }
        public List<LivrosDto> Listar()
        {

            try
            {
                return _bookRepository.Listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           

        }
    }
}
