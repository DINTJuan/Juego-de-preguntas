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
        private Pregunta preguntaSelecionada;
        private ObservableCollection<Pregunta> preguntas;
        private JSon js = new JSon();

        public Pregunta PreguntaCreada
        {
            get { return preguntaCreada; }
            set { SetProperty(ref preguntaCreada, value); }
        }
        public ObservableCollection<Pregunta> Preguntas
        {
            get { return preguntas; }
            set { SetProperty(ref preguntas, value); }
        }

        public Pregunta PreguntaSelecionada
        {
            get { return preguntaSelecionada; }
            set { SetProperty(ref preguntaSelecionada, value); }
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
            this.Preguntas = new ObservableCollection<Pregunta>();
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

        public void Añadir()
        {
            Preguntas.Add(PreguntaCreada);
            Limpiar();
        }

        public void Guardar(string ruta)
        {
            js.Escribir(preguntas,ruta);
        }

        public void Cargar(string ruta)
        {
            Preguntas = js.Leer(ruta);
        }
        public void Eliminar()
        {
            Preguntas.Remove(PreguntaSelecionada);
        }



    }
}
