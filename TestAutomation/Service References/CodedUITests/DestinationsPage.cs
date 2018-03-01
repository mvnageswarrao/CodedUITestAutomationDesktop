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
using System.Data.SqlClient;
using TestAutomation.Utility;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Configuration;


namespace DestinationsPageAutomation
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class DestinationsPage:logWriter
    {
        public DestinationsPage()
        {
        }

        [TestMethod]
        public void DestinationsPageVerification()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            string strURL = ConfigurationManager.AppSettings["URL"].ToString();
            WriteLogs("########## START ########## Destinations Page : " + DateTime.Now.ToString() + "##########");

            getFromDB getData = new getFromDB();
            SqlDataReader dataReader = null;

            List<string> villaCenterlst = new List<String>();
            List<string> villaCenterNamelst = new List<String>();
            string sqlQuery = "SELECT Centre, CentreName from dbo.TblCentre";
            dataReader = getData.getData(sqlQuery);
            while (dataReader.Read())
            {
                villaCenterlst.Add(dataReader["Centre"].ToString());
                villaCenterNamelst.Add(dataReader["CentreName"].ToString());
            }

            InitiateDestinationPage runScript = new InitiateDestinationPage();
            runScript.OpenBrowser_Obj.openBrowser_Method();
            runScript.enterURL_Obj.enterURL_Method(strURL + "destinations");
            //runScript.setIE9StandardsInDeveloperTools_Obj.setIE9StandardsInDeveloperTools_Method();

            runScript.verifyHeadingText_Obj.verifyHeadingText_Method("Destinations");
            runScript.clickListViewTab_Obj.clickListViewTab_Method();

            string villaCentre= "";
            string villaCentrerName = "";
            string villaCount = "";
            //for(int i = 0 ; i < villaCenterlst.Count ; i++)
            //{
            //    villaCentre = villaCenterlst[i];
            //    villaCentrerName = villaCenterNamelst[i];
            //    sqlQuery = "SELECT COUNT(*) as VillaCount from tblvilla where Centre ='" + villaCentre + "'  AND Showvilla='1'";
            //    dataReader = getData.getData(sqlQuery);
            //    while (dataReader.Read())
            //    {
            //        villaCount = dataReader[0].ToString();
            //    }
            //    runScript.verifyNoOfVillasPerCentre_Obj.verifyNoOfVillasPerCentre_Method(villaCount, villaCentrerName);
            //}
            
            runScript.clickViewVillas_Obj.clickViewVillasModified_Method(villaCenterlst);
            runScript.clickViewResorts_Obj.clickViewResortsMopdified_Method(villaCenterlst);
            runScript.clickCountryImage_Obj.clickCountryImageModified_Method(villaCenterlst);
            runScript.verifyHrefInCountryName_Obj.verifyHrefInCountryNameModified_Method();
            runScript.verifyImageAltTag_Obj.verifyImageAltTagModified_Method();
            
            runScript.clickMapViewTab_Obj.clickMapViewTab_Method();
        
            WriteLogs("########## END ########## Destinations Page : " + DateTime.Now.ToString() + "##########" + '\n');
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
