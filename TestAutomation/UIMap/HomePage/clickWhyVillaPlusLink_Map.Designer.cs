﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.clickWhyVillaPlusLink_MapClasses
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
    public partial class clickWhyVillaPlusLink_Map:logWriter
    {
        
        /// <summary>
        /// clickWhyVillaPlusLink_Method
        /// </summary>
        public void clickWhyVillaPlusLink_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIWhyVillaPlusHyperlink = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIMnuWhyVPCustom.UIWhyVillaPlusHyperlink;
            #endregion

            // Click 'Why Villa Plus?' link
            Mouse.Click(uIWhyVillaPlusHyperlink, new Point(85, 22));
            string chkURL = this.UIVillaHolidaysThatYouWindow.Uri.ToString();

            try
            {
                StringAssert.Contains(chkURL, "why-book-with-us");
                WriteLogs("PASS : Clicked on Why Villa Plus link from Menu bar.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Cuuld not Click on Why Villa Plus link from Menu bar.");
                WriteLogs("------------" + ex.Message.ToString());
            }
            this.UIVillaHolidaysThatYouWindow.Back();
        }
        
        #region Properties
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
        private UIVillaHolidaysThatYouWindow mUIVillaHolidaysThatYouWindow;
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
        public UIMnuWhyVPCustom UIMnuWhyVPCustom
        {
            get
            {
                if ((this.mUIMnuWhyVPCustom == null))
                {
                    this.mUIMnuWhyVPCustom = new UIMnuWhyVPCustom(this);
                }
                return this.mUIMnuWhyVPCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIMnuWhyVPCustom mUIMnuWhyVPCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIMnuWhyVPCustom : HtmlCustom
    {
        
        public UIMnuWhyVPCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "LI";
            this.SearchProperties["Id"] = "mnuWhyVP";
            this.FilterProperties["ControlDefinition"] = "id=\"mnuWhyVP\"";
            this.FilterProperties.Add(new PropertyExpression("InnerText", "Why Villa Plus? \r\n\r\nAbout Villa Plus\r\n \r", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIWhyVillaPlusHyperlink
        {
            get
            {
                if ((this.mUIWhyVillaPlusHyperlink == null))
                {
                    this.mUIWhyVillaPlusHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIWhyVillaPlusHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Why Villa Plus?";
                    this.mUIWhyVillaPlusHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/why-book-with-us";
                    this.mUIWhyVillaPlusHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, "/why-book-with-us", PropertyExpressionOperator.Contains));
                    this.mUIWhyVillaPlusHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.ControlDefinition, "href=\"/why-book-with-us\"", PropertyExpressionOperator.Contains));
                    this.mUIWhyVillaPlusHyperlink.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIWhyVillaPlusHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIWhyVillaPlusHyperlink;
        #endregion
    }
}
