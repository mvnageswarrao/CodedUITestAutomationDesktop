﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.PayOnlinePage.clickContinueFrmCertiErrPage_MapClasses
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
    public partial class clickContinueFrmCertiErrPage_Map
    {
        
        /// <summary>
        /// clickContinueFrmCertiErrPage_Method
        /// </summary>
        public void clickContinueFrmCertiErrPage_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIContinuetothiswebsitHyperlink = this.UICertificateErrorNaviWindow.UICertificateErrorNaviDocument.UIContinuetothiswebsitHyperlink;
            #endregion

            string URLFrmPage = UICertificateErrorNaviWindow.Uri.ToString();
            int dotindex = URLFrmPage.IndexOf(".");
            URLFrmPage = URLFrmPage.Remove(0, dotindex);
            string strUTLtocompare = "/acs/";

            Boolean Is3DPageOpened = StringAssert.Equals(URLFrmPage, "/acs/");
            if (Is3DPageOpened == true)
            {
                // Click 'Continue to this website (not recommended).' link
                Mouse.Click(uIContinuetothiswebsitHyperlink, new Point(111, 8));
            }

            
        }
        
        #region Properties
        public UICertificateErrorNaviWindow UICertificateErrorNaviWindow
        {
            get
            {
                if ((this.mUICertificateErrorNaviWindow == null))
                {
                    this.mUICertificateErrorNaviWindow = new UICertificateErrorNaviWindow();
                }
                return this.mUICertificateErrorNaviWindow;
            }
        }
        #endregion
        
        #region Fields
        private UICertificateErrorNaviWindow mUICertificateErrorNaviWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICertificateErrorNaviWindow : BrowserWindow
    {
        
        public UICertificateErrorNaviWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Certificate Error: Navigation Blocked", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Certificate Error: Navigation Blocked");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UICertificateErrorNaviDocument UICertificateErrorNaviDocument
        {
            get
            {
                if ((this.mUICertificateErrorNaviDocument == null))
                {
                    this.mUICertificateErrorNaviDocument = new UICertificateErrorNaviDocument(this);
                }
                return this.mUICertificateErrorNaviDocument;
            }
        }
        #endregion
        
        #region Fields
        private UICertificateErrorNaviDocument mUICertificateErrorNaviDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICertificateErrorNaviDocument : HtmlDocument
    {
        
        public UICertificateErrorNaviDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Certificate Error: Navigation Blocked", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/invalidcert.htm", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "res://ieframe.dll/invalidcert.htm?SSLError=", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Certificate Error: Navigation Blocked");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIContinuetothiswebsitHyperlink
        {
            get
            {
                if ((this.mUIContinuetothiswebsitHyperlink == null))
                {
                    this.mUIContinuetothiswebsitHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIContinuetothiswebsitHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "overridelink";
                    this.mUIContinuetothiswebsitHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = "overridelink";
                    this.mUIContinuetothiswebsitHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.InnerText, "Continue", PropertyExpressionOperator.Contains));
                    this.mUIContinuetothiswebsitHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "/acs/pa/", PropertyExpressionOperator.Contains));
                    this.mUIContinuetothiswebsitHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, "/acs/pa/", PropertyExpressionOperator.Contains));
                    this.mUIContinuetothiswebsitHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.ControlDefinition, "id=overridelink href=\"https://acs.gpayme", PropertyExpressionOperator.Contains));
                    this.mUIContinuetothiswebsitHyperlink.WindowTitles.Add("Certificate Error: Navigation Blocked");
                    #endregion
                }
                return this.mUIContinuetothiswebsitHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIContinuetothiswebsitHyperlink;
        #endregion
    }
}
