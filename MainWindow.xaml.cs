using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Juego_de_preguntas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM vm = new MainWindowVM();
        private Dialogo diag = new Dialogo();
        private SaveDialog sav = new SaveDialog();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = (object)this.vm;
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.Limpiar();
        }

        private void ExaminarButton_Click(object sender, RoutedEventArgs e)
        {
            diag.MostrarDialog();
            vm.AñadirImagen(diag.SacarUrl());
        }

        private void AñadirButton_Click(object sender, RoutedEventArgs e)
        {
            vm.Añadir();
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.Eliminar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            sav.MostrarDialog();
            vm.Guardar(sav.SacarRuta());
        }

        private void CargarButton_Click(object sender, RoutedEventArgs e)
        {
            diag.MostrarDialog();
            vm.Cargar(diag.SacraRuta());
        }

        private void ExaminarEditar_Click(object sender, RoutedEventArgs e)
        {
            diag.MostrarDialog();
            vm.EditarImagen(diag.SacraRuta());
        }

        private void NuevaButton_Click(object sender, RoutedEventArgs e)
        {
            vm.CrearListasPartida();
        }
    }
}
