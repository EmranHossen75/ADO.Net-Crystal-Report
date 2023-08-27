using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void traineeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            frm.MdiParent = this;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubject fs = new frmSubject();
            fs.Show();
            fs.MdiParent = this;
        }

        private void tutorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTutorEntry fte = new frmTutorEntry();
            fte.Show();
            fte.MdiParent = this;
        }

        private void tutorUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTutorUpdateDelete fte = new frmTutorUpdateDelete();
            fte.Show();
            fte.MdiParent = this;
        }

        private void tutorViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTutorView ft = new frmTutorView();
            ft.Show();
            ft.MdiParent = this;
        }

        private void tutorInformationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport fv = new frmReport();
            fv.Show();
            fv.MdiParent = this;
        }

        private void productInformationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductInfoReport pr = new frmProductInfoReport();
            pr.Show();
            pr.MdiParent = this;
        }
    }
}
