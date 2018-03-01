using System;
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
    public class BookingB_PK_WithAmends : logWriter
    {
        //Booking Flow:Home >> Search Results using Search Tile>>Package HS page>> Do all Amends >>Pay Online using Master Card//
        public BookingB_PK_WithAmends()
        {
        }

        [TestMethod]
        public void BookingB_PK_WithAllAmends()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463

            #region Booking Initiation
            getFromDB getdata = new getFromDB();
            pdfCheck verifyPDF = new pdfCheck();
            SqlDataReader dataReader = null;
            string strURL = ConfigurationManager.AppSettings["URL"].ToString();
            string Platform = ConfigurationManager.AppSettings["platform"].ToString();

            WriteLogs("########## START ########## Booking : On " + strURL + DateTime.Now.ToString() + "##########");

            InitiateBookingBPages runScript = new InitiateBookingBPages();
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
            string SelectedDuration = string.Empty;
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
                if(NumofDatesAvaial ==0)
                {
                    WriteLogs("FAIL : Zero Dates are Avaialable, Please make sure the Season End date is correct. : VERIFICATION");
                }
                Random rnd = new Random();
                int SelectableDateindex = rnd.Next(1, NumofDatesAvaial);
                SelectableDate = Convert.ToDateTime(DatesList[SelectableDateindex - 1]);
                SelectableDateforLog = ""+SelectableDate.Day +"/"+ SelectableDate.Month +"/"+ SelectableDate.Year+"";

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
                runScript.clickBookVillaFlightLink_Obj.clickBookVillaFlightLink_Method();
            }
            else
            {
                runScript.clickVillaNFlightsLinkFrmSearchResultsPage_Obj.clickVillaNFlightsLinkFrmSearchResultsPage_Method();
            }
            //}
            #endregion

            #region Holiday Summary Page

            #region Getting DB Values for HS Page
            //*****Opening HS PK Page*****//
            string BookingID = runScript.verifyHSPKOpened_Obj.getBookingID(strURL);
            BookingID = BookingID.TrimStart('"');
            BookingID = BookingID.TrimEnd('"');
            //runScript.verifyHSPagecontent_Obj.verifyHSPagecontent_Method();

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
            string DepPort_IB_Name = "";
            string ArrPort_IB_Name = "";

            //*****Retriveing Flight, Flight Extra and Villa Extra Details from DB*****//
            sqlQuery = "exec QAsp_GetFlightDetails " + BookingID;

            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                id = Convert.ToInt32(dataReader[0].ToString());
                fl_retdate = Convert.ToDateTime(dataReader[1]).ToString("ddd dd MMM yyyy").ToString();
                fl_depdate = Convert.ToDateTime(dataReader[2]).ToString("ddd dd MMM yyyy").ToString();
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

            //*****Retriveing Flight Extras count and Details from DB*****//
            int FExtrascount = 0;
            sqlQuery = "SELECT count(*) FROM [Booking].[ExtraBooked] WHERE Type = 'F' and Lineid in (SELECT  id FROM [Booking].[VillaPack] WHERE bookid=" + BookingID + ")";

            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                FExtrascount = Convert.ToInt32(dataReader[0].ToString());
            }

            string FExtrasFrmDB = string.Empty;
            List<string> ListofFExtrasFrmDB = new List<string>();
            sqlQuery = "SELECT Invoicedesc FROM [Booking].[ExtraBooked] WHERE Type = 'F' and Lineid in (SELECT  id FROM [Booking].[VillaPack] WHERE bookid=" + BookingID + ")";

            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                FExtrasFrmDB = dataReader[0].ToString();
                ListofFExtrasFrmDB.Add(FExtrasFrmDB);
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
            //*****Getting Required Values for PK Booking*****//
            string LineType0 = string.Empty;

            sqlQuery = "select LineType from Booking.VillaPack where Bookid=" + BookingID;
            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                LineType0 = dataReader[0].ToString();
            }
         
            #endregion

            #region Verifying Default details
            Boolean IsPopupwithOKshown = false;
            Boolean BkgstrtsfromSearchTile = true;
            int ADultsSelection = NumofAdults;
            int ChildSelection = NumofChild;
            int InfantSelection = NumofInfants;
            string FlightDetailsFromHSPage = runScript.verifyPreSelctedFlights_Obj.verifyPreSelctedFlights_Method(id, Nights, OutBoundFlightOperatedBy, fl_retdate, fl_depdate, Flightid, FlightType, FlightNo_OB, Deport_OB_Name, DepTime_OB, ArrPort_OB_Name, Arrtime_OB, FlightNo_IB, DepPort_IB_Name, DepTime_IB, ArrPort_IB_Name, ArrTime_IB, AdultRate, ChildRate, InfantRate, flAdultRate, flChildRate, Lineprice, FlightTotalPrice, IsPopupwithOKshown, ADultsSelection, ChildSelection, InfantSelection, BkgstrtsfromSearchTile);
            runScript.verifyFExtraDfltTxt_Obj.verifyFExtraDfltTxt_Method(FExtrascount);
            runScript.verifyVExtraDfltTxt_Obj.verifyVExtraDfltTxt_Method(QualityID, NumofAdults, NumofChild, NumofInfants, MaxOccupancy,LineType0);
            runScript.verifyCarDefaultText_Obj.verifyCarDefaultText_Method(CarReqid, villaFullName);
            runScript.verifyTransferDfltTxt_obj.verifyTransferDfltTxt_Method();
            runScript.verifyInsuranceDfltTxt_obj.verifyInsuranceDfltTxt_Method();
            runScript.verifyADWDfltTxt_Obj.verifyADWDfltTxt_Method(LineType0);
            runScript.verifyATOLDfltTxt_obj.verifyATOLDfltTxt_Method();
            #endregion

            #region Amend Flights 
            ////*****Verifying Add/Amend Flights button functionality and all other functionalities under Flights section*****//
            runScript.clickAddAmendFlights_Obj.clickAddAmendFlights_Method(strURL);
            runScript.verifyAddAmendFltpopupOpened_obj.verifyAddAmendFltpopupOpened_Method();
            //runScript.clickHideOptions_obj.clickHideOptions_Method();
            //runScript.clickViewFlightOptions_obj.clickViewFlightOptions_Method();
            runScript.verifyNotesTextDisplay_obj.verifyNotesTextDisplay_Method();
            //runScript.verifyAlternativeFlightsPanedisplay_obj.verifyAlternativeFlightsPanedisplay_Method();
            runScript.clickSelectBtnforOtherflight_Obj.clickSelectBtnforOtherflight_Method(strURL);
            runScript.clickChangeFlightLink_obj.clickChangeFlightLink_Method();
            runScript.verifyGetFlightsBtnDisplayed_obj.verifyGetFlightsBtnDisplayed_Method();
            runScript.verifyAirportListEnabled_obj.verifyAirportListEnabled_Method();
            SelectedAirport = runScript.selectAirportForFlight1_obj.selectAirportForFlight1_Method();
            runScript.clickGetFlightsBtn_obj.clickGetFlightsBtn_Method();
            runScript.clickSelectBtnforOtherflight_Obj.clickSelectBtnforOtherflight_Method(strURL);
            runScript.verifyNoFlightsErrMsgDisplay_obj.verifyNoFlightsErrMsgDisplay_Method(SelectedAirport);
            runScript.clickDoneBtnFrmFlights_obj.clickDoneBtnFrmFlights_Method(strURL);
            WriteLogs("PASS : \"Add/Amend Flights\" Functionalities are Verified. : VERIFICATION");
            //*****Chcecking Basket ID Avaialable for the Selected Flight*****//
            string BasketId = string.Empty;
            sqlQuery = "SELECT BasketId FROM [Booking].[VillaPack] WHERE bookid=" + BookingID;

            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                BasketId = dataReader[0].ToString();
            }

            #endregion

            #region Checking Basket ID
            if (BasketId != "")
            {
                WriteLogs("PASS : Basket ID Avaialable for the preselected Flight. : VERIFICATION");
            }

            int btncount = 0;
            int lastDone = 0;
            while (BasketId == "")
            {
                runScript.clickAddAmendFlights_Obj.clickAddAmendFlights_Method(strURL);
                runScript.verifyAddAmendFltpopupOpened_obj.verifyAddAmendFltpopupOpened_Method();
                HtmlDiv uISelectPane = runScript.clickSelectBtnforOtherflight_Obj.SelectingOtherFltstoGetBasketID_Method();
                UITestControlCollection AllSelectBtns = uISelectPane.FindMatchingControls();
                btncount = AllSelectBtns.Count;
                int j = 0;
                foreach (HtmlDiv eachSelectBTN in AllSelectBtns)
                {
                    if (j < lastDone)
                    {
                        j++;
                        continue;
                    }
                    else
                    {
                        Boolean IsSelectBtnExists = uISelectPane.Exists;
                        if (IsSelectBtnExists == false)
                        {
                            runScript.clickAddAmendFlights_Obj.clickAddAmendFlights_Method(strURL);
                        }
                        Mouse.Click(eachSelectBTN);
                        runScript.clickDoneBtnFrmFlights_obj.clickDoneBtnFrmFlights_Method(strURL);
                        //*****Chcecking Basket ID Avaialability After Amending Flights*****//
                        sqlQuery = "SELECT BasketId FROM [Booking].[VillaPack] WHERE bookid=" + BookingID;

                        dataReader = getdata.getData(sqlQuery);
                        while (dataReader.Read())
                        {
                            BasketId = dataReader[0].ToString();
                        }
                        if (BasketId == "")
                        {
                            lastDone++;
                            if (lastDone >= 5 || lastDone == (btncount))
                            {
                                WriteLogs("FAIL : \"Pay Online\" Button Would Not be Available as BasketId is NULL even after changing Preselected flights - For Info Only. : VERIFICATION");
                                break;
                            }
                            break;
                        }
                        WriteLogs("INFO : Found Basket ID after amending Flights");
                        break;
                    }
                }
                if (lastDone >= 5 || lastDone == (btncount))
                {
                    break;
                }
            }

            //*****Retriveing Flight, Flight Extra and Villa Extra Details from DB After Amending Flights*****//
            sqlQuery = "exec QAsp_GetFlightDetails " + BookingID;

            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                id = Convert.ToInt32(dataReader[0].ToString());
                fl_retdate = Convert.ToDateTime(dataReader[1]).ToString("ddd dd MMM yyyy").ToString();
                fl_depdate = Convert.ToDateTime(dataReader[2]).ToString("ddd dd MMM yyyy").ToString();
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


            string FlightdetailsFrmHSForPDF = runScript.verifyPreSelctedFlights_Obj.verifyPreSelctedFlights_Method(id, Nights, OutBoundFlightOperatedBy, fl_retdate, fl_depdate, Flightid, FlightType, FlightNo_OB, Deport_OB_Name, DepTime_OB, ArrPort_OB_Name, Arrtime_OB, FlightNo_IB, DepPort_IB_Name, DepTime_IB, ArrPort_IB_Name, ArrTime_IB, AdultRate, ChildRate, InfantRate, flAdultRate, flChildRate, Lineprice, FlightTotalPrice, IsPopupwithOKshown, ADultsSelection, ChildSelection, InfantSelection, BkgstrtsfromSearchTile);

            FlightdetailsFrmHSForPDF = FlightdetailsFrmHSForPDF.Replace("  ", " ");
            FlightdetailsFrmHSForPDF = FlightdetailsFrmHSForPDF.Replace("  ", " ");
            FlightdetailsFrmHSForPDF = FlightdetailsFrmHSForPDF.Replace("  ", " ");
            FlightdetailsFrmHSForPDF = FlightdetailsFrmHSForPDF.Replace("  ", " ");

            string[] arr1 = FlightdetailsFrmHSForPDF.Split(' ');
            string flttypeSupptxt = arr1[2] + " " + arr1[3] + " " + arr1[4];
            string PDFretdate = fl_retdate;
            string PDFdepdate = fl_depdate;
            string PDFDeport = Deport_OB_Name;
            string PDFArrport = ArrPort_OB_Name;
            string PDFDeptime = DepTime_OB;
            string PDFArrtime = Arrtime_OB;
            FlightDetailsFromHSPage = FlightdetailsFrmHSForPDF.Replace(" ", string.Empty);
            #endregion

            #region Add/Amend Flight Extras
            ////*****Retriveing Flight Extras count and Details from DB After Amending Flights*****//
            sqlQuery = "SELECT count(*) FROM [Booking].[ExtraBooked] WHERE Type = 'F' and Lineid in (SELECT  id FROM [Booking].[VillaPack] WHERE bookid=" + BookingID + ")";

            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                FExtrascount = Convert.ToInt32(dataReader[0].ToString());
            }

            FExtrasFrmDB = string.Empty;
            ListofFExtrasFrmDB = new List<string>();
            sqlQuery = "SELECT Invoicedesc FROM [Booking].[ExtraBooked] WHERE Type = 'F' and Lineid in (SELECT  id FROM [Booking].[VillaPack] WHERE bookid=" + BookingID + ")";

            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                FExtrasFrmDB = dataReader[0].ToString();
                ListofFExtrasFrmDB.Add(FExtrasFrmDB);
            }

            ////*****Verifying Add/Amend Flight Extras button functionality and all other functionalities under Flight Extras section*****//
            runScript.verifyFExtraDfltTxt_Obj.verifyFExtraDfltTxt_Method(FExtrascount);
            runScript.verifyAddAmendFltExtrasBtnEnabled_Obj.verifyAddAmendFltExtrasBtnEnabled_Method(FExtrascount);
            string Flt1tabdetailsFrmFExtrasPopup = string.Empty;
            if (FExtrascount != 0)
            {
                runScript.clickAddAmendFlightExtras_Obj.clickAddAmendFlightExtras_Method();
                runScript.verifyAddAmendFlightExtraspopupOpened_Obj.verifyAddAmendFlightExtraspopupOpened_Method();
                Flt1tabdetailsFrmFExtrasPopup = runScript.verifyFlight1tabinFExtrasPopup_Obj.verifyFlight1tabinFExtrasPopup_Method(Deport_OB_Name, ArrPort_OB_Name);
                runScript.verifyNumofFExtrasDisplayedinPopup_Obj.verifyNumofFExtrasDisplayedinPopup_Method(FExtrascount, ListofFExtrasFrmDB);
                Boolean IsFExtrasCheckBoxthere = runScript.selectFExtrasFrmCHKbox_Obj.IsFExtrasCHKboxthere_Method();
                if (IsFExtrasCheckBoxthere == true)
                {
                    runScript.selectFExtrasFrmCHKbox_Obj.selectFExtrasFrmCHKbox_Method();
                }
                Boolean IsFExtrasLISTthere = runScript.selectFExtrasFrmList_Obj.IsFExtrasLSTboxthere_Method();
                if (IsFExtrasLISTthere == true)
                {
                    runScript.selectFExtrasFrmList_Obj.selectFExtrasFrmList_Method();
                }
                runScript.clickDoneBtnFrmFExtraspopup_Obj.clickDoneBtnFrmFExtraspopup_Method();
                if (IsFExtrasCheckBoxthere == true || IsFExtrasLISTthere == true)
                {
                    runScript.verifyErrPopupDisplayedforFextras_Obj.verifyErrPopupDisplayedforFextras_Method();
                    runScript.clickOKFrmErrPopup_Obj.clickOKFrmErrPopup_Method();
                    runScript.clickSaveFlightExtrasBtn_Obj.clickSaveFlightExtrasBtn_Method();
                    runScript.clickDoneBtnFrmFExtraspopup_Obj.clickDoneBtnFrmFExtraspopup_Method();
                }
                WriteLogs("PASS : \"Add/Amend Flight Extras\" Functionalities are Verified. : VERIFICATION");
            }
            #endregion

            #region Add/Amend Villa Extras
            ////*****Verifying Add/Amend Villa Extras button functionality and all other functionalities under Villa Extras section*****//
            runScript.clickAddAmendVillaExtrasBtn_Obj.clickAddAmendVillaExtrasBtn_Method();
            runScript.verifyNumofVExtrasDisplayedinPopup_Obj.verifyNumofVExtrasDisplayedinPopup_Method(VExtrascount, ListofVExtrasFrmDB, MaxOccupancy, NumofAdults, NumofChild, NumofInfants);
            runScript.selectVExtrasFrmList_Obj.selectVExtrasFrmList_Method();
            Boolean IsVExtrasCheckBoxthere = runScript.selectVExtrasfrmChkBox_Obj.IsVExtrasCHKboxthere_Method();
            if (IsVExtrasCheckBoxthere == true)
            {
                runScript.selectVExtrasfrmChkBox_Obj.selectVExtrasfrmChkBox_Method();
            }
            runScript.clickSaveVillaExtrasBtn_Obj.clickSaveVillaExtrasBtn_Method();
            //*****Retriveing Villa Extras Details from DB After Adding/Amending the Villa Extras*****//

            string VExtrasFrmDBAfterAdding = string.Empty;
            List<string> ListofVExtrasFrmDBAfterAdding = new List<string>();

            string VExtraUnitPriceFrmDB = string.Empty;
            List<string> ListofVExtraUnitPriceFrmDB = new List<string>();

            string VExtraQtyFrmDB = string.Empty;
            List<string> ListofVExtraQtyFrmDB = new List<string>();

            string VExtraTotalPriceFrmDB = string.Empty;
            List<string> ListofVExtraTotalPriceFrmDB = new List<string>();

            sqlQuery = "SELECT Invoicedesc,UnitPrice,Qty,Price FROM [Booking].[ExtraBooked] WHERE Type = 'V' and Lineid in (SELECT  id FROM [Booking].[VillaPack] WHERE bookid=" + BookingID + ")";

            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                VExtrasFrmDBAfterAdding = dataReader[0].ToString();
                ListofVExtrasFrmDBAfterAdding.Add(VExtrasFrmDBAfterAdding);

                VExtraUnitPriceFrmDB = dataReader[1].ToString();
                ListofVExtraUnitPriceFrmDB.Add(VExtraUnitPriceFrmDB);

                VExtraQtyFrmDB = dataReader[2].ToString();
                ListofVExtraQtyFrmDB.Add(VExtraQtyFrmDB);

                VExtraTotalPriceFrmDB = dataReader[3].ToString();
                ListofVExtraTotalPriceFrmDB.Add(VExtraTotalPriceFrmDB);
            }
            runScript.verifyselectedVExtrasSavedOnHSPage_Obj.verifyselectedVExtrasSavedOnHSPage_Method(ListofVExtrasFrmDBAfterAdding, ListofVExtraUnitPriceFrmDB, ListofVExtraQtyFrmDB, ListofVExtraTotalPriceFrmDB, MaxOccupancy, NumofAdults, NumofChild, NumofInfants);
            WriteLogs("PASS : \"Add/Amend VIlla Extras\" Functionalities are Verified. : VERIFICATION");
            #endregion

            #region Amend Cars
            ////*****Verifying Add/Amend Car Hire button functionality and all other functionalities under Car Hire section*****//
            runScript.clickAddCarHireBtn_Obj.clickAddCarHireBtn_Method();
            runScript.verifyAddAmendCarHirepopupOpened_Obj.verifyAddAmendCarHirepopupOpened_Method();
            string ExpectedFlt1tabdetailsFrmCarHire = runScript.verifyFlight1tabinCarsPopup_Obj.verifyFlight1tabinCarsPopup_Method(Deport_OB_Name, ArrPort_OB_Name);
            string ExpectedFlightDetailsFrmCars = runScript.verifyFlightdetailsinCarspopup_Obj.verifyFlightdetailsinCarspopup_Method(fl_depdate, DepTime_OB, Deport_OB_Name, ArrTime_IB, ArrPort_OB_Name, fl_retdate, DepTime_IB, Arrtime_OB);
            runScript.clickSelectBtnfrmCars_Obj.clickSelectBtnfrmCars_Method();
            runScript.selectChildSeatsForaCar_Obj.selectChildSeatsForaCar_Method();
            runScript.clickSaveCarfrmQtypopup_Obj.clickSaveCarfrmQtypopup_Method(strURL);
            //Adding more Cars //
            runScript.clickAddAnotherCarBtn_Obj.clickAddAnotherCarBtn_Method();
            runScript.clickSelectBtnfrmCars_Obj.clickSelectBtnfrmCars_Method();
            runScript.selectChildSeatsForaCar_Obj.selectChildSeatsForaCar_Method();
            runScript.clickSaveCarfrmQtypopup_Obj.clickSaveCarfrmQtypopup_Method(strURL);
            runScript.clickDoneBtnfrmCarsPopup_Obj.clickDoneBtnfrmCarsPopup_Method(strURL);
            //Amending Existing Cars//
            runScript.clickAddCarHireBtn_Obj.clickAddCarHireBtn_Method();
            runScript.clickAmendBtnFrmCars_Obj.clickAmendBtnFrmCars_Method();
            runScript.clickSelectBtnfrmCars_Obj.clickSelectBtnfrmCars_Method();
            runScript.selectChildSeatsForaCar_Obj.selectChildSeatsForaCar_Method();
            runScript.clickSaveCarfrmQtypopup_Obj.clickSaveCarfrmQtypopup_Method(strURL);
            runScript.clickDoneBtnfrmCarsPopup_Obj.clickDoneBtnfrmCarsPopup_Method(strURL);
            //Deleting Selected Cars//
            runScript.clickAddCarHireBtn_Obj.clickAddCarHireBtn_Method();
            runScript.clickDeleteBtnForCar_Obj.clickDeleteBtnForCar_Method();
            runScript.clickDoneBtnfrmCarsPopup_Obj.clickDoneBtnfrmCarsPopup_Method(strURL);
            WriteLogs("PASS : \"Add/Amend Car Hire\" Functionalities are verified. : VERIFICATION");
            #endregion

            #region Private Transfers
            ////*****Verifying Add/Amend Transfers button functionality and all other functionalities under Transfers section*****//
            runScript.clickAddAmendTransfers_Obj.clickAddAmendTransfers_Method(strURL);
            runScript.verifyTransfersPopupOpened_Obj.verifyTransfersPopupOpened_Method();
            runScript.verifyFlt1TabfromTransfersPopup_Obj.verifyFlt1TabfromTransfersPopup_Method(ExpectedFlt1tabdetailsFrmCarHire);
            runScript.verifyFlightDetailsinTransfersPopup_Obj.verifyFlightDetailsinTransfersPopup_Method(ExpectedFlightDetailsFrmCars);
            runScript.clickSaveTransfers_Obj.clickSaveTransfers_Method(strURL);
            runScript.clickOKBtnFrmTransfersErr_Obj.clickOKBtnFrmTransfersErr_Method();
            runScript.clickDoneBtnFrmTransfers_Obj.clickDoneBtnFrmTransfers_Method(strURL);
            runScript.clickAddAmendTransfers_Obj.clickAddAmendTransfers_Method(strURL);
            runScript.clickSelectBtnForTransfers_Obj.clickSelectBtnForTransfers_Method();
            runScript.clickDoneBtnFrmTransfers_Obj.clickDoneBtnFrmTransfers_Method(strURL);
            runScript.verifyTransfersErrPopupDisplayed_Obj.verifyTransfersErrPopupDisplayed_Method();
            runScript.clickOKBtnFrmTransfersErr_Obj.clickOKBtnFrmTransfersErr_Method();
            runScript.clickRemoveBtnForaTransfer_Obj.clickRemoveBtnForaTransfer_Method();
            runScript.clickSaveTransfers_Obj.clickSaveTransfers_Method(strURL);
            runScript.clickOKBtnFrmTransfersErr_Obj.clickOKBtnFrmTransfersErr_Method();
            runScript.clickSelectBtnForTransfers_Obj.clickSelectBtnForTransfers_Method();
            runScript.clickSaveTransfers_Obj.clickSaveTransfers_Method(strURL);
            runScript.clickDoneBtnFrmTransfers_Obj.clickDoneBtnFrmTransfers_Method(strURL);
            //Adding More Transfers//
            runScript.clickAddAmendTransfers_Obj.clickAddAmendTransfers_Method(strURL);
            runScript.verifyTransfersPopupOpened_Obj.verifyTransfersPopupOpened_Method();
            runScript.clickAddExtraTransfer_Obj.clickAddExtraTransfer_Method();
            runScript.clickSelectBtnForTransfers_Obj.clickSelectBtnForTransfers_Method();
            runScript.clickSaveTransfers_Obj.clickSaveTransfers_Method(strURL);
            runScript.clickDoneBtnFrmTransfers_Obj.clickDoneBtnFrmTransfers_Method(strURL);
            //Amending Existing Transfers//
            runScript.clickAddAmendTransfers_Obj.clickAddAmendTransfers_Method(strURL);
            runScript.verifyTransfersPopupOpened_Obj.verifyTransfersPopupOpened_Method();
            runScript.clickAmendForaTransfer_Obj.clickAmendForaTransfer_Method();
            runScript.amendTransferQty_Obj.amendTransferQty_Method();
            runScript.amendTransferways_Obj.amendTransferways_Method();
            runScript.clickSaveBtnFrmAmendTransfer_Obj.clickSaveBtnFrmAmendTransfer_Method(strURL);
            runScript.clickDoneBtnFrmTransfers_Obj.clickDoneBtnFrmTransfers_Method(strURL);
            //Deleteing Existing Transfers//
            runScript.clickAddAmendTransfers_Obj.clickAddAmendTransfers_Method(strURL);
            runScript.verifyTransfersPopupOpened_Obj.verifyTransfersPopupOpened_Method();
            runScript.clickDeleteBtnFrmTransfer_Obj.clickDeleteBtnFrmTransfer_Method();
            runScript.clickDoneBtnFrmTransfers_Obj.clickDoneBtnFrmTransfers_Method(strURL);
            WriteLogs("PASS : \"Add/Amend Transfers\" Functionalities are Verified. : VERIFICATION");

            #endregion

            #region Travel Insurance
            runScript.clickAddInsuranceBtn_Obj.clickAddInsuranceBtn_Method(strURL);
            runScript.verifyInsurancePopupOpened_Obj.verifyInsurancePopupOpened_Method();
            runScript.selectPolicyType_Obj.selectPolicyType_Method(NumofAdults, NumofChild, NumofInfants);
            runScript.clickSaveInsuranceBtn_Obj.clickSaveInsuranceBtn_Method();
            WriteLogs("PASS : \"Add/Amend Travel Insurance\" Functionalities are Verified. : VERIFICATION");
            delayExecution(strURL);

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
            runScript.verifyTotalHolCost_Obj.verifyTotalHolCost_Method(TotalPrice);
            string PriceDepPPPDetailsFromHSPageRegEx = runScript.verifyDepositDetails_Obj.verifyDepositDetails_Method(TotalPrice, Deposit, BalanceDueDate, BookDate, DepDate, AdultRate, ChildRate, InfantRate, AdwRate, ATOLRate, IsPopupwithOKshown, ADultsSelection, ChildSelection, InfantSelection, LineType0, BkgstrtsfromSearchTile);
            #endregion

            #endregion

            #region LeadPax Page
            //*****Verification of Lead Pax Page*****//
            runScript.clickConitueButton_Obj.clickConitueButton_Method(strURL);
            Boolean Isexists = runScript.verifyHoldItemsPopupDisplay_Obj.verifyHoldItemsPopupDisplay_Method();
            if (Isexists == true)
            {
                runScript.clickYesFrmHoldItems_Obj.clickYesFrmHoldItems_Method();
            }
            Boolean IsCheckInBagsPopupShown = runScript.verifyCheckInBagsPopupOpened_Obj.verifyCheckInBagsPopupOpened_Method();
            if (IsCheckInBagsPopupShown == true)
            {
                runScript.clickYesFrmCheckInBags_Obj.clickYesFrmCheckInBags_Method();
            }
            runScript.verifyLeadPaxPageOpened_Obj.verifyLeadPaxPageOpened_Method();
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
                    runScript.verifyLeadPaxPageOpened_Obj.verifyLeadPaxPageOpened_Method();
                    runScript.enteringLeadPaxDetails_Obj.ChangingEMAILIDsFrmLeadPax_Method();
                    runScript.clickNextFrmLeadPaxPage_Obj.clickNextFrmLeadPaxPage_Method();
                }
                isOtherPaxOpened = runScript.verifyOtherPaxPageOpened_Obj.CheckifOtherPaxPageOpened_Method();
            }
            #endregion

            #region Other Pax Page
            //*****Verification of Other Pax Page*****//
            runScript.verifyOtherPaxPageOpened_Obj.verifyOtherPaxPageOpened_Method(strURL);

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
            //int NumofChild = Convert.ToInt32(ConfigurationSettings.AppSettings["NoofChild"].ToString());
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
            //int NumofInfants = Convert.ToInt32(ConfigurationSettings.AppSettings["NoofInfants"].ToString());
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

            #region ProvConf Page
            //*****Verification of Prov Conf Page*****//
            runScript.verifyProvConfPageOpened_Obj.verifyProvConfPageOpened_Method();
            takeImage(BookingID + "_ProvConf");
            runScript.verifyFlightDetailsonProvConfPage_Obj.verifyFlightDetailsonProvConfPage_Method(FlightDetailsFromHSPage);

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
            runScript.selectInsConditionsChkBox_Obj.selectInsConditionsChkBox_Method();
            runScript.clickOKBtnFrmInsCondPoupup_Obj.clickOKBtnFrmInsCondPoupup_Method();
            Boolean IsPayOnlineBtnAvaial = runScript.clickPayOnlineButton_Obj.IsPayOnlineBtnAvaial_Method();
            #endregion

            #region PayOnline Page
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

            //if (IsPayOnlineBtnAvaial == true)
            //{
            //    if (Platform.Equals("tabletLive") || Platform.Equals("tabletTest"))
            //    {
            //        runScript.clickPayOnlineButton_Obj.clickPayOnlineButton_Method(Platform);
            //        runScript.clickContinueBtnforOnline_Obj.clickContinueBtnforOnline_Method();
            //    }
            //    else
            //    {
            //        runScript.clickPayOnlineButton_Obj.clickPayOnlineButton_Method(Platform);
            //    }
            //    takeImage(BookingID + "_PayOnline");

                //*****Verification of Pay Online Page*****//
                string AddressDetails = ConfigurationManager.AppSettings["CardMasterAdd"].ToString();
                string[] AddDetailsArr = AddressDetails.Split(',');
                runScript.verifyPayOnlinePagedisplay_Obj.verifyPayOnlinePagedisplay_Method(strURL);
                runScript.clickEditAddressBtn_Obj.clickEditAddressBtn_Method();
                runScript.selectCountry_Obj.VerifyCountryBoxEnabled_Method();
                runScript.selectCountry_Obj.selectCountry_Method(AddDetailsArr[0]);
                runScript.enterStreet_Obj.enterStreet_Method(AddDetailsArr[1]);
                runScript.enterTownCity_Obj.enterTownCity_Method(AddDetailsArr[2]);
                runScript.enterPostCode_Obj.enterPostCode_Method(AddDetailsArr[3]);
                HtmlComboBox uIDrpCardTypeComboBox = runScript.selectCardType_Obj.getCardType_Method();
                string cardDetails = ConfigurationManager.AppSettings["CardMaster"].ToString();
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
                runScript.enterSecurityCode_Obj.enterSecurityCode_Method(cardDetailsArr[2]);
                runScript.clickMakePaymentBtn_Obj.clickMakePaymentBtn_Method(strURL);
                Boolean IserrPageshown = runScript.isCertErrPageshown_Obj.getCertErrPageshown_Method();
                if (IserrPageshown == true)
                {
                    runScript.clickContinueFrmCertiErrPage_Obj.clickContinueFrmCertiErrPage_Method();
                    runScript.enter3DPwd_Obj.enter3DPwd_Method(cardDetailsArr[3]);
                    runScript.clickSubmitFrm3D_Obj.clickSubmitFrm3D_Method();
                }
                else if (IserrPageshown == false)
                {
                    Boolean Is3DPageOpened = runScript.clickSubmitFrm3D_Obj.Is3DPageOpened_Method();
                    Boolean isAsh3DPage = runScript.verifyAshTest3DpageOpened_Obj.verifyAshTest3DpageOpened_Method();

                    if (Is3DPageOpened == true)
                    {
                        runScript.enter3DPwd_Obj.enter3DPwd_Method(cardDetailsArr[3]);
                        runScript.clickSubmitFrm3D_Obj.clickSubmitFrm3D_Method();
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
                                //runScript.clickContinueBtnforPhone_Obj.clickContinueBtnforPhone_Method();
                            }
                            else
                            {
                                runScript.clickPaybyPhoneonPayment_Obj.clickPaybyPhoneonPayment_Method(Platform);
                            }
                            WriteLogs("INFO : As Error Message has shown, Pay By Phone Button From Payment page has been clicked.");
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
            }
            #endregion

            #region ThankYou Page
            //*****Verification of Thank You Page*****//
            delayExecution(strURL);
            runScript.verifyThankYouRefPopupdisplay_Obj.verifyThankYouRefPopupdisplay_Method();
            runScript.selectRefFromList_Obj.selectRefFromList_Method(strURL);
            runScript.clickNextfrmThankYouRefPopup_Obj.clickNextfrmThankYouRefPopup_Method();
            runScript.verifyBookingRefTextDisplay_Obj.verifyBookingRefTextDisplay_Method(BookingID, IsPayOnlineBtnAvaial, IsPayOnlineBtnAvaial, LineType0);
            takeImage(BookingID + "_ThankYou");
            runScript.verifyFlightDetailsonThankYouPage_Obj.verifyFlightDetailsonThankYouPage_Method(FlightDetailsFromHSPage);
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

                if (IsPayOnlineBtnAvaial == true && BKBookingStage == "Booking")
                {
                    ExpectedApplCCRate = 0.020;
                }
                else if (IsPayOnlineBtnAvaial == false && BKBookingStage == "Costing")
                {
                    ExpectedApplCCRate = 0.020;
                }
                else if (IsPayOnlineBtnAvaial == true && BKBookingStage == "Costing")
                {
                    ExpectedApplCCRate = 0.025;
                }

                Hashtable Exphashtable = new Hashtable();
                Exphashtable.Add("LineType", "Villa-PK");
                Exphashtable.Add("VPStatus", "OK");
                Exphashtable.Add("VPBookingStage", "Booking");
                Exphashtable.Add("ApplCCRate", ExpectedApplCCRate);
                Exphashtable.Add("BKBookingStage", "Booking");
                Exphashtable.Add("BKStatus", "OK");
                Exphashtable.Add("WSStatus", "Optioned");
                Exphashtable.Add("WsSender", "WebSite");
                Exphashtable.Add("MailStatus", "PDF Mail");
                Exphashtable.Add("ATOLStatus", "Yes");
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

                if (IsPayOnlineBtnAvaial == true && BKBookingStage == "Booking")
                {
                    ExpectedApplCCRate = 0.020;
                }
                else if (IsPayOnlineBtnAvaial == false && BKBookingStage == "Costing")
                {
                    ExpectedApplCCRate = 0.020;
                }
                else if (IsPayOnlineBtnAvaial == true && BKBookingStage == "Costing")
                {
                    ExpectedApplCCRate = 0.025;
                }
                string ExpMailStatus = string.Empty;
                string ExpATOLStatus = string.Empty;
                ExpMailStatus = "Queued";
                ExpATOLStatus = "Queued";
                Hashtable Exphashtable = new Hashtable();
                Exphashtable.Add("LineType", "Villa-PK");
                Exphashtable.Add("VPStatus", "OK");
                Exphashtable.Add("VPBookingStage", "Booking");
                Exphashtable.Add("ApplCCRate", ExpectedApplCCRate);
                Exphashtable.Add("BKBookingStage", "Booking");
                Exphashtable.Add("BKStatus", "OK");
                Exphashtable.Add("WSStatus", "Optioned");
                Exphashtable.Add("WsSender", "WebSite");
                Exphashtable.Add("MailStatus", ExpMailStatus);
                Exphashtable.Add("ATOLStatus", ExpATOLStatus);
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
