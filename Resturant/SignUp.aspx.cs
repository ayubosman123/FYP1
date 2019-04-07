using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;
public partial class SignUp : System.Web.UI.Page
{
    Int32 Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the pk of the booking to be processed
        Id = Convert.ToInt32(Session["Id"]);
        if (IsPostBack == false)
        {

            //if this is not a new record
            if (Id != -1)
            {
                //display the current data for the record
                DisplayCust();
            }
        }
    }

    protected void btnEnter_Click(object sender, EventArgs e)
    {
        //This will then enter the information you have enterted in the form
        if (Id == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
    }

    //function for Adding records
    void Add()
    {
        //create an instance of the booking list
        clsCustomerCollection Customer = new clsCustomerCollection();
        //validate the data on the web form
        //string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode
        String Error = Customer.ThisCustomer.Valid(txtfirstname.Text, txtsurname.Text, txtdateOfBirth.Text, txtgender.Text, txtContactNumber.Text , txteMail.Text, txtHouseno.Text, txtpostCode.Text, txttitle.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            //Customer.ThisCustomer.Find(Id);
            //get the data entered by the user
            Customer.ThisCustomer.FirstName = Convert.ToString(txtfirstname.Text);
            Customer.ThisCustomer.Surname = Convert.ToString(txtsurname.Text);
            Customer.ThisCustomer.EMail = Convert.ToString(txteMail.Text);
            Customer.ThisCustomer.Title = Convert.ToString(txttitle.Text);
            Customer.ThisCustomer.Gender = Convert.ToString(txtgender.Text);
            Customer.ThisCustomer.dateOfBirth = Convert.ToDateTime(txtdateOfBirth.Text);
            Customer.ThisCustomer.ContactNumber = Convert.ToString(txtContactNumber.Text);
            Customer.ThisCustomer.HouseNo = Convert.ToString(txtHouseno.Text);
            Customer.ThisCustomer.PostCode = Convert.ToString(txtpostCode.Text);
            //CList.ThisCustomer.UserName = User.Identity.Name;
            //update the record
            Customer.Add();
            //all done so redirect back to the main page
            // Response.Redirect("AdminHomepage.aspx"); page does not exist
            lblError.Text = "add";
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
        void Update()
    {
            //create an instance of the booking list
            clsCustomerCollection Customer = new clsCustomerCollection();
        //validate the data on the web form
        //string foreName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string flatNo, string houseNo, string postCode
        String Error = Customer.ThisCustomer.Valid(txtfirstname.Text, txtsurname.Text, txtdateOfBirth.Text, txtgender.Text, txtContactNumber.Text, txteMail.Text, txtHouseno.Text, txtpostCode.Text, txttitle.Text);
        //if the data is OK then add it to the object
        if (Error == "")
            {
            //find the record to update
                 Customer.ThisCustomer.Find(Id);
                //get the data entered by the user
                Customer.ThisCustomer.FirstName = Convert.ToString(txtfirstname.Text);
                Customer.ThisCustomer.Surname = Convert.ToString(txtsurname.Text);
                Customer.ThisCustomer.EMail = Convert.ToString(txteMail.Text);
                Customer.ThisCustomer.Title = Convert.ToString(txttitle.Text);
                Customer.ThisCustomer.Gender = Convert.ToString(txtgender.Text);
                Customer.ThisCustomer.dateOfBirth = Convert.ToDateTime(txtdateOfBirth.Text);
                Customer.ThisCustomer.ContactNumber = Convert.ToString(txtContactNumber.Text);
                Customer.ThisCustomer.HouseNo = Convert.ToString(txtHouseno.Text);
                Customer.ThisCustomer.PostCode = Convert.ToString(txtpostCode.Text);
                //CList.ThisCustomer.UserName = User.Identity.Name;
                //update the record
                Customer.Update();
            //all done so redirect back to the main page
            //  Response.Redirect("AdminHomepage.aspx");
            lblError.Text = "update";
        }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayCust()
    {
        //create an instance of the booking list
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to update
        Customer.ThisCustomer.Find(Id);
        //display the data for this record
        txtfirstname.Text = Customer.ThisCustomer.FirstName;
        txtsurname.Text = Customer.ThisCustomer.Surname;
        txteMail.Text = Customer.ThisCustomer.EMail;
        txttitle.Text = Customer.ThisCustomer.Title;
        txtgender.Text = Customer.ThisCustomer.Gender;
        txtdateOfBirth.Text = Customer.ThisCustomer.dateOfBirth.ToString("dd/MM/yyyy");
        txtContactNumber.Text = Customer.ThisCustomer.ContactNumber;
        txtHouseno.Text = Customer.ThisCustomer.HouseNo;
        txtpostCode.Text = Customer.ThisCustomer.PostCode;

    }
}

