using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add new namesapce
using System.Data.SqlClient;
using System.Configuration;


namespace WindoDatabase
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            string strConnection = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con = new SqlConnection(strConnection);


        }

        private void labSalary_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void labId_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //@id,@name,@salary are the variable name
                string str = "insert into Stud_Info values(@id,@name,@salary)";
                cmd = new SqlCommand(str,con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name",txtName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(txtSalary.Text));
                //open DB connection
                con.Open();
                //FireThe Quary 
                int result = cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("Record Inserted");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtSalary.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ds = GetEmpData();
            dataGridView1.DataSource = ds.Tables["emp"];



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                //@id,@name,@salary are the variable name
                string str = "update Stud_Info set name=@name,salary=@salary where Id=@id ";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToInt32(txtSalary.Text));
                //open DB connection
                con.Open();
                //FireThe Quary 
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record update Success");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                //@id,@name,@salary are the variable name
                string str = "delete from Stud_Info where Id=@id ";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
               
                //open DB connection
                con.Open();
                //FireThe Quary 
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record Delete Success");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                string str = "select * from Stud_Info where Id=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                // open DB connection
                con.Open();
                // fire the query select
                dr = cmd.ExecuteReader();
                if (dr.HasRows)// check that record is present in dr object or not
                {
                    while (dr.Read()) // read data from dr object
                    {
                        txtName.Text = dr["Name"].ToString();
                        txtSalary.Text = dr["Salary"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               dr.Close();
            }

        }

        private void btnShowAllStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select * from Stud_Info";
                cmd = new SqlCommand(str, con);
                // open DB connection
                con.Open();
                // fire the query select
                dr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr);
                dataGridView1.DataSource = table;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
            }
        }
    }
}
