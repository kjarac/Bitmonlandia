using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega2
{
    class Zona
    {
        public string terreno;
        //agregar atributos, lista bitmon
        //generar peleas. metodo en simulacion
        List<Bitmon> bitmons;
        public Zona(string terreno, List<Bitmon> bitmons)
        {
            this.terreno = terreno;
            this.bitmons = bitmons;
        }
        public string TipoDeTerreno()
        {
            return terreno;
        }
        public void CambiarTerreno(string terreno2)
        {
            terreno = terreno2;
        }
        public List<Bitmon> GetBitmons()
        {
            return bitmons;
        }
        public void AgregarBitmon(Bitmon bitmon)
        {
            bitmons.Add(bitmon);
        }

    }
}




