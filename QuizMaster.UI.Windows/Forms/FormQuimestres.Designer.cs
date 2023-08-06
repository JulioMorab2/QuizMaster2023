namespace QuizMaster.UI.Windows.Forms
{
    partial class FormQuimestres
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
            this.lblQuimestre = new System.Windows.Forms.Label();
            this.txbQuimestre = new System.Windows.Forms.TextBox();
            this.dgvQuimestre = new System.Windows.Forms.DataGridView();
            this.btnQuimestre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuimestre)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuimestre
            // 
            this.lblQuimestre.AutoSize = true;
            this.lblQuimestre.Location = new System.Drawing.Point(76, 42);
            this.lblQuimestre.Name = "lblQuimestre";
            this.lblQuimestre.Size = new System.Drawing.Size(54, 13);
            this.lblQuimestre.TabIndex = 0;
            this.lblQuimestre.Text = "Quimestre";
            this.lblQuimestre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbQuimestre
            // 
            this.txbQuimestre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbQuimestre.Location = new System.Drawing.Point(141, 39);
            this.txbQuimestre.Name = "txbQuimestre";
            this.txbQuimestre.Size = new System.Drawing.Size(178, 20);
            this.txbQuimestre.TabIndex = 1;
            this.txbQuimestre.TextChanged += new System.EventHandler(this.txbQuimestre_TextChanged);
            // 
            // dgvQuimestre
            // 
            this.dgvQuimestre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuimestre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuimestre.Location = new System.Drawing.Point(79, 82);
            this.dgvQuimestre.Name = "dgvQuimestre";
            this.dgvQuimestre.Size = new System.Drawing.Size(240, 150);
            this.dgvQuimestre.TabIndex = 2;
            // 
            // btnQuimestre
            // 
            this.btnQuimestre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuimestre.Location = new System.Drawing.Point(352, 36);
            this.btnQuimestre.Name = "btnQuimestre";
            this.btnQuimestre.Size = new System.Drawing.Size(75, 23);
            this.btnQuimestre.TabIndex = 3;
            this.btnQuimestre.Text = "Guardar";
            this.btnQuimestre.UseVisualStyleBackColor = true;
            this.btnQuimestre.Click += new System.EventHandler(this.btnQuimestre_Click);
            // 
            // FormQuimestres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 331);
            this.Controls.Add(this.btnQuimestre);
            this.Controls.Add(this.dgvQuimestre);
            this.Controls.Add(this.txbQuimestre);
            this.Controls.Add(this.lblQuimestre);
            this.Name = "FormQuimestres";
            this.Text = "FormQuimestres";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuimestre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuimestre;
        private System.Windows.Forms.TextBox txbQuimestre;
        private System.Windows.Forms.DataGridView dgvQuimestre;
        private System.Windows.Forms.Button btnQuimestre;
    }
}