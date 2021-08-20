using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DBDemo
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {

        SqlConnection conn;
        SqlCommand cmd;
        string strSql;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Add button
            try
            {

                 conn = new SqlConnection(@"Data Source=LAPTOP-37T9O1E4\SQLEXPRESS;Initial Catalog=emp;Integrated Security=True");
                conn.Open();
                ///////////////////////////////
                strSql = "Insert into emptable values(@t1,@t2,@t3,@t4)";
                cmd = new SqlCommand(strSql, conn);
                cmd.Parameters.AddWithValue("@t1", int.Parse(TextBox1.Text));
                cmd.Parameters.AddWithValue("@t2", TextBox2.Text);
                cmd.Parameters.AddWithValue("@t3", int.Parse(TextBox3.Text));
                if (RadioButton1.Checked == true)
                    cmd.Parameters.AddWithValue("@t4", RadioButton1.Text);
                if (RadioButton2.Checked == true)
                    cmd.Parameters.AddWithValue("@t4", RadioButton2.Text);
                cmd.ExecuteNonQuery();

                conn.Close();
                Label5.Text = "data added";

            }
            catch (Exception er)
            {
                Label5.Text = er.Message;
                conn.Close();
            }
            ///////Part B: view data on screen////////////////
            strSql = "select * from emptable";
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlDataAdapter ad = new SqlDataAdapter(strSql, conn);
                ad.Fill(ds);
                conn.Close();
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();


            }
            catch (Exception e2)
            {
                Label5.Text = e2.Message;
                conn.Close();
            }

        }
      


protected void Button2_Click(object sender, EventArgs e)
        {
            //delete button
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-37T9O1E4\SQLEXPRESS;Initial Catalog=emp;Integrated Security=True");
            conn.Open();
            if(Button2.Text=="DELETE")
            {
                TextBox2.Enabled = false;
                TextBox3.Enabled = false;
                RadioButton1.Enabled = false;
                RadioButton2.Enabled = false;
                string strSql = "delete from emptable where eno=" + int.Parse(TextBox1.Text);
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Label5.Text = "data deleted";
                Button2.Text = "DONE";
            }
            else if(Button2.Text=="DONE")
            {
                TextBox2.Enabled = true;
                TextBox3.Enabled = true;
                RadioButton1.Enabled = true;
                RadioButton2.Enabled = true;
                Button2.Text = "DELETE";
            }

            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //view button
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-37T9O1E4\SQLEXPRESS;Initial Catalog=emp;Integrated Security=True");
            //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-C99UKO00\SQLSVR;Initial Catalog=demodb;User ID=sa;Password=admin");

            conn.Open();
            string strSql = "select * from emptable where eno=" + int.Parse(TextBox1.Text);
            SqlCommand cmd = new SqlCommand(strSql, conn);
            SqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                TextBox2.Text = myReader.GetString(1);
                TextBox3.Text ="" + myReader.GetInt32(2);
                if (myReader["GENDER"].ToString() == "Male") 
                {
                    RadioButton2.Checked = false;
                    RadioButton1.Checked = true;
                }
                if (myReader["GENDER"].ToString() == "Female")
                {
                    RadioButton1.Checked = false;
                    RadioButton2.Checked = true;
                }
            }


            conn.Close();
            Label5.Text = "data obtained from database";

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //edit button
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-37T9O1E4\SQLEXPRESS;Initial Catalog=emp;Integrated Security=True");
            conn.Open();
            if(Button4.Text=="EDIT")
            {
                string strSql1 = "select * from emptable where eno=" + int.Parse(TextBox1.Text);
                SqlCommand cmd1 = new SqlCommand(strSql1, conn);
                SqlDataReader myReader = cmd1.ExecuteReader();
                while (myReader.Read())
                {
                    TextBox2.Text = myReader.GetString(1);
                    TextBox3.Text = "" + myReader.GetInt32(2);
                    if (myReader["GENDER"].ToString() == "Male")
                    {
                        RadioButton2.Checked = false;
                        RadioButton1.Checked = true;
                    }
                    if (myReader["GENDER"].ToString() == "Female")
                    {
                        RadioButton1.Checked = false;
                        RadioButton2.Checked = true;
                    }
                }
                Button4.Text = "UPDATE";
                TextBox1.Enabled = false;
                myReader.Close();
            }//view code ends
            else if(Button4.Text=="UPDATE")
            {
                
                string strSql2 = "UPDATE emptable SET Name=@name, Salary=@salary, Gender=@gender WHERE Eno=@Eno";
                SqlCommand cmd2 = new SqlCommand(strSql2, conn);
                cmd2.Parameters.AddWithValue("@name", TextBox2.Text);
                cmd2.Parameters.AddWithValue("@salary", TextBox3.Text);
                cmd2.Parameters.AddWithValue("@gender", RadioButton1.Checked == true ? RadioButton1.Text : RadioButton2.Text);
                cmd2.Parameters.AddWithValue("@eno", TextBox1.Text);
                cmd2.ExecuteNonQuery();
                Label5.Text = "data updated";
                conn.Close();
            }
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //clear button
            TextBox1.Text = null;
            TextBox2.Text = null;
            TextBox3.Text = null;
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            Label5.Text = "Data cleared";
        }
    }
}