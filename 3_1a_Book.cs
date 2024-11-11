using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab03
{
    internal class Book
    {
        protected string title; // 3_1h
        public string Title
        {  
            get => title;
            set { title = value; } 
        }
        protected Person author; // 3_1h
        public Person Author
        { 
            get => author;
            set { author = value; }
        }
        protected DateTime releaseDate; // 3_1h
        public DateTime ReleaseDate 
        {
            get => releaseDate;
            set {  releaseDate = value; } 
        }

        public Book(string title, Person author, DateTime releaseDate)
        {
            this.Title = title;
            this.Author = author;
            this.ReleaseDate = releaseDate;
        }

        public virtual string View()
        {
            return ($"Książka {Title} autorstwa {Author.FirstName} {Author.LastName}, wydana dnia {ReleaseDate.Day}/{ReleaseDate.Month}/{ReleaseDate.Year}");
        }
    }
}
