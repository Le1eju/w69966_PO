using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace SharpLab03
{
    internal class Reviewer : Reader
    {
        public Reviewer(string FirstName, string LastName, int Age, List<Book> books)
            : base(FirstName, LastName, Age, books)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.books = books;
        }

        public override string View()
        {
            string lista = "\nLista książek zrecenzowanych przez Reviewer'a:\n";

            if (books.Count == 0)
            {
                lista += "Brak książek do recenzji\n";
            }
            else
            {
                foreach (Book book in books)
                {
                    Random ocena = new Random();
                    lista += ($" - {book.Title}, Ocena { ocena.Next(1, 10) }\n");
                }
            }
            return lista;
        }
    }
}
