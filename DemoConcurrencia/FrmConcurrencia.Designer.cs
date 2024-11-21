namespace DemoConcurrencia
{
    partial class FrmConcurrencia
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
            BtnIniciarSecuencial = new Button();
            BtnIniciarHilo = new Button();
            BtnIniciarTarea = new Button();
            splitContainer1 = new SplitContainer();
            BtnCancelarHilo = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnIniciarSecuencial
            // 
            BtnIniciarSecuencial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarSecuencial.Location = new Point(41, 29);
            BtnIniciarSecuencial.Name = "BtnIniciarSecuencial";
            BtnIniciarSecuencial.Size = new Size(123, 45);
            BtnIniciarSecuencial.TabIndex = 0;
            BtnIniciarSecuencial.Text = "Iniciar Secuencial";
            BtnIniciarSecuencial.UseVisualStyleBackColor = true;
            BtnIniciarSecuencial.Click += BtnIniciarSecuencial_Click;
            // 
            // BtnIniciarHilo
            // 
            BtnIniciarHilo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarHilo.Location = new Point(41, 80);
            BtnIniciarHilo.Name = "BtnIniciarHilo";
            BtnIniciarHilo.Size = new Size(123, 45);
            BtnIniciarHilo.TabIndex = 1;
            BtnIniciarHilo.Text = "Iniciar Hilo";
            BtnIniciarHilo.UseVisualStyleBackColor = true;
            BtnIniciarHilo.Click += BtnIniciarHilo_Click;
            // 
            // BtnIniciarTarea
            // 
            BtnIniciarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarTarea.Location = new Point(41, 131);
            BtnIniciarTarea.Name = "BtnIniciarTarea";
            BtnIniciarTarea.Size = new Size(123, 45);
            BtnIniciarTarea.TabIndex = 2;
            BtnIniciarTarea.Text = "Iniciar Tarea";
            BtnIniciarTarea.UseVisualStyleBackColor = true;
            BtnIniciarTarea.Click += BtnIniciarTarea_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnCancelarHilo);
            splitContainer1.Panel1.Controls.Add(BtnIniciarTarea);
            splitContainer1.Panel1.Controls.Add(BtnIniciarHilo);
            splitContainer1.Panel1.Controls.Add(BtnIniciarSecuencial);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(621, 539);
            splitContainer1.SplitterDistance = 204;
            splitContainer1.TabIndex = 3;
            // 
            // BtnCancelarHilo
            // 
            BtnCancelarHilo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnCancelarHilo.Location = new Point(41, 224);
            BtnCancelarHilo.Name = "BtnCancelarHilo";
            BtnCancelarHilo.Size = new Size(123, 45);
            BtnCancelarHilo.TabIndex = 3;
            BtnCancelarHilo.Text = "Cancelar Proceso";
            BtnCancelarHilo.UseVisualStyleBackColor = true;
            BtnCancelarHilo.Click += BtnCancelarHilo_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(413, 539);
            TxtResultado.TabIndex = 0;
            // 
            // FrmConcurrencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 539);
            Controls.Add(splitContainer1);
            Name = "FrmConcurrencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demostracion de Concurrencia";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnIniciarSecuencial;
        private Button BtnIniciarHilo;
        private Button BtnIniciarTarea;
        private SplitContainer splitContainer1;
        private TextBox TxtResultado;
        private Button BtnCancelarHilo;
    }
}
