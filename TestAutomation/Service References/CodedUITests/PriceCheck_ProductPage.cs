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



//using Microsoft.Practices.EnterpriseLibrary.Data;
//using VP.Nimbus.DataEntity;



namespace TestAutomation
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class PriceCheck_ProductPage : logWriter
    {
        public PriceCheck_ProductPage()
        {
        }

        [TestMethod]
        public void PriceCheck_productPageVerf()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463

            string villaIDList = ConfigurationManager.AppSettings["villaID"].ToString();
            string noOfVillas = ConfigurationManager.AppSettings["noOfVillas"].ToString();
            List<string> villaIDlst = new List<string>();
            string sqlQuery = "";
            getFromDB getData = new getFromDB();
            SqlDataReader dataReader = null;
            SqlDataReader dataReaderVillaID = null;

            if (villaIDList == string.Empty)
            {
                sqlQuery = "SELECT TOP " + noOfVillas + " VillaId FROM tblVIllaAvailability where available='A' ORDER BY NEWID()";
                dataReaderVillaID = getData.getData(sqlQuery);
                while (dataReaderVillaID.Read())
                {
                    villaIDlst.Add(dataReaderVillaID[0].ToString());
                }
            }
            else
            {
                string[] villaidArr = villaIDList.Split(',');
                for (int i = 0; i < villaidArr.GetLength(0); i++)
                {
                    villaIDlst.Add(villaidArr[i].ToString());
                }
            }

            foreach (string villaID in villaIDlst)
            {
                string strURL = ConfigurationManager.AppSettings["URL"].ToString() + "product.aspx?villaid=" + villaID;


                string villashortname = "";
                int maxoccupancy = 0;
                int extrachildren = 0;

                WriteLogs("########## START ########## Villa ID : " + villaID + " : " + DateTime.Now.ToString() + "##########");

                sqlQuery = "SELECT Summary, accommodationtext, accommodationdetails, locationtext, locationdetails, latitude, longitude, resortid, shortname, subtitle, centre, QualityID, maxoccupancy, extrachildren from dbo.TblVilla where id=" + villaID;
                dataReader = getData.getData(sqlQuery);
                while (dataReader.Read())
                {
                    villashortname = dataReader[8].ToString();
                    maxoccupancy = Convert.ToInt32(dataReader[12].ToString());
                    extrachildren = Convert.ToInt32(dataReader[13].ToString());
                }

                InitiateProductPage runScript = new InitiateProductPage();
                runScript.OpenBrowser_Obj.openBrowser_Method();
                runScript.enterURL_Obj.enterURL_Method(strURL);
                runScript.clickAvailabilityTab_Obj.clickAvailabilityTab_Method();
                runScript.clickCheckAvaiandPricesBtn_Obj.clickCheckAvaiandPricesBtn_Method();

                HtmlComboBox uIDdCalenderMonthsComboBox = runScript.selectActTabDepartsOn_Obj.getCombo_Method();
                HtmlComboBox uIDdAdultsComboBox = runScript.selectAdult_Obj.getselectAdultDropDown_Method();
                HtmlComboBox uIDdChildrenComboBox = runScript.selectChild_Obj.getselectChildDropDown_Method();
                int lastitem = uIDdAdultsComboBox.Items.Count-1;
                uIDdAdultsComboBox.SelectedIndex = lastitem - 2;
                uIDdChildrenComboBox.SelectedIndex = lastitem - 3;

                Boolean wht = false;

                for (int i = 0; i < uIDdCalenderMonthsComboBox.Items.Count; i++)
                {
                    uIDdCalenderMonthsComboBox.SelectedIndex = i;
                    //wht = runScript.selectActTabDate_Obj.selectActTabBookVillaBtn_Method();
                    wht = runScript.selectDateFrmProductPage_Obj.selectDateFrmProductPage_Method();
                    if (wht == true)
                    {
                        runScript.selectActTabAirtport_Obj.selectActTabAirport_Method();


                        //----Booking Popup--------
                        //runScript.selectAdult_Obj.selectAdult_Method();
                        //runScript.selectChild_Obj.selectChild_Method();
                        runScript.clickActTabBookVillaBtn_Obj.selectActTabBookVillaBtn_Method();

                        string strTemp = runScript.getDateforPriceCompare_Obj.getDateforPriceCompare_Method();
                        WriteLogs("INFO : strtmp date : " + strTemp);
                        string strDate = strTemp.Split(' ')[2];
                        string strMonth = strTemp.Split(' ')[3];
                        string strYear = strTemp.Split(' ')[4];
                        string dt = strMonth + " " + strDate + " " + strYear;
                        // string Dateincorrectformat = "10/02/2014";
                        //System.Globalization.DateTimeFormatInfo mfi = new
                        //System.Globalization.DateTimeFormatInfo();
                        //string strMonthName = mfi.GetMonthName(SelectableMonthNum).ToString();


                        WriteLogs("INFO : Date for Price Calculation : " + dt);
                        string villaOnlyPrice = "";

                        sqlQuery = "EXEC dbo.QAsp_CalculateVillaTotalPrice @paramvID = " + villaID +
                                                ", @departureDate = N'" + dt + "', @weeks = 1";

                        dataReader = getData.getData(sqlQuery);
                        while (dataReader.Read())
                        {
                            villaOnlyPrice = dataReader[0].ToString();
                        }
                        decimal price = Convert.ToDecimal(villaOnlyPrice);
                        price = Math.Round(price, 0);
                        villaOnlyPrice = Convert.ToString(price);
                        runScript.verifyActTabVillaOnlyPrice_Obj.verifyActTabVillaOnlyPrice_Method(villaOnlyPrice, dt);
                        break;

                    }
                    if (wht == false)
                    {
                        WriteLogs("INFO : Not able to select date for price calculation.");
                    }

                    WriteLogs("########## END ########## Villa ID : " + villaID + " : " + DateTime.Now.ToString() + "##########" + '\n');
                    runScript.OpenBrowser_Obj.closeBrowser_Method();

                }

            }
        }

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