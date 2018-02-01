using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07teht3
{
    class joukkue
    {
        public string nimi;
        public string kaupun;
        
        
    }
    class pelaaja
    {
        public string enim;
        public string sunim;
        public string pelpaik;
        public bool katisyys;
    }
    class kokoonpano : public pelaaja, public joukkue
    {

    }
}
