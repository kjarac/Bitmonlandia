using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmonlandia
{
    class Dorvalo:Bitmon
    {
        public Dorvalo(int tiempoDeVida, int puntosDeVida, int puntosDeAtaque, int cantidadDeHijos, int posicionX, int posicionY)
        {
            this.tiempoDeVida = tiempoDeVida;
            this.puntosDeVida = puntosDeVida;
            this.puntosDeAtaque = puntosDeAtaque;
            this.especie = "Dorvalo";
            this.cantidadDeHijos = cantidadDeHijos;
            this.posicionX = posicionX;
            this.posicionY = posicionY;
        }
        public Dorvalo(Bitmon bitmon)
        {
            if (bitmon.Especie() == "Dorvalo")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
        }

        public override string CambioTerreno()
        {
            return "";
        }
        public override int Daño(Bitmon bitmon)
        {
            if (bitmon.Especie() == "Ent" || bitmon.Especie() == "Wetar")
            {
                return puntosDeAtaque * 2;
            }
            else
            {
                return Convert.ToInt32(puntosDeAtaque * 0.5);
            }
        }
        public override void Desplazamiento(Mapa mapa)
        {
            Random random = new Random();
            while (true)
            {
                int rnd = random.Next(3);
                if (rnd == 0 && posicionX != mapa.Ancho()) // con 0 se mueve hacia la derecha
                {
                    posicionX += 2;
                    break;
                }
                else if (rnd == 1 && posicionX != 0) // con 1 se mueve hacia la izquierda
                {
                    posicionX -= 2;
                    break;
                }
                else if (rnd == 2 && posicionY != 0) //con 2 se mueve hacia arriba
                {
                    posicionY -= 2;
                    break;
                }
                else if (rnd == 3 && posicionY != mapa.Largo())// con 3 se mueve hacia abajo            
                {
                    posicionY += 2;
                    break;
                }
                else
                {
                    continue;
                }

            }
        }
        public override int AfinidadTerreno(string terreno)
        {
            if (terreno == "V")
            {
                return 0; // con 0 cambia el terreno, con 1 si es afin y con 2 no
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
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}

