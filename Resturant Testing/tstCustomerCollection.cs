using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;
using System.Collections.Generic;

namespace Resturant_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomer);
        }


        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this sceanario it needs to be a lists of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.FirstName = "fred";
            TestItem.Surname = "bloggs";
            TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-19);
            TestItem.Gender = "male";
            TestItem.ContactNumber = "01167";
            TestItem.EMail = "me@me.com";
            TestItem.HouseNo = "2";
            TestItem.PostCode = "LE5 6HP";
            TestItem.Title = "Mr";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that it exists
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        //[TestMethod]
        //public void ThisCustomerPropertyOK()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerCollection AllCustomer = new clsCustomerCollection();
        //    //create some test data to assign to the property
        //    //add an item to the list
        //    clsCustomer TestItem = new clsCustomer();
        //    //set its properties
        //    TestItem.FirstName = "fred";
        //    TestItem.Surname = "bloggs";
        //    TestItem.dateOfBirth = DateTime.Now.Date.AddYears(-19);
        //    TestItem.Gender = "male";
        //    TestItem.ContactNumber = "01167";
        //    TestItem.EMail = "me@me.com";
        //    TestItem.HouseNo = "2";
        //    TestItem.PostCode = "LE5 6HP";
        //    TestItem.Title = "Mr";
        //    //assign the data to the property
        //    AllCustomer.CustomerList = TestItem;
        //    //test to see that it exists
        //    Assert.AreEqual(AllCustomer.CustomerList, TestItem);
        //}

    }
}
