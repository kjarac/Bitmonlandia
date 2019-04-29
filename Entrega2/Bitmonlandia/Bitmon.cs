using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmonlandia
{
    abstract class Bitmon
    {
        protected int tiempoDeVida;
        protected int puntosDeVida;
        protected int puntosDeAtaque;
        protected string especie;
        protected int cantidadDeHijos;
        protected int posicionX;
        protected int posicionY;


        public abstract string CambioTerreno();

        public abstract int Daño(Bitmon bitmon);

        public abstract void Desplazamiento(Mapa mapa);

        public int PosicionX()
        {
            return posicionX;
        }
        public int PosicionY()
        {
            return posicionY;
        }
        public string Especie()
        {
            return especie;
        }
        public bool Muere() { 
            if (tiempoDeVida == 0|| puntosDeVida==0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

  
        public void Reproducirse()
        {
            cantidadDeHijos += 1;
        }
        public void ReducirTiempoDeVida(int a)
        {
            tiempoDeVida = tiempoDeVida-a;
        }
        public void ReducirPuntosDeVida(int ataque)
        {
            puntosDeVida -= ataque;
        }

        public int ObtenerAtaque()
        {
            return puntosDeAtaque;
        }
        public abstract int AfinidadTerreno(string terreno);

    }

}
