﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.PayOnlinePage.selectExpiryMonth_MapClasses
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
    public partial class selectExpiryMonth_Map:logWriter
    {
        
        /// <summary>
        /// selectExpiryMonth_Method - Use 'selectExpiryMonth_MethodParams' to pass parameters into this method.
        /// </summary>
        public void selectExpiryMonth_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDrpExpiryMonthComboBox = this.UIPayOnlineWindowsInteWindow.UIPayOnlineDocument.UIDrpExpiryMonthComboBox;
            #endregion

            // Select '6' in 'drpExpiryMonth' combo box
            uIDrpExpiryMonthComboBox.SelectedItem = this.selectExpiryMonth_MethodParams.UIDrpExpiryMonthComboBoxSelectedItem;
            WriteLogs("PASS : Selected Expiry Month");
        }

        public HtmlComboBox gettExpiryMonth_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDrpExpiryMonthComboBox = this.UIPayOnlineWindowsInteWindow.UIPayOnlineDocument.UIDrpExpiryMonthComboBox;
            #endregion

            return uIDrpExpiryMonthComboBox;
        }
        
        #region Properties
        public virtual selectExpiryMonth_MethodParams selectExpiryMonth_MethodParams
        {
            get
            {
                if ((this.mselectExpiryMonth_MethodParams == null))
                {
                    this.mselectExpiryMonth_MethodParams = new selectExpiryMonth_MethodParams();
                }
                return this.mselectExpiryMonth_MethodParams;
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
        private selectExpiryMonth_MethodParams mselectExpiryMonth_MethodParams;
        
        private UIPayOnlineWindowsInteWindow mUIPayOnlineWindowsInteWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'selectExpiryMonth_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class selectExpiryMonth_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Select '6' in 'drpExpiryMonth' combo box
        /// </summary>
        public string UIDrpExpiryMonthComboBoxSelectedItem = "6";
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
        public HtmlComboBox UIDrpExpiryMonthComboBox
        {
            get
            {
                if ((this.mUIDrpExpiryMonthComboBox == null))
                {
                    this.mUIDrpExpiryMonthComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDrpExpiryMonthComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "ctl00_Placeholder1_drpExpiryMonth";
                    this.mUIDrpExpiryMonthComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "ctl00$Placeholder1$drpExpiryMonth";
                    this.mUIDrpExpiryMonthComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = "textBox";
                    this.mUIDrpExpiryMonthComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"ctl00$Placeholder1$drpExpiryMonth\"";
                    this.mUIDrpExpiryMonthComboBox.WindowTitles.Add("Pay Online");
                    #endregion
                }
                return this.mUIDrpExpiryMonthComboBox;
            }
        }
        #endregion
        
        #region Fields
        private HtmlComboBox mUIDrpExpiryMonthComboBox;
        #endregion
    }
}
