﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.AddAmendTransfers.amendTransferQty_MapClasses
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
    public partial class amendTransferQty_Map:logWriter
    {
        
        /// <summary>
        /// amendTransferQty_Method - Use 'amendTransferQty_MethodParams' to pass parameters into this method.
        /// </summary>
        public void amendTransferQty_Method()
        {
            #region Variable Declarations
            HtmlEdit uITxtVehicleQntyEdit = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAmendTransferSelectiFrame.UIPrivateTransfersDocument.UITxtVehicleQntyEdit;
            #endregion

            Random rnd = new Random();
            string QtyTobeEntered =Convert.ToString(rnd.Next(1, 10));

            try
            {
                // Type '2' in 'txtVehicleQnty' text box
                uITxtVehicleQntyEdit.Text = QtyTobeEntered;
                WriteLogs("PASS : Changed Transfer Qty.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("amendTransferQty");
                WriteLogs("FAIL : Could Not Change Transfer Qty.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual amendTransferQty_MethodParams amendTransferQty_MethodParams
        {
            get
            {
                if ((this.mamendTransferQty_MethodParams == null))
                {
                    this.mamendTransferQty_MethodParams = new amendTransferQty_MethodParams();
                }
                return this.mamendTransferQty_MethodParams;
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
        private amendTransferQty_MethodParams mamendTransferQty_MethodParams;
        
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'amendTransferQty_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class amendTransferQty_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Type '2' in 'txtVehicleQnty' text box
        /// </summary>
        public string UITxtVehicleQntyEditText = "2";
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
        public HtmlEdit UITxtVehicleQntyEdit
        {
            get
            {
                if ((this.mUITxtVehicleQntyEdit == null))
                {
                    this.mUITxtVehicleQntyEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUITxtVehicleQntyEdit.SearchProperties.Add(new PropertyExpression(HtmlEdit.PropertyNames.Id, "_txtVehicleQnty", PropertyExpressionOperator.Contains));
                    this.mUITxtVehicleQntyEdit.SearchProperties.Add(new PropertyExpression(HtmlEdit.PropertyNames.Name, "$txtVehicleQnty", PropertyExpressionOperator.Contains));
                    this.mUITxtVehicleQntyEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtVehicleQntyEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "td_small";
                    this.mUITxtVehicleQntyEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"ctl00$ContentPlaceHolder1$rptAmend";
                    this.mUITxtVehicleQntyEdit.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUITxtVehicleQntyEdit;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUITxtVehicleQntyEdit;
        #endregion
    }
}
