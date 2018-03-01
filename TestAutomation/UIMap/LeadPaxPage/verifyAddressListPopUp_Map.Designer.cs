﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.LeadPaxPage.verifyAddressListPopUp_MapClasses
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
    public partial class verifyAddressListPopUp_Map:logWriter
    {
        
        /// <summary>
        /// verifyAddressListPopUp_Method - Use 'verifyAddressListPopUp_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyAddressListPopUp_Method()
        {
            #region Variable Declarations
            HtmlCell uIAddressListCell = this.UIAllocateLeadPassengeWindow.UIAllocateLeadPassengeDocument.UIAddressListCell.UIItemTable.UIAddressListCell;
            #endregion

            // Verify that the 'InnerText' property of 'Address List' cell contains 'Address List'
            //StringAssert.Contains(uIAddressListCell.InnerText, this.verifyAddressListPopUp_MethodExpectedValues.UIAddressListCellInnerText);

            try
            {
                StringAssert.Contains(uIAddressListCell.InnerText, this.verifyAddressListPopUp_MethodExpectedValues.UIAddressListCellInnerText);
                WriteLogs("PASS : Address List Popup is Opened Successfully.");
            }

            catch (AssertFailedException ex)
            {
                takeImage("verifyAddressListPopUp");
                WriteLogs("FAIL : Address List Popup is Not Opened.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyAddressListPopUp_MethodExpectedValues verifyAddressListPopUp_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyAddressListPopUp_MethodExpectedValues == null))
                {
                    this.mverifyAddressListPopUp_MethodExpectedValues = new verifyAddressListPopUp_MethodExpectedValues();
                }
                return this.mverifyAddressListPopUp_MethodExpectedValues;
            }
        }
        
        public UIAllocateLeadPassengeWindow UIAllocateLeadPassengeWindow
        {
            get
            {
                if ((this.mUIAllocateLeadPassengeWindow == null))
                {
                    this.mUIAllocateLeadPassengeWindow = new UIAllocateLeadPassengeWindow();
                }
                return this.mUIAllocateLeadPassengeWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyAddressListPopUp_MethodExpectedValues mverifyAddressListPopUp_MethodExpectedValues;
        
        private UIAllocateLeadPassengeWindow mUIAllocateLeadPassengeWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyAddressListPopUp_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyAddressListPopUp_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Address List' cell contains 'Address List'
        /// </summary>
        public string UIAddressListCellInnerText = "Address List";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAllocateLeadPassengeWindow : BrowserWindow
    {
        
        public UIAllocateLeadPassengeWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Allocate Lead Passenger", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Allocate Lead Passenger");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIAllocateLeadPassengeDocument UIAllocateLeadPassengeDocument
        {
            get
            {
                if ((this.mUIAllocateLeadPassengeDocument == null))
                {
                    this.mUIAllocateLeadPassengeDocument = new UIAllocateLeadPassengeDocument(this);
                }
                return this.mUIAllocateLeadPassengeDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIAllocateLeadPassengeDocument mUIAllocateLeadPassengeDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAllocateLeadPassengeDocument : HtmlDocument
    {
        
        public UIAllocateLeadPassengeDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Allocate Lead Passenger", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/allocateLeadPax.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/allocateLeadPax.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Allocate Lead Passenger");
            #endregion
        }
        
        #region Properties
        public UIAddressListCell UIAddressListCell
        {
            get
            {
                if ((this.mUIAddressListCell == null))
                {
                    this.mUIAddressListCell = new UIAddressListCell(this);
                }
                return this.mUIAddressListCell;
            }
        }
        #endregion
        
        #region Fields
        private UIAddressListCell mUIAddressListCell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAddressListCell : HtmlCell
    {
        
        public UIAddressListCell(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlCell.PropertyNames.Id] = "Td3";
            this.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "Address List", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "align=\"center\" class=\"DarkBlueBg\" id=\"Td3\" style=\"height: 23px; vertical-align: m" +
                "iddle;\"";
            this.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "0";
            this.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
            this.FilterProperties[HtmlCell.PropertyNames.Class] = "DarkBlueBg";
            this.WindowTitles.Add("Allocate Lead Passenger");
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
            this.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "Address List", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "width=\"100%\" style=\"height: 23px;\" border=\"0\" cellSpacing=\"0\" cellPadding=\"0\"";
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "1";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "2";
            this.WindowTitles.Add("Allocate Lead Passenger");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIAddressListCell
        {
            get
            {
                if ((this.mUIAddressListCell == null))
                {
                    this.mUIAddressListCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIAddressListCell.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "Address List", PropertyExpressionOperator.Contains));
                    this.mUIAddressListCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "width=\"100\" align=\"left\" class=\"whiteBigText\"";
                    this.mUIAddressListCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "0";
                    this.mUIAddressListCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "0";
                    this.mUIAddressListCell.FilterProperties[HtmlCell.PropertyNames.Class] = "whiteBigText";
                    this.mUIAddressListCell.WindowTitles.Add("Allocate Lead Passenger");
                    #endregion
                }
                return this.mUIAddressListCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIAddressListCell;
        #endregion
    }
}