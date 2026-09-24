using Patron_Diseño_Observer;
using System;

namespace PatronObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMOSTRACIÓN PATRÓN OBSERVER ===");

            // Crear el sujeto
            SistemaNotas materiaPOO = new SistemaNotas("Simón", 4.5);

            // Crear los observadores
            IObservador canalEstudiante = new NotificacionEstudiante();
            IObservador canalCoordinacion = new NotificacionCoordinacion();

            // Suscribir los observadores
            materiaPOO.Suscribir(canalEstudiante);
            materiaPOO.Suscribir(canalCoordinacion);

            // Cambios de estado
            materiaPOO.NotaFinal = 2.5;
            materiaPOO.NotaFinal = 3.8;

            // Desuscripción
            Console.WriteLine("\n--> Desuscribiendo la notificación a Coordinación...");
            materiaPOO.Desuscribir(canalCoordinacion);

            materiaPOO.NotaFinal = 4.8;

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}   