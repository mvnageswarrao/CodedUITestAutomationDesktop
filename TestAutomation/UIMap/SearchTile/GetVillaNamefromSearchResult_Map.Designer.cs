﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.searchtile.GetVillaNamefromSearchResult_mapclasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class GetVillaNamefromSearchResult_Map
    {
        
        /// <summary>
        /// GetVillaNamefromSearchResult_Method - Use 'GetVillaNamefromSearchResult_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void GetVillaNamefromSearchResult_Method()
        {
            #region Variable Declarations
            HtmlHyperlink uIVillaBrisasMarCorralHyperlink = this.UIYoursearchfound11VilWindow.UIYoursearchfound11VilDocument.UIVillaBrisasMarCorralHyperlink;
            HtmlSpan uIItem507Pane = this.UIYoursearchfound11VilWindow.UIYoursearchfound11VilDocument.UIItem507Pane;
            #endregion

            // Verify that the 'InnerText' property of 'Villa Brisas Mar, Corralejo, Fuerteventura' link contains 'Villa Brisas Mar, Corralejo, Fuerteventura'
            StringAssert.Contains(uIVillaBrisasMarCorralHyperlink.InnerText, this.GetVillaNamefromSearchResult_MethodExpectedValues.UIVillaBrisasMarCorralHyperlinkInnerText, "Villa name compare failed.");
            
            // Verify that the 'InnerText' property of ': £507' pane equals ' £507'
            Assert.AreEqual(this.GetVillaNamefromSearchResult_MethodExpectedValues.UIItem507PaneInnerText, uIItem507Pane.InnerText, "price compare failed");
        }
        
        #region Properties
        public virtual GetVillaNamefromSearchResult_MethodExpectedValues GetVillaNamefromSearchResult_MethodExpectedValues
        {
            get
            {
                if ((this.mGetVillaNamefromSearchResult_MethodExpectedValues == null))
                {
                    this.mGetVillaNamefromSearchResult_MethodExpectedValues = new GetVillaNamefromSearchResult_MethodExpectedValues();
                }
                return this.mGetVillaNamefromSearchResult_MethodExpectedValues;
            }
        }
        
        public UIYoursearchfound11VilWindow UIYoursearchfound11VilWindow
        {
            get
            {
                if ((this.mUIYoursearchfound11VilWindow == null))
                {
                    this.mUIYoursearchfound11VilWindow = new UIYoursearchfound11VilWindow();
                }
                return this.mUIYoursearchfound11VilWindow;
            }
        }
        #endregion
        
        #region Fields
        private GetVillaNamefromSearchResult_MethodExpectedValues mGetVillaNamefromSearchResult_MethodExpectedValues;
        
        private UIYoursearchfound11VilWindow mUIYoursearchfound11VilWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'GetVillaNamefromSearchResult_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class GetVillaNamefromSearchResult_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Villa Brisas Mar, Corralejo, Fuerteventura' link contains 'Villa Brisas Mar, Corralejo, Fuerteventura'
        /// </summary>
        public string UIVillaBrisasMarCorralHyperlinkInnerText = "Villa Brisas Mar, Corralejo, Fuerteventura";
        
        /// <summary>
        /// Verify that the 'InnerText' property of ': £507' pane equals ' £507'
        /// </summary>
        public string UIItem507PaneInnerText = " £507";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYoursearchfound11VilWindow : BrowserWindow
    {
        
        public UIYoursearchfound11VilWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Your search found 11 Villa holidays";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your search found 11 Villa holidays");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYoursearchfound11VilDocument UIYoursearchfound11VilDocument
        {
            get
            {
                if ((this.mUIYoursearchfound11VilDocument == null))
                {
                    this.mUIYoursearchfound11VilDocument = new UIYoursearchfound11VilDocument(this);
                }
                return this.mUIYoursearchfound11VilDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound11VilDocument mUIYoursearchfound11VilDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIYoursearchfound11VilDocument : HtmlDocument
    {
        
        public UIYoursearchfound11VilDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Your search found 11 Villa holidays";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/searchresult.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://staging1.villaplus.com/searchresult.aspx";
            this.WindowTitles.Add("Your search found 11 Villa holidays");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIVillaBrisasMarCorralHyperlink
        {
            get
            {
                if ((this.mUIVillaBrisasMarCorralHyperlink == null))
                {
                    this.mUIVillaBrisasMarCorralHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIVillaBrisasMarCorralHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "MainContent_lvVillaInfo_villaCtrl_0_lblVillaDesc_0";
                    this.mUIVillaBrisasMarCorralHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIVillaBrisasMarCorralHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIVillaBrisasMarCorralHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Villa Brisas Mar, Corralejo, Fuerteventura";
                    this.mUIVillaBrisasMarCorralHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/fuerteventura/villas/corralejo/villa-brisas-mar";
                    this.mUIVillaBrisasMarCorralHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIVillaBrisasMarCorralHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://staging1.villaplus.com/fuerteventura/villas/corralejo/villa-brisas-mar";
                    this.mUIVillaBrisasMarCorralHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "villDesc floatleft";
                    this.mUIVillaBrisasMarCorralHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "class=\"villDesc floatleft\" id=\"MainConte";
                    this.mUIVillaBrisasMarCorralHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "30";
                    this.mUIVillaBrisasMarCorralHyperlink.WindowTitles.Add("Your search found 11 Villa holidays");
                    #endregion
                }
                return this.mUIVillaBrisasMarCorralHyperlink;
            }
        }
        
        public HtmlSpan UIItem507Pane
        {
            get
            {
                if ((this.mUIItem507Pane == null))
                {
                    this.mUIItem507Pane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIItem507Pane.SearchProperties[HtmlDiv.PropertyNames.Id] = "MainContent_lvVillaInfo_villaCtrl_0_lblVOTotal_0";
                    this.mUIItem507Pane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIItem507Pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = ": £507";
                    this.mUIItem507Pane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIItem507Pane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUIItem507Pane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"MainContent_lvVillaInfo_villaCtrl_0_lblVOTotal_0\"";
                    this.mUIItem507Pane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "34";
                    this.mUIItem507Pane.WindowTitles.Add("Your search found 11 Villa holidays");
                    #endregion
                }
                return this.mUIItem507Pane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIVillaBrisasMarCorralHyperlink;
        
        private HtmlSpan mUIItem507Pane;
        #endregion
    }
}