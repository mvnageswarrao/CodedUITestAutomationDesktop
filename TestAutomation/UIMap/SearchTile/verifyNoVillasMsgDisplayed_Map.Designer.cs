﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchTile.verifyNoVillasMsgDisplayed_MapClasses
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
    public partial class verifyNoVillasMsgDisplayed_Map:logWriter
    {
        
        /// <summary>
        /// verifyNoVillasMsgDisplayed_Method - Use 'verifyNoVillasMsgDisplayed_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public Boolean verifyNoVillasMsgDisplayed_Method()
        {
            #region Variable Declarations
            
            HtmlSpan uISorryPane = this.UIYoursearchfound0VillWindow.UIYoursearchfound0VillDocument.UISorryPane;
            #endregion

            //Boolean IsNoVillasMsgDisplayed = uISorryPane.Exists;
            Boolean IsNoVillasMsgDisplayed = uISorryPane.DisplayText.Trim().StartsWith("Sorry!");

            if (IsNoVillasMsgDisplayed == true)
            {
                try
                {
                    // Verify that the 'InnerText' property of 'Sorry!' pane equals 'Sorry!'
                    Assert.AreEqual(this.verifyNoVillasMsgDisplayed_MethodExpectedValues.UISorryPaneInnerText, uISorryPane.InnerText);
                    WriteLogs("PASS : \"Search Results\" Page Shown 0 Villas Message. : VERIFICATION");
                }
                catch (AssertFailedException ex)
                {
                    takeImage("verifyNoVillasMsgDisplayed");
                    WriteLogs("FAIL : \"Search Results\" Page is Not Shown 0 Villas Message. : VERIFICATION");
                    WriteLogs("-----------------" + ex.Message.ToString());
                }
            }

            return IsNoVillasMsgDisplayed;
        }
        
        #region Properties
        public virtual verifyNoVillasMsgDisplayed_MethodExpectedValues verifyNoVillasMsgDisplayed_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyNoVillasMsgDisplayed_MethodExpectedValues == null))
                {
                    this.mverifyNoVillasMsgDisplayed_MethodExpectedValues = new verifyNoVillasMsgDisplayed_MethodExpectedValues();
                }
                return this.mverifyNoVillasMsgDisplayed_MethodExpectedValues;
            }
        }
        
        public UIYoursearchfound0VillWindow UIYoursearchfound0VillWindow
        {
            get
            {
                if ((this.mUIYoursearchfound0VillWindow == null))
                {
                    this.mUIYoursearchfound0VillWindow = new UIYoursearchfound0VillWindow();
                }
                return this.mUIYoursearchfound0VillWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyNoVillasMsgDisplayed_MethodExpectedValues mverifyNoVillasMsgDisplayed_MethodExpectedValues;
        
        private UIYoursearchfound0VillWindow mUIYoursearchfound0VillWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyNoVillasMsgDisplayed_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyNoVillasMsgDisplayed_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Sorry!' pane equals 'Sorry!'
        /// </summary>
        public string UISorryPaneInnerText = "Sorry!";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIYoursearchfound0VillWindow : BrowserWindow
    {
        
        public UIYoursearchfound0VillWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your search found 0 Villa holiday", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your search found 0 Villa holiday");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYoursearchfound0VillDocument UIYoursearchfound0VillDocument
        {
            get
            {
                if ((this.mUIYoursearchfound0VillDocument == null))
                {
                    this.mUIYoursearchfound0VillDocument = new UIYoursearchfound0VillDocument(this);
                }
                return this.mUIYoursearchfound0VillDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound0VillDocument mUIYoursearchfound0VillDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIYoursearchfound0VillDocument : HtmlDocument
    {
        
        public UIYoursearchfound0VillDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Your search found 0 Villa holiday";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/searchresult.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/searchresult.aspx?", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your search found 0 Villa holiday");
            #endregion
        }
        
        #region Properties
        public HtmlSpan UISorryPane
        {
            get
            {
                if ((this.mUISorryPane == null))
                {
                    this.mUISorryPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUISorryPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "topContent_header";
                    this.mUISorryPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Sorry!";
                    this.mUISorryPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"topContent_header\"";
                    this.mUISorryPane.WindowTitles.Add("Your search found 0 Villa holiday");
                    #endregion
                }
                return this.mUISorryPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlSpan mUISorryPane;
        #endregion
    }
}