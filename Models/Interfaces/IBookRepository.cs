using Nozama.Models.DTOS;

namespace Nozama.Models.Repositories
{
    public interface IBookRepository
    {
        List<LivrosDto> Listar();
    }

}
