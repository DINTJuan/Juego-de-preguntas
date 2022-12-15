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
            if(vm.ComprobarC2())
            {
                LimpiarCatego();
                vm.CrearListasPartida();
                ValidarButton.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Tiene que haber 1 pregunta en cada Categoria y dificultad (12)", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LimpiarCatego()
        {
            CienciaImagen.Visibility = Visibility.Collapsed;
            HistoriaImagen.Visibility = Visibility.Collapsed;
            LiteraturaImagen.Visibility = Visibility.Collapsed;
            GeografiaImagen.Visibility = Visibility.Collapsed;
            DeporteImagen.Visibility = Visibility.Collapsed;
            CineImagen.Visibility = Visibility.Collapsed;
        }

        private void ValidarButton_Click(object sender, RoutedEventArgs e)
        {
           string comprobar = vm.Validar(TextBoxRespuesta1.Text);
            switch(comprobar)
            {
                case "Ciencia y Naturaleza":
                    CienciaImagen.Visibility = Visibility.Visible;
                    TextBoxRespuesta1.Text = "";
                break;
                case "Historia":
                    HistoriaImagen.Visibility = Visibility.Visible;
                    TextBoxRespuesta1.Text = "";
                    break;
                case "Arte y Literatura":
                    LiteraturaImagen.Visibility = Visibility.Visible;
                    TextBoxRespuesta1.Text = "";
                    break;
                case "Geografía":
                    GeografiaImagen.Visibility = Visibility.Visible;
                    TextBoxRespuesta1.Text = "";
                    break;
                case "Deporte":
                    DeporteImagen.Visibility = Visibility.Visible;
                    TextBoxRespuesta1.Text = "";
                    break;
                case "Espectáculos":
                    CineImagen.Visibility = Visibility.Visible;
                    TextBoxRespuesta1.Text = "";
                    break;
                case "Ganado":
                    vm.Ganado();
                    ValidarButton.IsEnabled = false;
                    TextBoxRespuesta1.Text = "";
                    VisibilidadesOn();
                    MessageBox.Show("Has ganado!!!", "Victoria", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    VisibilidadesOff();
                    break;
                case "Fallido":
                    MessageBox.Show("Has fallado vuelve a intentarlo (usa la pista si lo necesitas)", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
                    TextBoxRespuesta1.Text = "";
                    break;
            }
        }

        private void VisibilidadesOn()
        {
            CienciaImagen.Visibility = Visibility.Visible;
            HistoriaImagen.Visibility = Visibility.Visible;
            GeografiaImagen.Visibility = Visibility.Visible;
            LiteraturaImagen.Visibility = Visibility.Visible;
            DeporteImagen.Visibility = Visibility.Visible;
            CineImagen.Visibility = Visibility.Visible;
        }
        private void VisibilidadesOff()
        {
            CienciaImagen.Visibility = Visibility.Collapsed;
            HistoriaImagen.Visibility = Visibility.Collapsed;
            GeografiaImagen.Visibility = Visibility.Collapsed;
            LiteraturaImagen.Visibility = Visibility.Collapsed;
            DeporteImagen.Visibility = Visibility.Collapsed;
            CineImagen.Visibility = Visibility.Collapsed;
        }
    }
}
