using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab03
{
    internal class DocumentaryBook : Book
    {
        private string genre;
        public string Genre
        {
            get => genre;
            set => genre = value;
        }

        public DocumentaryBook(string title, Person author, DateTime releaseDate) : base(title, author, releaseDate)
        {
            this.Title = title;
            this.Author = author;
            this.ReleaseDate = releaseDate;
            this.Genre = "Documentary";
        }

        public override string View()
        {
            return base.View() + ($", gatunek: {Genre}");
        }
    }
}

