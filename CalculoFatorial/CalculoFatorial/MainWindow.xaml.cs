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

namespace CalculoFatorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int valor = txtNumero.Text != "" ? Convert.ToInt32(txtNumero.Text) : 1;

                txtResultado.Text = Calculo_Fatorial(valor).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro {ex.Message}");
            }
            
        }

        private double Calculo_Fatorial(int numero)
        {
            if (numero == 1)
                return 1;
            else
                return numero * Calculo_Fatorial(numero - 1);
        }
    }
}
