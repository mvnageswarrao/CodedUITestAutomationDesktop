﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.AddAmendFlights.clickHideOptions_MapClasses
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
    public partial class clickHideOptions_Map:logWriter
    {
        
        /// <summary>
        /// clickHideOptions_Method
        /// </summary>
        public void clickHideOptions_Method()
        {
            #region Variable Declarations
            HtmlDiv uIHideFlightOptionsPane = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAmendFlightsSelectioFrame.UIVillaPlusQualityholiDocument.UIHideFlightOptionsPane;
            #endregion

            try
            {
                // Click 'Hide Flight Options' pane
                Mouse.Click(uIHideFlightOptionsPane, new Point(88, 24));
                WriteLogs("PASS : Hide Options Buttion Clicked.");
            }

            catch (AssertFailedException ex)
            {
                takeImage("clickHideOptions");
                WriteLogs("FAIL : Hide Options Button Could not be Clicked.");
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
        public UIAmendFlightsSelectioFrame UIAmendFlightsSelectioFrame
        {
            get
            {
                if ((this.mUIAmendFlightsSelectioFrame == null))
                {
                    this.mUIAmendFlightsSelectioFrame = new UIAmendFlightsSelectioFrame(this);
                }
                return this.mUIAmendFlightsSelectioFrame;
            }
        }
        #endregion
        
        #region Fields
        private UIAmendFlightsSelectioFrame mUIAmendFlightsSelectioFrame;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAmendFlightsSelectioFrame : HtmlIFrame
    {
        
        public UIAmendFlightsSelectioFrame(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "amendFlightsSelection";
            this.SearchProperties[HtmlFrame.PropertyNames.Name] = "amendFlightsSelection";
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.AbsolutePath, "AmendFlight.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.PageUrl, "AmendFlight.aspx?refNo=", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.ControlDefinition, "name=\"amendFlightsSelection\" id=\"amendFl", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIVillaPlusQualityholiDocument UIVillaPlusQualityholiDocument
        {
            get
            {
                if ((this.mUIVillaPlusQualityholiDocument == null))
                {
                    this.mUIVillaPlusQualityholiDocument = new UIVillaPlusQualityholiDocument(this);
                }
                return this.mUIVillaPlusQualityholiDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPlusQualityholiDocument mUIVillaPlusQualityholiDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaPlusQualityholiDocument : HtmlDocument
    {
        
        public UIVillaPlusQualityholiDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/AmendFlight.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/AmendFlight.aspx?refNo=", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIHideFlightOptionsPane
        {
            get
            {
                if ((this.mUIHideFlightOptionsPane == null))
                {
                    this.mUIHideFlightOptionsPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIHideFlightOptionsPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "cmdViewAlternates";
                    this.mUIHideFlightOptionsPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Hide Flight Options";
                    this.mUIHideFlightOptionsPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "orangeButtons";
                    this.mUIHideFlightOptionsPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"orangeButtons\" id=\"cmdViewAlternates\" style=\"width: 150px;\"";
                    this.mUIHideFlightOptionsPane.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIHideFlightOptionsPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIHideFlightOptionsPane;
        #endregion
    }
}