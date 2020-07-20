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

namespace SE130721_NgoThanhLoc_PracticalExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=SE130721;Initial Catalog=FUH_COMPANY;Integrated Security=True");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                MessageBox.Show("The connection is successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("The connection failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            conn.Open();
            SqlCommand com = new SqlCommand("SELECT depNum, depName, mgrSSN, mgrAssDate FROM tblDepartment", conn);
            SqlDataReader dr = com.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                ListViewDepartment.Items.Add(dr["depNum"].ToString());
                ListViewDepartment.Items[i].SubItems.Add(dr["depName"].ToString());
                ListViewDepartment.Items[i].SubItems.Add(dr["mgrSSN"].ToString());
                ListViewDepartment.Items[i].SubItems.Add(dr["mgrAssDate"].ToString());
                i++;
            }


            conn.Close();
        }

        private void ListViewDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ListViewDepartment.SelectedItems)
            {
                txtDepNum.Text = item.SubItems[0].Text;
                txtDepName.Text = item.SubItems[1].Text;
                txtmgrSSN.Text = item.SubItems[2].Text;
                txtmgrAssDate.Text = item.SubItems[3].Text;
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string depNum = txtDepNum.Text.Trim();
                string depName = txtDepName.Text.Trim();
                string mgrSSN = txtmgrSSN.Text.Trim();
                string mgrAssDate = txtmgrAssDate.Text.Trim();

                SqlCommand com = new SqlCommand("sp_Insert_tblDeparment", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@depNum", SqlDbType.Int);
                com.Parameters.Add("@depName", SqlDbType.NVarChar, 50);
                com.Parameters.Add("@mgrSSN", SqlDbType.Decimal);
                com.Parameters.Add("@mgrAssDate",SqlDbType.DateTime);

                com.Parameters["@depNum"].Value = depNum;
                com.Parameters["@depName"].Value = depName;
                com.Parameters["@mgrSSN"].Value = mgrSSN;
                com.Parameters["@mgrAssDate"].Value = mgrAssDate;

                com.ExecuteNonQuery();
                conn.Close();
                ListViewDepartment.Items.Clear();
                LoadData();
                MessageBox.Show("Insert data successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Insert data failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string depNum = txtDepNum.Text.Trim();
                string depName = txtDepName.Text.Trim();
                string mgrSSN = txtmgrSSN.Text.Trim();
                string mgrAssDate = txtmgrAssDate.Text.Trim();

                SqlCommand com = new SqlCommand("sp_Update_tblDeparment", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@depNum", SqlDbType.Int);
                com.Parameters.Add("@depName", SqlDbType.NVarChar, 50);
                com.Parameters.Add("@mgrSSN", SqlDbType.Decimal);
                com.Parameters.Add("@mgrAssDate", SqlDbType.DateTime);

                com.Parameters["@depNum"].Value = depNum;
                com.Parameters["@depName"].Value = depName;
                com.Parameters["@mgrSSN"].Value = mgrSSN;
                com.Parameters["@mgrAssDate"].Value = mgrAssDate;

                com.ExecuteNonQuery();
                conn.Close();
                ListViewDepartment.Items.Clear();
                LoadData();
                MessageBox.Show("Update data successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Update data failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string depNum = txtDepNum.Text.Trim();

                SqlCommand com = new SqlCommand("sp_Delete_tblDeparment", conn);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.Add("@depNum", SqlDbType.Int);
                com.Parameters["@depNum"].Value = depNum;

                com.ExecuteNonQuery();
                conn.Close();
                ListViewDepartment.Items.Clear();
                LoadData();
                MessageBox.Show("Delete data successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Delete data failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtDepName.Text = "";
            txtDepNum.Text = "";
            txtmgrAssDate.Text = "";
            txtmgrSSN.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
