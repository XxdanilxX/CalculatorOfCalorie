namespace CalculatorOfCalorie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            codeeloButton2 = new CodeeloUI.Controls.CodeeloButton();
            label8 = new Label();
            label7 = new Label();
            radioNoMan = new CodeeloUI.Controls.CodeeloToggleButton();
            radioMan = new CodeeloUI.Controls.CodeeloToggleButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textHeight = new TextBox();
            textWeight = new TextBox();
            textAge = new TextBox();
            tabPage2 = new TabPage();
            btnDelete = new CodeeloUI.Controls.CodeeloButton();
            btnAdd = new CodeeloUI.Controls.CodeeloButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            textCal = new TextBox();
            textName = new TextBox();
            tabPage3 = new TabPage();
            label9 = new Label();
            btnDel1 = new CodeeloUI.Controls.CodeeloButton();
            btnAdd1 = new CodeeloUI.Controls.CodeeloButton();
            codeeloButton1 = new CodeeloUI.Controls.CodeeloButton();
            ProgressBar1 = new CodeeloUI.Controls.CodeeloCircularProgressBar();
            textGram = new TextBox();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            listBox2 = new ListBox();
            tabPage5 = new TabPage();
            listBox3 = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.HotTrack = true;
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(847, 529);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(0, 192, 192);
            tabPage1.Controls.Add(codeeloButton2);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(radioNoMan);
            tabPage1.Controls.Add(radioMan);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textHeight);
            tabPage1.Controls.Add(textWeight);
            tabPage1.Controls.Add(textAge);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(839, 496);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Body Settings";
            // 
            // codeeloButton2
            // 
            codeeloButton2.AccessibleRole = null;
            codeeloButton2.Anchor = AnchorStyles.None;
            codeeloButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            codeeloButton2.BackColor = Color.Transparent;
            codeeloButton2.BorderColor_1 = Color.Transparent;
            codeeloButton2.BorderColor_2 = Color.Transparent;
            codeeloButton2.BorderRadius = 20;
            codeeloButton2.BorderSize = 3;
            codeeloButton2.CausesValidation = false;
            codeeloButton2.ColorFill_1 = Color.Gold;
            codeeloButton2.ColorFill_2 = Color.DodgerBlue;
            codeeloButton2.DialogResult = false;
            codeeloButton2.FlatAppearance.BorderSize = 0;
            codeeloButton2.FlatStyle = FlatStyle.Popup;
            codeeloButton2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            codeeloButton2.ForeColor = Color.WhiteSmoke;
            codeeloButton2.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            codeeloButton2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            codeeloButton2.Location = new Point(318, 357);
            codeeloButton2.Name = "codeeloButton2";
            codeeloButton2.OnClick_BorderColor_1 = Color.Transparent;
            codeeloButton2.OnClick_BorderColor_2 = Color.Transparent;
            codeeloButton2.OnClick_FillColor_1 = Color.DarkCyan;
            codeeloButton2.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            codeeloButton2.OnOver_BorderColor_1 = Color.Transparent;
            codeeloButton2.OnOver_BorderColor_2 = Color.Transparent;
            codeeloButton2.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            codeeloButton2.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            codeeloButton2.Size = new Size(196, 54);
            codeeloButton2.TabIndex = 13;
            codeeloButton2.TabStop = false;
            codeeloButton2.Text = "Підтвердити";
            codeeloButton2.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            codeeloButton2.UseGradient = true;
            codeeloButton2.UseGradientBorder = true;
            codeeloButton2.UseMnemonic = false;
            codeeloButton2.UseVisualStyleBackColor = false;
            codeeloButton2.Click += codeeloButton2_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(428, 329);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 12;
            label8.Text = "Жінка";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(414, 300);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 11;
            label7.Text = "Чоловік";
            // 
            // radioNoMan
            // 
            radioNoMan.Anchor = AnchorStyles.None;
            radioNoMan.AreaColor = Color.Red;
            radioNoMan.AreaColorChecked = Color.FromArgb(110, 220, 95);
            radioNoMan.BackColor = Color.Transparent;
            radioNoMan.DrawCircle = true;
            radioNoMan.Location = new Point(353, 329);
            radioNoMan.MinimumSize = new Size(45, 22);
            radioNoMan.Name = "radioNoMan";
            radioNoMan.Size = new Size(45, 22);
            radioNoMan.TabIndex = 10;
            radioNoMan.Tag = "";
            radioNoMan.ToggleColor = Color.FromArgb(245, 245, 245);
            radioNoMan.ToggleColorChecked = Color.FromArgb(245, 245, 245);
            radioNoMan.UseTransparentBackColor = false;
            radioNoMan.UseVisualStyleBackColor = false;
            // 
            // radioMan
            // 
            radioMan.Anchor = AnchorStyles.None;
            radioMan.AreaColor = Color.Red;
            radioMan.AreaColorChecked = Color.FromArgb(110, 220, 95);
            radioMan.BackColor = Color.Transparent;
            radioMan.DrawCircle = true;
            radioMan.Location = new Point(353, 300);
            radioMan.MinimumSize = new Size(45, 22);
            radioMan.Name = "radioMan";
            radioMan.Size = new Size(45, 22);
            radioMan.TabIndex = 9;
            radioMan.ToggleColor = Color.White;
            radioMan.ToggleColorChecked = Color.FromArgb(245, 245, 245);
            radioMan.UseCompatibleTextRendering = true;
            radioMan.UseTransparentBackColor = false;
            radioMan.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(353, 242);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 7;
            label3.Text = "Ріст";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(353, 187);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 6;
            label2.Text = "Вага";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(353, 129);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 5;
            label1.Text = "Вік";
            // 
            // textHeight
            // 
            textHeight.Anchor = AnchorStyles.None;
            textHeight.Location = new Point(353, 265);
            textHeight.Name = "textHeight";
            textHeight.Size = new Size(125, 27);
            textHeight.TabIndex = 4;
            // 
            // textWeight
            // 
            textWeight.Anchor = AnchorStyles.None;
            textWeight.Location = new Point(353, 210);
            textWeight.Name = "textWeight";
            textWeight.Size = new Size(125, 27);
            textWeight.TabIndex = 3;
            // 
            // textAge
            // 
            textAge.Anchor = AnchorStyles.None;
            textAge.Location = new Point(353, 152);
            textAge.Name = "textAge";
            textAge.Size = new Size(125, 27);
            textAge.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(0, 192, 192);
            tabPage2.Controls.Add(btnDelete);
            tabPage2.Controls.Add(btnAdd);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(listBox1);
            tabPage2.Controls.Add(textCal);
            tabPage2.Controls.Add(textName);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(839, 496);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Informations";
            // 
            // btnDelete
            // 
            btnDelete.AccessibleRole = null;
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BorderColor_1 = Color.Transparent;
            btnDelete.BorderColor_2 = Color.Transparent;
            btnDelete.BorderRadius = 8;
            btnDelete.BorderSize = 3;
            btnDelete.CausesValidation = false;
            btnDelete.ColorFill_1 = Color.OrangeRed;
            btnDelete.ColorFill_2 = Color.Magenta;
            btnDelete.DialogResult = false;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.WhiteSmoke;
            btnDelete.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnDelete.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnDelete.Location = new Point(629, 175);
            btnDelete.Name = "btnDelete";
            btnDelete.OnClick_BorderColor_1 = Color.Transparent;
            btnDelete.OnClick_BorderColor_2 = Color.Transparent;
            btnDelete.OnClick_FillColor_1 = Color.FromArgb(179, 184, 216);
            btnDelete.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            btnDelete.OnOver_BorderColor_1 = Color.Transparent;
            btnDelete.OnOver_BorderColor_2 = Color.Transparent;
            btnDelete.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            btnDelete.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnDelete.Size = new Size(174, 69);
            btnDelete.TabIndex = 10;
            btnDelete.TabStop = false;
            btnDelete.Text = "Видалити";
            btnDelete.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnDelete.UseGradient = true;
            btnDelete.UseGradientBorder = true;
            btnDelete.UseMnemonic = false;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.AccessibleRole = null;
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BorderColor_1 = Color.Transparent;
            btnAdd.BorderColor_2 = Color.Transparent;
            btnAdd.BorderRadius = 8;
            btnAdd.BorderSize = 3;
            btnAdd.CausesValidation = false;
            btnAdd.ColorFill_1 = Color.FromArgb(0, 192, 0);
            btnAdd.ColorFill_2 = Color.Yellow;
            btnAdd.DialogResult = false;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.WhiteSmoke;
            btnAdd.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnAdd.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnAdd.Location = new Point(438, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.OnClick_BorderColor_1 = Color.Transparent;
            btnAdd.OnClick_BorderColor_2 = Color.Transparent;
            btnAdd.OnClick_FillColor_1 = Color.FromArgb(179, 184, 216);
            btnAdd.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            btnAdd.OnOver_BorderColor_1 = Color.Transparent;
            btnAdd.OnOver_BorderColor_2 = Color.Transparent;
            btnAdd.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            btnAdd.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnAdd.Size = new Size(174, 69);
            btnAdd.TabIndex = 9;
            btnAdd.TabStop = false;
            btnAdd.Text = "Додати";
            btnAdd.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnAdd.UseGradient = true;
            btnAdd.UseGradientBorder = true;
            btnAdd.UseMnemonic = false;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(438, 88);
            label6.Name = "label6";
            label6.Size = new Size(165, 20);
            label6.TabIndex = 8;
            label6.Text = "Калорійність продукту";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(438, 13);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 7;
            label5.Text = "Назва продукту";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(24, 13);
            label4.Name = "label4";
            label4.Size = new Size(255, 20);
            label4.TabIndex = 6;
            label4.Text = "Список продуктів та їх калорійність";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.None;
            listBox1.BackColor = Color.Gainsboro;
            listBox1.ForeColor = SystemColors.Desktop;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(24, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(341, 444);
            listBox1.TabIndex = 5;
            // 
            // textCal
            // 
            textCal.Anchor = AnchorStyles.None;
            textCal.BackColor = Color.WhiteSmoke;
            textCal.Location = new Point(438, 111);
            textCal.Name = "textCal";
            textCal.Size = new Size(365, 27);
            textCal.TabIndex = 4;
            // 
            // textName
            // 
            textName.Anchor = AnchorStyles.None;
            textName.BackColor = Color.WhiteSmoke;
            textName.Location = new Point(438, 36);
            textName.Name = "textName";
            textName.Size = new Size(365, 27);
            textName.TabIndex = 3;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(0, 192, 192);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(btnDel1);
            tabPage3.Controls.Add(btnAdd1);
            tabPage3.Controls.Add(codeeloButton1);
            tabPage3.Controls.Add(ProgressBar1);
            tabPage3.Controls.Add(textGram);
            tabPage3.Controls.Add(tabControl2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(839, 496);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Calculator";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(489, 16);
            label9.Name = "label9";
            label9.Size = new Size(96, 20);
            label9.TabIndex = 10;
            label9.Text = "З'їдено грам";
            // 
            // btnDel1
            // 
            btnDel1.AccessibleRole = null;
            btnDel1.Anchor = AnchorStyles.None;
            btnDel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDel1.BackColor = Color.Transparent;
            btnDel1.BorderColor_1 = Color.Transparent;
            btnDel1.BorderColor_2 = Color.Transparent;
            btnDel1.BorderRadius = 20;
            btnDel1.BorderSize = 3;
            btnDel1.CausesValidation = false;
            btnDel1.ColorFill_1 = Color.Red;
            btnDel1.ColorFill_2 = Color.Fuchsia;
            btnDel1.DialogResult = false;
            btnDel1.FlatAppearance.BorderSize = 0;
            btnDel1.FlatStyle = FlatStyle.Flat;
            btnDel1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDel1.ForeColor = Color.WhiteSmoke;
            btnDel1.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnDel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnDel1.Location = new Point(621, 89);
            btnDel1.Name = "btnDel1";
            btnDel1.OnClick_BorderColor_1 = Color.Transparent;
            btnDel1.OnClick_BorderColor_2 = Color.Transparent;
            btnDel1.OnClick_FillColor_1 = Color.FromArgb(179, 184, 216);
            btnDel1.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            btnDel1.OnOver_BorderColor_1 = Color.Transparent;
            btnDel1.OnOver_BorderColor_2 = Color.Transparent;
            btnDel1.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            btnDel1.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnDel1.Size = new Size(112, 42);
            btnDel1.TabIndex = 9;
            btnDel1.TabStop = false;
            btnDel1.Text = "Видалити";
            btnDel1.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnDel1.UseGradient = true;
            btnDel1.UseGradientBorder = true;
            btnDel1.UseMnemonic = false;
            btnDel1.UseVisualStyleBackColor = false;
            btnDel1.Click += btnDel1_Click_1;
            // 
            // btnAdd1
            // 
            btnAdd1.AccessibleRole = null;
            btnAdd1.Anchor = AnchorStyles.None;
            btnAdd1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd1.BackColor = Color.Transparent;
            btnAdd1.BorderColor_1 = Color.Transparent;
            btnAdd1.BorderColor_2 = Color.Transparent;
            btnAdd1.BorderRadius = 20;
            btnAdd1.BorderSize = 3;
            btnAdd1.CausesValidation = false;
            btnAdd1.ColorFill_1 = Color.FromArgb(0, 192, 0);
            btnAdd1.ColorFill_2 = Color.Yellow;
            btnAdd1.DialogResult = false;
            btnAdd1.FlatAppearance.BorderSize = 0;
            btnAdd1.FlatStyle = FlatStyle.Flat;
            btnAdd1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd1.ForeColor = Color.WhiteSmoke;
            btnAdd1.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnAdd1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            btnAdd1.Location = new Point(489, 89);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.OnClick_BorderColor_1 = Color.Transparent;
            btnAdd1.OnClick_BorderColor_2 = Color.Transparent;
            btnAdd1.OnClick_FillColor_1 = Color.FromArgb(179, 184, 216);
            btnAdd1.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            btnAdd1.OnOver_BorderColor_1 = Color.Transparent;
            btnAdd1.OnOver_BorderColor_2 = Color.Transparent;
            btnAdd1.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            btnAdd1.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            btnAdd1.Size = new Size(112, 42);
            btnAdd1.TabIndex = 8;
            btnAdd1.TabStop = false;
            btnAdd1.Text = "Додати";
            btnAdd1.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            btnAdd1.UseGradient = true;
            btnAdd1.UseGradientBorder = true;
            btnAdd1.UseMnemonic = false;
            btnAdd1.UseVisualStyleBackColor = false;
            btnAdd1.Click += btnAdd1_Click_1;
            // 
            // codeeloButton1
            // 
            codeeloButton1.AccessibleRole = null;
            codeeloButton1.Anchor = AnchorStyles.None;
            codeeloButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            codeeloButton1.BackColor = Color.Transparent;
            codeeloButton1.BorderColor_1 = Color.Transparent;
            codeeloButton1.BorderColor_2 = Color.Transparent;
            codeeloButton1.BorderRadius = 20;
            codeeloButton1.BorderSize = 3;
            codeeloButton1.CausesValidation = false;
            codeeloButton1.ColorFill_1 = Color.Gold;
            codeeloButton1.ColorFill_2 = Color.Indigo;
            codeeloButton1.DialogResult = false;
            codeeloButton1.FlatAppearance.BorderSize = 0;
            codeeloButton1.FlatStyle = FlatStyle.Flat;
            codeeloButton1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            codeeloButton1.ForeColor = Color.WhiteSmoke;
            codeeloButton1.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            codeeloButton1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            codeeloButton1.Location = new Point(489, 409);
            codeeloButton1.Name = "codeeloButton1";
            codeeloButton1.OnClick_BorderColor_1 = Color.Transparent;
            codeeloButton1.OnClick_BorderColor_2 = Color.Transparent;
            codeeloButton1.OnClick_FillColor_1 = Color.FromArgb(179, 184, 216);
            codeeloButton1.OnClick_FillColor_2 = Color.FromArgb(199, 225, 229);
            codeeloButton1.OnOver_BorderColor_1 = Color.Transparent;
            codeeloButton1.OnOver_BorderColor_2 = Color.Transparent;
            codeeloButton1.OnOver_FillColor_1 = Color.FromArgb(159, 164, 196);
            codeeloButton1.OnOver_FillColor_2 = Color.FromArgb(179, 205, 209);
            codeeloButton1.Size = new Size(244, 75);
            codeeloButton1.TabIndex = 7;
            codeeloButton1.TabStop = false;
            codeeloButton1.Text = "Розрахувати";
            codeeloButton1.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            codeeloButton1.UseGradient = true;
            codeeloButton1.UseGradientBorder = true;
            codeeloButton1.UseMnemonic = false;
            codeeloButton1.UseVisualStyleBackColor = false;
            codeeloButton1.Click += codeeloButton1_Click;
            // 
            // ProgressBar1
            // 
            ProgressBar1.Anchor = AnchorStyles.None;
            ProgressBar1.BackColor = Color.Transparent;
            ProgressBar1.BarFirstColor = Color.Gold;
            ProgressBar1.BarSecondColor = Color.SpringGreen;
            ProgressBar1.BarShapeEnd = System.Drawing.Drawing2D.LineCap.Round;
            ProgressBar1.BarShapeStart = System.Drawing.Drawing2D.LineCap.Round;
            ProgressBar1.BarWidth = 14F;
            ProgressBar1.DisplayedTextType = CodeeloUI.Controls.CodeeloCircularProgressBar.TextMode.Percentage;
            ProgressBar1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ProgressBar1.ForeColor = SystemColors.ControlLightLight;
            ProgressBar1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            ProgressBar1.LineColor = Color.Gray;
            ProgressBar1.LineWidth = 10;
            ProgressBar1.Location = new Point(531, 241);
            ProgressBar1.MaxValue = 100;
            ProgressBar1.MinimumSize = new Size(100, 100);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(162, 162);
            ProgressBar1.TabIndex = 6;
            ProgressBar1.Text = "0%";
            ProgressBar1.UseWaitCursor = true;
            ProgressBar1.Value = 0;
            // 
            // textGram
            // 
            textGram.Anchor = AnchorStyles.None;
            textGram.Location = new Point(489, 35);
            textGram.Name = "textGram";
            textGram.Size = new Size(244, 27);
            textGram.TabIndex = 1;
            // 
            // tabControl2
            // 
            tabControl2.Anchor = AnchorStyles.None;
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Location = new Point(8, 6);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(372, 482);
            tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Gainsboro;
            tabPage4.Controls.Add(listBox2);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(364, 449);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Список продуктів (калорій на 100г)";
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Gainsboro;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(0, 6);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(361, 444);
            listBox2.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.Gainsboro;
            tabPage5.Controls.Add(listBox3);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(364, 449);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Ваші продукти";
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.Gainsboro;
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(0, 4);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(361, 444);
            listBox3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(847, 529);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Calculator Of Calorie";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textHeight;
        private TextBox textWeight;
        private TextBox textAge;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textCal;
        private TextBox textName;
        private TabPage tabPage3;
        private ListBox listBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private ListBox listBox2;
        private TabPage tabPage5;
        private ListBox listBox3;
        private TextBox textGram;
        private CodeeloUI.Controls.CodeeloButton codeeloButton1;
        private CodeeloUI.Controls.CodeeloCircularProgressBar ProgressBar1;
        private CodeeloUI.Controls.CodeeloToggleButton radioMan;
        private CodeeloUI.Controls.CodeeloToggleButton radioNoMan;
        private Label label8;
        private Label label7;
        private CodeeloUI.Controls.CodeeloButton codeeloButton2;
        private CodeeloUI.Controls.CodeeloButton btnDelete;
        private CodeeloUI.Controls.CodeeloButton btnAdd;
        private CodeeloUI.Controls.CodeeloButton btnDel1;
        private CodeeloUI.Controls.CodeeloButton btnAdd1;
        private Label label9;
    }
}