﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.clickLocationTab_MapClasses
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
    public partial class clickLocationTab_Map
    {
        
        /// <summary>
        /// clickLocationTab_Method
        /// </summary>
        public void clickLocationTab_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uILocationHyperlink = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIVITabsPane.UILocationHyperlink;
            #endregion

            // Click 'Location' link
            Mouse.Click(uILocationHyperlink, new Point(52, 8));
        }
        
        #region Properties
        public UICanas1bdrmEQuintadoLWindow UICanas1bdrmEQuintadoLWindow
        {
            get
            {
                if ((this.mUICanas1bdrmEQuintadoLWindow == null))
                {
                    this.mUICanas1bdrmEQuintadoLWindow = new UICanas1bdrmEQuintadoLWindow();
                }
                return this.mUICanas1bdrmEQuintadoLWindow;
            }
        }
        #endregion
        
        #region Fields
        private UICanas1bdrmEQuintadoLWindow mUICanas1bdrmEQuintadoLWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICanas1bdrmEQuintadoLWindow : BrowserWindow
    {
        
        public UICanas1bdrmEQuintadoLWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UICanas1bdrmEQuintadoLDocument UICanas1bdrmEQuintadoLDocument
        {
            get
            {
                if ((this.mUICanas1bdrmEQuintadoLDocument == null))
                {
                    this.mUICanas1bdrmEQuintadoLDocument = new UICanas1bdrmEQuintadoLDocument(this);
                }
                return this.mUICanas1bdrmEQuintadoLDocument;
            }
        }
        #endregion
        
        #region Fields
        private UICanas1bdrmEQuintadoLDocument mUICanas1bdrmEQuintadoLDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICanas1bdrmEQuintadoLDocument : HtmlDocument
    {
        
        public UICanas1bdrmEQuintadoLDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/product.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://nimbus/product.aspx?villaid=275";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIVITabsPane UIVITabsPane
        {
            get
            {
                if ((this.mUIVITabsPane == null))
                {
                    this.mUIVITabsPane = new UIVITabsPane(this);
                }
                return this.mUIVITabsPane;
            }
        }
        #endregion
        
        #region Fields
        private UIVITabsPane mUIVITabsPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIVITabsPane : HtmlDiv
    {
        
        public UIVITabsPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "VITabs";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Overview Photos Virtual tour Location Ac";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "overflow-hidden font11 Border0 width100pc ui-tabs ui-widget ui-widget-content ui-" +
                "corner-all";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=VITabs class=\"overflow-hidden font11 ";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "44";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UILocationHyperlink
        {
            get
            {
                if ((this.mUILocationHyperlink == null))
                {
                    this.mUILocationHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUILocationHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUILocationHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUILocationHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUILocationHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Location";
                    this.mUILocationHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/product.aspx";
                    this.mUILocationHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUILocationHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://nimbus/product.aspx?villaid=275#LocationTab";
                    this.mUILocationHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUILocationHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"#LocationTab\" jQuery17102747048879";
                    this.mUILocationHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "4";
                    this.mUILocationHyperlink.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUILocationHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUILocationHyperlink;
        #endregion
    }
}