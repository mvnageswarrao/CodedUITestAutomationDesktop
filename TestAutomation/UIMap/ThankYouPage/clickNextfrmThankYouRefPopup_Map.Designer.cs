﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ThankYouPage.clickNextfrmThankYouRefPopup_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class clickNextfrmThankYouRefPopup_Map
    {
        
        /// <summary>
        /// clickNextfrmThankYouRefPopup_Method
        /// </summary>
        public void clickNextfrmThankYouRefPopup_Method()
        {
            #region Variable Declarations
            HtmlInputButton uICtl00ContentPlaceHolButton = this.UIThankYouWindowsInterWindow.UIThankYouDocument.UIIfrmReferralSourceFrame.UISelectReferralSourceDocument.UICtl00ContentPlaceHolButton;
            #endregion

            // Click 'ctl00$ContentPlaceHolder1$btnNextEnable' button
            Mouse.Click(uICtl00ContentPlaceHolButton, new Point(33, 10));
        }
        
        #region Properties
        public UIThankYouWindowsInterWindow UIThankYouWindowsInterWindow
        {
            get
            {
                if ((this.mUIThankYouWindowsInterWindow == null))
                {
                    this.mUIThankYouWindowsInterWindow = new UIThankYouWindowsInterWindow();
                }
                return this.mUIThankYouWindowsInterWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIThankYouWindowsInterWindow mUIThankYouWindowsInterWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIThankYouWindowsInterWindow : BrowserWindow
    {
        
        public UIThankYouWindowsInterWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Thank You", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Thank You");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIThankYouDocument UIThankYouDocument
        {
            get
            {
                if ((this.mUIThankYouDocument == null))
                {
                    this.mUIThankYouDocument = new UIThankYouDocument(this);
                }
                return this.mUIThankYouDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIThankYouDocument mUIThankYouDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIThankYouDocument : HtmlDocument
    {
        
        public UIThankYouDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Thank You", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/bookingstatus.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/bookingstatus.aspx?thankyou", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Thank You");
            #endregion
        }
        
        #region Properties
        public UIIfrmReferralSourceFrame UIIfrmReferralSourceFrame
        {
            get
            {
                if ((this.mUIIfrmReferralSourceFrame == null))
                {
                    this.mUIIfrmReferralSourceFrame = new UIIfrmReferralSourceFrame(this);
                }
                return this.mUIIfrmReferralSourceFrame;
            }
        }
        #endregion
        
        #region Fields
        private UIIfrmReferralSourceFrame mUIIfrmReferralSourceFrame;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIIfrmReferralSourceFrame : HtmlIFrame
    {
        
        public UIIfrmReferralSourceFrame(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "ifrmReferralSource";
            this.SearchProperties[HtmlFrame.PropertyNames.Name] = "ifrmReferralSource";
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.AbsolutePath, "referralSource.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.PageUrl, "referralSource.aspx?bookingid=", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.ControlDefinition, "name=\"ifrmReferralSource\"", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Thank You");
            #endregion
        }
        
        #region Properties
        public UISelectReferralSourceDocument UISelectReferralSourceDocument
        {
            get
            {
                if ((this.mUISelectReferralSourceDocument == null))
                {
                    this.mUISelectReferralSourceDocument = new UISelectReferralSourceDocument(this);
                }
                return this.mUISelectReferralSourceDocument;
            }
        }
        #endregion
        
        #region Fields
        private UISelectReferralSourceDocument mUISelectReferralSourceDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UISelectReferralSourceDocument : HtmlDocument
    {
        
        public UISelectReferralSourceDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Select Referral Source", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/referralSource.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/referralSource.aspx?bookingid=", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Thank You");
            #endregion
        }
        
        #region Properties
        public HtmlInputButton UICtl00ContentPlaceHolButton
        {
            get
            {
                if ((this.mUICtl00ContentPlaceHolButton == null))
                {
                    this.mUICtl00ContentPlaceHolButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUICtl00ContentPlaceHolButton.SearchProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Id, "btnNextEnable", PropertyExpressionOperator.Contains));
                    this.mUICtl00ContentPlaceHolButton.SearchProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Name, "$btnNextEnable", PropertyExpressionOperator.Contains));
                    this.mUICtl00ContentPlaceHolButton.FilterProperties[HtmlButton.PropertyNames.Type] = "image";
                    this.mUICtl00ContentPlaceHolButton.FilterProperties.Add(new PropertyExpression("Src", "/imgs/vp/buttons/nextON.gif", PropertyExpressionOperator.Contains));
                    this.mUICtl00ContentPlaceHolButton.FilterProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.ControlDefinition, "$btnNextE", PropertyExpressionOperator.Contains));
                    this.mUICtl00ContentPlaceHolButton.WindowTitles.Add("Thank You");
                    #endregion
                }
                return this.mUICtl00ContentPlaceHolButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlInputButton mUICtl00ContentPlaceHolButton;
        #endregion
    }
}
