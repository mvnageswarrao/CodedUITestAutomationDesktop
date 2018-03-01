﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.LeadPaxPage.verifyHoldItemsPopupDisplay_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class verifyHoldItemsPopupDisplay_Map:logWriter
    {
        
        /// <summary>
        /// verifyHoldItemsPopupDisplay_Method - Use 'verifyHoldItemsPopupDisplay_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public Boolean verifyHoldItemsPopupDisplay_Method()
        {
            #region Variable Declarations
            HtmlCell uIHoldItemsCell = this.UIYourHolidaySummaryInWindow.UIYourHolidaySummaryDocument.UIHoldItemsCell;
            #endregion

            Boolean HoldItemsExits = false;

            try
            {
                HoldItemsExits = uIHoldItemsCell.TryFind();
                // Verify that the 'InnerText' property of 'Hold Items' cell equals 'Hold Items'
                //Assert.AreEqual(this.verifyHoldItemsPopupDisplay_MethodExpectedValues.UIHoldItemsCellInnerText, uIHoldItemsCell.InnerText);
                WriteLogs("INFO : Hold Items Popup displayed on HS page.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyHoldItemsPopupDisplay");
                WriteLogs("INFO : Could not find Hold Items Popup.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

            return HoldItemsExits;
        }
        
        #region Properties
        public virtual verifyHoldItemsPopupDisplay_MethodExpectedValues verifyHoldItemsPopupDisplay_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyHoldItemsPopupDisplay_MethodExpectedValues == null))
                {
                    this.mverifyHoldItemsPopupDisplay_MethodExpectedValues = new verifyHoldItemsPopupDisplay_MethodExpectedValues();
                }
                return this.mverifyHoldItemsPopupDisplay_MethodExpectedValues;
            }
        }
        
        public UIYourHolidaySummaryInWindow UIYourHolidaySummaryInWindow
        {
            get
            {
                if ((this.mUIYourHolidaySummaryInWindow == null))
                {
                    this.mUIYourHolidaySummaryInWindow = new UIYourHolidaySummaryInWindow();
                }
                return this.mUIYourHolidaySummaryInWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyHoldItemsPopupDisplay_MethodExpectedValues mverifyHoldItemsPopupDisplay_MethodExpectedValues;
        
        private UIYourHolidaySummaryInWindow mUIYourHolidaySummaryInWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyHoldItemsPopupDisplay_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class verifyHoldItemsPopupDisplay_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Hold Items' cell equals 'Hold Items'
        /// </summary>
        public string UIHoldItemsCellInnerText = "Hold Items";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYourHolidaySummaryInWindow : BrowserWindow
    {
        
        public UIYourHolidaySummaryInWindow()
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
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
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
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/code_net/booking/default.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIHoldItemsCell
        {
            get
            {
                if ((this.mUIHoldItemsCell == null))
                {
                    this.mUIHoldItemsCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIHoldItemsCell.SearchProperties[HtmlCell.PropertyNames.Id] = "alertTitle";
                    this.mUIHoldItemsCell.SearchProperties[HtmlCell.PropertyNames.InnerText] = "Hold Items";
                    this.mUIHoldItemsCell.FilterProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.ControlDefinition, "id=\"alertTitle\"", PropertyExpressionOperator.Contains));
                    this.mUIHoldItemsCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "0";
                    this.mUIHoldItemsCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    this.mUIHoldItemsCell.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIHoldItemsCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIHoldItemsCell;
        #endregion
    }
}