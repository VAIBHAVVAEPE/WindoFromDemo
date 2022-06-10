using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Ado.netHomeWork_of__Courese
{
    public partial class Form1 : Form
    {

        //code inside the class
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public Form1()
        {
            InitializeComponent();
            string strConnection = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con = new SqlConnection(strConnection);
        }

        private DataSet GetEmpData()
        {
            da = new SqlDataAdapter("select * from Course_info", con);
            // add PK constraint to the col (id) which is in DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // build the command for DataAdpater 
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            // Fill() fire the select qry in DB & load data in DataSet
            da.Fill(ds, "course_info"); // emp is the name given to the table which get loaded in the DataSet
            return ds;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtFees.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["course_info"].NewRow();
                row["Id"] = txtID.Text;
                row["Name"] = txtName.Text;
                row["Fees"] = txtFees.Text;
                ds.Tables["course_info"].Rows.Add(row);
                // reflect the changes from DataSet to DB
                int result = da.Update(ds.Tables["course_info"]);
                if (result == 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ds = GetEmpData();
            dataGridView1.DataSource = ds.Tables["course_info"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["course_info"].Rows.Find(txtID.Text);
                if (row != null)
                {
                    row["Name"] = txtName.Text;
                    row["Fees"] = txtFees.Text;
                    int result = da.Update(ds.Tables["course_info"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Record updated");
                    }

                }
                else
                {
                    MessageBox.Show("Id does not exists to update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["course_info"].Rows.Find(txtID.Text);
                if (row != null)
                {

                    txtName.Text = row["Name"].ToString();
                    txtFees.Text = row["Fees"].ToString();
                    int result = da.Update(ds.Tables["course_info"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Record Search");
                    }

                }
                else
                {
                    MessageBox.Show("Id does not exists to Search");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["course_info"].Rows.Find(txtID.Text);
                if (row != null)
                {
                    row.Delete();// delete the row from DataSet
                    int result = da.Update(ds.Tables["course_info"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Record Delete");
                    }

                }
                else
                {
                    MessageBox.Show("Id does not exists to Delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
