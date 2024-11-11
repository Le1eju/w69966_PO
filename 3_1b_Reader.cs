using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab03
{
    internal class Reader : Person
    {
        public List<Book> books = new List<Book>();
        public Reader(string FirstName, string LastName, int Age, List<Book> books)
            : base(FirstName, LastName, Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.books = books;
        }

        public override string View() // 3_1c
        {
            return base.View() + ViewBook();
        }

        public string ViewBook()
        {
            string lista = "\nLista książek przeczytanych przez czytelnika:\n";

            if (books.Count == 0)
            {
                lista += "Czytelnik nie przeczytał żadnej książki\n";
            }
            else
            {
                foreach (Book book in books)
                {
                    lista += (" - " + book.Title + "\n");
                }
            }
            return lista;

        }
    }
}
