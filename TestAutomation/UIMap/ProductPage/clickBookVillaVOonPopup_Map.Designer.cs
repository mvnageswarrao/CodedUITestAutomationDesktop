﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.clickBookVillaVOonPopup_MapClasses
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
    public partial class clickBookVillaVOonPopup_Map:logWriter
    {
        
        /// <summary>
        /// clickBookVillaVOonPopup_Method
        /// </summary>
        public void clickBookVillaVOonPopup_Method()
        {
            #region Variable Declarations
            HtmlInputButton uIBooknowButton1 = this.UIVillaBrisasMarInCorrWindow.UIVillaBrisasMarInCorrDocument.UIBooknowButton1;
            #endregion
                        
            try
            {
                // Click 'Book now' button
                Mouse.Click(uIBooknowButton1, new Point(34, 14));
                WriteLogs("PASS : Book Now Button Clicked for Villa Only From Product Page.");
            }
            catch (AssertFailedException ex)
            {
                WriteLogs("FAIL : Could Not Click Book Now Button for Villa Only From Product Page.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public UIVillaBrisasMarInCorrWindow UIVillaBrisasMarInCorrWindow
        {
            get
            {
                if ((this.mUIVillaBrisasMarInCorrWindow == null))
                {
                    this.mUIVillaBrisasMarInCorrWindow = new UIVillaBrisasMarInCorrWindow();
                }
                return this.mUIVillaBrisasMarInCorrWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaBrisasMarInCorrWindow mUIVillaBrisasMarInCorrWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaBrisasMarInCorrWindow : BrowserWindow
    {
        
        public UIVillaBrisasMarInCorrWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Brisas Mar In Corralejo, Fuerteventura | Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaBrisasMarInCorrDocument UIVillaBrisasMarInCorrDocument
        {
            get
            {
                if ((this.mUIVillaBrisasMarInCorrDocument == null))
                {
                    this.mUIVillaBrisasMarInCorrDocument = new UIVillaBrisasMarInCorrDocument(this);
                }
                return this.mUIVillaBrisasMarInCorrDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaBrisasMarInCorrDocument mUIVillaBrisasMarInCorrDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaBrisasMarInCorrDocument : HtmlDocument
    {
        
        public UIVillaBrisasMarInCorrDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "| Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/villas/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/villas/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Brisas Mar In Corralejo, Fuerteventura | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlInputButton UIBooknowButton
        {
            get
            {
                if ((this.mUIBooknowButton == null))
                {
                    this.mUIBooknowButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUIBooknowButton.SearchProperties[HtmlButton.PropertyNames.Id] = "MainContent_VillaAvailability_btnBookNowPkg";
                    this.mUIBooknowButton.SearchProperties[HtmlButton.PropertyNames.Name] = "ctl00$MainContent$VillaAvailability$btnBookNowPkg";
                    this.mUIBooknowButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "Book now";
                    this.mUIBooknowButton.FilterProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIBooknowButton.FilterProperties[HtmlButton.PropertyNames.Title] = "Book now";
                    this.mUIBooknowButton.FilterProperties[HtmlButton.PropertyNames.Class] = "button font12 bold";
                    this.mUIBooknowButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "name=\"ctl00$MainContent$VillaAvailabilit";
                    this.mUIBooknowButton.WindowTitles.Add("Villa Brisas Mar In Corralejo, Fuerteventura | Villa Plus");
                    #endregion
                }
                return this.mUIBooknowButton;
            }
        }
        
        public HtmlInputButton UIBooknowButton1
        {
            get
            {
                if ((this.mUIBooknowButton1 == null))
                {
                    this.mUIBooknowButton1 = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUIBooknowButton1.SearchProperties[HtmlButton.PropertyNames.Id] = "MainContent_VillaAvailability_btnBookNowVO";
                    this.mUIBooknowButton1.SearchProperties[HtmlButton.PropertyNames.Name] = "ctl00$MainContent$VillaAvailability$btnBookNowVO";
                    this.mUIBooknowButton1.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "Book now";
                    this.mUIBooknowButton1.FilterProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIBooknowButton1.FilterProperties[HtmlButton.PropertyNames.Title] = "Book now";
                    this.mUIBooknowButton1.FilterProperties[HtmlButton.PropertyNames.Class] = "button font12 bold";
                    this.mUIBooknowButton1.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "name=\"ctl00$MainContent$VillaAvailabilit";
                    this.mUIBooknowButton1.WindowTitles.Add("Villa Brisas Mar In Corralejo, Fuerteventura | Villa Plus");
                    #endregion
                }
                return this.mUIBooknowButton1;
            }
        }
        #endregion
        
        #region Fields
        private HtmlInputButton mUIBooknowButton;
        
        private HtmlInputButton mUIBooknowButton1;
        #endregion
    }
}