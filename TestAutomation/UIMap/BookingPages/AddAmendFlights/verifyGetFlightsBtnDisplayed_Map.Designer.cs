﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.AddAmendFlights.verifyGetFlightsBtnDisplayed_MapClasses
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
    public partial class verifyGetFlightsBtnDisplayed_Map:logWriter
    {
        
        /// <summary>
        /// verifyGetFlightsBtnDisplayed_Method - Use 'verifyGetFlightsBtnDisplayed_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyGetFlightsBtnDisplayed_Method()
        {
            #region Variable Declarations
            HtmlDiv uIGetflightsPane = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAmendFlightsSelectioFrame.UIVillaPlusQualityholiDocument.UIGetflightsPane;
            #endregion

            try
            {
                // Verify that the 'InnerText' property of 'Get flights' pane equals 'Get flights'
                Assert.AreEqual(this.verifyGetFlightsBtnDisplayed_MethodExpectedValues.UIGetflightsPaneInnerText, uIGetflightsPane.InnerText);
                WriteLogs("PASS : \"Get Flights\" Button is Displayed Properly.");
            }

            catch (AssertFailedException ex)
            {
                takeImage("verifyGetFlightsBtnDisplayed");
                WriteLogs("FAIL : \"Get Flights\" Button is Not displayed.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyGetFlightsBtnDisplayed_MethodExpectedValues verifyGetFlightsBtnDisplayed_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyGetFlightsBtnDisplayed_MethodExpectedValues == null))
                {
                    this.mverifyGetFlightsBtnDisplayed_MethodExpectedValues = new verifyGetFlightsBtnDisplayed_MethodExpectedValues();
                }
                return this.mverifyGetFlightsBtnDisplayed_MethodExpectedValues;
            }
        }
        
        public UIYourHolidaySummaryWiWindow UIYourHolidaySummaryWiWindow
        {
            get
            {
                if ((this.mUIYourHolidaySummaryWiWindow == null))
                {
                    this.mUIYourHolidaySummaryWiWindow = new UIYourHolidaySummaryWiWindow();
                }
                return this.mUIYourHolidaySummaryWiWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyGetFlightsBtnDisplayed_MethodExpectedValues mverifyGetFlightsBtnDisplayed_MethodExpectedValues;
        
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyGetFlightsBtnDisplayed_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyGetFlightsBtnDisplayed_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Get flights' pane equals 'Get flights'
        /// </summary>
        public string UIGetflightsPaneInnerText = "Get flights";
        
        /// <summary>
        /// Verify that the 'InnerText' property of 'Get flights' pane equals 'Get flights'
        /// </summary>
        public string UIGetflightsPaneInnerText1 = "Get flights";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIYourHolidaySummaryWiWindow : BrowserWindow
    {
        
        public UIYourHolidaySummaryWiWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your Holiday Summary", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYourHolidaySummaryDocument UIYourHolidaySummaryDocument
        {
            get
            {
                if ((this.mUIYourHolidaySummaryDocument == null))
                {
                    this.mUIYourHolidaySummaryDocument = new UIYourHolidaySummaryDocument(this);
                }
                return this.mUIYourHolidaySummaryDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYourHolidaySummaryDocument mUIYourHolidaySummaryDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIYourHolidaySummaryDocument : HtmlDocument
    {
        
        public UIYourHolidaySummaryDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your Holiday Summary", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/default.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/default.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIAmendFlightsSelectioFrame UIAmendFlightsSelectioFrame
        {
            get
            {
                if ((this.mUIAmendFlightsSelectioFrame == null))
                {
                    this.mUIAmendFlightsSelectioFrame = new UIAmendFlightsSelectioFrame(this);
                }
                return this.mUIAmendFlightsSelectioFrame;
            }
        }
        #endregion
        
        #region Fields
        private UIAmendFlightsSelectioFrame mUIAmendFlightsSelectioFrame;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAmendFlightsSelectioFrame : HtmlIFrame
    {
        
        public UIAmendFlightsSelectioFrame(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "amendFlightsSelection";
            this.SearchProperties[HtmlFrame.PropertyNames.Name] = "amendFlightsSelection";
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.AbsolutePath, "AmendFlight.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.PageUrl, "AmendFlight.aspx?refNo=", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlFrame.PropertyNames.ControlDefinition] = "name=\"amendFlightsSelection\" id=\"amendFl";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIVillaPlusQualityholiDocument UIVillaPlusQualityholiDocument
        {
            get
            {
                if ((this.mUIVillaPlusQualityholiDocument == null))
                {
                    this.mUIVillaPlusQualityholiDocument = new UIVillaPlusQualityholiDocument(this);
                }
                return this.mUIVillaPlusQualityholiDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPlusQualityholiDocument mUIVillaPlusQualityholiDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaPlusQualityholiDocument : HtmlDocument
    {
        
        public UIVillaPlusQualityholiDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/AmendFlight.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/AmendFlight.aspx?refNo=", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIGetflightsPane
        {
            get
            {
                if ((this.mUIGetflightsPane == null))
                {
                    this.mUIGetflightsPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIGetflightsPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "changeflight1";
                    this.mUIGetflightsPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Get flights";
                    this.mUIGetflightsPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "mycell cmdAmendFlight contentText11Px boldText textButtons orangeButtons";
                    this.mUIGetflightsPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = @"class=""mycell cmdAmendFlight contentText11Px boldText textButtons orangeButtons"" id=""changeflight1"" style=""float: left;"" data-flightid=""1"" data-flight=""199"" data-booking=""14680263"" data-iternid=""F!EZJ!LGW!E675o!FAO!EZY!EZY!8915!!EY!Y&amp;amp;F!EZJ!FAO!E6E9K!LGW!EZY!EZY!8916!!EY!Y"" data-airport=""LGW"" data-sessionid=""HQIYKLSReWQTXvkbuFzVsMe2"" data-departuredate=""6/7/2014 00:00:00"" data-duration=""7""";
                    this.mUIGetflightsPane.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIGetflightsPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIGetflightsPane;
        #endregion
    }
}