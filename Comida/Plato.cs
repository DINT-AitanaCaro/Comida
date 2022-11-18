using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel;

namespace Comida
{
    class Plato : INotifyPropertyChanged
    {
        private string _nombre;
        public string Nombre
        {
            get { return this._nombre; }
            set
            {
                if (this._nombre != value)
                {
                    this._nombre = value;
                    this.NotifyPropertyChanged("Nombre");
                }
            }
        }
        private string _imagen;
        public string Imagen
        {
            get { return this._imagen; }
            set
            {
                if (this._imagen != value)
                {
                    this._imagen = value;
                    this.NotifyPropertyChanged("Imagen");
                }
            }
        }
        private string _tipo;
        public string Tipo
        {
            get { return this._tipo; }
            set
            {
                if (this._tipo != value)
                {
                    this._tipo = value;
                    this.NotifyPropertyChanged("Tipo");
                }
            }
        }
        private bool _gluten;
        public bool Gluten
        {
            get { return this._gluten; }
            set
            {
                if (this._gluten != value)
                {
                    this._gluten = value;
                    this.NotifyPropertyChanged("Gluten");
                }
            }
        }

        private bool _soja;
        public bool Soja
        {
            get { return this._soja; }
            set
            {
                if (this._soja != value)
                {
                    this._soja = value;
                    this.NotifyPropertyChanged("Soja");
                }
            }
        }
        private bool _leche;
        public bool Leche {
            get { return this._leche; }
            set
            {
                if (this._leche != value)
                {
                    this._leche = value;
                    this.NotifyPropertyChanged("Leche");
                }
            }
        }
        private bool _sulfitos;
        public bool Sulfitos
        {
            get { return this._sulfitos; }
            set
            {
                if (this._sulfitos != value)
                {
                    this._sulfitos = value;
                    this.NotifyPropertyChanged("Sulfitos");
                }
            }
        }

        public Plato(string nombre, string imagen, string tipo, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Gluten = gluten;
            Soja = soja;
            Leche = leche;
            Sulfitos = sulfitos;
        }

        public Plato()
        {
        }

        public static ObservableCollection<Plato> GetSamples(string rutaImagenes)
        {
            ObservableCollection<Plato> lista = new ObservableCollection<Plato>();

            lista.Add(new Plato("Hamburguesa", Path.Combine(rutaImagenes, @"burguer.jpg"), "Americana", true, false, true, true));
            lista.Add(new Plato("Dumplings", Path.Combine(rutaImagenes, @"dumplings.jpg"), "China", true, true, false, false));
            lista.Add(new Plato("Tacos", Path.Combine(rutaImagenes, @"tacos.jpg"), "Mexicana", true, false, false, true));
            lista.Add(new Plato("Cerdo agridulce", Path.Combine(rutaImagenes, @"cerdoagridulce.jpg"), "China", true, true, false, true));
            lista.Add(new Plato("Hot dogs", Path.Combine(rutaImagenes, @"hotdog.jpg"), "Americana", true, true, true, true));
            lista.Add(new Plato("Fajitas", Path.Combine(rutaImagenes, @"fajitas.jpg"), "Mexicana", true, false, false, true));

            return lista;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

