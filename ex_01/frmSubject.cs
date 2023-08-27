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
    public partial class frmSubject : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=trainee_53;Trusted_Connection=True;");
        public frmSubject()
        {
            InitializeComponent();
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Subjects";

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO subjects(name) VALUES('" + txtSName.Text + "')", con);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Inserted Successfully!!";
            con.Close();
            ClearAll();
        }
        private void ClearAll()
        {
            txtSName.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM subjects WHERE id=" + txtId.Text + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtSName.Text = dt.Rows[0][1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM subjects WHERE id=" + txtId.Text + "", con);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Deleted Successfully!!";
            con.Close();
            ClearAll();
        }
    }
}
