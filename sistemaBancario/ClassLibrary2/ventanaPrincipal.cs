using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ventanaPrincipal : Form
    {
        public ventanaPrincipal()
        {
            InitializeComponent();
        }

        private void ventanaPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void _buttonConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = _textBoxNomClien.Text;
            string sistemaAhorro = tomarTipoCuenta();
            string monto = _textBoxMonto.Text;
            string plazo = _textBoxDias.Text;
            string moneda = _textBoxMoneda.Text;
            Console.WriteLine(sistemaAhorro);
        }
        private string tomarTipoCuenta() {
            if (_radioButtonCC.Checked == true) {
                return "Cuenta Corriente";
            }
            if (_radioButtonCertificado.Checked == true)
            {
                return "Certificado";
            }
            else 
            {
                return "Deposito a la vista";
            }
        }
       
        
    }
}
