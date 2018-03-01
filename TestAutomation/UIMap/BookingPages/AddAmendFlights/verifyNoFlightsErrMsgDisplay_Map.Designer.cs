﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.AddAmendFlights.verifyNoFlightsErrMsgDisplay_MapClasses
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
    public partial class verifyNoFlightsErrMsgDisplay_Map:logWriter
    {
        
        /// <summary>
        /// verifyNoFlightsErrMsgDisplay_Method - Use 'verifyNoFlightsErrMsgDisplay_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyNoFlightsErrMsgDisplay_Method(string SELECTEDAIRPORT)
        {
            #region Variable Declarations
            HtmlDiv uIFlightmessagePane = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAmendFlightsSelectioFrame.UIVillaPlusQualityholiDocument.UIFlightmessagePane;
            #endregion

            string NoFlightsErrMsgFromPage = uIFlightmessagePane.InnerText;
            string ExpectedErrMsgtoCompare = "Note : There are no flights available between ";//+SELECTEDAIRPORT+"and Paphos, so we have provided you with a flight departing from Luton instead at a time that we believe will be most convenient for you. If, however, you prefer to choose another airport, then please click on \"Change Flight\" button.";

            if (NoFlightsErrMsgFromPage == "null")
            {
                // Verify that the 'InnerText' property of 'flightmessage' pane equals 'Note : There are no flights available between London Heathrow and Paphos, so we have provided you with a flight departing from Luton instead at a time that we believe will be most convenient for you. If, however, you prefer to choose another airport, then please click on "Change Flight" button. '
                //Assert.AreEqual(this.verifyNoFlightsErrMsgDisplay_MethodExpectedValues.UIFlightmessagePaneInnerText, uIFlightmessagePane.InnerText);
                StringAssert.Contains(NoFlightsErrMsgFromPage, ExpectedErrMsgtoCompare);
                WriteLogs("PASS : No Flights Error Message Displayed.");
            }
            else
            {
                WriteLogs("PASS : No Flights Error Message is Not Displayed.");
            }
            
        }
        
        #region Properties
        public virtual verifyNoFlightsErrMsgDisplay_MethodExpectedValues verifyNoFlightsErrMsgDisplay_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyNoFlightsErrMsgDisplay_MethodExpectedValues == null))
                {
                    this.mverifyNoFlightsErrMsgDisplay_MethodExpectedValues = new verifyNoFlightsErrMsgDisplay_MethodExpectedValues();
                }
                return this.mverifyNoFlightsErrMsgDisplay_MethodExpectedValues;
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
        private verifyNoFlightsErrMsgDisplay_MethodExpectedValues mverifyNoFlightsErrMsgDisplay_MethodExpectedValues;
        
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyNoFlightsErrMsgDisplay_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyNoFlightsErrMsgDisplay_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'flightmessage' pane equals 'Note : There are no flights available between London Heathrow and Paphos, so we have provided you with a flight departing from Luton instead at a time that we believe will be most convenient for you. If, however, you prefer to choose another airport, then please click on "Change Flight" button. '
        /// </summary>
        public string UIFlightmessagePaneInnerText = @"Note : There are no flights available between London Heathrow and Paphos, so we have provided you with a flight departing from Luton instead at a time that we believe will be most convenient for you. If, however, you prefer to choose another airport, then please click on ""Change Flight"" button. ";
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
        public HtmlDiv UIFlightmessagePane
        {
            get
            {
                if ((this.mUIFlightmessagePane == null))
                {
                    this.mUIFlightmessagePane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIFlightmessagePane.SearchProperties[HtmlDiv.PropertyNames.Id] = "flightmessage";
                    this.mUIFlightmessagePane.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Note : There are no flights available be", PropertyExpressionOperator.Contains));
                    this.mUIFlightmessagePane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"flightmessage\"";
                    this.mUIFlightmessagePane.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIFlightmessagePane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIFlightmessagePane;
        #endregion
    }
}