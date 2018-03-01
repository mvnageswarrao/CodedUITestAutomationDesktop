using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using System.Configuration;
using TestAutomation.Utility;
using System.Data.SqlClient;
using System.IO;


namespace TestAutomation
{
    /// <summary>
    /// Summary description for SearchTile
    /// </summary>
    [CodedUITest]
    public class BookingB_PDFVerification:logWriter
    {
        public BookingB_PDFVerification()
        {
        }

        [TestMethod]
        public void BookingB_zPDFVerfication()
        {
         
    #region Booking Initiation
    WriteLogs("####### START ####### Booking PDF Verification : " + DateTime.Now.ToString() + "#######");
    getFromDB getData = new getFromDB();
    #endregion

    #region Booking PDF Verification
    pdfCheck verifyPDF = new pdfCheck();
    verifyPDF.ConvertAllPDFstoTXT();
    verifyPDF.VerifyAllPDFs();

    #endregion

    WriteLogs("####### END ####### Booking PDF Verification : " + DateTime.Now.ToString() + "#######" + '\n' + '\n' + '\n');

        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
