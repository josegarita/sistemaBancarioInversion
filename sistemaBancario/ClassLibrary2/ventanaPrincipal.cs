using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Factory;
using Model;
using Model.Products;

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
            this.Text = "Ventana principal";
        }

        private void _buttonConfirmar_Click(object sender, EventArgs e)
        {
            //obtencion de datos
            string nombre = _textBoxNomClien.Text;
            string sistemaAhorro = tomarTipoCuenta();
            string monto = _textBoxMonto.Text;
            string plazo = _textBoxDias.Text;
            string moneda = _textBoxMoneda.Text;
            //Console.WriteLine(sistemaAhorro);

            //Creacion del producto
            ServiceFactory fabric = new ServiceFactory();
            //creacion de la interfaz resultado
            this.Hide();
            
            CalculatorMessage resul = calculoResultado(sistemaAhorro, monto, plazo, moneda);
            ventanaResultado vent = new ventanaResultado();
            string men = armarResultado(resul, nombre, sistemaAhorro, monto, plazo, moneda);
            vent.cargarMensaje(men);
            vent.ShowDialog();
        }
        private string tomarTipoCuenta() {
            if (_radioButtonCC.Checked == true) {
                return "CuentaCorriente";
            }
            if (_radioButtonCertificado.Checked == true)
            {
                return "CertificadoDeDeposito";
            }
            else 
            {
                return "InversionVistaPactada";
            }
            
        }

        private CalculatorMessage calculoResultado(string pSistemaAhorro,
            string pMonto,
            string pPlazo,
            string pMoneda)
        {
            InterestCalculator calculator = new InterestCalculator(pSistemaAhorro);
            MoneyType enumMoneda = (MoneyType) Enum.Parse(typeof(MoneyType), pMoneda, true);
            decimal monto = decimal.Parse(pMonto);
            int dias = int.Parse(pPlazo);
            //Console.WriteLine(enumMoneda);
            CalculatorMessage resultado = calculator.calculateInterestPerformance(monto, dias, enumMoneda);
            return resultado;
        }

        private string armarResultado(CalculatorMessage pCalculator, 
            string pNombre, 
            string pSistemaAhorro,
            string pMonto,
            string pPlazo,
            string pMoneda)
        {
            string retornar = "";
            retornar += "El resultado de la transaccion para: "+pNombre+"\n";
            retornar += "Intereses ganados: " + Math.Round(pCalculator.InterestEarned, 2) + "\n";
            retornar += "Impuestos aplicados: "+pCalculator.TaxApplied+"\n";
            retornar += "El balance final es de: " + Math.Round(pCalculator.FinalBalance, 2) + "\n";
            retornar += "Su cuenta: " + pCalculator.Message + "\n";
            retornar += "Con un sistema de ahorro en: "+pMoneda+"\n";
            retornar += "Mediante la modalidad de: "+pSistemaAhorro+"\n";
            retornar += "Con un monto de: "+pMonto+"\n";
            retornar += "En un plazo de: "+pPlazo+"\n";
            retornar += "Con un interes de: " + (pCalculator.percentegeApplied * /*entedible*/100) +"%"+ "\n";
            retornar += "\n\n\n\n";
            retornar += "Gracias\n";
            //retornar += "\n";
            retornar += "";
            return retornar;
        }
    }
}
