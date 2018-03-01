﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.PayOnlinePage.selectStartYear_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class selectStartYear_Map:logWriter
    {
        
        /// <summary>
        /// selectStartYear_Method - Use 'selectStartYear_MethodParams' to pass parameters into this method.
        /// </summary>
        public void selectStartYear_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDrpStartYearComboBox = this.UIPayOnlineWindowsInteWindow.UIPayOnlineDocument.UIDrpStartYearComboBox;
            #endregion

            // Select '2012' in 'drpStartYear' combo box
            uIDrpStartYearComboBox.SelectedItem = this.selectStartYear_MethodParams.UIDrpStartYearComboBoxSelectedItem;
            WriteLogs("PASS : Selected Start Year.");
        }
        
        #region Properties
        public virtual selectStartYear_MethodParams selectStartYear_MethodParams
        {
            get
            {
                if ((this.mselectStartYear_MethodParams == null))
                {
                    this.mselectStartYear_MethodParams = new selectStartYear_MethodParams();
                }
                return this.mselectStartYear_MethodParams;
            }
        }
        
        public UIPayOnlineWindowsInteWindow UIPayOnlineWindowsInteWindow
        {
            get
            {
                if ((this.mUIPayOnlineWindowsInteWindow == null))
                {
                    this.mUIPayOnlineWindowsInteWindow = new UIPayOnlineWindowsInteWindow();
                }
                return this.mUIPayOnlineWindowsInteWindow;
            }
        }
        #endregion
        
        #region Fields
        private selectStartYear_MethodParams mselectStartYear_MethodParams;
        
        private UIPayOnlineWindowsInteWindow mUIPayOnlineWindowsInteWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'selectStartYear_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class selectStartYear_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Select '2012' in 'drpStartYear' combo box
        /// </summary>
        public string UIDrpStartYearComboBoxSelectedItem = "2012";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPayOnlineWindowsInteWindow : BrowserWindow
    {
        
        public UIPayOnlineWindowsInteWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Pay Online", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Pay Online");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIPayOnlineDocument UIPayOnlineDocument
        {
            get
            {
                if ((this.mUIPayOnlineDocument == null))
                {
                    this.mUIPayOnlineDocument = new UIPayOnlineDocument(this);
                }
                return this.mUIPayOnlineDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIPayOnlineDocument mUIPayOnlineDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPayOnlineDocument : HtmlDocument
    {
        
        public UIPayOnlineDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Pay Online", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/payonline.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/payonline.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Pay Online");
            #endregion
        }
        
        #region Properties
        public HtmlComboBox UIDrpStartYearComboBox
        {
            get
            {
                if ((this.mUIDrpStartYearComboBox == null))
                {
                    this.mUIDrpStartYearComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDrpStartYearComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "ctl00_Placeholder1_drpStartYear";
                    this.mUIDrpStartYearComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "ctl00$Placeholder1$drpStartYear";
                    this.mUIDrpStartYearComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = "textBox";
                    this.mUIDrpStartYearComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"ctl00$Placeholder1$drpStartYear\" c";
                    this.mUIDrpStartYearComboBox.WindowTitles.Add("Pay Online");
                    #endregion
                }
                return this.mUIDrpStartYearComboBox;
            }
        }
        #endregion
        
        #region Fields
        private HtmlComboBox mUIDrpStartYearComboBox;
        #endregion
    }
}
