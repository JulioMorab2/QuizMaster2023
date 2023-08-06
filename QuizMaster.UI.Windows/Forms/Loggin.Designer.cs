namespace QuizMaster.UI.Windows.Forms
{
    partial class Loggin
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtUsuarios = new MetroFramework.Controls.MetroTextBox();
            this.mtxtUsuariocontraseña = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.metroButton1.Location = new System.Drawing.Point(208, 133);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Ingresar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Usuario";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Contraseña";
            // 
            // mtxtUsuarios
            // 
            this.mtxtUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtUsuarios.BackColor = System.Drawing.Color.LightSteelBlue;
            // 
            // 
            // 
            this.mtxtUsuarios.CustomButton.Image = null;
            this.mtxtUsuarios.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.mtxtUsuarios.CustomButton.Name = "";
            this.mtxtUsuarios.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtUsuarios.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsuarios.CustomButton.TabIndex = 1;
            this.mtxtUsuarios.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsuarios.CustomButton.UseSelectable = true;
            this.mtxtUsuarios.CustomButton.Visible = false;
            this.mtxtUsuarios.Lines = new string[0];
            this.mtxtUsuarios.Location = new System.Drawing.Point(155, 37);
            this.mtxtUsuarios.MaxLength = 32767;
            this.mtxtUsuarios.Name = "mtxtUsuarios";
            this.mtxtUsuarios.PasswordChar = '\0';
            this.mtxtUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsuarios.SelectedText = "";
            this.mtxtUsuarios.SelectionLength = 0;
            this.mtxtUsuarios.SelectionStart = 0;
            this.mtxtUsuarios.ShortcutsEnabled = true;
            this.mtxtUsuarios.Size = new System.Drawing.Size(192, 23);
            this.mtxtUsuarios.TabIndex = 9;
            this.mtxtUsuarios.Tag = "";
            this.mtxtUsuarios.UseSelectable = true;
            this.mtxtUsuarios.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsuarios.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtxtUsuariocontraseña
            // 
            this.mtxtUsuariocontraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mtxtUsuariocontraseña.CustomButton.Image = null;
            this.mtxtUsuariocontraseña.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.mtxtUsuariocontraseña.CustomButton.Name = "";
            this.mtxtUsuariocontraseña.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtxtUsuariocontraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsuariocontraseña.CustomButton.TabIndex = 1;
            this.mtxtUsuariocontraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsuariocontraseña.CustomButton.UseSelectable = true;
            this.mtxtUsuariocontraseña.CustomButton.Visible = false;
            this.mtxtUsuariocontraseña.Lines = new string[0];
            this.mtxtUsuariocontraseña.Location = new System.Drawing.Point(155, 88);
            this.mtxtUsuariocontraseña.MaxLength = 32767;
            this.mtxtUsuariocontraseña.Name = "mtxtUsuariocontraseña";
            this.mtxtUsuariocontraseña.PasswordChar = '*';
            this.mtxtUsuariocontraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsuariocontraseña.SelectedText = "";
            this.mtxtUsuariocontraseña.SelectionLength = 0;
            this.mtxtUsuariocontraseña.SelectionStart = 0;
            this.mtxtUsuariocontraseña.ShortcutsEnabled = true;
            this.mtxtUsuariocontraseña.Size = new System.Drawing.Size(192, 23);
            this.mtxtUsuariocontraseña.TabIndex = 10;
            this.mtxtUsuariocontraseña.UseSelectable = true;
            this.mtxtUsuariocontraseña.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsuariocontraseña.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Loggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 197);
            this.Controls.Add(this.mtxtUsuariocontraseña);
            this.Controls.Add(this.mtxtUsuarios);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Name = "Loggin";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Loggin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtUsuarios;
        private MetroFramework.Controls.MetroTextBox mtxtUsuariocontraseña;
    }
}