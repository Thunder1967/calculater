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
    public partial class InputLog : Form
    {
        public double Output;
        public InputLog()
        {
            InitializeComponent();
        }

        private void InputLog_Load(object sender, EventArgs e)
        {
            InputText.Text = "10";
        }

        private void button_no_Click(object sender, EventArgs e)
        {
            
        }

        private void button_yes_Click(object sender, EventArgs e)
        {
            try
            {
                Output = Convert.ToDouble(InputText.Text);
                DialogResult = DialogResult.Yes;
            }
            catch(Exception)
            {
                MessageBox.Show("請勿輸入非數字字元", "錯誤", 0, MessageBoxIcon.Error);
            }
        }
    }
}
