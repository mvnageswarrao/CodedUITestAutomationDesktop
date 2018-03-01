﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.clickLaterFrmFlightInfoPopup_MapClasses
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
    public partial class clickLaterFrmFlightInfoPopup_Map:logWriter
    {
        
        /// <summary>
        /// clickLaterFrmFlightInfoPopup_Method
        /// </summary>
        public void clickLaterFrmFlightInfoPopup_Method()
        {
            #region Variable Declarations
            HtmlInputButton uILaterButton = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIYourFlightInformatioFrame.UIYourFlightInformatioDocument.UILaterButton;
            #endregion
                        
            try
            {
                // Click 'Later' button
                Mouse.Click(uILaterButton, new Point(32, 14));
                WriteLogs("PASS : \"Later\" Button Clicked From \"Flight Info\" Popup.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("clickLaterFrmFlightInfoPopup");
                WriteLogs("FAIL : Could not Click \"Later\" Button From \"Flight Info\" Popup.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
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
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
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
        public UIYourFlightInformatioFrame UIYourFlightInformatioFrame
        {
            get
            {
                if ((this.mUIYourFlightInformatioFrame == null))
                {
                    this.mUIYourFlightInformatioFrame = new UIYourFlightInformatioFrame(this);
                }
                return this.mUIYourFlightInformatioFrame;
            }
        }
        #endregion
        
        #region Fields
        private UIYourFlightInformatioFrame mUIYourFlightInformatioFrame;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIYourFlightInformatioFrame : HtmlIFrame
    {
        
        public UIYourFlightInformatioFrame(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "iFrmCustFlightInfo";
            this.SearchProperties[HtmlFrame.PropertyNames.Name] = "iFrmCustFlightInfo";
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.AbsolutePath, "/code_net/booking/CustomerBookedFlightInfo.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.PageUrl, "/code_net/booking/CustomerBookedFlightInfo.aspx?bookingRefNumber=", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.Title, "Your Flight Information", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlFrame.PropertyNames.ControlDefinition] = "name=\"iFrmCustFlightInfo\" width=\"610\" he";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIYourFlightInformatioDocument UIYourFlightInformatioDocument
        {
            get
            {
                if ((this.mUIYourFlightInformatioDocument == null))
                {
                    this.mUIYourFlightInformatioDocument = new UIYourFlightInformatioDocument(this);
                }
                return this.mUIYourFlightInformatioDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYourFlightInformatioDocument mUIYourFlightInformatioDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIYourFlightInformatioDocument : HtmlDocument
    {
        
        public UIYourFlightInformatioDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your Flight Information", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/CustomerBookedFlightInfo.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/CustomerBookedFlightInfo.aspx?bookingRefNumber=", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlInputButton UILaterButton
        {
            get
            {
                if ((this.mUILaterButton == null))
                {
                    this.mUILaterButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUILaterButton.SearchProperties[HtmlButton.PropertyNames.Id] = "ctl00_ContentPlaceHolder1_CustFlightInfo_imgLater";
                    this.mUILaterButton.SearchProperties[HtmlButton.PropertyNames.Name] = "ctl00$ContentPlaceHolder1$CustFlightInfo$imgLater";
                    this.mUILaterButton.FilterProperties[HtmlButton.PropertyNames.Type] = "image";
                    this.mUILaterButton.FilterProperties.Add(new PropertyExpression("Src", "/imgs/vp/buttons/later.gif", PropertyExpressionOperator.Contains));
                    this.mUILaterButton.FilterProperties[HtmlButton.PropertyNames.Title] = "Later";
                    this.mUILaterButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "name=\"ctl00$ContentPlaceHolder1$CustFlig";
                    this.mUILaterButton.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUILaterButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlInputButton mUILaterButton;
        #endregion
    }
}
