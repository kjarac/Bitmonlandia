using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmonlandia
{
    class Doti:Bitmon
    {
        public Doti(int tiempoDeVida, int puntosDeVida, int puntosDeAtaque, int cantidadDeHijos, int posicionX, int posicionY)
        {
            this.tiempoDeVida = tiempoDeVida;
            this.puntosDeVida = puntosDeVida;
            this.puntosDeAtaque = puntosDeAtaque;
            this.especie = "Doti";
            this.cantidadDeHijos = cantidadDeHijos;
            this.posicionX = posicionX;
            this.posicionY = posicionY;
        }
        public Doti(Bitmon bitmon)
        {
            if (bitmon.Especie() == "Doti")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }

        public override string CambioTerreno()
        {
            return "";
        }
        public override int Daño(Bitmon bitmon)
        {
            return puntosDeAtaque;
        }
        public override void Desplazamiento(Mapa mapa)
        {
            Random random = new Random();
            while (true)
            {
                int rnd = random.Next(3);
                if (rnd == 0 && posicionX != mapa.Ancho()) // con 0 se mueve hacia la derecha
                {
                    posicionX += 1;
                    break;
                }
                else if (rnd == 1 && posicionX != 0) // con 1 se mueve hacia la izquierda
                {
                    posicionX -= 1;
                    break;
                }
                else if (rnd == 2 && posicionY != 0) //con 2 se mueve hacia arriba
                {
                    posicionY -= 1;
                    break;
                }
                else if (rnd == 3 && posicionY != mapa.Largo())// con 3 se mueve hacia abajo            
                {
                    posicionY += 1;
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
            {
                if (terreno == "V")
                {
                    return 1; // con 0 cambia el terreno, con 1 si es afin y con 2 no
                }
                else if (terreno == "A")
                {
                    return 1;
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
                    return 1;
                }
            }
        }
    }
}
