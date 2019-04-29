using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bitmonlandia
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
            int tiempoTotal = 0;
            int cantidad1 = 0;
            int cantidad2 = 0;
            int cantidad3 = 0;
            int cantidad4 = 0;
            int cantidad5 = 0;
            int cantidad6 = 0;
            int tiempoTotal1 = 0;
            int tiempoTotal2 = 0;
            int tiempoTotal3 = 0;
            int tiempoTotal4 = 0;
            int tiempoTotal5 = 0;
            int tiempoTotal6 = 0;
            int cantidadDeHijos1 = 0;
            int cantidadDeHijos2 = 0;
            int cantidadDeHijos3 = 0;
            int cantidadDeHijos4 = 0;
            int cantidadDeHijos5 = 0;
            int cantidadDeHijos6 = 0;
            int muereBitmons = 0;
            int cantidadtotaldetiemposdevida = 0;
            int tiempoSimulacion = 0;
            int tasadenatalidad = 0;
            int muereBitmons1 = 0;
            int muereBitmons2 = 0;
            int muereBitmons3 = 0;
            int muereBitmons4 = 0;
            int muereBitmons5 = 0;
            int muereBitmons6 = 0;
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
                            tiempoTotal1 += tiempoDeVida;
                            puntosDeVida = random.Next(1, 15);
                            puntosDeAtaque = 0;
                            cantidadDeHijos = 0;
                            Console.WriteLine("Ingrese la posicion del bitmon entre un largo(X): " + x + " y un ancho(Y): " + y);
                            Console.WriteLine("Largo(X): ");
                            int xbitmon = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ancho(Y): ");
                            int ybitmon = int.Parse(Console.ReadLine());
                            Ent ent = new Ent(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                            cantidadDeHijos1 += cantidadDeHijos;
                            cantidad1 += nBitmons;
                            bitmons.Add(ent);


                        }
                        else if (especie == 2)
                        {
                            tiempoDeVida = random.Next(4, 15);
                            tiempoTotal2 += tiempoDeVida;
                            puntosDeVida = random.Next(3, 17);
                            puntosDeAtaque = 2;
                            cantidadDeHijos = 0;
                            Console.WriteLine("Ingrese la posicion del bitmon entre un largo(X): " + x + " y un ancho(Y): " + y);
                            Console.WriteLine("Largo(X): ");
                            int xbitmon = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ancho(Y): ");
                            int ybitmon = int.Parse(Console.ReadLine());
                            Taplan taplan = new Taplan(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                            cantidadDeHijos2 += cantidadDeHijos;
                            cantidad2 += nBitmons;
                            bitmons.Add(taplan);
                        }
                        else if (especie == 3)
                        {
                            tiempoDeVida = random.Next(3, 25);
                            tiempoTotal3 += tiempoDeVida;
                            puntosDeVida = random.Next(1, 10);
                            puntosDeAtaque = 3;
                            cantidadDeHijos = 0;
                            Console.WriteLine("Ingrese la posicion del bitmon entre un largo(X): " + x + " y un ancho(Y): " + y);
                            Console.WriteLine("Largo(X): ");
                            int xbitmon = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ancho(Y): ");
                            int ybitmon = int.Parse(Console.ReadLine());
                            Wetar wetar = new Wetar(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                            cantidadDeHijos3 += cantidadDeHijos;
                            cantidad3 += nBitmons;
                            bitmons.Add(wetar);
                        }
                        else if (especie == 4)
                        {
                            tiempoDeVida = random.Next(2, 18);
                            tiempoTotal4 += tiempoDeVida;
                            puntosDeVida = random.Next(5, 20);
                            puntosDeAtaque = 5;
                            cantidadDeHijos = 0;
                            Console.WriteLine("Ingrese la posicion del bitmon entre un largo(X): " + x + " y un ancho(Y): " + y);
                            Console.WriteLine("Largo(X): ");
                            int xbitmon = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ancho(Y): ");
                            int ybitmon = int.Parse(Console.ReadLine());
                            Dorvalo dorvalo = new Dorvalo(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                            cantidadDeHijos4 += cantidadDeHijos;
                            cantidad4 += nBitmons;
                            bitmons.Add(dorvalo);
                        }
                        else if (especie == 5)
                        {
                            tiempoDeVida = random.Next(10, 20);
                            tiempoTotal5 += tiempoDeVida;
                            puntosDeVida = random.Next(10, 18);
                            puntosDeAtaque = 5;
                            cantidadDeHijos = 0;
                            Console.WriteLine("Ingrese la posicion del bitmon entre un largo(X): " + x + " y un ancho(Y): " + y);
                            Console.WriteLine("Largo(X): ");
                            int xbitmon = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ancho(Y): ");
                            int ybitmon = int.Parse(Console.ReadLine());
                            Gofue gofue = new Gofue(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                            cantidadDeHijos5 += cantidadDeHijos;
                            cantidad5 += nBitmons;
                            bitmons.Add(gofue);
                        }
                        else
                        {
                            tiempoDeVida = random.Next(10, 20);
                            tiempoTotal6 += tiempoDeVida;
                            puntosDeVida = random.Next(1, 8);
                            puntosDeAtaque = 2;
                            cantidadDeHijos = 0;
                            Console.WriteLine("Ingrese la posicion del bitmon entre un largo(X): " + x + " y un ancho(Y): " + y);
                            Console.WriteLine("Largo(X): ");
                            int xbitmon = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ancho(Y): ");
                            int ybitmon = int.Parse(Console.ReadLine());
                            Doti doti = new Doti(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                            cantidadDeHijos6 += cantidadDeHijos;
                            cantidad6 += nBitmons;
                            bitmons.Add(doti);
                        }
                        tiempoTotal = tiempoDeVida;


                    }
                    Mapa mapa1 = new Mapa(x, y);//duplicar
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
                    cantidadtotaldetiemposdevida += 1;
                    mapa = mapa1;
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Ingrese tiempo de simulacion [Meses]: ");
                    tiempoSimulacion = int.Parse(Console.ReadLine());
                    if (tiempoSimulacion == 12)
                    {
                        tasadenatalidad = (cantidadDeHijos / bitmons.Count) * 100;
                    }

                }
                else
                {
                    for (int t = 0; t < tiempoSimulacion; t++)// inicio de la simulacion
                    {

                        if (t == 0)
                        {
                            mapa.MostrarMapa();
                            Console.ReadLine();
                        }
                        else
                        {
                            int cantidadAtaques = 0;
                            foreach (Bitmon bit in bitmons) //aqui recorre todos los bitmons existentes
                            {

                                bit.ReducirTiempoDeVida(bit.AfinidadTerreno(mapa.EntregarZona(bit.PosicionX(), bit.PosicionY()).TipoDeTerreno()));
                                bit.Desplazamiento(mapa);
                                Zona zonaL = mapa.EntregarZona(bit.PosicionX(), bit.PosicionY());
                                Console.WriteLine("zonaL: " + zonaL.GetBitmons().Count);
                                Simulacion simulacion = new Simulacion(zonaL);

                                if (bit.AfinidadTerreno(mapa.EntregarZona(bit.PosicionX(), bit.PosicionY()).TipoDeTerreno()) == 0)//aqui el bitmon cambia el terreno
                                {
                                    bit.CambioTerreno();
                                }
                                else// aqui se le reduce el tiempo de vida
                                {
                                    bit.ReducirTiempoDeVida(bit.AfinidadTerreno(mapa.EntregarZona(bit.PosicionX(), bit.PosicionY()).TipoDeTerreno()));
                                }
                                if (simulacion.Reproducirse())// aqui se reproducen
                                {
                                    Random random = new Random();
                                    int especie = random.Next(6);
                                    if (especie == 0)
                                    {
                                        tiempoDeVida = random.Next(2, 10);
                                        tiempoTotal1 += tiempoDeVida;
                                        puntosDeVida = random.Next(1, 15);
                                        puntosDeAtaque = 0;
                                        cantidadDeHijos = 0;
                                        int xbitmon = random.Next(0, mapa.Ancho());
                                        int ybitmon = random.Next(0, mapa.Largo());
                                        Console.Write("Bitmonnnn! : " + xbitmon + "  " + ybitmon);
                                        Ent ent = new Ent(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                                        bitmons.Add(ent);
                                    }
                                    else if (especie == 1)
                                    {
                                        tiempoDeVida = random.Next(4, 15);
                                        tiempoTotal2 += tiempoDeVida;
                                        puntosDeVida = random.Next(3, 17);
                                        puntosDeAtaque = 2;
                                        cantidadDeHijos = 0;
                                        int xbitmon = random.Next(0, mapa.Ancho());
                                        int ybitmon = random.Next(0, mapa.Largo());
                                        Console.Write("Bitmonnnn! : " + xbitmon + "  " + ybitmon);
                                        Taplan taplan = new Taplan(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                                        bitmons.Add(taplan);

                                    }
                                    else if (especie == 2)
                                    {
                                        tiempoDeVida = random.Next(3, 25);
                                        tiempoTotal3 += tiempoDeVida;
                                        puntosDeVida = random.Next(1, 10);
                                        puntosDeAtaque = 3;
                                        cantidadDeHijos = 0;
                                        int xbitmon = random.Next(0, mapa.Ancho());
                                        int ybitmon = random.Next(0, mapa.Largo());
                                        Console.Write("Bitmonnnn! : " + xbitmon + "  " + ybitmon);
                                        Wetar wetar = new Wetar(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                                        bitmons.Add(wetar);
                                    }
                                    else if (especie == 3)
                                    {
                                        tiempoDeVida = random.Next(2, 18);
                                        tiempoTotal4 += tiempoDeVida;
                                        puntosDeVida = random.Next(5, 20);
                                        puntosDeAtaque = 5;
                                        cantidadDeHijos = 0;
                                        int xbitmon = random.Next(0, mapa.Ancho());
                                        int ybitmon = random.Next(0, mapa.Largo());
                                        Console.Write("Bitmonnnn! : " + xbitmon + "  " + ybitmon);
                                        Dorvalo dorvalo = new Dorvalo(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                                        bitmons.Add(dorvalo);
                                    }
                                    else if (especie == 4)
                                    {
                                        tiempoDeVida = random.Next(10, 20);
                                        tiempoTotal5 += tiempoDeVida;
                                        puntosDeVida = random.Next(10, 18);
                                        puntosDeAtaque = 5;
                                        int xbitmon = random.Next(0, mapa.Ancho());
                                        int ybitmon = random.Next(0, mapa.Largo());
                                        Console.Write("Bitmonnnn! : " + xbitmon + "  " + ybitmon);
                                        Gofue gofue = new Gofue(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                                        bitmons.Add(gofue);
                                    }
                                    else
                                    {
                                        tiempoDeVida = random.Next(10, 20);
                                        tiempoTotal6 += tiempoDeVida;
                                        puntosDeVida = random.Next(1, 8);
                                        puntosDeAtaque = 2;
                                        cantidadDeHijos = 0;
                                        int xbitmon = random.Next(0, mapa.Ancho());
                                        int ybitmon = random.Next(0, mapa.Largo());
                                        Console.Write("Bitmonnnn! : " + xbitmon + "  " + ybitmon);
                                        Doti doti = new Doti(tiempoDeVida, puntosDeVida, puntosDeAtaque, cantidadDeHijos, xbitmon, ybitmon);
                                        bitmons.Add(doti);
                                    }
                                    Console.WriteLine("EAKSDJHKAJDHKASJD");
                                    Console.WriteLine(zonaL.GetBitmons().Count);
                                    Console.ReadLine();
                                    foreach (Bitmon bitm in zonaL.GetBitmons())
                                    {
                                        bitm.Reproducirse();
                                    }
                                }
                                if (zonaL.GetBitmons().Count == 2)
                                {
                                    if (zonaL.GetBitmons()[0].Especie() != zonaL.GetBitmons()[1].Especie() && cantidadAtaques == 0)// aqui ocurre la pelea
                                    {
                                        simulacion.Pelear();
                                        zonaL = simulacion.DevolverZona();
                                        cantidadAtaques += 1;
                                    }
                                }

                                if (bit.Muere()) // agregar registro al bithalla(cementerio de bitmons)
                                {

                                    bitmons.Remove(bit);
                                    muereBitmons += 1;
                                    if (bit.Especie() == "1")
                                    {
                                        muereBitmons1 += 1;
                                    }
                                    else if (bit.Especie() == "2")
                                    {
                                        muereBitmons2 += 1;
                                    }
                                    else if (bit.Especie() == "3")
                                    {
                                        muereBitmons3 += 1;
                                    }
                                    else if (bit.Especie() == "4")
                                    {
                                        muereBitmons4 += 1;
                                    }
                                    else if (bit.Especie() == "5")
                                    {
                                        muereBitmons5 += 1;
                                    }
                                    else if (bit.Especie() == "6")
                                    {
                                        muereBitmons6 += 1;
                                    }


                                }


                                cantidadtotaldetiemposdevida += 1;
                                Mapa ma = new Mapa();
                                Zona zona = new Zona();
                                mapa.MostrarMapa();// aqui termina elciclo,falta agregar lo que muestra la consola, y ojo que agregué nuevos metodos en varias clases, para que las agreguen al informe <3
                                int promediodevidas = tiempoDeVida / bitmons.Count;// indicara el promedio de vida de todas las especies
                                int promediodevida1 = tiempoTotal1 / cantidad1;
                                int promediodevida2 = tiempoTotal2 / cantidad2;
                                int promediodevida3 = tiempoTotal3 / cantidad3;
                                int promediodevida4 = tiempoTotal4 / cantidad4;
                                int promediodevida5 = tiempoTotal5 / cantidad5;
                                int promediodevida6 = tiempoTotal6 / cantidad6;
                                int tasademortalidad = (muereBitmons / bitmons.Count) * 100;

                                int promediodcantidadDeHijos1 = cantidadDeHijos1 / cantidad1;
                                int promediodcantidadDeHijos2 = cantidadDeHijos1 / cantidad2;
                                int promediodcantidadDeHijos3 = cantidadDeHijos1 / cantidad3;
                                int promediodcantidadDeHijos4 = cantidadDeHijos1 / cantidad4;
                                int promediodcantidadDeHijos5 = cantidadDeHijos1 / cantidad5;
                                int promediodcantidadDeHijos6 = cantidadDeHijos1 / cantidad6;

                                int promediomuereBitmons1 = (muereBitmons1 / bitmons.Count) * 100;
                                int promediomuereBitmons2 = (muereBitmons2 / bitmons.Count) * 100;
                                int promediomuereBitmons3 = (muereBitmons3 / bitmons.Count) * 100;
                                int promediomuereBitmons4 = (muereBitmons4 / bitmons.Count) * 100;
                                int promediomuereBitmons5 = (muereBitmons5 / bitmons.Count) * 100;
                                int promediomuereBitmons6 = (muereBitmons6 / bitmons.Count) * 100;

                                using (StreamWriter escribir1 = new StreamWriter(@"C:\texto\mitexto"))
                                {

                                    List<string> especiedeextincion = new List<string>();

                                    if (cantidad1 < cantidad2 && cantidad1 < cantidad3 && cantidad1 < cantidad4 && cantidad1 < cantidad5 && cantidad1 < cantidad6)
                                    {
                                        especiedeextincion.Add("Ent");
                                        escribir1.WriteLine(especiedeextincion);
                                    }
                                    else if (cantidad2 < cantidad1 && cantidad2 < cantidad3 && cantidad2 < cantidad4 && cantidad2 < cantidad5 && cantidad2 < cantidad6)
                                    {
                                        especiedeextincion.Add("Taplan");
                                        escribir1.WriteLine(especiedeextincion);
                                    }
                                    else if (cantidad3 < cantidad2 && cantidad3 < cantidad1 && cantidad3 < cantidad4 && cantidad3 < cantidad5 && cantidad3 < cantidad6)
                                    {
                                        especiedeextincion.Add("Wetar");
                                        escribir1.WriteLine(especiedeextincion);
                                    }
                                    else if (cantidad4 < cantidad2 && cantidad4 < cantidad3 && cantidad4 < cantidad1 && cantidad4 < cantidad5 && cantidad4 < cantidad6)
                                    {
                                        especiedeextincion.Add("Dorvalo");
                                        escribir1.WriteLine(especiedeextincion);
                                    }
                                    else if (cantidad5 < cantidad2 && cantidad5 < cantidad3 && cantidad5 < cantidad4 && cantidad5 < cantidad1 && cantidad5 < cantidad6)
                                    {
                                        especiedeextincion.Add("Wofue");
                                        escribir1.WriteLine(especiedeextincion);
                                    }
                                    else
                                    {
                                        especiedeextincion.Add("Doti");
                                        escribir1.WriteLine(especiedeextincion);
                                    }
                                    using (StreamWriter escribir = new StreamWriter(@"C:\texto\mitexto"))
                                    {
                                        escribir.WriteLine(promediodevidas);
                                        escribir.WriteLine(promediodevida1);
                                        escribir.WriteLine(promediodevida2);
                                        escribir.WriteLine(promediodevida3);
                                        escribir.WriteLine(promediodevida4);
                                        escribir.WriteLine(promediodevida5);
                                        escribir.WriteLine(promediodevida6);
                                        escribir.WriteLine(tasadenatalidad);
                                        escribir.WriteLine(tasademortalidad);
                                        escribir.WriteLine(promediodcantidadDeHijos1);
                                        escribir.WriteLine(promediodcantidadDeHijos2);
                                        escribir.WriteLine(promediodcantidadDeHijos3);
                                        escribir.WriteLine(promediodcantidadDeHijos4);
                                        escribir.WriteLine(promediodcantidadDeHijos5);
                                        escribir.WriteLine(promediodcantidadDeHijos6);
                                        escribir.WriteLine(promediomuereBitmons1);
                                        escribir.WriteLine(promediomuereBitmons2);
                                        escribir.WriteLine(promediomuereBitmons3);
                                        escribir.WriteLine(promediomuereBitmons4);
                                        escribir.WriteLine(promediomuereBitmons5);
                                        escribir.WriteLine(promediomuereBitmons6);


                                    }

                                }

                            }

                        }


                    }
                }


            }


        }

        internal class MuerteBitmon
        {
        }

    }
}

