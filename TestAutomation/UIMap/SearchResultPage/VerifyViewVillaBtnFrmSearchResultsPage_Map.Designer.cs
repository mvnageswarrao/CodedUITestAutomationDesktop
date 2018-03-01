﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchResultPage.VerifyViewVillaBtnFrmSearchResultsPage_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public partial class VerifyViewVillaBtnFrmSearchResultsPage_Map:logWriter
    {
        
        /// <summary>
        /// VerifyViewVillaBtnFrmSearchResultsPage_Method - Use 'VerifyViewVillaBtnFrmSearchResultsPage_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void VerifyViewVillaBtnFrmSearchResultsPage_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIViewVillaHyperlink = this.UIYoursearchfound214ViWindow.UIYoursearchfound214ViDocument.UIViewVillaHyperlink;
            #endregion

            string BtnNameFrmPage = uIViewVillaHyperlink.InnerText.Trim();
            string ExpTxt = "View Villa";
            
            try
            {
                StringAssert.Contains(BtnNameFrmPage, ExpTxt);
                //stringassert.AreEqual(this.VerifyViewVillaBtnFrmSearchResultsPage_MethodExpectedValues.UIViewVillaHyperlinkId, uIViewVillaHyperlink.Id);
                WriteLogs("PASS : View Villa Button is shown.");
            }

            catch (AssertFailedException ex)
            {
                WriteLogs("FAIL : View Villa Button is NOT shown.");
                WriteLogs("----------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual VerifyViewVillaBtnFrmSearchResultsPage_MethodExpectedValues VerifyViewVillaBtnFrmSearchResultsPage_MethodExpectedValues
        {
            get
            {
                if ((this.mVerifyViewVillaBtnFrmSearchResultsPage_MethodExpectedValues == null))
                {
                    this.mVerifyViewVillaBtnFrmSearchResultsPage_MethodExpectedValues = new VerifyViewVillaBtnFrmSearchResultsPage_MethodExpectedValues();
                }
                return this.mVerifyViewVillaBtnFrmSearchResultsPage_MethodExpectedValues;
            }
        }
        
        public UIYoursearchfound214ViWindow UIYoursearchfound214ViWindow
        {
            get
            {
                if ((this.mUIYoursearchfound214ViWindow == null))
                {
                    this.mUIYoursearchfound214ViWindow = new UIYoursearchfound214ViWindow();
                }
                return this.mUIYoursearchfound214ViWindow;
            }
        }
        #endregion
        
        #region Fields
        private VerifyViewVillaBtnFrmSearchResultsPage_MethodExpectedValues mVerifyViewVillaBtnFrmSearchResultsPage_MethodExpectedValues;
        
        private UIYoursearchfound214ViWindow mUIYoursearchfound214ViWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'VerifyViewVillaBtnFrmSearchResultsPage_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class VerifyViewVillaBtnFrmSearchResultsPage_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Id' property of 'View Villa' link equals 'MainContent_lvVillaInfo_villaCtrl_2_ancViewVilla_2'
        /// </summary>
        public string UIViewVillaHyperlinkId = "MainContent_lvVillaInfo_villaCtrl_2_ancViewVilla_2";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIYoursearchfound214ViWindow : BrowserWindow
    {
        
        public UIYoursearchfound214ViWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your search found ", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your search found 214 Villa holidays");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYoursearchfound214ViDocument UIYoursearchfound214ViDocument
        {
            get
            {
                if ((this.mUIYoursearchfound214ViDocument == null))
                {
                    this.mUIYoursearchfound214ViDocument = new UIYoursearchfound214ViDocument(this);
                }
                return this.mUIYoursearchfound214ViDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound214ViDocument mUIYoursearchfound214ViDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIYoursearchfound214ViDocument : HtmlDocument
    {
        
        public UIYoursearchfound214ViDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your search found ", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/searchresult.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "villaplus.com/searchresult.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your search found 214 Villa holidays");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIViewVillaHyperlink
        {
            get
            {
                if ((this.mUIViewVillaHyperlink == null))
                {
                    this.mUIViewVillaHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIViewVillaHyperlink.SearchProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Id, "ViewVilla", PropertyExpressionOperator.Contains));
                    this.mUIViewVillaHyperlink.SearchProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.InnerText, "View Villa", PropertyExpressionOperator.Contains));
                    this.mUIViewVillaHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "/villas/", PropertyExpressionOperator.Contains));
                    this.mUIViewVillaHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Title, "view this villa", PropertyExpressionOperator.Contains));
                    this.mUIViewVillaHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, ".villaplus.com/", PropertyExpressionOperator.Contains));
                    this.mUIViewVillaHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Class, "ViewVilla", PropertyExpressionOperator.Contains));
                    this.mUIViewVillaHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.ControlDefinition, "title=\"click to view this villa\" class=\"", PropertyExpressionOperator.Contains));
                    this.mUIViewVillaHyperlink.WindowTitles.Add("Your search found 214 Villa holidays");
                    #endregion
                }
                return this.mUIViewVillaHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIViewVillaHyperlink;
        #endregion
    }
}
