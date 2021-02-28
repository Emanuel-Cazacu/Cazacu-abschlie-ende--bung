using System;
using System.Collections.Generic;
using System.Text;

namespace Cazacu_abschließende_Übung
{
    public abstract class Gerät
    {
       
        public virtual int Akkustand { get; set; }

        public abstract bool Vollgeladen();
        

        
    }
}
