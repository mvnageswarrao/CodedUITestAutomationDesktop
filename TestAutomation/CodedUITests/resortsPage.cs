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
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Configuration;


namespace TestAutomation
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class resortsPage:logWriter
    {
        public resortsPage()
        {
        }

        [TestMethod]
        public void resortsPageVerification()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            
            WriteLogs("########## START ########## Resorts Page : " + DateTime.Now.ToString() + "##########");

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

            InitiateResortPage runScript = new InitiateResortPage();
            runScript.OpenBrowser_Obj.openBrowser_Method();

            for ( int i = 0 ; i < villaCenterlst.Count ; i++ )
            {
                WriteLogs("-------------- " + villaCenterNamelst[i] + " --------------");
                
                string resortsIntroTxt = "";
                string resortCount = "";
                List <string> resortIDlst = new List<string>();
                List <string> resortNamelst = new List<string>();
                List <string> palceIDlst = new List<string>();
                string resortDescriptionText = "";

                sqlQuery = "SELECT content from dbo.CentreContent where centre='" + villaCenterlst[i] + "' and attribute='resorts'";
                dataReader = getData.getData(sqlQuery);
                while (dataReader.Read())
                {
                    resortsIntroTxt = dataReader[0].ToString();
                }

                sqlQuery = "select ID, Fullname, PlaceTextID from dbo.TblResort where centre='" + villaCenterlst[i] + "'";
                dataReader = getData.getData(sqlQuery);
                while (dataReader.Read())
                {
                    resortIDlst.Add(dataReader["ID"].ToString());
                    resortNamelst.Add(dataReader["Fullname"].ToString());
                    palceIDlst.Add(dataReader["PlaceTextID"].ToString());
                }

                string cetreNameforURL = villaCenterNamelst[i];
                cetreNameforURL = cetreNameforURL.Trim();
                cetreNameforURL = cetreNameforURL.Replace(" ", string.Empty);

                string strURL = ConfigurationManager.AppSettings["URL"].ToString() + cetreNameforURL + "/resorts";

                runScript.enterURL_Obj.enterURL_Method(strURL);
                //runScript.setIE9StandardsInDeveloperTools_Obj.setIE9StandardsInDeveloperTools_Method();
                takeImage("ResortPage-" + cetreNameforURL);
                runScript.verifyHeadingText_Obj.verifyHeadingText_Method(villaCenterNamelst[i]);
                runScript.verifyResortsIntroText_Obj.verifyResortsIntroText_Method(resortsIntroTxt, villaCenterNamelst[i]);

                runScript.clickListViewTab_Obj.clickListViewTab_Method();

                for (int j = 0; j < resortIDlst.Count; j++)
                {
                    sqlQuery = "select count(*) as ResourtCount from dbo.TblVilla where centre='" + villaCenterlst[i] + "' and resortid=" + resortIDlst[j] + "and showvilla=1";
                    dataReader = getData.getData(sqlQuery);
                    while (dataReader.Read())
                    {
                        resortCount = dataReader[0].ToString();
                    }

                    if (Convert.ToInt32(resortCount) != 0)
                    {
                        runScript.verifyResortsCount_Obj.verifyResortsCount_Method(resortNamelst[j], resortCount);
                        sqlQuery = "select description from dbo.TblPlaces where centre='" + villaCenterlst[i] + "' and id=" + palceIDlst[j];
                        dataReader = getData.getData(sqlQuery);
                        while (dataReader.Read())
                        {
                            resortDescriptionText = dataReader[0].ToString();
                        }
                       // runScript.verifyResortDescriptionText_Obj.verifyResortDescriptionTextModified_Method(resortDescriptionText, resortNamelst[j], resortCount);
                    }
                    else
                    {
                        runScript.verifyResortsCount_Obj.verifyResortsCountModified_Method(resortNamelst[j], resortCount);
                    }
                }
                runScript.clickViewVillasBtn_Obj.clickViewVillasBtnModified_Method(resortNamelst);
                runScript.clickFindOutMore_Obj.clickFindOutMoreModified_Method(resortIDlst);
                runScript.clickResortImage_Obj.clickResortImageModified_Method(resortNamelst);

                //runScript.clickMapViewTab_Obj.clickMapViewTab_Method();

                WriteLogs("-------------- " + villaCenterNamelst[i] + " --------------");
            }
            WriteLogs("########## END ########## Resorts Page : " + DateTime.Now.ToString() + "##########");
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
