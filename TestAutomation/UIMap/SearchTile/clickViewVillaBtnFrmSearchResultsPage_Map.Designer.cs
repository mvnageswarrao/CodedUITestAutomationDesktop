﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchTile.clickViewVillaBtnFrmSearchResultsPage_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class clickViewVillaBtnFrmSearchResultsPage_Map
    {
        
        /// <summary>
        /// clickViewVillaBtnFrmSearchResultsPage_Method
        /// </summary>
        public void clickViewVillaBtnFrmSearchResultsPage_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIViewVillaHyperlink = this.UIYoursearchfound84VilWindow.UIYoursearchfound84VilDocument.UIViewVillaHyperlink;
            #endregion

            uIViewVillaHyperlink.WaitForControlEnabled();

            // Click 'View Villa' link
            Mouse.Click(uIViewVillaHyperlink, new Point(46, 13));
        }
        
        #region Properties
        public UIYoursearchfound23VilWindow UIYoursearchfound23VilWindow
        {
            get
            {
                if ((this.mUIYoursearchfound23VilWindow == null))
                {
                    this.mUIYoursearchfound23VilWindow = new UIYoursearchfound23VilWindow();
                }
                return this.mUIYoursearchfound23VilWindow;
            }
        }
        
        public UIYoursearchfound191ViWindow UIYoursearchfound191ViWindow
        {
            get
            {
                if ((this.mUIYoursearchfound191ViWindow == null))
                {
                    this.mUIYoursearchfound191ViWindow = new UIYoursearchfound191ViWindow();
                }
                return this.mUIYoursearchfound191ViWindow;
            }
        }
        
        public UIYoursearchfound84VilWindow UIYoursearchfound84VilWindow
        {
            get
            {
                if ((this.mUIYoursearchfound84VilWindow == null))
                {
                    this.mUIYoursearchfound84VilWindow = new UIYoursearchfound84VilWindow();
                }
                return this.mUIYoursearchfound84VilWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound23VilWindow mUIYoursearchfound23VilWindow;
        
        private UIYoursearchfound191ViWindow mUIYoursearchfound191ViWindow;
        
        private UIYoursearchfound84VilWindow mUIYoursearchfound84VilWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYoursearchfound23VilWindow : BrowserWindow
    {
        
        public UIYoursearchfound23VilWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your search found", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your search found ");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYoursearchfound23VilDocument UIYoursearchfound23VilDocument
        {
            get
            {
                if ((this.mUIYoursearchfound23VilDocument == null))
                {
                    this.mUIYoursearchfound23VilDocument = new UIYoursearchfound23VilDocument(this);
                }
                return this.mUIYoursearchfound23VilDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound23VilDocument mUIYoursearchfound23VilDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYoursearchfound23VilDocument : HtmlDocument
    {
        
        public UIYoursearchfound23VilDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your search found", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/searchresult.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/searchresult.aspx?", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your search found");
            #endregion
        }
        
        #region Properties
        public HtmlInputButton UIViewvillaButton
        {
            get
            {
                if ((this.mUIViewvillaButton == null))
                {
                    this.mUIViewvillaButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUIViewvillaButton.SearchProperties[HtmlButton.PropertyNames.Id] = "MainContent_lvVillaInfo_villaCtrl_0_btnViewVilla_0";
                    this.mUIViewvillaButton.SearchProperties[HtmlButton.PropertyNames.Name] = "ctl00$MainContent$lvVillaInfo$ctrl0$villaCtrl$btnViewVilla";
                    this.mUIViewvillaButton.FilterProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.DisplayText, "View villa", PropertyExpressionOperator.Contains));
                    this.mUIViewvillaButton.FilterProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIViewvillaButton.FilterProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Title, "View Villa", PropertyExpressionOperator.Contains));
                    this.mUIViewvillaButton.FilterProperties[HtmlButton.PropertyNames.Class] = "button font12 bold";
                    this.mUIViewvillaButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "name=\"ctl00$MainContent$lvVillaInfo$ctrl";
                    this.mUIViewvillaButton.WindowTitles.Add("Your search found");
                    #endregion
                }
                return this.mUIViewvillaButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlInputButton mUIViewvillaButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYoursearchfound191ViWindow : BrowserWindow
    {
        
        public UIYoursearchfound191ViWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your search found", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your search found ");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYoursearchfound191ViDocument UIYoursearchfound191ViDocument
        {
            get
            {
                if ((this.mUIYoursearchfound191ViDocument == null))
                {
                    this.mUIYoursearchfound191ViDocument = new UIYoursearchfound191ViDocument(this);
                }
                return this.mUIYoursearchfound191ViDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound191ViDocument mUIYoursearchfound191ViDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYoursearchfound191ViDocument : HtmlDocument
    {
        
        public UIYoursearchfound191ViDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Your search found 191 Villa holidays";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/searchresult.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://rup.villaplus.com/searchresult.aspx?2015any destination";
            this.WindowTitles.Add("Your search found 191 Villa holidays");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIViewVillaHyperlink
        {
            get
            {
                if ((this.mUIViewVillaHyperlink == null))
                {
                    this.mUIViewVillaHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIViewVillaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "MainContent_lvVillaInfo_villaCtrl_0_ancViewVilla_0";
                    this.mUIViewVillaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIViewVillaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIViewVillaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "View Villa";
                    this.mUIViewVillaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/menorca/villas/son-bou/villa-torrenova";
                    this.mUIViewVillaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "click to view this villa";
                    this.mUIViewVillaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://rup.villaplus.com/menorca/villas/son-bou/villa-torrenova?2015menorca";
                    this.mUIViewVillaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "ancvillaimg ancViewVilla";
                    this.mUIViewVillaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "title=\"click to view this villa\" class=\"";
                    this.mUIViewVillaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "43";
                    this.mUIViewVillaHyperlink.WindowTitles.Add("Your search found 191 Villa holidays");
                    #endregion
                }
                return this.mUIViewVillaHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIViewVillaHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYoursearchfound84VilWindow : BrowserWindow
    {
        
        public UIYoursearchfound84VilWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your search found ", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your search found ");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYoursearchfound84VilDocument UIYoursearchfound84VilDocument
        {
            get
            {
                if ((this.mUIYoursearchfound84VilDocument == null))
                {
                    this.mUIYoursearchfound84VilDocument = new UIYoursearchfound84VilDocument(this);
                }
                return this.mUIYoursearchfound84VilDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound84VilDocument mUIYoursearchfound84VilDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYoursearchfound84VilDocument : HtmlDocument
    {
        
        public UIYoursearchfound84VilDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = "";
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Your search found 84 Villa holidays";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/searchresult.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://rup.villaplus.com/searchresult.aspx?2015any destination";
            this.WindowTitles.Add("Your search found ");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIViewVillaHyperlink
        {
            get
            {
                if ((this.mUIViewVillaHyperlink == null))
                {
                    this.mUIViewVillaHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIViewVillaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "MainContent_lvVillaInfo_villaCtrl_0_ancViewVilla_0";
                    this.mUIViewVillaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIViewVillaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIViewVillaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "View Villa";
                    this.mUIViewVillaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/tenerife/villas/callao-salvaje/villa-laura-salvaje";
                    this.mUIViewVillaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "click to view this villa";
                    this.mUIViewVillaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://rup.villaplus.com/tenerife/villas/callao-salvaje/villa-laura-salvaje?2015t" +
                        "enerife";
                    this.mUIViewVillaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "ancvillaimg ancViewVilla";
                    this.mUIViewVillaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "title=\"click to view this villa\" class=\"";
                    this.mUIViewVillaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "42";
                    this.mUIViewVillaHyperlink.WindowTitles.Add("Your search found ");
                    #endregion
                }
                return this.mUIViewVillaHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIViewVillaHyperlink;
        #endregion
    }
}
