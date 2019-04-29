using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmonlandia
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

        public Zona()
        {
        }

        public string TipoDeTerreno()
        {
            if (terreno == "V")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else if (terreno == "A")
            {
                Console.BackgroundColor = ConsoleColor.Blue;

            }
            else if (terreno == "D")
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;

            }

            else if (terreno == "N")
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            return terreno;
        }

        public void CambiarTerreno(string terreno2)
        {
            terreno = terreno2;
            if (terreno == "V")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else if (terreno == "A")
            {
                Console.BackgroundColor = ConsoleColor.Blue;

            }
            else if (terreno == "D")
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;

            }

            else if (terreno == "N")
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
        }

        public List<Bitmon> GetBitmons()
        {
            return bitmons;
        }
        public int CantidadBitmons()
        {
            return bitmons.Count;
        }
        public void AgregarBitmon(Bitmon bitmon)
        {
            bitmons.Add(bitmon);
        }

    }
}
