﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.verifyFExtraDfltTxt_MapClasses
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
    public partial class verifyFExtraDfltTxt_Map:logWriter
    {
        
        /// <summary>
        /// verifyFExtraDfltTxt_Method - Use 'verifyFExtraDfltTxt_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyFExtraDfltTxt_Method(int ExtrasCOUNT)
        {
            #region Variable Declarations
            HtmlCell uIFlightextrasareavailCell = this.UIYourHolidaySummaryInWindow.UIYourHolidaySummaryDocument.UIFlightExtrasCellCell.UIItemTable.UINoflightextrasavailaCell;
            #endregion

            string TextFromPage = uIFlightextrasareavailCell.InnerText;
            string ExpectedTextifExtrasAvailable = "Flight extras are available for this flight by clicking on ''View Flight Extras'' button.";
            string ExpectedTextifExtrasNotAvailable = "No flight extras available ***";
            try
            {
                if (ExtrasCOUNT != 0)
                {

                    Assert.AreEqual(TextFromPage, ExpectedTextifExtrasAvailable);
                    WriteLogs("PASS : Flight Extras Are Avaialable and the respective Text is Matched.(" + ExpectedTextifExtrasAvailable + ").");
                }
                else
                {
                    Assert.AreEqual(TextFromPage, ExpectedTextifExtrasNotAvailable);
                    WriteLogs("PASS : Flight Extras Are Not Avaialable and the respective Text is Matched.(" + ExpectedTextifExtrasNotAvailable + ").");
                }
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyFExtraDfltTxt");
                WriteLogs("FAIL : Flight Extras Default Text is Not Matched.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyFExtraDfltTxt_MethodExpectedValues verifyFExtraDfltTxt_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyFExtraDfltTxt_MethodExpectedValues == null))
                {
                    this.mverifyFExtraDfltTxt_MethodExpectedValues = new verifyFExtraDfltTxt_MethodExpectedValues();
                }
                return this.mverifyFExtraDfltTxt_MethodExpectedValues;
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
        private verifyFExtraDfltTxt_MethodExpectedValues mverifyFExtraDfltTxt_MethodExpectedValues;
        
        private UIYourHolidaySummaryInWindow mUIYourHolidaySummaryInWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyFExtraDfltTxt_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class verifyFExtraDfltTxt_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'No flight extras available ***' cell equals 'No flight extras available ***'
        /// </summary>
        public string UINoflightextrasavailaCellInnerText = "No flight extras available ***";
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
        public UIFlightExtrasCellCell UIFlightExtrasCellCell
        {
            get
            {
                if ((this.mUIFlightExtrasCellCell == null))
                {
                    this.mUIFlightExtrasCellCell = new UIFlightExtrasCellCell(this);
                }
                return this.mUIFlightExtrasCellCell;
            }
        }
        #endregion
        
        #region Fields
        private UIFlightExtrasCellCell mUIFlightExtrasCellCell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIFlightExtrasCellCell : HtmlCell
    {
        
        public UIFlightExtrasCellCell(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlCell.PropertyNames.Id] = "flightExtrasCell";
            this.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "Flight Extras", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.ControlDefinition, "id=\"flightExtrasCell\"", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "5";
            this.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "0";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIItemTable UIItemTable
        {
            get
            {
                if ((this.mUIItemTable == null))
                {
                    this.mUIItemTable = new UIItemTable(this);
                }
                return this.mUIItemTable;
            }
        }
        #endregion
        
        #region Fields
        private UIItemTable mUIItemTable;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIItemTable : HtmlTable
    {
        
        public UIItemTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "flight extras", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "1";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "2";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlCell UINoflightextrasavailaCell
        {
            get
            {
                if ((this.mUINoflightextrasavailaCell == null))
                {
                    this.mUINoflightextrasavailaCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUINoflightextrasavailaCell.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "flight extras", PropertyExpressionOperator.Contains));
                    this.mUINoflightextrasavailaCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "class=\"hsContentIndentLevel2  contentText\" valign=\"top\"";
                    this.mUINoflightextrasavailaCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "0";
                    this.mUINoflightextrasavailaCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    this.mUINoflightextrasavailaCell.FilterProperties[HtmlCell.PropertyNames.Class] = "hsContentIndentLevel2  contentText";
                    this.mUINoflightextrasavailaCell.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUINoflightextrasavailaCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUINoflightextrasavailaCell;
        #endregion
    }
}