using System;

namespace CalculadoraMovimiento
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Bienvenido a la Calculadora de Movimiento");
                Console.WriteLine("Seleccione la opcion que desea:");
                Console.WriteLine("1. Movimiento Rectilineo Uniforme (MRU)");
                Console.WriteLine("2. Movimiento Rectilineo Uniformemente Acelerado (MRUA)");
                Console.WriteLine("3. Salir");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opcion no valida. Por favor, seleccione una opcion valida.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        CalcularMRU();
                        break;
                    case 2:
                        CalcularMRUA();
                        break;
                    case 3:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Por favor, seleccione una opcion valida.");
                        break;
                }
            }
        }
         static void CalcularMRU()
        {
            Console.WriteLine("Ha seleccionado Movimiento Rectilineo Uniforme (MRU).");
            Console.WriteLine("Que desea calcular?");
            Console.WriteLine("1. Distancia");
            Console.WriteLine("2. Tiempo");
            Console.WriteLine("3. Velocidad");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opcion no valida. Por favor, seleccione una opcion valida.");
                return;
            }

            switch (opcion)
            {
                case 1:
                    CalcularDistanciaMRU();
                    break;
                case 2:
                    CalcularTiempoMRU();
                    break;
                case 3:
                    CalcularVelocidadMRU();
                    break;
                default:
                    Console.WriteLine("Opcion no valida. Por favor, seleccione una opcion valida.");
                    break;
            }
        }

        static void CalcularDistanciaMRU()
        {
            Console.WriteLine("Ingrese la velocidad (m/s):");
            double velocidad;
            while (!double.TryParse(Console.ReadLine(), out velocidad))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            Console.WriteLine("Ingrese el tiempo (s):");
            double tiempo;
            while (!double.TryParse(Console.ReadLine(), out tiempo))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            double distancia = velocidad * tiempo;
            Console.WriteLine($"La distancia recorrida es: {distancia} metros.");
        }

        static void CalcularTiempoMRU()
        {
            Console.WriteLine("Ingrese la distancia (metros):");
            double distancia;
            while (!double.TryParse(Console.ReadLine(), out distancia))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            Console.WriteLine("Ingrese la velocidad (m/s):");
            double velocidad;
            while (!double.TryParse(Console.ReadLine(), out velocidad))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            double tiempo = distancia / velocidad;
            Console.WriteLine($"El tiempo transcurrido es: {tiempo} segundos.");
        }
        static void CalcularVelocidadMRU()
        {
            Console.WriteLine("Ingrese la distancia (metros):");
            double distancia;
            while (!double.TryParse(Console.ReadLine(), out distancia))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            Console.WriteLine("Ingrese el tiempo (s):");
            double tiempo;
            while (!double.TryParse(Console.ReadLine(), out tiempo))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            double velocidad = distancia / tiempo;
            Console.WriteLine($"La velocidad es: {velocidad} m/s.");
        }

        static void CalcularMRUA()
        {
            Console.WriteLine("Ha seleccionado Movimiento Rectilineo Uniformemente Acelerado (MRUA).");
            Console.WriteLine("Que desea calcular?");
            Console.WriteLine("1. Distancia");
            Console.WriteLine("2. Tiempo");
            Console.WriteLine("3. Velocidad inicial");
            Console.WriteLine("4. Velocidad final");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opcion no valida. Por favor, seleccione una opcion valida.");
                return;
            }

            switch (opcion)
            {
                case 1:
                    CalcularDistanciaMRUA();
                    break;
                case 2:
                    CalcularTiempoMRUA();
                    break;
                case 3:
                    CalcularVelocidadInicialMRUA();
                    break;
                case 4:
                    CalcularVelocidadFinalMRUA();
                    break;
                default:
                    Console.WriteLine("Opcion no valida. Por favor, seleccione una opcion valida.");
                    break;
            }
        }

        static void CalcularDistanciaMRUA()
        {
            Console.WriteLine("Ingrese la velocidad inicial (m/s):");
            double velocidadInicial;
            while (!double.TryParse(Console.ReadLine(), out velocidadInicial))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            Console.WriteLine("Ingrese la velocidad final (m/s):");
            double velocidadFinal;
            while (!double.TryParse(Console.ReadLine(), out velocidadFinal))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            Console.WriteLine("Ingrese la aceleracion (m/s^2):");
            double aceleracion;
            while (!double.TryParse(Console.ReadLine(), out aceleracion))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            double distancia = (Math.Pow(velocidadFinal, 2) - Math.Pow(velocidadInicial, 2)) / (2 * aceleracion);
            Console.WriteLine($"La distancia recorrida es: {distancia} metros.");
        }

        static void CalcularTiempoMRUA()
        {
            Console.WriteLine("Ingrese la velocidad inicial (m/s):");
            double velocidadInicial;
            while (!double.TryParse(Console.ReadLine(), out velocidadInicial))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            Console.WriteLine("Ingrese la velocidad final (m/s):");
            double velocidadFinal;
            while (!double.TryParse(Console.ReadLine(), out velocidadFinal))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            Console.WriteLine("Ingrese la aceleracion (m/s^2):");
            double aceleracion;
            while (!double.TryParse(Console.ReadLine(), out aceleracion))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            double tiempo = (velocidadFinal - velocidadInicial) / aceleracion;
            Console.WriteLine($"El tiempo transcurrido es: {tiempo} segundos.");
        }

        static void CalcularVelocidadInicialMRUA()
        {
            Console.WriteLine("Ingrese la velocidad final (m/s):");
            double velocidadFinal;
            while (!double.TryParse(Console.ReadLine(), out velocidadFinal))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            Console.WriteLine("Ingrese la aceleracion (m/s^2):");
            double aceleracion;
            while (!double.TryParse(Console.ReadLine(), out aceleracion))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            Console.WriteLine("Ingrese el tiempo (s):");
            double tiempo;
            while (!double.TryParse(Console.ReadLine(), out tiempo))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            double velocidadInicial = velocidadFinal - aceleracion * tiempo;
            Console.WriteLine($"La velocidad inicial es: {velocidadInicial} m/s.");
        }

        static void CalcularVelocidadFinalMRUA()
        {
            Console.WriteLine("Ingrese la velocidad inicial (m/s):");
            double velocidadInicial;
            while (!double.TryParse(Console.ReadLine(), out velocidadInicial))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            Console.WriteLine("Ingrese la aceleracion (m/s^2):");
            double aceleracion;
            while (!double.TryParse(Console.ReadLine(), out aceleracion))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            Console.WriteLine("Ingrese el tiempo (s):");
            double tiempo;
            while (!double.TryParse(Console.ReadLine(), out tiempo))
            {
                Console.WriteLine("Entrada invalida. Por favor, ingrese un numero valido.");
            }

            double velocidadFinal = velocidadInicial + aceleracion * tiempo;
            Console.WriteLine($"La velocidad final es: {velocidadFinal} m/s.");
        }
    }
}
