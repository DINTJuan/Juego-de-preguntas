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
        private int dificultad;
        private Pregunta preguntaCreada;
        private Pregunta preguntaSelecionada;
        private Pregunta preguntaJugada;
        private ObservableCollection<Pregunta> preguntas;
        private ObservableCollection<Pregunta> preguntasPartida;
        private JSon js = new JSon();

        public Pregunta PreguntaCreada
        {
            get { return preguntaCreada; }
            set { SetProperty(ref preguntaCreada, value); }
        }
        public Pregunta PreguntaJugada
        {
            get { return preguntaJugada; }
            set { SetProperty(ref preguntaJugada, value); }
        }
        public int Dificultad
        {
            get { return dificultad; }
            set { SetProperty(ref dificultad, value); }
        }
        public ObservableCollection<Pregunta> Preguntas
        {
            get { return preguntas; }
            set { SetProperty(ref preguntas, value); }
        }
        public ObservableCollection<Pregunta> PreguntasPartida
        {
            get { return preguntasPartida; }
            set { SetProperty(ref preguntasPartida, value); }
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
            this.PreguntasPartida = new ObservableCollection<Pregunta>();
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
        public void AñadirImagen(string ruta)
        {
            PreguntaCreada.Imagen = ruta;
        }
        public void EditarImagen(string ruta)
        {
            PreguntaSelecionada.Imagen = ruta;
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

        public void CrearListasPartida()
        {
            this.PreguntasPartida = new ObservableCollection<Pregunta>();
            foreach (Pregunta p in Preguntas)
            {
                if(Dificultad == 1)
                {
                    if(p.Dificultad == "Dificil")
                    {
                        PreguntasPartida.Add(p);
                    }
                    
                }
                else
                {
                    if (p.Dificultad == "Normal")
                    {
                        PreguntasPartida.Add(p);
                    }
                }
            }
            Random random = new Random();
            int numero = random.Next(0, PreguntasPartida.Count());
            PreguntaJugada = PreguntasPartida[numero];
        }



    }
}
