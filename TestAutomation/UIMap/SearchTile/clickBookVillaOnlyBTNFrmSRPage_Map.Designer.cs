﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchTile.clickBookVillaOnlyBTNFrmSRPage_MapClasses
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
    public partial class clickBookVillaOnlyBTNFrmSRPage_Map:logWriter
    {
        
        /// <summary>
        /// clickBookVillaOnlyBTNFrmSRPage_Method
        /// </summary>
        public void clickBookVillaOnlyBTNFrmSRPage_Method()
        {
            #region Variable Declarations
            HtmlInputButton uIBookvillaonlyButton = this.UIYoursearchfound43VilWindow.UIYoursearchfound43VilDocument.UIBookvillaonlyButton;
            #endregion

            try
            {  
                // Click 'Book villa only' button
                Mouse.Click(uIBookvillaonlyButton, new Point(25, 5));
                WriteLogs("PASS : Clicked \"Book Villa Only\" Button From Search Results Page.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("clickBookVillaOnlyBTNFrmSRPage");
                WriteLogs("FAIL : Could Not click \"Book Villa Only\" Button From Search Results Page.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public UIYoursearchfound43VilWindow UIYoursearchfound43VilWindow
        {
            get
            {
                if ((this.mUIYoursearchfound43VilWindow == null))
                {
                    this.mUIYoursearchfound43VilWindow = new UIYoursearchfound43VilWindow();
                }
                return this.mUIYoursearchfound43VilWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound43VilWindow mUIYoursearchfound43VilWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIYoursearchfound43VilWindow : BrowserWindow
    {
        
        public UIYoursearchfound43VilWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your search found", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your search found 43 Villa holidays");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYoursearchfound43VilDocument UIYoursearchfound43VilDocument
        {
            get
            {
                if ((this.mUIYoursearchfound43VilDocument == null))
                {
                    this.mUIYoursearchfound43VilDocument = new UIYoursearchfound43VilDocument(this);
                }
                return this.mUIYoursearchfound43VilDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound43VilDocument mUIYoursearchfound43VilDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIYoursearchfound43VilDocument : HtmlDocument
    {
        
        public UIYoursearchfound43VilDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your search found", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/searchresult.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/searchresult.aspx?", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your search found 43 Villa holidays");
            #endregion
        }
        
        #region Properties
        public HtmlInputButton UIBookvillaonlyButton
        {
            get
            {
                if ((this.mUIBookvillaonlyButton == null))
                {
                    this.mUIBookvillaonlyButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUIBookvillaonlyButton.SearchProperties.Add(new PropertyExpression(HtmlButton.PropertyNames.Id, "MainContent_lvVillaInfo_villaCtrl_0_lnkBookVO_", PropertyExpressionOperator.Contains));
                    this.mUIBookvillaonlyButton.SearchProperties[HtmlButton.PropertyNames.Name] = "ctl00$MainContent$lvVillaInfo$ctrl0$villaCtrl$lnkBookVO";
                    this.mUIBookvillaonlyButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "Book villa only";
                    this.mUIBookvillaonlyButton.FilterProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIBookvillaonlyButton.FilterProperties[HtmlButton.PropertyNames.Class] = "link_button";
                    this.mUIBookvillaonlyButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "name=\"ctl00$MainContent$lvVillaInfo$ctrl";
                    this.mUIBookvillaonlyButton.WindowTitles.Add("Your search found 43 Villa holidays");
                    #endregion
                }
                return this.mUIBookvillaonlyButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlInputButton mUIBookvillaonlyButton;
        #endregion
    }
}