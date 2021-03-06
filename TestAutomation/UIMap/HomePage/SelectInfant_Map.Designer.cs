﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.SelectInfant_MapClasses
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
    public partial class SelectInfant_Map
    {
        
        /// <summary>
        /// SelectInfant_Method - Use 'SelectInfant_MethodParams' to pass parameters into this method.
        /// </summary>
        public void SelectInfant_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDdInfantsComboBox = this.UIHomePageWindowsInterWindow.UIHomePageDocument.UIDdInfantsComboBox;
            #endregion

            // Select '1' in 'ddInfants' combo box
            uIDdInfantsComboBox.SelectedItem = this.SelectInfant_MethodParams.UIDdInfantsComboBoxSelectedItem;
        }
        
        #region Properties
        public virtual SelectInfant_MethodParams SelectInfant_MethodParams
        {
            get
            {
                if ((this.mSelectInfant_MethodParams == null))
                {
                    this.mSelectInfant_MethodParams = new SelectInfant_MethodParams();
                }
                return this.mSelectInfant_MethodParams;
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
        private SelectInfant_MethodParams mSelectInfant_MethodParams;
        
        private UIHomePageWindowsInterWindow mUIHomePageWindowsInterWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'SelectInfant_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class SelectInfant_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Select '1' in 'ddInfants' combo box
        /// </summary>
        public string UIDdInfantsComboBoxSelectedItem = "1";
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
        public HtmlComboBox UIDdInfantsComboBox
        {
            get
            {
                if ((this.mUIDdInfantsComboBox == null))
                {
                    this.mUIDdInfantsComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdInfantsComboBox.SearchProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.Id, "ddInfants", PropertyExpressionOperator.Contains));
                    this.mUIDdInfantsComboBox.SearchProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.Name, "ddInfants", PropertyExpressionOperator.Contains));
                    this.mUIDdInfantsComboBox.FilterProperties[HtmlComboBox.PropertyNames.ItemCount] = "17";
                    this.mUIDdInfantsComboBox.FilterProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.ControlDefinition, "id=ddInfants", PropertyExpressionOperator.Contains));
                    this.mUIDdInfantsComboBox.FilterProperties[HtmlComboBox.PropertyNames.TagInstance] = "6";
                    this.mUIDdInfantsComboBox.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUIDdInfantsComboBox;
            }
        }
        #endregion
        
        #region Fields
        private HtmlComboBox mUIDdInfantsComboBox;
        #endregion
    }
}
