using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;
public partial class Delete : System.Web.UI.Page
{

    //var to store the primary key value of the record to be deleted
    Int32 Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Customer to be deleted from the session object
        Id = Convert.ToInt32(Session["Id"]);
    }

    protected void btnbacktocustomerpage_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteCust();
        //directs back to the login page 
        Response.Redirect("DefaultCust.aspx");
    }

    void DeleteCust()
    {
        ////function to delete the selected record


        //create a new instance of the Customer collection
        clsCustomerCollection CustList = new clsCustomerCollection();
        //find the record to delete
        CustList.ThisCustomer.Find(Id);
        //delete the record
        CustList.Delete(); ;
    }
}
