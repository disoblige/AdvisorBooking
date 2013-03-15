using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using System.ComponentModel;
using System.Drawing;
using System.Text;

public partial class StudentProfileUpdate : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection();
        cmd = new SqlCommand();
        con.ConnectionString = "Data Source=SHREEJI-PC\\SQLSERVER2008;Initial Catalog=College_Mgmt;Integrated Security=True";
        con.Open();
        cmd.Connection = con;
        if (!IsPostBack)
        {
            String id = "300717754";
            lblStudentIDValue.Text = id;
         
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select First_Name,Last_Name,Program_id,Cur_Sem,Image from Student where Student_ID='" + id + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtFName.Text = dr[0].ToString();
                txtLName.Text = dr[1].ToString();
                ddlProgramName.SelectedValue = dr[2].ToString();
                txtCurrentSemester.Text = dr[3].ToString();
                imgPhoto.ImageUrl = MapPath("~" + dr[4].ToString());
           }



            dr.Close();
        }

    }


    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        DatabaseRegistration objdb = new DatabaseRegistration();
        objdb.update_Student_Info(lblStudentIDValue.Text ,txtFName.Text,txtLName.Text,ddlProgramName.SelectedValue,txtCurrentSemester.Text,"Photo");
     }
}