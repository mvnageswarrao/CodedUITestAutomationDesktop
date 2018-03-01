﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.verifyVisitTrustPilotLink_MapClasses
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
    public partial class verifyVisitTrustPilotLink_Map:logWriter
    {
        
        /// <summary>
        /// verifyVisitTrustPilotLink_Method - Use 'verifyVisitTrustPilotLink_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyVisitTrustPilotLink_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIVisitTrustPilotHyperlink = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIVisitTrustPilotPane.UIVisitTrustPilotHyperlink;
            #endregion

            try
            {
                // Verify that the 'Href' property of 'Visit Trust Pilot' link equals 'http://www.trustpilot.com/review/www.villaplus.com'
                Assert.AreEqual(this.verifyVisitTrustPilotLink_MethodExpectedValues.UIVisitTrustPilotHyperlinkHref, uIVisitTrustPilotHyperlink.Href, "URL is not matched");
                WriteLogs("PASS : Verify the Visit Trust Pilot Link URL.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Verify the Visit Trust Pilot Link URL.");
                WriteLogs("-----------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyVisitTrustPilotLink_MethodExpectedValues verifyVisitTrustPilotLink_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyVisitTrustPilotLink_MethodExpectedValues == null))
                {
                    this.mverifyVisitTrustPilotLink_MethodExpectedValues = new verifyVisitTrustPilotLink_MethodExpectedValues();
                }
                return this.mverifyVisitTrustPilotLink_MethodExpectedValues;
            }
        }
        
        public UIVillaHolidaysThatYouWindow UIVillaHolidaysThatYouWindow
        {
            get
            {
                if ((this.mUIVillaHolidaysThatYouWindow == null))
                {
                    this.mUIVillaHolidaysThatYouWindow = new UIVillaHolidaysThatYouWindow();
                }
                return this.mUIVillaHolidaysThatYouWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyVisitTrustPilotLink_MethodExpectedValues mverifyVisitTrustPilotLink_MethodExpectedValues;
        
        private UIVillaHolidaysThatYouWindow mUIVillaHolidaysThatYouWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyVisitTrustPilotLink_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class verifyVisitTrustPilotLink_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Href' property of 'Visit Trust Pilot' link equals 'http://www.trustpilot.com/review/www.villaplus.com'
        /// </summary>
        public string UIVisitTrustPilotHyperlinkHref = "http://www.trustpilot.com/review/www.villaplus.com";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaHolidaysThatYouWindow : BrowserWindow
    {
        
        public UIVillaHolidaysThatYouWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Villa Holidays That You’ll Love More | Villa Plus";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaHolidaysThatYouDocument UIVillaHolidaysThatYouDocument
        {
            get
            {
                if ((this.mUIVillaHolidaysThatYouDocument == null))
                {
                    this.mUIVillaHolidaysThatYouDocument = new UIVillaHolidaysThatYouDocument(this);
                }
                return this.mUIVillaHolidaysThatYouDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaHolidaysThatYouDocument mUIVillaHolidaysThatYouDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVillaHolidaysThatYouDocument : HtmlDocument
    {
        
        public UIVillaHolidaysThatYouDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Villa Holidays That You’ll Love More | Villa Plus";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIVisitTrustPilotPane UIVisitTrustPilotPane
        {
            get
            {
                if ((this.mUIVisitTrustPilotPane == null))
                {
                    this.mUIVisitTrustPilotPane = new UIVisitTrustPilotPane(this);
                }
                return this.mUIVisitTrustPilotPane;
            }
        }
        #endregion
        
        #region Fields
        private UIVisitTrustPilotPane mUIVisitTrustPilotPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIVisitTrustPilotPane : HtmlDiv
    {
        
        public UIVisitTrustPilotPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "VisitTrustPilot";
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Visit Trust Pilot ";
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "aRow";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"aRow\" id=\"VisitTrustPilot\"";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIVisitTrustPilotHyperlink
        {
            get
            {
                if ((this.mUIVisitTrustPilotHyperlink == null))
                {
                    this.mUIVisitTrustPilotHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIVisitTrustPilotHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = "_blank";
                    this.mUIVisitTrustPilotHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Visit Trust Pilot";
                    this.mUIVisitTrustPilotHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/review/www.villaplus.com";
                    this.mUIVisitTrustPilotHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://www.trustpilot.com/review/www.villaplus.com";
                    this.mUIVisitTrustPilotHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.ControlDefinition, "onclick=\"javascript:ga(\'send\', \'event\', ", PropertyExpressionOperator.Contains));
                    this.mUIVisitTrustPilotHyperlink.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIVisitTrustPilotHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIVisitTrustPilotHyperlink;
        #endregion
    }
}