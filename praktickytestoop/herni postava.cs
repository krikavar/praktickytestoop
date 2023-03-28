using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktickytestoop
{


    class herni_postava
    {
        private string jmeno;
        private int lvl;
        private int x;
        private int y;

        public herni_postava(string jmeno)
        {
            jmeno = jmeno;
            lvl = 1;
            x = 0;
            y = 0;
        }
        public string Name
        {
            get => jmeno;
           
        }
    }
}

