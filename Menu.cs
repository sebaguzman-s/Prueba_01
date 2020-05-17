using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Sistema_inventario
{
    class Menu
    {
        private int opcion;
        ArrayList listaAutos = new ArrayList();
        private int a;
        private int b;
        public void desplegar()
        {
            listaAutos = new ArrayList();
            
            do
            {
                do
                {
                    Console.WriteLine("------------------");
                    Console.WriteLine("Menú de automovil");
                    Console.WriteLine("------------------");
                    Console.WriteLine("1.- Registrar un automovil");
                    Console.WriteLine("2.- Listar automoviles");
                    Console.WriteLine("3.- Eliminar un auto");
                    Console.WriteLine("4.- Salir");
                    Console.WriteLine("------------------");
                    Console.WriteLine("Digite la opción: ");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    /*opción es inválida*/
                    if (opcion < 1 || opcion > 4)
                    {
                        Console.WriteLine("Ingrese una opción válida [1-4]");
                    }

                } while (opcion < 1 || opcion > 4);


                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();
                            /*Registrar Automovil*/

                            Automovil autoNuevo = new Automovil(0, null, null, 0, 0, 0, null, 0.0, 0, null, 0, 0, null, 0.0,true,true,true,0.0);
                            Console.Write("ingrese id del automovil: ");
                            autoNuevo.IdAutomovil = Convert.ToInt32(Console.ReadLine());
                            Console.Write("marca: ");
                            autoNuevo.Marca = Console.ReadLine();
                            Console.Write("modelo: ");
                            autoNuevo.Modelo = Console.ReadLine();
                            Console.Write("ingrese numero de año: ");
                            autoNuevo.Anho = Convert.ToInt32(Console.ReadLine());
                            Console.Write("kilometraje: ");
                            autoNuevo.Kilometraje = Convert.ToInt32(Console.ReadLine());
                            Console.Write("id de motor: ");
                            autoNuevo.Motor.Id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("su motor es de dos tiempos o de cuatro tiempos: ");
                            autoNuevo.Motor.Tipo = Console.ReadLine();
                            while ((autoNuevo.Motor.Tipo != "dos tiempos") && ( autoNuevo.Motor.Tipo != "cuatro tiempos"))
                            {
                                Console.WriteLine("inserte un tipo de motor valido");
                                autoNuevo.Motor.Tipo = Console.ReadLine();
                            }

                                        
                            Console.Write("cilindrada: ");    
                            autoNuevo.Motor.Cilindrada = Convert.ToDouble(Console.ReadLine());
                            Console.Write("numero de ruedas: ");
                            autoNuevo.Ruedas.NumRuedas = Convert.ToInt32(Console.ReadLine());
                            Console.Write("tipo de recubrimiento es fenol, hule o poliuterano?: ");
                            autoNuevo.Ruedas.Recubrimiento = Console.ReadLine(); 
                            while ((autoNuevo.Ruedas.Recubrimiento != "fenol") && (autoNuevo.Ruedas.Recubrimiento != "hule") && (autoNuevo.Ruedas.Recubrimiento != "poliuterano" ))
                            {
                                Console.WriteLine("inserte un tipo de recubrimiento valido");
                                autoNuevo.Ruedas.Recubrimiento = Console.ReadLine();
                            }
                            
                            Console.Write("Max Durometro: ");
                            autoNuevo.Ruedas.MaxDurometro = Convert.ToInt32(Console.ReadLine());
                            a = autoNuevo.Ruedas.MaxDurometro ;
                            Console.Write("Min Durometro: ");
                            autoNuevo.Ruedas.MinDurometro = Convert.ToInt32(Console.ReadLine());
                            b = autoNuevo.Ruedas.MinDurometro;
                            if (a > b)
                            {
                                autoNuevo.Ruedas.MaxDurometro = a; 
                                autoNuevo.Ruedas.MinDurometro = b;
                            }
                            else
                            {
                                autoNuevo.Ruedas.MinDurometro = a;
                                autoNuevo.Ruedas.MaxDurometro = b;


                            }
                            Console.Write("Tipo de Mezclador es carburador o inyector: ");
                            autoNuevo.Mezclador.Tipo = Console.ReadLine();
                            while ((autoNuevo.Mezclador.Tipo != "carburador") && (autoNuevo.Mezclador.Tipo != "inyector"))
                            {
                                Console.WriteLine("inserte un tipo de recubrimiento valido");
                                autoNuevo.Mezclador.Tipo = Console.ReadLine();
                            }
                            
                            Console.Write("ingrese capasidad de litros: ");
                            autoNuevo.Estanque.Capacidad = Convert.ToDouble(Console.ReadLine());
                            Console.Write("cuanto Litros de bencina hay: ");
                            autoNuevo.Estanque.Litros = Convert.ToDouble(Console.ReadLine());

                            if(autoNuevo.Estanque.Litros>50.0 && autoNuevo.Estanque.Litros<autoNuevo.Estanque.Capacidad)
                            {
                                autoNuevo.Estanque.medioLleno = true;
                            }
                            if (autoNuevo.Estanque.Litros > 10.5 && autoNuevo.Estanque.Litros <= 50.0)
                            {
                                autoNuevo.Estanque.mitadCombustible = true;
                            }
                            if(autoNuevo.Estanque.Litros <= 10.5)
                            {
                                autoNuevo.Estanque.bajoCombustible = true;
                            }
                            Console.Write("estado del motor del %1 - %100 : ");
                            autoNuevo.Motor.Estado = Convert.ToDouble(Console.ReadLine());
                            while (autoNuevo.Motor.Estado > 100.0)
                            {
                                Console.Write("por favor ingrese un numero valido: ");
                                autoNuevo.Motor.Estado = Convert.ToDouble(Console.ReadLine());
                            }

                            Console.Write("estado del estanque del %1 - %100 : ");
                            autoNuevo.Estanque.Estado = Convert.ToDouble(Console.ReadLine());
                            while (autoNuevo.Estanque.Estado > 100.0)
                            {
                                Console.Write("por favor ingrese un numero valido: ");
                                autoNuevo.Estanque.Estado = Convert.ToDouble(Console.ReadLine());
                            }
                            Console.Write("estado de las ruedas del %1 - %100 : ");
                            autoNuevo.Ruedas.Estado = Convert.ToDouble(Console.ReadLine());
                            while (autoNuevo.Ruedas.Estado > 100.0)
                            {
                                Console.Write("por favor ingrese un numero valido: ");
                                autoNuevo.Ruedas.Estado = Convert.ToDouble(Console.ReadLine());
                            }

                            Console.Write("estado del mezclador del %1 - %100 : ");
                            autoNuevo.Mezclador.Estado = Convert.ToDouble(Console.ReadLine());
                            while (autoNuevo.Mezclador.Estado > 100.0)
                            {
                                Console.Write("por favor ingrese un numero valido: ");
                                autoNuevo.Mezclador.Estado = Convert.ToDouble(Console.ReadLine());
                            }

                            listaAutos.Add(autoNuevo);
                            
                            Console.WriteLine("pulse una tecla para continuar");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                    case 2:
                        {
                            /*Listar todas los auto*/
                            Console.Clear();
                            
                            foreach (Automovil b in listaAutos)
                            {
                                
                                 Console.WriteLine("------------------------");
                                 Console.WriteLine("Id Automovil: " + b.IdAutomovil);
                                 Console.WriteLine("marca: " + b.Marca);
                                 Console.WriteLine("modelo: " + b.Modelo);
                                 Console.WriteLine("Año: " + b.Anho);
                                 Console.WriteLine("Kilometraje: " + b.Kilometraje + "km");
                                 Console.WriteLine("Id De Motor: " + b.Motor.Id);
                                 Console.WriteLine("Tipo Motor: " + b.Motor.Tipo);
                                 Console.WriteLine("Motor Cilindrada: " + b.Motor.Cilindrada + "cc");
                                 Console.WriteLine("Num Ruedas: " + b.Ruedas.NumRuedas);
                                 Console.WriteLine("Ruedas Recubrimiento: " + b.Ruedas.Recubrimiento);
                                 Console.WriteLine("Ruedas Max Recubrimiento: " + b.Ruedas.MaxDurometro);
                                 Console.WriteLine("Ruedas Min Recubrimiento: " + b.Ruedas.MinDurometro);
                                 Console.WriteLine("Mezclador Tipo: " + b.Mezclador.Tipo);
                                 Console.WriteLine("Litros capacidad: " + b.Estanque.Capacidad);
                                 Console.WriteLine("Litros Estanque: " + b.Estanque.Litros);
                                 Console.WriteLine("esta el estanque medio lleno: " + b.Estanque.medioLleno);
                                 Console.WriteLine("esta el estanque medio: " + b.Estanque.mitadCombustible);
                                 Console.WriteLine("esta el estanque bajo: " + b.Estanque.bajoCombustible);
                                 Console.WriteLine("estado del motor: %" + b.Motor.Estado);
                                 Console.WriteLine("estado del estanque: %" + b.Estanque.Estado);
                                 Console.WriteLine("estado de las ruedas: %" + b.Ruedas.Estado);
                                 Console.WriteLine("estado del mezclador: %" + b.Mezclador.Estado);


                                Console.WriteLine("------------------------"); 

                            }
                            Console.WriteLine("ingrese una tecla para continuar:");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                    case 3:
                        {
                            
                            Console.Clear();
                            Console.WriteLine("ingrese la posicion que desea eliminar");
                            listaAutos.RemoveAt(Convert.ToInt32(Console.ReadLine())-1);

                           
                            Console.WriteLine("ingrese una tecla para continuar:");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }

                    
                    case 4:
                        {
                            /*Salir*/
                                Console.WriteLine("Gracias por utilizar esta aplicación");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                }

            } while (opcion != 4);

        }
    }
}