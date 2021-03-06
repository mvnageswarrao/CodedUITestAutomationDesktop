﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.verifyMainPageSubTitle_MapClasses
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
    public partial class verifyMainPageSubTitle_Map:logWriter 
    {
        
        /// <summary>
        /// verifyMainPageSubTitle_Method - Use 'verifyMainPageSubTitle_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyMainPageSubTitle_Method(string villaHeader)
        {
            #region Variable Declarations
            HtmlSpan uICanas1bdrmEQuintadoLPane = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UICanas1bdrmEQuintadoLPane;
            HtmlSpan uICanas1bdrmEQuintadoLPane1 = this.UICanas1bdrmEQuintadoLWindow.UICanas1bdrmEQuintadoLDocument.UICanas1bdrmEQuintadoLPane1;
            #endregion

            // Verify that the 'InnerText' property of 'Canas 1 bdrm E, Quinta do Lago, Algarve' pane contains 'Canas 1 bdrm E, Quinta do Lago, Algarve'
            //StringAssert.Contains(uICanas1bdrmEQuintadoLPane.InnerText, this.verifyMainPageSubTitle_MethodExpectedValues.UICanas1bdrmEQuintadoLPaneInnerText);
            try
            {
                StringAssert.Equals(uICanas1bdrmEQuintadoLPane.InnerText, villaHeader);
                WriteLogs("PASS : Product Main Page - SubTitle_1.");
            }
            catch (AssertFailedException ex)
            {
                WriteLogs("FAIL : Product Main Page - SubTitle_1.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

            // Verify that the 'InnerText' property of 'Canas 1 bdrm E, Quinta do Lago, Algarve' pane contains 'Canas 1 bdrm E, Quinta do Lago, Algarve'
            //StringAssert.Contains(uICanas1bdrmEQuintadoLPane1.InnerText, this.verifyMainPageSubTitle_MethodExpectedValues.UICanas1bdrmEQuintadoLPane1InnerText);
            try
            {
                StringAssert.Equals(uICanas1bdrmEQuintadoLPane1.InnerText, villaHeader);
                WriteLogs("PASS : Product Main Page - SubTitle_2.");
            }
            catch (AssertFailedException ex)
            {
                WriteLogs("FAIL : Product Main Page - SubTitle_2.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyMainPageSubTitle_MethodExpectedValues verifyMainPageSubTitle_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyMainPageSubTitle_MethodExpectedValues == null))
                {
                    this.mverifyMainPageSubTitle_MethodExpectedValues = new verifyMainPageSubTitle_MethodExpectedValues();
                }
                return this.mverifyMainPageSubTitle_MethodExpectedValues;
            }
        }
        
        public UICanas1bdrmEQuintadoLWindow UICanas1bdrmEQuintadoLWindow
        {
            get
            {
                if ((this.mUICanas1bdrmEQuintadoLWindow == null))
                {
                    this.mUICanas1bdrmEQuintadoLWindow = new UICanas1bdrmEQuintadoLWindow();
                }
                return this.mUICanas1bdrmEQuintadoLWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyMainPageSubTitle_MethodExpectedValues mverifyMainPageSubTitle_MethodExpectedValues;
        
        private UICanas1bdrmEQuintadoLWindow mUICanas1bdrmEQuintadoLWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyMainPageSubTitle_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class verifyMainPageSubTitle_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Canas 1 bdrm E, Quinta do Lago, Algarve' pane contains 'Canas 1 bdrm E, Quinta do Lago, Algarve'
        /// </summary>
        public string UICanas1bdrmEQuintadoLPaneInnerText = "Canas 1 bdrm E, Quinta do Lago, Algarve";
        
        /// <summary>
        /// Verify that the 'InnerText' property of 'Canas 1 bdrm E, Quinta do Lago, Algarve' pane contains 'Canas 1 bdrm E, Quinta do Lago, Algarve'
        /// </summary>
        public string UICanas1bdrmEQuintadoLPane1InnerText = "Canas 1 bdrm E, Quinta do Lago, Algarve";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICanas1bdrmEQuintadoLWindow : BrowserWindow
    {
        
        public UICanas1bdrmEQuintadoLWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UICanas1bdrmEQuintadoLDocument UICanas1bdrmEQuintadoLDocument
        {
            get
            {
                if ((this.mUICanas1bdrmEQuintadoLDocument == null))
                {
                    this.mUICanas1bdrmEQuintadoLDocument = new UICanas1bdrmEQuintadoLDocument(this);
                }
                return this.mUICanas1bdrmEQuintadoLDocument;
            }
        }
        #endregion
        
        #region Fields
        private UICanas1bdrmEQuintadoLDocument mUICanas1bdrmEQuintadoLDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICanas1bdrmEQuintadoLDocument : HtmlDocument
    {
        
        public UICanas1bdrmEQuintadoLDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/product.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://nimbus/product.aspx?villaid=275";
            this.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlSpan UICanas1bdrmEQuintadoLPane
        {
            get
            {
                if ((this.mUICanas1bdrmEQuintadoLPane == null))
                {
                    this.mUICanas1bdrmEQuintadoLPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUICanas1bdrmEQuintadoLPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "MainContent_VillaHeader";
                    this.mUICanas1bdrmEQuintadoLPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUICanas1bdrmEQuintadoLPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Canas 1 bdrm E, Quinta do Lago, Algarve";
                    this.mUICanas1bdrmEQuintadoLPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUICanas1bdrmEQuintadoLPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "font20 bold black";
                    this.mUICanas1bdrmEQuintadoLPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"MainContent_VillaHeader\" class=\"font";
                    this.mUICanas1bdrmEQuintadoLPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "5";
                    this.mUICanas1bdrmEQuintadoLPane.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUICanas1bdrmEQuintadoLPane;
            }
        }
        
        public HtmlSpan UICanas1bdrmEQuintadoLPane1
        {
            get
            {
                if ((this.mUICanas1bdrmEQuintadoLPane1 == null))
                {
                    this.mUICanas1bdrmEQuintadoLPane1 = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUICanas1bdrmEQuintadoLPane1.SearchProperties[HtmlDiv.PropertyNames.Id] = "MainContent_SummaryHeader";
                    this.mUICanas1bdrmEQuintadoLPane1.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUICanas1bdrmEQuintadoLPane1.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Canas 1 bdrm E, Quinta do Lago, Algarve";
                    this.mUICanas1bdrmEQuintadoLPane1.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUICanas1bdrmEQuintadoLPane1.FilterProperties[HtmlDiv.PropertyNames.Class] = "bodyContent bold black margin-bottom-5";
                    this.mUICanas1bdrmEQuintadoLPane1.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"MainContent_SummaryHeader\" class=\"bo";
                    this.mUICanas1bdrmEQuintadoLPane1.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "11";
                    this.mUICanas1bdrmEQuintadoLPane1.WindowTitles.Add("Canas 1 bdrm E, Quinta do Lago, Algarve, Villa Plus");
                    #endregion
                }
                return this.mUICanas1bdrmEQuintadoLPane1;
            }
        }
        #endregion
        
        #region Fields
        private HtmlSpan mUICanas1bdrmEQuintadoLPane;
        
        private HtmlSpan mUICanas1bdrmEQuintadoLPane1;
        #endregion
    }
}
