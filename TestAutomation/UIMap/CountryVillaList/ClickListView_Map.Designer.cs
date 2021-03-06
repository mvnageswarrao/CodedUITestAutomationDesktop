﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.CountryVillaList.ClickListView_MapClasses
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
    public partial class ClickListView_Map
    {
        
        /// <summary>
        /// ClickListView_Method
        /// </summary>
        public void ClickListView_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIListViewHyperlink = this.UIHttpnimbusAlgarvevilWindow.UIHttpnimbusAlgarvevilDocument.UIDestTabPane.UIListViewHyperlink;
            #endregion

            // Click 'List View' link
            Mouse.Click(uIListViewHyperlink, new Point(29, 14));
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
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "/villas", PropertyExpressionOperator.Contains));
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
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/villas", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/villas", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("http://nimbus/Algarve/villas");
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
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = "";
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "overflow-hidden font11 Border0 ui-tabs ui-widget ui-widget-content ui-corner-all";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"destTab\" class=\"overflow-hidden font";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "23";
            this.WindowTitles.Add("http://nimbus/Algarve/villas");
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
                    this.mUIListViewHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "/villas", PropertyExpressionOperator.Contains));
                    this.mUIListViewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = "";
                    this.mUIListViewHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, "/villas#ListViewTab", PropertyExpressionOperator.Contains));
                    this.mUIListViewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "";
                    this.mUIListViewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"#ListViewTab\"";
                    this.mUIListViewHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUIListViewHyperlink.WindowTitles.Add("http://nimbus/Algarve/villas");
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
