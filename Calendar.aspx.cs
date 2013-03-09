using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;



//added
using System.Configuration;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI;
public partial class Default3 : System.Web.UI.Page
{
   
 
    protected void Page_Load(object sender, EventArgs e)
    {
        
 
      

          
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

    }
    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {

        

            int id = Convert.ToInt16(Request.QueryString["ID"]);
           ronUtil get = new ronUtil(id); 
        
        
        int length = get.DaysAvailable.Length;
        DayOfWeek[] days = new DayOfWeek[length];

        for (int i = 0; i < length; i++)
        {
            days[i] = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), get.DaysAvailable[i]);
        }

        e.Day.IsSelectable = false;
        e.Cell.ForeColor = System.Drawing.Color.Gray;
       // e.Cell.Font.Strikeout = true;
        e.Cell.Font.Size = 10;
            //    e.Cell.ForeColor = System.Drawing.Color.Gray;
        DateTime stratDate = DateTime.Today;
        DateTime endDate = stratDate.AddDays(8);
        //DateTime[] allDays = new DateTime[15];


        if (e.Day.Date > stratDate && e.Day.Date < endDate)
        {
            

            if (e.Day.IsWeekend)
            {
                e.Day.IsSelectable = false;

            }
            else
            {
                e.Day.IsSelectable = true;
              //  e.Cell.BackColor = System.Drawing.Color.AntiqueWhite;
             //   e.Cell.Font.Name = "Courier New Baltic";
               e.Cell.ForeColor = System.Drawing.Color.Black;




            
               e.Cell.Font.Strikeout = false;
               e.Cell.ForeColor = System.Drawing.Color.Red;
               e.Cell.Font.Size=12;
                //DAY RENDERING -ARRAY VARIABLE-.  This is the only way I can do this
                if (length == 1)
                {
                    if (e.Day.Date.DayOfWeek != days[0])
                    {
                        e.Day.IsSelectable = false;
                        //e.Cell.Font.Strikeout = true;
                        e.Cell.ForeColor = System.Drawing.Color.Gray;
                        e.Cell.Font.Size = 10;
                    }
                }



                if (length == 2)
                {
                    if (e.Day.Date.DayOfWeek != days[0] && e.Day.Date.DayOfWeek != days[1])
                    {
                        e.Day.IsSelectable = false;
                        //e.Cell.Font.Strikeout = true;
                        e.Cell.ForeColor = System.Drawing.Color.Gray;
                        e.Cell.Font.Size = 10;
                    }
                }



                if (length == 3)
                {
                    if (e.Day.Date.DayOfWeek != days[0] && e.Day.Date.DayOfWeek != days[1] && e.Day.Date.DayOfWeek != days[2])
                    {
                        e.Day.IsSelectable = false;
                        //e.Cell.Font.Strikeout = true;
                        e.Cell.ForeColor = System.Drawing.Color.Gray;
                        e.Cell.Font.Size = 10;
                    }
                }


                if (length == 4)
                {
                    if (e.Day.Date.DayOfWeek != days[0] && e.Day.Date.DayOfWeek != days[1] && e.Day.Date.DayOfWeek != days[2] && e.Day.Date.DayOfWeek != days[3])
                    {
                        e.Day.IsSelectable = false;
                        //e.Cell.Font.Strikeout = true;
                        e.Cell.ForeColor = System.Drawing.Color.Gray;
                        e.Cell.Font.Size = 10;
                    }
                }


                if (length == 5)
                {
                    if (e.Day.Date.DayOfWeek != days[0] && e.Day.Date.DayOfWeek != days[1] && e.Day.Date.DayOfWeek != days[2] && e.Day.Date.DayOfWeek != days[3] && e.Day.Date.DayOfWeek != days[4])
                    {
                        e.Day.IsSelectable = false;
                       //e.Cell.Font.Strikeout = true;
                        e.Cell.ForeColor = System.Drawing.Color.Gray;
                        e.Cell.Font.Size = 10;
                    }
                }




            }
        }

            }
    










    protected void cmd(object sender, EventArgs e)
    {
     
        if (Calendar1.SelectedDate.Date < DateTime.Now)
        { Server.Transfer("Calendar.aspx"); }
        else {
            Server.Transfer("Confirm.aspx");
                }

    }
}
