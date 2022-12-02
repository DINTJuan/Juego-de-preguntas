using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Juego_de_preguntas
{
    class Dialogo
    {
        private OpenFileDialog openFileDialog;

        public Dialogo()
        {
        }

        public void MostrarDialog()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }

    }
}
