﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.clickIncludeFlightsBtn_MapClasses
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
    public partial class clickIncludeFlightsBtn_Map:logWriter
    {
        
        /// <summary>
        /// clickIncludeFlightsBtn_Method
        /// </summary>
        public void clickIncludeFlightsBtn_Method()
        {
            #region Variable Declarations
            HtmlDiv uIIncludeFlightsPane = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIIncludeFlightsVillaORow.UIIncludeFlightsPane;
            #endregion

            // Click 'Include Flights' pane
            Mouse.Click(uIIncludeFlightsPane, new Point(78, 15));
            WriteLogs("PASS : \"Include Flight\" Button Clicked");
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
        public UIIncludeFlightsVillaORow UIIncludeFlightsVillaORow
        {
            get
            {
                if ((this.mUIIncludeFlightsVillaORow == null))
                {
                    this.mUIIncludeFlightsVillaORow = new UIIncludeFlightsVillaORow(this);
                }
                return this.mUIIncludeFlightsVillaORow;
            }
        }
        #endregion
        
        #region Fields
        private UIIncludeFlightsVillaORow mUIIncludeFlightsVillaORow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIIncludeFlightsVillaORow : HtmlRow
    {
        
        public UIIncludeFlightsVillaORow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlRow.PropertyNames.Id] = "includeFlightsVillaOnly";
            this.FilterProperties.Add(new PropertyExpression(HtmlRow.PropertyNames.InnerText, "Would you like to add flights?   \r\n\r\n\r\n\r", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlRow.PropertyNames.ControlDefinition] = "id=\"includeFlightsVillaOnly\" style=\"visibility: visible;\"";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIIncludeFlightsPane
        {
            get
            {
                if ((this.mUIIncludeFlightsPane == null))
                {
                    this.mUIIncludeFlightsPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIIncludeFlightsPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Include Flights", PropertyExpressionOperator.Contains));
                    this.mUIIncludeFlightsPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "orangeButtons";
                    this.mUIIncludeFlightsPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"orangeButtons\" style=\"width: 150px; float: right;\" onclick=\"javascript:js_" +
                        "controller_booking(\'includeFlightsVillaOnly\',\'click\');\"";
                    this.mUIIncludeFlightsPane.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIIncludeFlightsPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIIncludeFlightsPane;
        #endregion
    }
}