using System;
using System.Collections.Generic;
using System.Text;

namespace Cazacu_abschließende_Übung
{
    class Laptop : Gerät
    {
        public override int Akkustand { get { return 100; } }

        public override bool Vollgeladen()
        {
            if (Akkustand == 100)

                return true;
            else
            {
                throw new GerätException("Noch nicht Vollgeladen");
            }
            // else
            //{ return false; }
        }
    }
}
