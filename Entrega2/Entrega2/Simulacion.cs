using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega2
{
    class Simulacion
    {
        Zona zona;
        public Simulacion(Zona zona)
        {
            this.zona = zona;
        }
        public bool Reproducirse(Zona zona)
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
        public void Pelear(Zona zona)
        {
            zona.GetBitmons()[0].ReducirPuntosDeVida(zona.GetBitmons()[1].Daño(zona.GetBitmons()[0]));
            zona.GetBitmons()[1].ReducirPuntosDeVida(zona.GetBitmons()[0].Daño(zona.GetBitmons()[1]));
        }
    }
}





