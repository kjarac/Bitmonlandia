using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega2

{
    class Mapa
    {   // volver a tener la clase zona agragar bitmons a zona ( por referencia o por valor)
        // interaccion con consola- clases individuales.
        //lista de bitmon en zona
        // zona: representa a cada cuadrante del mapa, dene tener atributo de lista de bitmons, terreno
        // enum* buscar
        // editar reproduccion
        // interfaces son solamente metodos, clase abstracta solo hereda una clase (la hija)
        //

        public Zona[,] mapa;
        int x;
        int y;
        public Mapa(int x, int y) //genera el mapa
        {
            this.x = x;
            this.y = y;
            this.mapa = new Zona[x, y];
        }
        public void AgregarZona(int posX, int posY, Zona zona)
        {
            mapa[posX, posY] = zona;
        }
        public int Largo() // entrega el largo
        {
            return x;
        }
        public int Ancho() // entrega el ancho
        {
            return y;
        }
        public void MostrarMapa()
        {
            for (int k = 0; k < y; k++)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine(mapa[x - 1, y - 1]);//TERMINAR ESTO
                }
            }
        }
    }
}

