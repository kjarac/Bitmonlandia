using System;

namespace Entrega2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~BITMONLANDIA~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("PRESIONE ENTER");
            Console.ReadLine();
            int x = 0;
            int y = 0;
            int tiempoDeVida = 0;
            int puntosDeVida = 0;
            int puntosDeAtaque = 0;
            int cantidadDeHijos = 0;
            int posicionX = 0;
            int posicionY = 0;
            int tiempoSimulacion = 0;
            string[,] terrenos = new string[posicionX, posicionY];
            Mapa mapa = new Mapa(0, 0);
            List<Bitmon> bitmons = new List<Bitmon>();
            while (true)
            {

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("SELECCIONE UNA OPCION");
                Console.WriteLine("[1] TAMAÑO DEL MAPA");
                Console.WriteLine("[2] TIPO DE TERRENO ");
                Console.WriteLine("[3] BITMONS INICIALES ");
                Console.WriteLine("[4] TIEMPO DE SIMULACION");
                Console.WriteLine("[5] INICIAR SIMULACION ");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("INGRESE EL LARGO DEL MAPA");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESE EL ANCHO DEL MAPA");
                    y = int.Parse(Console.ReadLine());
                }

                else if (opcion == 2)
                {
                    string[,] terreno = new string[x, y];
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("INGRESE EL TIPO DE TERRENO PARA CADA CELDA");

                    Console.WriteLine("V: Vegetacion");
                    Console.WriteLine("A: Acuatico");
                    Console.WriteLine("D: Desierto");
                    Console.WriteLine("N: Nieve");
                    Console.WriteLine("Vn: Volcan");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                    for (int i = 0; i < y; i++)
                    {
                        for (int k = 0; k < x; k++)
                        {
                            Console.WriteLine("CELDA (" + k + "," + y + "):");
                            terreno[k, i] = Console.ReadLine();
                        }
                    }
                    terrenos = terreno;

                }

                else if (opcion == 3)
                {
                    Random random = new Random();

                    Console.WriteLine("Ingrese la cantidad de bitmons iniciales: ");
                    int nBitmons = int.Parse(Console.ReadLine());

                    for (int k = 0; k < nBitmons; k++)
                    {
                        Console.WriteLine("Ingrese la especie del Bitmon: ");
                        Console.WriteLine("1-Ent");
                        Console.WriteLine("2-Taplan");
                        Console.WriteLine("3-Wetar");
                        Console.WriteLine("4-Dorvalo");
                        Console.WriteLine("5-Gofue");
                        Console.WriteLine("6-Doti");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                        int especie = int.Parse(Console.ReadLine());
                        if (especie == 1)
                        {
                            tiempoDeVida = random.Next(2, 10);
                            puntosDeVida = random.Next(1, 15);
                            puntosDeAtaque = 0;
                            cantidadDeHijos = 0;
                            Console.WriteLine("Ingrese la posicion del bitmon entre un largo(X): " + x + " y un ancho(Y): " + y);
                            Console.WriteLine("Largo(X): ");
                            int xbitmon = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ancho(Y): ");
                            int ybitmon = int.Parse(Console.ReadLine());
                            Ent ent = new Ent(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                            bitmons.Add(ent);
                        }
                        else if (especie == 2)
                        {
                            tiempoDeVida = random.Next(4, 15);
                            puntosDeVida = random.Next(3, 17);
                            puntosDeAtaque = 2;
                            cantidadDeHijos = 0;
                            Console.WriteLine("Ingrese la posicion del bitmon entre un largo(X): " + x + " y un ancho(Y): " + y);
                            Console.WriteLine("Largo(X): ");
                            int xbitmon = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ancho(Y): ");
                            int ybitmon = int.Parse(Console.ReadLine());
                            Taplan taplan = new Taplan(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                            bitmons.Add(taplan);
                        }
                        else if (especie == 3)
                        {
                            tiempoDeVida = random.Next(3, 25);
                            puntosDeVida = random.Next(1, 10);
                            puntosDeAtaque = 3;
                            cantidadDeHijos = 0;
                            Console.WriteLine("Ingrese la posicion del bitmon entre un largo(X): " + x + " y un ancho(Y): " + y);
                            Console.WriteLine("Largo(X): ");
                            int xbitmon = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ancho(Y): ");
                            int ybitmon = int.Parse(Console.ReadLine());
                            Wetar wetar = new Wetar(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                            bitmons.Add(wetar);
                        }
                        else if (especie == 4)
                        {
                            tiempoDeVida = random.Next(2, 18);
                            puntosDeVida = random.Next(5, 20);
                            puntosDeAtaque = 5;
                            cantidadDeHijos = 0;
                            Console.WriteLine("Ingrese la posicion del bitmon entre un largo(X): " + x + " y un ancho(Y): " + y);
                            Console.WriteLine("Largo(X): ");
                            int xbitmon = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ancho(Y): ");
                            int ybitmon = int.Parse(Console.ReadLine());
                            Dorvalo dorvalo = new Dorvalo(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                            bitmons.Add(dorvalo);
                        }
                        else if (especie == 5)
                        {
                            tiempoDeVida = random.Next(10, 20);
                            puntosDeVida = random.Next(10, 18);
                            puntosDeAtaque = 5;
                            cantidadDeHijos = 0;
                            Console.WriteLine("Ingrese la posicion del bitmon entre un largo(X): " + x + " y un ancho(Y): " + y);
                            Console.WriteLine("Largo(X): ");
                            int xbitmon = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ancho(Y): ");
                            int ybitmon = int.Parse(Console.ReadLine());
                            Gofue gofue = new Gofue(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                            bitmons.Add(gofue);
                        }
                        else
                        {
                            tiempoDeVida = random.Next(10, 20);
                            puntosDeVida = random.Next(1, 8);
                            puntosDeAtaque = 2;
                            cantidadDeHijos = 0;
                            Console.WriteLine("Ingrese la posicion del bitmon entre un largo(X): " + x + " y un ancho(Y): " + y);
                            Console.WriteLine("Largo(X): ");
                            int xbitmon = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ancho(Y): ");
                            int ybitmon = int.Parse(Console.ReadLine());
                            Doti doti = new Doti(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                            bitmons.Add(doti);
                        }

                    }
                    Mapa mapa1 = new Mapa(x, y);
                    for (int k = 0; k < y; k++)
                    {
                        for (int i = 0; i < x; i++)
                        {
                            List<Bitmon> bitmons1 = new List<Bitmon>();
                            foreach (Bitmon bit in bitmons)
                            {
                                if (bit.PosicionX() == i && bit.PosicionY() == k)
                                {
                                    bitmons1.Add(bit);
                                    Zona zona = new Zona(terrenos[i, k], bitmons1);
                                    mapa1.AgregarZona(i, k, zona);
                                }
                                else
                                {
                                    Zona zona = new Zona(terrenos[i, k], bitmons1);
                                    mapa1.AgregarZona(i, k, zona);
                                }
                            }
                        }
                    }
                    mapa = mapa1;
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Ingrese tiempo de simulacion [Meses]: ");
                    tiempoSimulacion = int.Parse(Console.ReadLine());
                }
                else
                {
                    for (int t = 0; t < tiempoSimulacion; t++)
                    {
                        if (t == 0)
                        {
                            mapa.MostrarMapa();
                            Console.ReadLine();
                        }
                        else { }
                    }
                }





            }
        }


    }

}


}
}
