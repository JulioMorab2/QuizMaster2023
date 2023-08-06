namespace QuizMaster.UI.Windows.Forms
{
    partial class FormCat_TipoDocumento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxCat_TipoDocumento = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtBIDCat_TipoDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCat_TipoDocumento = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxCat_TipoDocumento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat_TipoDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCat_TipoDocumento
            // 
            this.gbxCat_TipoDocumento.Controls.Add(this.cbxEstado);
            this.gbxCat_TipoDocumento.Controls.Add(this.txtDescripcion);
            this.gbxCat_TipoDocumento.Controls.Add(this.txtBIDCat_TipoDocumento);
            this.gbxCat_TipoDocumento.Controls.Add(this.label2);
            this.gbxCat_TipoDocumento.Controls.Add(this.label1);
            this.gbxCat_TipoDocumento.Location = new System.Drawing.Point(12, 12);
            this.gbxCat_TipoDocumento.Name = "gbxCat_TipoDocumento";
            this.gbxCat_TipoDocumento.Size = new System.Drawing.Size(342, 152);
            this.gbxCat_TipoDocumento.TabIndex = 0;
            this.gbxCat_TipoDocumento.TabStop = false;
            this.gbxCat_TipoDocumento.Text = "Cat_TipoDocumento";
            this.gbxCat_TipoDocumento.Enter += new System.EventHandler(this.gbxCat_TipoDocumento_Enter);
            // 
            // cbxEstado
            // 
            this.cbxEstado.AutoSize = true;
            this.cbxEstado.Location = new System.Drawing.Point(128, 89);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(59, 17);
            this.cbxEstado.TabIndex = 5;
            this.cbxEstado.Text = "Estado";
            this.cbxEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxEstado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AcceptsTab = true;
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(128, 60);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(175, 20);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBIDCat_TipoDocumento
            // 
            this.txtBIDCat_TipoDocumento.AcceptsTab = true;
            this.txtBIDCat_TipoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBIDCat_TipoDocumento.Enabled = false;
            this.txtBIDCat_TipoDocumento.Location = new System.Drawing.Point(128, 32);
            this.txtBIDCat_TipoDocumento.Name = "txtBIDCat_TipoDocumento";
            this.txtBIDCat_TipoDocumento.Size = new System.Drawing.Size(175, 20);
            this.txtBIDCat_TipoDocumento.TabIndex = 3;
            this.txtBIDCat_TipoDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDCat_TipoDocumento";
            // 
            // dgvCat_TipoDocumento
            // 
            this.dgvCat_TipoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCat_TipoDocumento.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCat_TipoDocumento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCat_TipoDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCat_TipoDocumento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCat_TipoDocumento.Location = new System.Drawing.Point(12, 170);
            this.dgvCat_TipoDocumento.Name = "dgvCat_TipoDocumento";
            this.dgvCat_TipoDocumento.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCat_TipoDocumento.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCat_TipoDocumento.Size = new System.Drawing.Size(342, 177);
            this.dgvCat_TipoDocumento.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(237, 353);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 353);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FormCat_TipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 393);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvCat_TipoDocumento);
            this.Controls.Add(this.gbxCat_TipoDocumento);
            this.Name = "FormCat_TipoDocumento";
            this.Text = "Cat_TipoDocumento";
            this.gbxCat_TipoDocumento.ResumeLayout(false);
            this.gbxCat_TipoDocumento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat_TipoDocumento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCat_TipoDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBIDCat_TipoDocumento;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvCat_TipoDocumento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox cbxEstado;
        private System.Windows.Forms.Button btnNuevo;
    }
}