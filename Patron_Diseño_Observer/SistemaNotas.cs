using Patron_Diseño_Observer;
using System;
using System.Collections.Generic;

namespace Patron_Diseño_Observer
{
    public class SistemaNotas : ISujeto
    {
        private readonly List<IObservador> _observadores = new List<IObservador>();

        public string NombreEstudiante { get; private set; }
        private double _notaFinal;

        public double NotaFinal
        {
            get => _notaFinal;
            set
            {
                if (_notaFinal != value)
                {
                    _notaFinal = value;
                    Console.WriteLine($"\n[SistemaNotas] La nota de {NombreEstudiante} ha cambiado a: {_notaFinal:F1}");
                    Notificar();
                }
            }
        }

        public SistemaNotas(string nombreEstudiante, double notaInicial)
        {
            NombreEstudiante = nombreEstudiante;
            _notaFinal = notaInicial;
        }

        public void Suscribir(IObservador observador)
        {
            _observadores.Add(observador);
        }

        public void Desuscribir(IObservador observador)
        {
            _observadores.Remove(observador);
        }

        public void Notificar()
        {
            foreach (var observador in _observadores)
            {
                observador.Actualizar(NombreEstudiante, _notaFinal);
            }
        }
    }
}
