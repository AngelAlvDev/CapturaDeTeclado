using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapturaDeTeclado
{
    public partial class Form1 : Form
    {
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {

            if (keyData == Keys.A)
            {
                label1.Text = label1.Text + "A";
            }

            if (keyData == Keys.B)
            {
                label1.Text = label1.Text + "B"; //aqui la accion del F2
            }

            return true;
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
