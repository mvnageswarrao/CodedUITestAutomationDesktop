﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ThankYouPage.verifyFlightDetailsonThankYouPage_MapClasses
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
    public partial class verifyFlightDetailsonThankYouPage_Map:logWriter
    {
        
        /// <summary>
        /// verifyFlightDetailsonThankYouPage_Method - Use 'verifyFlightDetailsonThankYouPage_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyFlightDetailsonThankYouPage_Method(string FlightDetailsFromHSPAGE)
        {
            #region Variable Declarations
            HtmlCell uIFlightInfo1Cell = this.UIThankYouWindowsInterWindow.UIThankYouDocument.UIFlightInfo1Cell;
            #endregion

            // Verify that the 'InnerText' property of 'FlightInfo1' cell matches '        
            //
            //Flights
            //
            //Flight 1: (Monarch Airlines - Chartered)  4 Adults, 2 Children
            //
            //Sat 05 Apr 2014 
            //
            //            Departing: London Luton 06:00
            //
            //Arriving: Malaga 09:55
            //Adult  £339.06x4£1356.24
            //  
            //Sat 12 Apr 2014 
            //
            //            Departing: Malaga 10:55
            //
            //Arriving: London Luton 12:55
            //Child  £329.06x2£658.12
            //
            //
            //Total£2014.36'
            //StringAssert.Matches(uIFlightInfo1Cell.InnerText, new Regex(this.verifyFlightDetailsonThankYouPage_MethodExpectedValues.UIFlightInfo1CellInnerText));
            FlightDetailsFromHSPAGE = FlightDetailsFromHSPAGE.Replace("hrs", string.Empty);
            FlightDetailsFromHSPAGE = FlightDetailsFromHSPAGE.Replace("Flights1", "Flight1");

            string FlightDetailsFromThankYouPage = uIFlightInfo1Cell.InnerText;
            FlightDetailsFromThankYouPage = FlightDetailsFromThankYouPage.Replace("\r\n", string.Empty);
            FlightDetailsFromThankYouPage = FlightDetailsFromThankYouPage.Replace(" ", string.Empty);
            FlightDetailsFromThankYouPage = FlightDetailsFromThankYouPage.Trim();

            try
            {
                //StringAssert.Matches(FlightDetailsFromThankYouPage, new Regex(FlightDetailsFromHSPAGE));
                StringAssert.Equals(FlightDetailsFromThankYouPage, "Flights" + FlightDetailsFromHSPAGE);
                WriteLogs("PASS : Flight Details on Thank You Page are Matched with HS Page.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyFlightDetailsonThankYouPage");
                WriteLogs("FAIL : Flight Details on Thank You Page are Not Matched with HS Page.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyFlightDetailsonThankYouPage_MethodExpectedValues verifyFlightDetailsonThankYouPage_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyFlightDetailsonThankYouPage_MethodExpectedValues == null))
                {
                    this.mverifyFlightDetailsonThankYouPage_MethodExpectedValues = new verifyFlightDetailsonThankYouPage_MethodExpectedValues();
                }
                return this.mverifyFlightDetailsonThankYouPage_MethodExpectedValues;
            }
        }
        
        public UIThankYouWindowsInterWindow UIThankYouWindowsInterWindow
        {
            get
            {
                if ((this.mUIThankYouWindowsInterWindow == null))
                {
                    this.mUIThankYouWindowsInterWindow = new UIThankYouWindowsInterWindow();
                }
                return this.mUIThankYouWindowsInterWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyFlightDetailsonThankYouPage_MethodExpectedValues mverifyFlightDetailsonThankYouPage_MethodExpectedValues;
        
        private UIThankYouWindowsInterWindow mUIThankYouWindowsInterWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyFlightDetailsonThankYouPage_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyFlightDetailsonThankYouPage_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'FlightInfo1' cell matches '        
        ///
        ///Flights
        ///
        ///Flight 1: (Monarch Airlines - Chartered)  4 Adults, 2 Children
        ///
        ///Sat 05 Apr 2014 
        ///
        ///            Departing: London Luton 06:00
        ///
        ///Arriving: Malaga 09:55
        ///Adult  £339.06x4£1356.24
        ///  
        ///Sat 12 Apr 2014 
        ///
        ///            Departing: Malaga 10:55
        ///
        ///Arriving: London Luton 12:55
        ///Child  £329.06x2£658.12
        ///
        ///
        ///Total£2014.36'
        /// </summary>
        public string UIFlightInfo1CellInnerText = @"        

Flights

Flight 1: (Monarch Airlines - Chartered)  4 Adults, 2 Children

Sat 05 Apr 2014 

            Departing: London Luton 06:00

Arriving: Malaga 09:55
Adult  £339.06x4£1356.24
  
Sat 12 Apr 2014 

            Departing: Malaga 10:55

Arriving: London Luton 12:55
Child  £329.06x2£658.12


Total£2014.36";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIThankYouWindowsInterWindow : BrowserWindow
    {
        
        public UIThankYouWindowsInterWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Thank You", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Thank You");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIThankYouDocument UIThankYouDocument
        {
            get
            {
                if ((this.mUIThankYouDocument == null))
                {
                    this.mUIThankYouDocument = new UIThankYouDocument(this);
                }
                return this.mUIThankYouDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIThankYouDocument mUIThankYouDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIThankYouDocument : HtmlDocument
    {
        
        public UIThankYouDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Thank You", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/bookingstatus.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/bookingstatus.aspx?thankyou", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Thank You");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIFlightInfo1Cell
        {
            get
            {
                if ((this.mUIFlightInfo1Cell == null))
                {
                    this.mUIFlightInfo1Cell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIFlightInfo1Cell.SearchProperties[HtmlCell.PropertyNames.Id] = "FlightInfo1";
                    this.mUIFlightInfo1Cell.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "Flights", PropertyExpressionOperator.Contains));
                    this.mUIFlightInfo1Cell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "class=\"greyText\" id=\"FlightInfo1\" colSpan=\"9\"";
                    this.mUIFlightInfo1Cell.FilterProperties[HtmlCell.PropertyNames.Class] = "greyText";
                    this.mUIFlightInfo1Cell.WindowTitles.Add("Thank You");
                    #endregion
                }
                return this.mUIFlightInfo1Cell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIFlightInfo1Cell;
        #endregion
    }
}
