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
    public partial class Form1 : Form
    {
        InputLog m_InputLog = new InputLog();
        setconst m_setconst = new setconst();

        string Input = string.Empty;
        public static int mode = 0; // 0:number 、 "(" or sign  1:number or operate or ")"  2: operate or ")"
        bool RadOrDeg = true; //true:Rad false:Deg
        const double DegToRad = Math.PI / 180.0;
        string StoredSting = "";
        bool UseKeyInput= false;

        public Form1()
        {
            InitializeComponent();
        }


        private void DisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectAngleMod.SelectedIndex = 0;
        }


        private void UpdateDisplay(object sender, EventArgs e)
        {
            Display.Text = Input;
        }

        private string FindConst(string a)
        {
            foreach(var i in m_setconst.m_Const)
            {
                if (i.name == a)
                {
                    return i.value.ToString();
                }
            }
            return "-1";
        } 

        private void Input_equal_Click(object sender, EventArgs e)
        {
            if (UseKeyInput)
            {
                MessageBox.Show("請先完成輸入", "錯誤", 0, MessageBoxIcon.Error);
                return;
            }

            Stack<string> ToRPN = new Stack<string>();
            Queue<string> Run2 = new Queue<string>();
            Stack<double> calculate = new Stack<double>();
            string[] Run1 = Input.Split(' ');
            int Run1Count = 0;
            try
            {
                while (true)
                {
                    if (Run1Count == Run1.Length) break;
                    string value = Run1[Run1Count];
                    if(value == "")
                    {
                    }
                    else if (value.Contains('('))
                    {
                        ToRPN.Push(value);
                    }
                    else if (value == ")")
                    {
                        while (true)
                        {
                            if (ToRPN.Peek() == "(")
                            {
                                ToRPN.Pop();
                                break;
                            }
                            else if (ToRPN.Peek().Contains('('))
                            {
                                Run2.Enqueue(ToRPN.Pop());
                                break;
                            }
                            else
                            {
                                Run2.Enqueue(ToRPN.Pop());
                            }
                        }
                    }
                    else if (value == "+" || value == "-" || value == "*" || value == "/" || value == "%" || value == "^")
                    {
                        while (ToRPN.Count != 0 && OPweight(ToRPN.Peek()[0]) >= OPweight(value[0]))
                        {
                            Run2.Enqueue(ToRPN.Pop());
                        }
                        ToRPN.Push(value);
                    }
                    else
                    {
                        try
                        {
                            Convert.ToDouble(value);
                            Run2.Enqueue(value);
                        }
                        catch (Exception)
                        {
                            string a = FindConst(value);
                            if (a != "-1")
                            {
                                Run2.Enqueue(a);
                            }
                            else
                            {
                                MessageBox.Show("無法識別常數 \"" + value + "\"", "錯誤", 0, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    Run1Count++;
                }
                while (ToRPN.Count != 0)
                {
                    Run2.Enqueue(ToRPN.Pop());
                }

                while (Run2.Count != 0)
                {
                    string value = Run2.Dequeue();
                    if (value == "+")
                    {
                        double v1 = calculate.Pop();
                        double v2 = calculate.Pop();
                        calculate.Push(v2 + v1);
                    }

                    else if (value == "-")
                    {
                        double v1 = calculate.Pop();
                        double v2 = calculate.Pop();
                        calculate.Push(v2 - v1);
                    }

                    else if (value == "*")
                    {
                        double v1 = calculate.Pop();
                        double v2 = calculate.Pop();
                        calculate.Push(v2 * v1);
                    }

                    else if (value == "/")
                    {
                        double v1 = calculate.Pop();
                        double v2 = calculate.Pop();
                        if (v1 == 0d)
                        {
                            MessageBox.Show("無法除以0", "錯誤", 0, MessageBoxIcon.Error);
                            return;
                        }
                        calculate.Push(v2 / v1);
                    }

                    else if (value == "%")
                    {
                        double v1 = calculate.Pop();
                        double v2 = calculate.Pop();
                        if (v1 == 0d)
                        {
                            MessageBox.Show("無法模除以0", "錯誤", 0, MessageBoxIcon.Error);
                            return;
                        }
                        calculate.Push(v2 % v1);
                    }

                    else if (value == "^")
                    {
                        double v1 = calculate.Pop();
                        double v2 = calculate.Pop();
                        calculate.Push(Math.Pow(v2, v1));
                    }

                    else if (value == "sin(")
                    {
                        calculate.Push(Math.Sin(calculate.Pop() * (RadOrDeg ? 1 : DegToRad) ));
                    }

                    else if (value == "cos(")
                    {
                        calculate.Push(Math.Cos(calculate.Pop() * (RadOrDeg ? 1 : DegToRad)));
                    }

                    else if (value == "tan(")
                    {
                        calculate.Push(Math.Tan(calculate.Pop() * (RadOrDeg ? 1 : DegToRad)));
                    }

                    else if (value == "sinh(")
                    {
                        calculate.Push(Math.Sinh(calculate.Pop() * (RadOrDeg ? 1 : DegToRad)));
                    }

                    else if (value == "cosh(")
                    {
                        calculate.Push(Math.Cosh(calculate.Pop() * (RadOrDeg ? 1 : DegToRad)));
                    }

                    else if (value == "tanh(")
                    {
                        calculate.Push(Math.Tanh(calculate.Pop() * (RadOrDeg ? 1 : DegToRad)));
                    }

                    else if (value == "Asin(")
                    {
                        calculate.Push(Math.Asin(calculate.Pop()) * (RadOrDeg ? 1 : 1 / DegToRad));
                    }

                    else if (value == "Acos(")
                    {
                        calculate.Push(Math.Acos(calculate.Pop()) * (RadOrDeg ? 1 : 1 / DegToRad));
                    }

                    else if (value == "Atan(")
                    {
                        calculate.Push(Math.Atan(calculate.Pop()) * (RadOrDeg ? 1 : 1 / DegToRad));
                    }

                    else if (value.Contains("log"))
                    {
                        calculate.Push(Math.Log(calculate.Pop(),Convert.ToDouble(value.Substring(3,value.Length - 4))));
                    }

                    else if (value == "abs(")
                    {
                        calculate.Push(Math.Abs(calculate.Pop()));
                    }

                    else if (value == "X!(")
                    {
                        calculate.Push(MyGammaDouble(calculate.Pop()+1));
                    }

                    else if (value == "In(")
                    {
                        calculate.Push(Math.Log(calculate.Pop(),Math.E));
                    }

                    else if (value == "1/(")
                    {
                        if (calculate.Peek() == 0)
                        {
                            MessageBox.Show("無法除以0", "錯誤", 0, MessageBoxIcon.Error);
                            return;
                        }
                        calculate.Push(1 / calculate.Pop());
                    }

                    else
                    {
                        calculate.Push(Convert.ToDouble(value));
                    }
                }
                Output m_Output = new Output(calculate.Pop());
                m_Output.ShowDialog(this);
                m_Output = null;
            }
            catch (Exception)
            {
                MessageBox.Show("出現未知錯誤，請檢查算式是否正確", "錯誤", 0, MessageBoxIcon.Error);
            }
        }

        int OPweight(char a)
        {
            switch (a)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                case '%':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }

        double MyGammaDouble(double z)
        {
            int g = 7;
            double[] p = {0.99999999999980993, 676.5203681218851, -1259.1392167224028,
            771.32342877765313, -176.61502916214059, 12.507343278686905,
            -0.13857109526572012, 9.9843695780195716e-6, 1.5056327351493116e-7};
            if (z < 0.5)
                return Math.PI / (Math.Sin(Math.PI * z) * MyGammaDouble(1 - z));
            z -= 1;
            double x = p[0];
            for (var i = 1; i < g + 2; i++)
                x += p[i] / (z + i);
            double t = z + g + 0.5;
            return Math.Sqrt(2 * Math.PI) * (Math.Pow(t, z + 0.5)) * Math.Exp(-t) * x;
        }


        void InputNumber(string a)
        {
            if (UseKeyInput)
            {
                keyinputbox.Text += a;
            }
            else if (mode != 2)
            {
                Input += a;
                mode = 1;
            }
            else
            {
                MessageBox.Show("您不能在\")\"後插入數字", "錯誤", 0, MessageBoxIcon.Error);
            }
        }

        private void Input_1_Click(object sender, EventArgs e)
        {
            InputNumber("1");
        }

        private void Input_2_Click(object sender, EventArgs e)
        {
            InputNumber("2");
        }

        private void Input_3_Click(object sender, EventArgs e)
        {
            InputNumber("3");
        }

        private void Input_4_Click(object sender, EventArgs e)
        {
            InputNumber("4");
        }

        private void Input_5_Click(object sender, EventArgs e)
        {
            InputNumber("5");
        }

        private void Input_6_Click(object sender, EventArgs e)
        {
            InputNumber("6");
        }

        private void Input_7_Click(object sender, EventArgs e)
        {
            InputNumber("7");
        }

        private void Input_8_Click(object sender, EventArgs e)
        {
            InputNumber("8");
        }

        private void Input_9_Click(object sender, EventArgs e)
        {
            InputNumber("9");
        }

        private void Input_0_Click(object sender, EventArgs e)
        {
            InputNumber("0");
        }


        void InputOP(string a)
        {
            if (UseKeyInput)
            {
                keyinputbox.Text += a;
            }
            else if (mode == 1 || mode == 2)
            {
                Input += a;
                mode = 0;
            }
            else
            {
                MessageBox.Show("您不可以在開頭、運算子或\"(\"後插入另一個運算子", "錯誤", 0, MessageBoxIcon.Error);
            }
        }

        private void Input_add_Click(object sender, EventArgs e)
        {
            InputOP(" + ");
        }

        private void Input_reduce_Click(object sender, EventArgs e)
        {
            InputOP(" - ");
        }

        private void Input_X_Click(object sender, EventArgs e)
        {
            InputOP(" * ");
        }

        private void Input_divide_Click(object sender, EventArgs e)
        {
            InputOP(" / ");
        }

        private void Input_pow_Click(object sender, EventArgs e)
        {
            InputOP(" ^ ");
        }

        private void Input_modulo_Click(object sender, EventArgs e)
        {
            InputOP(" % ");
        }


        private void Input_sign_Click(object sender, EventArgs e)
        {
            if (UseKeyInput)
            {
                if (keyinputbox.Text.Length == 0)
                {
                    keyinputbox.Text += "-";
                }
                else if (keyinputbox.Text[keyinputbox.Text.Length - 1] == '-')
                {
                    keyinputbox.Text = keyinputbox.Text.Remove(keyinputbox.Text.Length - 1);
                }
                else
                {
                    keyinputbox.Text += "-";
                }
            }
            else if (mode == 0)
            {
                if (Input.Length == 0)
                {
                    Input += "-";
                }
                else if (Input[Input.Length - 1] == '-')
                {
                    Input = Input.Remove(Input.Length - 1);
                }
                else
                {
                    Input += "-";
                }
            }
            else
            {
                MessageBox.Show("您只能在數字開頭調整正負", "錯誤", 0, MessageBoxIcon.Error);
            }
        }

        private void Input_leftbracket_Click(object sender, EventArgs e)
        {
            if (UseKeyInput)
            {
                keyinputbox.Text += " ( ";
            }
            else if  (mode == 0)
            {
                Input += " ( ";
            }
            else
            {
                MessageBox.Show("您不可以在數字中或\")\"後插入另一個\"(\"", "錯誤", 0, MessageBoxIcon.Error);
            }
        }

        private void Input_rightbracket_Click(object sender, EventArgs e)
        {
            if (UseKeyInput)
            {
                keyinputbox.Text += " ) ";
            }
            else if (mode == 1 || mode == 2)
            {
                Input += " ) ";
                mode = 2;
            }
            else
            {
                MessageBox.Show("您不可以在開頭、運算子或\"(\"後插入\")\"", "錯誤", 0, MessageBoxIcon.Error);
            }
        }

        private void Input_dot_Click(object sender, EventArgs e)
        {
            if (UseKeyInput)
            {
                keyinputbox.Text += ".";
            }
            else if (Input[Input.Length - 1] == ' ' || Input[Input.Length - 1] == '.')
            {
                MessageBox.Show("您不可以在數字開頭或\".\"後插入\".\"", "錯誤", 0, MessageBoxIcon.Error);
            }
            else
            {
                Input += ".";
            }
        }


        private void Input_clear_all_Click(object sender, EventArgs e)
        {
            if (UseKeyInput)
            {
                StoredSting = keyinputbox.Text;
                keyinputbox.Text = "";
            }
            else
            {
                StoredSting = Input;
                Input = string.Empty;
                mode = 0;
            }
        }

        private void Input_backspace_Click(object sender, EventArgs e)
        {
            if (UseKeyInput && keyinputbox.Text.Length>0)
            {
                keyinputbox.Text = keyinputbox.Text.Remove(keyinputbox.Text.Length-1);
                return;
            }
            if (Input.Length == 0) return;
            if(Input[Input.Length-1] == ' ')
            {
                Input = Input.Remove(Input.Length - 3);
                if (Input[Input.Length - 1] == ' ')
                {
                    if(Input[Input.Length - 2] == ')')
                    {
                        mode = 2;
                    }
                    else
                    {
                        mode = 0;
                    }
                }
                else
                {
                    mode = 1;
                }
            }
            else
            {
                Input = Input.Remove(Input.Length - 1);
                if(Input.Length == 0 || Input[Input.Length - 1] == ' ')
                {
                    mode = 0;
                }
            }
        }


        void InputMathf(string a)
        {
            if (UseKeyInput)
            {
                keyinputbox.Text += a;
            }
            else if (mode == 0)
            {
                Input += a;
            }
            else
            {
                MessageBox.Show("您不可以在數字中或\")\"後插入一個函數", "錯誤", 0, MessageBoxIcon.Error);
            }
        }

        private void Input_sin_Click(object sender, EventArgs e)
        {
            InputMathf("sin( ");
        }

        private void Input_cos_Click(object sender, EventArgs e)
        {
            InputMathf("cos( ");
        }

        private void Input_tan_Click(object sender, EventArgs e)
        {
            InputMathf("tan( ");
        }

        private void Input_Asin_Click(object sender, EventArgs e)
        {
            InputMathf("Asin( ");
        }

        private void Input_Acos_Click(object sender, EventArgs e)
        {
            InputMathf("Acos( ");
        }

        private void Input_Atan_Click(object sender, EventArgs e)
        {
            InputMathf("Atan( ");
        }

        private void Input_log_Click(object sender, EventArgs e)
        {
            m_InputLog.Enabled = true;
            if(m_InputLog.ShowDialog(this) == DialogResult.Yes)
            {
                if (UseKeyInput)
                {
                    keyinputbox.Text += "log" + m_InputLog.Output + "( ";
                }
                else
                {
                    InputMathf("log" + m_InputLog.Output + "( ");
                }
            }
            m_InputLog.Enabled = false;
        }

        private void Input_abs_Click(object sender, EventArgs e)
        {
            InputMathf("abs( ");
        }

        private void Input_auto_Click(object sender, EventArgs e)
        {
            if (UseKeyInput)
            {
                for (int i = Math.Abs(keyinputbox.Text.Split('(').Length - keyinputbox.Text.Split(')').Length); i > 0; i--)
                {
                    keyinputbox.Text += " ) ";
                }
            }
            else
            {
                for (int i = Math.Abs(Input.Split('(').Length - Input.Split(')').Length); i > 0; i--)
                {
                    Input += " ) ";
                }
                mode = 2;
            }
        }

        private void Input_reload_Click(object sender, EventArgs e)
        {
            if (UseKeyInput)
            {
                keyinputbox.Text = StoredSting;
            }
            else
            {
                Input = StoredSting;
                if (Input[Input.Length - 1] == ' ')
                {
                    if (Input[Input.Length - 2] == ')')
                    {
                        mode = 2;
                    }
                    else
                    {
                        mode = 0;
                    }
                }
                else
                {
                    mode = 1;
                }
            }

        }

        private void Input_xxx_Click(object sender, EventArgs e)
        {
            InputMathf("X!( ");
        }

        private void Input_sinh_Click(object sender, EventArgs e)
        {
            InputMathf("sinh( ");
        }

        private void Input_cosh_Click(object sender, EventArgs e)
        {
            InputMathf("cosh( ");
        }

        private void Input_tanh_Click(object sender, EventArgs e)
        {
            InputMathf("tanh( ");
        }

        private void Input_in_Click(object sender, EventArgs e)
        {
            InputMathf("In( ");
        }

        private void Input_reciprocal_Click(object sender, EventArgs e)
        {
            InputMathf("1/( ");
        }

        private void Input_keyinput_Click(object sender, EventArgs e)
        {
            if (UseKeyInput)
            {
                keyinputbox.Visible = false;
                keyinputbox.Enabled = false;
                Input = keyinputbox.Text;
                if (Input[Input.Length - 1] == ' ')
                {
                    if (Input[Input.Length - 2] == ')')
                    {
                        mode = 2;
                    }
                    else
                    {
                        mode = 0;
                    }
                }
                else
                {
                    mode = 1;
                }
                UseKeyInput = false;
                Input_keyinput.Text = "鍵盤輸入";
            }
            else
            {
                keyinputbox.Enabled = true;
                keyinputbox.Text = Input;
                keyinputbox.Visible = true;
                Input = "";
                mode = 0;
                UseKeyInput = true;
                Input_keyinput.Text = "完成輸入";
            }
        }

        private void Input_setconst_Click(object sender, EventArgs e)
        {
            m_setconst.Enabled = true;
            if (m_setconst.ShowDialog(this) == DialogResult.Yes)
            {
                Input += m_setconst.Output;
                mode = 2;
            }
            m_setconst.Enabled = false;
        }

        private void Input_const_Click(object sender, EventArgs e)
        {

        }

        private void SelectAngleMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectAngleMod.SelectedItem.ToString() == "Rad")
            {
                RadOrDeg = true;
            }
            else
            {
                RadOrDeg = false;
            }
        }

    }
}
