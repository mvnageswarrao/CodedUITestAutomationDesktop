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
using System.Resources;
using System.Collections;
using TestAutomation.Properties;
using TestAutomation.UIMap.ProductPage.openBrowser_MapClasses;

namespace TestAutomation
{
    /// <summary>
    /// Summary description for Homepageload
    /// </summary>
    [CodedUITest]
    public class SearchResultPage : logWriter
    {
        public SearchResultPage()
        {
        }

        [TestMethod]
        public void SearchResultPageVerification()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            WriteLogs("########## START ########## Home Page Page : " + DateTime.Now.ToString() + "##########");
            getFromDB getData = new getFromDB();
            SqlDataReader dataReader = null;
            SqlDataReader dataReaderVillaID = null;
            string strURL = ConfigurationManager.AppSettings["URL"].ToString();
            string Platform = ConfigurationManager.AppSettings["platform"].ToString();

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

            string[] UrlArr = strURL.Split('.');
            string[] whichplatformarr = UrlArr[0].Split('/');
            string whichPlatform = whichplatformarr[2];
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
            string SelectedDateFrmTab = string.Empty;
            int MaxOccupancy = 0;
            int MinOccupancy = 0;
            int NumofVillasFound = 0;
            int NumofNights = 0;
            string centerCode = string.Empty;
            List<string> VillalistIDs = new List<string>();
            List<string> VillaFullnameLst = new List<string>();
            List<string> OverviewfrmDB = new List<string>();
            List<string> ResortNamefrmDB = new List<string>();
            List<string> VillacountperResortfrmDB = new List<string>();
            InitiateSearchResultpage runScript = new InitiateSearchResultpage();
            runScript.OpenBrowser_Obj.openBrowser_Method();
            runScript.EnterURL_Obj.enterURL_Method(strURL);
            string SelectedCenter = string.Empty;
            do
            {
                if (whichPlatform.Contains("tab"))
                {
                    //SelectedCenter = runScript.selectDestfrmTab_Obj.selectDestfrmTab_Method(centreNameList);
                }
                else
                {
                    runScript.verifyDestinationListBox_Obj.verifyDestinationListBox_Method(strURL);
                    SelectedCenter = runScript.verifyDestinationListBox_Obj.selectDestination_Method(centreNameList);
                }
                centerCode = string.Empty;
                sqlQuery = "SELECT Centre  from  dbo.TblCentre where CentreName = '" + SelectedCenter + "'";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    centerCode = dataReader["Centre"].ToString();
                }   
                DateTime StartDate = System.DateTime.Today;
                List<string> DatesList = new List<String>();
                sqlQuery = "exec dbo.QAsp_GetAvailableDates @strCentre='" + centerCode + "', @StartDate='" + StartDate + "',@EndDate='03/30/2017'";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    DatesList.Add(dataReader["WeekStart"].ToString());
                }
                int NumofDatesAvaial = DatesList.Count;
                Random rnd = new Random();
                int SelectableDateindex = rnd.Next(1, NumofDatesAvaial);
                SelectableDate = Convert.ToDateTime(DatesList[SelectableDateindex - 1]);
                sqlQuery = "Select  Min(Minoccupancy), Max(MaxOccupancy) from tblvilla where Centre = '" + centerCode + "'";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    MinOccupancy = Convert.ToInt32(dataReader[0].ToString());
                    MaxOccupancy = Convert.ToInt32(dataReader[1].ToString());
                }
                if (Platform.Equals("tabletTest") || Platform.Equals("tabletLive"))
                {

                }
                else
                {
                    runScript.clickCalenderIcon_Obj.clickCalenderIcon_Method();
                    runScript.verifyCalenderDisplay_Obj.verifyCalenderDisplay_Method();
                    runScript.selectMonthFrmCalender_Obj.selectMonthFrmCalender_Method(SelectableDate);
                    runScript.selectaDateFrmCalender_Obj.selectaDateFrmCalender_Method(SelectableDate);
                    runScript.verifyDurationListBox_Obj.verifyDurationListBox_Method();
                    SelectedDuration = runScript.verifyDurationListBox_Obj.selectDuration_Method();
                    runScript.verifyAdultListBox_Obj.verifyAdultListBox_Method();
                    NumofAdults = runScript.verifyAdultListBox_Obj.selectAdults_Method(MaxOccupancy);
                    runScript.verifyChildListBox_Obj.verifyChildListBox_Method();
                    NumofChild = runScript.verifyChildListBox_Obj.selectChild_Method(MaxOccupancy);
                    runScript.verifyInfantListbox_Obj.verifyInfantListbox_Method();
                    NumofInfants = runScript.verifyInfantListbox_Obj.selectInfant_Method(NumofAdults);
                    runScript.verifyAirportListBox_Obj.verifyAirportListBox_Method();
                    SelectedAirport = runScript.verifyAirportListBox_Obj.selectAirport_Method();
                    runScript.clickSearchBtn_Obj.clickSearchBtn_Method();
                    //runScript.VerifyHeadingText_Obj.VerifyHeadingText_Method();
                }
                NumofNights = Convert.ToInt32(SelectedDuration.Trim().Replace("nights", string.Empty));
                if (Platform.Equals("tabletTest") || Platform.Equals("tabletLive"))
                {
                    SelectedDate = SelectedDateFrmTab;
                }
                else
                {
                    SelectedDate = Convert.ToString(SelectableDate.ToString("dd MMMM yyyy"));
                }

                sqlQuery = "exec QAsp_GetSearchResultDetails " + NumofNights + ",'" + centerCode + "','" + SelectedDate + "',20," + NumofAdults + "," + NumofChild + ",'ANY'";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    NumofVillasFound = Convert.ToInt32(dataReader[0].ToString());
                }
                IsNoVillasMsgDisplayed = runScript.verifyNoVillasMsgDisplayed_Obj.verifyNoVillasMsgDisplayed_Method();
            } while (IsNoVillasMsgDisplayed == true);
            runScript.verifySearchResultsPageOpened_Obj.verifySearchResultsPageOpened_Method(NumofAdults, NumofChild, NumofInfants, SelectedDuration, SelectedAirport, SelectableDate, SelectedDate, NumofVillasFound);
            string logsearchCriteria = " Destination:" + SelectedCenter + ", Date:" + SelectableDate.ToString("dd-MMM-yyyy") + ", Duration:" + NumofNights + ",  Adult:" + NumofAdults + ", Child:" + NumofChild;
            //WriteLogs("#####-#-#-# " + logsearchCriteria + " #-#-#-#####");
            string villaCount = "";
            List<string> CentersList = new List<string>();
            List<string> VillaCountFrEachCenter = new List<string>();
            List<string> ResortsList = new List<string>();
            List<string> VillaCountFrEachResort = new List<string>();
            List<string> VillaTypeList = new List<string>();
            List<string> VillaCountFrEachType = new List<string>();
            List<string> BedRoomsList = new List<string>();
            List<string> VillaCountFrEachBedRoom = new List<string>();
            List<string> VillaDetailsList = new List<string>();
            List<string> VillaCountFrEachVillaDetails = new List<string>();
            if (SelectedCenter == "ANY")
            {
                sqlQuery = "exec QAsp_GetSearchResultDetails " + NumofNights + ",'','" + SelectedDate + "',20," + NumofAdults + "," + NumofAdults + ",'ANY'";
                while (dataReader.Read())
                {
                    villaCount = dataReader[0].ToString();

                }
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    CentersList.Add(dataReader[1].ToString());
                    VillaCountFrEachCenter.Add(dataReader[2].ToString());
                }
                dataReader.NextResult();
                dataReader.NextResult();
                dataReader.NextResult();
                dataReader.NextResult();
                dataReader.NextResult();
                dataReader.NextResult();
                dataReader.NextResult();
                dataReader.NextResult();
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    BedRoomsList.Add(dataReader[1].ToString());
                    VillaCountFrEachBedRoom.Add(dataReader[2].ToString());
                }
                dataReader.NextResult();
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    VillaTypeList.Add(dataReader[1].ToString());
                    VillaCountFrEachType.Add(dataReader[2].ToString());
                }
            }
            else
            {
                sqlQuery = "exec QAsp_GetSearchResultDetails " + NumofNights + "," + "'" + centerCode + "','" + SelectedDate + "',20," + NumofAdults + "," + NumofChild + ",'ANY'";
                dataReader = getData.getData(sqlQuery, InitialCatalog);
                while (dataReader.Read())
                {
                    villaCount = dataReader[0].ToString();
                }
                dataReader.NextResult();
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    ResortsList.Add(dataReader[1].ToString());
                    VillaCountFrEachResort.Add(dataReader[2].ToString());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    VillaDetailsList.Add(dataReader[1].ToString().Trim());
                    VillaCountFrEachVillaDetails.Add(dataReader[2].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Closed to Beach//
                    VillaDetailsList.Add("Walk to beach");
                    VillaCountFrEachVillaDetails.Add(dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Closed to Restaurent//
                    VillaDetailsList.Add("Walk to shops & restaurants");
                    VillaCountFrEachVillaDetails.Add(dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Air con/heating//
                    if (!VillaDetailsList.Contains("Air con/heating"))
                    {
                        VillaDetailsList.Add("Air con/heating");
                         VillaCountFrEachVillaDetails.Add(dataReader[1].ToString().Trim());
                    }
                    else
                    {
                        //int ix = Convert.ToInt32(dataReader[1]);
                        //int iy = Convert.ToInt32(objVillaDetailValuesFrmDB["Air con/heating"]);
                        //objVillaDetailValuesFrmDB["Air con/heating"] = (ix + iy).ToString().Trim();
                    }
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Has Pool Heating//
                    VillaDetailsList.Add("Pool Heating");
                    VillaCountFrEachVillaDetails.Add(dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Gated Pools//
                    VillaDetailsList.Add("Gated Pools");
                    VillaCountFrEachVillaDetails.Add(dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
               /* while (dataReader.Read())
                {//Quality IDs//
                    VillaDetailsList.Add(dataReader[0].ToString().Trim());
                    VillaCountFrEachVillaDetails.Add(dataReader[1].ToString().Trim());
                }*/
                dataReader.NextResult();
                while (dataReader.Read())
                {//Has Wifi//
                    VillaDetailsList.Add("Wi-fi");
                    VillaCountFrEachVillaDetails.Add(dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Removable Pool Fences//
                    VillaDetailsList.Add("Pool Fence");
                    VillaCountFrEachVillaDetails.Add(dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    BedRoomsList.Add(dataReader[0].ToString());
                    VillaCountFrEachBedRoom.Add(dataReader[1].ToString());
                }
                dataReader.NextResult();
                while (dataReader.Read())
                {//Greater Selusion//
                    VillaDetailsList.Add("Greater seclusion");
                    VillaCountFrEachVillaDetails.Add(dataReader[1].ToString().Trim());
                }
                dataReader.NextResult();
                dataReader.NextResult();
                while (dataReader.Read())
                {
                    VillaTypeList.Add(dataReader[1].ToString());
                    VillaCountFrEachType.Add(dataReader[2].ToString());
                }
            }
            runScript.VerifySearchResultCriteriaText_Obj.VerifySearchResultCriteriaText_Method(villaCount);
            runScript.VerifyViewVillaBtnFrmSearchResultsPage_Obj.VerifyViewVillaBtnFrmSearchResultsPage_Method();
            string VillaName = "";
            string villablockdetails = runScript.getvillablockDetails_Obj.getvillablockDetails_Method();
            string[] Arrvillablockdetails = villablockdetails.Split(',');
            VillaName = Arrvillablockdetails[0];
            VillaName = VillaName.Replace("Villa", "").Trim();
            List<string> OverviewfrmDb = new List<string>();
            sqlQuery = "select Detail from dbo.TblVillaOverview where VillaID=(select ID from tblvilla where ShortName like'%" + VillaName + "')";
            dataReader = getData.getData(sqlQuery, InitialCatalog);
            while (dataReader.Read())
            {
                OverviewfrmDb.Add(dataReader["Detail"].ToString());
            }
            runScript.VerifyVillaOverView_Obj.VerifyVillaOverview_Method(OverviewfrmDb, villablockdetails, VillaName);
            if (SelectedCenter == "ANY" && villaCount != "0")
            {
                runScript.verifyVillaDestinationsFilter_Obj.VerifyVillaDestinationsFilter_Method(CentersList, VillaCountFrEachCenter);
            }
            else
            {
                runScript.VerifyResortsFilter_Obj.VerifyResortsFilter_Method(ResortsList, VillaCountFrEachResort);
            }
            runScript.VerifyVillaTypeFilter_Obj.VerifyVillaTypeFilter_Method(VillaTypeList, VillaCountFrEachType);
            runScript.verifyBedRoomFilter_Obj.verifyBedRoomFilter_Method(BedRoomsList,VillaCountFrEachBedRoom);
            runScript.verifyVillaDetailsFilter_Obj.verifyVillaDetailsFilter_Method(VillaDetailsList,VillaCountFrEachVillaDetails);
            runScript.verifySortByOrder_Obj.verifySortByOrder_Method();
            if (SelectedAirport.Trim() == "Villa Only")
            {
                runScript.clickIncludeFlights_Obj.clickIncludeFlights_Method();
                runScript.verifyIncludeFlightPopupDisplay_Obj.verifyIncludeFlightPopupDisplay_Method();
                //runScript.clickCloseFrmIncludeFlights_Obj.clickCloseFrmIncludeFlights_Method();
            }
            runScript.ClickViewVillaButton_Obj.ClickViewVillaButton_Method(VillaName);
            runScript.verifyProdPageOpened_Obj.verifyProdPageOpened_Method(VillaName);
        }
            //List<string> ResortNamefrmDB = new List<string>();
            //List<string> VillacountperResortfrmDB = new List<string>();
            //        string sqlquery;
            //        sqlquery = "select resortid , tblResort.FullName as ResortName, count(resortid) as villacount  from dbo.TblVilla inner join tblResort on tblResort.Id=resortid where TblVilla.Centre = '" + CenterList[i] + "' and showvilla=1 group by resortid, tblResort.FullName";
            //        datareader = getData.getData(sqlquery);
            //        ResortNamefrmDB.Clear();
            //        VillacountperResortfrmDB.Clear();

            //        while (datareader.Read())
            //        {
            //            ResortNamefrmDB.Add(datareader["ResortName"].ToString());
            //            VillacountperResortfrmDB.Add(datareader["villacount"].ToString());
            //        }

            //runScript. VerifyResortsFilter_Obj.ResortFilters_Method();
  
        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
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


