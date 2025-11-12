using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfAppPOOArch
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //LISTAS DE CLIENTES Y CUENTAS
        public ObservableCollection<Cliente> lstClientes { get; set; }
        public ObservableCollection<CuentaBancaria> lstCuentasBa { get; set; }

        //VARIABLES DE INICIO DE LOS ID DE Clientes y Cuentas
        private int idCliente = 111;
        private int idCtaB = 150;
        public MainWindow()
        {
            InitializeComponent();
            lstClientes = new ObservableCollection<Cliente>();
            lstCuentasBa = new ObservableCollection<CuentaBancaria>();

            //CARGAR DATOS A LOS DATAGRIDS
            dgClientes.ItemsSource = lstClientes;
            dgCuentas.ItemsSource = lstCuentasBa;
        }

        private void btnAgregarCliente_Click(object sender, RoutedEventArgs e)
        {
            if(txtCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de cliente");
                return;
            }
            else
            {
                Cliente cli = new Cliente(idCliente, txtCliente.Text);
                lstClientes.Add(cli);
                idCliente++;
                txtCliente.Clear();
            }
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = dgClientes.SelectedItem as Cliente;
            lstClientes.Remove(cli);
        }

        private void btnAgregarCuenta_Click(object sender, RoutedEventArgs e)
        {
            Cliente Cli = dgClientes.SelectedItem as Cliente;
            if(Cli is null)
            {
                MessageBox.Show("no ha escogido un cliente");
                return;
            }
            else
            {
                double saldo = double.Parse(txtCuentas.Text);
                if (saldo > 0)
                {
                    CuentaBancaria ctaB = new CuentaBancaria(idCtaB, saldo);
                    Cli.lstCtas.Add(ctaB);//lstCtas es la lista de las cuentas de la clase eCliete
                    lstCuentasBa.Add(ctaB);//lstCtasBa es la lsita del data?Grid
                    idCtaB++;
                   // dgClientes.SelectedChanged(null,null)
                    txtCuentas.Clear();
                }
                else
                {
                    MessageBox.Show("ingrese un monto valido ");
                }
            }
        }
    }
}
