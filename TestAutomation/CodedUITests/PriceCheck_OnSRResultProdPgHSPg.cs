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
using TestAutomation.UIMap.ProductPage.openBrowser_MapClasses;

namespace TestAutomation
{
    /// <summary>
    /// Summary description for SearchTile
    /// </summary>
    [CodedUITest]
    public class PriceCheck_OnSRResultProdPgHSPg:logWriter
    {
        public PriceCheck_OnSRResultProdPgHSPg()
        {
        }

        [TestMethod]
        public void VOPriceCheck_OnSRResultProdPgHSPg()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463

            #region Booking Initiation
            WriteLogs("########## START ########## Villa Only Price Check on Search Result page : " + DateTime.Now.ToString() + "##########");
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
            #endregion

            #region Search Tile Verification
            InitiateSearchTile runScript = new InitiateSearchTile();
            runScript.openBrowser_Obj.openBrowser_Method();
            runScript.enterURL_Obj.enterURL_Method(strURL);
            takeImage("HomePage");
            Boolean IsIncompletepopupDisplayed = runScript.verifyIncompleteBookingpopupDisplay_Obj.verifyIncompleteBookingpopupDisplay_Method();
            if (IsIncompletepopupDisplayed == true)
            {
                runScript.clickNOBtnFrmIncompletePopup_Obj.clickNOBtnFrmIncompletePopup_Method();
            }

            List<string> centreNameList = new List<string>();
            sqlQuery = "SELECT centreName  from  dbo.TblCentre";
            dataReader = getData.getData(sqlQuery, InitialCatalog);
            while (dataReader.Read())
            {
                centreNameList.Add(dataReader["centreName"].ToString());
            }
            Boolean IsNoVillasMsgDisplayed = false;
            int NumofAdults = 0;
            int NumofChild = 0;
            int NumofInfants = 0;
            string SelectedDuration = string.Empty;
            string SelectedAirport = string.Empty;
            DateTime SelectableDate = new DateTime();
            string SelectedDate = string.Empty;
            int NumofVillasFound = 0;
            string villaid = null;
            string dt =string.Empty;
            int numweeks = 0;
            
        

          //  runScript.verifyDestinationListBox_Obj.verifyDestinationListBox_Method();
            do
            {   
                string SelectedCenter = runScript.verifyDestinationListBox_Obj.selectDestination_Method(centreNameList);
                //string SelectedCenter = "AL";
                string centerCode = string.Empty;
                sqlQuery = "SELECT Centre  from  dbo.TblCentre where CentreName = '" + SelectedCenter + "'";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    centerCode = dataReader["Centre"].ToString();
                }

                int MaxOccupancy = 0;
                int MinOccupancy = 0;
                sqlQuery = "Select  Min(Minoccupancy), Max(MaxOccupancy) from tblvilla where Centre = '" + centerCode + "'";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    MaxOccupancy = Convert.ToInt32(dataReader[0].ToString());
                    MinOccupancy = Convert.ToInt32(dataReader[1].ToString());
                }
                string EndDate = ConfigurationManager.AppSettings["SeasonEndDate"].ToString();

                DateTime StartDate = System.DateTime.Today;
                List<string> DatesList = new List<String>();
                //sqlQuery = "exec dbo.QAsp_GetAvailableDates @strCentre='" + centerCode + "', @StartDate='" + StartDate + "',@EndDate='02/28/2016'";
                sqlQuery = "exec dbo.QAsp_GetAvailableDates @strCentre='" + centerCode + "', @StartDate='04/01/2015',@EndDate='" + EndDate + "'";

                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    DatesList.Add(dataReader["WeekStart"].ToString());
                }

                int NumofDatesAvaial = DatesList.Count;
                Random rnd = new Random();
                int SelectableDateindex = rnd.Next(1, NumofDatesAvaial);
                SelectableDate = Convert.ToDateTime(DatesList[SelectableDateindex - 1]);
                runScript.clickCalenderIcon_Obj.clickCalenderIcon_Method();
               // runScript.verifyCalenderDisplay_Obj.verifyCalenderDisplay_Method();
                runScript.selectMonthFrmCalender_Obj.selectMonthFrmCalender_Method(SelectableDate);
                runScript.selectaDateFrmCalender_Obj.selectaDateFrmCalender_Method(SelectableDate);
                //runScript.verifyDurationListBox_Obj.verifyDurationListBox_Method();
                SelectedDuration = runScript.verifyDurationListBox_Obj.selectDuration_Method();
                //runScript.verifyAdultListBox_Obj.verifyAdultListBox_Method();
                NumofAdults = runScript.verifyAdultListBox_Obj.selectAdults_Method(MaxOccupancy);
               // runScript.verifyChildListBox_Obj.verifyChildListBox_Method();
                NumofChild = runScript.verifyChildListBox_Obj.selectChild_Method(MaxOccupancy);
               // runScript.verifyInfantListbox_Obj.verifyInfantListbox_Method();
                NumofInfants = runScript.verifyInfantListbox_Obj.selectInfant_Method(NumofAdults);
               // runScript.verifyAirportListBox_Obj.verifyAirportListBox_Method();
                SelectedAirport = runScript.verifyAirportListBox_Obj.selectAirport_Method();
                runScript.clickSearchBtn_Obj.clickSearchBtn_Method();
            #endregion

            #region Search Results Verification
                int NumofPax = (NumofAdults + NumofChild);
                Boolean Ispopupdisplayed = runScript.verifyIncorrectInputPopupDisplayed_Obj.returnIncorrectInputPopupDisplayed_Method();
                while (Ispopupdisplayed == true)
                {
                    runScript.verifyIncorrectInputPopupDisplayed_Obj.verifyIncorrectInputPopupDisplayed_Method();
                    runScript.clickOKFrmIncorrectPopup_Obj.clickOKFrmIncorrectPopup_Method();
                    if (MaxOccupancy < NumofPax)
                    {
                        int valuetoselect = MaxOccupancy / 2;
                        NumofAdults = runScript.verifyAdultListBox_Obj.ModifyAdultsNum_Method(valuetoselect);
                        NumofChild = runScript.verifyChildListBox_Obj.ModifyChildNum_Method(valuetoselect);
                        runScript.clickSearchBtn_Obj.clickSearchBtn_Method();
                        Ispopupdisplayed = runScript.verifyIncorrectInputPopupDisplayed_Obj.returnIncorrectInputPopupDisplayed_Method();
                    }
                }
                int NumofNights = Convert.ToInt32(SelectedDuration.Trim().Replace("nights", string.Empty));
                SelectedDate = Convert.ToString(SelectableDate.ToString("dd MMMM yyyy"));
                string strTemp = SelectedDate;
                string strDate = strTemp.Split(' ')[0];
                string strMonth = strTemp.Split(' ')[1];
                string strMonth1 = strMonth.Substring(0, 3);
                string strYear = strTemp.Split(' ')[2];
                dt = strMonth1 + " " + strDate + " " + strYear;
                WriteLogs("INFO: Selected date:         \"" + dt + "\" ");
               
                switch (NumofNights)
                {
                    case 7:
                        numweeks = 1;
                        break;
                    case 14:
                        numweeks = 2;
                        break;
                    case 21:
                        numweeks = 3;
                        break;
                    case 28:
                        numweeks = 4;
                        break;
                    default:
                        
                        break;
                }
                WriteLogs("INFO: Number of Weeks:           \"" + numweeks + "\"");
            
                sqlQuery = "exec QAsp_GetSearchResultDetails " + NumofNights + ",'" + centerCode + "','" + SelectedDate + "',20," + NumofAdults + "," + NumofChild + ",'ANY'";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    NumofVillasFound = Convert.ToInt32(dataReader[0].ToString());
                }
                IsNoVillasMsgDisplayed = runScript.verifyNoVillasMsgDisplayed_Obj.verifyNoVillasMsgDisplayed_Method();
                }while (IsNoVillasMsgDisplayed == true);
               runScript.verifySearchResultsPageOpened_Obj.verifySearchResultsPageOpened_Method(NumofAdults, NumofChild, NumofInfants, SelectedDuration, SelectedAirport, SelectableDate, SelectedDate, NumofVillasFound);
               WriteLogs("----------------------------------------------------------------------------------------------");
               string Villaname = runScript.getVillaNameFrmSRPage_Obj.getVillaNameFrmSRPage_Method();
             
               WriteLogs("INFO :Villa Name:      \"" + Villaname + "\"");
               string villanameweb = Villaname.Substring(0, Villaname.IndexOf(","));
               int index = villanameweb.IndexOf("'");
               if (index > 0)
               {
                   villanameweb = villanameweb.Insert(index + 1, "'");
               }
               sqlQuery = "SELECT id from dbo.TblVilla where fullname='" + villanameweb + "'";
               dataReader = getData.getData(sqlQuery, InitialCatalog);
               while (dataReader.Read())
               {
                   villaid = dataReader[0].ToString();
                 
               }

               WriteLogs("INFO : Villa ID:            \"" + villaid + "\" ");
               string villaOnlyPricefromDB = "";

               sqlQuery = "EXEC dbo.QAsp_CalculateVillaTotalPrice @paramvID = " + villaid +
                                       ", @departureDate = N'" + dt + "', @weeks = "+numweeks +"";

               dataReader = getData.getData(sqlQuery, InitialCatalog);
               while (dataReader.Read())
               {
                   villaOnlyPricefromDB = dataReader[0].ToString();
               }
               decimal price = Convert.ToDecimal(villaOnlyPricefromDB);
               price = Math.Round(price, 0);
               villaOnlyPricefromDB = Convert.ToString(price);
               WriteLogs("INFO : Villa only price from DB \"" + villaOnlyPricefromDB + "\" ");
               WriteLogs("INFO: -------------------------------------------------------------------");
                runScript.getVillaOnlyPriceFrmSRPage_obj.getVillaOnlyPriceFrmSRPage_Method(villaOnlyPricefromDB,villanameweb);
                runScript.clickViewVillaBtnFrmSearchResultsPage_Obj.clickViewVillaBtnFrmSearchResultsPage_Method();
                runScript.GetVillaOnlyPriceFrmProductPage_obj.GetVillaOnlyPriceFrmProductPage_Method(villaOnlyPricefromDB, villanameweb);
                runScript.clickBookVillaOnlyBtnFrmProductPage_Obj.clickBookVillaOnlyBtnFrmProductPage_Method();
                runScript.getVOPriceFrmHSPage_obj.getVOPriceFrmHSPage_Method(villaOnlyPricefromDB, villanameweb);
            
                //}
                #endregion

         

            #region Villa Tab Verfication From Search Tile
            //Verifying Villa Tab From SearchTile.
            //runScript.enterURL_Obj.enterURL_Method(strURL);
            //IsIncompletepopupDisplayed = runScript.verifyIncompleteBookingpopupDisplay_Obj.verifyIncompleteBookingpopupDisplay_Method();
            //if (IsIncompletepopupDisplayed == true)
            //{
            //    runScript.clickNOBtnFrmIncompletePopup_Obj.clickNOBtnFrmIncompletePopup_Method();
            //}
            //runScript.clickVillaNameTabfromSearchTile_Obj.clickVillaNameTabfromSearchTile_Method();
            //runScript.enterAnyCharInVillaNameTxtBox_Obj.enterAnyCharInVillaNameTxtBox_Method();
            //string selectedVilla = runScript.selectaVillaFromList_Obj.selectaVillaFromList_Method();
            //runScript.clickViewVillaFrmSearchTile_Obj.clickViewVillaFrmSearchTile_Method();

            //string[] SelectedVillaNCenter = selectedVilla.Split('(');
            //string selectedVillaFrmVillaTab ="Villa "+SelectedVillaNCenter[0].Trim();
            //string selectedCenterFrmVillaTab = SelectedVillaNCenter[1].Replace(")", string.Empty).Trim();
            //string SubTitle = string.Empty;
            //sqlQuery = "SELECT  SubTitle  from  dbo.tblvilla where FullName = '" + selectedVillaFrmVillaTab + "'";
            //dataReader = getData.getData(sqlQuery);
            //while (dataReader.Read())
            //{
            //    SubTitle = dataReader[0].ToString();
            //}

            //runScript.verifyProductPageOpened_Obj.verifyProductPageOpened_Method(selectedVillaFrmVillaTab, SubTitle, selectedCenterFrmVillaTab);          

            //WriteLogs("########## END ########## Search Tile : " + DateTime.Now.ToString() + "##########");
            #endregion

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
