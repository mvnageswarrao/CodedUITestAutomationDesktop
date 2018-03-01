﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.VerifySearchResult_MapClasses
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
    public partial class VerifySearchResult_Map:logWriter
    {
        
        /// <summary>
        /// VerifySearch_Method
        /// </summary>
        public void VerifySearch_Method()
        {
            #region Variable Declarations
            HtmlInputButton uISearchButton = this.UIHomePageWindowsInterWindow.UIHomePageDocument.UISearchButton;
            #endregion

            // Click 'Search' button
            Mouse.Click(uISearchButton, new Point(21, 8));
            String cmprsearch = this.UIHomePageWindowsInterWindow.Uri.ToString();
            try
            {
                StringAssert.Contains(this.UIHomePageWindowsInterWindow.Uri.ToString(), "searchresult");
                WriteLogs("PASS : Search Result Page opened.");
            }
            catch(Exception ex)
            {
                takeImage("VerifySearchResult");
                WriteLogs("FAIL : Search Result Page not opened.");
                WriteLogs("-------EXCEPTION-------" + ex.Message.ToString());
            }
            //if (cmprsearch.Contains("searchresult"))
            //{
            //    WriteLogs("Search Result Page : PASS");
            //}
            //else 
            //{
            //    WriteLogs("Search Result Page : FAIL");
            //}
            takeImage("SearchResult");
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
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "http://", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public UIForm1Custom UIForm1Custom
        {
            get
            {
                if ((this.mUIForm1Custom == null))
                {
                    this.mUIForm1Custom = new UIForm1Custom(this);
                }
                return this.mUIForm1Custom;
            }
        }
        
        public HtmlInputButton UISearchButton
        {
            get
            {
                if ((this.mUISearchButton == null))
                {
                    this.mUISearchButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUISearchButton.SearchProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Id, "btnSearch", PropertyExpressionOperator.Contains));
                    this.mUISearchButton.SearchProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Name, "btnSearch", PropertyExpressionOperator.Contains));
                    this.mUISearchButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "Search";
                    this.mUISearchButton.FilterProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Type, "submit", PropertyExpressionOperator.Contains));
                    this.mUISearchButton.FilterProperties[HtmlButton.PropertyNames.Class] = "button";
                    this.mUISearchButton.FilterProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.ControlDefinition, "id=btnSearch", PropertyExpressionOperator.Contains));
                    this.mUISearchButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "9";
                    this.mUISearchButton.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUISearchButton;
            }
        }
        #endregion
        
        #region Fields
        private UIForm1Custom mUIForm1Custom;
        
        private HtmlInputButton mUISearchButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIForm1Custom : HtmlCustom
    {
        
        public UIForm1Custom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression("Id", "form1", PropertyExpressionOperator.Contains));
            this.SearchProperties["TagName"] = "FORM";
            this.FilterProperties.Add(new PropertyExpression("ControlDefinition", "id=form1 ", PropertyExpressionOperator.Contains));
            this.FilterProperties["TagInstance"] = "1";
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public UIItemTable UIItemTable
        {
            get
            {
                if ((this.mUIItemTable == null))
                {
                    this.mUIItemTable = new UIItemTable(this);
                }
                return this.mUIItemTable;
            }
        }
        #endregion
        
        #region Fields
        private UIItemTable mUIItemTable;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIItemTable : HtmlTable
    {
        
        public UIItemTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "  \r\n \r\n     Villa Plus on  ", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.ControlDefinition, "border=0 cellSpacing=0 cellPadding=0 wid", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "3";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "2";
            this.FilterProperties[HtmlTable.PropertyNames.TagInstance] = "3";
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIItemCell
        {
            get
            {
                if ((this.mUIItemCell == null))
                {
                    this.mUIItemCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIItemCell.SearchProperties[HtmlCell.PropertyNames.MaxDepth] = "3";
                    this.mUIItemCell.FilterProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "\\\\ ", PropertyExpressionOperator.Contains));
                    this.mUIItemCell.FilterProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.ControlDefinition, "colSpan=7", PropertyExpressionOperator.Contains));
                    this.mUIItemCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "1";
                    this.mUIItemCell.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "3";
                    this.mUIItemCell.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUIItemCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIItemCell;
        #endregion
    }
}