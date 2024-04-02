using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmInico : Form
    {
        Thread th;
        public FrmInico()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Form1 calculadora = new Form1();
            calculadora.ShowDialog();
            this.Close();
        }

        private void FrmInico_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
