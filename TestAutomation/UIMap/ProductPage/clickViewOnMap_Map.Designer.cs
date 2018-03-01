﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.clickViewOnMap_MapClasses
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
    public partial class clickViewOnMap_Map
    {
        
        /// <summary>
        /// clickViewOnMap_Method
        /// </summary>
        public void clickViewOnMap_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIViewonmapHyperlink1 = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIViewonmapHyperlink1;
            HtmlDiv uIItemPane1 = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIItemPane1;
            HtmlHyperlink uICloseHyperlink1 = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UICloseHyperlink1;
            #endregion

            // Click 'View on map' link
            Mouse.Click(uIViewonmapHyperlink1, new Point(32, 8));

            //// Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            //Playback.PlaybackSettings.ContinueOnError = true;

            //// Mouse hover  pane at (193, 634)
            //Mouse.Hover(uIItemPane1, new Point(193, 634));

            //// Reset flag to ensure that play back stops if there is an error.
            //Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'close' link
            Mouse.Click(uICloseHyperlink1, new Point(6, 6));
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
        public HtmlHyperlink UIViewonmapHyperlink
        {
            get
            {
                if ((this.mUIViewonmapHyperlink == null))
                {
                    this.mUIViewonmapHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIViewonmapHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "MainContent_lnkViewOnMap";
                    this.mUIViewonmapHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIViewonmapHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIViewonmapHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "View on map";
                    this.mUIViewonmapHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "__doPostBack(\'ctl00$MainContent$lnkViewOnMap\',\'\')";
                    this.mUIViewonmapHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIViewonmapHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "javascript:__doPostBack(\'ctl00$MainContent$lnkViewOnMap\',\'\')";
                    this.mUIViewonmapHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "font14 bold";
                    this.mUIViewonmapHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "id=\"MainContent_lnkViewOnMap\" class=\"fon";
                    this.mUIViewonmapHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "110";
                    this.mUIViewonmapHyperlink.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIViewonmapHyperlink;
            }
        }
        
        public HtmlDiv UIItemPane
        {
            get
            {
                if ((this.mUIItemPane == null))
                {
                    this.mUIItemPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIItemPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIItemPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "ui-widget-overlay";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"width: 1263px; height: 1870px; z-";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "283";
                    this.mUIItemPane.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIItemPane;
            }
        }
        
        public HtmlHyperlink UICloseHyperlink
        {
            get
            {
                if ((this.mUICloseHyperlink == null))
                {
                    this.mUICloseHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUICloseHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUICloseHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUICloseHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUICloseHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "close";
                    this.mUICloseHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/product.aspx";
                    this.mUICloseHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUICloseHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://nimbus/product.aspx?villaid=275#";
                    this.mUICloseHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "ui-dialog-titlebar-close ui-corner-all";
                    this.mUICloseHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"ui-dialog-titlebar-close ui-corne";
                    this.mUICloseHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "204";
                    this.mUICloseHyperlink.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUICloseHyperlink;
            }
        }
        
        public HtmlHyperlink UIViewonmapHyperlink1
        {
            get
            {
                if ((this.mUIViewonmapHyperlink1 == null))
                {
                    this.mUIViewonmapHyperlink1 = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIViewonmapHyperlink1.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "MainContent_lnkViewOnMap";
                    this.mUIViewonmapHyperlink1.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIViewonmapHyperlink1.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIViewonmapHyperlink1.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "View on map";
                    this.mUIViewonmapHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "__doPostBack(\'ctl00$MainContent$lnkViewOnMap\',\'\')";
                    this.mUIViewonmapHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIViewonmapHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "javascript:__doPostBack(\'ctl00$MainContent$lnkViewOnMap\',\'\')";
                    this.mUIViewonmapHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "font14 bold";
                    this.mUIViewonmapHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "id=\"MainContent_lnkViewOnMap\" class=\"fon";
                    this.mUIViewonmapHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "72";
                    this.mUIViewonmapHyperlink1.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIViewonmapHyperlink1;
            }
        }
        
        public HtmlDiv UIItemPane1
        {
            get
            {
                if ((this.mUIItemPane1 == null))
                {
                    this.mUIItemPane1 = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIItemPane1.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIItemPane1.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIItemPane1.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                    this.mUIItemPane1.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIItemPane1.FilterProperties[HtmlDiv.PropertyNames.Class] = "ui-widget-overlay";
                    this.mUIItemPane1.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"width: 1263px; height: 2589px; z-";
                    this.mUIItemPane1.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "281";
                    this.mUIItemPane1.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIItemPane1;
            }
        }
        
        public HtmlHyperlink UICloseHyperlink1
        {
            get
            {
                if ((this.mUICloseHyperlink1 == null))
                {
                    this.mUICloseHyperlink1 = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUICloseHyperlink1.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUICloseHyperlink1.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUICloseHyperlink1.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUICloseHyperlink1.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "close";
                    this.mUICloseHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/product.aspx";
                    this.mUICloseHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUICloseHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://nimbus/product.aspx?villaid=275#";
                    this.mUICloseHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "ui-dialog-titlebar-close ui-corner-all";
                    this.mUICloseHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"ui-dialog-titlebar-close ui-corne";
                    this.mUICloseHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "167";
                    this.mUICloseHyperlink1.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUICloseHyperlink1;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIViewonmapHyperlink;
        
        private HtmlDiv mUIItemPane;
        
        private HtmlHyperlink mUICloseHyperlink;
        
        private HtmlHyperlink mUIViewonmapHyperlink1;
        
        private HtmlDiv mUIItemPane1;
        
        private HtmlHyperlink mUICloseHyperlink1;
        #endregion
    }
}