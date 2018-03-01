﻿using System;
using System.Collections;
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
    public class BookingB_VO_Online_Advice : logWriter
    {
        //Booking Flow: Home Page>> Serach Results Page using Serach Tile >> Villa Only HS page>>Pay Online using Maestro Card>> Cancel from 3D >> Advice //
        public BookingB_VO_Online_Advice()
        {
        }

        [TestMethod]
        public void BookingB_VO_Advice()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            
            #region Booking Initiation
            getFromDB getdata = new getFromDB();
            SqlDataReader dataReader = null;
            string strURL = ConfigurationManager.AppSettings["URL"].ToString();
            string Platform = ConfigurationManager.AppSettings["platform"].ToString();
            #endregion

            #region Home Page
            WriteLogs("########## START ########## Booking : On " + strURL + " " + DateTime.Now.ToString() + "##########");
            InitiateBookingBPages runScript = new InitiateBookingBPages();
            pdfCheck verifyPDF = new pdfCheck();
            runScript.OpenBrowser_Obj.openBrowser_Method();
            runScript.enterURL_Obj.enterURL_Method(strURL);
            getFromDB getData = new getFromDB();
            Boolean IsIncompletepopupDisplayed = runScript.verifyIncompleteBookingpopupDisplay_Obj.verifyIncompleteBookingpopupDisplay_Method();
            if (IsIncompletepopupDisplayed == true)
            {
                runScript.clickNOBtnFrmIncompletePopup_Obj.clickNOBtnFrmIncompletePopup_Method();
            }
            List<string> centreNameList = new List<string>();
            string sqlQuery = "SELECT centreName  from  dbo.TblCentre";
            dataReader = getData.getData(sqlQuery);
            while (dataReader.Read())
            {
                centreNameList.Add(dataReader["centreName"].ToString());
            }
            Boolean IsNoVillasMsgDisplayed = false;
            int NumofAdults = 0;
            int NumofChild = 0;
            int NumofInfants = 0;
            string SelectedDuration  = string.Empty;
            string SelectedAirport = string.Empty;
            DateTime SelectableDate = new DateTime();
            string SelectableDateforLog = string.Empty;
            string SelectedDate = string.Empty;
            string SelectedDateFrmTab = string.Empty;
            int NumofVillasFound = 0;
            int MaxOccupancy = 0;
            int MinOccupancy = 0;

            do
            {
                string SelectedCenter = string.Empty;
                if (Platform.Equals("tabletTest") || Platform.Equals("tabletLive"))
                {
                    SelectedCenter = runScript.selectDestfrmTab_Obj.selectDestfrmTab_Method(centreNameList);
                }
                else
                {
                    runScript.verifyDestinationListBox_Obj.verifyDestinationListBox_Method(strURL);
                    SelectedCenter = runScript.verifyDestinationListBox_Obj.selectDestination_Method(centreNameList);
                } 
                
                string centerCode = string.Empty;
                sqlQuery = "SELECT Centre  from  dbo.TblCentre where CentreName = '" + SelectedCenter + "'";
                dataReader = getData.getData(sqlQuery);
                while (dataReader.Read())
                {
                    centerCode = dataReader["Centre"].ToString();
                }

                sqlQuery = "Select  Min(Minoccupancy), Max(MaxOccupancy) from tblvilla where Centre = '" + centerCode + "'";
                dataReader = getData.getData(sqlQuery);
                while (dataReader.Read())
                {
                    MinOccupancy = Convert.ToInt32(dataReader[0].ToString());
                    MaxOccupancy = Convert.ToInt32(dataReader[1].ToString());
                }
                string EndDate = ConfigurationManager.AppSettings["SeasonEndDate"].ToString();

                //DateTime StartDate = System.DateTime.Today;
                string StartDate = System.DateTime.Now.ToString("MM/dd/yyyy");
                List<string> DatesList = new List<String>();
                sqlQuery = "exec dbo.QAsp_GetAvailableDates @strCentre='" + centerCode + "', @StartDate='" + StartDate + "',@EndDate='" + EndDate + "'";
                dataReader = getData.getData(sqlQuery);
                while (dataReader.Read())
                {
                    DatesList.Add(dataReader["WeekStart"].ToString());
                }

                int NumofDatesAvaial = DatesList.Count;
                Random rnd = new Random();
                int SelectableDateindex = rnd.Next(1, NumofDatesAvaial);
                SelectableDate = Convert.ToDateTime(DatesList[SelectableDateindex - 1]);
                SelectableDateforLog = "" + SelectableDate.Day + "/" + SelectableDate.Month + "/" + SelectableDate.Year + "";
                if (Platform.Equals("tabletTest") || Platform.Equals("tabletLive"))
                {
                    runScript.clickCalenderIconFrmTab_Obj.clickCalenderIconFrmTab_Method();
                    runScript.clickNextArrowFrmCalender_Obj.clickNextArrowFrmCalender_Method();
                    runScript.pickaDateFrmTabCalender_Obj.pickaDateFrmTabCalender_Method(SelectableDate);
                    SelectedDuration = runScript.enterDurationinTab_Obj.enterDurationinTab_Method();
                    runScript.clickOKfromTabCalender_Obj.clickOKfromTabCalender_Method();
                    runScript.clickPaxBoxFrmTab_Obj.clickPaxBoxFrmTab_Method();
                    NumofAdults = runScript.enterNumofAdultsinTab_Obj.enterNumofAdultsinTab_Method(MaxOccupancy);
                    NumofChild = runScript.enterNumofChildinTab_Obj.enterNumofChildinTab_Method(MaxOccupancy);
                    NumofInfants = runScript.enterNumofInfantsinTab_Obj.enterNumofInfantsinTab_Method(MaxOccupancy);
                    runScript.clickOKBtnFrmTabPaxLayer_Obj.clickOKBtnFrmTabPaxLayer_Method();
                    SelectedAirport = runScript.selectAirportFrmTab_Obj.selectAirportFrmTab_Method();
                    SelectedDateFrmTab = runScript.getSelectedDate_Obj.getSelectedDate_Method();
                    WriteLogs("PASS : Selected Search Criteria - " + SelectedCenter + ", " + SelectableDateforLog + ", " + SelectedDuration + ", " + NumofAdults + "A, " + NumofChild + "C, " + NumofInfants + "I, " + SelectedAirport + ". : VERIFICATION");
                    runScript.clickSearchBtn_Obj.clickSearchBtn_Method();
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
                    WriteLogs("PASS : Selected Search Criteria - " + SelectedCenter + ", " + SelectableDateforLog + ", " + SelectedDuration + ", " + NumofAdults + "A, " + NumofChild + "C, " + NumofInfants + "I, " + SelectedAirport + ". : VERIFICATION");
                    runScript.clickSearchBtn_Obj.clickSearchBtn_Method();

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
                            WriteLogs("PASS : Selected Search Criteria - " + SelectedCenter + ", " + SelectableDateforLog + ", " + SelectedDuration + ", " + NumofAdults + "A, " + NumofChild + "C, " + NumofInfants + "I, " + SelectedAirport + ". : VERIFICATION");
                            runScript.clickSearchBtn_Obj.clickSearchBtn_Method();
                            Ispopupdisplayed = runScript.verifyIncorrectInputPopupDisplayed_Obj.returnIncorrectInputPopupDisplayed_Method();
                        }
                    }
                }
                int NumofNights = Convert.ToInt32(SelectedDuration.Trim().Replace("nights", string.Empty));
                if (Platform.Equals("tabletTest") || Platform.Equals("tabletLive"))
                {
                    SelectedDate = SelectedDateFrmTab;
                }
                else
                {
                    SelectedDate = Convert.ToString(SelectableDate.ToString("dd MMMM yyyy"));
                }

                sqlQuery = "exec QAsp_GetSearchResultDetails " + NumofNights + ",'" + centerCode + "','" + SelectedDate + "',20," + NumofAdults + "," + NumofChild + ",'ANY'";
                dataReader = getData.getData(sqlQuery);
                while (dataReader.Read())
                {
                    NumofVillasFound = Convert.ToInt32(dataReader[0].ToString());
                }
                IsNoVillasMsgDisplayed = runScript.verifyNoVillasMsgDisplayed_Obj.verifyNoVillasMsgDisplayed_Method();
            } while (IsNoVillasMsgDisplayed == true);
            runScript.verifySearchResultsPageOpened_Obj.verifySearchResultsPageOpened_Method(NumofAdults, NumofChild, NumofInfants, SelectedDuration, SelectedAirport, SelectableDate, SelectedDate, NumofVillasFound);
            Boolean islinkavaialable = runScript.clickVillaNFlightsLinkFrmSearchResultsPage_Obj.checkiflinkavaialable();
            if (islinkavaialable != true)
            {
                runScript.clickBookVillaOnlyLINKFrmSRPage_Obj.clickBookVillaOnlyLINKFrmSRPage_Method();
            }
            else
            {
                runScript.clickBookVillaOnlyBTNFrmSRPage_Obj.clickBookVillaOnlyBTNFrmSRPage_Method();
            }
            #endregion

            #region Holiday Summary Page
            //*****Opening HS VO Page*****//
            string BookingID = runScript.verifyHSPKOpened_Obj.getBookingID(strURL);
            BookingID = BookingID.TrimStart('"');
            BookingID = BookingID.TrimEnd('"');

            //*****Getting VillaID for this Booking*****//
            string villaID = "";

            sqlQuery = "select VillaID from Booking.Villapack where BookID = " + BookingID;
            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                villaID = dataReader[0].ToString();
            }

            //*****Getting Required Values for Car Hire from DB*****//
            int CarReqid = 0;
            string villaFullName = string.Empty;
            MaxOccupancy = 0;
            int QualityID = 0;

            sqlQuery = "select CarReqid, FullName,MaxOccupancy,QualityID from dbo.TblVilla where id = " + villaID;
            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                CarReqid = Convert.ToInt32(dataReader[0].ToString());
                villaFullName = dataReader[1].ToString();
                MaxOccupancy = Convert.ToInt32(dataReader[2].ToString());
                QualityID = Convert.ToInt32(dataReader[3].ToString());
            }

            runScript.verifyHSPKOpened_Obj.verifyHSPKOpened_Method(villaFullName, BookingID);
            takeImage(BookingID + "_HSPage");
            WriteLogs("---------- START ---------- Booking ID : " + BookingID + " : " + DateTime.Now.ToString() + "----------");
            //*****Verifying Default values/Text of each section in HS PK Page*****//
            int id = 0;
            string fl_retdate = "";
            string fl_depdate = "";
            int Nights = 0;
            string Flightid = "";
            string FlightType = "";
            string FlightNo_OB = "";
            string DepTime_OB = "";
            string Arrtime_OB = "";
            string FlightNo_IB = "";
            string DepTime_IB = "";
            string ArrTime_IB = "";
            decimal AdultRate = 0;
            decimal ChildRate = 0;
            decimal InfantRate = 0;
            decimal flAdultRate = 0;
            decimal flChildRate = 0;
            decimal Lineprice = 0;
            decimal FabTotalPrice = 0;
            decimal FlightTotalPrice = 0;
            string DepPort_OB = "";
            string ArrPort_OB = "";
            string OutBoundFlightOperatedBy = "";
            string Deport_OB_Name = "";
            string ArrPort_OB_Name = "";
     
            //*****Retriveing Flight, Flight Extra and Villa Extra Details from DB*****//
            sqlQuery = "exec QAsp_GetFlightDetails " + BookingID;

            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                id = Convert.ToInt32(dataReader[0].ToString());
                fl_retdate = Convert.ToDateTime(dataReader[1]).ToString("dd MMM yyyy").ToString();
                fl_depdate = Convert.ToDateTime(dataReader[2]).ToString("dd MMM yyyy").ToString();
                Nights = Convert.ToInt32(dataReader[3].ToString());
                Flightid = dataReader[4].ToString();
                FlightType = dataReader[5].ToString();
                FlightNo_OB = dataReader[6].ToString();
                DepTime_OB = dataReader[7].ToString();
                Arrtime_OB = dataReader[8].ToString();
                FlightNo_IB = dataReader[9].ToString();
                DepTime_IB = dataReader[10].ToString();
                ArrTime_IB = dataReader[11].ToString();
                AdultRate = Convert.ToDecimal(dataReader[12]);
                ChildRate = Convert.ToDecimal(dataReader[13]);
                InfantRate = Convert.ToDecimal(dataReader[14]);
                flAdultRate = Convert.ToDecimal(dataReader[15]);
                flChildRate = Convert.ToDecimal(dataReader[16]);
                Lineprice = Convert.ToDecimal(dataReader[17]);
                FabTotalPrice = Convert.ToDecimal(dataReader[18]);
                FlightTotalPrice = Convert.ToDecimal(dataReader[19]);
                DepPort_OB = dataReader[20].ToString();
                ArrPort_OB = dataReader[21].ToString();
                OutBoundFlightOperatedBy = dataReader[22].ToString();
                Deport_OB_Name = dataReader[23].ToString();
                ArrPort_OB_Name = dataReader[24].ToString();
            }

            //*****Getting Required Values for VO Booking*****//
            string LineType0 = string.Empty;

            sqlQuery = "select LineType from Booking.VillaPack where Bookid=" + BookingID;
            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                LineType0 = dataReader[0].ToString();
            }

            //*****Retriveing Villa Extras count and Details from DB*****//
            int VExtrascount = 0;
            sqlQuery = "SELECT count(*) FROM [Booking].[ExtraBooked] WHERE Type = 'V' and Lineid in (SELECT  id FROM [Booking].[VillaPack] WHERE bookid=" + BookingID + ")";

            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                VExtrascount = Convert.ToInt32(dataReader[0].ToString());
            }
            string VExtrasFrmDB = string.Empty;
            List<string> ListofVExtrasFrmDB = new List<string>();
            sqlQuery = "SELECT Invoicedesc FROM [Booking].[ExtraBooked] WHERE Type = 'V' and Lineid in (SELECT  id FROM [Booking].[VillaPack] WHERE bookid=" + BookingID + ")";

            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                VExtrasFrmDB = dataReader[0].ToString();
                ListofVExtrasFrmDB.Add(VExtrasFrmDB);
            }

            //*****Retriveing ADW and ATOL Price Details from DB*****//

            decimal AdwRate = 0;
            sqlQuery = "Select LinePrice from Booking.ADW where Bookid=" + BookingID;
            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                AdwRate = Convert.ToDecimal(dataReader[0].ToString());
            }

            decimal ATOLRate = 0;
            sqlQuery = "Select LinePrice from Booking.ATOL where Bookid=" + BookingID;
            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                ATOLRate = Convert.ToDecimal(dataReader[0].ToString());
            }

            //*****Retriveing Total Holiday & Deposit Details from DB*****//
            decimal TotalPrice = 0;
            decimal Deposit = 0;
            string BalanceDueDate = string.Empty;
            string BookDate = string.Empty;
            string DepDate = string.Empty;

            sqlQuery = "SELECT TotalPrice,Deposit,BalanceDue,BookDate,DepDate FROM Booking.Bookings WHERE BookId=" + BookingID;
            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                TotalPrice = Convert.ToDecimal(dataReader[0].ToString());
                Deposit = Convert.ToDecimal(dataReader[1].ToString());
                BalanceDueDate = Convert.ToDateTime(dataReader[2]).ToString("dd MMM yyyy").ToString();
                BookDate = Convert.ToDateTime(dataReader[3]).ToString("dd MMM yyyy").ToString();
                DepDate = Convert.ToDateTime(dataReader[4]).ToString("dd MMM yyyy").ToString();
            }
            string VODetailsFrmPageForPDF = runScript.verifyVODetails_Obj.verifyVODetails_Method(Nights, fl_retdate, fl_depdate, villaFullName);
            string flttypeSupptxt = "N/A";
            string PDFretdate = fl_retdate;
            string PDFdepdate = fl_depdate;
            string PDFDeport = "N/A";
            string PDFArrport = "N/A";
            string PDFDeptime = "N/A";
            string PDFArrtime = "N/A";
            string VODetailsFrmPage = VODetailsFrmPageForPDF.Replace(" ", string.Empty);

            runScript.verifyVOPrice_Obj.verifyVOPrice_Method(Lineprice);
            runScript.verifyVExtraDfltTxt_Obj.verifyVExtraDfltTxt_Method(QualityID, NumofAdults, NumofChild, NumofInfants, MaxOccupancy, LineType0);
            runScript.verifyCarDefaultText_Obj.verifyCarDefaultText_Method(CarReqid, villaFullName);
            runScript.verifyTransferDfltTxt_obj.verifyTransferDfltTxt_Method();
            runScript.verifyInsuranceDfltTxt_obj.verifyInsuranceDfltTxt_Method();
            runScript.verifyADWDfltTxt_Obj.verifyADWDfltTxt_Method(LineType0);
            runScript.verifyTotalHolCost_Obj.verifyTotalHolCost_Method(TotalPrice);
            Boolean IsPopupwithOKshown = false;
            Boolean BkgstrtsfromSearchTile = true;
            int ADultsSelection = NumofAdults;
            int ChildSelection = NumofChild;
            string PriceDepPPPDetailsFromHSPageRegEx = runScript.verifyDepositDetails_Obj.verifyDepositDetails_Method(TotalPrice, Deposit, BalanceDueDate, BookDate, DepDate, AdultRate, ChildRate, InfantRate, AdwRate, ATOLRate, IsPopupwithOKshown, ADultsSelection, ChildSelection,NumofInfants,LineType0,BkgstrtsfromSearchTile);
            #endregion

            #region LeadPax Page
            //*****Verification of Lead Pax Page*****//
            runScript.clickConitueButton_Obj.clickConitueButton_Method(strURL);
            runScript.verifyFlightInfoPopupOpened_Obj.verifyFlightInfoPopupOpened_Method();
            runScript.clickLaterFrmFlightInfoPopup_Obj.clickLaterFrmFlightInfoPopup_Method();
            runScript.verifyLeadPaxPageOpenedForVO_Obj.verifyLeadPaxPageOpenedForVO_Method();
            string LeadFullName = runScript.enteringLeadPaxDetails_Obj.enteringLeadPaxDetails_Method(Platform);
            runScript.getPostCodeDetails_Obj.getPostCodeDetails_Method(strURL);
            runScript.verifyAddressListPopUp_Obj.verifyAddressListPopUp_Method();
            runScript.selectAddressFromList_Obj.selectAddressFromList_Method();
            runScript.clickSubmitFromAdrsPopup_Obj.clickSubmitFromAdrsPopup_Method(strURL);
            takeImage(BookingID + "_LeadPax");
            runScript.clickNextFrmLeadPaxPage_Obj.clickNextFrmLeadPaxPage_Method();
            Boolean isOtherPaxOpened = runScript.verifyOtherPaxPageOpened_Obj.CheckifOtherPaxPageOpened_Method();
            while (isOtherPaxOpened == false)
            {
                Boolean IsAnotherBookingFound = runScript.verifyAnotherBkfnd_Obj.verifyAnotherBkfnd_Method();
                if (IsAnotherBookingFound == true)
                {
                    runScript.clickNoFrmAnotherBooking_Obj.clickNoFrmAnotherBooking_Method();
                    runScript.clickBackBtnFrmOtherPax_Obj.clickBackBtnFrmOtherPax_Method();
                    runScript.verifyLeadPaxPageOpenedForVO_Obj.verifyLeadPaxPageOpenedForVO_Method();
                    runScript.enteringLeadPaxDetails_Obj.ChangingEMAILIDsFrmLeadPax_Method();
                    runScript.clickNextFrmLeadPaxPage_Obj.clickNextFrmLeadPaxPage_Method();
                }
                isOtherPaxOpened = runScript.verifyOtherPaxPageOpened_Obj.CheckifOtherPaxPageOpened_Method();
            }
            #endregion

            #region OtherPax Page
            //*****Verification of Other Pax Page*****//
            runScript.verifyOtherPaxPageOpenedForVO_Obj.verifyOtherPaxPageOpenedForVO_Method();

            //*****Selecting Titles for Adults in Other Pax Page*****//
            HtmlComboBox uIDdlAdultMrComboBox = runScript.enteringTestDataInOtherPaxPage_Obj.getAdultTitleCombo_Method();
            UITestControlCollection ui = uIDdlAdultMrComboBox.FindMatchingControls();
            string AdultTitle = uIDdlAdultMrComboBox.InnerText;
            string[] myAdultTitle = AdultTitle.Split(' ');
            foreach (HtmlComboBox combo in ui)
            {
                combo.SelectedItem = myAdultTitle[new Random().Next(0, 4)];
            }

            //*****Entering First Names for Adults in Other Pax Page*****//
            HtmlEdit uITxtAdultFNameEdit = runScript.enterAdultFNames_Obj.getAdultFNames_Method();
            UITestControlCollection AdultFnames = uITxtAdultFNameEdit.FindMatchingControls();
            char forFname = 'B';
            foreach (HtmlEdit Edit in AdultFnames)
            {
                Edit.Text = "Test Adult FName" + forFname;
                forFname++;
            }

            //*****Entering Last Names for Adults in Other Pax Page*****//
            HtmlEdit uITxtAdultLNameEdit = runScript.enterAdultLnames_Obj.getAdultLnames_Method();
            UITestControlCollection AdultLNames = uITxtAdultLNameEdit.FindMatchingControls();
            foreach (HtmlEdit Edit in AdultLNames)
            {
                Edit.Text = "Test Adult LName";
            }

            //*****Selecting Titles for Child in Other Pax Page*****//
            if (NumofChild > 0)
            {
                HtmlComboBox uIDdlChildMrComboBox = runScript.selectChildTitleCombo_Obj.getChildTitleCombo_Method();
                UITestControlCollection ChildTitles = uIDdlChildMrComboBox.FindMatchingControls();
                string ChildTitleOptions = uIDdlChildMrComboBox.InnerText;
                string[] myChildTitle = ChildTitleOptions.Split(' ');
                foreach (HtmlComboBox Ccombo in ChildTitles)
                {
                    Ccombo.SelectedItem = myChildTitle[new Random().Next(1)];
                }

                //*****Entering First Names for Child in Other Pax Page*****//
                HtmlEdit uITxtChildFNameEdit = runScript.enterChildFNames_Obj.getChildFNames_Method();
                UITestControlCollection ChildFname = uITxtChildFNameEdit.FindMatchingControls();
                char CforFname = 'B';
                foreach (HtmlEdit Edit in ChildFname)
                {
                    Edit.Text = "Test FName" + CforFname;
                    CforFname++;
                }

                //*****Entering Last Names for Child in Other Pax Page*****//
                HtmlEdit uITxtChildLNameEdit = runScript.enterChildLNames_Obj.getChildLNames_Method();
                UITestControlCollection ChildLNames = uITxtChildLNameEdit.FindMatchingControls();
                foreach (HtmlEdit Edit in ChildLNames)
                {
                    Edit.Text = "Test Child LName";
                }
            }

            //*****Selecting Titles for Infants in Other Pax Page*****//
            if (NumofInfants > 0)
            {
                HtmlComboBox uIDdlInfantMrComboBox = runScript.selectInfantTitleCombo_Obj.getInfantTitleCombo_Method();
                UITestControlCollection InfantTitleCombos = uIDdlInfantMrComboBox.FindMatchingControls();
                string ITitleOptions = uIDdlInfantMrComboBox.InnerText;
                string[] MyItitles = ITitleOptions.Split(' ');
                foreach (HtmlComboBox select in InfantTitleCombos)
                {
                    select.SelectedItem = MyItitles[new Random().Next(2)];
                }

                //*****Entering First Names for Infants in Other Pax Page*****//
                HtmlEdit uITxtInfantFNameEdit = runScript.enterInfantFNames_Obj.getInfantFNames_Method();
                UITestControlCollection IFnames = uITxtInfantFNameEdit.FindMatchingControls();
                char IforFName = 'B';
                foreach (HtmlEdit select in IFnames)
                {
                    select.Text = "Test Infant FName" + IforFName;
                    IforFName++;
                }

                //*****Entering Last Names for Infants in Other Pax Page*****//
                HtmlEdit uITxtInfantLNameEdit = runScript.enterInfantLNames_Obj.getInfantLNames_Method();
                UITestControlCollection ILNames = uITxtInfantLNameEdit.FindMatchingControls();
                foreach (HtmlEdit edit in ILNames)
                {
                    edit.Text = "Test Infant LName";
                }
            }
            takeImage(BookingID + "_OtherPax");
            runScript.clickNextFrmOtherPaxPage_Obj.clickNextFrmOtherPaxPage_Method(strURL);
            #endregion

            #region ProVConf Page
            //*****Verification of Prov Conf Page*****//
            runScript.verifyProvConfPageOpened_Obj.verifyProvConfPageOpened_Method();
            takeImage(BookingID + "_ProvConf");

            decimal SecurtyDeposit = 0;
            sqlQuery = "Select LinePrice from Booking.ADW where Bookid=" + BookingID;
            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                SecurtyDeposit = Convert.ToDecimal(dataReader[0].ToString());
            }
            runScript.verifyTotalDepositPPPDetailsonProvConfPage_Obj.verifyTotalDepositPPPDetailsonProvConfPage_Method(PriceDepPPPDetailsFromHSPageRegEx, AdwRate, SecurtyDeposit, NumofAdults, NumofChild, NumofInfants, TotalPrice);
            runScript.clickBookingCondCheckBox_Obj.clickBookingCondCheckBox_Method(strURL);
            runScript.clickOKFromBookingCondPopup_Obj.clickOKFromBookingCondPopup_Method();
            Boolean IsPayOnlineBtnAvaial = runScript.clickPayOnlineButton_Obj.IsPayOnlineBtnAvaial_Method();
            #endregion

            #region PayOnline Page
            Boolean IsPhoneBtnClicked = false;
            if (IsPayOnlineBtnAvaial == true)
            {
                if (Platform.Equals("tabletLive") || Platform.Equals("tabletTest"))
                {
                    runScript.clickPayOnlineButton_Obj.clickPayOnlineButton_Method(Platform);
                    runScript.clickContinueBtnforOnline_Obj.clickContinueBtnforOnline_Method();
                    Boolean IsTLSpopupdisplayed = runScript.VerifyTLSpopupdisplayed_obj.VerifyTLSpopupdisplayed_method();
                    if (IsTLSpopupdisplayed == true)
                    {
                        runScript.clickcontinuefromTLSpopup_obj.ClickcontinueonTLSpopup_Method();
                    }
                }
                else
                {
                    runScript.clickPayOnlineButton_Obj.clickPayOnlineButton_Method(Platform);
                    Boolean IsTLSpopupdisplayed = runScript.VerifyTLSpopupdisplayed_obj.VerifyTLSpopupdisplayed_method();
                    if (IsTLSpopupdisplayed == true)
                    {
                        runScript.clickcontinuefromTLSpopup_obj.ClickcontinueonTLSpopup_Method();
                    }
                } 
                takeImage(BookingID + "_PayOnline");

                //*****Verification of Pay Online Page*****//
                string AddressDetails = ConfigurationManager.AppSettings["CardMaestroAdd"].ToString();
                string[] AddDetailsArr = AddressDetails.Split(',');
                runScript.verifyPayOnlinePagedisplay_Obj.verifyPayOnlinePagedisplay_Method(strURL);
                runScript.clickEditAddressBtn_Obj.clickEditAddressBtn_Method();
                runScript.selectCountry_Obj.VerifyCountryBoxEnabled_Method();
                runScript.selectCountry_Obj.selectCountry_Method(AddDetailsArr[0]);
                runScript.enterStreet_Obj.enterStreet_Method(AddDetailsArr[1]);
                runScript.enterTownCity_Obj.enterTownCity_Method(AddDetailsArr[2]);
                runScript.enterPostCode_Obj.enterPostCode_Method(AddDetailsArr[3]); 
                HtmlComboBox uIDrpCardTypeComboBox = runScript.selectCardType_Obj.getCardType_Method();
                string cardDetails = ConfigurationManager.AppSettings["CardMaestro"].ToString();
                string[] cardDetailsArr = cardDetails.Split(',');
                for (int j = 1; j < uIDrpCardTypeComboBox.ItemCount; j++)
                {
                    uIDrpCardTypeComboBox.SelectedIndex = j;
                    if (uIDrpCardTypeComboBox.SelectedItem.StartsWith(cardDetailsArr[0]))
                    {
                        break;
                    }
                }
                runScript.enterCardNumber_Obj.enterCardNumber_Method(cardDetailsArr[1]);
                runScript.selectExpiryYear_Obj.selectExpiryYear_Method();
                runScript.selectExpiryMonth_Obj.selectExpiryMonth_Method();
                runScript.selectStartYear_Obj.selectStartYear_Method();
                runScript.selectStartMonth_Obj.selectStartMonth_Method();
                runScript.enterSecurityCode_Obj.enterSecurityCode_Method(cardDetailsArr[2]);
                runScript.clickMakePaymentBtn_Obj.clickMakePaymentBtn_Method(strURL);
                Boolean IserrPageshown = runScript.isCertErrPageshown_Obj.getCertErrPageshown_Method();
                if (IserrPageshown == true)
                {
                    runScript.clickContinueFrmCertiErrPage_Obj.clickContinueFrmCertiErrPage_Method();
                    runScript.clickCancelLinkFrm3DPage_Obj.clickCancelLinkFrm3DPage_Method();
                    runScript.verifyAnyErrMsgDispayed_Obj.verifyAnyErrMsgDispayed_Method();
                    runScript.clickPaybyPhoneonPayment_Obj.verifyPaybyPhoneBtnDisplayedOnPaymentPage_Method();
                    if (Platform.Equals("tabletLive") || Platform.Equals("tabletTest"))
                    {
                        runScript.clickPaybyPhoneonPayment_Obj.clickPaybyPhoneonPayment_Method(Platform);
                    }
                    else
                    {
                        runScript.clickPaybyPhoneonPayment_Obj.clickPaybyPhoneonPayment_Method(Platform);
                    } 

                    WriteLogs("INFO : As Error Message has shown, Pay By Phone Button From Payment has been clicked.");
                }
                else if (IserrPageshown == false)
                {
                    Boolean Is3DPageOpened = runScript.clickSubmitFrm3D_Obj.Is3DPageOpened_Method();
                    Boolean isAsh3DPage = runScript.verifyAshTest3DpageOpened_Obj.verifyAshTest3DpageOpened_Method();

                    if (Is3DPageOpened == true)
                    {
                        runScript.clickCancelLinkFrm3DPage_Obj.clickCancelLinkFrm3DPage_Method();
                        runScript.clickPaybyPhoneonPayment_Obj.verifyPaybyPhoneBtnDisplayedOnPaymentPage_Method();
                        takeImage(BookingID + "_ErrOnMkPaymentClk");
                        if (Platform.Equals("tabletLive") || Platform.Equals("tabletTest"))
                        {
                            runScript.clickPaybyPhoneonPayment_Obj.clickPaybyPhoneonPayment_Method(Platform);
                        }
                        else
                        {
                            runScript.clickPaybyPhoneonPayment_Obj.clickPaybyPhoneonPayment_Method(Platform);
                        } 
                        WriteLogs("INFO : As Error Message has shown, Pay By Phone Button From Payment Page has been clicked.");
                    }
                    else if (isAsh3DPage == true)
                    {
                        runScript.verifyAshTest3DpageOpened_Obj.enterPWDinAshTest3Dpage_Method(cardDetailsArr[4]);
                        runScript.clickSubmitFrmAshTst3DPge_Obj.clickSubmitFrmAshTst3DPge_Method();
                    }
                    else
                    {
                        Boolean AnyErrMsg = runScript.verifyAnyErrMsgDispayed_Obj.verifyAnyErrMsgDispayed_Method();
                        if (AnyErrMsg == true)
                        {
                            takeImage(BookingID + "_ErrOnMkPaymentClk");
                            if (Platform.Equals("tabletLive") || Platform.Equals("tabletTest"))
                            {
                                runScript.clickPaybyPhoneonPayment_Obj.clickPaybyPhoneonPayment_Method(Platform);
                            }
                            else
                            {
                                runScript.clickPaybyPhoneonPayment_Obj.clickPaybyPhoneonPayment_Method(Platform);
                            } 
                            WriteLogs("INFO : As Error Message has shown, Pay By Phone Button From Payment Page has been clicked.");
                        }
                    }
                }
            }
            else
            {
                if (Platform.Equals("tabletLive") || Platform.Equals("tabletTest"))
                {
                    runScript.clickPayByPhoneButton_Obj.clickPayByPhoneButton_Method(Platform);
                    runScript.clickContinueBtnforPhone_Obj.clickContinueBtnforPhone_Method();
                }
                else
                {
                    runScript.clickPayByPhoneButton_Obj.clickPayByPhoneButton_Method(Platform);
                } 
                WriteLogs("INFO : As Pay Online Button Not Available, Pay By Phone Button has been clicked.");
            }
            #endregion

            #region ThankYou Page
            //*****Verification of Thank You Page*****//
            runScript.verifyThankYouRefPopupdisplay_Obj.verifyThankYouRefPopupdisplay_Method();
            runScript.selectRefFromList_Obj.selectRefFromList_Method(strURL);
            runScript.clickNextfrmThankYouRefPopup_Obj.clickNextfrmThankYouRefPopup_Method();
            runScript.verifyBookingRefTextDisplay_Obj.verifyBookingRefTextDisplay_Method(BookingID, IsPhoneBtnClicked, IsPayOnlineBtnAvaial, LineType0);
            takeImage(BookingID + "_ThankYou");
            runScript.verifyTotalDepositPPPThankYouPage_Obj.verifyTotalDepositPPPThankYouPage_Method(PriceDepPPPDetailsFromHSPageRegEx);
            #endregion

            #region Verifying DB details After Booking - With Email Queuing OFF
            //*****Verification of DB Updates after completion of Booking*****//

            string EMAILQueuing = ConfigurationManager.AppSettings["EMAILQueuing"].ToString();
            string Ref = string.Empty;
            double CCRatePhone = 0;
            double CCRateWeb = 0;
            double ApplCCRate = 0;
            string BKBookingStage = string.Empty;
            string BKStatus = string.Empty;
            string WSStatus = string.Empty;
            string WsSender = string.Empty;
            string MailStatus = string.Empty;
            string ATOLStatus = string.Empty;
            string BookingConVersion = string.Empty;
            string UsefulInfoVersion = string.Empty;
            string HealthSafetyVersion = string.Empty;
            string WebTOUVersion = string.Empty;
            string BookingTerms = string.Empty;
            string WheelChairAsst = string.Empty;
            string InsDocsbyPost = string.Empty;
            string AlertMsg = string.Empty;

            if (EMAILQueuing == "OFF")
            {
                int Bookid = 0;
                string LineType = string.Empty;
                string VPStatus = string.Empty;
                string VPBookingStage = string.Empty;

                sqlQuery = "SELECT Bookid,LineType,Status,BookingStage FROM booking.villapack  WHERE BookId= " + BookingID;

                dataReader = getdata.getData(sqlQuery);
                while (dataReader.Read())
                {
                    Bookid = Convert.ToInt32(dataReader[0].ToString());
                    LineType = dataReader[1].ToString();
                    VPStatus = dataReader[2].ToString();
                    VPBookingStage = dataReader[3].ToString();
                }
                sqlQuery = "SELECT Ref,CCRatePhone,CCRateWeb,ApplCCRate,BookingStage,Status,WSStatus,WsSender,MailStatus,ATOLStatus,BookingConVersion,UsefulInfoVersion,HealthSafetyVersion,WebTOUVersion,BookingTerms,WheelChairAsst,AlertMessage FROM Booking.Bookings WHERE BookId=" + BookingID;

                dataReader = getdata.getData(sqlQuery);
                while (dataReader.Read())
                {
                    Ref = dataReader[0].ToString();
                    CCRatePhone = Convert.ToDouble(dataReader[1].ToString());
                    CCRateWeb = Convert.ToDouble(dataReader[2].ToString());
                    ApplCCRate = Convert.ToDouble(dataReader[3].ToString());
                    BKBookingStage = dataReader[4].ToString();
                    BKStatus = dataReader[5].ToString();
                    WSStatus = dataReader[6].ToString();
                    WsSender = dataReader[7].ToString();
                    MailStatus = dataReader[8].ToString();
                    ATOLStatus = dataReader[9].ToString();
                    BookingConVersion = dataReader[10].ToString();
                    UsefulInfoVersion = dataReader[11].ToString();
                    HealthSafetyVersion = dataReader[12].ToString();
                    WebTOUVersion = dataReader[13].ToString();
                    BookingTerms = dataReader[14].ToString();
                    WheelChairAsst = dataReader[15].ToString();
                    AlertMsg = dataReader[16].ToString();
                    //InsDocsbyPost = Convert.ToInt32(dataReader[16].ToString());
                }

                Hashtable hashtable = new Hashtable();
                hashtable.Add("LineType", LineType);
                hashtable.Add("VPStatus", VPStatus);
                hashtable.Add("VPBookingStage", VPBookingStage);
                hashtable.Add("ApplCCRate", ApplCCRate);
                hashtable.Add("BKBookingStage", BKBookingStage);
                hashtable.Add("BKStatus", BKStatus);
                hashtable.Add("WSStatus", WSStatus);
                hashtable.Add("WsSender", WsSender);
                hashtable.Add("MailStatus", MailStatus);
                hashtable.Add("ATOLStatus", ATOLStatus);
                hashtable.Add("BookingTerms", BookingTerms);
                hashtable.Add("WheelChairAsst", WheelChairAsst);
                hashtable.Add("AlertMessage", AlertMsg);
                double ExpectedApplCCRate = 0;
                if (IsPayOnlineBtnAvaial == true && BKBookingStage == "Costing")
                {
                    ExpectedApplCCRate = 0.025;
                }
                else
                { 
                    ExpectedApplCCRate = 0.020; 
                }   
                Hashtable Exphashtable = new Hashtable();
                Exphashtable.Add("LineType", "Villa-On");
                Exphashtable.Add("VPStatus", "OK");
                Exphashtable.Add("VPBookingStage", "Booking");
                Exphashtable.Add("ApplCCRate", ExpectedApplCCRate);
                Exphashtable.Add("BKBookingStage", "Booking");
                Exphashtable.Add("BKStatus", "OK");
                Exphashtable.Add("WSStatus", "Optioned");
                Exphashtable.Add("WsSender", "WebSite");
                Exphashtable.Add("MailStatus", "PDF Mail");
                Exphashtable.Add("ATOLStatus", "NA");
                Exphashtable.Add("BookingTerms", "True");
                Exphashtable.Add("WheelChairAsst", "False");
                Exphashtable.Add("AlertMessage", "");
                foreach (string key in hashtable.Keys)
                {
                    if (hashtable[key].ToString().Trim().Equals(Exphashtable[key].ToString().Trim()))
                    {
                        WriteLogs("PASS : " + key + " is as Expected = " + hashtable[key].ToString());
                    }
                    else if (VPBookingStage == "Costing" && BKBookingStage == "Costing")
                    {
                        WriteLogs("INFO : Pay Online Was not Avaialable Booking Done using Phone button, so " + key + " is as Expected = " + hashtable[key].ToString());
                    }
                    else
                    {
                        WriteLogs("FAIL : " + key + " is Not as Expected, it should be " + Exphashtable[key].ToString());
                    }
                }
            }
            #endregion

            #region DBVerification After Booking - With Email Queuing ON
            else
            {
                //*****Verification of DB Updates after completion of Booking*****//
                int Bookid = 0;
                string LineType = string.Empty;
                string VPStatus = string.Empty;
                string VPBookingStage = string.Empty;

                sqlQuery = "SELECT Bookid,LineType,Status,BookingStage FROM booking.villapack  WHERE BookId= " + BookingID;

                dataReader = getdata.getData(sqlQuery);
                while (dataReader.Read())
                {
                    Bookid = Convert.ToInt32(dataReader[0].ToString());
                    LineType = dataReader[1].ToString();
                    VPStatus = dataReader[2].ToString();
                    VPBookingStage = dataReader[3].ToString();
                }
                sqlQuery = "SELECT Ref,CCRatePhone,CCRateWeb,ApplCCRate,BookingStage,Status,WSStatus,WsSender,MailStatus,ATOLStatus,BookingConVersion,UsefulInfoVersion,HealthSafetyVersion,WebTOUVersion,BookingTerms,WheelChairAsst,AlertMessage FROM Booking.Bookings WHERE BookId=" + BookingID;

                dataReader = getdata.getData(sqlQuery);
                while (dataReader.Read())
                {
                    Ref = dataReader[0].ToString().Trim();
                    CCRatePhone = Convert.ToDouble(dataReader[1].ToString());
                    CCRateWeb = Convert.ToDouble(dataReader[2].ToString());
                    ApplCCRate = Convert.ToDouble(dataReader[3].ToString());
                    BKBookingStage = dataReader[4].ToString();
                    BKStatus = dataReader[5].ToString();
                    WSStatus = dataReader[6].ToString();
                    WsSender = dataReader[7].ToString();
                    MailStatus = dataReader[8].ToString();
                    ATOLStatus = dataReader[9].ToString();
                    BookingConVersion = dataReader[10].ToString();
                    UsefulInfoVersion = dataReader[11].ToString();
                    HealthSafetyVersion = dataReader[12].ToString();
                    WebTOUVersion = dataReader[13].ToString();
                    BookingTerms = dataReader[14].ToString();
                    WheelChairAsst = dataReader[15].ToString();
                    AlertMsg = dataReader[16].ToString();
                }

                Boolean MSMQMailStatus = false;
                Boolean BookingPDF = false;
                string ATOLPDF = string.Empty;
                Boolean WheelChairPDF = false;
                Boolean VPInsurance = false;
                Boolean BOAlert = false;
                Boolean InfoMailsentToCust = false;
                Boolean IsDataSentBacktoMSMQ = false;

                sqlQuery = "SELECT MailStatus,BookingPDF,ATOLPDF,WheelChairPDF,VPInsurance,BOAlert,InfoMailsentToCust,IsDataSentBacktoMSMQ from msmqemailrecords where Bookingid=" + BookingID;

                dataReader = getdata.getData(sqlQuery);
                while (dataReader.Read())
                {
                    MSMQMailStatus = Convert.ToBoolean(dataReader[0]);
                    BookingPDF = Convert.ToBoolean(dataReader[1].ToString());
                    ATOLPDF = dataReader[2].ToString();
                    WheelChairPDF = Convert.ToBoolean(dataReader[3].ToString());
                    VPInsurance = Convert.ToBoolean(dataReader[4].ToString());
                    BOAlert = Convert.ToBoolean(dataReader[5].ToString());
                    InfoMailsentToCust = Convert.ToBoolean(dataReader[6].ToString());
                    IsDataSentBacktoMSMQ = Convert.ToBoolean(dataReader[7].ToString());
                }

                Hashtable hashtable = new Hashtable();
                hashtable.Add("LineType", LineType);
                hashtable.Add("VPStatus", VPStatus);
                hashtable.Add("VPBookingStage", VPBookingStage);
                hashtable.Add("ApplCCRate", ApplCCRate);
                hashtable.Add("BKBookingStage", BKBookingStage);
                hashtable.Add("BKStatus", BKStatus);
                hashtable.Add("WSStatus", WSStatus);
                hashtable.Add("WsSender", WsSender);
                hashtable.Add("MailStatus", MailStatus);
                hashtable.Add("ATOLStatus", ATOLStatus);
                hashtable.Add("BookingTerms", BookingTerms);
                hashtable.Add("WheelChairAsst", WheelChairAsst);
                hashtable.Add("MSMQMailStatus", MSMQMailStatus);
                hashtable.Add("BookingPDF", BookingPDF);
                hashtable.Add("ATOLPDF", ATOLPDF);
                hashtable.Add("WheelChairPDF", WheelChairPDF);
                hashtable.Add("VPInsurance", VPInsurance);
                hashtable.Add("BOAlert", BOAlert);
                hashtable.Add("InfoMailsentToCust", InfoMailsentToCust);
                hashtable.Add("IsDataSentBacktoMSMQ", IsDataSentBacktoMSMQ);
                hashtable.Add("AlertMessage", AlertMsg);
                double ExpectedApplCCRate = 0;
                if (IsPayOnlineBtnAvaial == true && BKBookingStage == "Costing")
                {
                    ExpectedApplCCRate = 0.025;
                }
                else
                {
                    ExpectedApplCCRate = 0.020;
                }
                string ExpMailStatus = string.Empty;
                string ExpATOLStatus = string.Empty;
                string[] UrlArr = strURL.Split('.');
                string[] whichplatformarr = UrlArr[0].Split('/');
                string whichPlatform = whichplatformarr[2];
                ExpMailStatus = "Queued";
                Hashtable Exphashtable = new Hashtable();
                Exphashtable.Add("LineType", "Villa-On");
                Exphashtable.Add("VPStatus", "OK");
                Exphashtable.Add("VPBookingStage", "Booking");
                Exphashtable.Add("ApplCCRate", ExpectedApplCCRate);
                Exphashtable.Add("BKBookingStage", "Booking");
                Exphashtable.Add("BKStatus", "OK");
                Exphashtable.Add("WSStatus", "Optioned");
                Exphashtable.Add("WsSender", "WebSite");
                Exphashtable.Add("MailStatus", ExpMailStatus);
                Exphashtable.Add("ATOLStatus", "NA");
                Exphashtable.Add("BookingTerms", "True");
                Exphashtable.Add("WheelChairAsst", "False");
                Exphashtable.Add("AlertMessage", "");
                Exphashtable.Add("MSMQMailStatus", "True");
                Exphashtable.Add("BookingPDF", "True");
                Exphashtable.Add("ATOLPDF", "Yes");
                Exphashtable.Add("WheelChairPDF", "False");
                Exphashtable.Add("VPInsurance", "True");
                Exphashtable.Add("BOAlert", "False");
                Exphashtable.Add("InfoMailsentToCust", "False");
                Exphashtable.Add("IsDataSentBacktoMSMQ", "False");

                foreach (string key in hashtable.Keys)
                {
                    if (hashtable[key].ToString().Trim().Equals(Exphashtable[key].ToString().Trim()))
                    {
                        WriteLogs("PASS : " + key + " is as Expected = " + hashtable[key].ToString());
                    }
                    else if (VPBookingStage == "Costing" && BKBookingStage == "Costing")
                    {
                        WriteLogs("INFO : Pay Online Was not Avaialable Booking Done using Phone button, so " + key + " is as Expected = " + hashtable[key].ToString());
                    }
                    else
                    {
                        WriteLogs("FAIL : " + key + " is Not as Expected, it should be " + Exphashtable[key].ToString());
                    }
                }
            }
            #endregion

            #region PDF Verification
            verifyPDF.WriteExpBDetailsFrmPDFtoTxt(Ref.Trim(), LeadFullName, flttypeSupptxt, PDFretdate, PDFdepdate, PDFDeport, PDFDeptime, PDFArrport, PDFArrtime, TotalPrice, Deposit);
            WriteLogs("########## END ########## Booking ID : " + BookingID + " : " + DateTime.Now.ToString() + "##########" + '\n' + '\n' + '\n');
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
