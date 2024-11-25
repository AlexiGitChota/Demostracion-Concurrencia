namespace DemoConcurrencia
{
    partial class FrmGestionImpresion
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
            splitContainer1 = new SplitContainer();
            label1 = new Label();
            BtnProcesarTrabajos = new Button();
            BtnAgregarTrabajo = new Button();
            TxtTrabajo = new TextBox();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(BtnProcesarTrabajos);
            splitContainer1.Panel1.Controls.Add(BtnAgregarTrabajo);
            splitContainer1.Panel1.Controls.Add(TxtTrabajo);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingresa un Trabajo para Imprimir:";
            // 
            // BtnProcesarTrabajos
            // 
            BtnProcesarTrabajos.Location = new Point(12, 113);
            BtnProcesarTrabajos.Name = "BtnProcesarTrabajos";
            BtnProcesarTrabajos.Size = new Size(222, 23);
            BtnProcesarTrabajos.TabIndex = 2;
            BtnProcesarTrabajos.Text = "Procesar Impresiones";
            BtnProcesarTrabajos.UseVisualStyleBackColor = true;
            BtnProcesarTrabajos.Click += BtnProcesarTrabajos_Click;
            // 
            // BtnAgregarTrabajo
            // 
            BtnAgregarTrabajo.Location = new Point(12, 84);
            BtnAgregarTrabajo.Name = "BtnAgregarTrabajo";
            BtnAgregarTrabajo.Size = new Size(222, 23);
            BtnAgregarTrabajo.TabIndex = 1;
            BtnAgregarTrabajo.Text = "Agregar Impresion";
            BtnAgregarTrabajo.UseVisualStyleBackColor = true;
            BtnAgregarTrabajo.Click += BtnAgregarTrabajo_Click;
            // 
            // TxtTrabajo
            // 
            TxtTrabajo.Location = new Point(12, 55);
            TxtTrabajo.Name = "TxtTrabajo";
            TxtTrabajo.Size = new Size(222, 23);
            TxtTrabajo.TabIndex = 0;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(530, 450);
            TxtResultado.TabIndex = 0;
            // 
            // FrmGestionImpresion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmGestionImpresion";
            Text = "FrmGestionImpresion";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button BtnProcesarTrabajos;
        private Button BtnAgregarTrabajo;
        private TextBox TxtTrabajo;
        private TextBox TxtResultado;
        private Label label1;
    }
}