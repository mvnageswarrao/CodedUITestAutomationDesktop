﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ThankYouPage.verifyTotalDepositPPPThankYouPage_MapClasses
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
    public partial class verifyTotalDepositPPPThankYouPage_Map:logWriter
    {
        
        /// <summary>
        /// verifyTotalDepositPPPThankYouPage_Method - Use 'verifyTotalDepositPPPThankYouPage_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyTotalDepositPPPThankYouPage_Method(string PriceDepPPPDetailsFromHSPageRegEx)
        {
            #region Variable Declarations
            HtmlCustom uIFrmCalculateTotalCosCustom = this.UIThankYouWindowsInterWindow.UIThankYouDocument.UIIFrmTotalCostFrame.UIVillaPlusDocument.UIFrmCalculateTotalCosCustom;
            #endregion

            // Verify that the 'InnerText' property of 'frmCalculateTotalCost' custom control matches '   
            ////<![CDATA[ var theForm = document.forms['frmCalculateTotalCost']; if (!theForm) { theForm = document.frmCalculateTotalCost; } function __doPostBack(eventTarget, eventArgument) { if (!theForm.onsubmit || (theForm.onsubmit() != false)) { theForm.__EVENTTARGET.value = eventTarget; theForm.__EVENTARGUMENT.value = eventArgument; theForm.submit(); } } //]]>    //<![CDATA[ if (typeof(Sys) === 'undefined') throw new Error('ASP.NET Ajax client-side framework failed to load.'); //]]>   
            // 
            // 
            //Total Holiday Cost £2083.36
            //
            //
            //
            // 
            //Price per person (approximate) : Adult £350.56   Child £340.56 
            //
            // 
            //
            //The deposit £615.00 (£102.50 per person) is payable immediately. 
            //The balance of £1468.36 is due on 13 Jan 2014 which is 12 weeks before your departure date. 
            //Just to let you know, your deposit payment of £615.00 doesn’t include extras or car hire – just the villa and flights cost. 
            //
            // //Global Variables var getElementsID=new Array(0); var getElementsAttrib=new Array(0); if(getElementsVillaList==null) { var getElementsVillaList=new Array(0); } var cmPageID1 = ""; var cmCatID1 = ""; var cmAttributePatt1 = ""; var JSAttribute; var jsElementCat; var jsElementId; var countEle = 0; //Global Variables    //<![CDATA[ Sys.WebForms.PageRequestManager._initialize('CMtracking1$ctl00', 'frmCalculateTotalCost', [], [], [], 90, ''); //]]>  '
            string TotalDepPPPFromThankYouPage = uIFrmCalculateTotalCosCustom.InnerText;

            //StringAssert.Matches(uIFrmCalculateTotalCosCustom.InnerText, new Regex(this.verifyTotalDepositPPPThankYouPage_MethodExpectedValues.UIFrmCalculateTotalCosCustomInnerText));

            string TotalDepositPPPFromThankYouPage = uIFrmCalculateTotalCosCustom.InnerText;
            TotalDepositPPPFromThankYouPage = TotalDepositPPPFromThankYouPage.Replace("\r\n", string.Empty);
            TotalDepositPPPFromThankYouPage = TotalDepositPPPFromThankYouPage.Replace(" ", string.Empty);
            TotalDepositPPPFromThankYouPage = TotalDepositPPPFromThankYouPage.Trim();

            try
            {
                StringAssert.Equals(TotalDepositPPPFromThankYouPage, PriceDepPPPDetailsFromHSPageRegEx);
                //Assert.AreEqual(TotalDepositPPPFromThankYouPage, PriceDepPPPDetailsFromHSPageRegEx);
                WriteLogs("PASS : Total, Deposit, Price Per Person Details on Thank You Page are Matched with HS Page.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyTotalDepositPPPThankYouPage");
                WriteLogs("FAIL : Total, Deposit, Price Per Person Details on Thank You Page are Not Matched with HS Page.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyTotalDepositPPPThankYouPage_MethodExpectedValues verifyTotalDepositPPPThankYouPage_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyTotalDepositPPPThankYouPage_MethodExpectedValues == null))
                {
                    this.mverifyTotalDepositPPPThankYouPage_MethodExpectedValues = new verifyTotalDepositPPPThankYouPage_MethodExpectedValues();
                }
                return this.mverifyTotalDepositPPPThankYouPage_MethodExpectedValues;
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
        private verifyTotalDepositPPPThankYouPage_MethodExpectedValues mverifyTotalDepositPPPThankYouPage_MethodExpectedValues;
        
        private UIThankYouWindowsInterWindow mUIThankYouWindowsInterWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyTotalDepositPPPThankYouPage_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyTotalDepositPPPThankYouPage_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'frmCalculateTotalCost' custom control matches '   
        /////<![CDATA[ var theForm = document.forms['frmCalculateTotalCost']; if (!theForm) { theForm = document.frmCalculateTotalCost; } function __doPostBack(eventTarget, eventArgument) { if (!theForm.onsubmit || (theForm.onsubmit() != false)) { theForm.__EVENTTARGET.value = eventTarget; theForm.__EVENTARGUMENT.value = eventArgument; theForm.submit(); } } //]]>    //<![CDATA[ if (typeof(Sys) === 'undefined') throw new Error('ASP.NET Ajax client-side framework failed to load.'); //]]>   
        /// 
        /// 
        ///Total Holiday Cost £2083.36
        ///
        ///
        ///
        /// 
        ///Price per person (approximate) : Adult £350.56   Child £340.56 
        ///
        /// 
        ///
        ///The deposit £615.00 (£102.50 per person) is payable immediately. 
        ///The balance of £1468.36 is due on 13 Jan 2014 which is 12 weeks before your departure date. 
        ///Just to let you know, your deposit payment of £615.00 doesn’t include extras or car hire – just the villa and flights cost. 
        ///
        /// //Global Variables var getElementsID=new Array(0); var getElementsAttrib=new Array(0); if(getElementsVillaList==null) { var getElementsVillaList=new Array(0); } var cmPageID1 = ""; var cmCatID1 = ""; var cmAttributePatt1 = ""; var JSAttribute; var jsElementCat; var jsElementId; var countEle = 0; //Global Variables    //<![CDATA[ Sys.WebForms.PageRequestManager._initialize('CMtracking1$ctl00', 'frmCalculateTotalCost', [], [], [], 90, ''); //]]>  '
        /// </summary>
        public string UIFrmCalculateTotalCosCustomInnerText = @"   
//<![CDATA[ var theForm = document.forms['frmCalculateTotalCost']; if (!theForm) { theForm = document.frmCalculateTotalCost; } function __doPostBack(eventTarget, eventArgument) { if (!theForm.onsubmit || (theForm.onsubmit() != false)) { theForm.__EVENTTARGET.value = eventTarget; theForm.__EVENTARGUMENT.value = eventArgument; theForm.submit(); } } //]]>    //<![CDATA[ if (typeof(Sys) === 'undefined') throw new Error('ASP.NET Ajax client-side framework failed to load.'); //]]>   
 
 
Total Holiday Cost £2083.36



 
Price per person (approximate) : Adult £350.56   Child £340.56 

 

The deposit £615.00 (£102.50 per person) is payable immediately. 
The balance of £1468.36 is due on 13 Jan 2014 which is 12 weeks before your departure date. 
Just to let you know, your deposit payment of £615.00 doesn’t include extras or car hire – just the villa and flights cost. 

 //Global Variables var getElementsID=new Array(0); var getElementsAttrib=new Array(0); if(getElementsVillaList==null) { var getElementsVillaList=new Array(0); } var cmPageID1 = """"; var cmCatID1 = """"; var cmAttributePatt1 = """"; var JSAttribute; var jsElementCat; var jsElementId; var countEle = 0; //Global Variables    //<![CDATA[ Sys.WebForms.PageRequestManager._initialize('CMtracking1$ctl00', 'frmCalculateTotalCost', [], [], [], 90, ''); //]]>  ";
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
        public UIIFrmTotalCostFrame UIIFrmTotalCostFrame
        {
            get
            {
                if ((this.mUIIFrmTotalCostFrame == null))
                {
                    this.mUIIFrmTotalCostFrame = new UIIFrmTotalCostFrame(this);
                }
                return this.mUIIFrmTotalCostFrame;
            }
        }
        #endregion
        
        #region Fields
        private UIIFrmTotalCostFrame mUIIFrmTotalCostFrame;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIIFrmTotalCostFrame : HtmlIFrame
    {
        
        public UIIFrmTotalCostFrame(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "iFrmTotalCost";
            this.SearchProperties[HtmlFrame.PropertyNames.Name] = "iFrmTotalCost";
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.AbsolutePath, "calculateTotalCost.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.PageUrl, "calculateTotalCost.aspx?refNo=", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlFrame.PropertyNames.ControlDefinition] = "name=\"iFrmTotalCost\" id=\"iFrmTotalCost\" ";
            this.WindowTitles.Add("Thank You");
            #endregion
        }
        
        #region Properties
        public UIVillaPlusDocument UIVillaPlusDocument
        {
            get
            {
                if ((this.mUIVillaPlusDocument == null))
                {
                    this.mUIVillaPlusDocument = new UIVillaPlusDocument(this);
                }
                return this.mUIVillaPlusDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPlusDocument mUIVillaPlusDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaPlusDocument : HtmlDocument
    {
        
        public UIVillaPlusDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/calculateTotalCost.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/calculateTotalCost.aspx?refNo=", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Thank You");
            #endregion
        }
        
        #region Properties
        public HtmlCustom UIFrmCalculateTotalCosCustom
        {
            get
            {
                if ((this.mUIFrmCalculateTotalCosCustom == null))
                {
                    this.mUIFrmCalculateTotalCosCustom = new HtmlCustom(this);
                    #region Search Criteria
                    this.mUIFrmCalculateTotalCosCustom.SearchProperties["TagName"] = "FORM";
                    this.mUIFrmCalculateTotalCosCustom.SearchProperties["Id"] = "frmCalculateTotalCost";
                    this.mUIFrmCalculateTotalCosCustom.FilterProperties["ControlDefinition"] = "id=\"frmCalculateTotalCost\" style=\"backgr";
                    this.mUIFrmCalculateTotalCosCustom.WindowTitles.Add("Thank You");
                    #endregion
                }
                return this.mUIFrmCalculateTotalCosCustom;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCustom mUIFrmCalculateTotalCosCustom;
        #endregion
    }
}