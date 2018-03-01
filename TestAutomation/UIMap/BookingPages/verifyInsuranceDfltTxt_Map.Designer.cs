﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.verifyInsuranceDfltTxt_MapClasses
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
    public partial class verifyInsuranceDfltTxt_Map:logWriter
    {
        
        /// <summary>
        /// verifyInsuranceDfltTxt_Method - Use 'verifyInsuranceDfltTxt_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyInsuranceDfltTxt_Method()
        {
            #region Variable Declarations
            HtmlCell uIMakesureyouandyourfeCell = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIInsuranceCellCell.UIItemTable.UIMakesureyouandyourfeCell;
            #endregion

            // Verify that the 'InnerText' property of 'Make sure you and your fellow travellers' cell matches 'Make sure you and your fellow travellers are looked after from the moment you book your holiday with our comprehensive Travel Insurance.
            //
            // Villa Plus Insurance is valid for UK residents only.'
            //StringAssert.Matches(uIMakesureyouandyourfeCell.InnerText, new Regex(this.verifyInsuranceDfltTxt_MethodExpectedValues.UIMakesureyouandyourfeCellInnerText), "Not Matched");
            string TextFrmPage = uIMakesureyouandyourfeCell.InnerText;
            string ExpectedText = "Make sure you and your fellow travellers are looked after from the moment you book your holiday with our comprehensive Travel Insurance.Villa Plus Insurance is valid for residents of the UK and Channel Islands only.";
            try
            {
                StringAssert.Equals(TextFrmPage, ExpectedText);
                WriteLogs("PASS : Insurance Default Text is Matched.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyInsuranceDfltTxt");
                WriteLogs("FAIL : Insurance Default Text is Not Matched.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyInsuranceDfltTxt_MethodExpectedValues verifyInsuranceDfltTxt_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyInsuranceDfltTxt_MethodExpectedValues == null))
                {
                    this.mverifyInsuranceDfltTxt_MethodExpectedValues = new verifyInsuranceDfltTxt_MethodExpectedValues();
                }
                return this.mverifyInsuranceDfltTxt_MethodExpectedValues;
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
        private verifyInsuranceDfltTxt_MethodExpectedValues mverifyInsuranceDfltTxt_MethodExpectedValues;
        
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyInsuranceDfltTxt_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyInsuranceDfltTxt_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Make sure you and your fellow travellers' cell matches 'Make sure you and your fellow travellers are looked after from the moment you book your holiday with our comprehensive Travel Insurance.
        ///
        /// Villa Plus Insurance is valid for UK residents only.'
        /// </summary>
        public string UIMakesureyouandyourfeCellInnerText = "Make sure you and your fellow travellers are looked after from the moment you boo" +
            "k your holiday with our comprehensive Travel Insurance.\r\n\r\n Villa Plus Insurance" +
            " is valid for UK residents only.";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
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
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
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
        public UIInsuranceCellCell UIInsuranceCellCell
        {
            get
            {
                if ((this.mUIInsuranceCellCell == null))
                {
                    this.mUIInsuranceCellCell = new UIInsuranceCellCell(this);
                }
                return this.mUIInsuranceCellCell;
            }
        }
        #endregion
        
        #region Fields
        private UIInsuranceCellCell mUIInsuranceCellCell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIInsuranceCellCell : HtmlCell
    {
        
        public UIInsuranceCellCell(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlCell.PropertyNames.Id] = "insuranceCell";
            this.SearchProperties[HtmlCell.PropertyNames.Name] = null;
            this.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "Travel Insurance  \r\n Price Quantity Tota", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "id=\"insuranceCell\" colspan=\"9\"";
            this.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "18";
            this.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "0";
            this.FilterProperties[HtmlCell.PropertyNames.Class] = null;
            this.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "347";
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
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemTable : HtmlTable
    {
        
        public UIItemTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlTable.PropertyNames.Id] = null;
            this.SearchProperties[HtmlTable.PropertyNames.Name] = null;
            this.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "Travel Insurance  \r\n Price Quantity Tota", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"";
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "7";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "9";
            this.FilterProperties[HtmlTable.PropertyNames.Class] = null;
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIMakesureyouandyourfeCell
        {
            get
            {
                if ((this.mUIMakesureyouandyourfeCell == null))
                {
                    this.mUIMakesureyouandyourfeCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIMakesureyouandyourfeCell.SearchProperties[HtmlCell.PropertyNames.Id] = "";
                    this.mUIMakesureyouandyourfeCell.SearchProperties[HtmlCell.PropertyNames.Name] = "";
                    this.mUIMakesureyouandyourfeCell.SearchProperties[HtmlCell.PropertyNames.MaxDepth] = "3";
                    this.mUIMakesureyouandyourfeCell.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "Make sure you and your fellow travellers", PropertyExpressionOperator.Contains));
                    this.mUIMakesureyouandyourfeCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "width=\"535\" class=\"contentText hsContentIndent\" style=\"color: rgb(51, 51, 51);\"";
                    this.mUIMakesureyouandyourfeCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "4";
                    this.mUIMakesureyouandyourfeCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "0";
                    this.mUIMakesureyouandyourfeCell.FilterProperties[HtmlCell.PropertyNames.Class] = "contentText hsContentIndent";
                    this.mUIMakesureyouandyourfeCell.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIMakesureyouandyourfeCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIMakesureyouandyourfeCell;
        #endregion
    }
}