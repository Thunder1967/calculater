using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer
{
    public partial class Output : Form
    {
        double display;
        public Output(double a)
        {
            InitializeComponent();
            display = a;
        }

        private void Output_Load(object sender, EventArgs e)
        {
            textBox1.Text = display.ToString();
        }
    }
}
