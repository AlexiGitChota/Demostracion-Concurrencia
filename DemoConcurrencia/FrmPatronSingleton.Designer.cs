namespace DemoConcurrencia
{
    partial class FrmPatronSingleton
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
            BtnAsignar = new Button();
            BtnRecuperar = new Button();
            TxtCadenaConexion = new TextBox();
            label1 = new Label();
            LblCadenaConexionRecuperada = new Label();
            SuspendLayout();
            // 
            // BtnAsignar
            // 
            BtnAsignar.Location = new Point(12, 67);
            BtnAsignar.Name = "BtnAsignar";
            BtnAsignar.Size = new Size(103, 39);
            BtnAsignar.TabIndex = 0;
            BtnAsignar.Text = "Asignar cadena de conexión";
            BtnAsignar.UseVisualStyleBackColor = true;
            BtnAsignar.Click += BtnAsignar_Click;
            // 
            // BtnRecuperar
            // 
            BtnRecuperar.Location = new Point(12, 112);
            BtnRecuperar.Name = "BtnRecuperar";
            BtnRecuperar.Size = new Size(103, 39);
            BtnRecuperar.TabIndex = 1;
            BtnRecuperar.Text = "Obtener cadena de conexión";
            BtnRecuperar.UseVisualStyleBackColor = true;
            BtnRecuperar.Click += BtnRecuperar_Click;
            // 
            // TxtCadenaConexion
            // 
            TxtCadenaConexion.Location = new Point(12, 38);
            TxtCadenaConexion.Name = "TxtCadenaConexion";
            TxtCadenaConexion.Size = new Size(485, 23);
            TxtCadenaConexion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 3;
            label1.Text = "Cadena de Conexión:";
            // 
            // LblCadenaConexionRecuperada
            // 
            LblCadenaConexionRecuperada.AutoSize = true;
            LblCadenaConexionRecuperada.Location = new Point(121, 124);
            LblCadenaConexionRecuperada.Name = "LblCadenaConexionRecuperada";
            LblCadenaConexionRecuperada.Size = new Size(0, 15);
            LblCadenaConexionRecuperada.TabIndex = 4;
            // 
            // FrmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 168);
            Controls.Add(LblCadenaConexionRecuperada);
            Controls.Add(label1);
            Controls.Add(TxtCadenaConexion);
            Controls.Add(BtnRecuperar);
            Controls.Add(BtnAsignar);
            Name = "FrmPatronSingleton";
            Text = "Demostración de Patrón Singleton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAsignar;
        private Button BtnRecuperar;
        private TextBox TxtCadenaConexion;
        private Label label1;
        private Label LblCadenaConexionRecuperada;
    }
}