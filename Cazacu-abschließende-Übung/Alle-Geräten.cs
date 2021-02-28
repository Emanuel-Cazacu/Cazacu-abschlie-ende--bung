using System;
using System.Collections.Generic;
using System.Text;

namespace Cazacu_abschließende_Übung
{
    class Alle_Geräten
    {
        List<Gerät> geräte = new List<Gerät>();

        public void Hinzufügen(Gerät g)
        {
            geräte.Add(g);
        }

        public void Entfernen(Gerät g)
        {
            geräte.Remove(g);
        }
    }
}
