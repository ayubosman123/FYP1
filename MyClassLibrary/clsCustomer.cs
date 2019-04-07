using System;

namespace MyClassLibrary
{
    public class clsCustomer
    {
        //private data memeber for the BookRef property
        private Int32 mID;

        //public property for BookRef
        public int Id
        {
            get
            {
                //return private data
                return mID;
            }
            set
            {
                //set the value of the private data member
                mID = value;
            }
        }
        //public property for fName
        private string mFirstName;
        public string FirstName
        {
            get
            {
                //return private data
                return mFirstName;
            }
            set
            {
                //set the the value of the private memeber
                mFirstName = value;
            }

        }
        private string mSurname;
        public string Surname
        {
            get
            {
                //return private data
                return mSurname;
            }
            set
            {
                //set the the value of the private memeber
                mSurname = value;
            }

        }

        private string mEMail;
        public string EMail
        {
            get
            {
                //return private data
                return mEMail;
            }
            set
            {
                //set the the value of the private memeber
                mEMail = value;
            }

        }

        private string mGender;
        public string Gender
        {
            get
            {
                //return private data
                return mGender;
            }
            set
            {
                //set the the value of the private memeber
                mGender = value;
            }
        }

        private DateTime mdateOfBirth;
        public DateTime dateOfBirth
        {
            get
            {
                //return private data
                return mdateOfBirth;
            }
            set
            {
                //set the the value of the private memeber
                mdateOfBirth = value;
            }
        }

        private string mContactNumber;
        public string ContactNumber
        {
            get
            {
                //return private data
                return mContactNumber;
            }
            set
            {
                //set the the value of the private memeber
                mContactNumber = value;
            }
        }

        private string mHouseNo;
        public string HouseNo
        {
            get
            {
                //return private data
                return mHouseNo;
            }
            set
            {
                //set the the value of the private memeber
                mHouseNo = value;
            }
        }

        private string mPostCode;
        public string PostCode
        {
            get
            {
                //return private data
                return mPostCode;
            }
            set
            {
                //set the the value of the private memeber
                mPostCode = value;
            }
        }

        private string mTitle;
        public string Title
        {
            get
            {
                //return private data
                return mTitle;
            }
            set
            {
                //set the the value of the private memeber
                mTitle = value;
            }
        }

        private string mAllDetails;

        //public property for AllDetails
        public string AllDetails
        {
            get
            {
                //return private data
                return mTitle + " " + mFirstName + " " + mSurname + " " + mdateOfBirth + " " + mGender + " " + mContactNumber + " " + mEMail + " " + mHouseNo + " " + mPostCode + " ";
            }
            set
            {
                //set the the value of the private memeber
                mAllDetails = value;
            }
        }




        public string Valid(string firstName, string surname, string dateOfBirth, string gender, string contactNumber, string eMail, string houseNo, string postCode, string title)
        {
            {
                //temp variable to store start date
                DateTime DateTemp;
                string OK = "";


                ///// validation 


                if (firstName.Length < 1)
                {
                    OK = OK + " Firstname is too short :     ";
                }
                if (firstName.Length > 25)
                {
                    OK = OK + " Firstname is too long :      ";
                }

                ///////////////////////////////////////////////
                if (surname.Length < 1)
                {
                    OK = OK + " Last name is too short :     ";
                }
                if (surname.Length > 25)
                {
                    OK = OK + " Last name is too long :      ";
                }

                /////////////////////////////

                // if statement for email 

                if (eMail.Length < 6)
                {
                    OK = OK + " Email is too short :  ";
                }

                if (eMail.Length > 30)
                {
                    OK = OK + " Email is too long :    ";
                }

          

                if (title.Length < 2)
                {
                    OK = OK + " title is too short :";
                }

                if (title.Length > 5)
                {
                    OK = OK + " title is too long :";
                }

                if (gender.Length < 1)
                {
                    OK = OK + " Gender is too short : ";
                }
                if (gender.Length > 6)
                {
                    OK = OK + " Gender is too long : ";
                }


                try
                {
                    DateTemp = Convert.ToDateTime(dateOfBirth);

                    if (DateTemp >= DateTime.Now.Date.AddYears(-18))
                    {
                        OK = OK + " You must be over 18 years old :      ";
                    }

                    if (DateTemp <= DateTime.Now.Date.AddYears(-150))
                    {
                        OK = OK + " You must be under 150 years old :       ";
                    }

                }
                catch
                {
                    OK = OK + " Incorrect date entered :  ";
                }


                // if statement for contactNo

                if (contactNumber.Length < 3)
                {
                    OK = OK + " Contact Number is too short : ";
                }
                if (contactNumber.Length > 11)
                {
                    OK = OK + " Contact Number is too long :  ";
                }


                // if statement for houseno

                if (houseNo.Length < 1)
                {
                    OK = OK + " HouseNo is too short :";
                }
                if (houseNo.Length > 6)
                {
                    OK = OK + " HouseNo is too long :";
                }

                // if statement for postcode

                if (postCode.Length < 5)
                {
                    OK = OK + " PostCode is too short :";
                }
                if (postCode.Length > 9)
                {
                    OK = OK + " PostCode is too long :";
                }


        

                return OK;

            }
        }


        public bool Find(int ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the book ref to search for
            DB.AddParameter("@Id", ID);
            //execute stored procedure
            DB.Execute("sproc_FiltertblUserDetailsbyPK");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["firstname"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["lastname"]);
                mEMail = Convert.ToString(DB.DataTable.Rows[0]["email"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["title"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mdateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["dob"]);
                mContactNumber = Convert.ToString(DB.DataTable.Rows[0]["contactno"]);
                mHouseNo = Convert.ToString(DB.DataTable.Rows[0]["houseNo"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["postCode"]);
                //mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);


                //return an record has been found
                return true;
            }
            //if no record is found
            else
            {
                //record no record has been found
                return false;
            }
        }
    }

}