using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_de_preguntas
{
    class SaveDialog
    {
        SaveFileDialog saveFileDialog;

        public SaveDialog()
        {
        }

        public void MostrarDialog()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
        }
        public string SacarRuta()
        {
            return saveFileDialog.FileName;
        }
    }
}
