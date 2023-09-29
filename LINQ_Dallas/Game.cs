using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Dallas
{
    //makes a class that creats 3 objects and then give them its pramaters.
    class Game
    {
        public string Title { get; }

        public char Esrb { get; }

        public string Genre { get; }

        public Game(string title, char esrb, string genre)
        {
            Title = title;
            Esrb = esrb;
            Genre = genre;
        }
    }
}