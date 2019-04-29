using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmonlandia
{
    class Simulacion
    {
        Zona zona;
        public Simulacion(Zona zona)
        {
            this.zona = zona;
        }
        public bool Reproducirse()
        {
            if (zona.GetBitmons().Count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Pelear()
        {
            zona.GetBitmons()[0].ReducirPuntosDeVida(zona.GetBitmons()[1].Daño(zona.GetBitmons()[0]));
            zona.GetBitmons()[1].ReducirPuntosDeVida(zona.GetBitmons()[0].Daño(zona.GetBitmons()[1]));
        }
        public Zona DevolverZona()
        {
            return zona;
        }
    }
}