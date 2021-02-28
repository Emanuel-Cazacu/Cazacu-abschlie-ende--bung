using System;
using System.Collections.Generic;
using System.Text;

namespace Cazacu_abschließende_Übung
{
    public class GerätException : Exception
    {
        public GerätException(string Ausgabe) : base(Ausgabe)
        {


        }
    }
}
