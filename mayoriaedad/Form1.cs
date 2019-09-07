using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayoriaedad
{
    public partial class programa : Form
    {
        public programa()
        {
            InitializeComponent();
        }

        private void Btncontinuar_Click(object sender, EventArgs e)
        {
            double añotxt2 = double.Parse(añotxt.Text);

              if (añotxt2 <= 2001) {

                MessageBox.Show("El usuario es mayor de edad.");
              }
            else{
                MessageBox.Show("El usuario es menor de edad." );
            }
        }
    }
}
