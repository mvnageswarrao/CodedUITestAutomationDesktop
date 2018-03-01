﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ThankYouPage.verifyBookingRefTextDisplay_MapClasses
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
    public partial class verifyBookingRefTextDisplay_Map:logWriter
    {
        
        /// <summary>
        /// verifyBookingRefTextDisplay_Method - Use 'verifyBookingRefTextDisplay_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyBookingRefTextDisplay_Method(string BOOKINGID, Boolean IsPhoneBtnCLICKED, Boolean IsPayOnlineBtnAVAIAL, string LineTYPE)
        {
            #region Variable Declarations
            HtmlCell uIThankyouforchoosingVCell = this.UIThankYouWindowsInterWindow.UIThankYouDocument.UIMainContentsCellCell.UIItemTable.UIThankyouforchoosingVCell;
            #endregion

            // Verify that the 'InnerText' property of 'Thank you for choosing Villa Plus. Your' cell matches 'Thank you for choosing Villa Plus. Your quote reference number is E001D1. Please find below a copy of your provisional holiday confirmation.
            // A copy of this will be sent to your email. '
            //StringAssert.Matches(uIThankyouforchoosingVCell.InnerText, new Regex(this.verifyBookingRefTextDisplay_MethodExpectedValues.UIThankyouforchoosingVCellInnerText));

            string BookingRefTextfromThankYouPage = uIThankyouforchoosingVCell.InnerText;
            BookingRefTextfromThankYouPage = BookingRefTextfromThankYouPage.Replace("\r\n", string.Empty);
            BookingRefTextfromThankYouPage = BookingRefTextfromThankYouPage.Replace(" ", string.Empty);
            BookingRefTextfromThankYouPage = BookingRefTextfromThankYouPage.Trim();

            int Bookingid = Convert.ToInt32(BOOKINGID);

            string HexBookingRef = Bookingid.ToString("x").ToUpper();

            string BookingRefTextwithDBvalue = string.Empty;
            LineTYPE = LineTYPE.Trim();

            if (IsPayOnlineBtnAVAIAL == true && IsPhoneBtnCLICKED == false && LineTYPE == "Villa-On")
            {
                BookingRefTextwithDBvalue = "ThankyouforchoosingVillaPlus.YourBookingreferencenumberis" + HexBookingRef + ".PleasefindbelowacopyofyourHolidayconfirmation.Acopyofthiswillbesenttoyouremail.";
            }
            else if (IsPayOnlineBtnAVAIAL == true && IsPhoneBtnCLICKED == false && LineTYPE == "Villa-PK")
            {
                BookingRefTextwithDBvalue = "ThankyouforchoosingVillaPlus.YourBookingreferencenumberis" + HexBookingRef + ".PleasefindbelowacopyofyourHolidayconfirmation.Acopyofthiswillbesenttoyouremail.";
            }
            else if (IsPayOnlineBtnAVAIAL == true && IsPhoneBtnCLICKED == true && LineTYPE == "Villa-PK")
            {
                BookingRefTextwithDBvalue = "ThankyouforchoosingVillaPlus.Yourquotereferencenumberis" + HexBookingRef + ".Pleasefindbelowacopyofyourprovisionalholidayconfirmation.Acopyofthiswillbesenttoyouremail.";
            }
            else if (IsPayOnlineBtnAVAIAL == true && IsPhoneBtnCLICKED == true && LineTYPE == "Villa-On")
            {
                BookingRefTextwithDBvalue = "ThankyouforchoosingVillaPlus.Yourquotereferencenumberis" + HexBookingRef + ".Pleasefindbelowacopyofyourprovisionalholidayconfirmation.Acopyofthiswillbesenttoyouremail.";
            }
            

            try
            {
                StringAssert.Equals(BookingRefTextfromThankYouPage,BookingRefTextwithDBvalue);
                //StringAssert.Matches(BookingRefTextfromThankYouPage, new Regex(BookingRefTextwithDBvalue));
                WriteLogs("PASS : Thank You message with Booking Ref is displayed properly on Thank You Page. : VERIFICATION");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyBookingRefTextDisplay");
                WriteLogs("FAIL : Thank You message with Booking Ref is not displayed. : VERIFICATION");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

        }
        
        #region Properties
        public virtual verifyBookingRefTextDisplay_MethodExpectedValues verifyBookingRefTextDisplay_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyBookingRefTextDisplay_MethodExpectedValues == null))
                {
                    this.mverifyBookingRefTextDisplay_MethodExpectedValues = new verifyBookingRefTextDisplay_MethodExpectedValues();
                }
                return this.mverifyBookingRefTextDisplay_MethodExpectedValues;
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
        private verifyBookingRefTextDisplay_MethodExpectedValues mverifyBookingRefTextDisplay_MethodExpectedValues;
        
        private UIThankYouWindowsInterWindow mUIThankYouWindowsInterWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyBookingRefTextDisplay_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyBookingRefTextDisplay_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Thank you for choosing Villa Plus. Your' cell matches 'Thank you for choosing Villa Plus. Your quote reference number is E001D1. Please find below a copy of your provisional holiday confirmation.
        /// A copy of this will be sent to your email. '
        /// </summary>
        public string UIThankyouforchoosingVCellInnerText = "Thank you for choosing Villa Plus. Your quote reference number is E001D1. Please " +
            "find below a copy of your provisional holiday confirmation.\r\n A copy of this wil" +
            "l be sent to your email. ";
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
        public UIMainContentsCellCell UIMainContentsCellCell
        {
            get
            {
                if ((this.mUIMainContentsCellCell == null))
                {
                    this.mUIMainContentsCellCell = new UIMainContentsCellCell(this);
                }
                return this.mUIMainContentsCellCell;
            }
        }
        #endregion
        
        #region Fields
        private UIMainContentsCellCell mUIMainContentsCellCell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIMainContentsCellCell : HtmlCell
    {
        
        public UIMainContentsCellCell(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlCell.PropertyNames.Id] = "mainContentsCell";
            this.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "Thank you for choosing Villa Plus.", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "width=\"100%\" id=\"mainContentsCell\" vAlign=\"top\" style=\"background-color: rgb(255," +
                " 255, 255);\"";
            this.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "2";
            this.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
            this.WindowTitles.Add("Thank You");
            #endregion
        }
        
        #region Properties
        public UIItemTable UIItemTable
        {
            get
            {
                if ((this.mUIItemTable == null))
                {
                    this.mUIItemTable = new UIItemTable(this);
                }
                return this.mUIItemTable;
            }
        }
        #endregion
        
        #region Fields
        private UIItemTable mUIItemTable;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemTable : HtmlTable
    {
        
        public UIItemTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "Thank you for choosing Villa Plus.", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "width=\"100%\" border=\"0\" cellSpacing=\"0\" cellPadding=\"0\"";
            this.WindowTitles.Add("Thank You");
            #endregion
        }
        
        #region Properties
        public HtmlCell UIThankyouforchoosingVCell
        {
            get
            {
                if ((this.mUIThankyouforchoosingVCell == null))
                {
                    this.mUIThankyouforchoosingVCell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIThankyouforchoosingVCell.SearchProperties.Add(new PropertyExpression(HtmlCell.PropertyNames.InnerText, "Thank you for choosing Villa Plus. ", PropertyExpressionOperator.Contains));
                    this.mUIThankyouforchoosingVCell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "class=\"greyText\"";
                    this.mUIThankyouforchoosingVCell.FilterProperties[HtmlCell.PropertyNames.Class] = "greyText";
                    this.mUIThankyouforchoosingVCell.WindowTitles.Add("Thank You");
                    #endregion
                }
                return this.mUIThankyouforchoosingVCell;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mUIThankyouforchoosingVCell;
        #endregion
    }
}