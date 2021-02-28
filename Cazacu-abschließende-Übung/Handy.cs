using System;
using System.Collections.Generic;
using System.Text;

namespace Cazacu_abschließende_Übung
{
    public sealed class Handy : Gerät
    {
        public override int Akkustand { get { return 77; } }

        public override bool Vollgeladen()
        {
            if (Akkustand == 100)
                return true;
            else
            { return false; }
        }






    }
}
