using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace computer
{
    public partial class setconst : Form
    {
        public struct Const
        {
            public Const(string a, double s)
            {
                name = a;
                value = s;
            }
            public string name { get; set;  }
            public double value { get; set; }
            public string display()
            {
                return name + "  =  " + value;
            }
        }

        public List<Const> m_Const = new List<Const>() { new Const("π", Math.PI), new Const("e", Math.E) };
        public string Output;
        bool isItemAllowed(string a)
        {
            try
            {
                double b = Convert.ToDouble(a);
            }
            catch (Exception)
            {
                for (int i = 0; i < m_Const.Count; i++)
                {
                    if (m_Const[i].name == a)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public setconst()
        {
            InitializeComponent();
            listBox.Items.Add(m_Const[0].display());
            listBox.Items.Add(m_Const[1].display());
            listBox.Items.Add("新增常數");
        }

        private void setconst_Load(object sender, EventArgs e)
        {
            listBox.SelectedIndex = listBox.Items.Count - 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == 0 || listBox.SelectedIndex == 1)
            {
                MessageBox.Show("您不能修改內建常數", "錯誤", 0, MessageBoxIcon.Error);
            }
            else if(listBox.SelectedIndex == listBox.Items.Count - 1)
            {
                if (isItemAllowed(input_name.Text))
                {
                    try
                    {
                        m_Const.Add(new Const(input_name.Text, Convert.ToDouble(input_value.Text)));
                        listBox.Items.Insert(listBox.Items.Count - 1, m_Const[m_Const.Count - 1].display());
                        input_name.Text = "";
                        input_value.Text = "";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("您不能在常數名或數值留白", "錯誤", 0, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("您不能使用重複或純數字之常數名", "錯誤", 0, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    int q = listBox.SelectedIndex;
                    m_Const.RemoveAt(q);
                    m_Const.Insert(q, new Const(input_name.Text, Convert.ToDouble(input_value.Text)));
                    listBox.Items.RemoveAt(q);
                    listBox.Items.Insert(q, m_Const[q].display());
                    listBox.SelectedIndex = q;
                }
                catch (Exception)
                {
                    MessageBox.Show("您不能在數值處留白", "錯誤", 0, MessageBoxIcon.Error);
                }
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == 0 || listBox.SelectedIndex == 1 || listBox.SelectedIndex == listBox.Items.Count - 1)
            {
                MessageBox.Show("您不能移除內建常數", "錯誤", 0, MessageBoxIcon.Error);
            }
            else
            {
                int a = listBox.SelectedIndex;
                listBox.Items.RemoveAt(a);
                m_Const.RemoveAt(a);
                listBox.SelectedIndex = a;
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == listBox.Items.Count-1)
            {
                button_change.Text = "新增";
                input_name.Text = "";
                input_value.Text = "";
                input_name.Enabled = true;
                button_insert.Enabled = false;
            }
            else
            {
                if(listBox.SelectedIndex == -1)
                {
                    listBox.SelectedIndex = listBox.Items.Count - 1;
                    return;
                }
                button_change.Text = "修改";
                input_name.Text = m_Const[listBox.SelectedIndex].name;
                input_value.Text = m_Const[listBox.SelectedIndex].value.ToString();
                input_name.Enabled = false;
                Output = m_Const[listBox.SelectedIndex].name;
                if (Form1.mode == 1 || Form1.mode == 0)
                {
                    button_insert.Enabled = true;
                }
            }
        }
    }
}
