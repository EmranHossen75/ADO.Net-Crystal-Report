using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_01
{
    public partial class frmTutorEntry : Form
    {
        SqlConnection con = new SqlConnection("Server=.;Database=trainee_53;Trusted_Connection=True;");
        public frmTutorEntry()
        {
            InitializeComponent();
        }

        private void frmTutorEntry_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT id,name FROM Subjects";

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbSubject.DataSource = ds.Tables[0];
            cmbSubject.DisplayMember = "name";
            cmbSubject.ValueMember = "id";
            con.Close();
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtPicture.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tutors(tutorName,tutorContact,tutorEmail,picture,subjectId,dateOfBirth,gender) VALUES(@n,@c,@e,@p,@s,@d,@g)";
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@c", txtContact.Text);
            cmd.Parameters.AddWithValue("@e", txtEmail.Text);
            cmd.Parameters.AddWithValue("@d", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@g", chkGender.Checked.ToString());
            cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary) { Value = ms.ToArray() });
            cmd.Parameters.AddWithValue("@s", cmbSubject.SelectedValue);
            cmd.ExecuteNonQuery();
            lblMsg.Text = "Data Inserted successfully!!!";
            con.Close();
        }

        private void btnPicture_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = img;
                txtPicture.Text = openFileDialog1.FileName;
            }
        }
    }
}
