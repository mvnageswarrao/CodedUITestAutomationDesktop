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
    public class BookingB_Converted_PayOnline:logWriter
    {
        //Booking Flow: Product Page>>Villa Only HS page>>Include Flights>>Pay Online using VISA Card//
        public BookingB_Converted_PayOnline() 
        {
        }
        
        [TestMethod]
        public void BookingB_Converted_VISA()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463

                #region Booking Initiation
            getFromDB getdata = new getFromDB();
            pdfCheck verifyPDF = new pdfCheck();
            SqlDataReader dataReader = null;
            SqlDataReader dataReaderVillaID = null;
            string villaID = ConfigurationManager.AppSettings["villaID"].ToString();
            string noOfVillas = ConfigurationManager.AppSettings["noOfVillas"].ToString();
            string strURL = ConfigurationManager.AppSettings["URL"].ToString() + "product.aspx?villaid=" + villaID;
            string Platform = ConfigurationManager.AppSettings["platform"].ToString().Trim();
            int NumofAdultsfromConfig =Convert.ToInt32(ConfigurationManager.AppSettings["NoofAdults"].ToString());
            int NumofChildfromConfig = Convert.ToInt32(ConfigurationManager.AppSettings["NoofChild"].ToString());
            int NumofInfants = Convert.ToInt32(ConfigurationManager.AppSettings["NoofInfants"].ToString());
            int TotalPax = (NumofAdultsfromConfig + NumofChildfromConfig);
            //*****Getting Required Values for Car Hire from DB*****//
                int CarReqid = 0;
                string villaFullName = string.Empty;
                int MaxOccupancy = 0;
                int QualityID = 0;

                string sqlQuery = "select CarReqid, FullName,MaxOccupancy,QualityID from dbo.TblVilla where id = " + villaID;
                dataReader = getdata.getData(sqlQuery);
                while (dataReader.Read())
                {
                    CarReqid = Convert.ToInt32(dataReader[0].ToString());
                    villaFullName = dataReader[1].ToString();
                    MaxOccupancy = Convert.ToInt32(dataReader[2].ToString());
                    QualityID = Convert.ToInt32(dataReader[3].ToString());
                }
            #endregion

                #region Product Page
                WriteLogs("########## START ########## Villa ID : " + villaID + " : Booking On "+ strURL +" "+ DateTime.Now.ToString() + "##########");

                InitiateBookingBPages runScript = new InitiateBookingBPages();
                runScript.OpenBrowser_Obj.openBrowser_Method();
                runScript.enterURL_Obj.enterURL_Method(strURL);
                takeImage(villaID + "_VillaPage");
            runScript.clickCheckAvaiandPricesBtn_Obj.clickCheckAvaiandPricesBtn_Method();
                HtmlComboBox uIDdCalenderMonthsComboBox = runScript.selectActTabDepartsOn_Obj.getCombo_Method();
                HtmlComboBox uIDdAdultsComboBox = runScript.selectAdult_Obj.getselectAdultDropDown_Method();
                HtmlComboBox uIDdChildrenComboBox = runScript.selectChild_Obj.getselectChildDropDown_Method();
                HtmlComboBox uIDdInfantsComboBox = runScript.selectInfant_Obj.getInfant_Method();
                HtmlComboBox uIDdAirportsComboBox = runScript.selectActTabAirtport_Obj.getAirportCombo_Method();
                int lastitem = uIDdAdultsComboBox.Items.Count;
                Boolean wht = false;
                for (int i = 0; i < uIDdCalenderMonthsComboBox.Items.Count; i++)
                {
                    uIDdCalenderMonthsComboBox.SelectedIndex = i;
                    wht = runScript.selectDateFrmProductPage_Obj.selectDateFrmProductPage_Method();
                    if (wht == true)
                    {
                        //*****Booking popup From Product Page*****//
                        runScript.selectAdult_Obj.selectAdultForBookings_Method();
                        runScript.selectChild_Obj.selectChildForBookings_Method();
                        runScript.selectInfant_Obj.selectInfant_Method();
                        uIDdAirportsComboBox.SelectedIndex = 0;
                        runScript.clickActTabBookVillaBtn_Obj.selectActTabBookVillaBtn_Method();

                        Boolean IsPopupwithOKshown = runScript.clickOKonMaxOccupancyPopUp_obj.isMaxOccupancyPopUpshown_Method();
                        Boolean BkgstrtsfromSearchTile = false;

                        int ADultsSelection = 0;
                        int ChildSelection = 0;

                        if (IsPopupwithOKshown == true)
                        {
                            runScript.clickOKonMaxOccupancyPopUp_obj.clickOKonMaxOccupancyPopUp_Method();
                            ADultsSelection = MaxOccupancy / 2;
                            ChildSelection = MaxOccupancy / 2;
                            runScript.selectAdult_Obj.selectAdultbyreducing_Method(ADultsSelection);
                            runScript.selectChild_Obj.selectChildbyreducing_Method(ChildSelection);
                            runScript.clickActTabBookVillaBtn_Obj.selectActTabBookVillaBtn_Method();
                        }
                #endregion

                #region Holiday Summary Page
                //*****Opening HS VO Page*****//
                runScript.clickBookVillaVOonPopup_Obj.clickBookVillaVOonPopup_Method();
                string BookingID = runScript.verifyHSPKOpened_Obj.getBookingID(strURL);
                BookingID = BookingID.TrimStart('"');
                BookingID = BookingID.TrimEnd('"');
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

                fl_retdate = fl_retdate.Remove(0, 3);
                fl_depdate = fl_depdate.Remove(0, 3);
                runScript.verifyVODetails_Obj.verifyVODetails_Method(Nights, fl_retdate, fl_depdate, villaFullName);
                runScript.verifyVOPrice_Obj.verifyVOPrice_Method(Lineprice);
                runScript.verifyVExtraDfltTxt_Obj.verifyVExtraDfltTxt_Method(QualityID, NumofAdultsfromConfig, NumofChildfromConfig, NumofInfants, MaxOccupancy, LineType0);
                runScript.verifyCarDefaultText_Obj.verifyCarDefaultText_Method(CarReqid, villaFullName);
                runScript.verifyTransferDfltTxt_obj.verifyTransferDfltTxt_Method();
                runScript.verifyInsuranceDfltTxt_obj.verifyInsuranceDfltTxt_Method();
                runScript.verifyADWDfltTxt_Obj.verifyADWDfltTxt_Method(LineType0);
                runScript.verifyTotalHolCost_Obj.verifyTotalHolCost_Method(TotalPrice);
                string PriceDepPPPDetailsFromHSPageRegEx = runScript.verifyDepositDetails_Obj.verifyDepositDetails_Method(TotalPrice, Deposit, BalanceDueDate, BookDate, DepDate, AdultRate, ChildRate, InfantRate, AdwRate, ATOLRate, IsPopupwithOKshown, ADultsSelection, ChildSelection, NumofInfants, LineType0, BkgstrtsfromSearchTile);

                //runScript.verifyDfltTxtfrmIncludeFlts_Obj.verifyDfltTxtfrmIncludeFlts_Method();
                runScript.clickIncludeFlightsBtn_Obj.clickIncludeFlightsBtn_Method();
                runScript.verifyAirportBoxOpened_Obj.verifyAirportBoxOpened_Method();
                runScript.selectAirporttoIncludeFlights_Obj.selectAirporttoIncludeFlights_Method();
                runScript.clickGOfrmIncludeFlights_Obj.clickGOfrmIncludeFlights_Method();

                //*****Chcecking Basket ID Avaialable for the Selected Flight*****//
                string BasketId = string.Empty;
                sqlQuery = "SELECT BasketId FROM [Booking].[VillaPack] WHERE bookid=" + BookingID;

                dataReader = getdata.getData(sqlQuery);
                while (dataReader.Read())
                {
                    BasketId = dataReader[0].ToString();
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

                if (BasketId != "")
                {
                    WriteLogs("PASS : Basket ID Avaialable for the preselected Flight");
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
                                    WriteLogs("FAIL : \"Pay Online\" Button Would Not be Available as BasketId is NULL even after changing First set of flights.");
                                    break;
                                }
                                break;
                            }
                            WriteLogs("INFO : Found Basket ID after amending Flights");
                            break;
                        }
                    }
                    if (lastDone >= 6 || lastDone == (btncount))
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

                //*****Retriveing Total Holiday & Deposit Details from DB After Including Flight*****//
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

                sqlQuery = "select LineType,Lineprice from Booking.VillaPack where Bookid=" + BookingID;
                dataReader = getdata.getData(sqlQuery);
                while (dataReader.Read())
                {
                    LineType0 = dataReader[0].ToString();
                    Lineprice = Convert.ToDecimal(dataReader[1].ToString());
                }

                PriceDepPPPDetailsFromHSPageRegEx = runScript.verifyDepositDetails_Obj.verifyDepositDetails_Method(TotalPrice, Deposit, BalanceDueDate, BookDate, DepDate, AdultRate, ChildRate, InfantRate, AdwRate, ATOLRate, IsPopupwithOKshown, ADultsSelection, ChildSelection, NumofInfants, LineType0, BkgstrtsfromSearchTile);
                string FlightdetailsFrmHSForPDF = runScript.verifyPreSelctedFlights_Obj.verifyPreSelctedFlights_Method(id, Nights, OutBoundFlightOperatedBy, fl_retdate, fl_depdate, Flightid, FlightType, FlightNo_OB, Deport_OB_Name, DepTime_OB, ArrPort_OB_Name, Arrtime_OB, FlightNo_IB, DepPort_IB_Name, DepTime_IB, ArrPort_IB_Name, ArrTime_IB, AdultRate, ChildRate, InfantRate, flAdultRate, flChildRate, Lineprice, FlightTotalPrice, IsPopupwithOKshown, ADultsSelection, ChildSelection, NumofInfants, BkgstrtsfromSearchTile);
                FlightdetailsFrmHSForPDF = FlightdetailsFrmHSForPDF.Replace("  ", " ");
                FlightdetailsFrmHSForPDF = FlightdetailsFrmHSForPDF.Replace("  ", " ");
                FlightdetailsFrmHSForPDF = FlightdetailsFrmHSForPDF.Replace("  ", " ");
                FlightdetailsFrmHSForPDF = FlightdetailsFrmHSForPDF.Replace("  ", " ").Trim();

                string[] arr1 = FlightdetailsFrmHSForPDF.Split(' ');
                string flttypeSupptxt = arr1[2] + " " + arr1[3] + " " + arr1[4];
                string PDFretdate = fl_retdate;
                string PDFdepdate = fl_depdate;
                string PDFDeport = Deport_OB_Name;
                string PDFArrport = ArrPort_OB_Name;
                string PDFDeptime = DepTime_OB;
                string PDFArrtime = Arrtime_OB;

                string FlightDetailsFromHSPage = FlightdetailsFrmHSForPDF.Replace(" ", string.Empty);

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

                #region OtherPax Page
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
                int NumofChild = Convert.ToInt32(ConfigurationManager.AppSettings["NoofChild"].ToString());
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
                runScript.verifyFlightDetailsonProvConfPage_Obj.verifyFlightDetailsonProvConfPage_Method(FlightDetailsFromHSPage);

                decimal SecurtyDeposit = 0;
                sqlQuery = "Select LinePrice from Booking.ADW where Bookid=" + BookingID;
                dataReader = getdata.getData(sqlQuery);
                while (dataReader.Read())
                {
                    SecurtyDeposit = Convert.ToDecimal(dataReader[0].ToString());
                }
                runScript.verifyTotalDepositPPPDetailsonProvConfPage_Obj.verifyTotalDepositPPPDetailsonProvConfPage_Method(PriceDepPPPDetailsFromHSPageRegEx, AdwRate, SecurtyDeposit, NumofAdultsfromConfig, NumofChild, NumofInfants, TotalPrice);
                runScript.clickBookingCondCheckBox_Obj.clickBookingCondCheckBox_Method(strURL);
                runScript.clickOKFromBookingCondPopup_Obj.clickOKFromBookingCondPopup_Method();
                runScript.clickDisabilityBtn_Obj.clickDisabilityBtn_Method();
                runScript.verifyWheelChairPopupOpened_Obj.verifyWheelChairPopupOpened_Method();
                runScript.selectAirAssistanceForPax_Obj.selectAirAssistanceForPax_Method();
                runScript.clickOKFrmWheelChairPopup_Obj.clickOKFrmWheelChairPopup_Method();
                runScript.clickYesFrmPopup_Obj.clickYesFrmPopup_Method();
                Boolean IsPayOnlineBtnAvaial = runScript.clickPayOnlineButton_Obj.IsPayOnlineBtnAvaial_Method();
                Boolean IsWheelChairSelected = false;
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
                    string AddressDetails = ConfigurationManager.AppSettings["CardVISAAdd"].ToString();
                    string[] AddDetailsArr = AddressDetails.Split(',');
                    runScript.verifyPayOnlinePagedisplay_Obj.verifyPayOnlinePagedisplay_Method(strURL);
                    runScript.clickEditAddressBtn_Obj.clickEditAddressBtn_Method();
                    runScript.selectCountry_Obj.VerifyCountryBoxEnabled_Method();
                    runScript.selectCountry_Obj.selectCountry_Method(AddDetailsArr[0]);
                    runScript.enterStreet_Obj.enterStreet_Method(AddDetailsArr[1]);
                    runScript.enterTownCity_Obj.enterTownCity_Method(AddDetailsArr[2]);
                    runScript.enterPostCode_Obj.enterPostCode_Method(AddDetailsArr[3]);
                    HtmlComboBox uIDrpCardTypeComboBox = runScript.selectCardType_Obj.getCardType_Method();
                    string cardDetails = ConfigurationManager.AppSettings["CardVISA"].ToString();
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
                        runScript.clickSubmitFrmVISA3D_Obj.clickSubmitFrmVISA3D_Method();
                    }
                    else if (IserrPageshown == false)
                    {
                        Boolean Is3DPageOpened = runScript.clickSubmitFrmVISA3D_Obj.IsVisa3DPageOpened_Method();
                        Boolean isAsh3DPage = runScript.verifyAshTest3DpageOpened_Obj.verifyAshTest3DpageOpened_Method();

                        if (Is3DPageOpened == true)
                        {
                            runScript.enter3DPwd_Obj.enter3DPwd_Method(cardDetailsArr[3]);
                            runScript.clickSubmitFrmVISA3D_Obj.clickSubmitFrmVISA3D_Method();
                        }
                        else if(isAsh3DPage==true)
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
                                WriteLogs("INFO : As Error Message has shown, Pay By Phone Button From Payment has been clicked.");
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

                    if (IsPayOnlineBtnAvaial == true && IsWheelChairSelected == false && BKBookingStage == "Costing")
                    {
                        ExpectedApplCCRate = 0.025;
                    }
                    else
                    {
                        ExpectedApplCCRate = 0.020;
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
                    if (IsPayOnlineBtnAvaial == true && IsWheelChairSelected == false && BKBookingStage == "Costing")
                    {
                        ExpectedApplCCRate = 0.025;
                    }
                    else
                    {
                        ExpectedApplCCRate = 0.020;
                    }
                    string ExpMailStatus = string.Empty;
                    string ExpATOLStatus = string.Empty;
                    ExpMailStatus = "Queued";
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
                    Exphashtable.Add("ATOLStatus", "Queued");
                    Exphashtable.Add("BookingTerms", "True");
                    Exphashtable.Add("WheelChairAsst", "False");
                    Exphashtable.Add("AlertMessage", "");
                    Exphashtable.Add("MSMQMailStatus", "True");
                    Exphashtable.Add("BookingPDF", "True");
                    Exphashtable.Add("ATOLPDF", "Yes");
                    Exphashtable.Add("WheelChairPDF", "False");
                    Exphashtable.Add("VPInsurance", "False");
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

                break;
            }
        }
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
