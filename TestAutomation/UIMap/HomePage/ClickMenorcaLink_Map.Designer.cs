﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.ClickMenorcaLink_MapClasses
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
    public partial class ClickMenorcaLink_Map:logWriter
    {
        
        /// <summary>
        /// ClickMenorcaLink_Method
        /// </summary>
        public void ClickMenorcaLink_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIMenorcaHyperlink = this.UIHomePageWindowsInterWindow.UIHomePageDocument.UIMenorcaPane.UIMenorcaHyperlink;
            #endregion

            // Click 'Menorca' link
            Mouse.Click(uIMenorcaHyperlink, new Point(13, 7));
            String cmprmenorca = this.UIHomePageWindowsInterWindow.Uri.ToString();
            try
            {
                StringAssert.Contains(cmprmenorca, "menorca");
                WriteLogs("PASS : Verify Menorca Villa Lists Page.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Verify Menorca Villa Lists Page.");
                WriteLogs("-------EXCEPTION-------" + ex.Message.ToString());
            }
            //if (cmprmenorca.Contains("menorca"))
            //{
            //    WriteLogs("Verify Menorca Villa Lists page : PASS");
            //}
            //else
            //{
            //    WriteLogs("Verify Menorca Villa Lists Page : FAIL");
 
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
        public UIMenorcaPane UIMenorcaPane
        {
            get
            {
                if ((this.mUIMenorcaPane == null))
                {
                    this.mUIMenorcaPane = new UIMenorcaPane(this);
                }
                return this.mUIMenorcaPane;
            }
        }
        #endregion
        
        #region Fields
        private UIMenorcaPane mUIMenorcaPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIMenorcaPane : HtmlDiv
    {
        
        public UIMenorcaPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Id, "destME", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Menorca";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "id=destME", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.TagInstance, "96", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIMenorcaHyperlink
        {
            get
            {
                if ((this.mUIMenorcaHyperlink == null))
                {
                    this.mUIMenorcaHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIMenorcaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIMenorcaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIMenorcaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIMenorcaHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Menorca";
                    this.mUIMenorcaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/menorca/code_net/villas/villalists.aspx";
                    this.mUIMenorcaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIMenorcaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://nimbus/menorca/code_net/villas/villalists.aspx";
                    this.mUIMenorcaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIMenorcaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/menorca/code_net/villas/villalist";
                    this.mUIMenorcaHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUIMenorcaHyperlink.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUIMenorcaHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIMenorcaHyperlink;
        #endregion
    }
}
