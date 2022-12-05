using Azure.Storage.Blobs;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
        public string SacarUrl()
        {
            Azure azu = new Azure();
            string urlImagen = azu.SubirFoto(openFileDialog.FileName);
            return urlImagen;
        }
        public string SacraRuta()
        {
            return openFileDialog.FileName;
        }

    }
}
