namespace QuizMaster.UI.Windows.Forms
{
    partial class IngresoAlumnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtNumIdentificacion = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbIDCat_TipoDocumento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbIDAlumnoGrupo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(182, 53);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(200, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 3;
            // 
            // txtNumIdentificacion
            // 
            this.txtNumIdentificacion.AutoSize = true;
            this.txtNumIdentificacion.Location = new System.Drawing.Point(31, 116);
            this.txtNumIdentificacion.Name = "txtNumIdentificacion";
            this.txtNumIdentificacion.Size = new System.Drawing.Size(92, 13);
            this.txtNumIdentificacion.TabIndex = 2;
            this.txtNumIdentificacion.Text = "NumIdentificacion";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(182, 79);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(200, 20);
            this.txtApellidos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos";
            // 
            // dateFechaNacimiento
            // 
            this.dateFechaNacimiento.Location = new System.Drawing.Point(182, 152);
            this.dateFechaNacimiento.Name = "dateFechaNacimiento";
            this.dateFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateFechaNacimiento.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "FechaNacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo Documento";
            // 
            // cbIDCat_TipoDocumento
            // 
            this.cbIDCat_TipoDocumento.FormattingEnabled = true;
            this.cbIDCat_TipoDocumento.Location = new System.Drawing.Point(182, 193);
            this.cbIDCat_TipoDocumento.Name = "cbIDCat_TipoDocumento";
            this.cbIDCat_TipoDocumento.Size = new System.Drawing.Size(200, 21);
            this.cbIDCat_TipoDocumento.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Grupo";
            // 
            // cbIDAlumnoGrupo
            // 
            this.cbIDAlumnoGrupo.FormattingEnabled = true;
            this.cbIDAlumnoGrupo.Location = new System.Drawing.Point(182, 227);
            this.cbIDAlumnoGrupo.Name = "cbIDAlumnoGrupo";
            this.cbIDAlumnoGrupo.Size = new System.Drawing.Size(200, 21);
            this.cbIDAlumnoGrupo.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IngresoAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbIDAlumnoGrupo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbIDCat_TipoDocumento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateFechaNacimiento);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtNumIdentificacion);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label1);
            this.Name = "IngresoAlumnos";
            this.Text = "IngresoAlumnos";
            this.Load += new System.EventHandler(this.IngresoAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtNumIdentificacion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFechaNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbIDCat_TipoDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbIDAlumnoGrupo;
        private System.Windows.Forms.Button button1;
    }
}