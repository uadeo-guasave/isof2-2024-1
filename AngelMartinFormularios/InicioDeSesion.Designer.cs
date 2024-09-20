namespace AngelMartinFormularios
{
    partial class InicioDeSesion
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
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(43, 45);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(43, 68);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(323, 27);
            txtUsuario.TabIndex = 1;
            // 
            // InicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 450);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InicioDeSesion";
            Text = "Bienvenido - Inicio de sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
    }
}
