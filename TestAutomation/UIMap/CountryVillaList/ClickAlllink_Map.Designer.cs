﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.CountryVillaList.ClickAlllink_MapClasses
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
    public partial class ClickAlllink_Map
    {
        
        /// <summary>
        /// ClickAllLink_Method
        /// </summary>
        public void ClickAllLink_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIAllHyperlink = this.UIHttpnimbusAlgarvevilWindow.UIHttpnimbusAlgarvevilDocument.UIAllHyperlink;
            #endregion

            // Click 'All' link
            Mouse.Click(uIAllHyperlink, new Point(8, 6));
        }
        
        #region Properties
        public UIHttpnimbusAlgarvevilWindow UIHttpnimbusAlgarvevilWindow
        {
            get
            {
                if ((this.mUIHttpnimbusAlgarvevilWindow == null))
                {
                    this.mUIHttpnimbusAlgarvevilWindow = new UIHttpnimbusAlgarvevilWindow();
                }
                return this.mUIHttpnimbusAlgarvevilWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpnimbusAlgarvevilWindow mUIHttpnimbusAlgarvevilWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHttpnimbusAlgarvevilWindow : BrowserWindow
    {
        
        public UIHttpnimbusAlgarvevilWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "http://nimbus/Algarve/villas";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("http://nimbus/Algarve/villas");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHttpnimbusAlgarvevilDocument UIHttpnimbusAlgarvevilDocument
        {
            get
            {
                if ((this.mUIHttpnimbusAlgarvevilDocument == null))
                {
                    this.mUIHttpnimbusAlgarvevilDocument = new UIHttpnimbusAlgarvevilDocument(this);
                }
                return this.mUIHttpnimbusAlgarvevilDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpnimbusAlgarvevilDocument mUIHttpnimbusAlgarvevilDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHttpnimbusAlgarvevilDocument : HtmlDocument
    {
        
        public UIHttpnimbusAlgarvevilDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Algarve/villas";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://nimbus/Algarve/villas";
            this.WindowTitles.Add("http://nimbus/Algarve/villas");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIAllHyperlink
        {
            get
            {
                if ((this.mUIAllHyperlink == null))
                {
                    this.mUIAllHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIAllHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "MainContent_pgSizeList_pgsize_2";
                    this.mUIAllHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIAllHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIAllHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "All";
                    this.mUIAllHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "__doPostBack(\'ctl00$MainContent$pgSizeList$ctrl4$pgsize\',\'\')";
                    this.mUIAllHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIAllHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "javascript:__doPostBack(\'ctl00$MainContent$pgSizeList$ctrl4$pgsize\',\'\')";
                    this.mUIAllHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "CommonColor bold";
                    this.mUIAllHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "id=\"MainContent_pgSizeList_pgsize_2\" cla";
                    this.mUIAllHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "56";
                    this.mUIAllHyperlink.WindowTitles.Add("http://nimbus/Algarve/villas");
                    #endregion
                }
                return this.mUIAllHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIAllHyperlink;
        #endregion
    }
}
