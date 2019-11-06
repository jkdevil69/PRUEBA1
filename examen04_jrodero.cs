/* Javier Rodero Martínez
 
 27/11/2018 Examen de programacion tema 4*/
 using System;

public class Examen04_jrodero
{
    public struct Flota_Estelar
    {
        public string identificadorFlota;
        public string descripcionFlota;
        public string especificacionesFlota;
        public string destinoFlota;
        public int fechaSalidaFlota;
        public int fechaVueltaFlota;
        public int capacidadTripulantesFlota;
    }
	public static void Main()
	{
        const int MAXIMO = 10000;
        int cantidadNaves=0, posicionAModificar, posicionABorrar;
        Flota_Estelar[] naves = new Flota_Estelar[MAXIMO];
        string operacionARealizar, busquedaTexto;
        string identificadorTemporal, fechaTemporal;
        string[] fechasTemporales = new string[3];
        bool salir = false;

        do
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1.- Insertar una nave");
            Console.WriteLine("2.- Borrar una posicion en concreto");
            Console.WriteLine("3.- Modificar una ficha");
            Console.WriteLine("4.- Buscar las naves que salen hoy");
            Console.WriteLine("5.- Buscar por texto");
            Console.WriteLine("Ordenar por fecha de salida");
            Console.WriteLine();
            Console.WriteLine("T.- Salir del programa");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            operacionARealizar = Console.ReadLine();

            switch (operacionARealizar)
            {
                case "1":
                    do
                    {
                        Console.Write("Introduzca el identificador: ");
                        identificadorTemporal = Console.ReadLine();

                        if (identificadorTemporal.Substring(0,3) == "USS")
                        {
                            naves[cantidadNaves].identificadorFlota=identificadorTemporal;
                            salir = true;
                        }
                        else
                        {
                            Console.WriteLine("Error de formato: El identificador debe empezar por USS");
                            Console.WriteLine();
                        }
                    } while(!salir);
                    salir = false;

                    Console.Write("Introduzca descripcion: ");
                    naves[cantidadNaves].descripcionFlota = Console.ReadLine();

                    Console.Write("Introduzca las especificaciones tecnicas: ");
                    naves[cantidadNaves].especificacionesFlota = Console.ReadLine();

                    Console.Write("Introduzca el destino de la nave: ");
                    naves[cantidadNaves].destinoFlota = Console.ReadLine();

                    do
                    {
                        Console.Write("Introduzca la fecha de salida (DD/MM/AAAA): ");
                        fechaTemporal = Console.ReadLine();
                        if (fechaTemporal.Length == 10)
                        {
                            fechasTemporales = fechaTemporal.Split('/');
                            naves[cantidadNaves].fechaSalidaFlota = (Convert.ToInt32(fechasTemporales[2]) + Convert.ToInt32(fechasTemporales[1]) + Convert.ToInt32(fechasTemporales[0]));
                            salir = true;
                        }
                    } while (!salir);
                    salir = false;

                    do
                    {
                        Console.Write("Introduzca la fecha de vuenta (DD/MM/AAAA): ");
                        fechaTemporal = Console.ReadLine();
                        if (fechaTemporal.Length == 10)
                        {
                            fechasTemporales = fechaTemporal.Split('/');
                            naves[cantidadNaves].fechaVueltaFlota = (Convert.ToInt32(fechasTemporales[2]) + Convert.ToInt32(fechasTemporales[1]) + Convert.ToInt32(fechasTemporales[0]));
                            salir = true;
                        }
                    } while (!salir);
                    salir = false;

                    Console.Write("Introduzca la capacidad de tripulantes: ");
                    naves[cantidadNaves].capacidadTripulantesFlota = Convert.ToInt32(Console.ReadLine());

                    cantidadNaves++;

                    break;

                case "2":
                    Console.WriteLine("Posicion a borrar?");
                    posicionABorrar = Convert.ToInt32(Console.ReadLine);
                    posicionABorrar--;

                    for (int i = posicionABorrar; i < cantidadNaves; i++)
                    {
                        naves[i].identificadorFlota = naves[i + 1].identificadorFlota;
                        naves[i].descripcionFlota = naves[i + 1].descripcionFlota;
                        naves[i].especificacionesFlota = naves[i + 1].especificacionesFlota;
                        naves[i].fechaSalidaFlota = naves[i + 1].fechaSalidaFlota;
                        naves[i].fechaVueltaFlota = naves[i + 1].fechaVueltaFlota;
                        naves[i].capacidadTripulantesFlota = naves[i + 1].capacidadTripulantesFlota;
                    }

                case "3":
                    for (int i = 0; i < cantidadNaves; i++)
                    {
                        Console.WriteLine("{0}", i++);
                        Console.WriteLine(naves[i].identificadorFlota);
                        Console.WriteLine(naves[i].descripcionFlota);
                        Console.WriteLine(naves[i].especificacionesFlota);
                        Console.WriteLine(naves[i].fechaSalidaFlota);
                        Console.WriteLine(naves[i].fechaVueltaFlota);
                        Console.WriteLine(naves[i].capacidadTripulantesFlota);
                        Console.WriteLine();
                    }
                    
                    Console.Write("Que posicion desea modificar? ");
                    posicionAModificar = Convert.ToInt32(Console.ReadLine());
                    posicionAModificar--;

                    if (posicionAModificar < cantidadNaves)
                    {
                        do
                        {
                            Console.Write("Introduzca el identificador: ");
                            identificadorTemporal = Console.ReadLine();

                            if (identificadorTemporal.Substring(0, 3) == "USS")
                            {
                                naves[posicionAModificar].identificadorFlota = identificadorTemporal;
                                salir = true;
                            }
                            else
                            {
                                Console.WriteLine("Error de formato: El identificador debe empezar por USS");
                                Console.WriteLine();
                            }
                        } while (!salir);
                        salir = false;

                        Console.Write("Introduzca descripcion: ");
                        naves[posicionAModificar].descripcionFlota = Console.ReadLine();

                        Console.Write("Introduzca las especificaciones tecnicas: ");
                        naves[posicionAModificar].especificacionesFlota = Console.ReadLine();

                        Console.Write("Introduzca el destino de la nave: ");
                        naves[posicionAModificar].destinoFlota = Console.ReadLine();

                        do
                        {
                            Console.Write("Introduzca la fecha de salida (DD/MM/AAAA): ");
                            fechaTemporal = Console.ReadLine();
                            if (fechaTemporal.Length == 10)
                            {
                                fechasTemporales = fechaTemporal.Split('/');
                                naves[posicionAModificar].fechaSalidaFlota = (Convert.ToInt32(fechasTemporales[2]) + Convert.ToInt32(fechasTemporales[1]) + Convert.ToInt32(fechasTemporales[0]));
                                salir = true;
                            }
                        } while (!salir);
                        salir = false;

                        do
                        {
                            Console.Write("Introduzca la fecha de vuenta (DD/MM/AAAA): ");
                            fechaTemporal = Console.ReadLine();
                            if (fechaTemporal.Length == 10)
                            {
                                fechasTemporales = fechaTemporal.Split('/');
                                naves[posicionAModificar].fechaVueltaFlota = (Convert.ToInt32(fechasTemporales[2]) + Convert.ToInt32(fechasTemporales[1]) + Convert.ToInt32(fechasTemporales[0]));
                                salir = true;
                            }
                        } while (!salir);
                        salir = false;

                        Console.Write("Introduzca la capacidad de tripulantes: ");
                        naves[posicionAModificar].capacidadTripulantesFlota = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Posicion no valida");
                    }
                    break;

                case "4":
                    break;

                case "5":
                    Console.WriteLine("Busqueda?");
                    busquedaTexto = Console.ReadLine();

                    for (int i=0; i < cantidadNaves; i++)
                    {
                        if (naves[i].especificacionesFlota.Contains(busquedaTexto) || naves[i].destinoFlota.Contains(busquedaTexto))
                        {
                            Console.WriteLine(naves[i].identificadorFlota);
                            Console.WriteLine(naves[i].descripcionFlota);
                            Console.WriteLine(naves[i].especificacionesFlota);
                            Console.WriteLine(naves[i].fechaSalidaFlota);
                            Console.WriteLine(naves[i].fechaVueltaFlota);
                            Console.WriteLine(naves[i].capacidadTripulantesFlota);
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                    }
                    break;

                case "6":
                    break;

                case "T":
                case "t":
                    break;

                default:
                    Console.WriteLine("La opcion introducida no es valida...");
                    Console.ReadLine();
                    break;
            }

            Console.Clear();
        }while (operacionARealizar != "T" || operacionARealizar != "t");
    }
}
