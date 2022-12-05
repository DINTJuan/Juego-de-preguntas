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
            TextBoxImagen.Text = diag.SacarUrl();
        }

        private void AñadirButton_Click(object sender, RoutedEventArgs e)
        {
            vm.Añadir();
        }
    }
}
