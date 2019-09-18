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

namespace _180919
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Login con puerta abierta";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Iniciar_Click(object sender, RoutedEventArgs e)
        {
            if (nombre.Text=="juancho")
            {
                if (contrasena.Text=="123tamarindo")
                {
                    Window1 form = new Window1();
                    form.ShowDialog();
                     
                }
                else
                {
                    MessageBox.Show("Su nombre de usuario o su contraseña son incorrectos.");
                }
            }
            else
            {
                MessageBox.Show("Su nombre de usuario o su contraseña son incorrectos.");
            }
        }
    }
}
