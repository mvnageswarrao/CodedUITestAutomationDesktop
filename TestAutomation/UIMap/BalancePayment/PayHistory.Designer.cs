﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BalancePayment.PayHistoryClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class PayHistory_Map : logWriter
    {
        
        /// <summary>
        /// TestPayHistory_Method - Use 'TestPayHistory_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void PayHistory_Method(string totalpayment)
        {
            #region Variable Declarations
            HtmlCell uIPaymentHistoryCell = this.UIVillaPlusBalancePaymWindow.UIVillaPlusBalancePaymDocument.UIFrmBalancePaymentCustom.UIItemTable.UIPaymentHistoryCell;
            HtmlCell uIItem14990Cell = this.UIVillaPlusBalancePaymWindow.UIVillaPlusBalancePaymDocument.UIFrmBalancePaymentCustom.UIItemTable.UIItem14990Cell;
            #endregion

            // Verify that the 'InnerText' property of 'Payment History' cell equals '  Payment History '
           // Assert.AreEqual(this.TestPayHistory_MethodExpectedValues.UIPaymentHistoryCellInnerText, uIPaymentHistoryCell.InnerText);

            // Verify that the 'InnerText' property of '£149.90' cell equals ''
           // Assert.AreEqual(this.TestPayHistory_MethodExpectedValues.UIItem14990CellInnerText, uIItem14990Cell.InnerText);
             totalpayment = "£" + totalpayment;
            try
            {
                StringAssert.Contains(uIItem14990Cell.InnerText, totalpayment);
                WriteLogs("PASS : Total payment value is matched with value in database " + totalpayment);

            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Total payment value does not matched with value in database " + totalpayment);

            }
        }
        
        #region Properties
        public virtual TestPayHistory_MethodExpectedValues TestPayHistory_MethodExpectedValues
        {
            get
            {
                if ((this.mTestPayHistory_MethodExpectedValues == null))
                {
                    this.mTestPayHistory_MethodExpectedValues = new TestPayHistory_MethodExpectedValues();
                }
                return this.mTestPayHistory_MethodExpectedValues;
            }
        }
        
        public UIVillaPlusBalancePaymWindow UIVillaPlusBalancePaymWindow
        {
            get
            {
                if ((this.mUIVillaPlusBalancePaymWindow == null))
                {
                    this.mUIVillaPlusBalancePaymWindow = new UIVillaPlusBalancePaymWindow();
                }
                return this.mUIVillaPlusBalancePaymWindow;
            }
        }
        #endregion
        
        #region Fields
        private TestPayHistory_MethodExpectedValues mTestPayHistory_MethodExpectedValues;
        
        private UIVillaPlusBalancePaymWindow mUIVillaPlusBalancePaymWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'TestPayHistory_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class TestPayHistory_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Payment History' cell equals '  Payment History '
        /// </summary>
        public string UIPaymentHistoryCellInnerText = "  Payment History ";
        
        /// <summary>
        /// Verify that the 'InnerText' property of '£149.90' cell equals ''
        /// </summary>
        public string UIItem14990CellInnerText = "";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIVillaPlusBalancePaymWindow : BrowserWindow
    {
        
        public UIVillaPlusBalancePaymWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Villa Plus Balance Payment";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Plus Balance Payment");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaPlusBalancePaymDocument UIVillaPlusBalancePaymDocument
        {
            get
            {
                if ((this.mUIVillaPlusBalancePaymDocument == null))
                {
                    this.mUIVillaPlusBalancePaymDocument = new UIVillaPlusBalancePaymDocument(this);
                }
                return this.mUIVillaPlusBalancePaymDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPlusBalancePaymDocument mUIVillaPlusBalancePaymDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIVillaPlusBalancePaymDocument : HtmlDocument
    {
        
        public UIVillaPlusBalancePaymDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Villa Plus Balance Payment";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/balancepayments/default.aspx";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/balancepayments/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Plus Balance Payment");
            #endregion
        }
        
        #region Properties
        public UIFrmBalancePaymentCustom UIFrmBalancePaymentCustom
        {
            get
            {
                if ((this.mUIFrmBalancePaymentCustom == null))
                {
                    this.mUIFrmBalancePaymentCustom = new UIFrmBalancePaymentCustom(this);
                }
                return this.mUIFrmBalancePaymentCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIFrmBalancePaymentCustom mUIFrmBalancePaymentCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIFrmBalancePaymentCustom : HtmlCustom
    {
        
        public UIFrmBalancePaymentCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "FORM";
            this.SearchProperties["Id"] = "frmBalancePayment";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties["Class"] = null;
            this.FilterProperties["ControlDefinition"] = "id=\"frmBalancePayment\" onsubmit=\"javascr";
            this.FilterProperties["TagInstance"] = "1";
            this.WindowTitles.Add("Villa Plus Balance Payment");
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
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIItemTable : HtmlTable
    {
        
        public UIItemTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlTable.PropertyNames.Id] = null;
            this.SearchProperties[HtmlTable.PropertyNames.Name] = null;
            this.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "Payment History \r\n", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "width=\"835\" border=\"0\" cellSpacing=\"0\" cellPadding=\"0\"";
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "8";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "1";
            this.FilterProperties[HtmlTable.PropertyNames.Class] = "";
            this.FilterProperties[HtmlTable.PropertyNames.TagInstance] = "20";
            this.WindowTitles.Add("Villa Plus Balance Payment");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIPaymentHistoryCell
        {
            get
            {
                if ((this.mUIPaymentHistoryCell == null))
                {
                    this.mUIPaymentHistoryCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIPaymentHistoryCell.SearchProperties[HtmlCell.PropertyNames.Id] = null;
                    this.mUIPaymentHistoryCell.SearchProperties[HtmlCell.PropertyNames.Name] = null;
                    this.mUIPaymentHistoryCell.SearchProperties[HtmlCell.PropertyNames.MaxDepth] = "3";
                    this.mUIPaymentHistoryCell.SearchProperties[HtmlCell.PropertyNames.InnerText] = "Payment History ";
                    this.mUIPaymentHistoryCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "style=\'height: 18px; background-image: url(\"/imgs/vp/buttons/DateBW_bigBG.gif\"); " +
                        "background-repeat: no-repeat;\' colSpan=\"5\"";
                    this.mUIPaymentHistoryCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "0";
                    this.mUIPaymentHistoryCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "0";
                    this.mUIPaymentHistoryCell.FilterProperties[HtmlCell.PropertyNames.Class] = null;
                    this.mUIPaymentHistoryCell.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "186";
                    this.mUIPaymentHistoryCell.WindowTitles.Add("Villa Plus Balance Payment");
                    #endregion
                }
                return this.mUIPaymentHistoryCell;
            }
        }
        
        public HtmlCell UIItem14990Cell
        {
            get
            {
                if ((this.mUIItem14990Cell == null))
                {
                    this.mUIItem14990Cell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIItem14990Cell.SearchProperties[HtmlCell.PropertyNames.Id] = "";
                    this.mUIItem14990Cell.SearchProperties[HtmlCell.PropertyNames.Name] = "";
                    this.mUIItem14990Cell.SearchProperties[HtmlCell.PropertyNames.MaxDepth] = "3";
                    this.mUIItem14990Cell.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "£", PropertyExpressionOperator.Contains));
                    this.mUIItem14990Cell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "width=\"200\" align=\"center\" class=\"greyText\" style=\"font-weight: bold;\"";
                    this.mUIItem14990Cell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "5";
                    this.mUIItem14990Cell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "2";
                    this.mUIItem14990Cell.FilterProperties[HtmlCell.PropertyNames.Class] = "greyText";
                    this.mUIItem14990Cell.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "197";
                    this.mUIItem14990Cell.WindowTitles.Add("Villa Plus Balance Payment");
                    #endregion
                }
                return this.mUIItem14990Cell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIPaymentHistoryCell;
        
        private HtmlCell mUIItem14990Cell;
        #endregion
    }
}
