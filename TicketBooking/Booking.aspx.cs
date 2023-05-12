using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketBooking
{
    public partial class Booking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(cln1.SelectedDate>cln1.TodaysDate)
            {
                lblMsg.Text=txtName.Text+"<br>"+txtFrom.Text+ "<br>"+txtTo.Text+"<br>Tickets Booked for"+cln1.SelectedDate.ToShortDateString();
            }
            else
            {
                lblMsg.Text = "Sorry! Tickets Not Available";
            }
        }

        
        protected void cln1_SelectionChanged(object sender, EventArgs e)
        {
            txtJourneyDate.Text = cln1.SelectedDate.ToLongDateString();
        }
    }
}