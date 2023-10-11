using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemmaövning_Media
{
    internal abstract class Media
    {   
        public string Title { get; set; }
        public string Year { get; set; }     
        public string Genre { get; set; }

        public abstract void DisplayInfo();
     
    }
}
