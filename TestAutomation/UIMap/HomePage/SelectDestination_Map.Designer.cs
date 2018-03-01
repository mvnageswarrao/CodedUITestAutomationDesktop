﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.SelectDestination_MapClasses
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
    public partial class SelectDestination_Map
    {
        
        /// <summary>
        /// SelectDestination_Method - Use 'SelectDestination_MethodParams' to pass parameters into this method.
        /// </summary>
        public void SelectDestination_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDdDestinationsComboBox = this.UIHomePageWindowsInterWindow.UIHomePageDocument.UIDdDestinationsComboBox;
            #endregion

            uIDdDestinationsComboBox.WaitForControlReady(15000);
            // Select 'Corfu' in 'ddDestinations' combo box
            uIDdDestinationsComboBox.SelectedItem = this.SelectDestination_MethodParams.UIDdDestinationsComboBoxSelectedItem;
        }
        
        #region Properties
        public virtual SelectDestination_MethodParams SelectDestination_MethodParams
        {
            get
            {
                if ((this.mSelectDestination_MethodParams == null))
                {
                    this.mSelectDestination_MethodParams = new SelectDestination_MethodParams();
                }
                return this.mSelectDestination_MethodParams;
            }
        }
        
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
        private SelectDestination_MethodParams mSelectDestination_MethodParams;
        
        private UIHomePageWindowsInterWindow mUIHomePageWindowsInterWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'SelectDestination_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class SelectDestination_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'Corfu' in 'ddDestinations' combo box
        /// </summary>
        public string UIDdDestinationsComboBoxSelectedItem = "Corfu";
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
        
        public HtmlComboBox UIDdDestinationsComboBox
        {
            get
            {
                if ((this.mUIDdDestinationsComboBox == null))
                {
                    this.mUIDdDestinationsComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdDestinationsComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "ddDestinations";
                    this.mUIDdDestinationsComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "ctl00$MainContent$quickSearch$ddDestinations";
                    this.mUIDdDestinationsComboBox.FilterProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.ItemCount, "19", PropertyExpressionOperator.Contains));
                    this.mUIDdDestinationsComboBox.FilterProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.ControlDefinition, " id=ddDestinations ", PropertyExpressionOperator.Contains));
                    this.mUIDdDestinationsComboBox.FilterProperties[HtmlComboBox.PropertyNames.TagInstance] = "1";
                    this.mUIDdDestinationsComboBox.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUIDdDestinationsComboBox;
            }
        }
        #endregion
        
        #region Fields
        private UIDestTabsPane mUIDestTabsPane;
        
        private HtmlComboBox mUIDdDestinationsComboBox;
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
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Where to? \r\n ", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Class, "QCdestTab ui-tabs-panel ui-widget-content ui-corner-bottom", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "id=destTabs ", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "27";
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public HtmlControl UIWhenPane
        {
            get
            {
                if ((this.mUIWhenPane == null))
                {
                    this.mUIWhenPane = new HtmlControl(this);
                    #region Search Criteria
                    this.mUIWhenPane.SearchProperties[HtmlDiv.PropertyNames.ControlType] = "Pane";
                    this.mUIWhenPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "";
                    this.mUIWhenPane.SearchProperties[HtmlDiv.PropertyNames.Name] = "";
                    this.mUIWhenPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "When?";
                    this.mUIWhenPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Class, "bold black", PropertyExpressionOperator.Contains));
                    this.mUIWhenPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"bold black\"", PropertyExpressionOperator.Contains));
                    this.mUIWhenPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "2";
                    this.mUIWhenPane.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUIWhenPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlControl mUIWhenPane;
        #endregion
    }
}
