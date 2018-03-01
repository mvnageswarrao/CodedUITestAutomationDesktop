﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.clickDestVillasPageLink_MapClasses
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
    public partial class clickDestVillasPageLink_Map:logWriter
    {
        
        /// <summary>
        /// clickDestVillasPageLink_Method
        /// </summary>
        public void clickDestVillasPageLink_Method()
        {
            #region Variable Declarations
            HtmlDiv uIHeaderPane = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIHeaderPane;
            HtmlHyperlink uIDestinationsHyperlink = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIMnuDestsCustom.UIDestinationsHyperlink;
            HtmlHyperlink uIViewvillas1Hyperlink = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIMenu_dest_layerCustom.UIViewvillas1Hyperlink;
            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover 'header' pane at (1053, 101)
            Mouse.Hover(uIHeaderPane, new Point(1053, 101));

            // Mouse hover 'Destinations' link at (86, 21)
            Mouse.Hover(uIDestinationsHyperlink, new Point(86, 21));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'View villas' link
            Mouse.Click(uIViewvillas1Hyperlink, new Point(27, 7));
            string chkURL = this.UIVillaHolidaysThatYouWindow.Uri.ToString();

            try
            {
                StringAssert.Contains(chkURL, "majorca/villas");
                WriteLogs("PASS : Clicked on Destination Villas Page from Menubar.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Clicked on Destination Villas Page from Menubar.");
                WriteLogs("-------------" + ex.Message.ToString());
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
        public HtmlDiv UIHeaderPane
        {
            get
            {
                if ((this.mUIHeaderPane == null))
                {
                    this.mUIHeaderPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIHeaderPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "header";
                    this.mUIHeaderPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Newsletter Sign-up \r\n\r\n\r\nNewsletter Sign";
                    this.mUIHeaderPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "clearfix";
                    this.mUIHeaderPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"clearfix\" id=\"header\"", PropertyExpressionOperator.Contains));
                    this.mUIHeaderPane.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIHeaderPane;
            }
        }
        
        public UIMnuDestsCustom UIMnuDestsCustom
        {
            get
            {
                if ((this.mUIMnuDestsCustom == null))
                {
                    this.mUIMnuDestsCustom = new UIMnuDestsCustom(this);
                }
                return this.mUIMnuDestsCustom;
            }
        }
        
        public UIMenu_dest_layerCustom UIMenu_dest_layerCustom
        {
            get
            {
                if ((this.mUIMenu_dest_layerCustom == null))
                {
                    this.mUIMenu_dest_layerCustom = new UIMenu_dest_layerCustom(this);
                }
                return this.mUIMenu_dest_layerCustom;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIHeaderPane;
        
        private UIMnuDestsCustom mUIMnuDestsCustom;
        
        private UIMenu_dest_layerCustom mUIMenu_dest_layerCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIMnuDestsCustom : HtmlCustom
    {
        
        public UIMnuDestsCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "LI";
            this.SearchProperties["Id"] = "mnuDests";
            this.FilterProperties.Add(new PropertyExpression("ControlDefinition", "id=\"mnuDests\" onmouseover=\"javascript:Sh", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression("InnerText", "Destinations Algarve\r\nView villas (172)\r", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIDestinationsHyperlink
        {
            get
            {
                if ((this.mUIDestinationsHyperlink == null))
                {
                    this.mUIDestinationsHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIDestinationsHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIDestinationsHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIDestinationsHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIDestinationsHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Destinations";
                    this.mUIDestinationsHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/destinations";
                    this.mUIDestinationsHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, "/destinations", PropertyExpressionOperator.Contains));
                    this.mUIDestinationsHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.ControlDefinition, "href=\"/destinations\"", PropertyExpressionOperator.Contains));
                    this.mUIDestinationsHyperlink.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIDestinationsHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIDestinationsHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIMenu_dest_layerCustom : HtmlCustom
    {
        
        public UIMenu_dest_layerCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "UL";
            this.SearchProperties["Id"] = "menu_dest_layer";
            this.FilterProperties["ControlDefinition"] = "id=\"menu_dest_layer\"";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIViewvillas1Hyperlink
        {
            get
            {
                if ((this.mUIViewvillas1Hyperlink == null))
                {
                    this.mUIViewvillas1Hyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIViewvillas1Hyperlink.SearchProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.InnerText, "View villas", PropertyExpressionOperator.Contains));
                    this.mUIViewvillas1Hyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "/majorca/villas", PropertyExpressionOperator.Contains));
                    this.mUIViewvillas1Hyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, "/majorca/villas", PropertyExpressionOperator.Contains));
                    this.mUIViewvillas1Hyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.ControlDefinition, "href=\"/majorca/villas\"", PropertyExpressionOperator.Contains));
                    this.mUIViewvillas1Hyperlink.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIViewvillas1Hyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIViewvillas1Hyperlink;
        #endregion
    }
}
