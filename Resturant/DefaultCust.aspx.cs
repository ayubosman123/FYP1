using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;

public partial class DefaultCust : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //create an instancew of the Customer Collection
        clsCustomerCollection Customer = new clsCustomerCollection();
        // set the data source to the list of countries in the collection
        lstCust.DataSource = Customer.CustomerList;
        // set the name of the primary key
        lstCust.DataValueField = "Id";
        // set the data field to display
        lstCust.DataTextField = "AllDetails";
        //bind the data to the list 
        lstCust.DataBind();

    }

    void Filteremail(string email)
    {
        //create an instance of the booking collection
        clsCustomerCollection C = new clsCustomerCollection();
        C.Filterbyemail(email);
        //set the data source to the list of bookings in the collection
        lstCust.DataSource = C.CustomerList;
        //set the name of the primary key
        lstCust.DataValueField = "id";
        //set the data field to display
        lstCust.DataTextField = "email";
        //bind the data to the list
        lstCust.DataBind();
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        DisplayCustomers();
    }

    protected void btnAddCustomer_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["Id"] = -1;
        //redirect to the data entry page
        Response.Redirect("SignUp.aspx");
    }

    protected void btnDeleteCustomer_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 Id;
        //if a record has been selected from the list
        if (lstCust.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            Id = Convert.ToInt32(lstCust.SelectedValue);
            //store the data in the session object
            Session["Id"] = Id;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

        //var to store the primary key value of the record to be edited
        Int32 Id;
        //if a record has been selected from the list
        if (lstCust.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            Id = Convert.ToInt32(lstCust.SelectedValue);
            //store the data in the session object
            Session["Id"] = Id;
            //redirect to the edit page
            Response.Redirect("SignUp.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnFilterEmail_Click(object sender, EventArgs e)
    {
        Filteremail(txtFilter.Text);
    }
}