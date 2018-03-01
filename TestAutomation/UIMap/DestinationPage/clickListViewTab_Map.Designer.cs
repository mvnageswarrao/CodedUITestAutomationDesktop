﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.DestinationsPage.clickListViewTab_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class clickListViewTab_Map
    {
        
        /// <summary>
        /// clickListViewTab_Method
        /// </summary>
        public void clickListViewTab_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIListViewHyperlink = this.UIHttpnimbusdestinatioWindow.UIHttpnimbusdestinatioDocument.UIDestTabPane.UIListViewHyperlink;
            #endregion

            // Click 'List View' link
            Mouse.Click(uIListViewHyperlink, new Point(47, 11));
        }
        
        #region Properties
        public UIHttpnimbusdestinatioWindow UIHttpnimbusdestinatioWindow
        {
            get
            {
                if ((this.mUIHttpnimbusdestinatioWindow == null))
                {
                    this.mUIHttpnimbusdestinatioWindow = new UIHttpnimbusdestinatioWindow();
                }
                return this.mUIHttpnimbusdestinatioWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpnimbusdestinatioWindow mUIHttpnimbusdestinatioWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHttpnimbusdestinatioWindow : BrowserWindow
    {
        
        public UIHttpnimbusdestinatioWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "destinations.aspx", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("http://nimbus/destinations.aspx");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHttpnimbusdestinatioDocument UIHttpnimbusdestinatioDocument
        {
            get
            {
                if ((this.mUIHttpnimbusdestinatioDocument == null))
                {
                    this.mUIHttpnimbusdestinatioDocument = new UIHttpnimbusdestinatioDocument(this);
                }
                return this.mUIHttpnimbusdestinatioDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpnimbusdestinatioDocument mUIHttpnimbusdestinatioDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHttpnimbusdestinatioDocument : HtmlDocument
    {
        
        public UIHttpnimbusdestinatioDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/destinations.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://nimbus/destinations.aspx";
            this.WindowTitles.Add("http://nimbus/destinations.aspx");
            #endregion
        }
        
        #region Properties
        public UIDestTabPane UIDestTabPane
        {
            get
            {
                if ((this.mUIDestTabPane == null))
                {
                    this.mUIDestTabPane = new UIDestTabPane(this);
                }
                return this.mUIDestTabPane;
            }
        }
        #endregion
        
        #region Fields
        private UIDestTabPane mUIDestTabPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIDestTabPane : HtmlDiv
    {
        
        public UIDestTabPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "destTab";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "List View\r\nMap View\r\n\r\n\r\n\r\n\r\nAlgarve - 1";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "overflow-hidden font11 Border0 ui-tabs ui-widget ui-widget-content ui-corner-all";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"destTab\" class=\"overflow-hidden font";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "20";
            this.WindowTitles.Add("http://nimbus/destinations.aspx");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIListViewHyperlink
        {
            get
            {
                if ((this.mUIListViewHyperlink == null))
                {
                    this.mUIListViewHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIListViewHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIListViewHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIListViewHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIListViewHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "List View";
                    this.mUIListViewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/destinations.aspx";
                    this.mUIListViewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIListViewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://nimbus/destinations.aspx#ListViewTab";
                    this.mUIListViewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIListViewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"#ListViewTab\"";
                    this.mUIListViewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUIListViewHyperlink.WindowTitles.Add("http://nimbus/destinations.aspx");
                    #endregion
                }
                return this.mUIListViewHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIListViewHyperlink;
        #endregion
    }
}
