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
    public partial class ventanaResultado : Form
    {
        string mensaje = "No cargado";
        public ventanaResultado()
        {
            InitializeComponent();
        }

        private void ventanaResultado_Load(object sender, EventArgs e)
        {
            _labelMensaje.Text = mensaje;
            this.Text = "Ventana resultados";
        }
        public void cargarMensaje(string pMensaje) {
            mensaje = pMensaje;
        }

        private void _buttonRetornar_Click(object sender, EventArgs e)
        {
            this.Hide();
            cargarNuevaVentana();
            
        }
        private void cargarNuevaVentana() {
            ventanaPrincipal vent2 = new ventanaPrincipal();
            vent2.ShowDialog();
        }
    }
}
