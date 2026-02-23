
namespace computer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Input_2 = new System.Windows.Forms.Button();
            this.Input_5 = new System.Windows.Forms.Button();
            this.Input_4 = new System.Windows.Forms.Button();
            this.Input_8 = new System.Windows.Forms.Button();
            this.Input_7 = new System.Windows.Forms.Button();
            this.Input_9 = new System.Windows.Forms.Button();
            this.Input_6 = new System.Windows.Forms.Button();
            this.Input_3 = new System.Windows.Forms.Button();
            this.Input_reduce = new System.Windows.Forms.Button();
            this.Input_X = new System.Windows.Forms.Button();
            this.Input_divide = new System.Windows.Forms.Button();
            this.Input_add = new System.Windows.Forms.Button();
            this.Input_equal = new System.Windows.Forms.Button();
            this.Input_0 = new System.Windows.Forms.Button();
            this.Input_sign = new System.Windows.Forms.Button();
            this.Input_1 = new System.Windows.Forms.Button();
            this.Input_dot = new System.Windows.Forms.Button();
            this.Input_rightbracket = new System.Windows.Forms.Button();
            this.Input_leftbracket = new System.Windows.Forms.Button();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.keyinputbox = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.Label();
            this.Input_clear_all = new System.Windows.Forms.Button();
            this.Input_backspace = new System.Windows.Forms.Button();
            this.Input_pow = new System.Windows.Forms.Button();
            this.Input_modulo = new System.Windows.Forms.Button();
            this.Input_sin = new System.Windows.Forms.Button();
            this.Input_abs = new System.Windows.Forms.Button();
            this.Input_cos = new System.Windows.Forms.Button();
            this.Input_tan = new System.Windows.Forms.Button();
            this.Input_log = new System.Windows.Forms.Button();
            this.Input_Asin = new System.Windows.Forms.Button();
            this.Input_Acos = new System.Windows.Forms.Button();
            this.Input_Atan = new System.Windows.Forms.Button();
            this.Input_sinh = new System.Windows.Forms.Button();
            this.Input_cosh = new System.Windows.Forms.Button();
            this.Input_tanh = new System.Windows.Forms.Button();
            this.Input_in = new System.Windows.Forms.Button();
            this.Input_reciprocal = new System.Windows.Forms.Button();
            this.Input_auto = new System.Windows.Forms.Button();
            this.Input_setconst = new System.Windows.Forms.Button();
            this.Input_reload = new System.Windows.Forms.Button();
            this.Input_keyinput = new System.Windows.Forms.Button();
            this.Input_xxx = new System.Windows.Forms.Button();
            this.SelectAngleMod = new System.Windows.Forms.ComboBox();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.DisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += new System.EventHandler(this.UpdateDisplay);
            // 
            // Input_2
            // 
            this.Input_2.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_2.Location = new System.Drawing.Point(508, 266);
            this.Input_2.Name = "Input_2";
            this.Input_2.Size = new System.Drawing.Size(70, 35);
            this.Input_2.TabIndex = 1;
            this.Input_2.Text = "2";
            this.Input_2.UseVisualStyleBackColor = true;
            this.Input_2.Click += new System.EventHandler(this.Input_2_Click);
            // 
            // Input_5
            // 
            this.Input_5.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_5.Location = new System.Drawing.Point(508, 225);
            this.Input_5.Name = "Input_5";
            this.Input_5.Size = new System.Drawing.Size(70, 35);
            this.Input_5.TabIndex = 3;
            this.Input_5.Text = "5";
            this.Input_5.UseVisualStyleBackColor = true;
            this.Input_5.Click += new System.EventHandler(this.Input_5_Click);
            // 
            // Input_4
            // 
            this.Input_4.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_4.Location = new System.Drawing.Point(432, 225);
            this.Input_4.Name = "Input_4";
            this.Input_4.Size = new System.Drawing.Size(70, 35);
            this.Input_4.TabIndex = 2;
            this.Input_4.Text = "4";
            this.Input_4.UseVisualStyleBackColor = true;
            this.Input_4.Click += new System.EventHandler(this.Input_4_Click);
            // 
            // Input_8
            // 
            this.Input_8.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_8.Location = new System.Drawing.Point(508, 184);
            this.Input_8.Name = "Input_8";
            this.Input_8.Size = new System.Drawing.Size(70, 35);
            this.Input_8.TabIndex = 5;
            this.Input_8.Text = "8";
            this.Input_8.UseVisualStyleBackColor = true;
            this.Input_8.Click += new System.EventHandler(this.Input_8_Click);
            // 
            // Input_7
            // 
            this.Input_7.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_7.Location = new System.Drawing.Point(432, 184);
            this.Input_7.Name = "Input_7";
            this.Input_7.Size = new System.Drawing.Size(70, 35);
            this.Input_7.TabIndex = 4;
            this.Input_7.Text = "7";
            this.Input_7.UseVisualStyleBackColor = true;
            this.Input_7.Click += new System.EventHandler(this.Input_7_Click);
            // 
            // Input_9
            // 
            this.Input_9.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_9.Location = new System.Drawing.Point(584, 184);
            this.Input_9.Name = "Input_9";
            this.Input_9.Size = new System.Drawing.Size(70, 35);
            this.Input_9.TabIndex = 8;
            this.Input_9.Text = "9";
            this.Input_9.UseVisualStyleBackColor = true;
            this.Input_9.Click += new System.EventHandler(this.Input_9_Click);
            // 
            // Input_6
            // 
            this.Input_6.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_6.Location = new System.Drawing.Point(584, 225);
            this.Input_6.Name = "Input_6";
            this.Input_6.Size = new System.Drawing.Size(70, 35);
            this.Input_6.TabIndex = 7;
            this.Input_6.Text = "6";
            this.Input_6.UseVisualStyleBackColor = true;
            this.Input_6.Click += new System.EventHandler(this.Input_6_Click);
            // 
            // Input_3
            // 
            this.Input_3.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_3.Location = new System.Drawing.Point(584, 266);
            this.Input_3.Name = "Input_3";
            this.Input_3.Size = new System.Drawing.Size(70, 35);
            this.Input_3.TabIndex = 6;
            this.Input_3.Text = "3";
            this.Input_3.UseVisualStyleBackColor = true;
            this.Input_3.Click += new System.EventHandler(this.Input_3_Click);
            // 
            // Input_reduce
            // 
            this.Input_reduce.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_reduce.Location = new System.Drawing.Point(657, 184);
            this.Input_reduce.Name = "Input_reduce";
            this.Input_reduce.Size = new System.Drawing.Size(100, 35);
            this.Input_reduce.TabIndex = 11;
            this.Input_reduce.Text = "-";
            this.Input_reduce.UseVisualStyleBackColor = true;
            this.Input_reduce.Click += new System.EventHandler(this.Input_reduce_Click);
            // 
            // Input_X
            // 
            this.Input_X.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_X.Location = new System.Drawing.Point(657, 225);
            this.Input_X.Name = "Input_X";
            this.Input_X.Size = new System.Drawing.Size(100, 35);
            this.Input_X.TabIndex = 10;
            this.Input_X.Text = "*";
            this.Input_X.UseVisualStyleBackColor = true;
            this.Input_X.Click += new System.EventHandler(this.Input_X_Click);
            // 
            // Input_divide
            // 
            this.Input_divide.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_divide.Location = new System.Drawing.Point(657, 266);
            this.Input_divide.Name = "Input_divide";
            this.Input_divide.Size = new System.Drawing.Size(100, 35);
            this.Input_divide.TabIndex = 9;
            this.Input_divide.Text = "/";
            this.Input_divide.UseVisualStyleBackColor = true;
            this.Input_divide.Click += new System.EventHandler(this.Input_divide_Click);
            // 
            // Input_add
            // 
            this.Input_add.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_add.Location = new System.Drawing.Point(657, 143);
            this.Input_add.Name = "Input_add";
            this.Input_add.Size = new System.Drawing.Size(100, 35);
            this.Input_add.TabIndex = 12;
            this.Input_add.Text = "+";
            this.Input_add.UseVisualStyleBackColor = true;
            this.Input_add.Click += new System.EventHandler(this.Input_add_Click);
            // 
            // Input_equal
            // 
            this.Input_equal.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_equal.Location = new System.Drawing.Point(657, 308);
            this.Input_equal.Name = "Input_equal";
            this.Input_equal.Size = new System.Drawing.Size(100, 35);
            this.Input_equal.TabIndex = 13;
            this.Input_equal.Text = "=";
            this.Input_equal.UseVisualStyleBackColor = true;
            this.Input_equal.Click += new System.EventHandler(this.Input_equal_Click);
            // 
            // Input_0
            // 
            this.Input_0.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_0.Location = new System.Drawing.Point(356, 308);
            this.Input_0.Name = "Input_0";
            this.Input_0.Size = new System.Drawing.Size(222, 35);
            this.Input_0.TabIndex = 14;
            this.Input_0.Text = "0";
            this.Input_0.UseVisualStyleBackColor = true;
            this.Input_0.Click += new System.EventHandler(this.Input_0_Click);
            // 
            // Input_sign
            // 
            this.Input_sign.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_sign.Location = new System.Drawing.Point(432, 143);
            this.Input_sign.Name = "Input_sign";
            this.Input_sign.Size = new System.Drawing.Size(70, 35);
            this.Input_sign.TabIndex = 16;
            this.Input_sign.Text = "+/-";
            this.Input_sign.UseVisualStyleBackColor = true;
            this.Input_sign.Click += new System.EventHandler(this.Input_sign_Click);
            // 
            // Input_1
            // 
            this.Input_1.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_1.Location = new System.Drawing.Point(432, 266);
            this.Input_1.Name = "Input_1";
            this.Input_1.Size = new System.Drawing.Size(70, 35);
            this.Input_1.TabIndex = 18;
            this.Input_1.Text = "1";
            this.Input_1.UseVisualStyleBackColor = true;
            this.Input_1.Click += new System.EventHandler(this.Input_1_Click);
            // 
            // Input_dot
            // 
            this.Input_dot.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_dot.Location = new System.Drawing.Point(584, 308);
            this.Input_dot.Name = "Input_dot";
            this.Input_dot.Size = new System.Drawing.Size(70, 35);
            this.Input_dot.TabIndex = 19;
            this.Input_dot.Text = ".";
            this.Input_dot.UseVisualStyleBackColor = true;
            this.Input_dot.Click += new System.EventHandler(this.Input_dot_Click);
            // 
            // Input_rightbracket
            // 
            this.Input_rightbracket.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_rightbracket.Location = new System.Drawing.Point(584, 143);
            this.Input_rightbracket.Name = "Input_rightbracket";
            this.Input_rightbracket.Size = new System.Drawing.Size(70, 35);
            this.Input_rightbracket.TabIndex = 21;
            this.Input_rightbracket.Text = ")";
            this.Input_rightbracket.UseVisualStyleBackColor = true;
            this.Input_rightbracket.Click += new System.EventHandler(this.Input_rightbracket_Click);
            // 
            // Input_leftbracket
            // 
            this.Input_leftbracket.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_leftbracket.Location = new System.Drawing.Point(508, 143);
            this.Input_leftbracket.Name = "Input_leftbracket";
            this.Input_leftbracket.Size = new System.Drawing.Size(70, 35);
            this.Input_leftbracket.TabIndex = 20;
            this.Input_leftbracket.Text = "(";
            this.Input_leftbracket.UseVisualStyleBackColor = true;
            this.Input_leftbracket.Click += new System.EventHandler(this.Input_leftbracket_Click);
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.AutoScroll = true;
            this.DisplayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.DisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayPanel.Controls.Add(this.keyinputbox);
            this.DisplayPanel.Controls.Add(this.Display);
            this.DisplayPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DisplayPanel.Location = new System.Drawing.Point(11, 38);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(746, 82);
            this.DisplayPanel.TabIndex = 22;
            this.DisplayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayPanel_Paint);
            // 
            // keyinputbox
            // 
            this.keyinputbox.BackColor = System.Drawing.Color.White;
            this.keyinputbox.Enabled = false;
            this.keyinputbox.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.keyinputbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.keyinputbox.Location = new System.Drawing.Point(-1, 10);
            this.keyinputbox.Name = "keyinputbox";
            this.keyinputbox.Size = new System.Drawing.Size(740, 51);
            this.keyinputbox.TabIndex = 53;
            this.keyinputbox.Visible = false;
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Display.Location = new System.Drawing.Point(3, 10);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(0, 42);
            this.Display.TabIndex = 0;
            // 
            // Input_clear_all
            // 
            this.Input_clear_all.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_clear_all.Location = new System.Drawing.Point(356, 143);
            this.Input_clear_all.Name = "Input_clear_all";
            this.Input_clear_all.Size = new System.Drawing.Size(70, 35);
            this.Input_clear_all.TabIndex = 27;
            this.Input_clear_all.Text = "AC";
            this.Input_clear_all.UseVisualStyleBackColor = true;
            this.Input_clear_all.Click += new System.EventHandler(this.Input_clear_all_Click);
            // 
            // Input_backspace
            // 
            this.Input_backspace.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_backspace.Location = new System.Drawing.Point(356, 184);
            this.Input_backspace.Name = "Input_backspace";
            this.Input_backspace.Size = new System.Drawing.Size(70, 35);
            this.Input_backspace.TabIndex = 25;
            this.Input_backspace.Text = "C";
            this.Input_backspace.UseVisualStyleBackColor = true;
            this.Input_backspace.Click += new System.EventHandler(this.Input_backspace_Click);
            // 
            // Input_pow
            // 
            this.Input_pow.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_pow.Location = new System.Drawing.Point(356, 225);
            this.Input_pow.Name = "Input_pow";
            this.Input_pow.Size = new System.Drawing.Size(70, 35);
            this.Input_pow.TabIndex = 24;
            this.Input_pow.Text = "^";
            this.Input_pow.UseVisualStyleBackColor = true;
            this.Input_pow.Click += new System.EventHandler(this.Input_pow_Click);
            // 
            // Input_modulo
            // 
            this.Input_modulo.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_modulo.Location = new System.Drawing.Point(356, 266);
            this.Input_modulo.Name = "Input_modulo";
            this.Input_modulo.Size = new System.Drawing.Size(70, 35);
            this.Input_modulo.TabIndex = 23;
            this.Input_modulo.Text = "%";
            this.Input_modulo.UseVisualStyleBackColor = true;
            this.Input_modulo.Click += new System.EventHandler(this.Input_modulo_Click);
            // 
            // Input_sin
            // 
            this.Input_sin.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_sin.Location = new System.Drawing.Point(117, 266);
            this.Input_sin.Name = "Input_sin";
            this.Input_sin.Size = new System.Drawing.Size(70, 35);
            this.Input_sin.TabIndex = 32;
            this.Input_sin.Text = "sin";
            this.Input_sin.UseVisualStyleBackColor = true;
            this.Input_sin.Click += new System.EventHandler(this.Input_sin_Click);
            // 
            // Input_abs
            // 
            this.Input_abs.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_abs.Location = new System.Drawing.Point(193, 143);
            this.Input_abs.Name = "Input_abs";
            this.Input_abs.Size = new System.Drawing.Size(70, 35);
            this.Input_abs.TabIndex = 31;
            this.Input_abs.Text = "abs";
            this.Input_abs.UseVisualStyleBackColor = true;
            this.Input_abs.Click += new System.EventHandler(this.Input_abs_Click);
            // 
            // Input_cos
            // 
            this.Input_cos.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_cos.Location = new System.Drawing.Point(193, 265);
            this.Input_cos.Name = "Input_cos";
            this.Input_cos.Size = new System.Drawing.Size(70, 35);
            this.Input_cos.TabIndex = 30;
            this.Input_cos.Text = "cos";
            this.Input_cos.UseVisualStyleBackColor = true;
            this.Input_cos.Click += new System.EventHandler(this.Input_cos_Click);
            // 
            // Input_tan
            // 
            this.Input_tan.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_tan.Location = new System.Drawing.Point(269, 266);
            this.Input_tan.Name = "Input_tan";
            this.Input_tan.Size = new System.Drawing.Size(70, 35);
            this.Input_tan.TabIndex = 29;
            this.Input_tan.Text = "tan";
            this.Input_tan.UseVisualStyleBackColor = true;
            this.Input_tan.Click += new System.EventHandler(this.Input_tan_Click);
            // 
            // Input_log
            // 
            this.Input_log.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_log.Location = new System.Drawing.Point(269, 143);
            this.Input_log.Name = "Input_log";
            this.Input_log.Size = new System.Drawing.Size(70, 35);
            this.Input_log.TabIndex = 28;
            this.Input_log.Text = "log";
            this.Input_log.UseVisualStyleBackColor = true;
            this.Input_log.Click += new System.EventHandler(this.Input_log_Click);
            // 
            // Input_Asin
            // 
            this.Input_Asin.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_Asin.Location = new System.Drawing.Point(117, 307);
            this.Input_Asin.Name = "Input_Asin";
            this.Input_Asin.Size = new System.Drawing.Size(70, 35);
            this.Input_Asin.TabIndex = 41;
            this.Input_Asin.Text = "Asin";
            this.Input_Asin.UseVisualStyleBackColor = true;
            this.Input_Asin.Click += new System.EventHandler(this.Input_Asin_Click);
            // 
            // Input_Acos
            // 
            this.Input_Acos.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_Acos.Location = new System.Drawing.Point(193, 306);
            this.Input_Acos.Name = "Input_Acos";
            this.Input_Acos.Size = new System.Drawing.Size(70, 35);
            this.Input_Acos.TabIndex = 40;
            this.Input_Acos.Text = "Acos";
            this.Input_Acos.UseVisualStyleBackColor = true;
            this.Input_Acos.Click += new System.EventHandler(this.Input_Acos_Click);
            // 
            // Input_Atan
            // 
            this.Input_Atan.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_Atan.Location = new System.Drawing.Point(269, 307);
            this.Input_Atan.Name = "Input_Atan";
            this.Input_Atan.Size = new System.Drawing.Size(70, 35);
            this.Input_Atan.TabIndex = 39;
            this.Input_Atan.Text = "Atan";
            this.Input_Atan.UseVisualStyleBackColor = true;
            this.Input_Atan.Click += new System.EventHandler(this.Input_Atan_Click);
            // 
            // Input_sinh
            // 
            this.Input_sinh.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_sinh.Location = new System.Drawing.Point(117, 225);
            this.Input_sinh.Name = "Input_sinh";
            this.Input_sinh.Size = new System.Drawing.Size(70, 35);
            this.Input_sinh.TabIndex = 47;
            this.Input_sinh.Text = "sinh";
            this.Input_sinh.UseVisualStyleBackColor = true;
            this.Input_sinh.Click += new System.EventHandler(this.Input_sinh_Click);
            // 
            // Input_cosh
            // 
            this.Input_cosh.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_cosh.Location = new System.Drawing.Point(193, 224);
            this.Input_cosh.Name = "Input_cosh";
            this.Input_cosh.Size = new System.Drawing.Size(70, 35);
            this.Input_cosh.TabIndex = 46;
            this.Input_cosh.Text = "cosh";
            this.Input_cosh.UseVisualStyleBackColor = true;
            this.Input_cosh.Click += new System.EventHandler(this.Input_cosh_Click);
            // 
            // Input_tanh
            // 
            this.Input_tanh.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_tanh.Location = new System.Drawing.Point(269, 225);
            this.Input_tanh.Name = "Input_tanh";
            this.Input_tanh.Size = new System.Drawing.Size(70, 35);
            this.Input_tanh.TabIndex = 45;
            this.Input_tanh.Text = "tanh";
            this.Input_tanh.UseVisualStyleBackColor = true;
            this.Input_tanh.Click += new System.EventHandler(this.Input_tanh_Click);
            // 
            // Input_in
            // 
            this.Input_in.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_in.Location = new System.Drawing.Point(117, 184);
            this.Input_in.Name = "Input_in";
            this.Input_in.Size = new System.Drawing.Size(70, 35);
            this.Input_in.TabIndex = 44;
            this.Input_in.Text = "In";
            this.Input_in.UseVisualStyleBackColor = true;
            this.Input_in.Click += new System.EventHandler(this.Input_in_Click);
            // 
            // Input_reciprocal
            // 
            this.Input_reciprocal.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_reciprocal.Location = new System.Drawing.Point(193, 183);
            this.Input_reciprocal.Name = "Input_reciprocal";
            this.Input_reciprocal.Size = new System.Drawing.Size(70, 35);
            this.Input_reciprocal.TabIndex = 43;
            this.Input_reciprocal.Text = "1/x";
            this.Input_reciprocal.UseVisualStyleBackColor = true;
            this.Input_reciprocal.Click += new System.EventHandler(this.Input_reciprocal_Click);
            // 
            // Input_auto
            // 
            this.Input_auto.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_auto.Location = new System.Drawing.Point(269, 184);
            this.Input_auto.Name = "Input_auto";
            this.Input_auto.Size = new System.Drawing.Size(70, 35);
            this.Input_auto.TabIndex = 42;
            this.Input_auto.Text = ")))";
            this.Input_auto.UseVisualStyleBackColor = true;
            this.Input_auto.Click += new System.EventHandler(this.Input_auto_Click);
            // 
            // Input_setconst
            // 
            this.Input_setconst.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_setconst.Location = new System.Drawing.Point(11, 224);
            this.Input_setconst.Name = "Input_setconst";
            this.Input_setconst.Size = new System.Drawing.Size(100, 76);
            this.Input_setconst.TabIndex = 48;
            this.Input_setconst.Text = "設定/插入常數";
            this.Input_setconst.UseVisualStyleBackColor = true;
            this.Input_setconst.Click += new System.EventHandler(this.Input_setconst_Click);
            // 
            // Input_reload
            // 
            this.Input_reload.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_reload.Location = new System.Drawing.Point(11, 183);
            this.Input_reload.Name = "Input_reload";
            this.Input_reload.Size = new System.Drawing.Size(100, 35);
            this.Input_reload.TabIndex = 49;
            this.Input_reload.Text = "上次刪除";
            this.Input_reload.UseVisualStyleBackColor = true;
            this.Input_reload.Click += new System.EventHandler(this.Input_reload_Click);
            // 
            // Input_keyinput
            // 
            this.Input_keyinput.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_keyinput.Location = new System.Drawing.Point(11, 143);
            this.Input_keyinput.Name = "Input_keyinput";
            this.Input_keyinput.Size = new System.Drawing.Size(100, 35);
            this.Input_keyinput.TabIndex = 51;
            this.Input_keyinput.Text = "鍵盤輸入";
            this.Input_keyinput.UseVisualStyleBackColor = true;
            this.Input_keyinput.Click += new System.EventHandler(this.Input_keyinput_Click);
            // 
            // Input_xxx
            // 
            this.Input_xxx.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Input_xxx.Location = new System.Drawing.Point(117, 142);
            this.Input_xxx.Name = "Input_xxx";
            this.Input_xxx.Size = new System.Drawing.Size(70, 35);
            this.Input_xxx.TabIndex = 52;
            this.Input_xxx.Text = "X!";
            this.Input_xxx.UseVisualStyleBackColor = true;
            this.Input_xxx.Click += new System.EventHandler(this.Input_xxx_Click);
            // 
            // SelectAngleMod
            // 
            this.SelectAngleMod.AccessibleDescription = "0";
            this.SelectAngleMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectAngleMod.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SelectAngleMod.Items.AddRange(new object[] {
            "Rad",
            "Deg"});
            this.SelectAngleMod.Location = new System.Drawing.Point(11, 311);
            this.SelectAngleMod.Name = "SelectAngleMod";
            this.SelectAngleMod.Size = new System.Drawing.Size(100, 28);
            this.SelectAngleMod.TabIndex = 53;
            this.SelectAngleMod.SelectedIndexChanged += new System.EventHandler(this.SelectAngleMod_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 372);
            this.Controls.Add(this.SelectAngleMod);
            this.Controls.Add(this.Input_xxx);
            this.Controls.Add(this.Input_keyinput);
            this.Controls.Add(this.Input_reload);
            this.Controls.Add(this.Input_setconst);
            this.Controls.Add(this.Input_sinh);
            this.Controls.Add(this.Input_cosh);
            this.Controls.Add(this.Input_tanh);
            this.Controls.Add(this.Input_in);
            this.Controls.Add(this.Input_reciprocal);
            this.Controls.Add(this.Input_auto);
            this.Controls.Add(this.Input_Asin);
            this.Controls.Add(this.Input_Acos);
            this.Controls.Add(this.Input_Atan);
            this.Controls.Add(this.Input_sin);
            this.Controls.Add(this.Input_abs);
            this.Controls.Add(this.Input_cos);
            this.Controls.Add(this.Input_tan);
            this.Controls.Add(this.Input_log);
            this.Controls.Add(this.Input_clear_all);
            this.Controls.Add(this.Input_backspace);
            this.Controls.Add(this.Input_pow);
            this.Controls.Add(this.Input_modulo);
            this.Controls.Add(this.DisplayPanel);
            this.Controls.Add(this.Input_rightbracket);
            this.Controls.Add(this.Input_leftbracket);
            this.Controls.Add(this.Input_dot);
            this.Controls.Add(this.Input_1);
            this.Controls.Add(this.Input_sign);
            this.Controls.Add(this.Input_0);
            this.Controls.Add(this.Input_equal);
            this.Controls.Add(this.Input_add);
            this.Controls.Add(this.Input_reduce);
            this.Controls.Add(this.Input_X);
            this.Controls.Add(this.Input_divide);
            this.Controls.Add(this.Input_9);
            this.Controls.Add(this.Input_6);
            this.Controls.Add(this.Input_3);
            this.Controls.Add(this.Input_8);
            this.Controls.Add(this.Input_7);
            this.Controls.Add(this.Input_5);
            this.Controls.Add(this.Input_4);
            this.Controls.Add(this.Input_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "多則運算計算機";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DisplayPanel.ResumeLayout(false);
            this.DisplayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Input_2;
        private System.Windows.Forms.Button Input_5;
        private System.Windows.Forms.Button Input_4;
        private System.Windows.Forms.Button Input_8;
        private System.Windows.Forms.Button Input_7;
        private System.Windows.Forms.Button Input_9;
        private System.Windows.Forms.Button Input_6;
        private System.Windows.Forms.Button Input_3;
        private System.Windows.Forms.Button Input_reduce;
        private System.Windows.Forms.Button Input_X;
        private System.Windows.Forms.Button Input_divide;
        private System.Windows.Forms.Button Input_add;
        private System.Windows.Forms.Button Input_equal;
        private System.Windows.Forms.Button Input_0;
        private System.Windows.Forms.Button Input_sign;
        private System.Windows.Forms.Button Input_1;
        private System.Windows.Forms.Button Input_dot;
        private System.Windows.Forms.Button Input_rightbracket;
        private System.Windows.Forms.Button Input_leftbracket;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Button Input_clear_all;
        private System.Windows.Forms.Button Input_backspace;
        private System.Windows.Forms.Button Input_pow;
        private System.Windows.Forms.Button Input_modulo;
        private System.Windows.Forms.Button Input_sin;
        private System.Windows.Forms.Button Input_abs;
        private System.Windows.Forms.Button Input_cos;
        private System.Windows.Forms.Button Input_tan;
        private System.Windows.Forms.Button Input_log;
        private System.Windows.Forms.Button Input_Asin;
        private System.Windows.Forms.Button Input_Acos;
        private System.Windows.Forms.Button Input_Atan;
        private System.Windows.Forms.Button Input_sinh;
        private System.Windows.Forms.Button Input_cosh;
        private System.Windows.Forms.Button Input_tanh;
        private System.Windows.Forms.Button Input_in;
        private System.Windows.Forms.Button Input_reciprocal;
        private System.Windows.Forms.Button Input_auto;
        private System.Windows.Forms.Button Input_setconst;
        private System.Windows.Forms.Button Input_reload;
        private System.Windows.Forms.Button Input_keyinput;
        private System.Windows.Forms.Button Input_xxx;
        private System.Windows.Forms.TextBox keyinputbox;
        private System.Windows.Forms.ComboBox SelectAngleMod;
    }
}

