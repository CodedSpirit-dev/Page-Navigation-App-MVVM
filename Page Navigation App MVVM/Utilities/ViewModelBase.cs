// Incluimos las librerías necesarias para el funcionamiento de nuestro código.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

// Definimos el espacio de nombres. Es como un contenedor para agrupar clases relacionadas.
namespace Page_Navigation_App_MVVM.Utilities
{
    // Creamos una clase 'ViewModelBase' que implementa la interfaz 'INotifyPropertyChanged'.
    // Esta clase sirve como base para cualquier ViewModel en el patrón MVVM, facilitando la notificación de cambios en las propiedades.
    class ViewModelBase : INotifyPropertyChanged
    {
        // Evento definido por la interfaz INotifyPropertyChanged.
        // Se dispara cuando una propiedad del ViewModel cambia, lo cual es esencial para el enlace de datos (data binding) en WPF.
        public event PropertyChangedEventHandler PropertyChanged;

        // Método que dispara el evento PropertyChanged. Se llama en los setters de las propiedades del ViewModel.
        public void onPropertyChanged([CallerMemberName] string propName = null)

            //Test
        {
            // ?. es el operador de acceso condicional. Solo invoca el método si PropertyChanged no es null.
            // Esto evita excepciones si no hay suscriptores al evento.
            // 'this' se refiere a la instancia actual de ViewModelBase.
            // PropertyChangedEventArgs proporciona el nombre de la propiedad que ha cambiado.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
