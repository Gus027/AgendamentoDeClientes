namespace Cabelo_Software
{
    partial class FormInfClie
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
            label1 = new Label();
            name_cli = new Label();
            name_type = new Label();
            name_data = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            nome_hora = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(54, 18);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // name_cli
            // 
            name_cli.AutoSize = true;
            name_cli.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            name_cli.Location = new Point(63, 24);
            name_cli.Name = "name_cli";
            name_cli.Size = new Size(40, 17);
            name_cli.TabIndex = 1;
            name_cli.Text = "name";
            // 
            // name_type
            // 
            name_type.AutoSize = true;
            name_type.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            name_type.Location = new Point(115, 54);
            name_type.Name = "name_type";
            name_type.Size = new Size(40, 17);
            name_type.TabIndex = 3;
            name_type.Text = "name";
            // 
            // name_data
            // 
            name_data.AutoSize = true;
            name_data.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            name_data.Location = new Point(116, 84);
            name_data.Name = "name_data";
            name_data.Size = new Size(40, 17);
            name_data.TabIndex = 5;
            name_data.Text = "name";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(72, 140);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(148, 45);
            guna2Button1.TabIndex = 6;
            guna2Button1.Text = "Excluir Agendamento";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 53);
            label6.Name = "label6";
            label6.Size = new Size(103, 18);
            label6.TabIndex = 8;
            label6.Text = "Tipo do corte:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 83);
            label7.Name = "label7";
            label7.Size = new Size(107, 18);
            label7.TabIndex = 9;
            label7.Text = "Data do corte:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(185, 84);
            label2.Name = "label2";
            label2.Size = new Size(46, 18);
            label2.TabIndex = 10;
            label2.Text = "Hora:";
            // 
            // nome_hora
            // 
            nome_hora.AutoSize = true;
            nome_hora.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nome_hora.Location = new Point(225, 84);
            nome_hora.Name = "nome_hora";
            nome_hora.Size = new Size(40, 17);
            nome_hora.TabIndex = 11;
            nome_hora.Text = "name";
            // 
            // FormInfClie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 197);
            Controls.Add(nome_hora);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(guna2Button1);
            Controls.Add(name_data);
            Controls.Add(name_type);
            Controls.Add(name_cli);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInfClie";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informações do Agendamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label name_cli;
        private Label name_type;
        private Label name_data;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label6;
        private Label label7;
        private Label label2;
        private Label nome_hora;
    }
}