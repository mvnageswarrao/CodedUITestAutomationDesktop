﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.clickLandingPageLink_MapClasses
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
    public partial class clickLandingPageLink_Map:logWriter
    {
        
        /// <summary>
        /// clickLandingPageLink_Method
        /// </summary>
        public void clickLandingPageLink_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIVillasHyperlink = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIMnuVillasCustom.UIVillasHyperlink;
            HtmlHyperlink uISeaviewvillasHyperlink = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIMenu_villa_layerCustom.UISeaviewvillasHyperlink;
            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover 'Villas' link at (36, 22)
            Mouse.Hover(uIVillasHyperlink, new Point(36, 22));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Sea view villas' link
            Mouse.Click(uISeaviewvillasHyperlink, new Point(69, 8));
            string chkURL = this.UIVillaHolidaysThatYouWindow.Uri.ToString();

            try
            {
                StringAssert.Contains(chkURL, "sea-view-villas");
                WriteLogs("PASS : Clicked on Sea Views Villa Landing Page link from Menu Bar.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Clicked on Sea Views Villa Landing Page link from Menu Bar.");
                WriteLogs("----------" + ex.Message.ToString());
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
        public HtmlCustom UIFrmDefaultCustom
        {
            get
            {
                if ((this.mUIFrmDefaultCustom == null))
                {
                    this.mUIFrmDefaultCustom = new HtmlCustom(this);
                    #region Search Criteria
                    this.mUIFrmDefaultCustom.SearchProperties["TagName"] = "FORM";
                    this.mUIFrmDefaultCustom.SearchProperties["Id"] = "frmDefault";
                    this.mUIFrmDefaultCustom.FilterProperties["ControlDefinition"] = "id=\"frmDefault\" action=\"default.aspx\" me";
                    this.mUIFrmDefaultCustom.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIFrmDefaultCustom;
            }
        }
        
        public UIMnuVillasCustom UIMnuVillasCustom
        {
            get
            {
                if ((this.mUIMnuVillasCustom == null))
                {
                    this.mUIMnuVillasCustom = new UIMnuVillasCustom(this);
                }
                return this.mUIMnuVillasCustom;
            }
        }
        
        public UIMenu_villa_layerCustom UIMenu_villa_layerCustom
        {
            get
            {
                if ((this.mUIMenu_villa_layerCustom == null))
                {
                    this.mUIMenu_villa_layerCustom = new UIMenu_villa_layerCustom(this);
                }
                return this.mUIMenu_villa_layerCustom;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCustom mUIFrmDefaultCustom;
        
        private UIMnuVillasCustom mUIMnuVillasCustom;
        
        private UIMenu_villa_layerCustom mUIMenu_villa_layerCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIMnuVillasCustom : HtmlCustom
    {
        
        public UIMnuVillasCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "LI";
            this.SearchProperties["Id"] = "mnuVillas";
            this.FilterProperties.Add(new PropertyExpression("Class", "mnuVillasMega", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression("ControlDefinition", "class=\"mnuVillasMega\" id=\"mnuVillas\" onm", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression("InnerText", "Villas \r\n\r\n\r\n\r\nVillas for large families", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIVillasHyperlink
        {
            get
            {
                if ((this.mUIVillasHyperlink == null))
                {
                    this.mUIVillasHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIVillasHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Villas";
                    this.mUIVillasHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/villas";
                    this.mUIVillasHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, "/villas", PropertyExpressionOperator.Contains));
                    this.mUIVillasHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.ControlDefinition, "href=\"/villas\"", PropertyExpressionOperator.Contains));
                    this.mUIVillasHyperlink.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIVillasHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIVillasHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIMenu_villa_layerCustom : HtmlCustom
    {
        
        public UIMenu_villa_layerCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "UL";
            this.SearchProperties["Id"] = "menu_villa_layer";
            this.FilterProperties["Class"] = "clearfix";
            this.FilterProperties["ControlDefinition"] = "class=\"clearfix\" id=\"menu_villa_layer\"";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UISeaviewvillasHyperlink
        {
            get
            {
                if ((this.mUISeaviewvillasHyperlink == null))
                {
                    this.mUISeaviewvillasHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUISeaviewvillasHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Sea view villas";
                    this.mUISeaviewvillasHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/sea-view-villas";
                    this.mUISeaviewvillasHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, "/sea-view-villas", PropertyExpressionOperator.Contains));
                    this.mUISeaviewvillasHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.ControlDefinition, "href=\"/sea-view-villas\"", PropertyExpressionOperator.Contains));
                    this.mUISeaviewvillasHyperlink.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUISeaviewvillasHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUISeaviewvillasHyperlink;
        #endregion
    }
}
