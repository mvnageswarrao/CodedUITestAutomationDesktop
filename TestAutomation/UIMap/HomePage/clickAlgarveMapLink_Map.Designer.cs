﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.clickAlgarveMapLink_MapClasses
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
    public partial class clickAlgarveMapLink_Map:logWriter
    {
        
        /// <summary>
        /// clickAlgarveMapLink_Method
        /// </summary>
        public void clickAlgarveMapLink_Method()
        {
            #region Variable Declarations
            HtmlAreaHyperlink uIAlgarveHyperlink = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIDestMapCustom.UIAlgarveHyperlink;
            #endregion

            // Click 'Algarve' link
            Mouse.Click(uIAlgarveHyperlink, new Point(7, 4));
            string chkURL = this.UIVillaHolidaysThatYouWindow.Uri.ToString();

            try
            {
                StringAssert.Contains(chkURL, "algarve");
                WriteLogs("PASS : Clicked on Algarve link from Map Section.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Clicked on Algarve link from Map Section.");
                WriteLogs("--------" + ex.Message.ToString());
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
        public UIDestMapCustom UIDestMapCustom
        {
            get
            {
                if ((this.mUIDestMapCustom == null))
                {
                    this.mUIDestMapCustom = new UIDestMapCustom(this);
                }
                return this.mUIDestMapCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIDestMapCustom mUIDestMapCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIDestMapCustom : HtmlCustom
    {
        
        public UIDestMapCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "MAP";
            this.SearchProperties["Id"] = "destMap";
            this.SearchProperties[UITestControl.PropertyNames.Name] = "destMap";
            this.FilterProperties.Add(new PropertyExpression("ControlDefinition", "name=\"destMap\" id=\"destMap\"", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlAreaHyperlink UIAlgarveHyperlink
        {
            get
            {
                if ((this.mUIAlgarveHyperlink == null))
                {
                    this.mUIAlgarveHyperlink = new HtmlAreaHyperlink(this);
                    #region Search Criteria
                    this.mUIAlgarveHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "/algarve", PropertyExpressionOperator.Contains));
                    this.mUIAlgarveHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Title, "Algarve", PropertyExpressionOperator.Contains));
                    this.mUIAlgarveHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, "/algarve", PropertyExpressionOperator.Contains));
                    this.mUIAlgarveHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.ControlDefinition, "title=\"Algarve\" href=\"/algarve\" ", PropertyExpressionOperator.Contains));
                    this.mUIAlgarveHyperlink.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIAlgarveHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlAreaHyperlink mUIAlgarveHyperlink;
        #endregion
    }
}