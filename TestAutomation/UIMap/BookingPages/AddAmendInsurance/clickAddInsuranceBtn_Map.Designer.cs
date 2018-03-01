﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.AddAmendInsurance.clickAddInsuranceBtn_MapClasses
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
    public partial class clickAddInsuranceBtn_Map:logWriter
    {
        
        /// <summary>
        /// clickAddInsuranceBtn_Method
        /// </summary>
        public void clickAddInsuranceBtn_Method(string strURL)
        {
            #region Variable Declarations
            HtmlDiv uIAddInsurancePane = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAddInsurancePane;
            #endregion
         
            try
            {
                // Click 'Add Insurance' pane
                Mouse.Click(uIAddInsurancePane, new Point(93, 15));
                WriteLogs("PASS : Clicked \"Add/Amend Insurance\" Button From HS Page.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("clickAddInsuranceBtn");
                WriteLogs("FAIL : Could Not Click \"Add/Amend Insurance\" Button From HS Page.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

            delayExecution(strURL);
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
        public HtmlDiv UIAddInsurancePane
        {
            get
            {
                if ((this.mUIAddInsurancePane == null))
                {
                    this.mUIAddInsurancePane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIAddInsurancePane.SearchProperties[HtmlDiv.PropertyNames.Id] = "amendInsuranceButton";
                    this.mUIAddInsurancePane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Add Insurance";
                    this.mUIAddInsurancePane.FilterProperties[HtmlDiv.PropertyNames.Class] = "orangeButtons";
                    this.mUIAddInsurancePane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"orangeButtons\" id=\"amendInsuranceButton\" ", PropertyExpressionOperator.Contains));
                    this.mUIAddInsurancePane.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIAddInsurancePane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIAddInsurancePane;
        #endregion
    }
}