using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmonlandia
{
    class Ent:Bitmon
        //en en el caso de que terreno del ent sea volcanico o acuatico, verlo en el main
    {
        public Ent(int tiempoDeVida, int puntosDeVida, int puntosDeAtaque, int cantidadDeHijos, int posicionX, int posicionY)
        {
            this.tiempoDeVida = tiempoDeVida;
            this.puntosDeVida = puntosDeVida;
            this.puntosDeAtaque = puntosDeAtaque;
            this.especie = "Ent";
            this.cantidadDeHijos = cantidadDeHijos;
            this.posicionX = posicionX;
            this.posicionY = posicionY;
        }
        public Ent(Bitmon bitmon)
        {
            if (bitmon.Especie() == "Ent")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
        }

        public override void Desplazamiento(Mapa mapa)
        {
        }
        public override string CambioTerreno()
        {
            return "";
        }
        public override int Daño(Bitmon bitmon)
        {
            return 0;
        }
        public override int AfinidadTerreno(string terreno)
        {
            if (terreno == "V")
            {
                return 1;
            }
            else if (terreno == "A")
            {
                return 2;
            }
            else if (terreno == "D")
            {
                return 1;
            }
            else if (terreno == "N")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

       
    }
}
