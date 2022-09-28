using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Console
{
    class Curators :CollectionBase
    {
        public void AddCurator(Curator cur)
        {
            List.Add(cur);
        }

        public Curator this[int index]
        {
            get => (Curator)List[index];
            set => List[index] = value; 
        }
    }
}
