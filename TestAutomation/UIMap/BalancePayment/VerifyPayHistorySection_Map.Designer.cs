﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BalancePayment.VerifyPayHistorySection_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class VerifyPayHistorySection_Map : logWriter
    {
        
        /// <summary>
        /// VerifyPayHistorySection_Method - Use 'VerifyPayHistorySection_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyPayHistorySection_Method(string Reference,string payhistory)
        {
            #region Variable Declarations
            HtmlCell uIYourHolidayBookingReCell = this.UIVillaPlusBalancePaymWindow.UIVillaPlusBalancePaymDocument.UIFrmBalancePaymentCustom.UIItemTable1.UIYourHolidayBookingReCell;
            #endregion

            // Verify that the 'InnerText' property of 'Your Holiday Booking Ref: E7B34F' cell contains '
            //
            //
            //
            //Booking Ref: E7B34F
            //
            //
            //
            //
            //The balance of £1923.16 is due on Mon 07 Mar 2016 which is 12 weeks before your departure date.
            //Holiday Cost£4553.58
            //
            //Credit Charge£12.30
            //
            //
            //
            //Total Cost£4565.88
            //
            //
            //
            //Total Paid£2642.72
            //
            //Refund£0.00
            //
            //
            //
            //Outstanding Balance£1923.16
            //
            //
            //
            //
            //
            //
            //
            //Important Information:
            //
            //No charge for debit cards issued in UK.
            //2.00% charge for payments made by credit card or non UK Debit cards when paying online.
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //  Package Holiday Details 
            //
            //
            //Peyia Melina, Peyia, Cyprus 
            //
            //7 nights from Sun 29 May 2016 to 10am Sun 05 Jun 2016
            //
            //
            //
            //
            //Flight Ref No. : 829769 - TUI - First Choice (FIR) : Villa Plus Booked 
            //TOM2700 Sun 29 May 2016, Departure: Manchester Intl 09:15, Arrival: Larnaca 16:00
            //TOM2701 Sun 05 Jun 2016, Departure: Larnaca 17:15, Arrival: Manchester Intl 20:25
            //
            //
            //
            //
            //Package Holiday CostPriceQuantityTotal
            //
            //
            //
            //
            //
            //Flight Ref No. : 829769 
            //
            //
            //
            //
            //
            //
            //Adults£757.43x4£3029.72
            //
            //
            //
            //
            //
            //Child£727.43x2£1454.86
            //
            //
            //Total£4484.58
            //
            //
            //
            //
            //
            //  Villa Extras PriceQuantityTotal
            //
            //
            //
            //Childgates--£0.00
            //
            //
            //
            //
            //
            //Accidental Damage Waiver - 2 Bedrooms @ £20.00 each--£54.00
            //
            //
            //
            //ATOL Protection Contribution£2.50x6£15.00
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //  Total Holiday Amounts and Payments 
            //
            //
            //The balance of £1923.16 is due on Mon 07 Mar 2016 which is 12 weeks before your departure date.
            //Holiday Cost£4553.58
            //
            //Credit Charge£12.30
            //
            //
            //
            //Total Cost£4565.88
            //
            //
            //
            //Total Paid£2642.72
            //
            //Refund£0.00
            //
            //
            //
            //Outstanding Balance£1923.16
            //
            //
            //
            //
            //
            //
            //
            //
            //Important Information:
            //
            //No charge for debit cards issued in UK.
            //2.00% charge for payments made by credit card or non UK Debit cards when paying online.
            //
            //
            //
            //
            //
            //  Payment History 
            //
            //
            //DateReferenceHoliday PaymentCard ChargeTotal Payment
            //
            //17 Oct 2015************0643£950.00£0.00(0.00%)£950.00
            //
            //30 Aug 2015************0643£1065.42£0.00(0.00%)£1065.42
            //
            //02 Jul 2015************8908£615.00£12.30(2.00%)£627.30
            //
            //
            //
            //
            //
            //
            //
            //
            //Totals£2630.42£12.30£2642.72
            //
            //
            //
            //
            //
            //
            //
            //  Passenger Details 
            //
            //
            //NamesFlightMobility RequirementsTravel Insurance
            //
            //
            //1)* Miss.Rebecca BagnallRef No. : 829769- - 
            //
            //2)* Mr.Marc BuckleyRef No. : 829769- - 
            //
            //3)* Mrs.Susan BuckleyRef No. : 829769- - 
            //
            //4)* Mr.Barrie BuckleyRef No. : 829769- - 
            //
            //5)* Mast.Sam BuckleyRef No. : 829769- - 
            //
            //6)* Miss.Cameron BuckleyRef No. : 829769- - 
            //
            //
            //* Lead Passengers for the respective flights.
            //
            //
            //
            //
            //
            //  Lead Passengers 
            //
            //
            //
            //
            //Flight Ref No. : 829769
            //
            //Miss Rebecca Bagnall
            //
            //
            //
            //4 John Nelson Close
            //
            //
            //
            //Batley
            //
            //West Yorkshire
            //
            //
            //
            //WF17 0RA
            //
            //
            //
            //
            //Contact Details
            //
            //Tel:07432605301
            //
            //Mobile:07432605301
            //
            //Email: beckybagnall85@hotmail.com
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //
            //Company
            //Contact us
            //Booking Conditions
            //Health and Safety
            //Useful Info
            //Eco Policy
            //How to Book
            //Travel Insurance
            //Feedback
            //Villa Owners
            //
            //
            //Website
            //Terms of Use
            //Privacy
            //Cookie Policy
            //Holiday Games Guide
            //Top Travel Tech
            //Sitemap
            //Cost of eating out
            //Villa Plus Blog
            //
            //
            //Book with confidence
            //
            //Your money is 100% safe with Villa Plus!
            //
            //
            //
            //
            //
            //
            //
            //
            //Get Social
            //
            //Join the Villa Plus community
            //
            //71.2K  
            //
            //5.8K  
            //
            //247  
            //
            //Visit  
            //
            //Website Design by Villa Plus 
            //
            //© 2015 Villa Plus Ltd. 
            //
            //Version 5.01.0073   -  Web1  -  Last Updated On: 05 Jun 2015 '

        //    StringAssert.Contains(uIYourHolidayBookingReCell.InnerText, this.VerifyPayHistorySection_MethodExpectedValues.UIYourHolidayBookingReCellInnerText);

            try
            {
                StringAssert.Contains(uIYourHolidayBookingReCell.InnerText, payhistory );
                StringAssert.Contains(uIYourHolidayBookingReCell.InnerText, Reference);

                WriteLogs("PASS : Payment history is matched with value in database - payment  " + payhistory+" : VERIFICATION");

            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Payment history does not matched with value in database " + payhistory+" : VERIFICATION");

            }
        }
        
        #region Properties
        public virtual VerifyPayHistorySection_MethodExpectedValues VerifyPayHistorySection_MethodExpectedValues
        {
            get
            {
                if ((this.mVerifyPayHistorySection_MethodExpectedValues == null))
                {
                    this.mVerifyPayHistorySection_MethodExpectedValues = new VerifyPayHistorySection_MethodExpectedValues();
                }
                return this.mVerifyPayHistorySection_MethodExpectedValues;
            }
        }
        
        public UIVillaPlusBalancePaymWindow UIVillaPlusBalancePaymWindow
        {
            get
            {
                if ((this.mUIVillaPlusBalancePaymWindow == null))
                {
                    this.mUIVillaPlusBalancePaymWindow = new UIVillaPlusBalancePaymWindow();
                }
                return this.mUIVillaPlusBalancePaymWindow;
            }
        }
        #endregion
        
        #region Fields
        private VerifyPayHistorySection_MethodExpectedValues mVerifyPayHistorySection_MethodExpectedValues;
        
        private UIVillaPlusBalancePaymWindow mUIVillaPlusBalancePaymWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'VerifyPayHistorySection_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class VerifyPayHistorySection_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Your Holiday Booking Ref: E7B34F' cell contains '
        ///
        ///
        ///
        ///Booking Ref: E7B34F
        ///
        ///
        ///
        ///
        ///The balance of £1923.16 is due on Mon 07 Mar 2016 which is 12 weeks before your departure date.
        ///Holiday Cost£4553.58
        ///
        ///Credit Charge£12.30
        ///
        ///
        ///
        ///Total Cost£4565.88
        ///
        ///
        ///
        ///Total Paid£2642.72
        ///
        ///Refund£0.00
        ///
        ///
        ///
        ///Outstanding Balance£1923.16
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///Important Information:
        ///
        ///No charge for debit cards issued in UK.
        ///2.00% charge for payments made by credit card or non UK Debit cards when paying online.
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
        ///  Package Holiday Details 
        ///
        ///
        ///Peyia Melina, Peyia, Cyprus 
        ///
        ///7 nights from Sun 29 May 2016 to 10am Sun 05 Jun 2016
        ///
        ///
        ///
        ///
        ///Flight Ref No. : 829769 - TUI - First Choice (FIR) : Villa Plus Booked 
        ///TOM2700 Sun 29 May 2016, Departure: Manchester Intl 09:15, Arrival: Larnaca 16:00
        ///TOM2701 Sun 05 Jun 2016, Departure: Larnaca 17:15, Arrival: Manchester Intl 20:25
        ///
        ///
        ///
        ///
        ///Package Holiday CostPriceQuantityTotal
        ///
        ///
        ///
        ///
        ///
        ///Flight Ref No. : 829769 
        ///
        ///
        ///
        ///
        ///
        ///
        ///Adults£757.43x4£3029.72
        ///
        ///
        ///
        ///
        ///
        ///Child£727.43x2£1454.86
        ///
        ///
        ///Total£4484.58
        ///
        ///
        ///
        ///
        ///
        ///  Villa Extras PriceQuantityTotal
        ///
        ///
        ///
        ///Childgates--£0.00
        ///
        ///
        ///
        ///
        ///
        ///Accidental Damage Waiver - 2 Bedrooms @ £20.00 each--£54.00
        ///
        ///
        ///
        ///ATOL Protection Contribution£2.50x6£15.00
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
        ///  Total Holiday Amounts and Payments 
        ///
        ///
        ///The balance of £1923.16 is due on Mon 07 Mar 2016 which is 12 weeks before your departure date.
        ///Holiday Cost£4553.58
        ///
        ///Credit Charge£12.30
        ///
        ///
        ///
        ///Total Cost£4565.88
        ///
        ///
        ///
        ///Total Paid£2642.72
        ///
        ///Refund£0.00
        ///
        ///
        ///
        ///Outstanding Balance£1923.16
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///Important Information:
        ///
        ///No charge for debit cards issued in UK.
        ///2.00% charge for payments made by credit card or non UK Debit cards when paying online.
        ///
        ///
        ///
        ///
        ///
        ///  Payment History 
        ///
        ///
        ///DateReferenceHoliday PaymentCard ChargeTotal Payment
        ///
        ///17 Oct 2015************0643£950.00£0.00(0.00%)£950.00
        ///
        ///30 Aug 2015************0643£1065.42£0.00(0.00%)£1065.42
        ///
        ///02 Jul 2015************8908£615.00£12.30(2.00%)£627.30
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///Totals£2630.42£12.30£2642.72
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///  Passenger Details 
        ///
        ///
        ///NamesFlightMobility RequirementsTravel Insurance
        ///
        ///
        ///1)* Miss.Rebecca BagnallRef No. : 829769- - 
        ///
        ///2)* Mr.Marc BuckleyRef No. : 829769- - 
        ///
        ///3)* Mrs.Susan BuckleyRef No. : 829769- - 
        ///
        ///4)* Mr.Barrie BuckleyRef No. : 829769- - 
        ///
        ///5)* Mast.Sam BuckleyRef No. : 829769- - 
        ///
        ///6)* Miss.Cameron BuckleyRef No. : 829769- - 
        ///
        ///
        ///* Lead Passengers for the respective flights.
        ///
        ///
        ///
        ///
        ///
        ///  Lead Passengers 
        ///
        ///
        ///
        ///
        ///Flight Ref No. : 829769
        ///
        ///Miss Rebecca Bagnall
        ///
        ///
        ///
        ///4 John Nelson Close
        ///
        ///
        ///
        ///Batley
        ///
        ///West Yorkshire
        ///
        ///
        ///
        ///WF17 0RA
        ///
        ///
        ///
        ///
        ///Contact Details
        ///
        ///Tel:07432605301
        ///
        ///Mobile:07432605301
        ///
        ///Email: beckybagnall85@hotmail.com
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
        ///Company
        ///Contact us
        ///Booking Conditions
        ///Health and Safety
        ///Useful Info
        ///Eco Policy
        ///How to Book
        ///Travel Insurance
        ///Feedback
        ///Villa Owners
        ///
        ///
        ///Website
        ///Terms of Use
        ///Privacy
        ///Cookie Policy
        ///Holiday Games Guide
        ///Top Travel Tech
        ///Sitemap
        ///Cost of eating out
        ///Villa Plus Blog
        ///
        ///
        ///Book with confidence
        ///
        ///Your money is 100% safe with Villa Plus!
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///
        ///Get Social
        ///
        ///Join the Villa Plus community
        ///
        ///71.2K  
        ///
        ///5.8K  
        ///
        ///247  
        ///
        ///Visit  
        ///
        ///Website Design by Villa Plus 
        ///
        ///© 2015 Villa Plus Ltd. 
        ///
        ///Version 5.01.0073   -  Web1  -  Last Updated On: 05 Jun 2015 '
        /// </summary>
        public string UIYourHolidayBookingReCellInnerText = "\r\n\r\n\r\n\r\nBooking Ref: E7B34F\r\n\r\n\r\n\r\n\r\nThe balance of £1923.16 is due on Mon 07 Mar" +
            " 2016 which is 12 weeks before your departure date.\r\nHoliday Cost£4553.58\r\n\r\nCre" +
            "dit Charge£12.30\r\n\r\n\r\n\r\nTotal Cost£4565.88\r\n\r\n\r\n\r\nTotal Paid£2642.72\r\n\r\nRefund£0" +
            ".00\r\n\r\n\r\n\r\nOutstanding Balance£1923.16\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nImportant Information:\r\n\r\n" +
            "No charge for debit cards issued in UK.\r\n2.00% charge for payments made by credi" +
            "t card or non UK Debit cards when paying online.\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n  Packag" +
            "e Holiday Details \r\n\r\n\r\nPeyia Melina, Peyia, Cyprus \r\n\r\n7 nights from Sun 29 May" +
            " 2016 to 10am Sun 05 Jun 2016\r\n\r\n\r\n\r\n\r\nFlight Ref No. : 829769 - TUI - First Cho" +
            "ice (FIR) : Villa Plus Booked \r\nTOM2700 Sun 29 May 2016, Departure: Manchester I" +
            "ntl 09:15, Arrival: Larnaca 16:00\r\nTOM2701 Sun 05 Jun 2016, Departure: Larnaca 1" +
            "7:15, Arrival: Manchester Intl 20:25\r\n\r\n\r\n\r\n\r\nPackage Holiday CostPriceQuantityT" +
            "otal\r\n\r\n\r\n\r\n\r\n\r\nFlight Ref No. : 829769 \r\n\r\n\r\n\r\n\r\n\r\n\r\nAdults£757.43x4£3029.72\r\n\r" +
            "\n\r\n\r\n\r\n\r\nChild£727.43x2£1454.86\r\n\r\n\r\nTotal£4484.58\r\n\r\n\r\n\r\n\r\n\r\n  Villa Extras Pri" +
            "ceQuantityTotal\r\n\r\n\r\n\r\nChildgates--£0.00\r\n\r\n\r\n\r\n\r\n\r\nAccidental Damage Waiver - 2" +
            " Bedrooms @ £20.00 each--£54.00\r\n\r\n\r\n\r\nATOL Protection Contribution£2.50x6£15.00" +
            "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n  Total Holiday Amounts and Payments \r\n\r\n\r\nThe balance of " +
            "£1923.16 is due on Mon 07 Mar 2016 which is 12 weeks before your departure date." +
            "\r\nHoliday Cost£4553.58\r\n\r\nCredit Charge£12.30\r\n\r\n\r\n\r\nTotal Cost£4565.88\r\n\r\n\r\n\r\nT" +
            "otal Paid£2642.72\r\n\r\nRefund£0.00\r\n\r\n\r\n\r\nOutstanding Balance£1923.16\r\n\r\n\r\n\r\n\r\n\r\n\r" +
            "\n\r\n\r\nImportant Information:\r\n\r\nNo charge for debit cards issued in UK.\r\n2.00% ch" +
            "arge for payments made by credit card or non UK Debit cards when paying online.\r" +
            "\n\r\n\r\n\r\n\r\n\r\n  Payment History \r\n\r\n\r\nDateReferenceHoliday PaymentCard ChargeTotal " +
            "Payment\r\n\r\n17 Oct 2015************0643£950.00£0.00(0.00%)£950.00\r\n\r\n30 Aug 2015*" +
            "***********0643£1065.42£0.00(0.00%)£1065.42\r\n\r\n02 Jul 2015************8908£615.0" +
            "0£12.30(2.00%)£627.30\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nTotals£2630.42£12.30£2642.72\r\n\r\n\r\n\r\n\r\n\r\n\r" +
            "\n\r\n  Passenger Details \r\n\r\n\r\nNamesFlightMobility RequirementsTravel Insurance\r\n\r" +
            "\n\r\n1)* Miss.Rebecca BagnallRef No. : 829769- - \r\n\r\n2)* Mr.Marc BuckleyRef No. : " +
            "829769- - \r\n\r\n3)* Mrs.Susan BuckleyRef No. : 829769- - \r\n\r\n4)* Mr.Barrie Buckley" +
            "Ref No. : 829769- - \r\n\r\n5)* Mast.Sam BuckleyRef No. : 829769- - \r\n\r\n6)* Miss.Cam" +
            "eron BuckleyRef No. : 829769- - \r\n\r\n\r\n* Lead Passengers for the respective fligh" +
            "ts.\r\n\r\n\r\n\r\n\r\n\r\n  Lead Passengers \r\n\r\n\r\n\r\n\r\nFlight Ref No. : 829769\r\n\r\nMiss Rebec" +
            "ca Bagnall\r\n\r\n\r\n\r\n4 John Nelson Close\r\n\r\n\r\n\r\nBatley\r\n\r\nWest Yorkshire\r\n\r\n\r\n\r\nWF1" +
            "7 0RA\r\n\r\n\r\n\r\n\r\nContact Details\r\n\r\nTel:07432605301\r\n\r\nMobile:07432605301\r\n\r\nEmail" +
            ": beckybagnall85@hotmail.com\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nCompany\r\nContact us\r\nBoo" +
            "king Conditions\r\nHealth and Safety\r\nUseful Info\r\nEco Policy\r\nHow to Book\r\nTravel" +
            " Insurance\r\nFeedback\r\nVilla Owners\r\n\r\n\r\nWebsite\r\nTerms of Use\r\nPrivacy\r\nCookie P" +
            "olicy\r\nHoliday Games Guide\r\nTop Travel Tech\r\nSitemap\r\nCost of eating out\r\nVilla " +
            "Plus Blog\r\n\r\n\r\nBook with confidence\r\n\r\nYour money is 100% safe with Villa Plus!\r" +
            "\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nGet Social\r\n\r\nJoin the Villa Plus community\r\n\r\n71.2K  \r\n\r\n5.8K " +
            " \r\n\r\n247  \r\n\r\nVisit  \r\n\r\nWebsite Design by Villa Plus \r\n\r\n© 2015 Villa Plus Ltd." +
            " \r\n\r\nVersion 5.01.0073   -  Web1  -  Last Updated On: 05 Jun 2015 ";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIVillaPlusBalancePaymWindow : BrowserWindow
    {
        
        public UIVillaPlusBalancePaymWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Villa Plus Balance Payment";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Plus Balance Payment");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaPlusBalancePaymDocument UIVillaPlusBalancePaymDocument
        {
            get
            {
                if ((this.mUIVillaPlusBalancePaymDocument == null))
                {
                    this.mUIVillaPlusBalancePaymDocument = new UIVillaPlusBalancePaymDocument(this);
                }
                return this.mUIVillaPlusBalancePaymDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPlusBalancePaymDocument mUIVillaPlusBalancePaymDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIVillaPlusBalancePaymDocument : HtmlDocument
    {
        
        public UIVillaPlusBalancePaymDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Villa Plus Balance Payment";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/balancepayments/default.aspx";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/balancepayments/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Plus Balance Payment");
            #endregion
        }
        
        #region Properties
        public UIFrmBalancePaymentCustom UIFrmBalancePaymentCustom
        {
            get
            {
                if ((this.mUIFrmBalancePaymentCustom == null))
                {
                    this.mUIFrmBalancePaymentCustom = new UIFrmBalancePaymentCustom(this);
                }
                return this.mUIFrmBalancePaymentCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIFrmBalancePaymentCustom mUIFrmBalancePaymentCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIFrmBalancePaymentCustom : HtmlCustom
    {
        
        public UIFrmBalancePaymentCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "FORM";
            this.SearchProperties["Id"] = "frmBalancePayment";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties["Class"] = null;
            this.FilterProperties["ControlDefinition"] = "id=\"frmBalancePayment\" onsubmit=\"javascr";
            this.FilterProperties["TagInstance"] = "1";
            this.WindowTitles.Add("Villa Plus Balance Payment");
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
                    this.mUIItemTable.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "width=\"835\" border=\"0\" cellSpacing=\"0\" cellPadding=\"0\"";
                    this.mUIItemTable.FilterProperties[HtmlTable.PropertyNames.RowCount] = "12";
                    this.mUIItemTable.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "1";
                    this.mUIItemTable.FilterProperties[HtmlTable.PropertyNames.Class] = "";
                    this.mUIItemTable.FilterProperties[HtmlTable.PropertyNames.TagInstance] = "19";
                    this.mUIItemTable.WindowTitles.Add("Villa Plus Balance Payment");
                    #endregion
                }
                return this.mUIItemTable;
            }
        }
        
        public UIItemTable1 UIItemTable1
        {
            get
            {
                if ((this.mUIItemTable1 == null))
                {
                    this.mUIItemTable1 = new UIItemTable1(this);
                }
                return this.mUIItemTable1;
            }
        }
        #endregion
        
        #region Fields
        private HtmlTable mUIItemTable;
        
        private UIItemTable1 mUIItemTable1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIItemTable1 : HtmlTable
    {
        
        public UIItemTable1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlTable.PropertyNames.Id] = null;
            this.SearchProperties[HtmlTable.PropertyNames.Name] = null;
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "width=\"835\" border=\"0\" cellSpacing=\"0\" cellPadding=\"0\"";
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "1";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "1";
            this.FilterProperties[HtmlTable.PropertyNames.Class] = "";
            this.FilterProperties[HtmlTable.PropertyNames.TagInstance] = "2";
            this.WindowTitles.Add("Villa Plus Balance Payment");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIYourHolidayBookingReCell
        {
            get
            {
                if ((this.mUIYourHolidayBookingReCell == null))
                {
                    this.mUIYourHolidayBookingReCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIYourHolidayBookingReCell.SearchProperties[HtmlCell.PropertyNames.Id] = "";
                    this.mUIYourHolidayBookingReCell.SearchProperties[HtmlCell.PropertyNames.Name] = "";
                    this.mUIYourHolidayBookingReCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = null;
                    this.mUIYourHolidayBookingReCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "0";
                    this.mUIYourHolidayBookingReCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "0";
                    this.mUIYourHolidayBookingReCell.FilterProperties[HtmlCell.PropertyNames.Class] = null;
                    this.mUIYourHolidayBookingReCell.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "5";
                    this.mUIYourHolidayBookingReCell.WindowTitles.Add("Villa Plus Balance Payment");
                    #endregion
                }
                return this.mUIYourHolidayBookingReCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIYourHolidayBookingReCell;
        #endregion
    }
}
