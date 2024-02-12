using System;

namespace FinalCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MJE_INGRESO_COMPETIDOR = "Ingrese el nombre de un competidor para consultar el tiempo total de sus carreras: ";
            const string MJE_ERROR_COMPETIDOR = "El competidor ingresado no existe en cars.";
            const string MJE_ERROR_TIEMPO = "El tiempo de la carrera debe ser >=0. Vuelva a ingresar: ";
            const string MJE_INGRESO_CARRERA = "Ingrese el numero de carrera a consultar su duracion: ";
            const string MJE_ERROR_CARRERA = "La carrera ingresada es invalida.";
            const string MJE_FINAL_1 = "\nEl tiempo total del competidor elegido fue de {0} segundos.";
            const string MJE_FINAL_2 = "La carrera #{0} duro {1} segundos.";
            const int CANT_CARRERAS = 5;
            const int CANT_COMPETIDORES = 4;

            int posiCompetidor, totalTiemposCompetidor, posiCarrera, duracionCarreraX;
            string[] competidores = { "RAYO MCQUEEN", "MATE", "CHICK HICKS", "SALLY" };
            int[,] tiemposCarreras = new int[CANT_COMPETIDORES, CANT_CARRERAS];
            int[] carrerasGanadasXCompetidor = new int[CANT_COMPETIDORES];

            CargarTiemposCarreras(tiemposCarreras, competidores, MJE_ERROR_TIEMPO);
            posiCompetidor = IngresarCompetidor(MJE_INGRESO_COMPETIDOR, MJE_ERROR_COMPETIDOR, competidores);
            totalTiemposCompetidor = ObtenerTiemposCompetidor(tiemposCarreras, posiCompetidor);
            posiCarrera = IngresarEntero(MJE_INGRESO_CARRERA, MJE_ERROR_CARRERA, 1, CANT_CARRERAS - 1) - 1;
            duracionCarreraX = ObtenerDuracionCarrera(tiemposCarreras, posiCarrera);
            CalcularCarrerasGanadas(tiemposCarreras, carrerasGanadasXCompetidor);

            Console.WriteLine(MJE_FINAL_1, totalTiemposCompetidor);
            Console.WriteLine(MJE_FINAL_2, posiCarrera + 1, duracionCarreraX);
            MostrarCarrerasGanadas(carrerasGanadasXCompetidor, competidores);
        }

        static void MostrarCarrerasGanadas(int[] carrerasGanadasXCompetidor, string[] competidores)
        {
            for (int i = 0; i < competidores.Length; i++)
            {
                Console.WriteLine($"{competidores[i]} ganó {carrerasGanadasXCompetidor[i]} carreras.");
            }
        }
        /// <summary>
        /// Actualiza en la estructura carrerasGanadasXCompetidor la cantidad de carreras ganadas.
        /// </summary>
        /// <param name="tiemposCarreras">Estructura donde se guardan los tiempos de todas las carreras por competidor</param>
        /// <param name="carrerasGanadasXCompetidor">Estructura que debe ser actualizada con la cant. de carreras ganadas. El vector es paralelo al de competidores.</param>
        static void CalcularCarrerasGanadas(int[,] tiemposCarreras, int[] carrerasGanadasXCompetidor)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Permite obtener la duración de una carrera en particular
        /// </summary>
        /// <param name="tiemposCarreras">Estructura donde se guardan los tiempos de todas las carreras por competidor</param>
        /// <param name="posiCarrera">Posición de la carrera a encontrar su duración</param>
        /// <returns>Duración de la carrera pasada por parámetro.</returns>
        static int ObtenerDuracionCarrera(int[,] tiemposCarreras, int posiCarrera)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Permite obtener la sumatoria de todos los tiempos de todas las carreras de un competidor en particular.
        /// </summary>
        /// <param name="tiemposCarreras">Estructura donde se guardan los tiempos de todas las carreras por competidor</param>
        /// <param name="posiCompetidor">Posición del competidor</param>
        /// <returns>Sumatoria de los tiempos de todas las carreras del competidor recibido por parámetro.</returns>
        static int ObtenerTiemposCompetidor(int[,] tiemposCarreras, int posiCompetidor)
        {
            throw new NotImplementedException();
        }

        static void CargarTiemposCarreras(int[,] tiempos, string[] competidores, string mjeError)
        {
            const int MIN_TIEMPO = 0;
            for (int i = 0; i < tiempos.GetLength(0); i++)
            {
                Console.WriteLine($"{competidores[i]}:");
                for (int j = 0; j < tiempos.GetLength(1); j++)
                {
                    tiempos[i, j] = IngresarEntero($"Ingrese el tiempo que tardo en la carrera #{j + 1}: ", mjeError, MIN_TIEMPO);
                }
                Console.WriteLine();
            }
        }
        static int IngresarEntero(string mensaje, string mjeError = "", int min = int.MinValue, int max = int.MaxValue)
        {
            Console.Write(mensaje);
            int ingreso = int.Parse(Console.ReadLine());
            while (ingreso < min || ingreso > max)
            {
                Console.Write(mjeError);
                ingreso = int.Parse(Console.ReadLine());
            }
            return ingreso;
        }
        static string IngresarString(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine();
        }
        /// <summary>
        /// Permite ingresar el nombre de un competidor validando que exista entre los competidores registrados. Si no existe, se le debe volver a pedir al usuario un nuevo competidor.
        /// </summary>
        /// <param name="mensaje">Mensaje a mostrar al usuario para solicitar el nombre del competidor.</param>
        /// <param name="mjeError">Mensaje de error a mostrar al usuario en caso de no existir el competidor ingresado.</param>
        /// <param name="competidores">Estructura donde se guardan los competidores existentes</param>
        /// <returns>Posición del competidor ingresado</returns>
        
        static int IngresarCompetidor(string mensaje, string mjeError, string[] competidores)
        {
            throw new NotImplementedException();
        }

    } 
}
