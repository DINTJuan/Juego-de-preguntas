using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_preguntas
{
    class MainWindowVM : ObservableObject
    {
        private Pregunta preguntaCreada;

        public Pregunta PreguntaCreada
        {
            get { return preguntaCreada; }
            set { SetProperty(ref preguntaCreada, value); }
        }

        private ObservableCollection<string> categorias;

        public ObservableCollection<string> Categorias
        {
            get { return categorias; }
            set { SetProperty(ref categorias, value); }
        }

        public ObservableCollection<string> dificultades;
        public ObservableCollection<string> Dificultades
        {
            get { return dificultades; }
            set { SetProperty(ref dificultades, value); }
        }

        public MainWindowVM()
        {
            ObservableCollection<string> catg = new ObservableCollection<string>();
            catg.Add("Ciencia y Naturaleza");
            catg.Add("Historia");
            catg.Add("Arte y Literatura");
            catg.Add("Geografía");
            catg.Add("Deporte");
            catg.Add("Espectáculos");
            this.categorias = catg;

            ObservableCollection<string> difi = new ObservableCollection<string>();
            difi.Add("Normal");
            difi.Add("Dificil");
            this.dificultades = difi;
            Iniciar();
        }

        private void Iniciar()
        {
            PreguntaCreada = new Pregunta();
            PreguntaCreada.Dificultad = "Normal";
            PreguntaCreada.Categoria = "Ciencia y Naturaleza";
        }

        public void Limpiar()
        {
            Iniciar();
        }



    }
}
