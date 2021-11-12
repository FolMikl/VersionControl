using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.feladat
{
    public class PresentFactory : IToyFactory
    {
        public Toy CreateNew()
        {
           
            return new Present(Color1, Color1);
        }
    }
}
