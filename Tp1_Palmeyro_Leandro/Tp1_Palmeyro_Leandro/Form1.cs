using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp1_Palmeyro_Leandro
{
    public partial class Form1 : Form
    {
        private Numero numero1;
        private Numero numero2;
        private string operador;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.numero1 = new Numero(txtNumero1.Text);
            this.numero2 = new Numero(txtNumero2.Text);
            this.operador = cmbOperacion.Text;

            this.lblResultado.Text = Calculadora.operar(numero1, numero2, operador).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = "";
            this.txtNumero1.ResetText();
            this.txtNumero2.ResetText();
            this.cmbOperacion.ResetText();
        }
    }
}
