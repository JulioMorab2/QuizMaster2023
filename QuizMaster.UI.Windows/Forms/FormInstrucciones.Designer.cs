namespace QuizMaster.UI.Windows.Forms
{
    partial class FormInstrucciones
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
            this.gbxInstrucciones = new System.Windows.Forms.GroupBox();
            this.rtextInstruccion = new System.Windows.Forms.RichTextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.dgIntrucciones = new System.Windows.Forms.DataGridView();
            this.gbxInstrucciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIntrucciones)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxInstrucciones
            // 
            this.gbxInstrucciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxInstrucciones.Controls.Add(this.rtextInstruccion);
            this.gbxInstrucciones.Location = new System.Drawing.Point(24, 44);
            this.gbxInstrucciones.Name = "gbxInstrucciones";
            this.gbxInstrucciones.Size = new System.Drawing.Size(559, 170);
            this.gbxInstrucciones.TabIndex = 1;
            this.gbxInstrucciones.TabStop = false;
            this.gbxInstrucciones.Text = "Ingresar Instrucciones";
            // 
            // rtextInstruccion
            // 
            this.rtextInstruccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtextInstruccion.Location = new System.Drawing.Point(6, 36);
            this.rtextInstruccion.Name = "rtextInstruccion";
            this.rtextInstruccion.Size = new System.Drawing.Size(537, 125);
            this.rtextInstruccion.TabIndex = 1;
            this.rtextInstruccion.Text = "";
            // 
            // btGuardar
            // 
            this.btGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btGuardar.Location = new System.Drawing.Point(434, 229);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(149, 23);
            this.btGuardar.TabIndex = 2;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // dgIntrucciones
            // 
            this.dgIntrucciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgIntrucciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIntrucciones.Location = new System.Drawing.Point(30, 258);
            this.dgIntrucciones.Name = "dgIntrucciones";
            this.dgIntrucciones.Size = new System.Drawing.Size(553, 166);
            this.dgIntrucciones.TabIndex = 3;
            // 
            // FormInstrucciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 429);
            this.Controls.Add(this.dgIntrucciones);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.gbxInstrucciones);
            this.Name = "FormInstrucciones";
            this.Text = "FormInstrucciones";
            this.gbxInstrucciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgIntrucciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInstrucciones;
        private System.Windows.Forms.RichTextBox rtextInstruccion;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.DataGridView dgIntrucciones;
    }
}