﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.PayOnlinePage.verifyPayOnlinePagedisplay_MapClasses
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
    public partial class verifyPayOnlinePagedisplay_Map:logWriter
    {
        
        /// <summary>
        /// verifyPayOnlinePagedisplay_Method - Use 'verifyPayOnlinePagedisplay_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyPayOnlinePagedisplay_Method(string strURL)
        {
            delayExecution(strURL);
            #region Variable Declarations
            HtmlSpan uIAmounttobePaidPane = this.UIPayOnlineWindowsInteWindow.UIPayOnlineDocument.UIAmounttobePaidPane;
            #endregion

            // Verify that the 'InnerText' property of 'Amount to be Paid' pane contains 'Amount to be Paid  '
            //StringAssert.Contains(uIAmounttobePaidPane.InnerText, this.verifyPayOnlinePagedisplay_MethodExpectedValues.UIAmounttobePaidPaneInnerText);
            string ExpTxt = "Amount to be Paid";
            string ActTxt = uIAmounttobePaidPane.InnerText.Trim();
            try
            {
                Assert.AreEqual(ExpTxt, ActTxt);
                WriteLogs("PASS : Pay Online Page Opened Successfully. : VERIFICATION");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyPayOnlinePagedisplay");
                WriteLogs("FAIL : Pay Online page is not Opened. : VERIFICATION");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyPayOnlinePagedisplay_MethodExpectedValues verifyPayOnlinePagedisplay_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyPayOnlinePagedisplay_MethodExpectedValues == null))
                {
                    this.mverifyPayOnlinePagedisplay_MethodExpectedValues = new verifyPayOnlinePagedisplay_MethodExpectedValues();
                }
                return this.mverifyPayOnlinePagedisplay_MethodExpectedValues;
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
        private verifyPayOnlinePagedisplay_MethodExpectedValues mverifyPayOnlinePagedisplay_MethodExpectedValues;
        
        private UIPayOnlineWindowsInteWindow mUIPayOnlineWindowsInteWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyPayOnlinePagedisplay_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyPayOnlinePagedisplay_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Amount to be Paid' pane contains 'Amount to be Paid  '
        /// </summary>
        public string UIAmounttobePaidPaneInnerText = "Amount to be Paid  ";
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
        public HtmlSpan UIAmounttobePaidPane
        {
            get
            {
                if ((this.mUIAmounttobePaidPane == null))
                {
                    this.mUIAmounttobePaidPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIAmounttobePaidPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "ctl00_Placeholder1_lblAmountText";
                    this.mUIAmounttobePaidPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Amount to be Paid  ", PropertyExpressionOperator.Contains));
                    this.mUIAmounttobePaidPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"ctl00_Placeholder1_lblAmountText\" style=\"height: 12px; font-weight: bold; ver" +
                        "tical-align: middle; display: inline-block;\"";
                    this.mUIAmounttobePaidPane.WindowTitles.Add("Pay Online");
                    #endregion
                }
                return this.mUIAmounttobePaidPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlSpan mUIAmounttobePaidPane;
        #endregion
    }
}
