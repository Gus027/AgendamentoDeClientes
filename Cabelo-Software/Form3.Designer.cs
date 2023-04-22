namespace Cabelo_Software
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            barbaImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            CabeloImageButton = new Guna.UI2.WinForms.Guna2ImageButton();
            label1 = new Label();
            label2 = new Label();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            SuspendLayout();
            // 
            // barbaImageButton1
            // 
            barbaImageButton1.CheckedState.ImageSize = new Size(64, 64);
            barbaImageButton1.HoverState.ImageSize = new Size(64, 64);
            barbaImageButton1.Image = (Image)resources.GetObject("barbaImageButton1.Image");
            barbaImageButton1.ImageOffset = new Point(0, 0);
            barbaImageButton1.ImageRotate = 0F;
            barbaImageButton1.Location = new Point(324, 170);
            barbaImageButton1.Name = "barbaImageButton1";
            barbaImageButton1.PressedState.ImageSize = new Size(64, 64);
            barbaImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            barbaImageButton1.Size = new Size(64, 54);
            barbaImageButton1.TabIndex = 1;
            barbaImageButton1.Click += barbaImageButton1_Click;
            // 
            // CabeloImageButton
            // 
            CabeloImageButton.CheckedState.ImageSize = new Size(64, 64);
            CabeloImageButton.HoverState.ImageSize = new Size(64, 64);
            CabeloImageButton.Image = (Image)resources.GetObject("CabeloImageButton.Image");
            CabeloImageButton.ImageOffset = new Point(0, 0);
            CabeloImageButton.ImageRotate = 0F;
            CabeloImageButton.Location = new Point(131, 159);
            CabeloImageButton.Name = "CabeloImageButton";
            CabeloImageButton.PressedState.ImageSize = new Size(64, 64);
            CabeloImageButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            CabeloImageButton.Size = new Size(73, 65);
            CabeloImageButton.TabIndex = 2;
            CabeloImageButton.Click += CabeloImageButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(335, 129);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "BARBA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(144, 129);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "CABELO";
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.Location = new Point(19, 21);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2ImageButton1.Size = new Size(64, 54);
            guna2ImageButton1.TabIndex = 5;
            guna2ImageButton1.Click += guna2ImageButton1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(523, 354);
            Controls.Add(guna2ImageButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CabeloImageButton);
            Controls.Add(barbaImageButton1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton barbaImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton CabeloImageButton;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}