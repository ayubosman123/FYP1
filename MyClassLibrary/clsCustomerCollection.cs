using System;
using System.Collections.Generic;

namespace MyClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();



        //public property for the Customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //public propery for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //later
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }


        }


        public Int32 Add()
        {
            //adds a new record to the database based on the values of thisCustomer
            clsDataConnection NewAnCustomer = new clsDataConnection();
            //adding the parameters 
            NewAnCustomer.AddParameter("@firstname", mThisCustomer.FirstName);
            NewAnCustomer.AddParameter("@lastname", mThisCustomer.Surname);
            NewAnCustomer.AddParameter("@email", mThisCustomer.EMail);
            NewAnCustomer.AddParameter("@title", mThisCustomer.Title);
            NewAnCustomer.AddParameter("@gender", mThisCustomer.Gender);
            NewAnCustomer.AddParameter("@dob", mThisCustomer.dateOfBirth);
            NewAnCustomer.AddParameter("@houseno", mThisCustomer.HouseNo);
            NewAnCustomer.AddParameter("@contactno", mThisCustomer.ContactNumber);
            NewAnCustomer.AddParameter("@postcode", mThisCustomer.PostCode);
            // execute the stored procedure returning the primary key value of the new record 
            return NewAnCustomer.Execute("sproc_tblUserdetails_Insert");
        }



        public Int32 Update()
        {
            //adds a new record to the database based on the values of thisCustomer
            clsDataConnection NewAnCustomer = new clsDataConnection();
            //updating the parameters 
            NewAnCustomer.AddParameter("@ID", mThisCustomer.Id);
            NewAnCustomer.AddParameter("@firstname", mThisCustomer.FirstName);
            NewAnCustomer.AddParameter("@lastname", mThisCustomer.Surname);
            NewAnCustomer.AddParameter("@email", mThisCustomer.EMail);
            NewAnCustomer.AddParameter("@title", mThisCustomer.Title);
            NewAnCustomer.AddParameter("@gender", mThisCustomer.Gender);
            NewAnCustomer.AddParameter("@dob", mThisCustomer.dateOfBirth);
            NewAnCustomer.AddParameter("@houseno", mThisCustomer.HouseNo);
            NewAnCustomer.AddParameter("@contactno", mThisCustomer.ContactNumber);
            NewAnCustomer.AddParameter("@postcode", mThisCustomer.PostCode);
            // execute the stored procedure returning the primary key value of the new record 
            return NewAnCustomer.Execute("sproc_tblUserdetails_Update");
        }


        public Int32 Delete()
        {
            //deletes the record pointed to by thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ID", mThisCustomer.Id);
            //execute the stored procedure
            return DB.Execute("sproc_tblUserdetails_Delete");
        }



        void PopulateArray(clsDataConnection DB)
        {
            //populates array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count.
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array lsit
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //Create a blank booking
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.Id = Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["firstname"]);
                AnCustomer.Surname = Convert.ToString(DB.DataTable.Rows[Index]["lastname"]);
                AnCustomer.EMail = Convert.ToString(DB.DataTable.Rows[Index]["email"]);
                AnCustomer.Title = Convert.ToString(DB.DataTable.Rows[Index]["title"]);
                AnCustomer.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                AnCustomer.dateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["dob"]);
                AnCustomer.ContactNumber = Convert.ToString(DB.DataTable.Rows[Index]["contactno"]);
                AnCustomer.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["houseNo"]);
                AnCustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["postCode"]);
                //add the records into a private data member
                mCustomerList.Add(AnCustomer);
                //point to the next record
                Index++;
            }
        }
        //constructor for the class
        public clsCustomerCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_FiltertblUserDetailsALL");
            //populate the array list
            PopulateArray(DB);
        }

        public void Filterbyemail(string email) //string UserName)
        {
            //filters the records based on a full or partial code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@email", email);
            // execute the stored procedure 
            DB.Execute("sproc_FiltertblUserDetailsbyemail");
            //populate the array list with the data table
            PopulateArray(DB);
        }

    }
}