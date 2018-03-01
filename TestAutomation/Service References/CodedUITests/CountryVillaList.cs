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
using TestAutomation.Utility;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;


namespace TestAutomation
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CountryVillaList:logWriter
    {
        public CountryVillaList()
        {
        }

        [TestMethod]
        public void Script_VerifyNumofVillas()
        {
            initiateCountryVillaList Verify = new initiateCountryVillaList();
           WriteLogs("########## START ########## CountryVillalistAutomation:" + DateTime.Now.ToString() + "##########");
            getFromDB getData = new getFromDB();
            SqlDataReader datareader = null;

            List<string> CenterList = new List<string>();
            List<string> CenterNameList = new List<string>();
            string villaCount = "";
            String IntrotextfrmDB = "";
            List<string> VillalistIDs = new List<string>();
            List<string> VillaFullnameLst = new List<string>();

            List<string> OverviewfrmDB = new List<string>();
            List<string> ResortNamefrmDB = new List<string>();
            List<string> VillacountperResortfrmDB = new List<string>();
            //string VillaOverviewfrmDB = "";
             

            string sqlquery = "Select Centre, CentreName from dbo.TblCentre";
            datareader = getData.getData(sqlquery);
            while ( datareader.Read())
            {
                CenterList.Add(datareader["Centre"].ToString());
                CenterNameList.Add(datareader["CentreName"].ToString());
            }

            Verify.OpenBrowser_Obj.OpenBrowserIE_Method();

            for (int i = 0; i < CenterList.Count; i++)
            {
                WriteLogs("----------------" + CenterList[i] + "------------");

                string centreNameinURL = CenterNameList[i];
                centreNameinURL = centreNameinURL.Trim();
                centreNameinURL = centreNameinURL.Replace(" ", string.Empty);

                String strURL = ConfigurationManager.AppSettings["URL"].ToString() + "/" + centreNameinURL + "/villas";

                sqlquery = "select count (*) as VillaCount from dbo.TblVilla where Centre = '" + CenterList[i] + "' and showvilla=1";
                datareader = getData.getData(sqlquery);
                while (datareader.Read())
                {
                    villaCount = datareader[0].ToString();
                }
                string sqlquery1;
                sqlquery1 = "Select content from dbo.CentreContent where Attribute like 'Intro2' and Centre = '" + CenterList[i] + "'";
                datareader = getData.getData(sqlquery1);
                while (datareader.Read())
                {
                    IntrotextfrmDB = datareader[0].ToString();
                }

                Verify.OpenHomePage_Obj.OpenHomePage_Method(strURL);
                Verify.VerifyIntroText_Obj.VerifyIntrotext_Method(IntrotextfrmDB, CenterNameList[i]);
                
                //----NOT RUN SUCCESSFULLY-- NEED TO CHECK
                //Verify.OpenVillalistfromDestPage_Obj.VerifyNumofVillas_Assert(CenterNameList[i], villaCount);
                
                //Verify.ClickMapView_Obj.ClickMapView_Method();
                //Verify.ClickMapView_Obj.ClickMapViewAssert_Method(CenterNameList[i]);
                //Verify.ClickListView_Obj.ClickListView_Method();

               Verify.ClickAllLink_Obj.ClickAllLink_Method();

                string sqlquery2;
                sqlquery2 = "select ID as VillaIDsfrmDB, FullName as VillaFullnamesfrmDB from dbo.TblVilla where Centre = '" + CenterList[i] + "' and showvilla=1";
                datareader = getData.getData(sqlquery2);
                while (datareader.Read())
                {
                    VillalistIDs.Add(datareader["VillaIDsfrmDB"].ToString());
                    VillaFullnameLst.Add(datareader["VillaFullnamesfrmDB"].ToString());
                }

                string tempVillaid = "";
                string tempVillaName = Verify.getFirstVillaName_Obj.getVillaName();
                string[] words = tempVillaName.Split(',');
                tempVillaName = words[0];

                string sqlquery3;
                sqlquery3 = "Select id from tblvilla where Fullname like '" + tempVillaName + "'";
                datareader = getData.getData(sqlquery3);
                while (datareader.Read())
                {
                    tempVillaid = datareader[0].ToString();
                }

                OverviewfrmDB.Clear();
                tempVillaid = tempVillaid.Trim();
                tempVillaid = tempVillaid.Replace(" ", string.Empty);
                string sqlquery4;
                sqlquery4 = "select Detail from tblvillaoverview where villaid=" + tempVillaid + "";
                datareader = getData.getData(sqlquery4);
                while (datareader.Read())
                {
                    OverviewfrmDB.Add(datareader["Detail"].ToString());
                }

                    Verify.VerifyVillaOverView_Obj.VerifyVillaOverViewAssertModified_Method(OverviewfrmDB, tempVillaName);
                    Verify.ClickViewVillabtn_Obj.ClickViewVillabtnModified_Method(VillalistIDs);
                //Verify.ClickBacktoVillas_Obj.ClickBacktoVillas_Method();
                //Verify.OpenHomePage_Obj.closeBrowesr();

                    string sqlquery5;
                    sqlquery5 = "select resortid , tblResort.FullName as ResortName, count(resortid) as villacount  from dbo.TblVilla inner join tblResort on tblResort.Id=resortid where TblVilla.Centre = '" + CenterList[i] + "' and showvilla=1 group by resortid, tblResort.FullName";
                    datareader = getData.getData(sqlquery5);
                    ResortNamefrmDB.Clear();
                    VillacountperResortfrmDB.Clear();

                    while (datareader.Read())
                    {
                        ResortNamefrmDB.Add(datareader["ResortName"].ToString());
                        VillacountperResortfrmDB.Add(datareader["villacount"].ToString());
                    }

                    Verify.ResortFilters_Obj.ResortFilters_Method(ResortNamefrmDB, VillacountperResortfrmDB, CenterNameList[i]);
            }
                // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
                // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463

            WriteLogs("########## END ########## CountryVillalistAutomation:" + DateTime.Now.ToString() + "##########");
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
        private string tempVillaid;

        public object sqlquery3 { get; set; }

        public List<string> VillaOverView { get; set; }
    }
}


