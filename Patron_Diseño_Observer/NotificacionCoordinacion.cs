using Patron_Diseño_Observer;
using System;

namespace Patron_Diseño_Observer
{
    public class NotificacionCoordinacion : IObservador
    {
        public void Actualizar(string nombreEstudiante, double nuevaNota)
        {
            if (nuevaNota < 3.0)
            {
                Console.WriteLine($"  -> [Coordinación Académica]: ALERTA - El estudiante {nombreEstudiante} está perdiendo la materia con {nuevaNota:F1}. Se requiere seguimiento.");
            }
            else
            {
                Console.WriteLine($"  -> [Coordinación Académica]: Estado académico regular para {nombreEstudiante}.");
            }
        }
    }
}
