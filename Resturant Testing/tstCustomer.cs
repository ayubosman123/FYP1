using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace Resturant_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see if it exists
            Assert.IsNotNull(AnCustomer);
        }

        //Firstname
        [TestMethod]
        public void FirstNameExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //create some test data
            string FirstName = "fred";
            TestItem.FirstName = FirstName;
            //test to see if it exists
            Assert.AreEqual(TestItem.FirstName, FirstName);

        }

        [TestMethod]
        public void SurnameExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //create some test data
            string Surname = "bloggs";
            TestItem.Surname = Surname;
            //test to see if it exists
            Assert.AreEqual(TestItem.Surname, Surname);

        }

        //Email
        [TestMethod]
        public void EMailExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //create some test data
            string EMail = "me@me.com";
            TestItem.EMail = EMail;
            //test to see if it exists
            Assert.AreEqual(TestItem.EMail, EMail);

        }

        //Gender
        [TestMethod]
        public void GenderExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //create some test data
            string Gender = "Male";
            TestItem.Gender = Gender;
            //test to see if it exists
            Assert.AreEqual(TestItem.Gender, Gender);

        }

        [TestMethod]
        public void DateExist()
        {
            //create a new instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer(); ;
            //create some test data
            DateTime Date = DateTime.Now.Date;
            AnCustomer.dateOfBirth = Date;
            //test to see if it exists
            Assert.AreEqual(AnCustomer.dateOfBirth, Date);

        }

        [TestMethod]
        public void ContactNumberExist()
        {
            //create a new instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data
            string ContactNumber = "01161234567";
            AnCustomer.ContactNumber = ContactNumber;
            //test to see if it exists
            Assert.AreEqual(AnCustomer.ContactNumber, ContactNumber);

        }

        [TestMethod]
        public void HouseNoExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //create some test data
            string HouseNo = "2";
            TestItem.HouseNo = HouseNo;
            //test to see if it exists
            Assert.AreEqual(TestItem.HouseNo, HouseNo);

        }

        [TestMethod]
        public void PostCodeExist()
        {
            //create a new instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data
            string PostCode = "LE5";
            AnCustomer.PostCode = PostCode;
            //test to see if it exists
            Assert.AreEqual(AnCustomer.PostCode, PostCode);
        }

        [TestMethod]
        public void TitleExist()
        {
            //create a new instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data
            string Title = "Mr";
            AnCustomer.Title = Title;
            //test to see if it exists
            Assert.AreEqual(AnCustomer.Title, Title);
        }

        [TestMethod]
        public void ValidExist()
        {
            //create a new instance of the class we want to create
            clsCustomer TestItem = new clsCustomer(); ;
            //string variable to store result of validation
            string AllOK = "";
            //create some test data to assign to property
            string FirstName = "fred";
            string Surname = "bloggs";
            string dateOfBirth = DateTime.Now.Date.AddYears(-21).ToString();
            string Gender = "male";
            string ContactNumber = "01161234567";
            string EMail = "me@me.com";
            string HouseNo = "2";
            string PostCode = "LE5 6HP";
            string Title ="Mr";
            //invoke method
            AllOK = TestItem.Valid(FirstName, Surname, dateOfBirth, Gender, ContactNumber, EMail, HouseNo, PostCode, Title);
            //test to see if it exists
            Assert.AreEqual(AllOK, "");
        }








    }
}
