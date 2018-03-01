﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.PayOnlinePage.enterSecurityCode_MapClasses
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
    public partial class enterSecurityCode_Map:logWriter
    {
        
        /// <summary>
        /// enterSecurityCode_Method - Use 'enterSecurityCode_MethodParams' to pass parameters into this method.
        /// </summary>
        public void enterSecurityCode_Method(string SecurityCode)
        {
            #region Variable Declarations
            HtmlEdit uITxtSecurityCodeEdit = this.UIPayOnlineWindowsInteWindow.UIPayOnlineDocument.UITxtSecurityCodeEdit;
            #endregion

            // Type '********' in 'txtSecurityCode' text box
            //uITxtSecurityCodeEdit.Password = this.enterSecurityCode_MethodParams.UITxtSecurityCodeEditPassword;
            //uITxtSecurityCodeEdit.Password = SecurityCode;
            uITxtSecurityCodeEdit.Text = SecurityCode;
            WriteLogs("PASS : Entered Security Password.");
        }
        
        #region Properties
        public virtual enterSecurityCode_MethodParams enterSecurityCode_MethodParams
        {
            get
            {
                if ((this.menterSecurityCode_MethodParams == null))
                {
                    this.menterSecurityCode_MethodParams = new enterSecurityCode_MethodParams();
                }
                return this.menterSecurityCode_MethodParams;
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
        private enterSecurityCode_MethodParams menterSecurityCode_MethodParams;
        
        private UIPayOnlineWindowsInteWindow mUIPayOnlineWindowsInteWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'enterSecurityCode_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class enterSecurityCode_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Type '********' in 'txtSecurityCode' text box
        /// </summary>
        public string UITxtSecurityCodeEditPassword = "dkca0o/qMuwpCkIsCPzGyA==";
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
        public HtmlEdit UITxtSecurityCodeEdit
        {
            get
            {
                if ((this.mUITxtSecurityCodeEdit == null))
                {
                    this.mUITxtSecurityCodeEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUITxtSecurityCodeEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "ctl00_Placeholder1_txtSecurityCode";
                    this.mUITxtSecurityCodeEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "ctl00$Placeholder1$txtSecurityCode";
                    this.mUITxtSecurityCodeEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "PASSWORD";
                    this.mUITxtSecurityCodeEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "td_small";
                    this.mUITxtSecurityCodeEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"ctl00$Placeholder1$txtSecurityCode";
                    this.mUITxtSecurityCodeEdit.WindowTitles.Add("Pay Online");
                    #endregion
                }
                return this.mUITxtSecurityCodeEdit;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUITxtSecurityCodeEdit;
        #endregion
    }
}
