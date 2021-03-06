﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.ClickTenerifeLink_MapClasses
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
    public partial class ClickTenerifeLink_Map:logWriter
    {
        
        /// <summary>
        /// ClickTenerifeLink_Method
        /// </summary>
        public void ClickTenerifeLink_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uITenerifeHyperlink = this.UIHomePageWindowsInterWindow.UIHomePageDocument.UITenerifePane.UITenerifeHyperlink;
            #endregion

            // Click 'Tenerife' link
            Mouse.Click(uITenerifeHyperlink, new Point(28, 6));
            String cmprtenerife = this.UIHomePageWindowsInterWindow.Uri.ToString();
            try
            {
                StringAssert.Contains(cmprtenerife, "tenerife");
                WriteLogs("PASS : Tenerife Villa Lists Page opened.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Verify Tenerife Villa Lists Page.");
                WriteLogs("-------EXCEPTION-------" + ex.Message.ToString());
            }
            //if (cmprtenerife.Contains("tenerife"))
            //{
            //    WriteLogs("Verify Tenerife Villa Lists Page : PASS");
            //}
            //else
            //{
            //    WriteLogs("Verify Tenerife Villa Lists Page : FAIL");
 
            //}
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
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Home Page";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "http://nimbus/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public UITenerifePane UITenerifePane
        {
            get
            {
                if ((this.mUITenerifePane == null))
                {
                    this.mUITenerifePane = new UITenerifePane(this);
                }
                return this.mUITenerifePane;
            }
        }
        #endregion
        
        #region Fields
        private UITenerifePane mUITenerifePane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UITenerifePane : HtmlDiv
    {
        
        public UITenerifePane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Id, "destTE", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Tenerife";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "id=destTE", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.TagInstance, "100", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UITenerifeHyperlink
        {
            get
            {
                if ((this.mUITenerifeHyperlink == null))
                {
                    this.mUITenerifeHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUITenerifeHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Tenerife";
                    this.mUITenerifeHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "/villalists.aspx", PropertyExpressionOperator.Contains));
                    this.mUITenerifeHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, "/villalists.aspx", PropertyExpressionOperator.Contains));
                    this.mUITenerifeHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUITenerifeHyperlink.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUITenerifeHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUITenerifeHyperlink;
        #endregion
    }
}
