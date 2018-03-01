﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchResultPage.verifyIncludeFlightPopupDisplay_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class verifyIncludeFlightPopupDisplay_Map:logWriter
    {
        
        /// <summary>
        /// verifyIncludeFlightPopupDisplay_Method - Use 'verifyIncludeFlightPopupDisplay_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyIncludeFlightPopupDisplay_Method()
        {
            #region Variable Declarations
            HtmlDiv uIVillaflightcloseInorPane = this.UIYoursearchfound9VillWindow.UIYoursearchfound9VillDocument.UIVillaflightcloseInorPane;
            #endregion
            string ExpTxt = "Villa&Flight";
            try
            {
                StringAssert.Contains(uIVillaflightcloseInorPane.InnerText.Replace("\r\n",string.Empty.Trim()), ExpTxt);
                WriteLogs("PASS : Clicked \"Include Flights\" Popup.");
            }
            catch (AssertFailedException ex)
            {
                WriteLogs("FAIL : Could Not Click \"Include Flights\" Popup.");
                WriteLogs("----------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyIncludeFlightPopupDisplay_MethodExpectedValues verifyIncludeFlightPopupDisplay_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyIncludeFlightPopupDisplay_MethodExpectedValues == null))
                {
                    this.mverifyIncludeFlightPopupDisplay_MethodExpectedValues = new verifyIncludeFlightPopupDisplay_MethodExpectedValues();
                }
                return this.mverifyIncludeFlightPopupDisplay_MethodExpectedValues;
            }
        }
        
        public UIYoursearchfound9VillWindow UIYoursearchfound9VillWindow
        {
            get
            {
                if ((this.mUIYoursearchfound9VillWindow == null))
                {
                    this.mUIYoursearchfound9VillWindow = new UIYoursearchfound9VillWindow();
                }
                return this.mUIYoursearchfound9VillWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyIncludeFlightPopupDisplay_MethodExpectedValues mverifyIncludeFlightPopupDisplay_MethodExpectedValues;
        
        private UIYoursearchfound9VillWindow mUIYoursearchfound9VillWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyIncludeFlightPopupDisplay_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class verifyIncludeFlightPopupDisplay_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Villa & flightclose In order to ca' pane equals 'Villa & flightclose
        ///
        /// 
        ///In order to calculate the cost of Villa plus Flight packages, we require confirmation of the departure airport and passengers within your party. 
        ///
        ///
        ///How many people   
        ///
        ///Adults 
        /// 
        ///Child 2-11 
        /// 
        ///Infant Under 2 
        /// 
        ///Travelling from?  
        /// 
        ///
        ///1234567891011121314151617181920 
        /// 
        ///0123456789101112131415161718 
        /// 
        ///01234567891011121314151617181920 
        /// 
        ///All London London Gatwick London Heathrow London Luton London Southend London Stansted All Midlands Birmingham Intl East Midlands All North East Doncaster Durham Humberside Leeds Bradford Newcastle All North West Liverpool Manchester All Scottish Aberdeen Edinburgh  Glasgow All South West Bournemouth Bristol Cardiff Exeter Southampton  All Northern Ireland Belfast City Belfast Intl East England Norwich  
        /// 
        ///
        ///
        ///
        /// '
        /// </summary>
        public string UIVillaflightcloseInorPaneInnerText = @"Villa & flightclose

 
In order to calculate the cost of Villa plus Flight packages, we require confirmation of the departure airport and passengers within your party. 


How many people   

Adults 
 
Child 2-11 
 
Infant Under 2 
 
Travelling from?  
 

1234567891011121314151617181920 
 
0123456789101112131415161718 
 
01234567891011121314151617181920 
 
All London London Gatwick London Heathrow London Luton London Southend London Stansted All Midlands Birmingham Intl East Midlands All North East Doncaster Durham Humberside Leeds Bradford Newcastle All North West Liverpool Manchester All Scottish Aberdeen Edinburgh  Glasgow All South West Bournemouth Bristol Cardiff Exeter Southampton  All Northern Ireland Belfast City Belfast Intl East England Norwich  
 



 ";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIYoursearchfound9VillWindow : BrowserWindow
    {
        
        public UIYoursearchfound9VillWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your search found", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your search found 9 Villa holidays");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYoursearchfound9VillDocument UIYoursearchfound9VillDocument
        {
            get
            {
                if ((this.mUIYoursearchfound9VillDocument == null))
                {
                    this.mUIYoursearchfound9VillDocument = new UIYoursearchfound9VillDocument(this);
                }
                return this.mUIYoursearchfound9VillDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound9VillDocument mUIYoursearchfound9VillDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIYoursearchfound9VillDocument : HtmlDocument
    {
        
        public UIYoursearchfound9VillDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your search found", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/searchresult.aspx";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/searchresult.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your search found 9 Villa holidays");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIVillaflightcloseInorPane
        {
            get
            {
                if ((this.mUIVillaflightcloseInorPane == null))
                {
                    this.mUIVillaflightcloseInorPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIVillaflightcloseInorPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Villa & flight", PropertyExpressionOperator.Contains));
                    this.mUIVillaflightcloseInorPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "ui-dialog ui-widget ui-widget-content ui-corner-all dialogShadow";
                    this.mUIVillaflightcloseInorPane.WindowTitles.Add("Your search found 9 Villa holidays");
                    #endregion
                }
                return this.mUIVillaflightcloseInorPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIVillaflightcloseInorPane;
        #endregion
    }
}