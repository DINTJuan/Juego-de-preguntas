using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_preguntas
{
    class JSon
    {
        public JSon()
        {
        }
        public void Escribir(ObservableCollection<Pregunta> preguntas,string ruta)
        {
            string personasJson = JsonConvert.SerializeObject(preguntas);
            File.WriteAllText(ruta, personasJson);
        }

        public ObservableCollection<Pregunta> Leer(string ruta)
        {
            string personasJson = File.ReadAllText(ruta);
            ObservableCollection<Pregunta> preguntas = JsonConvert.DeserializeObject<ObservableCollection<Pregunta>>(personasJson);
            return preguntas;
        }
    }
}
