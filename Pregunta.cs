using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_preguntas
{
    class Pregunta : ObservableObject
    {
        private string categoria;
        public string Categoria
        {
            get { return categoria; }
            set { SetProperty(ref categoria, value); }
        }
        private string imagen;
        public string Imagen
        {
            get { return imagen; }
            set { SetProperty(ref imagen, value); }
        }
        private string pista;
        public string Pista
        {
            get { return pista; }
            set { SetProperty(ref pista, value); }
        }
        private string dificultad;
        public string Dificultad
        {
            get { return dificultad; }
            set { SetProperty(ref dificultad, value); }
        }
        private string respuesta;
        public string Respuesta
        {
            get { return respuesta; }
            set { SetProperty(ref respuesta, value); }
        }
        private string preguntaF;
        public string PreguntaF
        {
            get { return preguntaF; }
            set { SetProperty(ref preguntaF, value); }
        }

        public Pregunta()
        {
        }

        public Pregunta(string categoria, string imagen, string pista, string dificultad, string respuesta, string preguntaF)
        {
            this.categoria = categoria;
            this.imagen = imagen;
            this.pista = pista;
            this.dificultad = dificultad;
            this.respuesta = respuesta;
            this.preguntaF = preguntaF;
        }
    }
}
