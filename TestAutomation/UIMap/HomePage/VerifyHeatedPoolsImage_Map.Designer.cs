﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.HomePage.VerifyHeatedPoolsImage_MapClasses
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
    public partial class VerifyHeatedPoolsImage_Map:logWriter
    {
        
        /// <summary>
        /// VerifyHeatedPoolsImage_Method - Use 'VerifyHeatedPoolsImage_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyHeatedPoolsImage_Method()
        {
            #region Variable Declarations
            HtmlImage uIFreeheatedpoolsvillaImage = this.UIHomePageWindowsInterWindow.UIHomePageDocument.UIDvFreeheatedpoolPane.UIFreeheatedpoolsvillaImage;
            #endregion

            // Verify that the 'Title' property of 'Free heated pools villas' image equals 'Free heated pools villas'
            try
            {
                Assert.AreEqual(this.VerifyHeatedPoolsImage_MethodExpectedValues.UIFreeheatedpoolsvillaImageTitle, uIFreeheatedpoolsvillaImage.Title);
                WriteLogs("PASS : Heated Pool Image.");
            }
            catch (AssertFailedException ex)
            {
                WriteLogs("FAIL : Heated Pool Image.");
                WriteLogs("------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual VerifyHeatedPoolsImage_MethodExpectedValues VerifyHeatedPoolsImage_MethodExpectedValues
        {
            get
            {
                if ((this.mVerifyHeatedPoolsImage_MethodExpectedValues == null))
                {
                    this.mVerifyHeatedPoolsImage_MethodExpectedValues = new VerifyHeatedPoolsImage_MethodExpectedValues();
                }
                return this.mVerifyHeatedPoolsImage_MethodExpectedValues;
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
        private VerifyHeatedPoolsImage_MethodExpectedValues mVerifyHeatedPoolsImage_MethodExpectedValues;
        
        private UIHomePageWindowsInterWindow mUIHomePageWindowsInterWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'VerifyHeatedPoolsImage_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class VerifyHeatedPoolsImage_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Title' property of 'Free heated pools villas' image equals 'Free heated pools villas'
        /// </summary>
        public string UIFreeheatedpoolsvillaImageTitle = "Free heated pools villas";
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
        public UIDvFreeheatedpoolPane UIDvFreeheatedpoolPane
        {
            get
            {
                if ((this.mUIDvFreeheatedpoolPane == null))
                {
                    this.mUIDvFreeheatedpoolPane = new UIDvFreeheatedpoolPane(this);
                }
                return this.mUIDvFreeheatedpoolPane;
            }
        }
        #endregion
        
        #region Fields
        private UIDvFreeheatedpoolPane mUIDvFreeheatedpoolPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIDvFreeheatedpoolPane : HtmlDiv
    {
        
        public UIDvFreeheatedpoolPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.Id, "dvFreeheatedpool", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "\\ ";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "id=dvFreeheatedpool", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "46";
            this.WindowTitles.Add("Home Page");
            #endregion
        }
        
        #region Properties
        public HtmlImage UIFreeheatedpoolsvillaImage
        {
            get
            {
                if ((this.mUIFreeheatedpoolsvillaImage == null))
                {
                    this.mUIFreeheatedpoolsvillaImage = new HtmlImage(this);
                    #region Search Criteria
                    this.mUIFreeheatedpoolsvillaImage.SearchProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Alt, "Free heated pools villas", PropertyExpressionOperator.Contains));
                    this.mUIFreeheatedpoolsvillaImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
                    this.mUIFreeheatedpoolsvillaImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Src, "http://", PropertyExpressionOperator.Contains));
                    this.mUIFreeheatedpoolsvillaImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.ControlDefinition, "title=\"Free heated pools villas\"", PropertyExpressionOperator.Contains));
                    this.mUIFreeheatedpoolsvillaImage.FilterProperties[HtmlImage.PropertyNames.TagInstance] = "1";
                    this.mUIFreeheatedpoolsvillaImage.WindowTitles.Add("Home Page");
                    #endregion
                }
                return this.mUIFreeheatedpoolsvillaImage;
            }
        }
        #endregion
        
        #region Fields
        private HtmlImage mUIFreeheatedpoolsvillaImage;
        #endregion
    }
}
