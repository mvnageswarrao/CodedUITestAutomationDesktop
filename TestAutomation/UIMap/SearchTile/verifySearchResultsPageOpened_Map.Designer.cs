﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchTile.verifySearchResultsPageOpened_MapClasses
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
    public partial class verifySearchResultsPageOpened_Map:logWriter
    {
        
        /// <summary>
        /// verifySearchResultsPageOpened_Method - Use 'verifySearchResultsPageOpened_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifySearchResultsPageOpened_Method(int NumofADULTS, int NumofCHILD, int NumofINFANTS, string selectedDuration, string SelectedAIRPORT, DateTime SelectableDATE, string SelectedDATE, int NumofVillasFOUND)
        
        {
            #region Variable Declarations
            HtmlSpan uIMainContent_SearchMsPane = this.UIYoursearchfound60VilWindow.UIYoursearchfound60VilDocument.UIMainContent_SearchMsPane;
            #endregion

            string selectedWeek = SelectableDATE.DayOfWeek.ToString();

            string SearchMsgFrmPage = uIMainContent_SearchMsPane.InnerText;
            SearchMsgFrmPage = SearchMsgFrmPage.Replace("\r\n", string.Empty);
            SearchMsgFrmPage = SearchMsgFrmPage.Replace(" ", string.Empty);
            SearchMsgFrmPage = SearchMsgFrmPage.Trim();
                        
            if (NumofVillasFOUND == 1)
            {
                string ExpectedSearchMsgforsinglevilla = string.Empty;
                string ExpectedSearchMsgforsinglevillaREGEX = string.Empty;
                if (SelectedAIRPORT == "Villa Only")
                {
                    ExpectedSearchMsgforsinglevilla = @"YourSearchhasreturned(.*?)villabasedonyoursearchcriteriaof:(.*?)on(.*?)for";
                    Regex RegexSTR = new Regex(ExpectedSearchMsgforsinglevilla, RegexOptions.IgnoreCase);
                    ExpectedSearchMsgforsinglevillaREGEX = RegexSTR.Match(SearchMsgFrmPage).Value.Trim().ToString();
                    ExpectedSearchMsgforsinglevillaREGEX = ExpectedSearchMsgforsinglevillaREGEX + selectedDuration;
                    ExpectedSearchMsgforsinglevillaREGEX = ExpectedSearchMsgforsinglevillaREGEX.Replace(" ", string.Empty);
                }
                else
                {
                    ExpectedSearchMsgforsinglevilla = @"YourSearchhasreturned(.*?)villabasedonyoursearchcriteriaof:(.*?)on(.*?)from";
                    Regex RegexSTR = new Regex(ExpectedSearchMsgforsinglevilla, RegexOptions.IgnoreCase);
                    ExpectedSearchMsgforsinglevillaREGEX = RegexSTR.Match(SearchMsgFrmPage).Value.Trim().ToString();
                    ExpectedSearchMsgforsinglevillaREGEX = ExpectedSearchMsgforsinglevillaREGEX + SelectedAIRPORT;
                    ExpectedSearchMsgforsinglevillaREGEX = ExpectedSearchMsgforsinglevillaREGEX.Replace(" ", string.Empty);
                }
                
                try
                {
                    Assert.AreEqual(ExpectedSearchMsgforsinglevillaREGEX, SearchMsgFrmPage);
                    WriteLogs("PASS : \"Search Results\" Page Opened with proper Number of Villas. : VERIFICATION");
                }
                catch (AssertFailedException ex)
                {
                    takeImage("verifySearchResultsPageOpened");
                    WriteLogs("FAIL : \"Search Results\" Page is Not Opened. : VERIFICATION");
                    WriteLogs("-----------------" + ex.Message.ToString());
                }
            }

            if (NumofVillasFOUND > 1)
            {
                string ExpectedSearchMsgforMultivilla = string.Empty;
                string ExpectedSearchMsgforMultivillaREGEX = string.Empty;
                if (SelectedAIRPORT == "Villa Only")
                {
                    ExpectedSearchMsgforMultivilla = @"YourSearchhasreturned(.*?)villasbasedonyoursearchcriteriaof:(.*?)on(.*?)for";
                    Regex RegexSTRM = new Regex(ExpectedSearchMsgforMultivilla, RegexOptions.IgnoreCase);
                    ExpectedSearchMsgforMultivillaREGEX = RegexSTRM.Match(SearchMsgFrmPage).Value.Trim().ToString();
                    ExpectedSearchMsgforMultivillaREGEX = ExpectedSearchMsgforMultivillaREGEX + selectedDuration;
                    ExpectedSearchMsgforMultivillaREGEX = ExpectedSearchMsgforMultivillaREGEX.Replace(" ", string.Empty);
                }
                else
                {
                    ExpectedSearchMsgforMultivilla = @"YourSearchhasreturned(.*?)villasbasedonyoursearchcriteriaof:(.*?)on(.*?)for(.*?)from";
                    Regex RegexSTRM = new Regex(ExpectedSearchMsgforMultivilla, RegexOptions.IgnoreCase);
                    ExpectedSearchMsgforMultivillaREGEX = RegexSTRM.Match(SearchMsgFrmPage).Value.Trim().ToString();
                    ExpectedSearchMsgforMultivillaREGEX = ExpectedSearchMsgforMultivillaREGEX + SelectedAIRPORT;
                    ExpectedSearchMsgforMultivillaREGEX = ExpectedSearchMsgforMultivillaREGEX.Replace(" ", string.Empty);
                }
              
                try
                {
                    Assert.AreEqual(ExpectedSearchMsgforMultivillaREGEX, SearchMsgFrmPage);
                    WriteLogs("PASS : \"Search Results\" Page Opened with proper Number of Villas.");
                }
                catch (AssertFailedException ex)
                {
                    takeImage("verifySearchResultsPageOpened");
                    WriteLogs("FAIL : \"Search Results\" Page is Not Opened.");
                    WriteLogs("-----------------" + ex.Message.ToString());
                }
            }

            //string Expectedforallsingle = "Your Search has returned " + NumofVillasFOUND + " villa based on your search criteria of: " + NumofADULTS + " Adult, " + NumofCHILD + " Child and " + NumofINFANTS + " Infant on " + selectedWeek + SelectedDATE + " for " + selectedDuration + " from " + SelectedAIRPORT;
            //string Expectedforallmulti = "Your Search has returned " + NumofVillasFOUND + " villas based on your search criteria of: " + NumofADULTS + " Adults, " + NumofCHILD + " Children and " + NumofINFANTS + " Infants on " + selectedWeek + SelectedDATE + " for " + selectedDuration + " from " + SelectedAIRPORT;

            //if (NumofCHILD == 0 && NumofINFANTS == 0)
            //{
            //    Expectedforallsingle = Expectedforallsingle.Replace("0 Child and 0 Infant", string.Empty);
            //    Expectedforallmulti = Expectedforallmulti.Replace("0 Child and 0 Infant", string.Empty);
            //}

            //if (NumofCHILD == 1 && NumofINFANTS == 1)
            //{
            //    Expectedforallsingle = Expectedforallsingle;
            //}

            //if (NumofCHILD > 1 && NumofINFANTS > 1)
            //{
            //    Expectedforallmulti = Expectedforallmulti;
            //}
            //if (NumofCHILD > 1 && NumofINFANTS > 0)
            //{
            //    Expectedforallmulti = Expectedforallmulti.Replace("and 0 Infant", string.Empty);
            //}


            //if (NumofVillasFOUND == 1 && NumofADULTS == 1)
            //{
            //    try
            //    {
            //        Assert.AreEqual(Expectedforallsingle, SearchMsgFrmPage);
            //        WriteLogs("PASS : \"Search Results\" Page Opened with proper Number of Villas.");
            //    }
            //    catch (AssertFailedException ex)
            //    {
            //        WriteLogs("FAIL : \"Search Results\" Page is Not Opened.");
            //        WriteLogs("-----------------" + ex.Message.ToString());
            //    }

            //}
            //else if (NumofVillasFOUND > 1 && NumofADULTS > 1)
            //{
            //    try
            //    {
            //        Assert.AreEqual(Expectedforallmulti, SearchMsgFrmPage);
            //        WriteLogs("PASS : \"Search Results\" Page Opened with proper Number of Villas.");
            //    }
            //    catch (AssertFailedException ex)
            //    {
            //        WriteLogs("FAIL : \"Search Results\" Page is Not Opened.");
            //        WriteLogs("-----------------" + ex.Message.ToString());
            //    }

            //}
            //else if (NumofVillasFOUND == 1 && NumofADULTS == 1 && NumofCHILD > 1 && NumofINFANTS > 1)
            //{
            //    try
            //    {
            //        Assert.AreEqual(Expectedforallmulti, SearchMsgFrmPage);
            //        WriteLogs("PASS : \"Search Results\" Page Opened with proper Number of Villas.");
            //    }
            //    catch (AssertFailedException ex)
            //    {
            //        WriteLogs("FAIL : \"Search Results\" Page is Not Opened.");
            //        WriteLogs("-----------------" + ex.Message.ToString());
            //    }
            //}
        }
        
        #region Properties
        public virtual verifySearchResultsPageOpened_MethodExpectedValues verifySearchResultsPageOpened_MethodExpectedValues
        {
            get
            {
                if ((this.mverifySearchResultsPageOpened_MethodExpectedValues == null))
                {
                    this.mverifySearchResultsPageOpened_MethodExpectedValues = new verifySearchResultsPageOpened_MethodExpectedValues();
                }
                return this.mverifySearchResultsPageOpened_MethodExpectedValues;
            }
        }
        
        public UIYoursearchfound60VilWindow UIYoursearchfound60VilWindow
        {
            get
            {
                if ((this.mUIYoursearchfound60VilWindow == null))
                {
                    this.mUIYoursearchfound60VilWindow = new UIYoursearchfound60VilWindow();
                }
                return this.mUIYoursearchfound60VilWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifySearchResultsPageOpened_MethodExpectedValues mverifySearchResultsPageOpened_MethodExpectedValues;
        
        private UIYoursearchfound60VilWindow mUIYoursearchfound60VilWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifySearchResultsPageOpened_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifySearchResultsPageOpened_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'MainContent_SearchMsg' pane equals 'Your Search has returned 60 villas based on your search criteria of: 
        ///2 Adults and 2 Children on Thursday 05 June 2014 for 7 nights from All London'
        /// </summary>
        public string UIMainContent_SearchMsPaneInnerText = "Your Search has returned 60 villas based on your search criteria of: \r\n2 Adults a" +
            "nd 2 Children on Thursday 05 June 2014 for 7 nights from All London";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIYoursearchfound60VilWindow : BrowserWindow
    {
        
        public UIYoursearchfound60VilWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your search found ", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your search found 60 Villa holidays");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYoursearchfound60VilDocument UIYoursearchfound60VilDocument
        {
            get
            {
                if ((this.mUIYoursearchfound60VilDocument == null))
                {
                    this.mUIYoursearchfound60VilDocument = new UIYoursearchfound60VilDocument(this);
                }
                return this.mUIYoursearchfound60VilDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYoursearchfound60VilDocument mUIYoursearchfound60VilDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIYoursearchfound60VilDocument : HtmlDocument
    {
        
        public UIYoursearchfound60VilDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your search found ", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/searchresult.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/searchresult.aspx?", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your search found 60 Villa holidays");
            #endregion
        }
        
        #region Properties
        public HtmlSpan UIMainContent_SearchMsPane
        {
            get
            {
                if ((this.mUIMainContent_SearchMsPane == null))
                {
                    this.mUIMainContent_SearchMsPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIMainContent_SearchMsPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "MainContent_SearchMsg";
                    this.mUIMainContent_SearchMsPane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Your Search has returned ", PropertyExpressionOperator.Contains));
                    this.mUIMainContent_SearchMsPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"MainContent_SearchMsg\"";
                    this.mUIMainContent_SearchMsPane.WindowTitles.Add("Your search found 60 Villa holidays");
                    #endregion
                }
                return this.mUIMainContent_SearchMsPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlSpan mUIMainContent_SearchMsPane;
        #endregion
    }
}