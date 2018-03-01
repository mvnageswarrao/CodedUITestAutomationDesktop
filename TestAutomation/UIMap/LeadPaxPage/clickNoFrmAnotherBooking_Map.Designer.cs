﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.LeadPaxPage.clickNoFrmAnotherBooking_MapClasses
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
    public partial class clickNoFrmAnotherBooking_Map:logWriter
    {
        
        /// <summary>
        /// clickNoFrmAnotherBooking_Method
        /// </summary>
        public void clickNoFrmAnotherBooking_Method()
        {
            #region Variable Declarations
            HtmlImage uIImgsvpcommoncurveBotImage = this.UIAllocateLeadPassengeWindow.UIAllocateLeadPassengeDocument.UIDvAlertBoxPane.UIImgsvpcommoncurveBotImage;
            HtmlImage uINOImage = this.UIAllocateLeadPassengeWindow.UIAllocateLeadPassengeDocument.UINOImage;
            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover '/imgs/vp/common/curveBottomR_BB.gif' image at (17, 2)
            Mouse.Hover(uIImgsvpcommoncurveBotImage, new Point(17, 2));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'No' image
            Mouse.Click(uINOImage, new Point(26, 13));
            WriteLogs("PASS : Clicked No button and Continued with the Current Booking.");
        }
        
        #region Properties
        public UIAllocateLeadPassengeWindow UIAllocateLeadPassengeWindow
        {
            get
            {
                if ((this.mUIAllocateLeadPassengeWindow == null))
                {
                    this.mUIAllocateLeadPassengeWindow = new UIAllocateLeadPassengeWindow();
                }
                return this.mUIAllocateLeadPassengeWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIAllocateLeadPassengeWindow mUIAllocateLeadPassengeWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAllocateLeadPassengeWindow : BrowserWindow
    {
        
        public UIAllocateLeadPassengeWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Allocate Lead Passenger", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Allocate Lead Passenger");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIAllocateLeadPassengeDocument UIAllocateLeadPassengeDocument
        {
            get
            {
                if ((this.mUIAllocateLeadPassengeDocument == null))
                {
                    this.mUIAllocateLeadPassengeDocument = new UIAllocateLeadPassengeDocument(this);
                }
                return this.mUIAllocateLeadPassengeDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIAllocateLeadPassengeDocument mUIAllocateLeadPassengeDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAllocateLeadPassengeDocument : HtmlDocument
    {
        
        public UIAllocateLeadPassengeDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Allocate Lead Passenger", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/allocateLeadPax.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/allocateLeadPax.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Allocate Lead Passenger");
            #endregion
        }
        
        #region Properties
        public UIDvAlertBoxPane UIDvAlertBoxPane
        {
            get
            {
                if ((this.mUIDvAlertBoxPane == null))
                {
                    this.mUIDvAlertBoxPane = new UIDvAlertBoxPane(this);
                }
                return this.mUIDvAlertBoxPane;
            }
        }
        
        public HtmlImage UINOImage
        {
            get
            {
                if ((this.mUINOImage == null))
                {
                    this.mUINOImage = new HtmlImage(this);
                    #region Search Criteria
                    this.mUINOImage.SearchProperties[HtmlImage.PropertyNames.Id] = "cmdNo";
                    this.mUINOImage.SearchProperties[HtmlImage.PropertyNames.Name] = "cmdNo";
                    this.mUINOImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Alt, "No", PropertyExpressionOperator.Contains));
                    this.mUINOImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.AbsolutePath, "/imgs/vp/buttons/noOFF.gif", PropertyExpressionOperator.Contains));
                    this.mUINOImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Src, "/imgs/vp/buttons/noOFF.gif", PropertyExpressionOperator.Contains));
                    this.mUINOImage.FilterProperties[HtmlImage.PropertyNames.ControlDefinition] = "name=\"cmdNo\" id=\"cmdNo\" style=\"visibilit";
                    this.mUINOImage.WindowTitles.Add("Allocate Lead Passenger");
                    #endregion
                }
                return this.mUINOImage;
            }
        }
        #endregion
        
        #region Fields
        private UIDvAlertBoxPane mUIDvAlertBoxPane;
        
        private HtmlImage mUINOImage;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDvAlertBoxPane : HtmlDiv
    {
        
        public UIDvAlertBoxPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "dvAlertBox";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Another Booking Found", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "alertOuter ";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"alertOuter \" id=\"dvAlertBox\" style=\"left: 443px; top: 231px; width: 500px;" +
                " visibility: visible; position: absolute; z-index: 2000; background-color: rgb(2" +
                "19, 237, 243);\"";
            this.WindowTitles.Add("Allocate Lead Passenger");
            #endregion
        }
        
        #region Properties
        public HtmlImage UIImgsvpcommoncurveBotImage
        {
            get
            {
                if ((this.mUIImgsvpcommoncurveBotImage == null))
                {
                    this.mUIImgsvpcommoncurveBotImage = new HtmlImage(this);
                    #region Search Criteria
                    this.mUIImgsvpcommoncurveBotImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.AbsolutePath, "/imgs/vp/common/curveBottomR_BB.gif", PropertyExpressionOperator.Contains));
                    this.mUIImgsvpcommoncurveBotImage.FilterProperties.Add(new PropertyExpression(HtmlImage.PropertyNames.Src, "/imgs/vp/common/curveBottomR_BB.gif", PropertyExpressionOperator.Contains));
                    this.mUIImgsvpcommoncurveBotImage.FilterProperties[HtmlImage.PropertyNames.ControlDefinition] = "width=\"18\" height=\"19\" alt=\"\" src=\"/imgs";
                    this.mUIImgsvpcommoncurveBotImage.WindowTitles.Add("Allocate Lead Passenger");
                    #endregion
                }
                return this.mUIImgsvpcommoncurveBotImage;
            }
        }
        #endregion
        
        #region Fields
        private HtmlImage mUIImgsvpcommoncurveBotImage;
        #endregion
    }
}
