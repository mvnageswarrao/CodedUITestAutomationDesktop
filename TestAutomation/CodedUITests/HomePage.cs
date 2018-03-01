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
using System.Data.SqlClient;
using System.Configuration;
using TestAutomation.UIMap.ProductPage.openBrowser_MapClasses;


namespace TestAutomation
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class HomePage:logWriter
    {
        public HomePage()
        {
        }
        [TestInitialize]
        public void Init()
        {

           string Brow = Environment.GetEnvironmentVariable("browser", EnvironmentVariableTarget.User);
        }

        [TestMethod]
        public void HomePageVerification()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            WriteLogs("########## START ########## Home Page Page : " + DateTime.Now.ToString() + "##########");
            getFromDB getData = new getFromDB();
            SqlDataReader dataReader = null;
            string strURL = ConfigurationManager.AppSettings["URL"].ToString();

            string DBSelectionMode = ConfigurationManager.AppSettings["DBSelectionMode"].ToString();
            string InitialCatalog = string.Empty;
            string sqlQuery = string.Empty;
            if (DBSelectionMode == "Auto")
            {
                InitialCatalog = openBrowser_Map.ChooseDB(strURL);
            }
            else if (DBSelectionMode == "Manual")
            {
                InitialCatalog = ConfigurationManager.AppSettings["InitialCatalog"].ToString();
            }

            List<string> villaCenterlst = new List<String>();
            List<string> villaCenterNamelst = new List<String>();
            sqlQuery = "SELECT Centre, CentreName from dbo.TblCentre";
            dataReader = getData.getData(sqlQuery, InitialCatalog);
            while (dataReader.Read())
            {
                villaCenterlst.Add(dataReader["Centre"].ToString());
                villaCenterNamelst.Add(dataReader["CentreName"].ToString());
            }           

            InitiateHomePage runscript = new InitiateHomePage();

             

            BrowserWindow.CurrentBrowser = "chrome";
            BrowserWindow.Launch(new string[] { "http://www.bing.com/", @"–user-data-dir=C:\Users\veera\AppData\Local\Google\Chrome\User Data" });

            runscript.OpenBrowser_Obj.openBrowser_Method();
            runscript.EnterURL_Obj.enterURL_Method(strURL);
            string villaid = ConfigurationManager.AppSettings["villaid"].ToString();
            takeImage("HomePage");
            runscript.clickHomePageLink_Obj.clickHomePageLink_Method();
            runscript.clickThinkSeaViewslink_Obj.clickThinkSeaViewslink_Method();
            runscript.clickThinkVillasHeatedPools_Obj.clickThinkVillasHeatedPools_Method();
            runscript.clickWiFiVillas_Obj.clickWiFiVillas_Method();
            //runscript.clickBrowseSeaViewsLink_Obj.clickBrowseSeaViewsLink_Method();
            //runscript.clickBrowseVillasHeatedPoolsLink_Obj.clickBrowseVillasHeatedPoolsLink_Method();
            //runscript.clickBrowseWiFiVillasLink_Obj.clickBrowseWiFiVillasLink_Method();
            //runscript.clickImageSeaViews_Obj.clickImageSeaViews_Method();
            //runscript.clickImageHeatedPools_Obj.clickImageHeatedPools_Method();
            //runscript.clickImageWiFi_Obj.clickImageWiFi_Method();
            runscript.clickThinkDestinationsLink_Obj.clickThinkDestinationsLink_Method();
            runscript.clickAlgarveMapLink_Obj.clickAlgarveMapLink_Method();
            runscript.clickKefaloniaMapLink_Obj.clickKefaloniaMapLink_Method();
            runscript.clickCyprusMapLink_Obj.clickCyprusMapLink_Method();
            runscript.clickCorfuListLink_Obj.clickCorfuListLink_Method();
            runscript.clickMenorcaListLink_Obj.clickMenorcaListLink_Method();
            runscript.clickDestinitaionsLink_Obj.clickDestinitaionsLink_Method();
            runscript.clickThinkSunshineLink_Obj.clickThinkSunshineLink_Method();
            runscript.clickViewMoreVideosLink_Obj.clickViewMoreVideosLink_Method();
            runscript.clickAboutVillaPlusLink_Obj.clickAboutVillaPlusLink_Method();
            runscript.cickReadMoreAboutUsLink_Obj.clickReadMoreAboutUsLink_Method();
            runscript.clickVoteVillaPlusLink_Obj.clickVoteVillaPlusLink_Method();
            runscript.clickVoteNowLink_Obj.clickVoteNowLink_Method();
            runscript.verifyWhatPeopleSayLink_Obj.verifyWhatPeopleSayLink_Method();
            runscript.verifyVisitTrustPilotLink_Obj.verifyVisitTrustPilotLink_Method();
            runscript.clickContactUsLink_Obj.clickContactUsLink_Method();
            runscript.clickHowToBookLink_Obj.clickHowToBookLink_Method();
            runscript.clickVillaOwnersLink_Obj.clickVillaOwnersLink_Method();
            runscript.clickTermsofUseLink_Obj.clickTermsofUseLink_Method();
            runscript.clickHolidayGamesGuideLink_Obj.clickHolidayGamesGuideLink_Method();
            runscript.clickSitemapLink_Obj.clickSitemapLink_Method();
            runscript.click2323ATOLLink_Obj.click2323ATOLLink_Method();
            runscript.clickABTALink_Obj.clickABTALink_Method();
            runscript.click28YearsLogoLink_Obj.click28YearsLogoLink_Method();
            runscript.verifyFacebookLink_Obj.verifyFacebookLink_Method();
            runscript.verifyTwitterLink_Obj.verifyTwitterLink_Method();
            runscript.verifyGoogleLink_Obj.verifyGoogleLink_Method();
            runscript.click2323ATOLPLink_Obj.click2323ATOLP_Method();
            runscript.clickDestinationsMenuLink_Obj.clickDestinationsMenuLink_Method();
            runscript.clickDestLandingPage_Obj.clickDestLandingPage_Method();
            runscript.clickDestVillasPageLink_Obj.clickDestVillasPageLink_Method();
            runscript.ClickDestResortPageLink_Obj.ClickDestResortPageLink_Method();
            runscript.clickVillasLandingPage_Obj.clickVillasLandingPage_Method();
            runscript.clickWhyVillaPlusLink_Obj.clickWhyVillaPlusLink_Method();
            runscript.clickLowDepostMenuBarLink_Obj.clickLowDepostMenuBarLink_Method();
            runscript.clickBrochureRequestLink_Obj.clickBrochureRequestLink_Method();
            runscript.clickFAQsLink_Obj.clickFAQsLink_Method();
            runscript.clickContactUsMenuLink_Obj.clickContactUsMenuLink_Method();
            WriteLogs("########## END ########## Home Page Page : " + DateTime.Now.ToString() + "##########");
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
