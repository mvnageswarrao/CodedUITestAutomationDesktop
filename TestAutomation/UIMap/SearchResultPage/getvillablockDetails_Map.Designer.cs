﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchResultPage.getvillablockDetails_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public partial class getvillablockDetails_Map
    {
        
        /// <summary>
        /// getvillablockDetails_Method - Use 'getvillablockDetails_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public string getvillablockDetails_Method()
        {
            #region Variable Declarations
            HtmlDiv uIVillaVentetPollensaMPane = this.UIYoursearchfound214ViWindow.UIYoursearchfound214ViDocument.UIMainContent_lvVillaIPane.UIVillaVentetPollensaMPane;
            #endregion

            string villablockdetails = uIVillaVentetPollensaMPane.InnerText;
            villablockdetails = villablockdetails.Replace("\r\n",string.Empty);
            return villablockdetails;
   
        }
        
        #region Properties
        public virtual getvillablockDetails_MethodExpectedValues getvillablockDetails_MethodExpectedValues
        {
            get
            {
                if ((this.mgetvillablockDetails_MethodExpectedValues == null))
                {
                    this.mgetvillablockDetails_MethodExpectedValues = new getvillablockDetails_MethodExpectedValues();
                }
                return this.mgetvillablockDetails_MethodExpectedValues;
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
        private getvillablockDetails_MethodExpectedValues mgetvillablockDetails_MethodExpectedValues;
        
        private UIYoursearchfound214ViWindow mUIYoursearchfound214ViWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'getvillablockDetails_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class getvillablockDetails_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Villa Ventet, Pollensa, Majorca' pane contains '
        ///
        ///Villa Ventet, Pollensa, Majorca
        ///
        ///   
        ///
        ///
        /// 
        ///
        ///Saturday 25 April 2015, for 7 nights from
        ///London Gatwick - Palma 
        ///3 Bedrooms 
        ///Sleeps 2 to 7 
        ///Pool 29 x 9ft 
        ///Car Essential 
        ///3 Bathrooms 
        ///Beach 4 miles 
        ///Free Air Con 
        ///
        ///
        ///View Villa 
        ///
        ///
        ///
        ///Prices
        ///
        ///
        ///Villa & Flights
        ///Adult 2 X £199
        ///Child 2 X £179
        ///  Total: £756 
        /// 
        ///
        ///Villa Only: £429 
        /// '
        /// </summary>
        public string UIVillaVentetPollensaMPaneInnerText = @"

Villa Ventet, Pollensa, Majorca

   


 

Saturday 25 April 2015, for 7 nights from
London Gatwick - Palma 
3 Bedrooms 
Sleeps 2 to 7 
Pool 29 x 9ft 
Car Essential 
3 Bathrooms 
Beach 4 miles 
Free Air Con 


View Villa 



Prices


Villa & Flights
Adult 2 X £199
Child 2 X £179
  Total: £756 
 

Villa Only: £429 
 ";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIYoursearchfound214ViWindow : BrowserWindow
    {
        
        public UIYoursearchfound214ViWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your search found", PropertyExpressionOperator.Contains));
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
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your search found", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/searchresult.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/searchresult.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your search found 214 Villa holidays");
            #endregion
        }
        
        #region Properties
        public UIMainContent_lvVillaIPane UIMainContent_lvVillaIPane
        {
            get
            {
                if ((this.mUIMainContent_lvVillaIPane == null))
                {
                    this.mUIMainContent_lvVillaIPane = new UIMainContent_lvVillaIPane(this);
                }
                return this.mUIMainContent_lvVillaIPane;
            }
        }
        #endregion
        
        #region Fields
        private UIMainContent_lvVillaIPane mUIMainContent_lvVillaIPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.30501.0")]
    public class UIMainContent_lvVillaIPane : HtmlDiv
    {
        
        public UIMainContent_lvVillaIPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "MainContent_lvVillaInfo_lstProducts";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Villa", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"MainContent_lvVillaInfo_lstProducts\"";
            this.WindowTitles.Add("Your search found 214 Villa holidays");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIVillaVentetPollensaMPane
        {
            get
            {
                if ((this.mUIVillaVentetPollensaMPane == null))
                {
                    this.mUIVillaVentetPollensaMPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIVillaVentetPollensaMPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIVillaVentetPollensaMPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIVillaVentetPollensaMPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Villa", PropertyExpressionOperator.Contains));
                    this.mUIVillaVentetPollensaMPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "Villa-item VillaItemCss";
                    this.mUIVillaVentetPollensaMPane.WindowTitles.Add("Your search found 214 Villa holidays");
                    #endregion
                }
                return this.mUIVillaVentetPollensaMPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIVillaVentetPollensaMPane;
        #endregion
    }
}
