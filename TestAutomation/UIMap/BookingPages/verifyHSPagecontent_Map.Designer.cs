﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.verifyHSPagecontent_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class verifyHSPagecontent_Map:logWriter
    {
        
        /// <summary>
        /// verifyHSPagecontent_Method - Use 'verifyHSPagecontent_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyHSPagecontent_Method()
        {
            #region Variable Declarations
            HtmlCell uIYourHolidaySummaryViCell = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UITblMainTable.UIYourHolidaySummaryViCell;
            #endregion

            string Content = uIYourHolidaySummaryViCell.InnerText;
            Content = Content.Replace("\r\n", string.Empty);
            Content = Content.Replace(" ", string.Empty);
            Content = Content.Trim();

            Assert.AreEqual(this.verifyHSPagecontent_MethodExpectedValues.UIYourHolidaySummaryViCellInnerText, uIYourHolidaySummaryViCell.InnerText);
        }
        
        #region Properties
        public virtual verifyHSPagecontent_MethodExpectedValues verifyHSPagecontent_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyHSPagecontent_MethodExpectedValues == null))
                {
                    this.mverifyHSPagecontent_MethodExpectedValues = new verifyHSPagecontent_MethodExpectedValues();
                }
                return this.mverifyHSPagecontent_MethodExpectedValues;
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
        private verifyHSPagecontent_MethodExpectedValues mverifyHSPagecontent_MethodExpectedValues;
        
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyHSPagecontent_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyHSPagecontent_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Your Holiday Summary Vill' cell equals '
        ///Your Holiday Summary
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///Villa Tres Olivos, Nerja, Costa del Sol
        ///
        ///5 Adults, 2 Children, 2 Infants departing on 02 May 2014 for 7 nights, from Glasgow to Malaga
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        /// 
        ///
        ///
        ///
        ///
        ///
        ///Villa Overview
        ///
        ///
        ///3 BEDROOMS
        ///2 BATHROOMS
        ///SLEEPS 2 TO 7
        ///BEACH 3 MILES
        ///POOL 21 X 13 FT
        ///FREE AIR CON
        ///CAR ESSENTIAL
        ///
        ///Boasting fantastic panoramic views over Spain's southern coast to the sea, this delightful 3 bedroom villa enjoys a great location in the sought after town of Nerja. The shops and eateries of Nerja as well as the beautiful, expansive golden beach are all within a short drive and the villa also benefits from air conditioning/heating in the bedrooms at no extra cost.
        ///
        ///Included FREE with your villa
        ///
        ///
        ///Air Conditioning/Heating
        ///Childgate(s)  
        ///
        ///Table Tennis Table
        ///Pool/Billiard Table
        ///
        ///Satellite TV
        ///Microwave
        /// 
        /// 
        ///
        ///
        ///
        ///
        ///
        ///Package Holiday Details    All timings are local and shown in 24hr format
        /// Price Quantity Total 
        ///
        ///
        ///
        ///
        ///
        ///Villa Tres Olivos, Nerja, Costa del Sol      
        ///7 nights from 02 May 2014 to 09 May 2014        
        ///
        ///
        ///
        ///
        ///Flights 
        ///
        ///
        ///1: (Jet2 - NoFrills)   5 Adults, 2 Children, 2 Infants
        ///
        ///
        ///Fri 02 May 2014 
        ///            Departing: Glasgow 07:30hrs Arriving:  Malaga 11:45hrs 
        ///Adult  £333.87
        /// x5 £1669.35 
        ///
        ///
        ///Fri 09 May 2014 
        ///            Departing:  Malaga 12:30hrs Arriving:  Glasgow 14:45hrs 
        ///Child  £313.87
        /// x2 £627.74 
        ///      
        ///  
        ///Infant  £50.00
        /// x2 £100.00 
        ///
        ///
        ///
        ///  Total  £2397.09 
        ///
        ///
        ///
        ///
        ///Add/Amend Flights
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///Flight Extras 
        ///
        ///
        ///Flight 1Prepaid Baggage **
        ///  Free x7 Free 
        ///
        ///
        ///Flight extras are available for this flight by clicking on ''Add/Amend Flight Extras'' button.
        ///        
        ///
        ///
        ///
        ///
        ///** We have included a luggage allowance for each passenger (excluding infants) in our package prices. Most airlines offer an allowance of between 20-22kg, this will be confirmed on your invoice.
        ///        
        ///  
        ///Add/Amend Flight Extras
        ///
        ///
        ///
        ///
        ///
        ///
        ///Package Total (Villa + Flights)      £2397.09
        ///
        ///
        ///
        ///
        ///
        ///
        /// 
        /// 
        ///
        ///
        ///
        ///Villa Extras  
        /// Price Quantity Total 
        ///
        ///
        /// 
        ///
        ///
        ///
        ///Cots Free x2 Free 
        ///
        ///Z-Bed Free x1 Free 
        ///
        ///High Chair Free x2 Free 
        ///
        ///   
        ///
        ///
        ///
        ///Add/Amend Villa Extras
        ///
        /// 
        ///
        ///
        ///
        ///Car Hire  
        /// Price Quantity Total 
        ///
        ///
        ///
        ///
        ///
        ///
        ///Car Hire 1 (Flight 1)       
        ///
        ///Group 1A - FORD KA or similar, Manual, Air Con, 3 doors, 4 seats - for 7 days £137.00 x1 £137.00 
        ///
        ///Collect from airport Free - - 
        ///
        ///Return to airport Free - - 
        ///
        ///Child seats (Payable locally) €35.00 - - 
        ///
        ///
        ///Car Hire 2 (Flight 1)       
        ///
        ///Group 1H - VW PASSAT ESTATE or similar, Manual, Air Con, 5 doors, 5 seats - for 7 days £229.00 x1 £229.00 
        ///
        ///Collect from airport Free - - 
        ///
        ///Return to airport Free - - 
        ///
        ///Child seats (Payable locally) €35.00 x3 - 
        ///
        ///
        ///
        ///
        ///  
        ///Add/Amend Car Hire
        ///
        ///
        ///
        ///
        ///
        ///
        ///Private Transfers  
        /// Price Quantity Total 
        ///
        ///
        ///
        ///
        ///Private Transfer 1 (Flight 1) : 5 Adults, 2 Children, 2 Infants from        
        ///Airport (Malaga) to Villa - Fri 02 May 2014  £82.00 x1 £82.00 
        ///
        ///Private Transfer 1 (Flight 1) : 5 Adults, 2 Children, 2 Infants from        
        ///Villa to Airport (Malaga) - Fri 09 May 2014  £82.00 x1 £82.00 
        ///
        ///Private Transfer 2 (Flight 1) : 5 Adults, 2 Children, 2 Infants from        
        ///Airport (Malaga) to Villa - Fri 02 May 2014  £132.00 x1 £132.00 
        ///
        ///Private Transfer 2 (Flight 1) : 5 Adults, 2 Children, 2 Infants from        
        ///Villa to Airport (Malaga) - Fri 09 May 2014  £132.00 x1 £132.00 
        ///
        ///
        ///  
        ///Add/Amend Transfers
        ///
        ///
        ///
        ///
        ///
        ///
        ///Travel Insurance  
        /// Price Quantity Total 
        ///
        ///
        ///
        ///
        ///Adult Single Trip Policy  £22.00 x1 £22.00 
        ///
        ///Child Single Trip Policy  £14.00 x1 £14.00 
        ///
        ///Snr Citizen Single Trip Policy  £44.00 x1 £44.00 
        ///
        ///Family Single Trip Policy  £55.00 x1 £55.00 
        ///
        ///Family Insurance is cheaper than individual policies and it will save you upto £44.00     
        ///
        ///  
        ///Add/Amend Insurance
        ///
        ///
        ///
        ///
        ///
        ///ADW (Accidental Damage Waiver)    Total 
        ///
        ///
        ///NOTE: The ADW amount is subject to change or the ADW may change to Security Deposit based on the selected passenge details.£63.00 
        ///
        ///
        ///
        ///
        ///
        ///
        ///ATOL Protection Contribution
        /// Price Quantity Total 
        ///
        ///Your Financial Protection£2.50x7£17.50
        ///
        ///
        ///
        ///
        ///
        ///£2.50 per person of the cost of this air holiday package is paid to the Civil Aviation Authority to provide ATOL protection to you. This means the money paid for these arrangements is fully protected. Our ATOL number is 2323 and our registered trading name is Villa Plus Ltd. For more information see our booking terms & conditions.
        /// 
        ///
        ///
        ///
        ///
        ///
        /// 
        ///Would you like to add flights?   
        ///
        ///
        ///
        ///
        ///
        ///This holiday will cost you just £-20.08 per person (approximate) extra with flights from London Gatwick.£3326.09
        ///
        ///By adding flights your holiday will be protected by our ATOL 
        ///
        ///Include Flights
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        /// 
        /// 
        ///Back
        ///
        ///Continue
        ///
        ///
        ///
        ///
        ///
        ///
        /// 
        ///
        ///
        ///
        /// 
        ///
        ///
        ///
        ///
        ///
        ///Please wait...'
        /// </summary>
        public string UIYourHolidaySummaryViCellInnerText = "\r\nYour Holiday Summary\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nVilla Tres Olivos, Nerja, Costa del Sol\r\n\r\n" +
            "5 Adults, 2 Children, 2 Infants departing on 02 May 2014 for 7 nights, from Glas" +
            "gow to Malaga\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n \r\n\r\n\r\n\r\n\r\n\r\nVilla Overview\r\n" +
            "\r\n\r\n3 BEDROOMS\r\n2 BATHROOMS\r\nSLEEPS 2 TO 7\r\nBEACH 3 MILES\r\nPOOL 21 X 13 FT\r\nFREE" +
            " AIR CON\r\nCAR ESSENTIAL\r\n\r\nBoasting fantastic panoramic views over Spain\'s south" +
            "ern coast to the sea, this delightful 3 bedroom villa enjoys a great location in" +
            " the sought after town of Nerja. The shops and eateries of Nerja as well as the " +
            "beautiful, expansive golden beach are all within a short drive and the villa als" +
            "o benefits from air conditioning/heating in the bedrooms at no extra cost.\r\n\r\nIn" +
            "cluded FREE with your villa\r\n\r\n\r\nAir Conditioning/Heating\r\nChildgate(s)  \r\n\r\nTab" +
            "le Tennis Table\r\nPool/Billiard Table\r\n\r\nSatellite TV\r\nMicrowave\r\n \r\n \r\n\r\n\r\n\r\n\r\n\r" +
            "\nPackage Holiday Details    All timings are local and shown in 24hr format\r\n Pri" +
            "ce Quantity Total \r\n\r\n\r\n\r\n\r\n\r\nVilla Tres Olivos, Nerja, Costa del Sol      \r\n7 n" +
            "ights from 02 May 2014 to 09 May 2014        \r\n\r\n\r\n\r\n\r\nFlights \r\n\r\n\r\n1: (Jet2 - " +
            "NoFrills)   5 Adults, 2 Children, 2 Infants\r\n\r\n\r\nFri 02 May 2014 \r\n            D" +
            "eparting: Glasgow 07:30hrs Arriving:  Malaga 11:45hrs \r\nAdult  £333.87\r\n x5 £166" +
            "9.35 \r\n\r\n\r\nFri 09 May 2014 \r\n            Departing:  Malaga 12:30hrs Arriving:  " +
            "Glasgow 14:45hrs \r\nChild  £313.87\r\n x2 £627.74 \r\n      \r\n  \r\nInfant  £50.00\r\n x2" +
            " £100.00 \r\n\r\n\r\n\r\n  Total  £2397.09 \r\n\r\n\r\n\r\n\r\nAdd/Amend Flights\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
            "\r\n\r\nFlight Extras \r\n\r\n\r\nFlight 1Prepaid Baggage **\r\n  Free x7 Free \r\n\r\n\r\nFlight " +
            "extras are available for this flight by clicking on \'\'Add/Amend Flight Extras\'\' " +
            "button.\r\n        \r\n\r\n\r\n\r\n\r\n** We have included a luggage allowance for each pass" +
            "enger (excluding infants) in our package prices. Most airlines offer an allowanc" +
            "e of between 20-22kg, this will be confirmed on your invoice.\r\n        \r\n  \r\nAdd" +
            "/Amend Flight Extras\r\n\r\n\r\n\r\n\r\n\r\n\r\nPackage Total (Villa + Flights)      £2397.09\r" +
            "\n\r\n\r\n\r\n\r\n\r\n\r\n \r\n \r\n\r\n\r\n\r\nVilla Extras  \r\n Price Quantity Total \r\n\r\n\r\n \r\n\r\n\r\n\r\nCo" +
            "ts Free x2 Free \r\n\r\nZ-Bed Free x1 Free \r\n\r\nHigh Chair Free x2 Free \r\n\r\n   \r\n\r\n\r\n" +
            "\r\nAdd/Amend Villa Extras\r\n\r\n \r\n\r\n\r\n\r\nCar Hire  \r\n Price Quantity Total \r\n\r\n\r\n\r\n\r" +
            "\n\r\n\r\nCar Hire 1 (Flight 1)       \r\n\r\nGroup 1A - FORD KA or similar, Manual, Air " +
            "Con, 3 doors, 4 seats - for 7 days £137.00 x1 £137.00 \r\n\r\nCollect from airport F" +
            "ree - - \r\n\r\nReturn to airport Free - - \r\n\r\nChild seats (Payable locally) €35.00 " +
            "- - \r\n\r\n\r\nCar Hire 2 (Flight 1)       \r\n\r\nGroup 1H - VW PASSAT ESTATE or similar" +
            ", Manual, Air Con, 5 doors, 5 seats - for 7 days £229.00 x1 £229.00 \r\n\r\nCollect " +
            "from airport Free - - \r\n\r\nReturn to airport Free - - \r\n\r\nChild seats (Payable lo" +
            "cally) €35.00 x3 - \r\n\r\n\r\n\r\n\r\n  \r\nAdd/Amend Car Hire\r\n\r\n\r\n\r\n\r\n\r\n\r\nPrivate Transfe" +
            "rs  \r\n Price Quantity Total \r\n\r\n\r\n\r\n\r\nPrivate Transfer 1 (Flight 1) : 5 Adults, " +
            "2 Children, 2 Infants from        \r\nAirport (Malaga) to Villa - Fri 02 May 2014 " +
            " £82.00 x1 £82.00 \r\n\r\nPrivate Transfer 1 (Flight 1) : 5 Adults, 2 Children, 2 In" +
            "fants from        \r\nVilla to Airport (Malaga) - Fri 09 May 2014  £82.00 x1 £82.0" +
            "0 \r\n\r\nPrivate Transfer 2 (Flight 1) : 5 Adults, 2 Children, 2 Infants from      " +
            "  \r\nAirport (Malaga) to Villa - Fri 02 May 2014  £132.00 x1 £132.00 \r\n\r\nPrivate " +
            "Transfer 2 (Flight 1) : 5 Adults, 2 Children, 2 Infants from        \r\nVilla to A" +
            "irport (Malaga) - Fri 09 May 2014  £132.00 x1 £132.00 \r\n\r\n\r\n  \r\nAdd/Amend Transf" +
            "ers\r\n\r\n\r\n\r\n\r\n\r\n\r\nTravel Insurance  \r\n Price Quantity Total \r\n\r\n\r\n\r\n\r\nAdult Singl" +
            "e Trip Policy  £22.00 x1 £22.00 \r\n\r\nChild Single Trip Policy  £14.00 x1 £14.00 \r" +
            "\n\r\nSnr Citizen Single Trip Policy  £44.00 x1 £44.00 \r\n\r\nFamily Single Trip Polic" +
            "y  £55.00 x1 £55.00 \r\n\r\nFamily Insurance is cheaper than individual policies and" +
            " it will save you upto £44.00     \r\n\r\n  \r\nAdd/Amend Insurance\r\n\r\n\r\n\r\n\r\n\r\nADW (Ac" +
            "cidental Damage Waiver)    Total \r\n\r\n\r\nNOTE: The ADW amount is subject to change" +
            " or the ADW may change to Security Deposit based on the selected passenge detail" +
            "s.£63.00 \r\n\r\n\r\n\r\n\r\n\r\n\r\nATOL Protection Contribution\r\n Price Quantity Total \r\n\r\nY" +
            "our Financial Protection£2.50x7£17.50\r\n\r\n\r\n\r\n\r\n\r\n£2.50 per person of the cost of" +
            " this air holiday package is paid to the Civil Aviation Authority to provide ATO" +
            "L protection to you. This means the money paid for these arrangements is fully p" +
            "rotected. Our ATOL number is 2323 and our registered trading name is Villa Plus " +
            "Ltd. For more information see our booking terms & conditions.\r\n \r\n\r\n\r\n\r\n\r\n\r\n \r\nW" +
            "ould you like to add flights?   \r\n\r\n\r\n\r\n\r\n\r\nThis holiday will cost you just £-20" +
            ".08 per person (approximate) extra with flights from London Gatwick.£3326.09\r\n\r\n" +
            "By adding flights your holiday will be protected by our ATOL \r\n\r\nInclude Flights" +
            "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n \r\n \r\nBack\r\n\r\nContinue\r\n\r\n\r\n\r\n\r\n\r\n\r\n \r\n\r\n\r\n\r\n \r\n\r\n\r\n\r\n\r\n\r\nPlease" +
            " wait...";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
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
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIYourHolidaySummaryDocument : HtmlDocument
    {
        
        public UIYourHolidaySummaryDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your Holiday Summary", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/default.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/default.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UITblMainTable UITblMainTable
        {
            get
            {
                if ((this.mUITblMainTable == null))
                {
                    this.mUITblMainTable = new UITblMainTable(this);
                }
                return this.mUITblMainTable;
            }
        }
        #endregion
        
        #region Fields
        private UITblMainTable mUITblMainTable;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UITblMainTable : HtmlTable
    {
        
        public UITblMainTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlTable.PropertyNames.Id] = "tblMain";
            this.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "Your Holiday Summary", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "width=\"1054\" align=\"center\" id=\"tblMain\" style=\"visibility: visible; background-c" +
                "olor: rgb(255, 255, 255);\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIYourHolidaySummaryViCell
        {
            get
            {
                if ((this.mUIYourHolidaySummaryViCell == null))
                {
                    this.mUIYourHolidaySummaryViCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIYourHolidaySummaryViCell.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "Your Holiday Summary", PropertyExpressionOperator.Contains));
                    this.mUIYourHolidaySummaryViCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "width=\"100%\" valign=\"top\"";
                    this.mUIYourHolidaySummaryViCell.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIYourHolidaySummaryViCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIYourHolidaySummaryViCell;
        #endregion
    }
}
