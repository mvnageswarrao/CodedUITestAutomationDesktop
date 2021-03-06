﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.openAddAmendFlights_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public partial class openAddAmendFlights_Map:logWriter
    {
        
        /// <summary>
        /// openAddAmendFlights_Method
        /// </summary>
        public void openAddAmendFlights_Method()
        {
            #region Variable Declarations
            HtmlDiv uIAddAmendFlightsPane = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAddAmendFlightsPane;
            #endregion

            // Click 'Add/Amend Flights' pane
            Mouse.Click(uIAddAmendFlightsPane, new Point(70, 17));

            try
            {
                Mouse.Click(uIAddAmendFlightsPane, new Point(70, 17));
                WriteLogs("PASS : Add/Amend Flights button is Clicked");
            }
            catch (AssertFailedException ex)
            {
                takeImage("openAddAmendFlights");
                WriteLogs("FAIL : Add/Amend Flights button could not be Clicked");
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
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your Holiday Summary", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/default.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/default.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIAddAmendFlightsPane
        {
            get
            {
                if ((this.mUIAddAmendFlightsPane == null))
                {
                    this.mUIAddAmendFlightsPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIAddAmendFlightsPane.SearchProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Id, "amendFlightAnchor", PropertyExpressionOperator.Contains));
                    this.mUIAddAmendFlightsPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Add/Amend Flights", PropertyExpressionOperator.Contains));
                    this.mUIAddAmendFlightsPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Class, "orangeButtons", PropertyExpressionOperator.Contains));
                    this.mUIAddAmendFlightsPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"orangeButtons\" id=\"amendFlightAnchor\" style=\"width: 150px; float: right;\" " +
                                "onclick=\"javascript:js_controller_booking(\'amendFlights\',\'click\');\"", PropertyExpressionOperator.Contains));
                    this.mUIAddAmendFlightsPane.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIAddAmendFlightsPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIAddAmendFlightsPane;
        #endregion
    }
}
