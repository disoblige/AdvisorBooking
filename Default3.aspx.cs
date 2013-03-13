using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//added
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {



        ronUtil2 get = new ronUtil2();
        DropDownList1.DataSource = get.getStudentIds();
        DropDownList1.DataBind();

    }


}