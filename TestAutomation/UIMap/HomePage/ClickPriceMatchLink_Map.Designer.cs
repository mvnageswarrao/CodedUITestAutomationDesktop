﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.ClickPriceMatchLink_MapClasses
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
    public partial class ClickPriceMatchLink_Map:logWriter
    {
        
        /// <summary>
        /// ClickPriceMatchLink_Method
        /// </summary>
        //public void ClickPriceMatchLink_Method()
        //{
        //    #region Variable Declarations
        //    HtmlImage uIPriceMatchImage = this.UIHomePageWindowsInterWindow.UIHomePageDocument.UIPriceMatchImage;
        //    #endregion

        //    // Click 'Price Match' image
        //    Mouse.Click(uIPriceMatchImage, new Point(157, 45));
        //}

        public void ClickPriceMatchLinkModified_Method()
        {
            #region Variable Declarations
            HtmlImage uIPriceMatchImage = this.UIHomePageWindowsInterWindow.UIHomePageDocument.UIPriceMatchImage;
            #endregion

            // Click 'Price Match' image
            Mouse.Click(uIPriceMatchImage, new Point(157, 45));
            string comaprURL = this.UIHomePageWindowsInterWindow.Uri.ToString();

            try
            {
                StringAssert.Contains(comaprURL, "pricematch");
                WriteLogs("PASS : Price Match Link clicked.");
            }
            catch (Exception ex)
            {
                WriteLogs("FAIL : Price Match Link not clicked.");
                WriteLogs("-------EXCEPTION-------" + ex.Message.ToString());
            }
            //if ( comaprURL.Contains("pricematch"))
            //{
            //    WriteLogs("Price Match Link : PASS");
            //}
            //else
            //{
            //    WriteLogs("Price Match Link : FAIL");
            //}
            takeImage("PriceMatchLink");
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
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "http://", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public HtmlImage UIPriceMatchImage
        {
            get
            {
                if ((this.mUIPriceMatchImage == null))
                {
                    this.mUIPriceMatchImage = new HtmlImage(this);
                    #region Search Criteria
                    this.mUIPriceMatchImage.SearchProperties[HtmlImage.PropertyNames.Id] = "imgPriceMatch";
                    this.mUIPriceMatchImage.SearchProperties[HtmlImage.PropertyNames.Name] = null;
                    this.mUIPriceMatchImage.SearchProperties[HtmlImage.PropertyNames.Alt] = "Price Match";
                    this.mUIPriceMatchImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
                    this.mUIPriceMatchImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Src, "http://", PropertyExpressionOperator.Contains));
                    this.mUIPriceMatchImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.LinkAbsolutePath, "/", PropertyExpressionOperator.Contains));
                    this.mUIPriceMatchImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Href, "http://", PropertyExpressionOperator.Contains));
                    this.mUIPriceMatchImage.FilterProperties[HtmlImage.PropertyNames.Class] = "Padding-Top10 Border0";
                    this.mUIPriceMatchImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.ControlDefinition, "id=imgPriceMatch", PropertyExpressionOperator.Contains));
                    this.mUIPriceMatchImage.FilterProperties[HtmlImage.PropertyNames.TagInstance] = "20";
                    this.mUIPriceMatchImage.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUIPriceMatchImage;
            }
        }
        #endregion
        
        #region Fields
        private HtmlImage mUIPriceMatchImage;
        #endregion
    }
}
