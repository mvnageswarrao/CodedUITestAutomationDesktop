﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.ClickLanzaroteLink_MapClasses
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
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class ClickLanzaroteLink_Map:logWriter
    {
        
        /// <summary>
        /// ClickLanzaroteLink_Method
        /// </summary>
        public void ClickLanzaroteLink_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uILanzaroteHyperlink = this.UIHomePageWindowsInterWindow.UIHomePageDocument.UILanzarotePane.UILanzaroteHyperlink;
            #endregion

            // Click 'Lanzarote' link
            Mouse.Click(uILanzaroteHyperlink, new Point(31, 8));
            String cmprlanzarote = this.UIHomePageWindowsInterWindow.Uri.ToString();
            try
            {
                StringAssert.Contains(cmprlanzarote, "lanzarote");
                WriteLogs("PASS : Verify Lanzarote Villa Lists Page.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Verify Lanzarote Villa Lists Page.");
                WriteLogs("-------EXCEPTION-------" + ex.Message.ToString());
            }
            //    if(cmprlanzarote.Contains("lanzarote"))
            //    {
            //    WriteLogs("Verify Lanzarote Villa Lists Page : PASS");
            //    }
            //else
            //    {
            //    WriteLogs("Verify Lanzarote Villa Lists Page : FAIL");

            //    }
                this.UIHomePageWindowsInterWindow.Back();
        }
        
        #region Properties
        public UIHomePageWindowsInterWindow UIHomePageWindowsInterWindow
        {
            get
            {
                if ((this.mUIHomePageWindowsInterWindow == null))
                {
                    this.mUIHomePageWindowsInterWindow = new UIHomePageWindowsInterWindow();
                }
                return this.mUIHomePageWindowsInterWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIHomePageWindowsInterWindow mUIHomePageWindowsInterWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHomePageWindowsInterWindow : BrowserWindow
    {
        
        public UIHomePageWindowsInterWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Home Page", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHomePageDocument UIHomePageDocument
        {
            get
            {
                if ((this.mUIHomePageDocument == null))
                {
                    this.mUIHomePageDocument = new UIHomePageDocument(this);
                }
                return this.mUIHomePageDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHomePageDocument mUIHomePageDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHomePageDocument : HtmlDocument
    {
        
        public UIHomePageDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Home Page";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "http://nimbus/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public UILanzarotePane UILanzarotePane
        {
            get
            {
                if ((this.mUILanzarotePane == null))
                {
                    this.mUILanzarotePane = new UILanzarotePane(this);
                }
                return this.mUILanzarotePane;
            }
        }
        #endregion
        
        #region Fields
        private UILanzarotePane mUILanzarotePane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UILanzarotePane : HtmlDiv
    {
        
        public UILanzarotePane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Id, "destLA", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Lanzarote", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "id=destLA", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.TagInstance, "99", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UILanzaroteHyperlink
        {
            get
            {
                if ((this.mUILanzaroteHyperlink == null))
                {
                    this.mUILanzaroteHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUILanzaroteHyperlink.SearchProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.InnerText, "Lanzarote", PropertyExpressionOperator.Contains));
                    this.mUILanzaroteHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "villalists.aspx", PropertyExpressionOperator.Contains));
                    this.mUILanzaroteHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, "/villalists.aspx", PropertyExpressionOperator.Contains));
                    this.mUILanzaroteHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUILanzaroteHyperlink.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUILanzaroteHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUILanzaroteHyperlink;
        #endregion
    }
}