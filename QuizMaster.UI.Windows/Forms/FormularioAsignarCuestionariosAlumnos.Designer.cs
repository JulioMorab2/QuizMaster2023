namespace FormulariosQuizMaster
{
    partial class FormularioAsignarCuestionariosAlumnos
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
            this.checkedListBoxListaAlumnos = new System.Windows.Forms.CheckedListBox();
            this.labelParaSeleccionAlumnos = new System.Windows.Forms.Label();
            this.buttonParaAsignarYEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxListaAlumnos
            // 
            this.checkedListBoxListaAlumnos.FormattingEnabled = true;
            this.checkedListBoxListaAlumnos.Location = new System.Drawing.Point(59, 67);
            this.checkedListBoxListaAlumnos.Name = "checkedListBoxListaAlumnos";
            this.checkedListBoxListaAlumnos.Size = new System.Drawing.Size(575, 310);
            this.checkedListBoxListaAlumnos.TabIndex = 0;
            this.checkedListBoxListaAlumnos.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // labelParaSeleccionAlumnos
            // 
            this.labelParaSeleccionAlumnos.AutoSize = true;
            this.labelParaSeleccionAlumnos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParaSeleccionAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelParaSeleccionAlumnos.Location = new System.Drawing.Point(56, 24);
            this.labelParaSeleccionAlumnos.Name = "labelParaSeleccionAlumnos";
            this.labelParaSeleccionAlumnos.Size = new System.Drawing.Size(273, 17);
            this.labelParaSeleccionAlumnos.TabIndex = 1;
            this.labelParaSeleccionAlumnos.Text = "Seleccione los alumnos del cuestionario:";
            this.labelParaSeleccionAlumnos.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonParaAsignarYEnviar
            // 
            this.buttonParaAsignarYEnviar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonParaAsignarYEnviar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonParaAsignarYEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonParaAsignarYEnviar.Location = new System.Drawing.Point(474, 397);
            this.buttonParaAsignarYEnviar.Name = "buttonParaAsignarYEnviar";
            this.buttonParaAsignarYEnviar.Size = new System.Drawing.Size(160, 41);
            this.buttonParaAsignarYEnviar.TabIndex = 2;
            this.buttonParaAsignarYEnviar.Text = "Asignar y Enviar";
            this.buttonParaAsignarYEnviar.UseVisualStyleBackColor = false;
            this.buttonParaAsignarYEnviar.Click += new System.EventHandler(this.buttonParaAsignarYEnviar_Click);
            // 
            // FormularioAsignarCuestionariosAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonParaAsignarYEnviar);
            this.Controls.Add(this.labelParaSeleccionAlumnos);
            this.Controls.Add(this.checkedListBoxListaAlumnos);
            this.Name = "FormularioAsignarCuestionariosAlumnos";
            this.Text = "FormularioAsignarCuestionariosAlumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxListaAlumnos;
        private System.Windows.Forms.Label labelParaSeleccionAlumnos;
        private System.Windows.Forms.Button buttonParaAsignarYEnviar;
    }
}
