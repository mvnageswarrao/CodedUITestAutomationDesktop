﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.ClickCreteLink_MapClasses
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
    public partial class ClickCreteLink_Map:logWriter
    {
        
        /// <summary>
        /// ClickCreteLink_Method
        /// </summary>
        public void ClickCreteLink_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uICreteHyperlink = this.UIHomePageWindowsInterWindow.UIHomePageDocument.UICretePane.UICreteHyperlink;
            #endregion

            // Click 'Crete' link
            Mouse.Click(uICreteHyperlink, new Point(14, 10));
            String cmprcrete = this.UIHomePageWindowsInterWindow.Uri.ToString();
            try
            {
                StringAssert.Contains(cmprcrete, "crete");
                WriteLogs("PASS : Verify Crete Villa Lists Page.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Verify Crete Villa Lists Page.");
                WriteLogs("-------EXCEPTION-------" + ex.Message.ToString());
            }
            //if (cmprcrete.Contains("crete"))
            //{
            //    WriteLogs("Verify Crete Villa Lists Page : PASS");
            //}
            //else
            //{
            //    WriteLogs("Verify Crete Villa Lists Page : FAIL");
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
        public HtmlCustom UIForm1Custom
        {
            get
            {
                if ((this.mUIForm1Custom == null))
                {
                    this.mUIForm1Custom = new HtmlCustom(this);
                    #region Search Criteria
                    this.mUIForm1Custom.SearchProperties.Add(new PropertyExpression("Id", "form1", PropertyExpressionOperator.Contains));
                    this.mUIForm1Custom.SearchProperties["TagName"] = "FORM";
                    this.mUIForm1Custom.FilterProperties.Add(new PropertyExpression("ControlDefinition", "id=form1", PropertyExpressionOperator.Contains));
                    this.mUIForm1Custom.FilterProperties["TagInstance"] = "1";
                    this.mUIForm1Custom.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUIForm1Custom;
            }
        }
        
        public UICretePane UICretePane
        {
            get
            {
                if ((this.mUICretePane == null))
                {
                    this.mUICretePane = new UICretePane(this);
                }
                return this.mUICretePane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCustom mUIForm1Custom;
        
        private UICretePane mUICretePane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICretePane : HtmlDiv
    {
        
        public UICretePane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Id, "destCR", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Crete", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "id=destCR", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.TagInstance, "92", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UICreteHyperlink
        {
            get
            {
                if ((this.mUICreteHyperlink == null))
                {
                    this.mUICreteHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUICreteHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUICreteHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUICreteHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUICreteHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Crete";
                    this.mUICreteHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/crete/code_net/villas/villalists.aspx";
                    this.mUICreteHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUICreteHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://nimbus/crete/code_net/villas/villalists.aspx";
                    this.mUICreteHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUICreteHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/crete/code_net/villas/villalists.";
                    this.mUICreteHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUICreteHyperlink.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUICreteHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUICreteHyperlink;
        #endregion
    }
}