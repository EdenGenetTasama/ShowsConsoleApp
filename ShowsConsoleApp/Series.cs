using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowsConsoleApp
{
    internal class Series : IComparable
    {
        public string name;
        public string genre;
        public int numberOfEps;

        public Series(string _name, string _genre, int _numberOfEps)
        {
            this.name = _name;
            this.genre = _genre;
            this.numberOfEps = _numberOfEps;
        }

        public string Name { get; set; }
        public string Genre { get; set; }
        public int NumberOfEps { get; set; }

        public int CompareTo(object obj)
        {
            Series p = (Series)obj;
            if (this.numberOfEps < p.numberOfEps) return -1;
            if (this.numberOfEps > p.numberOfEps) return 1;
            return 0;
        }



    }
}
