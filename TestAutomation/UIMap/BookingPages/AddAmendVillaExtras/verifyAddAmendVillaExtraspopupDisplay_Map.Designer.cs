﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.AddAmendVillaExtras.verifyAddAmendVillaExtraspopupDisplay_MapClasses
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
    public partial class verifyAddAmendVillaExtraspopupDisplay_Map:logWriter
    {
        
        /// <summary>
        /// verifyAddAmendVillaExtraspopupDisplay_Method - Use 'verifyAddAmendVillaExtraspopupDisplay_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyAddAmendVillaExtraspopupDisplay_Method()
        {
            #region Variable Declarations
            HtmlSpan uIAddAmendVillaExtrasPane = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAmendVillaExtrasSeleFrame.UIVillaPlusPackageHoliDocument.UIAddAmendVillaExtrasPane;
            #endregion
            
            try
            {
                // Verify that the 'InnerText' property of 'Add/Amend Villa Extras' pane equals 'Add/Amend Villa Extras'
                Assert.AreEqual(this.verifyAddAmendVillaExtraspopupDisplay_MethodExpectedValues.UIAddAmendVillaExtrasPaneInnerText, uIAddAmendVillaExtrasPane.InnerText);
                WriteLogs("PASS : \"Add/Amend Villa Extras\" Popup Opened.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyAddAmendVillaExtraspopupDisplay");
                WriteLogs("FAIL : \"Add/Amend Villa Extras\" Popup is not Opened.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyAddAmendVillaExtraspopupDisplay_MethodExpectedValues verifyAddAmendVillaExtraspopupDisplay_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyAddAmendVillaExtraspopupDisplay_MethodExpectedValues == null))
                {
                    this.mverifyAddAmendVillaExtraspopupDisplay_MethodExpectedValues = new verifyAddAmendVillaExtraspopupDisplay_MethodExpectedValues();
                }
                return this.mverifyAddAmendVillaExtraspopupDisplay_MethodExpectedValues;
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
        private verifyAddAmendVillaExtraspopupDisplay_MethodExpectedValues mverifyAddAmendVillaExtraspopupDisplay_MethodExpectedValues;
        
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyAddAmendVillaExtraspopupDisplay_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyAddAmendVillaExtraspopupDisplay_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Add/Amend Villa Extras' pane equals 'Add/Amend Villa Extras'
        /// </summary>
        public string UIAddAmendVillaExtrasPaneInnerText = "Add/Amend Villa Extras";
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
        public UIAmendVillaExtrasSeleFrame UIAmendVillaExtrasSeleFrame
        {
            get
            {
                if ((this.mUIAmendVillaExtrasSeleFrame == null))
                {
                    this.mUIAmendVillaExtrasSeleFrame = new UIAmendVillaExtrasSeleFrame(this);
                }
                return this.mUIAmendVillaExtrasSeleFrame;
            }
        }
        #endregion
        
        #region Fields
        private UIAmendVillaExtrasSeleFrame mUIAmendVillaExtrasSeleFrame;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAmendVillaExtrasSeleFrame : HtmlIFrame
    {
        
        public UIAmendVillaExtrasSeleFrame(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "amendVillaExtrasSelection";
            this.SearchProperties[HtmlFrame.PropertyNames.Name] = "amendVillaExtrasSelection";
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.AbsolutePath, "amendVillaExtra.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.PageUrl, "amendVillaExtra.aspx?", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlFrame.PropertyNames.ControlDefinition] = "name=\"amendVillaExtrasSelection\" id=\"ame";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIVillaPlusPackageHoliDocument UIVillaPlusPackageHoliDocument
        {
            get
            {
                if ((this.mUIVillaPlusPackageHoliDocument == null))
                {
                    this.mUIVillaPlusPackageHoliDocument = new UIVillaPlusPackageHoliDocument(this);
                }
                return this.mUIVillaPlusPackageHoliDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPlusPackageHoliDocument mUIVillaPlusPackageHoliDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaPlusPackageHoliDocument : HtmlDocument
    {
        
        public UIVillaPlusPackageHoliDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/amendVillaExtra.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/amendVillaExtra.aspx?", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlSpan UIAddAmendVillaExtrasPane
        {
            get
            {
                if ((this.mUIAddAmendVillaExtrasPane == null))
                {
                    this.mUIAddAmendVillaExtrasPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIAddAmendVillaExtrasPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "ctl00_lblPageHeader";
                    this.mUIAddAmendVillaExtrasPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Add/Amend Villa Extras";
                    this.mUIAddAmendVillaExtrasPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "popTitleBar";
                    this.mUIAddAmendVillaExtrasPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"popTitleBar\" id=\"ctl00_lblPageHeader\"";
                    this.mUIAddAmendVillaExtrasPane.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIAddAmendVillaExtrasPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlSpan mUIAddAmendVillaExtrasPane;
        #endregion
    }
}