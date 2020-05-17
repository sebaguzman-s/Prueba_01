using System;

namespace Sistema_inventario
{
    class Program
    {
        static void Main(string[] args)
        {
            int Intento_Usuario = 1;
            int Intento_Clave = 1;
            string UsuarioPredeterminado = "admin";
            string ClavePredeterminada = "abc123";
            string Usuario;
            string Clave;
            


            do
            {
                Console.WriteLine("ingrese el nombre de usuario (intento N°" + Intento_Usuario + "):");
                Usuario = Console.ReadLine();

                if (Usuario == UsuarioPredeterminado)
                {
                    Console.WriteLine("WELCOME SEÑOR ADMIN!!!!!!");
                    do
                    {

                        Console.WriteLine("insgrese la clave de admin(intento n°" + Intento_Clave + "):");
                        Clave = Console.ReadLine();
                        if (Clave == ClavePredeterminada)
                        {
                            
                            
                            Console.Clear();
                            Menu menu = new Menu();
                            menu.desplegar();
                            break;
                        }
                        else
                        {
                            Intento_Clave++;
                            Console.WriteLine("clave Erronea");
                        }
                    } while (Intento_Clave <= 3);

                    break;
                }
                else{
                    Intento_Usuario++;
                    Console.WriteLine("Usuario Equivocada");
                }
            } while (Intento_Usuario <= 3);

        }
    }
}
