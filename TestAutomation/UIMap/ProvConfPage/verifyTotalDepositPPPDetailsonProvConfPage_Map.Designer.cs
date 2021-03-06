﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProvConfPage.verifyTotalDepositPPPDetailsonProvConfPage_MapClasses
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
    public partial class verifyTotalDepositPPPDetailsonProvConfPage_Map:logWriter
    {
        
        /// <summary>
        /// verifyTotalDepositPPPDetailsonProvConfPage_Method - Use 'verifyTotalDepositPPPDetailsonProvConfPage_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyTotalDepositPPPDetailsonProvConfPage_Method(string PriceDepPPPDetailsFromHSPageRegEx, decimal ADWRATE, decimal SDEPOSIT, int NumofADULTS, int NumofCHILD, int NumofINFANTS, decimal TotalPRICE)
        {
            #region Variable Declarations
            HtmlCustom uIFrmCalculateTotalCosCustom = this.UIVillaPlusHolidayBookWindow.UIVillaPlusHolidayBookDocument.UIIFrmTotalCostFrame.UIVillaPlusDocument.UIFrmCalculateTotalCosCustom;
            #endregion

            string TotalDepositPPPFromProvConfPage = uIFrmCalculateTotalCosCustom.InnerText;
            TotalDepositPPPFromProvConfPage = TotalDepositPPPFromProvConfPage.Replace("\r\n", string.Empty);
            TotalDepositPPPFromProvConfPage = TotalDepositPPPFromProvConfPage.Replace(" ", string.Empty);

            if (NumofCHILD == 0 && NumofINFANTS == 0)
            {
                decimal TotalPriceWithSD = (TotalPRICE - ADWRATE + SDEPOSIT);
                string PriceDepPPPDetailsFromHSPagewithSD = TotalDepositPPPFromProvConfPage.ToString();
                int FindexofTotal = PriceDepPPPDetailsFromHSPagewithSD.IndexOf('£');
                int LindexofTotal = PriceDepPPPDetailsFromHSPagewithSD.IndexOf('P');
                int Findexofdeposit = PriceDepPPPDetailsFromHSPagewithSD.IndexOf("it£");
                int Lindexofdeposit = PriceDepPPPDetailsFromHSPagewithSD.IndexOf("(£");

                try
                {
                    //Assert.AreEqual(TotalDepositPPPFromProvConfPage, PriceDepPPPDetailsFromHSPAGE);
                    StringAssert.Contains(TotalDepositPPPFromProvConfPage, PriceDepPPPDetailsFromHSPagewithSD);
                    WriteLogs("PASS : Total, Deposit, Price Per Person Details on Prov Conf Page are Matched with HS Page.");
                }
                catch (AssertFailedException ex)
                {
                    takeImage("verifyTotalDepositPPPDetailsonProvConfPage");
                    WriteLogs("FAIL : Total, Deposit, Price Per Person Details on Prov Conf Page are Not Matched with HS Page.");
                    WriteLogs("-----------------" + ex.Message.ToString());
                }
            }
            else
            {
                try
                {
                    //Assert.AreEqual(TotalDepositPPPFromProvConfPage, PriceDepPPPDetailsFromHSPAGE);
                    StringAssert.Contains(TotalDepositPPPFromProvConfPage, PriceDepPPPDetailsFromHSPageRegEx);
                    WriteLogs("PASS : Total, Deposit, Price Per Person Details on Prov Conf Page are Matched with HS Page.");
                }
                catch (AssertFailedException ex)
                {
                    takeImage("verifyTotalDepositPPPDetailsonProvConfPage");
                    WriteLogs("FAIL : Total, Deposit, Price Per Person Details on Prov Conf Page are Not Matched with HS Page.");
                    WriteLogs("-----------------" + ex.Message.ToString());
                }
            }
  
        }
        
        #region Properties
        public virtual verifyTotalDepositPPPDetailsonProvConfPage_MethodExpectedValues verifyTotalDepositPPPDetailsonProvConfPage_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyTotalDepositPPPDetailsonProvConfPage_MethodExpectedValues == null))
                {
                    this.mverifyTotalDepositPPPDetailsonProvConfPage_MethodExpectedValues = new verifyTotalDepositPPPDetailsonProvConfPage_MethodExpectedValues();
                }
                return this.mverifyTotalDepositPPPDetailsonProvConfPage_MethodExpectedValues;
            }
        }
        
        public UIVillaPlusHolidayBookWindow UIVillaPlusHolidayBookWindow
        {
            get
            {
                if ((this.mUIVillaPlusHolidayBookWindow == null))
                {
                    this.mUIVillaPlusHolidayBookWindow = new UIVillaPlusHolidayBookWindow();
                }
                return this.mUIVillaPlusHolidayBookWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyTotalDepositPPPDetailsonProvConfPage_MethodExpectedValues mverifyTotalDepositPPPDetailsonProvConfPage_MethodExpectedValues;
        
        private UIVillaPlusHolidayBookWindow mUIVillaPlusHolidayBookWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyTotalDepositPPPDetailsonProvConfPage_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyTotalDepositPPPDetailsonProvConfPage_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'frmCalculateTotalCost' custom control equals '   
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
    public class UIVillaPlusHolidayBookWindow : BrowserWindow
    {
        
        public UIVillaPlusHolidayBookWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus - Holiday Booking Details", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Plus - Holiday Booking Details");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaPlusHolidayBookDocument UIVillaPlusHolidayBookDocument
        {
            get
            {
                if ((this.mUIVillaPlusHolidayBookDocument == null))
                {
                    this.mUIVillaPlusHolidayBookDocument = new UIVillaPlusHolidayBookDocument(this);
                }
                return this.mUIVillaPlusHolidayBookDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPlusHolidayBookDocument mUIVillaPlusHolidayBookDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaPlusHolidayBookDocument : HtmlDocument
    {
        
        public UIVillaPlusHolidayBookDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus - Holiday Booking Details", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/bookingstatus.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/bookingstatus.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Plus - Holiday Booking Details");
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
            this.WindowTitles.Add("Villa Plus - Holiday Booking Details");
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
            this.WindowTitles.Add("Villa Plus - Holiday Booking Details");
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
                    this.mUIFrmCalculateTotalCosCustom.WindowTitles.Add("Villa Plus - Holiday Booking Details");
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
