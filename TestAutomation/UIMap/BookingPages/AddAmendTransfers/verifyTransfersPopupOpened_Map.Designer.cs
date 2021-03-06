﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.AddAmendTransfers.verifyTransfersPopupOpened_MapClasses
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
    public partial class verifyTransfersPopupOpened_Map:logWriter
    {
        
        /// <summary>
        /// verifyTransfersPopupOpened_Method - Use 'verifyTransfersPopupOpened_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyTransfersPopupOpened_Method()
        {
            #region Variable Declarations
            HtmlCell uIAddAmendPrivateTransCell = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAmendTransferSelectiFrame.UIPrivateTransfersDocument.UIAspnetFormCustom.UIItemTable.UIAddAmendPrivateTransCell;
            #endregion

            try
            {
                // Verify that the 'InnerText' property of 'Add/Amend Private Transfers' cell equals 'Add/Amend Private Transfers'
                Assert.AreEqual(this.verifyTransfersPopupOpened_MethodExpectedValues.UIAddAmendPrivateTransCellInnerText, uIAddAmendPrivateTransCell.InnerText);
                WriteLogs("PASS : \"Add/Amend Transfers\" Popup Opened.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyTransfersPopupOpened");
                WriteLogs("FAIL : Could Not Open \"Add/Amend Transfers\" Popup.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyTransfersPopupOpened_MethodExpectedValues verifyTransfersPopupOpened_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyTransfersPopupOpened_MethodExpectedValues == null))
                {
                    this.mverifyTransfersPopupOpened_MethodExpectedValues = new verifyTransfersPopupOpened_MethodExpectedValues();
                }
                return this.mverifyTransfersPopupOpened_MethodExpectedValues;
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
        private verifyTransfersPopupOpened_MethodExpectedValues mverifyTransfersPopupOpened_MethodExpectedValues;
        
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyTransfersPopupOpened_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyTransfersPopupOpened_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Add/Amend Private Transfers' cell equals 'Add/Amend Private Transfers'
        /// </summary>
        public string UIAddAmendPrivateTransCellInnerText = "Add/Amend Private Transfers";
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
        public UIAmendTransferSelectiFrame UIAmendTransferSelectiFrame
        {
            get
            {
                if ((this.mUIAmendTransferSelectiFrame == null))
                {
                    this.mUIAmendTransferSelectiFrame = new UIAmendTransferSelectiFrame(this);
                }
                return this.mUIAmendTransferSelectiFrame;
            }
        }
        #endregion
        
        #region Fields
        private UIAmendTransferSelectiFrame mUIAmendTransferSelectiFrame;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAmendTransferSelectiFrame : HtmlIFrame
    {
        
        public UIAmendTransferSelectiFrame(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "amendTransferSelection";
            this.SearchProperties[HtmlFrame.PropertyNames.Name] = "amendTransferSelection";
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.AbsolutePath, "amendTransfers.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.PageUrl, "amendTransfers.aspx?", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlFrame.PropertyNames.ControlDefinition] = "name=\"amendTransferSelection\" id=\"amendT";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIPrivateTransfersDocument UIPrivateTransfersDocument
        {
            get
            {
                if ((this.mUIPrivateTransfersDocument == null))
                {
                    this.mUIPrivateTransfersDocument = new UIPrivateTransfersDocument(this);
                }
                return this.mUIPrivateTransfersDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIPrivateTransfersDocument mUIPrivateTransfersDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPrivateTransfersDocument : HtmlDocument
    {
        
        public UIPrivateTransfersDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Private Transfers";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/amendTransfers.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/amendTransfers.aspx?", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIAspnetFormCustom UIAspnetFormCustom
        {
            get
            {
                if ((this.mUIAspnetFormCustom == null))
                {
                    this.mUIAspnetFormCustom = new UIAspnetFormCustom(this);
                }
                return this.mUIAspnetFormCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIAspnetFormCustom mUIAspnetFormCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAspnetFormCustom : HtmlCustom
    {
        
        public UIAspnetFormCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "FORM";
            this.SearchProperties["Id"] = "aspnetForm";
            this.FilterProperties["ControlDefinition"] = "id=\"aspnetForm\" onsubmit=\"javascript:ret";
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
            this.FilterProperties[HtmlTable.PropertyNames.InnerText] = "Add/Amend Private Transfers";
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\"";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIAddAmendPrivateTransCell
        {
            get
            {
                if ((this.mUIAddAmendPrivateTransCell == null))
                {
                    this.mUIAddAmendPrivateTransCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIAddAmendPrivateTransCell.SearchProperties[HtmlCell.PropertyNames.InnerText] = "Add/Amend Private Transfers";
                    this.mUIAddAmendPrivateTransCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "width=\"100%\" class=\"frameBg\"";
                    this.mUIAddAmendPrivateTransCell.FilterProperties[HtmlCell.PropertyNames.Class] = "frameBg";
                    this.mUIAddAmendPrivateTransCell.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIAddAmendPrivateTransCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIAddAmendPrivateTransCell;
        #endregion
    }
}
