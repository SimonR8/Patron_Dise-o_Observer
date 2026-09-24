using Patron_Diseño_Observer;
using System;

namespace Patron_Diseño_Observer
{
    public class NotificacionEstudiante : IObservador
    {
        public void Actualizar(string nombreEstudiante, double nuevaNota)
        {
            Console.WriteLine($"  -> [Notificación SMS/Correo]: Hola {nombreEstudiante}, tu nota fue actualizada a {nuevaNota:F1}.");
        }
    }
}