namespace Cabelo_Software
{
    partial class FormBarba
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            barb_box = new CheckBox();
            sobran_box = new CheckBox();
            pigCab_box = new CheckBox();
            pigBarb_box = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            nm_cliente = new Guna.UI2.WinForms.Guna2TextBox();
            agendarBarba = new Guna.UI2.WinForms.Guna2Button();
            hr_ag = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            hairCalendar = new Guna.UI2.WinForms.Guna2DateTimePicker();
            SuspendLayout();
            // 
            // barb_box
            // 
            barb_box.AutoSize = true;
            barb_box.Location = new Point(156, 255);
            barb_box.Name = "barb_box";
            barb_box.Size = new Size(56, 19);
            barb_box.TabIndex = 15;
            barb_box.Text = "Barba";
            barb_box.UseVisualStyleBackColor = true;
            // 
            // sobran_box
            // 
            sobran_box.AutoSize = true;
            sobran_box.Location = new Point(156, 208);
            sobran_box.Name = "sobran_box";
            sobran_box.Size = new Size(91, 19);
            sobran_box.TabIndex = 14;
            sobran_box.Text = "Sobrancelha";
            sobran_box.UseVisualStyleBackColor = true;
            // 
            // pigCab_box
            // 
            pigCab_box.AutoSize = true;
            pigCab_box.Location = new Point(26, 255);
            pigCab_box.Name = "pigCab_box";
            pigCab_box.Size = new Size(121, 19);
            pigCab_box.TabIndex = 13;
            pigCab_box.Text = "Pigmentar Cabelo";
            pigCab_box.UseVisualStyleBackColor = true;
            // 
            // pigBarb_box
            // 
            pigBarb_box.AutoSize = true;
            pigBarb_box.Location = new Point(26, 208);
            pigBarb_box.Name = "pigBarb_box";
            pigBarb_box.Size = new Size(114, 19);
            pigBarb_box.TabIndex = 12;
            pigBarb_box.Text = "Pigmentar Barba";
            pigBarb_box.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 179);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 11;
            label2.Text = "TIPO DE CORTE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 47);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 10;
            label1.Text = "Nome:";
            // 
            // nm_cliente
            // 
            nm_cliente.CustomizableEdges = customizableEdges1;
            nm_cliente.DefaultText = "";
            nm_cliente.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nm_cliente.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nm_cliente.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nm_cliente.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nm_cliente.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nm_cliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nm_cliente.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nm_cliente.Location = new Point(22, 65);
            nm_cliente.Name = "nm_cliente";
            nm_cliente.PasswordChar = '\0';
            nm_cliente.PlaceholderText = "Insira o Nome do Cliente";
            nm_cliente.SelectedText = "";
            nm_cliente.ShadowDecoration.CustomizableEdges = customizableEdges2;
            nm_cliente.Size = new Size(200, 28);
            nm_cliente.TabIndex = 9;
            // 
            // agendarBarba
            // 
            agendarBarba.CustomizableEdges = customizableEdges3;
            agendarBarba.DisabledState.BorderColor = Color.DarkGray;
            agendarBarba.DisabledState.CustomBorderColor = Color.DarkGray;
            agendarBarba.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            agendarBarba.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            agendarBarba.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            agendarBarba.ForeColor = Color.White;
            agendarBarba.Location = new Point(215, 293);
            agendarBarba.Name = "agendarBarba";
            agendarBarba.ShadowDecoration.CustomizableEdges = customizableEdges4;
            agendarBarba.Size = new Size(180, 45);
            agendarBarba.TabIndex = 17;
            agendarBarba.Text = "AGENDAR";
            agendarBarba.Click += agendarBarba_Click;
            // 
            // hr_ag
            // 
            hr_ag.CustomizableEdges = customizableEdges5;
            hr_ag.DefaultText = "";
            hr_ag.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            hr_ag.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            hr_ag.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            hr_ag.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            hr_ag.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            hr_ag.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hr_ag.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            hr_ag.Location = new Point(22, 127);
            hr_ag.Name = "hr_ag";
            hr_ag.PasswordChar = '\0';
            hr_ag.PlaceholderText = "Insira a hora do agendamento";
            hr_ag.SelectedText = "";
            hr_ag.ShadowDecoration.CustomizableEdges = customizableEdges6;
            hr_ag.Size = new Size(200, 28);
            hr_ag.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 109);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 19;
            label3.Text = "Hora:";
            // 
            // hairCalendar
            // 
            hairCalendar.Checked = true;
            hairCalendar.CustomizableEdges = customizableEdges7;
            hairCalendar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hairCalendar.Format = DateTimePickerFormat.Long;
            hairCalendar.Location = new Point(332, 65);
            hairCalendar.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            hairCalendar.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            hairCalendar.Name = "hairCalendar";
            hairCalendar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            hairCalendar.Size = new Size(200, 36);
            hairCalendar.TabIndex = 20;
            hairCalendar.Value = new DateTime(2023, 4, 22, 20, 19, 53, 745);
            // 
            // FormBarba
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 350);
            Controls.Add(hairCalendar);
            Controls.Add(label3);
            Controls.Add(hr_ag);
            Controls.Add(agendarBarba);
            Controls.Add(barb_box);
            Controls.Add(sobran_box);
            Controls.Add(pigCab_box);
            Controls.Add(pigBarb_box);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nm_cliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBarba";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barba";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox barb_box;
        private CheckBox sobran_box;
        private CheckBox pigCab_box;
        private CheckBox pigBarb_box;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox nm_cliente;
        private Guna.UI2.WinForms.Guna2Button agendarBarba;
        private Guna.UI2.WinForms.Guna2TextBox hr_ag;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker hairCalendar;
    }
}