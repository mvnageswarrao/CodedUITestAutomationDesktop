﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.PayOnlinePage.clickAdviceBtn_MapClasses
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
    public partial class clickAdviceBtn_Map:logWriter
    {
        
        /// <summary>
        /// clickAdviceBtn_Method
        /// </summary>
        public void clickAdviceBtn_Method()
        {
            #region Variable Declarations
            HtmlImage uIAdviceImage = this.UIPayOnlineWindowsInteWindow.UIPayOnlineDocument.UIAdviceImage;
            #endregion

            try
            {
               // Click 'Advice' image
                Mouse.Click(uIAdviceImage, new Point(36, 12));
                WriteLogs("PASS : Advice Button is clicked.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("clickAdviceBtn");
                WriteLogs("FAIL : Could not click Advice Button.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
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
        private UIPayOnlineWindowsInteWindow mUIPayOnlineWindowsInteWindow;
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
        public HtmlImage UIAdviceImage
        {
            get
            {
                if ((this.mUIAdviceImage == null))
                {
                    this.mUIAdviceImage = new HtmlImage(this);
                    #region Search Criteria
                    this.mUIAdviceImage.SearchProperties[HtmlImage.PropertyNames.Id] = "btnPayByPhone";
                    this.mUIAdviceImage.SearchProperties[HtmlImage.PropertyNames.Alt] = "Advice";
                    this.mUIAdviceImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.AbsolutePath, "/imgs/vp/buttons/adviceON.gif", PropertyExpressionOperator.Contains));
                    this.mUIAdviceImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Src, "/imgs/vp/buttons/adviceON.gif", PropertyExpressionOperator.Contains));
                    this.mUIAdviceImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.ControlDefinition, "id=\"btnPayByPhone\" style=\"visibility:", PropertyExpressionOperator.Contains));
                    this.mUIAdviceImage.WindowTitles.Add("Pay Online");
                    #endregion
                }
                return this.mUIAdviceImage;
            }
        }
        #endregion
        
        #region Fields
        private HtmlImage mUIAdviceImage;
        #endregion
    }
}
