namespace Cabelo_Software
{
    partial class FormCabelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label2 = new Label();
            americanoBox1 = new CheckBox();
            desfarçadoBox2 = new CheckBox();
            infantilBox3 = new CheckBox();
            platinaldoBox4 = new CheckBox();
            navalhadoBox5 = new CheckBox();
            outroBox6 = new CheckBox();
            agendarCabelo = new Guna.UI2.WinForms.Guna2Button();
            guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            SuspendLayout();
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(21, 41);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "Insira o Nome do Cliente";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(200, 28);
            guna2TextBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 90);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "TIPO DE CORTE:";
            // 
            // americanoBox1
            // 
            americanoBox1.AutoSize = true;
            americanoBox1.Location = new Point(21, 126);
            americanoBox1.Name = "americanoBox1";
            americanoBox1.Size = new Size(84, 19);
            americanoBox1.TabIndex = 3;
            americanoBox1.Text = "Americano";
            americanoBox1.UseVisualStyleBackColor = true;
            // 
            // desfarçadoBox2
            // 
            desfarçadoBox2.AutoSize = true;
            desfarçadoBox2.Location = new Point(21, 173);
            desfarçadoBox2.Name = "desfarçadoBox2";
            desfarçadoBox2.Size = new Size(85, 19);
            desfarçadoBox2.TabIndex = 4;
            desfarçadoBox2.Text = "Desfarçado";
            desfarçadoBox2.UseVisualStyleBackColor = true;
            // 
            // infantilBox3
            // 
            infantilBox3.AutoSize = true;
            infantilBox3.Location = new Point(126, 126);
            infantilBox3.Name = "infantilBox3";
            infantilBox3.Size = new Size(95, 19);
            infantilBox3.TabIndex = 5;
            infantilBox3.Text = "Corte Infantil";
            infantilBox3.UseVisualStyleBackColor = true;
            // 
            // platinaldoBox4
            // 
            platinaldoBox4.AutoSize = true;
            platinaldoBox4.Location = new Point(126, 173);
            platinaldoBox4.Name = "platinaldoBox4";
            platinaldoBox4.Size = new Size(76, 19);
            platinaldoBox4.TabIndex = 6;
            platinaldoBox4.Text = "Platinado";
            platinaldoBox4.UseVisualStyleBackColor = true;
            // 
            // navalhadoBox5
            // 
            navalhadoBox5.AutoSize = true;
            navalhadoBox5.Location = new Point(21, 217);
            navalhadoBox5.Name = "navalhadoBox5";
            navalhadoBox5.Size = new Size(83, 19);
            navalhadoBox5.TabIndex = 7;
            navalhadoBox5.Text = "Navalhado";
            navalhadoBox5.UseVisualStyleBackColor = true;
            // 
            // outroBox6
            // 
            outroBox6.AutoSize = true;
            outroBox6.Location = new Point(126, 217);
            outroBox6.Name = "outroBox6";
            outroBox6.Size = new Size(57, 19);
            outroBox6.TabIndex = 8;
            outroBox6.Text = "Outro";
            outroBox6.UseVisualStyleBackColor = true;
            // 
            // agendarCabelo
            // 
            agendarCabelo.CustomizableEdges = customizableEdges3;
            agendarCabelo.DisabledState.BorderColor = Color.DarkGray;
            agendarCabelo.DisabledState.CustomBorderColor = Color.DarkGray;
            agendarCabelo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            agendarCabelo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            agendarCabelo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            agendarCabelo.ForeColor = Color.White;
            agendarCabelo.Location = new Point(375, 268);
            agendarCabelo.Name = "agendarCabelo";
            agendarCabelo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            agendarCabelo.Size = new Size(180, 45);
            agendarCabelo.TabIndex = 9;
            agendarCabelo.Text = "AGENDAR";
            agendarCabelo.Click += agendarCabelo_Click;
            // 
            // guna2DateTimePicker1
            // 
            guna2DateTimePicker1.Checked = true;
            guna2DateTimePicker1.CustomizableEdges = customizableEdges5;
            guna2DateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DateTimePicker1.Format = DateTimePickerFormat.Long;
            guna2DateTimePicker1.Location = new Point(328, 41);
            guna2DateTimePicker1.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2DateTimePicker1.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2DateTimePicker1.Size = new Size(227, 36);
            guna2DateTimePicker1.TabIndex = 12;
            guna2DateTimePicker1.Value = new DateTime(2023, 4, 21, 16, 27, 32, 589);
            // 
            // FormCabelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 335);
            Controls.Add(guna2DateTimePicker1);
            Controls.Add(agendarCabelo);
            Controls.Add(outroBox6);
            Controls.Add(navalhadoBox5);
            Controls.Add(platinaldoBox4);
            Controls.Add(infantilBox3);
            Controls.Add(desfarçadoBox2);
            Controls.Add(americanoBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guna2TextBox1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormCabelo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cabelo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Label label1;
        private Label label2;
        private CheckBox americanoBox1;
        private CheckBox desfarçadoBox2;
        private CheckBox infantilBox3;
        private CheckBox platinaldoBox4;
        private CheckBox navalhadoBox5;
        private CheckBox outroBox6;
        private Guna.UI2.WinForms.Guna2Button agendarCabelo;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}