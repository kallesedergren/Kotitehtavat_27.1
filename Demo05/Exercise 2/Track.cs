using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Track
    {
        public string Title { get; set; }
        public string Length { get; set; }

        public override string ToString()
        {
            return Title + ", " + Length;
        }
    }
}