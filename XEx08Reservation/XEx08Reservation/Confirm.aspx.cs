using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XEx08Reservation
{
    public partial class Confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblYear.Text = DateTime.Today.Year.ToString();
            DisplayReservation();
        }

        private void DisplayReservation()
        {
            Reservation reservation = (Reservation)Session["Reservation"];

            // Personal data
            lblFirstName.Text = reservation.FirstName;
            lblLastName.Text = reservation.LastName;
            lblEmail.Text = reservation.Email;
            lblPhone.Text = reservation.Phone;
            lblPreferredMethod.Text = reservation.PreferredMethod;

            // Request data
            lblArrivalDate.Text = reservation.ArrivalDate.ToShortDateString();
            lblDepartureDate.Text = reservation.DepartureDate.ToShortDateString();
            lblNoOfDays.Text = reservation.NoOfDays.ToString();
            lblNoOfPeople.Text = reservation.NoOfPeople.ToString();
            lblBedType.Text = reservation.BedType;
            lblSpecialRequests.Text = reservation.SpecialRequests;

        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            Response.Redirect("Request.aspx");
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Thank you for your message! \r\n We will get back to you within 24 hours.";
        }
    }
}