﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.clickActTabClosePriceWindow_MapClasses
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
    public partial class clickActTabClosePriceWindow_Map
    {
        
        /// <summary>
        /// clickActTabClosePriceWindow_Method
        /// </summary>
        public void clickActTabClosePriceWindow_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uICloseHyperlink1 = this.UIVillaPoppyPolisCypruWindow.UIVillaPoppyPolisCypruDocument.UICloseHyperlink1;
            #endregion

            // Click 'close' link
            Mouse.Click(uICloseHyperlink1, new Point(13, 11));
        }
        
        #region Properties
        public UIVillaPoppyPolisCypruWindow UIVillaPoppyPolisCypruWindow
        {
            get
            {
                if ((this.mUIVillaPoppyPolisCypruWindow == null))
                {
                    this.mUIVillaPoppyPolisCypruWindow = new UIVillaPoppyPolisCypruWindow();
                }
                return this.mUIVillaPoppyPolisCypruWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPoppyPolisCypruWindow mUIVillaPoppyPolisCypruWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIVillaPoppyPolisCypruWindow : BrowserWindow
    {
        
        public UIVillaPoppyPolisCypruWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Poppy, Polis, Cyprus, Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaPoppyPolisCypruDocument UIVillaPoppyPolisCypruDocument
        {
            get
            {
                if ((this.mUIVillaPoppyPolisCypruDocument == null))
                {
                    this.mUIVillaPoppyPolisCypruDocument = new UIVillaPoppyPolisCypruDocument(this);
                }
                return this.mUIVillaPoppyPolisCypruDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPoppyPolisCypruDocument mUIVillaPoppyPolisCypruDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIVillaPoppyPolisCypruDocument : HtmlDocument
    {
        
        public UIVillaPoppyPolisCypruDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Villa Poppy, Polis, Cyprus, Villa Plus";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/product.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://nimbus/product.aspx?villaid=914";
            this.WindowTitles.Add("Villa Poppy, Polis, Cyprus, Villa Plus");
            #endregion
        }
        
        #region Properties
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
                    this.mUICloseHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://nimbus/product.aspx?villaid=914#";
                    this.mUICloseHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "ui-dialog-titlebar-close ui-corner-all";
                    this.mUICloseHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"ui-dialog-titlebar-close ui-corne";
                    this.mUICloseHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "162";
                    this.mUICloseHyperlink.WindowTitles.Add("Villa Poppy, Polis, Cyprus, Villa Plus");
                    #endregion
                }
                return this.mUICloseHyperlink;
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
                    this.mUICloseHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://nimbus/product.aspx?villaid=914#";
                    this.mUICloseHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "ui-dialog-titlebar-close ui-corner-all";
                    this.mUICloseHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"ui-dialog-titlebar-close ui-corne";
                    this.mUICloseHyperlink1.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "164";
                    this.mUICloseHyperlink1.WindowTitles.Add("Villa Poppy, Polis, Cyprus, Villa Plus");
                    #endregion
                }
                return this.mUICloseHyperlink1;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUICloseHyperlink;
        
        private HtmlHyperlink mUICloseHyperlink1;
        #endregion
    }
}