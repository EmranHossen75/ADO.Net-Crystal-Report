using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_01
{
    public partial class frmTutorView : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=trainee_53;Trusted_Connection=True;");
        public frmTutorView()
        {
            InitializeComponent();
        }

        private void frmTutorView_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT t.tutorId,t.tutorName,t.tutorContact,t.tutorEmail,t.picture,s.name FROM tutors t INNER JOIN Subjects s ON t.subjectId=s.id", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
