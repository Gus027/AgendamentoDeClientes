namespace Cabelo_Software
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            pass_text = new Guna.UI2.WinForms.Guna2TextBox();
            user_text = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            guna2Button1.Location = new Point(12, 274);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(180, 46);
            guna2Button1.TabIndex = 0;
            guna2Button1.Text = "Confirmar";
            guna2Button1.Click += guna2Button1_Click_1;
            // 
            // buttonCancel
            // 
            buttonCancel.CustomizableEdges = customizableEdges3;
            buttonCancel.DisabledState.BorderColor = Color.DarkGray;
            buttonCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(211, 274);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            buttonCancel.Size = new Size(180, 46);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancelar";
            buttonCancel.Click += buttonCancel_Click;
            // 
            // pass_text
            // 
            pass_text.CustomizableEdges = customizableEdges5;
            pass_text.DefaultText = "";
            pass_text.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            pass_text.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            pass_text.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            pass_text.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            pass_text.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            pass_text.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pass_text.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            pass_text.IconLeft = (Image)resources.GetObject("pass_text.IconLeft");
            pass_text.Location = new Point(30, 211);
            pass_text.Name = "pass_text";
            pass_text.PasswordChar = '*';
            pass_text.PlaceholderText = "";
            pass_text.SelectedText = "";
            pass_text.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pass_text.Size = new Size(337, 36);
            pass_text.TabIndex = 2;
            // 
            // user_text
            // 
            user_text.CustomizableEdges = customizableEdges7;
            user_text.DefaultText = "";
            user_text.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            user_text.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            user_text.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            user_text.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            user_text.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            user_text.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            user_text.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            user_text.IconLeft = (Image)resources.GetObject("user_text.IconLeft");
            user_text.Location = new Point(30, 155);
            user_text.Name = "user_text";
            user_text.PasswordChar = '\0';
            user_text.PlaceholderText = "";
            user_text.SelectedText = "";
            user_text.ShadowDecoration.CustomizableEdges = customizableEdges8;
            user_text.Size = new Size(337, 36);
            user_text.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 137);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 194);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(163, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 74);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 368);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(user_text);
            Controls.Add(pass_text);
            Controls.Add(buttonCancel);
            Controls.Add(guna2Button1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loguin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private Guna.UI2.WinForms.Guna2TextBox pass_text;
        private Guna.UI2.WinForms.Guna2TextBox user_text;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}