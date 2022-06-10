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


namespace Disconnected_Demo
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
            da = new SqlDataAdapter("select * from Stud_Info", con);
            // add PK constraint to the col (id) which is in DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // build the command for DataAdpater 
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            // Fill() fire the select qry in DB & load data in DataSet
            da.Fill(ds, "stud_info"); // emp is the name given to the table which get loaded in the DataSet
            return ds;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["stud_info"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row["Name"] = txtName.Text;
                    row["Salary"] = txtSalary.Text;
                    int result = da.Update(ds.Tables["stud_info"]);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                    ds = GetEmpData();
                    DataRow row = ds.Tables["stud_info"].NewRow();
                row["Id"] = txtId.Text;
                   row["Name"] = txtName.Text;
                    row["Salary"] = txtSalary.Text;
                    ds.Tables["stud_info"].Rows.Add(row);
                    // reflect the changes from DataSet to DB
                    int result = da.Update(ds.Tables["stud_info"]);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["stud_info"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    row.Delete();// delete the row from DataSet
                    int result = da.Update(ds.Tables["stud_info"]);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                ds = GetEmpData();
                DataRow row = ds.Tables["stud_info"].Rows.Find(txtId.Text);
                if (row != null)
                {
                    
                    txtName.Text = row["Name"].ToString() ;
                    txtSalary.Text=row["Salary"].ToString() ;
                    int result = da.Update(ds.Tables["stud_info"]);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAllStudent_Click(object sender, EventArgs e)
        {
            ds = GetEmpData();
            dataGridView1.DataSource = ds.Tables["stud_info"];

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtSalary.Clear();

        }
    }
}
