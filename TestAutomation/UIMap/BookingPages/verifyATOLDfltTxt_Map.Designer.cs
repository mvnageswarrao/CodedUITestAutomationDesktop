﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.verifyATOLDfltTxt_MapClasses
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
    public partial class verifyATOLDfltTxt_Map:logWriter
    {
        
        /// <summary>
        /// verifyATOLDfltTxt_Method - Use 'verifyATOLDfltTxt_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyATOLDfltTxt_Method()
        {
            #region Variable Declarations
            HtmlCell uIItem250perpersonofthCell = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UITblMainTable.UIItemTable.UIItem250perpersonofthCell;
            #endregion

            // Verify that the 'InnerText' property of '£2.50 per person of the cost of this air' cell matches '
            //
            //£2.50 per person of the cost of this air holiday package is paid to the Civil Aviation Authority to provide ATOL protection to you. This means the money paid for these arrangements is fully protected. Our ATOL number is 2323 and our registered trading name is Villa Plus Ltd. For more information see our booking terms & conditions.
            // '
            //StringAssert.Matches(uIItem250perpersonofthCell.InnerText, new Regex(this.verifyATOLDfltTxt_MethodExpectedValues.UIItem250perpersonofthCellInnerText), "Not Matched");
            try
            {
                StringAssert.Matches(uIItem250perpersonofthCell.InnerText, new Regex(this.verifyATOLDfltTxt_MethodExpectedValues.UIItem250perpersonofthCellInnerText), "Not Matched");
                WriteLogs("PASS : ATOL Default Text is Matched.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyATOLDfltTxt");
                WriteLogs("FAIL : ATOL Default Text is Not Matched.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyATOLDfltTxt_MethodExpectedValues verifyATOLDfltTxt_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyATOLDfltTxt_MethodExpectedValues == null))
                {
                    this.mverifyATOLDfltTxt_MethodExpectedValues = new verifyATOLDfltTxt_MethodExpectedValues();
                }
                return this.mverifyATOLDfltTxt_MethodExpectedValues;
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
        private verifyATOLDfltTxt_MethodExpectedValues mverifyATOLDfltTxt_MethodExpectedValues;
        
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyATOLDfltTxt_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class verifyATOLDfltTxt_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of '£2.50 per person of the cost of this air' cell matches '
        ///
        ///£2.50 per person of the cost of this air holiday package is paid to the Civil Aviation Authority to provide ATOL protection to you. This means the money paid for these arrangements is fully protected. Our ATOL number is 2323 and our registered trading name is Villa Plus Ltd. For more information see our booking terms & conditions.
        /// '
        /// </summary>
        public string UIItem250perpersonofthCellInnerText = @"

£2.50 per person of the cost of this air holiday package is paid to the Civil Aviation Authority to provide ATOL protection to you. This means the money paid for these arrangements is fully protected. Our ATOL number is 2323 and our registered trading name is Villa Plus Ltd. For more information see our booking terms & conditions.
 ";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIYourHolidaySummaryWiWindow : BrowserWindow
    {
        
        public UIYourHolidaySummaryWiWindow()
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
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIYourHolidaySummaryDocument : HtmlDocument
    {
        
        public UIYourHolidaySummaryDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
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
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UITblMainTable : HtmlTable
    {
        
        public UITblMainTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlTable.PropertyNames.Id] = "tblMain";
            this.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "Your Holiday Summary\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nVill", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "width=\"1054\" align=\"center\" id=\"tblMain\" style=\"visibility: visible; background-c" +
                "olor: rgb(255, 255, 255);\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"";
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "1";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "2";
            this.FilterProperties[HtmlTable.PropertyNames.Class] = "";
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
    
    [GeneratedCode("Coded UITest Builder", "11.0.51106.1")]
    public class UIItemTable : HtmlTable
    {
        
        public UIItemTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlTable.PropertyNames.Id] = null;
            this.SearchProperties[HtmlTable.PropertyNames.Name] = null;
            this.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "Package Holiday Details    All timings a", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"";
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "35";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "1";
            this.FilterProperties[HtmlTable.PropertyNames.Class] = "";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIItem250perpersonofthCell
        {
            get
            {
                if ((this.mUIItem250perpersonofthCell == null))
                {
                    this.mUIItem250perpersonofthCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIItem250perpersonofthCell.SearchProperties[HtmlCell.PropertyNames.Id] = "";
                    this.mUIItem250perpersonofthCell.SearchProperties[HtmlCell.PropertyNames.Name] = "";
                    this.mUIItem250perpersonofthCell.SearchProperties[HtmlCell.PropertyNames.MaxDepth] = "3";
                    this.mUIItem250perpersonofthCell.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "£2.50 per person of the cost of this air", PropertyExpressionOperator.Contains));
                    this.mUIItem250perpersonofthCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "class=\"contentText\" colspan=\"4\"";
                    this.mUIItem250perpersonofthCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "26";
                    this.mUIItem250perpersonofthCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "0";
                    this.mUIItem250perpersonofthCell.FilterProperties[HtmlCell.PropertyNames.Class] = "contentText";
                    this.mUIItem250perpersonofthCell.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIItem250perpersonofthCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIItem250perpersonofthCell;
        #endregion
    }
}
