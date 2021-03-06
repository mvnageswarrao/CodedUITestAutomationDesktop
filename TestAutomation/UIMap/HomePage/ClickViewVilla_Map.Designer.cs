﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.ClickViewVilla_MapClasses
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
    public partial class ClickViewVilla_Map:logWriter
    {
        
        /// <summary>
        /// ClickViewVilla_Method
        /// </summary>
        public void ClickViewVilla_Method()
        {
            #region Variable Declarations
            HtmlInputButton uIViewVillaButton = this.UIHomePageWindowsInterWindow.UIHomePageDocument.UIViewVillaButton;
            #endregion
      
        
                // Click 'View Villa' button
                Mouse.Click(uIViewVillaButton, new Point(43, 15));
                String cmprview = this.UIHomePageWindowsInterWindow.Uri.ToString();
                try
                {
                    StringAssert.Contains(cmprview, "villaid");
                    WriteLogs("PASS : Verify Villa Individual Page - clicked View Villa button.");
                }
                catch (Exception ex)
                {
                    WriteLogs("FAIL : Verify Villa Individual Page- View Villa button not clicked.");
                    WriteLogs("-------EXCEPTION-------" + ex.Message.ToString());
                }
                //if (cmprview.Contains("villaid"))
                //{
                //    WriteLogs("Verify Villa Individual Page : PASS");
                //}
                //else
                //{
                //    WriteLogs("Verify Villa Individual Page : FAIL");
                //}

                takeImage("VillaSearch");
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
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Home Page";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
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
        
        public HtmlInputButton UIViewVillaButton
        {
            get
            {
                if ((this.mUIViewVillaButton == null))
                {
                    this.mUIViewVillaButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUIViewVillaButton.SearchProperties[HtmlButton.PropertyNames.Id] = "btnViewVilla";
                    this.mUIViewVillaButton.SearchProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Name, "btnViewVilla", PropertyExpressionOperator.Contains));
                    this.mUIViewVillaButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "View Villa";
                    this.mUIViewVillaButton.FilterProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIViewVillaButton.FilterProperties[HtmlButton.PropertyNames.Title] = "";
                    this.mUIViewVillaButton.FilterProperties[HtmlButton.PropertyNames.Class] = "button";
                    this.mUIViewVillaButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "11";
                    this.mUIViewVillaButton.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUIViewVillaButton;
            }
        }
        #endregion
        
        #region Fields
        private UIForm1Custom mUIForm1Custom;
        
        private HtmlInputButton mUIViewVillaButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIForm1Custom : HtmlCustom
    {
        
        public UIForm1Custom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["Id"] = "form1";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.SearchProperties["TagName"] = "FORM";
            this.FilterProperties["Class"] = "";
            this.FilterProperties.Add(new PropertyExpression("ControlDefinition", "id=form", PropertyExpressionOperator.Contains));
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
            this.SearchProperties[HtmlTable.PropertyNames.Id] = null;
            this.SearchProperties[HtmlTable.PropertyNames.Name] = null;
            this.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "  \r\n \r\n     Villa Plus on  ", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "3";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "2";
            this.FilterProperties[HtmlTable.PropertyNames.Class] = "";
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
                    this.mUIItemCell.SearchProperties[HtmlCell.PropertyNames.Name] = "";
                    this.mUIItemCell.SearchProperties[HtmlCell.PropertyNames.MaxDepth] = "3";
                    this.mUIItemCell.FilterProperties[HtmlCell.PropertyNames.InnerText] = "\\ ";
                    this.mUIItemCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "0";
                    this.mUIItemCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "0";
                    this.mUIItemCell.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "1";
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
