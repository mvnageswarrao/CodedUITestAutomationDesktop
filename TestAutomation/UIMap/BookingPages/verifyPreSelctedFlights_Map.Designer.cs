﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.verifyPreSelctedFlights_MapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using TestAutomation.Utility;
    using System.Configuration;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public partial class verifyPreSelctedFlights_Map:logWriter
    {
        
        /// <summary>
        /// verifyPreSelctedFlights_Method - Use 'verifyPreSelctedFlights_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        //public void verifyPreSelctedFlights_Method()
        //{
        //    #region Variable Declarations
        //    HtmlTable uIItemTable = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIFlightsCellCell.UIItemTable;
        //    #endregion

        //    // Verify that the 'InnerText' property of table contains '
        //    //
        //    //Flights 
        //    //
        //    //
        //    //1: (Thomas Cook Airlines - NoFrills)   2 Adults, 2 Children
        //    //
        //    //
        //    //Thu 13 Mar 2014 
        //    //            Departing: London Gatwick 10:05hrs Arriving:  Arrecife 14:15hrs 
        //    //Adult  £291.14
        //    // x2 £582.28 
        //    //
        //    //
        //    //Thu 20 Mar 2014 
        //    //            Departing:  Arrecife 15:15hrs Arriving:  London Gatwick 19:25hrs 
        //    //Child  £261.14
        //    // x2 £522.28 
        //    //     
        //    //
        //    //
        //    //
        //    //  Total  £1104.56 
        //    //
        //    //
        //    //
        //    //
        //    //Add/Amend Flights'
        //    //StringAssert.Contains(uIItemTable.InnerText, this.verifyPreSelctedFlights_MethodExpectedValues.UIItemTableInnerText);

        //    string FlightDetailsFromPage = uIItemTable.InnerText;
        //    FlightDetailsFromPage = FlightDetailsFromPage.Replace("\r\n", string.Empty);
        //    FlightDetailsFromPage = FlightDetailsFromPage.Replace(" ", string.Empty);
        //    FlightDetailsFromPage = FlightDetailsFromPage.Replace("Add/AmendFlights", string.Empty);
        //    FlightDetailsFromPage = FlightDetailsFromPage.Trim();

        //    try
        //    {
        //        StringAssert.Contains(FlightDetailsFromPage, "Flights");
        //        WriteLogs("PASS : Flight Details are Matched");
        //    }
        //    catch (AssertFailedException ex)
        //    {
        //        WriteLogs("FAIL : Flight Details are Not Matched");
        //        WriteLogs("-----------------" + ex.Message.ToString());
        //    }
        //}

        public string verifyPreSelctedFlights_Method(int ID, int NIGHTS, string OUTBOUNDFLIGHTOPERATEDBY, string FL_RETDATE, string FL_DEPDATE, string FLIGHTID, string FLIGHTTYPE, string FLIGHTNO_OB, string DEPORT_OB_NAME, string DEPTIME_OB, string ARRPORT_OB_NAME, string ARRTIME_OB, string FLIGHTNO_IB, string DEPPORT_IB_NAME, string DEPTIME_IB, string ARRPORT_IB_NAME, string ARRTIME_IB, decimal ADULTRATE, decimal CHILDRATE, decimal INFANTRATE, decimal FLADULTRATE, decimal FLCHILDRATE, decimal LINEPRICE, decimal FLIGHTTOTALPRICE, Boolean IsPopupwithOKSHOWN, int ADultsSELECTION, int ChildSELECTION, int InfantSELECTION,Boolean BkgstrtsfromSearchTILE)
        {
            #region Variable Declarations
            HtmlTable uIItemTable = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIFlightsCellCell.UIItemTable;
            #endregion

            int NumofAdults = 0;
            int Numofchildren = 0;
            int NumofInfants = 0;

            if (BkgstrtsfromSearchTILE == true)
            {
                NumofAdults = ADultsSELECTION;
                Numofchildren = ChildSELECTION;
                NumofInfants = InfantSELECTION;
            }
            else if (BkgstrtsfromSearchTILE == false && IsPopupwithOKSHOWN == true)
            {
                NumofAdults = ADultsSELECTION;
                Numofchildren = ChildSELECTION;
                NumofInfants = InfantSELECTION;
            }
            else if (BkgstrtsfromSearchTILE == false && IsPopupwithOKSHOWN == false)
            {
                NumofAdults = Convert.ToInt16(ConfigurationManager.AppSettings["NoofAdults"].ToString());
                Numofchildren = Convert.ToInt16(ConfigurationManager.AppSettings["NoofChild"].ToString());
                NumofInfants = Convert.ToInt16(ConfigurationManager.AppSettings["NoofInfants"].ToString());
            }
           
            string multiAdultRate = Convert.ToString(NumofAdults * ADULTRATE);
            string multichildRate = Convert.ToString(Numofchildren * CHILDRATE);
            string multiInfantRate = Convert.ToString(NumofInfants * INFANTRATE);

            DEPPORT_IB_NAME = ARRPORT_OB_NAME;
            ARRPORT_IB_NAME = DEPORT_OB_NAME;

            string Adulttextforsingle = "Adult";
            string Adulttextformulti = "Adults";

            string Childtextforsingle = "Child";
            string Childtextformulti = "Children";

            string Infanttextforsingle = "Infant";
            string Infanttextformulti = "Infants";

            string FlightDetailsFromDB = null;

            if (NumofAdults == 1 && Numofchildren == 1)
            {
                if (NumofInfants == 0)
                {
                    FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextforsingle + "," + Numofchildren + Childtextforsingle + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrsChild£" + CHILDRATE + "x" + Numofchildren + "£" + multichildRate + "Total£" + LINEPRICE + "";
                    FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
                else if (NumofInfants == 1)
                {
                    FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextforsingle + "," + Numofchildren + Childtextforsingle + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrsChild£" + CHILDRATE + "x" + Numofchildren + "£" + multichildRate + Infanttextforsingle+ "£" + INFANTRATE + "x" + NumofInfants + "£" + multiInfantRate + "Total£" + LINEPRICE + "";
                    FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
                else if (NumofInfants > 1)
                {
                    FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextforsingle + "," + Numofchildren + Childtextforsingle + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrsChild£" + CHILDRATE + "x" + Numofchildren + "£" + multichildRate + Infanttextformulti + "£" + INFANTRATE + "x" + NumofInfants + "£" + multiInfantRate + "Total£" + LINEPRICE + "";
                    FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
            }
            else if(NumofAdults == 1 && Numofchildren > 1)
            {
                if (NumofInfants ==0)
                {
                FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextforsingle + "," + Numofchildren + Childtextformulti + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrsChild£" + CHILDRATE + "x" + Numofchildren + "£" + multichildRate + "Total£" + LINEPRICE + "";
                FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
                else if (NumofInfants == 1)
                {
                    FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextforsingle + "," + Numofchildren + Childtextformulti + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrsChild£" + CHILDRATE + "x" + Numofchildren + "£" + multichildRate + Infanttextforsingle + "£" + INFANTRATE + "x" + NumofInfants + "£" + multiInfantRate + "Total£" + LINEPRICE + "";
                    FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
                else if (NumofInfants > 1)
                {
                    FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextforsingle + "," + Numofchildren + Childtextformulti + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrsChild£" + CHILDRATE + "x" + Numofchildren + "£" + multichildRate + Infanttextformulti + "£" + INFANTRATE + "x" + NumofInfants + "£" + multiInfantRate + "Total£" + LINEPRICE + "";
                    FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
            }
            else if (NumofAdults > 1 && Numofchildren == 1)
            {
                if (NumofInfants == 0)
                {
                    FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextformulti + "," + Numofchildren + Childtextforsingle + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrsChild£" + CHILDRATE + "x" + Numofchildren + "£" + multichildRate + "Total£" + LINEPRICE + "";
                    FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
                else if (NumofInfants == 1)
                {
                    FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextformulti + "," + Numofchildren + Childtextforsingle + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrsChild£" + CHILDRATE + "x" + Numofchildren + "£" + multichildRate + Infanttextforsingle + "£" + INFANTRATE + "x" + NumofInfants + "£" + multiInfantRate + "Total£" + LINEPRICE + "";
                    FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
                else if (NumofInfants > 1)
                {
                    FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextformulti + "," + Numofchildren + Childtextforsingle + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrsChild£" + CHILDRATE + "x" + Numofchildren + "£" + multichildRate + Infanttextformulti + "£" + INFANTRATE + "x" + NumofInfants + "£" + multiInfantRate + "Total£" + LINEPRICE + "";
                    FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
            }
            else if (NumofAdults > 1 && Numofchildren > 1)
            {
                if (NumofInfants == 0)
                {
                    FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextformulti + "," + Numofchildren + Childtextformulti + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrsChild£" + CHILDRATE + "x" + Numofchildren + "£" + multichildRate + "Total£" + LINEPRICE + "";
                    FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
                else if (NumofInfants == 1)
                {
                    FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextformulti + "," + Numofchildren + Childtextformulti + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrsChild£" + CHILDRATE + "x" + Numofchildren + "£" + multichildRate + Infanttextforsingle + "£" + INFANTRATE + "x" + NumofInfants + "£" + multiInfantRate + "Total£" + LINEPRICE + "";
                    FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
                else if (NumofInfants > 1)
                {
                    FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextformulti + "," + Numofchildren + Childtextformulti + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrsChild£" + CHILDRATE + "x" + Numofchildren + "£" + multichildRate + Infanttextformulti + "£" + INFANTRATE + "x" + NumofInfants + "£" + multiInfantRate + "Total£" + LINEPRICE + "";
                    FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
            }
            else if (NumofAdults > 1 && Numofchildren == 0)
            {
                if (NumofInfants == 0)
                {
                    FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextformulti + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrs" + "Total£" + LINEPRICE + "";
                    FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
                else if (NumofInfants == 1)
                {
                    FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextformulti + "," + NumofInfants + Infanttextforsingle + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrs" + Infanttextforsingle + "£" + INFANTRATE + "x" + NumofInfants + "£" + multiInfantRate + "Total£" + LINEPRICE + "";
                    FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
                else if (NumofInfants > 1)
                {
                    FlightDetailsFromDB = "Flights1:(" + OUTBOUNDFLIGHTOPERATEDBY + "-" + FLIGHTTYPE + ")" + NumofAdults + Adulttextformulti + "," + NumofInfants + Infanttextformulti + FL_DEPDATE + "Departing:" + DEPORT_OB_NAME + DEPTIME_OB + "hrsArriving:" + ARRPORT_OB_NAME + ARRTIME_OB + "hrsAdult£" + ADULTRATE + "x" + NumofAdults + "£" + multiAdultRate + "" + FL_RETDATE + "Departing:" + DEPPORT_IB_NAME + DEPTIME_IB + "hrsArriving:" + ARRPORT_IB_NAME + ARRTIME_IB + "hrs" + Infanttextformulti + "£" + INFANTRATE + "x" + NumofInfants + "£" + multiInfantRate + "Total£" + LINEPRICE + "";
                    FlightDetailsFromDB = FlightDetailsFromDB.Replace(" ", string.Empty);
                }
            }

            if (OUTBOUNDFLIGHTOPERATEDBY == "")
            {
                FlightDetailsFromDB = FlightDetailsFromDB.Replace("-", string.Empty);
            }
            
            string FlightDetailsFromHSPage = uIItemTable.InnerText;
            FlightDetailsFromHSPage = FlightDetailsFromHSPage.Replace("\r\n", string.Empty);
            //FlightDetailsFromHSPage = FlightDetailsFromHSPage.Replace(" ", string.Empty);
            FlightDetailsFromHSPage = FlightDetailsFromHSPage.Replace("Change Flights", string.Empty);
            string FlightDetailsFromHSPageforthis = FlightDetailsFromHSPage.Replace(" ", string.Empty).Trim();

            try
            {
                StringAssert.Equals(FlightDetailsFromHSPageforthis, FlightDetailsFromDB);
                WriteLogs("PASS : Flight Details are Matched.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyPreSelctedFlights");
                WriteLogs("FAIL : Flight Details are Not Matched.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
            return FlightDetailsFromHSPage;
        }

        #region Properties
        public virtual verifyPreSelctedFlights_MethodExpectedValues verifyPreSelctedFlights_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyPreSelctedFlights_MethodExpectedValues == null))
                {
                    this.mverifyPreSelctedFlights_MethodExpectedValues = new verifyPreSelctedFlights_MethodExpectedValues();
                }
                return this.mverifyPreSelctedFlights_MethodExpectedValues;
            }
        }
        
        public UIYourHolidaySummaryWiWindow UIYourHolidaySummaryWiWindow
        {
            get
            {
                if ((this.mUIYourHolidaySummaryWiWindow == null))
                {
                    this.mUIYourHolidaySummaryWiWindow = new UIYourHolidaySummaryWiWindow();
                }
                return this.mUIYourHolidaySummaryWiWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyPreSelctedFlights_MethodExpectedValues mverifyPreSelctedFlights_MethodExpectedValues;
        
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyPreSelctedFlights_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class verifyPreSelctedFlights_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of table contains '
        ///
        ///Flights 
        ///
        ///
        ///1: (Thomas Cook Airlines - NoFrills)   2 Adults, 2 Children
        ///
        ///
        ///Thu 13 Mar 2014 
        ///            Departing: London Gatwick 10:05hrs Arriving:  Arrecife 14:15hrs 
        ///Adult  £291.14
        /// x2 £582.28 
        ///
        ///
        ///Thu 20 Mar 2014 
        ///            Departing:  Arrecife 15:15hrs Arriving:  London Gatwick 19:25hrs 
        ///Child  £261.14
        /// x2 £522.28 
        ///     
        ///
        ///
        ///
        ///  Total  £1104.56 
        ///
        ///
        ///
        ///
        ///Add/Amend Flights'
        /// </summary>
        public string UIItemTableInnerText = @"

Flights 


1: (Thomas Cook Airlines - NoFrills)   2 Adults, 2 Children


Thu 13 Mar 2014 
            Departing: London Gatwick 10:05hrs Arriving:  Arrecife 14:15hrs 
Adult  £291.14
 x2 £582.28 


Thu 20 Mar 2014 
            Departing:  Arrecife 15:15hrs Arriving:  London Gatwick 19:25hrs 
Child  £261.14
 x2 £522.28 
     



  Total  £1104.56 




Add/Amend Flights";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIYourHolidaySummaryWiWindow : BrowserWindow
    {
        
        public UIYourHolidaySummaryWiWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your Holiday Summary", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYourHolidaySummaryDocument UIYourHolidaySummaryDocument
        {
            get
            {
                if ((this.mUIYourHolidaySummaryDocument == null))
                {
                    this.mUIYourHolidaySummaryDocument = new UIYourHolidaySummaryDocument(this);
                }
                return this.mUIYourHolidaySummaryDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYourHolidaySummaryDocument mUIYourHolidaySummaryDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIYourHolidaySummaryDocument : HtmlDocument
    {
        
        public UIYourHolidaySummaryDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your Holiday Summary", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/default.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/default.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIFlightsCellCell UIFlightsCellCell
        {
            get
            {
                if ((this.mUIFlightsCellCell == null))
                {
                    this.mUIFlightsCellCell = new UIFlightsCellCell(this);
                }
                return this.mUIFlightsCellCell;
            }
        }
        #endregion
        
        #region Fields
        private UIFlightsCellCell mUIFlightsCellCell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIFlightsCellCell : HtmlCell
    {
        
        public UIFlightsCellCell(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlCell.PropertyNames.Id] = "flightsCell";
            this.SearchProperties[HtmlCell.PropertyNames.Name] = "";
            this.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "Flights ", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "id=\"flightsCell\" colspan=\"9\"";
            this.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "4";
            this.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "0";
            this.FilterProperties[HtmlCell.PropertyNames.Class] = null;
            this.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "48";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlTable UIItemTable
        {
            get
            {
                if ((this.mUIItemTable == null))
                {
                    this.mUIItemTable = new HtmlTable(this);
                    #region Search Criteria
                    this.mUIItemTable.SearchProperties[HtmlTable.PropertyNames.Id] = null;
                    this.mUIItemTable.SearchProperties[HtmlTable.PropertyNames.Name] = null;
                    this.mUIItemTable.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "Flights", PropertyExpressionOperator.Contains));
                    this.mUIItemTable.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"";
                    this.mUIItemTable.FilterProperties[HtmlTable.PropertyNames.RowCount] = "24";
                    this.mUIItemTable.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "12";
                    this.mUIItemTable.FilterProperties[HtmlTable.PropertyNames.Class] = "";
                    this.mUIItemTable.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIItemTable;
            }
        }
        #endregion
        
        #region Fields
        private HtmlTable mUIItemTable;
        #endregion
    }
}
