﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.AddAmendTransfers.clickAddExtraTransfer_MapClasses
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
    public partial class clickAddExtraTransfer_Map:logWriter
    {
        
        /// <summary>
        /// clickAddExtraTransfer_Method
        /// </summary>
        public void clickAddExtraTransfer_Method()
        {
            #region Variable Declarations
            HtmlInputButton uIAddExtraTransferButton = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAmendTransferSelectiFrame.UIPrivateTransfersDocument.UIAddExtraTransferButton;
            #endregion

            try
            {
                // Click 'Add Extra Transfer' button
                Mouse.Click(uIAddExtraTransferButton, new Point(51, 14));
                WriteLogs("PASS : Clicked \"Add Extra Transfer\" Button From Transfer Popup.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("clickAddExtraTransfer");
                WriteLogs("FAIL : Could Not Click \"Add Extra Transfer\" Button From Transfer Popup.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

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
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Private Transfers", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/amendTransfers.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/amendTransfers.aspx?", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlInputButton UIAddExtraTransferButton
        {
            get
            {
                if ((this.mUIAddExtraTransferButton == null))
                {
                    this.mUIAddExtraTransferButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUIAddExtraTransferButton.SearchProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Id, "_btnAddExtra", PropertyExpressionOperator.Contains));
                    this.mUIAddExtraTransferButton.SearchProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Name, "$btnAddExtra", PropertyExpressionOperator.Contains));
                    this.mUIAddExtraTransferButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "Add Extra Transfer";
                    this.mUIAddExtraTransferButton.FilterProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIAddExtraTransferButton.FilterProperties[HtmlButton.PropertyNames.Title] = "Add Extra Transfer";
                    this.mUIAddExtraTransferButton.FilterProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Class, "button", PropertyExpressionOperator.Contains));
                    this.mUIAddExtraTransferButton.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIAddExtraTransferButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlInputButton mUIAddExtraTransferButton;
        #endregion
    }
}
