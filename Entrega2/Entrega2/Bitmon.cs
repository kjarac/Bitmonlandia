using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega2
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
        public bool TieneTiempoDeVida()
        {
            if (tiempoDeVida == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Reproducirse()
        {
            cantidadDeHijos += 1;
        }
        public void ReducirTiempoDeVida(int a)
        {
            tiempoDeVida = tiempoDeVida - a;
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

