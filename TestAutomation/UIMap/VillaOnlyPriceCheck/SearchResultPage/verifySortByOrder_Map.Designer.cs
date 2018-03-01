﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchResultPage.verifySortByOrder_MapClasses
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
    using TestAutomation.UIMap.SearchResultPage.getvillablockDetails_MapClasses;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class verifySortByOrder_Map:logWriter
    {
        
        /// <summary>
        /// verifySortByOrder_Method - Use 'verifySortByOrder_MethodParams' to pass parameters into this method.
        /// </summary>
        public void verifySortByOrder_Method()
        {
            #region Variable Declarations
            HtmlComboBox uISortByComboBox = this.UIYoursearchfound9VillWindow.UIYoursearchfound9VillDocument.UISortByComboBox;
            #endregion

            int count = uISortByComboBox.ItemCount;
            string sortOrderName = string.Empty;
            getvillablockDetails_Map blockdetails = new getvillablockDetails_Map();       
            try
            {
                for(int i=1;i<count;i++)
                {
                    uISortByComboBox.SelectedIndex = i;
                    sortOrderName = uISortByComboBox.SelectedItem;
                    blockdetails.getvillablockDetails_Method();
                    WriteLogs("PASS : Selected " + sortOrderName +".");
                }
                uISortByComboBox.SelectedIndex = 0;
                WriteLogs("PASS : Selected " + sortOrderName + ".");
            }
            catch (AssertFailedException ex)
            {
                WriteLogs("FAIL : Could Not Select " + sortOrderName + ".");
                WriteLogs("----------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifySortByOrder_MethodParams verifySortByOrder_MethodParams
        {
            get
            {
                if ((this.mverifySortByOrder_MethodParams == null))
                {
                    this.mverifySortByOrder_MethodParams = new verifySortByOrder_MethodParams();
                }
                return this.mverifySortByOrder_MethodParams;
            }
        }
        
        public UIYoursearchfound9VillWindow UIYoursearchfound9VillWindow
        {
            get
            {
                if ((this.mUIYoursearchfound9VillWindow == null))
                {
                    this.mUIYoursearchfound9VillWindow = new UIYoursearchfound9VillWindow();
                }
                return this.mUIYoursearchfound9VillWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifySortByOrder_MethodParams mverifySortByOrder_MethodParams;
        
        private UIYoursearchfound9VillWindow mUIYoursearchfound9VillWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifySortByOrder_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class verifySortByOrder_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'Price low to high' in 'SortBy' combo box
        /// </summary>
        public string UISortByComboBoxSelectedItem = "Price low to high";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIYoursearchfound9VillWindow : BrowserWindow
    {
        
        public UIYoursearchfound9VillWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your search found", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your search found 9 Villa holidays");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYoursearchfound9VillDocument UIYoursearchfound9VillDocument
        {
            get
            {
                if ((this.mUIYoursearchfound9VillDocument == null))
                {
                    this.mUIYoursearchfound9VillDocument = new UIYoursearchfound9VillDocument(this);
                }
                return this.mUIYoursearchfound9VillDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound9VillDocument mUIYoursearchfound9VillDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIYoursearchfound9VillDocument : HtmlDocument
    {
        
        public UIYoursearchfound9VillDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your search found", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/searchresult.aspx";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/searchresult.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your search found 9 Villa holidays");
            #endregion
        }
        
        #region Properties
        public HtmlComboBox UISortByComboBox
        {
            get
            {
                if ((this.mUISortByComboBox == null))
                {
                    this.mUISortByComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUISortByComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "MainContent_SortBy";
                    this.mUISortByComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "ctl00$MainContent$SortBy";
                    this.mUISortByComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = "dropdown width200px";
                    this.mUISortByComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"ctl00$MainContent$SortBy\" class=\"d";
                    this.mUISortByComboBox.WindowTitles.Add("Your search found 9 Villa holidays");
                    #endregion
                }
                return this.mUISortByComboBox;
            }
        }
        #endregion
        
        #region Fields
        private HtmlComboBox mUISortByComboBox;
        #endregion
    }
}
