﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BalancePayment.verifyBPpgOpen_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public partial class verifyBPpgOpen_Map:logWriter
    {
        
        /// <summary>
        /// verifyBPpgOpen_Method - Use 'verifyBPpgOpen_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyBPpgOpen_Method(string bookRef)
        {
            #region Variable Declarations
            HtmlCell uIBookingRefE6DC34Cell = this.UIVillaPlusBalancePaymWindow.UIVillaPlusBalancePaymDocument.UIFrmBalancePaymentCustom.UIItemTable.UIBookingRefE6DC34Cell;
            #endregion

            // Verify that the 'InnerText' property of 'Booking Ref: E6DC34' cell equals 'Booking Ref: E6DC34'
            string checkBookRef = "Booking Ref: " + bookRef.Trim();
            try
            {
                Assert.AreEqual(checkBookRef, uIBookingRefE6DC34Cell.InnerText);
                WriteLogs("PASS : Balance Payment page opened successfully for Booking Ref " + bookRef.Trim()+" : VERIFICATION");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Failed to open Balance Payment page for Booking Ref " + bookRef.Trim() + " : VERIFICATION");
               // WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyBPpgOpen_MethodExpectedValues verifyBPpgOpen_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyBPpgOpen_MethodExpectedValues == null))
                {
                    this.mverifyBPpgOpen_MethodExpectedValues = new verifyBPpgOpen_MethodExpectedValues();
                }
                return this.mverifyBPpgOpen_MethodExpectedValues;
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
        private verifyBPpgOpen_MethodExpectedValues mverifyBPpgOpen_MethodExpectedValues;
        
        private UIVillaPlusBalancePaymWindow mUIVillaPlusBalancePaymWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyBPpgOpen_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class verifyBPpgOpen_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Booking Ref: E6DC34' cell equals 'Booking Ref: E6DC34'
        /// </summary>
        public string UIBookingRefE6DC34CellInnerText = "Booking Ref: E6DC34";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
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
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
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
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/balancepayments", PropertyExpressionOperator.Contains));
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
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
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
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIItemTable : HtmlTable
    {
        
        public UIItemTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlTable.PropertyNames.Id] = null;
            this.SearchProperties[HtmlTable.PropertyNames.Name] = null;
            this.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "Your Holiday", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "width=\"835\" border=\"0\" cellSpacing=\"0\" cellPadding=\"0\"";
            this.FilterProperties[HtmlTable.PropertyNames.Class] = "";
            this.WindowTitles.Add("Villa Plus Balance Payment");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIBookingRefE6DC34Cell
        {
            get
            {
                if ((this.mUIBookingRefE6DC34Cell == null))
                {
                    this.mUIBookingRefE6DC34Cell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIBookingRefE6DC34Cell.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "Booking Ref:", PropertyExpressionOperator.Contains));
                    this.mUIBookingRefE6DC34Cell.FilterProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.ControlDefinition, "class=\"greyHeader\"", PropertyExpressionOperator.Contains));
                    this.mUIBookingRefE6DC34Cell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "4";
                    this.mUIBookingRefE6DC34Cell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "0";
                    this.mUIBookingRefE6DC34Cell.FilterProperties[HtmlCell.PropertyNames.Class] = "greyHeader";
                    this.mUIBookingRefE6DC34Cell.WindowTitles.Add("Villa Plus Balance Payment");
                    #endregion
                }
                return this.mUIBookingRefE6DC34Cell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIBookingRefE6DC34Cell;
        #endregion
    }
}