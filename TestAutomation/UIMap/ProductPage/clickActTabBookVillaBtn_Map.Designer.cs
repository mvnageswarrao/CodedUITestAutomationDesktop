﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.clickActTabBookVillaBtn_MapClasses
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
    public partial class clickActTabBookVillaBtn_Map
    {
        
        /// <summary>
        /// selectActTabBookVillaBtn_Method
        /// </summary>
        public void selectActTabBookVillaBtn_Method()
        {
            #region Variable Declarations
            HtmlDiv uIItemPane = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIAvailabilityTabPane.UIItemPane;
            HtmlInputButton uIBookvillaButton = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UIBookvillaButton;
            #endregion

            //// Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            //Playback.PlaybackSettings.ContinueOnError = true;

            //// Mouse hover  pane at (261, 1)
            //Mouse.Hover(uIItemPane, new Point(261, 1));

            //// Reset flag to ensure that play back stops if there is an error.
            //Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Book villa' button
            Mouse.Click(uIBookvillaButton, new Point(53, 16));
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
        public UIAvailabilityTabPane UIAvailabilityTabPane
        {
            get
            {
                if ((this.mUIAvailabilityTabPane == null))
                {
                    this.mUIAvailabilityTabPane = new UIAvailabilityTabPane(this);
                }
                return this.mUIAvailabilityTabPane;
            }
        }
        
        public HtmlInputButton UIBookvillaButton
        {
            get
            {
                if ((this.mUIBookvillaButton == null))
                {
                    this.mUIBookvillaButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUIBookvillaButton.SearchProperties[HtmlButton.PropertyNames.Id] = "MainContent_VillaAvailability_btnBookVilla";
                    this.mUIBookvillaButton.SearchProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Name, "$MainContent$VillaAvailability$btnBookVilla", PropertyExpressionOperator.Contains));
                    this.mUIBookvillaButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "Book villa";
                    this.mUIBookvillaButton.FilterProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIBookvillaButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUIBookvillaButton.FilterProperties[HtmlButton.PropertyNames.Class] = "button";
                    this.mUIBookvillaButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "id=\"MainContent_VillaAvailability_btnBoo";
                    this.mUIBookvillaButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "24";
                    this.mUIBookvillaButton.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIBookvillaButton;
            }
        }
        #endregion
        
        #region Fields
        private UIAvailabilityTabPane mUIAvailabilityTabPane;
        
        private HtmlInputButton mUIBookvillaButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIAvailabilityTabPane : HtmlDiv
    {
        
        public UIAvailabilityTabPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "AvailabilityTab";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "\r\n\r\nPrices & availability\r\n Please provi";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "vi-tabs ui-tabs-panel ui-widget-content ui-corner-bottom";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"min-height: 625px;\" id=\"Availabil";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "170";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        #region Properties
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
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "availability-calendar-extras availability-calendar-footer clearfix";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"availability-calendar-extras avai";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "65";
                    this.mUIItemPane.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUIItemPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIItemPane;
        #endregion
    }
}
