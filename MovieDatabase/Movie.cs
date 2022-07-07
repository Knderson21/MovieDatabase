using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    internal class Movie
    {
        //properties
        public string Title { get; set; }
        public string Category { get; set; }

        public Movie(string _title, string _category)
        {
            Title = _title;
            Category = _category;
        }


        //methods
        public virtual string DisplayMovies(string category)
        {
            return Console.WriteLine($" {Title}  ");
        }
    }
}
