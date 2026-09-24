using Patron_Diseño_Observer;

namespace Patron_Diseño_Observer
{
    public interface ISujeto
    {
        void Suscribir(IObservador observador);
        void Desuscribir(IObservador observador);
        void Notificar();
    }
}