﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.AddAmendFlightExtras.verifyAddAmendFlightExtraspopupOpened_MapClasses
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
    public partial class verifyAddAmendFlightExtraspopupOpened_Map:logWriter
    {
        
        /// <summary>
        /// verifyAddAmendFlightExtraspopupOpened_Method - Use 'verifyAddAmendFlightExtraspopupOpened_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyAddAmendFlightExtraspopupOpened_Method()
        {
            #region Variable Declarations
            HtmlCell uIViewFlightExtrasCell = this.UIYourHolidaySummaryInWindow.UIYourHolidaySummaryDocument.UIAmendFlightExtraSeleFrame.UIUntitledPageDocument.UITblIFrameHeaderTable.UIViewFlightExtrasCell;
            #endregion

            try
            {
                // Verify that the 'InnerText' property of 'Add/Amend Flight Extras' cell contains 'Add/Amend Flight Extras'
                StringAssert.Contains(uIViewFlightExtrasCell.InnerText, this.verifyAddAmendFlightExtraspopupOpened_MethodExpectedValues.UIViewFlightExtrasCellInnerText);
                WriteLogs("PASS : \"Add/Amend Flight Extras\" Popup Opened Successfully.");

            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyAddAmendFlightExtraspopupOpened");
                WriteLogs("FAIL : \"Add/Amend Flight Extras\" Popup is Not Opened.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyAddAmendFlightExtraspopupOpened_MethodExpectedValues verifyAddAmendFlightExtraspopupOpened_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyAddAmendFlightExtraspopupOpened_MethodExpectedValues == null))
                {
                    this.mverifyAddAmendFlightExtraspopupOpened_MethodExpectedValues = new verifyAddAmendFlightExtraspopupOpened_MethodExpectedValues();
                }
                return this.mverifyAddAmendFlightExtraspopupOpened_MethodExpectedValues;
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
        private verifyAddAmendFlightExtraspopupOpened_MethodExpectedValues mverifyAddAmendFlightExtraspopupOpened_MethodExpectedValues;
        
        private UIYourHolidaySummaryInWindow mUIYourHolidaySummaryInWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyAddAmendFlightExtraspopupOpened_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class verifyAddAmendFlightExtraspopupOpened_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'View Flight Extras' cell equals 'View Flight Extras'
        /// </summary>
        public string UIViewFlightExtrasCellInnerText = "View Flight Extras";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYourHolidaySummaryInWindow : BrowserWindow
    {
        
        public UIYourHolidaySummaryInWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Your Holiday Summary";
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
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Your Holiday Summary";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/default.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/code_net/booking/default.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIAmendFlightExtraSeleFrame UIAmendFlightExtraSeleFrame
        {
            get
            {
                if ((this.mUIAmendFlightExtraSeleFrame == null))
                {
                    this.mUIAmendFlightExtraSeleFrame = new UIAmendFlightExtraSeleFrame(this);
                }
                return this.mUIAmendFlightExtraSeleFrame;
            }
        }
        #endregion
        
        #region Fields
        private UIAmendFlightExtraSeleFrame mUIAmendFlightExtraSeleFrame;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIAmendFlightExtraSeleFrame : HtmlIFrame
    {
        
        public UIAmendFlightExtraSeleFrame(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "amendFlightExtraSelection";
            this.SearchProperties[HtmlFrame.PropertyNames.Name] = "amendFlightExtraSelection";
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.AbsolutePath, "amendFlightExtra.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.PageUrl, "amendFlightExtra.aspx?refNo=", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlFrame.PropertyNames.ControlDefinition] = "name=\"amendFlightExtraSelection\" id=\"ame";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIUntitledPageDocument UIUntitledPageDocument
        {
            get
            {
                if ((this.mUIUntitledPageDocument == null))
                {
                    this.mUIUntitledPageDocument = new UIUntitledPageDocument(this);
                }
                return this.mUIUntitledPageDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIUntitledPageDocument mUIUntitledPageDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIUntitledPageDocument : HtmlDocument
    {
        
        public UIUntitledPageDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/amendFlightExtra.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/code_net/booking/amendFlightExtra.aspx?refNo=", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UITblIFrameHeaderTable UITblIFrameHeaderTable
        {
            get
            {
                if ((this.mUITblIFrameHeaderTable == null))
                {
                    this.mUITblIFrameHeaderTable = new UITblIFrameHeaderTable(this);
                }
                return this.mUITblIFrameHeaderTable;
            }
        }
        #endregion
        
        #region Fields
        private UITblIFrameHeaderTable mUITblIFrameHeaderTable;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UITblIFrameHeaderTable : HtmlTable
    {
        
        public UITblIFrameHeaderTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlTable.PropertyNames.Id] = "tblIFrameHeader";
            this.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "View Flight Extras", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "width=\"100%\" id=\"tblIFrameHeader\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"";
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "1";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "3";
            this.FilterProperties[HtmlTable.PropertyNames.Class] = "";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIViewFlightExtrasCell
        {
            get
            {
                if ((this.mUIViewFlightExtrasCell == null))
                {
                    this.mUIViewFlightExtrasCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIViewFlightExtrasCell.SearchProperties[HtmlCell.PropertyNames.MaxDepth] = "3";
                    this.mUIViewFlightExtrasCell.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "View Flight Extras", PropertyExpressionOperator.Contains));
                    this.mUIViewFlightExtrasCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "width=\"100%\" class=\"frameBg\"";
                    this.mUIViewFlightExtrasCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "0";
                    this.mUIViewFlightExtrasCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    this.mUIViewFlightExtrasCell.FilterProperties[HtmlCell.PropertyNames.Class] = "frameBg";
                    this.mUIViewFlightExtrasCell.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIViewFlightExtrasCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIViewFlightExtrasCell;
        #endregion
    }
}
