using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMaster.UI.Windows.Forms
{
    public partial class MDIQuizMaster : MetroFramework.Forms.MetroForm
    {
        private int childFormNumber = 0;

        public MDIQuizMaster()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registroTiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCat_TipoDocumento tipoDocumento = new FormCat_TipoDocumento();
            tipoDocumento.MdiParent = this;
            tipoDocumento.Show();

        }

        private void registrosDeTiposGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoGrupo ingresoGrupo = new IngresoGrupo();
            ingresoGrupo.MdiParent = this;
            ingresoGrupo.Show();
        }

        private void registroDeMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMaterias formMaterias = new FormMaterias();
            formMaterias.MdiParent = this;
            formMaterias.Show();

        }

        private void registroDeQuimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuimestres formQuimestres = new FormQuimestres();
            formQuimestres.MdiParent = this;
            formQuimestres.Show();
        }

        private void ingresoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoAlumnos ingresoAlumnos = new IngresoAlumnos();
            ingresoAlumnos.MdiParent = this;
            ingresoAlumnos.Show();
        }
    }
}
