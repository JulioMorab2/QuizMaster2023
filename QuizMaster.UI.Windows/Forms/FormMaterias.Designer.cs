namespace QuizMaster.UI.Windows.Forms
{
    partial class FormMaterias
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
            this.txbMateria = new System.Windows.Forms.TextBox();
            this.btnMateria = new System.Windows.Forms.Button();
            this.lblMateria = new System.Windows.Forms.Label();
            this.dgvMateria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // txbMateria
            // 
            this.txbMateria.Location = new System.Drawing.Point(97, 15);
            this.txbMateria.Name = "txbMateria";
            this.txbMateria.Size = new System.Drawing.Size(181, 20);
            this.txbMateria.TabIndex = 0;
            // 
            // btnMateria
            // 
            this.btnMateria.Location = new System.Drawing.Point(307, 12);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(75, 23);
            this.btnMateria.TabIndex = 1;
            this.btnMateria.Text = "Guardar";
            this.btnMateria.UseVisualStyleBackColor = true;
            this.btnMateria.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(35, 18);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 2;
            this.lblMateria.Text = "Materia";
            this.lblMateria.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvMateria
            // 
            this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria.Location = new System.Drawing.Point(38, 67);
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.Size = new System.Drawing.Size(344, 150);
            this.dgvMateria.TabIndex = 3;
            // 
            // FormMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 234);
            this.Controls.Add(this.dgvMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.btnMateria);
            this.Controls.Add(this.txbMateria);
            this.Name = "FormMaterias";
            this.Text = "FormMaterias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMateria;
        private System.Windows.Forms.Button btnMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.DataGridView dgvMateria;
    }
}