// Importamos las librerías necesarias para el funcionamiento del código.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

// Definimos el espacio de nombres, que es como un contenedor para clases y otros espacios de nombres.
namespace Page_Navigation_App_MVVM.Utilities
{
    // Creamos una clase 'RelayCommand' que implementa la interfaz 'ICommand'.
    // Esta clase es útil para el enlace de comandos en el patrón MVVM.
    class RelayCommand : ICommand
    {
        // Declaramos un delegado Action que representa un método que recibe un objeto y no devuelve nada.
        private readonly Action<object> _execute;

        // Declaramos un delegado Func que representa un método que recibe un objeto y devuelve un booleano.
        private readonly Func<object, bool> _canExecute;

        // Evento que se dispara cuando cambia la posibilidad de ejecución del comando.
        public event EventHandler CanExecuteChanged
        {
            // Al agregar un manejador al evento, lo suscribimos al evento RequerySuggested del CommandManager.
            add { CommandManager.RequerySuggested += value; }

            // Al eliminar un manejador del evento, lo desuscribimos del evento RequerySuggested del CommandManager.
            remove { CommandManager.RequerySuggested -= value; }
        }

        // Constructor de la clase RelayCommand. Inicializa las variables _execute y _canExecute.
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute; // Asignamos el método que se ejecutará cuando se active el comando.
            _canExecute = canExecute; // Asignamos el método que determina si el comando puede ejecutarse.
        }
    }
}
