﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.VerifyAdvanceSearch_MapClasses
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
    public partial class VerifyAdvanceSearch_Map:logWriter
    {
        
        /// <summary>
        /// VerifyAdvanceSearch_Method
        /// </summary>
        public void VerifyAdvanceSearch_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIAdvancedVillaSearchHyperlink = this.UIHomePageWindowsInterWindow.UIHomePageDocument.UIDestTabsPane.UIAdvancedVillaSearchHyperlink;
            #endregion

            uIAdvancedVillaSearchHyperlink.WaitForControlReady(10000);
            // Click 'Advanced Villa Search' link
            Mouse.Click(uIAdvancedVillaSearchHyperlink, new Point(71, 2));
            String cmpradvance = this.UIHomePageWindowsInterWindow.Uri.ToString();

            try
            {
                StringAssert.Contains(cmpradvance, "advancesearch");
                WriteLogs("PASS : Advance Search Page.");
            }
            catch (Exception ex)
                {
                    WriteLogs("FAIL : Advance Search Page.");
                    WriteLogs("-------EXCEPTION-------" + ex.Message.ToString());
                }
            //if (cmpradvance.Contains("advancesearch"))
            //{
            //    WriteLogs("Advance Search Page : PASS");
            //}
            //else 
            //{
            //    WriteLogs("Advance Search Page : FAil");
            //}
            takeImage("AdvanceSearchPage");
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
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Home Page";
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
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "http://", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public UIDestTabsPane UIDestTabsPane
        {
            get
            {
                if ((this.mUIDestTabsPane == null))
                {
                    this.mUIDestTabsPane = new UIDestTabsPane(this);
                }
                return this.mUIDestTabsPane;
            }
        }
        #endregion
        
        #region Fields
        private UIDestTabsPane mUIDestTabsPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIDestTabsPane : HtmlDiv
    {
        
        public UIDestTabsPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "destTabs";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Where to? \r\n ", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Class, "QCdestTab ", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "id=destTabs ", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "27";
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIAdvancedVillaSearchPane
        {
            get
            {
                if ((this.mUIAdvancedVillaSearchPane == null))
                {
                    this.mUIAdvancedVillaSearchPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIAdvancedVillaSearchPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, " Advanced Villa Search ", PropertyExpressionOperator.Contains));
                    this.mUIAdvancedVillaSearchPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "10";
                    this.mUIAdvancedVillaSearchPane.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUIAdvancedVillaSearchPane;
            }
        }
        
        public HtmlHyperlink UIAdvancedVillaSearchHyperlink
        {
            get
            {
                if ((this.mUIAdvancedVillaSearchHyperlink == null))
                {
                    this.mUIAdvancedVillaSearchHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIAdvancedVillaSearchHyperlink.SearchProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.InnerText, "Advanced Villa Search", PropertyExpressionOperator.Contains));
                    this.mUIAdvancedVillaSearchHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
                    this.mUIAdvancedVillaSearchHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, "http://", PropertyExpressionOperator.Contains));
                    this.mUIAdvancedVillaSearchHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Class, "advSearchA", PropertyExpressionOperator.Contains));
                    this.mUIAdvancedVillaSearchHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.ControlDefinition, "class=advSearchA ", PropertyExpressionOperator.Contains));
                    this.mUIAdvancedVillaSearchHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUIAdvancedVillaSearchHyperlink.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUIAdvancedVillaSearchHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIAdvancedVillaSearchPane;
        
        private HtmlHyperlink mUIAdvancedVillaSearchHyperlink;
        #endregion
    }
}
