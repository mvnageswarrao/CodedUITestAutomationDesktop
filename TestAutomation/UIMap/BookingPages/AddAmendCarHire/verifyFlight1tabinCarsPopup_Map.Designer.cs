﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.AddAmendCarHire.verifyFlight1tabinCarsPopup_MapClasses
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
    public partial class verifyFlight1tabinCarsPopup_Map:logWriter
    {
        
        /// <summary>
        /// verifyFlight1tabinCarsPopup_Method - Use 'verifyFlight1tabinCarsPopup_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public string verifyFlight1tabinCarsPopup_Method(string DepportFRMDB, string ArrportFRMDB)
        {
            #region Variable Declarations
            HtmlHyperlink uIFlight1LondonGatwickHyperlink = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAmendCarHireFrame.UIAmendCarHireDocument.UIFlight1LondonGatwickHyperlink;
            #endregion

            string ExpectedFlt1tabdetailsFrmCarHire = "Flight1 - " + DepportFRMDB.Trim() + " - " + ArrportFRMDB.Trim();

            string Flight1tabdetailsFromPage = uIFlight1LondonGatwickHyperlink.InnerText.Trim();
            
            // Verify that the 'InnerText' property of 'Flight 1 - London Gatwick - Arrecife' link equals 'Flight 1 - London Gatwick - Arrecife'
            //Assert.AreEqual(this.verifyFlight1tabinCarsPopup_MethodExpectedValues.UIFlight1LondonGatwickHyperlinkInnerText, uIFlight1LondonGatwickHyperlink.InnerText);
            try
            {
                StringAssert.Equals(ExpectedFlt1tabdetailsFrmCarHire, Flight1tabdetailsFromPage);
               WriteLogs("PASS : Flight 1 Tab Details in Car Hire Popup are Matched with the Selected Departure and Arrival Airports.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyFlight1tabinCarsPopup");
                WriteLogs("FAIL : Flight 1 Tab Details in Car Hire Popup are NOT Matched with the Selected Departure and Arrival Airports.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

            return ExpectedFlt1tabdetailsFrmCarHire;
        }
        
        #region Properties
        public virtual verifyFlight1tabinCarsPopup_MethodExpectedValues verifyFlight1tabinCarsPopup_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyFlight1tabinCarsPopup_MethodExpectedValues == null))
                {
                    this.mverifyFlight1tabinCarsPopup_MethodExpectedValues = new verifyFlight1tabinCarsPopup_MethodExpectedValues();
                }
                return this.mverifyFlight1tabinCarsPopup_MethodExpectedValues;
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
        private verifyFlight1tabinCarsPopup_MethodExpectedValues mverifyFlight1tabinCarsPopup_MethodExpectedValues;
        
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyFlight1tabinCarsPopup_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyFlight1tabinCarsPopup_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Flight 1 - London Gatwick - Arrecife' link equals 'Flight 1 - London Gatwick - Arrecife'
        /// </summary>
        public string UIFlight1LondonGatwickHyperlinkInnerText = "Flight 1 - London Gatwick - Arrecife";
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
        public UIAmendCarHireFrame UIAmendCarHireFrame
        {
            get
            {
                if ((this.mUIAmendCarHireFrame == null))
                {
                    this.mUIAmendCarHireFrame = new UIAmendCarHireFrame(this);
                }
                return this.mUIAmendCarHireFrame;
            }
        }
        #endregion
        
        #region Fields
        private UIAmendCarHireFrame mUIAmendCarHireFrame;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAmendCarHireFrame : HtmlIFrame
    {
        
        public UIAmendCarHireFrame(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "amendCarHire";
            this.SearchProperties[HtmlFrame.PropertyNames.Name] = "amendCarHire";
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.AbsolutePath, "amendCarHire.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.PageUrl, "amendCarHire.aspx?", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlFrame.PropertyNames.ControlDefinition] = "name=\"amendCarHire\" id=\"amendCarHire\" sr";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIAmendCarHireDocument UIAmendCarHireDocument
        {
            get
            {
                if ((this.mUIAmendCarHireDocument == null))
                {
                    this.mUIAmendCarHireDocument = new UIAmendCarHireDocument(this);
                }
                return this.mUIAmendCarHireDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIAmendCarHireDocument mUIAmendCarHireDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAmendCarHireDocument : HtmlDocument
    {
        
        public UIAmendCarHireDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Amend Car Hire", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/amendCarHire.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/amendCarHire.aspx?", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIFlight1LondonGatwickHyperlink
        {
            get
            {
                if ((this.mUIFlight1LondonGatwickHyperlink == null))
                {
                    this.mUIFlight1LondonGatwickHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIFlight1LondonGatwickHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "tdATab_ACE_69_1_2";
                    this.mUIFlight1LondonGatwickHyperlink.SearchProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.InnerText, "Flight ", PropertyExpressionOperator.Contains));
                    this.mUIFlight1LondonGatwickHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.AbsolutePath, "/code_net/booking/amendCarHire.aspx", PropertyExpressionOperator.Contains));
                    this.mUIFlight1LondonGatwickHyperlink.FilterProperties.Add(new PropertyExpression(HtmlHyperlink.PropertyNames.Href, "/code_net/booking/amendCarHire.aspx?", PropertyExpressionOperator.Contains));
                    this.mUIFlight1LondonGatwickHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "id=\"tdATab_ACE_69_1_2\" href=\"#Flight_Tab";
                    this.mUIFlight1LondonGatwickHyperlink.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIFlight1LondonGatwickHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIFlight1LondonGatwickHyperlink;
        #endregion
    }
}
