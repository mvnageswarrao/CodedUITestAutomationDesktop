﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.AddAmendFlightExtras.clickOKFrmErrPopup_MapClasses
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
    public partial class clickOKFrmErrPopup_Map:logWriter
    {
        
        /// <summary>
        /// clickOKFrmErrPopup_Method
        /// </summary>
        public void clickOKFrmErrPopup_Method()
        {
            #region Variable Declarations
            HtmlImage uIOKImage = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAmendFlightExtraSeleFrame.UIUntitledPageDocument.UIOKImage;
            HtmlImage uIOKImage1 = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAmendFlightExtraSeleFrame.UIUntitledPageDocument.UIOKImage1;
            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;


            try
            {
                // Mouse hover 'OK' image at (48, 24)
                Mouse.Hover(uIOKImage, new Point(48, 24));

                // Reset flag to ensure that play back stops if there is an error.
                Playback.PlaybackSettings.ContinueOnError = false;

                // Click 'OK' image
                Mouse.Click(uIOKImage1, new Point(42, 12));
                WriteLogs("PASS : \"OK\" Button clicked from Error Popup From Add/Amend Flight Extras.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("clickOKFrmErrPopup");
                WriteLogs("FAIL : Could not Click \"OK\" Button from Error Popup From Add/Amend Flight Extras.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
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
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
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
        public UIAmendFlightExtraSeleFrame UIAmendFlightExtraSeleFrame
        {
            get
            {
                if ((this.mUIAmendFlightExtraSeleFrame == null))
                {
                    this.mUIAmendFlightExtraSeleFrame = new UIAmendFlightExtraSeleFrame(this);
                }
                return this.mUIAmendFlightExtraSeleFrame;
            }
        }
        #endregion
        
        #region Fields
        private UIAmendFlightExtraSeleFrame mUIAmendFlightExtraSeleFrame;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAmendFlightExtraSeleFrame : HtmlIFrame
    {
        
        public UIAmendFlightExtraSeleFrame(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "amendFlightExtraSelection";
            this.SearchProperties[HtmlFrame.PropertyNames.Name] = "amendFlightExtraSelection";
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.AbsolutePath, "amendFlightExtra.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.PageUrl, "amendFlightExtra.aspx?refNo=", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlFrame.PropertyNames.ControlDefinition] = "name=\"amendFlightExtraSelection\" id=\"ame";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIUntitledPageDocument UIUntitledPageDocument
        {
            get
            {
                if ((this.mUIUntitledPageDocument == null))
                {
                    this.mUIUntitledPageDocument = new UIUntitledPageDocument(this);
                }
                return this.mUIUntitledPageDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIUntitledPageDocument mUIUntitledPageDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIUntitledPageDocument : HtmlDocument
    {
        
        public UIUntitledPageDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/amendFlightExtra.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/amendFlightExtra.aspx?refNo=", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlImage UIOKImage
        {
            get
            {
                if ((this.mUIOKImage == null))
                {
                    this.mUIOKImage = new HtmlImage(this);
                    #region Search Criteria
                    this.mUIOKImage.SearchProperties[HtmlImage.PropertyNames.Id] = "cmdOk";
                    this.mUIOKImage.SearchProperties[HtmlImage.PropertyNames.Name] = "cmdOk";
                    this.mUIOKImage.FilterProperties[HtmlImage.PropertyNames.Alt] = "OK";
                    this.mUIOKImage.FilterProperties[HtmlImage.PropertyNames.AbsolutePath] = "/imgs/vp/buttons/okOFF.gif";
                    this.mUIOKImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Src, "/imgs/vp/buttons/okOFF.gif", PropertyExpressionOperator.Contains));
                    this.mUIOKImage.FilterProperties[HtmlImage.PropertyNames.ControlDefinition] = "name=\"cmdOk\" title=\"OK\" id=\"cmdOk\" style";
                    this.mUIOKImage.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIOKImage;
            }
        }
        
        public HtmlImage UIOKImage1
        {
            get
            {
                if ((this.mUIOKImage1 == null))
                {
                    this.mUIOKImage1 = new HtmlImage(this);
                    #region Search Criteria
                    this.mUIOKImage1.SearchProperties[HtmlImage.PropertyNames.Id] = "cmdOkOn";
                    this.mUIOKImage1.SearchProperties[HtmlImage.PropertyNames.Name] = "cmdOkOn";
                    this.mUIOKImage1.FilterProperties[HtmlImage.PropertyNames.Alt] = "OK";
                    this.mUIOKImage1.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.AbsolutePath, "/imgs/vp/buttons/okON.gif", PropertyExpressionOperator.Contains));
                    this.mUIOKImage1.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Src, "/imgs/vp/buttons/okON.gif", PropertyExpressionOperator.Contains));
                    this.mUIOKImage1.FilterProperties[HtmlImage.PropertyNames.ControlDefinition] = "name=\"cmdOkOn\" title=\"OK\" id=\"cmdOkOn\" s";
                    this.mUIOKImage1.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIOKImage1;
            }
        }
        #endregion
        
        #region Fields
        private HtmlImage mUIOKImage;
        
        private HtmlImage mUIOKImage1;
        #endregion
    }
}
