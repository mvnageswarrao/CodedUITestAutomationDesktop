﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.DestinationsPage.verifyHeadingText_MapClasses
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
    public partial class verifyHeadingText_Map:logWriter
    {
        
        /// <summary>
        /// verifyHeadingText_Method - Use 'verifyHeadingText_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyHeadingText_Method(string headingText)
        {
            #region Variable Declarations
            HtmlSpan uIDestinationsPane = this.UIHttpnimbusdestinatioWindow.UIHttpnimbusdestinatioDocument.UIDestinationsPane;
            #endregion

            // Verify that the 'InnerText' property of 'Destinations' pane equals 'Destinations'
            //Assert.AreEqual(this.verifyHeadingText_MethodExpectedValues.UIDestinationsPaneInnerText, uIDestinationsPane.InnerText);
            try
            {
                Assert.AreEqual(headingText, uIDestinationsPane.InnerText);
                WriteLogs("PASS : Heading Text");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyHeadingText");
                WriteLogs("FAIL : Heading Text");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

        }
        
        #region Properties
        public virtual verifyHeadingText_MethodExpectedValues verifyHeadingText_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyHeadingText_MethodExpectedValues == null))
                {
                    this.mverifyHeadingText_MethodExpectedValues = new verifyHeadingText_MethodExpectedValues();
                }
                return this.mverifyHeadingText_MethodExpectedValues;
            }
        }
        
        public UIHttpnimbusdestinatioWindow UIHttpnimbusdestinatioWindow
        {
            get
            {
                if ((this.mUIHttpnimbusdestinatioWindow == null))
                {
                    this.mUIHttpnimbusdestinatioWindow = new UIHttpnimbusdestinatioWindow();
                }
                return this.mUIHttpnimbusdestinatioWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyHeadingText_MethodExpectedValues mverifyHeadingText_MethodExpectedValues;
        
        private UIHttpnimbusdestinatioWindow mUIHttpnimbusdestinatioWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyHeadingText_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class verifyHeadingText_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Destinations' pane equals 'Destinations'
        /// </summary>
        public string UIDestinationsPaneInnerText = "Destinations";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHttpnimbusdestinatioWindow : BrowserWindow
    {
        
        public UIHttpnimbusdestinatioWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "destinations.aspx", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("http://nimbus/destinations.aspx");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHttpnimbusdestinatioDocument UIHttpnimbusdestinatioDocument
        {
            get
            {
                if ((this.mUIHttpnimbusdestinatioDocument == null))
                {
                    this.mUIHttpnimbusdestinatioDocument = new UIHttpnimbusdestinatioDocument(this);
                }
                return this.mUIHttpnimbusdestinatioDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpnimbusdestinatioDocument mUIHttpnimbusdestinatioDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHttpnimbusdestinatioDocument : HtmlDocument
    {
        
        public UIHttpnimbusdestinatioDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/destinations.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://nimbus/destinations.aspx";
            this.WindowTitles.Add("http://nimbus/destinations.aspx");
            #endregion
        }
        
        #region Properties
        public HtmlSpan UIDestinationsPane
        {
            get
            {
                if ((this.mUIDestinationsPane == null))
                {
                    this.mUIDestinationsPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIDestinationsPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "topContent_lblName";
                    this.mUIDestinationsPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIDestinationsPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Destinations";
                    this.mUIDestinationsPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIDestinationsPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "floatleft Heading1";
                    this.mUIDestinationsPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"topContent_lblName\" class=\"floatleft";
                    this.mUIDestinationsPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "8";
                    this.mUIDestinationsPane.WindowTitles.Add("http://nimbus/destinations.aspx");
                    #endregion
                }
                return this.mUIDestinationsPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlSpan mUIDestinationsPane;
        #endregion
    }
}