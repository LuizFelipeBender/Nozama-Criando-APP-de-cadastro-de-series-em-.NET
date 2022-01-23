using Nozama.Models.DTOS;
using System;
using System.Collections.Generic;

namespace Nozama.Models.Repositories
{
    public class DatabaseFake
    {
        public static List<LivrosDto> Livros;

        static DatabaseFake()
        {
            Livros = new List<LivrosDto>();
            InitializeData();
        }

        private static void InitializeData()
        {
            var books = new LivrosDto("O nome do vento (A Crônica do Matador do Rei – Livro 1)", "Patrick Rothfuss", "Arqueiro", "Aventura", 9788599296493);
            Livros.Add(books);

            books = new LivrosDto("O temor do sábio (A Crônica do Matador do Rei – Livro 2)", "Patrick Rothfuss", "Arqueiro", "Aventura", 9788580410327);
            Livros.Add(books);

            books = new LivrosDto("O nome do vento – Edição luxo (A Crônica do Matador do Rei – Livro 1)", "Patrick Rothfuss", "Arqueiro", "Aventura", 9786555651850);
            Livros.Add(books);

            books = new LivrosDto("A música do silêncio (A Crônica do Matador do Rei – Livro 3)", "Patrick Rothfuss", "Arqueiro", "Aventura",9788580413533);
            Livros.Add(books);
        }
         


}
}
    

