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
using System.Diagnostics;


namespace TestAutomation
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class Load_BookingB_VO_Online_Debit:logWriter
    {
        //Booking Flow: Home Page>> Search Results using Serach Tile >> Click View Villa and Open Product Page >>Villa Only HS page>> Pay Online Booking//
        public Load_BookingB_VO_Online_Debit()
        {
        }
        
        [TestMethod]
        public void Load_BookingB_VO_Online_Maestro()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
                        
            #region Booking Initiation
            Stopwatch stopWatch = new Stopwatch();
            Stopwatch stopWatchFullBooking = new Stopwatch();
            TimeSpan ts = new TimeSpan();
            string elaspsedTime = string.Empty;
            getFromDB getdata = new getFromDB();
            SqlDataReader dataReader = null;
            string strURL = ConfigurationManager.AppSettings["URL"].ToString();
            string Platform = ConfigurationManager.AppSettings["platform"].ToString().Trim();

            #endregion

            #region Home Page
            WriteLogs("########## START ########## Booking : On " + strURL +" "+ DateTime.Now.ToString() + "##########");
            InitiateBookingBPages runScript = new InitiateBookingBPages();
            stopWatchFullBooking.Start();
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
            string SelectedDate = string.Empty;
            string SelectedDateFrmTab = string.Empty;
            int MaxOccupancy = 0;
            int MinOccupancy = 0;

            do
            {
                string SelectedCenter = string.Empty;
                if (Platform.Equals("tabletLive") || Platform.Equals("tabletTest"))
                {
                    SelectedCenter = runScript.selectDestfrmTab_Obj.selectDestfrmTab_Method(centreNameList);
                }
                else
                {
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
                    MaxOccupancy = Convert.ToInt32(dataReader[0].ToString());
                    MinOccupancy = Convert.ToInt32(dataReader[1].ToString());
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

                if (Platform.Equals("tabletLive") || Platform.Equals("tabletTest"))
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
                    runScript.clickSearchBtn_Obj.clickSearchBtn_Method();
                }
                else
                {
                    runScript.clickCalenderIcon_Obj.clickCalenderIcon_Method();
                    runScript.selectMonthFrmCalender_Obj.selectMonthFrmCalender_Method(SelectableDate);
                    runScript.selectaDateFrmCalender_Obj.selectaDateFrmCalender_Method(SelectableDate);
                    SelectedDuration = runScript.verifyDurationListBox_Obj.selectDuration_Method();
                    NumofAdults = runScript.verifyAdultListBox_Obj.selectAdults_Method(MaxOccupancy);
                    NumofChild = runScript.verifyChildListBox_Obj.selectChild_Method(MaxOccupancy);
                    NumofInfants = runScript.verifyInfantListbox_Obj.selectInfant_Method(NumofAdults);
                    SelectedAirport = runScript.verifyAirportListBox_Obj.selectAirport_Method();
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
                            runScript.clickSearchBtn_Obj.clickSearchBtn_Method();
                            Ispopupdisplayed = runScript.verifyIncorrectInputPopupDisplayed_Obj.returnIncorrectInputPopupDisplayed_Method();
                        }
                    }
                }

                stopWatch.Start();

                IsNoVillasMsgDisplayed = runScript.verifyNoVillasMsgDisplayed_Obj.verifyNoVillasMsgDisplayed_Method();
                               
            } while (IsNoVillasMsgDisplayed == true);

            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elaspsedTime = ts.TotalSeconds + " Sec";
            WriteLogs("Info : Elapsed Time (\"Search Button\" Click - \"Search Results\" Page) : ~" + elaspsedTime);

            runScript.clickViewVillaBtnFrmSearchResultsPage_Obj.clickViewVillaBtnFrmSearchResultsPage_Method();
            runScript.clickBookVillaOnlyBtnFrmProductPage_Obj.clickBookVillaOnlyBtnFrmProductPage_Method();

            stopWatch.Reset();
            stopWatch.Start();
            #endregion

            #region Holiday Summary Page
            //*****Opening HS VO Page*****//
            string BookingID = runScript.verifyHSPKOpened_Obj.getBookingID(strURL);

            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elaspsedTime = ts.TotalSeconds + " Sec";
            WriteLogs("Info : Elapsed Time (\"Book Villa Only\" Button Click - \"HS VO\" Page) : ~" + elaspsedTime);

            BookingID = BookingID.TrimStart('"');
            BookingID = BookingID.TrimEnd('"');
            
            WriteLogs("---------- START ---------- Booking ID : " + BookingID + " : " + DateTime.Now.ToString() + "----------");
          
            //*****Getting Required Values for VO Booking*****//
            string LineType0 = string.Empty;

            sqlQuery = "select LineType from Booking.VillaPack where Bookid=" + BookingID;
            dataReader = getdata.getData(sqlQuery);
            while (dataReader.Read())
            {
                LineType0 = dataReader[0].ToString();
            }

            int ADultsSelection = NumofAdults;
            int ChildSelection = NumofChild;
            #endregion

            #region LeadPax Page
            //*****Verification of Lead Pax Page*****//
            runScript.clickConitueButton_Obj.clickConitueButton_Method(strURL);
            runScript.verifyFlightInfoPopupOpened_Obj.verifyFlightInfoPopupOpened_Method();
            runScript.clickLaterFrmFlightInfoPopup_Obj.clickLaterFrmFlightInfoPopup_Method();

            stopWatch.Reset();
            stopWatch.Start();

            runScript.verifyLeadPaxPageOpenedForVO_Obj.verifyLeadPaxPageOpenedForVO_Method();
            
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elaspsedTime = ts.TotalSeconds + " Sec";
            WriteLogs("Info : Elapsed Time (\"Continue/Later\" Button Click - \"Lead Pax\" Page) : ~" + elaspsedTime);

            string LeadFullName = runScript.enteringLeadPaxDetails_Obj.enteringLeadPaxDetails_Method(Platform);
            runScript.enteringLeadPaxDetails_Obj.ChangingEMAILIDsFrmLeadPax_Method();
            runScript.getPostCodeDetails_Obj.getPostCodeDetails_Method(strURL);
            runScript.selectAddressFromList_Obj.selectAddressFromList_Method();
            runScript.clickSubmitFromAdrsPopup_Obj.clickSubmitFromAdrsPopup_Method(strURL);
            runScript.clickNextFrmLeadPaxPage_Obj.clickNextFrmLeadPaxPage_Method();

            stopWatch.Reset();
            stopWatch.Start();

            Boolean isOtherPaxOpened = runScript.verifyOtherPaxPageOpened_Obj.CheckifOtherPaxPageOpened_Method();

            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elaspsedTime = ts.TotalSeconds + " Sec";
            WriteLogs("Info : Elapsed Time (\"Next Button From Lead Pax\" Click - \"Other Pax\" Page) : ~" + elaspsedTime);

            #endregion

            #region OtherPax Page
            //*****Verification of Other Pax Page*****//

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
            runScript.clickNextFrmOtherPaxPage_Obj.clickNextFrmOtherPaxPage_Method(strURL);

            stopWatch.Reset();
            stopWatch.Start();
            #endregion

            #region ProVConf Page
            //*****Verification of Prov Conf Page*****//
            runScript.verifyProvConfPageOpened_Obj.verifyProvConfPageOpened_Method();

            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elaspsedTime = ts.TotalSeconds + " Sec";
            WriteLogs("Info : Elapsed Time (\"Next Button From Other Pax\" Click - \"Prov Conf\" Page) : ~" + elaspsedTime);

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
                }
                else
                {
                    runScript.clickPayOnlineButton_Obj.clickPayOnlineButton_Method(Platform);
                }
                stopWatch.Reset();
                stopWatch.Start();    
           
                //*****Verification of Pay Online Page*****//
                runScript.verifyPayOnlinePagedisplay_Obj.verifyPayOnlinePagedisplay_Method(strURL);

                stopWatch.Stop();
                ts = stopWatch.Elapsed;
                elaspsedTime = ts.TotalSeconds + " Sec";
                WriteLogs("Info : Elapsed Time (\"Pay Online\" Button Click - \"Pay Online\" Page) : ~" + elaspsedTime);

                string AddressDetails = ConfigurationManager.AppSettings["CardMaestroAdd"].ToString();
                string[] AddDetailsArr = AddressDetails.Split(',');
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
                runScript.enterSecurityCode_Obj.enterSecurityCode_Method(cardDetailsArr[2]);
                runScript.clickMakePaymentBtn_Obj.clickMakePaymentBtn_Method(strURL);

                stopWatch.Reset();
                stopWatch.Start();

                Boolean IserrPageshown = runScript.isCertErrPageshown_Obj.getCertErrPageshown_Method();
                Boolean isAsh3DPage = runScript.verifyAshTest3DpageOpened_Obj.verifyAshTest3DpageOpened_Method();

                if (IserrPageshown == true)
                {
                    runScript.clickContinueFrmCertiErrPage_Obj.clickContinueFrmCertiErrPage_Method();
                    runScript.enter3DPwd_Obj.enter3DPwd_Method(cardDetailsArr[3]);
                    runScript.clickSubmitFrm3D_Obj.clickSubmitFrm3D_Method();
                }
                else if (IserrPageshown == false)
                {
                    Boolean Is3DPageOpened = runScript.clickSubmitFrm3D_Obj.Is3DPageOpened_Method();
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
                            runScript.clickPaybyPhoneonPayment_Obj.clickPaybyPhoneonPayment_Method(Platform);
                            WriteLogs("INFO : As Error Message has shown, Pay By Phone Button From Payment has been clicked.");
                        }
                    }
                }
             }
            else
            {
                runScript.clickPayByPhoneButton_Obj.clickPayByPhoneButton_Method(Platform);
                WriteLogs("INFO : As Pay Online Button Not Available, Pay By Phone Button has been clicked.");
            }
            #endregion

            #region ThankYou Page
            WriteLogs("########## Thank You Page Load ########## Booking ID : " + BookingID + " : " + DateTime.Now.ToString() + "##########" + '\n');
            //*****Verification of Thank You Page*****//
            runScript.verifyThankYouRefPopupdisplay_Obj.verifyThankYouRefPopupdisplay_Method();

            runScript.selectRefFromList_Obj.selectRefFromList_Method(strURL);
            runScript.clickNextfrmThankYouRefPopup_Obj.clickNextfrmThankYouRefPopup_Method();
            runScript.verifyBookingRefTextDisplay_Obj.verifyBookingRefTextDisplay_Method(BookingID, IsPayOnlineBtnAvaial, IsPayOnlineBtnAvaial, LineType0);

            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elaspsedTime = ts.TotalSeconds + " Sec";
            WriteLogs("Info : Elapsed Time (\"Make Payment\" Button Click - \"Thank You\" Page) : ~" + elaspsedTime);

            stopWatchFullBooking.Stop();
            TimeSpan tsF = stopWatchFullBooking.Elapsed;
            string elaspsedTimeFULL = tsF.TotalSeconds + " Sec";
            WriteLogs("Info : Elapsed Time (FULL BOOKING) : ~" + elaspsedTimeFULL);

            runScript.verifyBookingRefTextDisplay_Obj.verifyBookingRefTextDisplay_Method(BookingID,IsPhoneBtnClicked,IsPayOnlineBtnAvaial, LineType0);
            WriteLogs("########## END ########## Booking ID : " + BookingID + " : " + DateTime.Now.ToString() + "##########" + '\n'+'\n'+'\n');
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
