using Nozama.Models.DTOS;

namespace Nozama.Models.Repositories
{
    public class BookRepository : IBookRepository
    {
        // Acessa o banco de dados fake carregando o list criado e mostra o que tem armazendoa em ordem alfabetica

        public List<LivrosDto> Listar() 
        {
            var livros = DatabaseFake.Livros;
            return livros
                .OrderBy(N => N.Name)
                .ToList();
            //Retorno de exceção caso a listar sair do contexto
            throw new NotImplementedException();
        }
    }
}
