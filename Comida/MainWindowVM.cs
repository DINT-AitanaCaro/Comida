using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {

        private ObservableCollection<Plato> _platos;
        public ObservableCollection<Plato> Platos
        {
            get { return _platos; }
            set
            {
                _platos = value;
                NotifyPropertyChanged("Platos");
            }
        }

        private ObservableCollection<string> _tiposComida;
        public ObservableCollection<string> TiposComida
        {
            get { return _tiposComida; }
            set
            {
                _tiposComida = value;
                NotifyPropertyChanged("TiposComida");
            }
        }

        private Plato _platoSeleccionado;
        public Plato PlatoSeleccionado
        {
            get { return _platoSeleccionado; }
            set
            {
                _platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }

        public MainWindowVM()
        {
            Platos = Plato.GetSamples(@"C:\Users\alumno\source\repos\Comida\FotosPlatos");
            TiposComida = new ObservableCollection<string>() { "Americana", "China", "Mexicana" };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void LimpiaFormulario()
        {
            PlatoSeleccionado = null;
        }
    }
}
