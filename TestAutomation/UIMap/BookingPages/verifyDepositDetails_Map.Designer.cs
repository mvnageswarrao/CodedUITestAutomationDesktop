﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.verifyDepositDetails_MapClasses
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
    using System.Configuration;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class verifyDepositDetails_Map:logWriter
    {
        
        /// <summary>
        /// verifyDepositDetails_Method - Use 'verifyDepositDetails_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public string verifyDepositDetails_Method(decimal TOTALPRICE, decimal DEPOSIT, string BALANCEDUEDATE, string BOOKDATE, string DEPDATE, decimal ADULTRATE, decimal CHILDRATE, decimal INFANTRATE,decimal ADWRATE, decimal ATOLRATE,Boolean IsPopupwithOKshown, int ADultsSelection, int ChildSelection, int InfantSELECTION, string LineTYPE, Boolean BkgstrtsfromSearchTILE)
        {
            #region Variable Declarations
            HtmlCustom mUIFrmCalculateTotalCosCustom = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIIFrmTotalCostFrame.UIVillaPlusDocument.UIFrmCalculateTotalCosCustom;
            #endregion

            // Verify that the 'InnerText' property of 'The deposit £995.80 (£248.95 per person)' cell matches 'The deposit £995.80 (£248.95 per person) is payable immediately. 
            //The balance of £704.40 is due on 28 Mar 2014 which is 12 weeks before your departure date. 
            //Just to let you know, your deposit payment of £995.80 doesn’t include extras or car hire – just the villa and flights cost. '
            //StringAssert.Matches(uIThedeposit9958024895Cell.InnerText, new Regex(this.verifyDepositDetails_MethodExpectedValues.UIThedeposit9958024895CellInnerText));
            LineTYPE = LineTYPE.Trim();
            DateTime BOOKINGDATE = Convert.ToDateTime(BOOKDATE);
            DateTime DEPARTDATE = Convert.ToDateTime(DEPDATE);
            int DiffinWeeks = Convert.ToInt32((DEPARTDATE - BOOKINGDATE).TotalDays / 7);

            string PriceDepPPPDetailsFromHSPage = mUIFrmCalculateTotalCosCustom.InnerText;

            PriceDepPPPDetailsFromHSPage = PriceDepPPPDetailsFromHSPage.Replace("\r\n", string.Empty);
            PriceDepPPPDetailsFromHSPage = PriceDepPPPDetailsFromHSPage.Replace(" ", string.Empty);
            string PriceDepPPPDetailsFromHSPageRegEx = string.Empty;
            
            if (DiffinWeeks < 12 && LineTYPE == "Villa-PK")
            {
                string regexstrFullDepPattern = string.Empty;
                if (ChildSelection != 0 && InfantSELECTION!=0)
                {
                    regexstrFullDepPattern = @"TotalHolidayCost£(.*?)Priceperperson\(approximate\):Adult£(.*?)Child£(.*?)Infant£(.*?)Thefullamountispayableasyouaredepartinginlessthan12weeks";
                }
                else if (ChildSelection == 0 && InfantSELECTION==0)
                {
                    regexstrFullDepPattern = @"TotalHolidayCost£(.*?)Priceperperson\(approximate\):Adult£(.*?)Thefullamountispayableasyouaredepartinginlessthan12weeks";
                }
                else if (ChildSelection != 0 && InfantSELECTION==0)
                {
                    regexstrFullDepPattern = @"TotalHolidayCost£(.*?)Priceperperson\(approximate\):Adult£(.*?)Child£(.*?)Thefullamountispayableasyouaredepartinginlessthan12weeks";
                }
                else if (ChildSelection == 0 && InfantSELECTION!=0)
                {
                    regexstrFullDepPattern = @"TotalHolidayCost£(.*?)Priceperperson\(approximate\):Adult£(.*?)Infant£(.*?)Thefullamountispayableasyouaredepartinginlessthan12weeks";
                }

                Regex regexstrR = new Regex(regexstrFullDepPattern, RegexOptions.IgnoreCase);
                PriceDepPPPDetailsFromHSPageRegEx = regexstrR.Match(PriceDepPPPDetailsFromHSPage).Value.Trim().ToString();
                PriceDepPPPDetailsFromHSPageRegEx = PriceDepPPPDetailsFromHSPageRegEx.Trim();
            }
            else if( DiffinWeeks >= 12 && LineTYPE == "Villa-PK")
            {
                string regexstrPartDepPattern = string.Empty;
                if (ChildSelection != 0 && InfantSELECTION != 0)
                {
                    regexstrPartDepPattern = @"TotalHolidayCost£(.*?)Priceperperson\(approximate\):Adult£(.*?)Child£(.*?)Infant£(.*?)Thedeposit£(.*?)\(£(.*?)perperson\)ispayableimmediately.Thebalanceof£(.*?)isdueon(.*?)whichis12weeksbeforeyourdeparturedate.Justtoletyouknow,yourdepositpaymentof£(.*?)doesn’tincludeextrasorcarhire(.*?)justthevillaandflightscostalongwiththeinsurancepremiumifaddedbyyou.";
                }
                else if (ChildSelection == 0 && InfantSELECTION == 0)
                {
                    //regexstrPartDepPattern = @"TotalHolidayCost£(.*?)Priceperperson\(approximate\):Adult£(.*?)Thedeposit£(.*?)\(£(.*?)perperson\)ispayableimmediately.Thebalanceof£(.*?)isdueon(.*?)whichis12weeksbeforeyourdeparturedate.Justtoletyouknow,yourdepositpaymentof£(.*?)doesn’tincludeextrasorcarhire(.*?)justthevillaandflightscostalongwiththeinsurancepremiumifaddedbyyou.";
                    regexstrPartDepPattern = @"TotalHolidayCost£(.*?)Priceperperson\(approximate\):Adult£(.*?)Thedeposit£(.*?)\(£(.*?)perperson\)ispayableimmediately.Thebalanceof£(.*?)isdueon(.*?)whichis12weeksbeforeyourdeparturedate.Justtoletyouknow,yourdepositpaymentof£(.*?)doesn’tincludeextrasorcarhire(.*?)justthevillaandflightscost.";
                }
                else if (ChildSelection != 0 && InfantSELECTION == 0)
                {
                    regexstrPartDepPattern = @"TotalHolidayCost£(.*?)Priceperperson\(approximate\):Adult£(.*?)Child£(.*?)Thedeposit£(.*?)\(£(.*?)perperson\)ispayableimmediately.Thebalanceof£(.*?)isdueon(.*?)whichis12weeksbeforeyourdeparturedate.Justtoletyouknow,yourdepositpaymentof£(.*?)doesn’tincludeextrasorcarhire(.*?)justthevillaandflightscostalongwiththeinsurancepremiumifaddedbyyou.";
                }
                else if (ChildSelection == 0 && InfantSELECTION != 0)
                {
                    regexstrPartDepPattern = @"TotalHolidayCost£(.*?)Priceperperson\(approximate\):Adult£(.*?)Infant£(.*?)Thedeposit£(.*?)\(£(.*?)perperson\)ispayableimmediately.Thebalanceof£(.*?)isdueon(.*?)whichis12weeksbeforeyourdeparturedate.Justtoletyouknow,yourdepositpaymentof£(.*?)doesn’tincludeextrasorcarhire(.*?)justthevillaandflightscostalongwiththeinsurancepremiumifaddedbyyou.";
                }

                Regex regexstrR = new Regex(regexstrPartDepPattern, RegexOptions.IgnoreCase);
                PriceDepPPPDetailsFromHSPageRegEx = regexstrR.Match(PriceDepPPPDetailsFromHSPage).Value.Trim().ToString();
                PriceDepPPPDetailsFromHSPageRegEx = PriceDepPPPDetailsFromHSPageRegEx.Trim();
            }
            else if (DiffinWeeks >= 12 && LineTYPE == "Villa-On")
            {
                string regexstrPartDepPattern = @"TotalHolidayCost£(.*?)Priceperperson\(approximate\):£(.*?)Thedeposit£(.*?)\(£(.*?)perperson\)ispayableimmediately.Thebalanceof£(.*?)isdueon(.*?)whichis12weeksbeforeyourdeparturedate.Justtoletyouknow,yourdepositpaymentof£(.*?)doesn’tincludeextrasorcarhire(.*?)justthevillaOnlyalongwiththeinsurancepremiumifaddedbyyou.";
                Regex regexstrR = new Regex(regexstrPartDepPattern, RegexOptions.IgnoreCase);
                PriceDepPPPDetailsFromHSPageRegEx = regexstrR.Match(PriceDepPPPDetailsFromHSPage).Value.Trim().ToString();
                PriceDepPPPDetailsFromHSPageRegEx = PriceDepPPPDetailsFromHSPageRegEx.Trim();
            }
            else if (DiffinWeeks < 12 && LineTYPE == "Villa-On")
            {
                string regexstrFullDepPattern = @"TotalHolidayCost£(.*?)Priceperperson\(approximate\):£(.*?)Thefullamountispayableasyouaredepartinginlessthan12weeks";
                Regex regexstrR = new Regex(regexstrFullDepPattern, RegexOptions.IgnoreCase);
                PriceDepPPPDetailsFromHSPageRegEx = regexstrR.Match(PriceDepPPPDetailsFromHSPage).Value.Trim().ToString();
                PriceDepPPPDetailsFromHSPageRegEx = PriceDepPPPDetailsFromHSPageRegEx.Trim();
            }

            int NumofAdults = 0;
            int Numofchild = 0;
            int NumofInfants = 0;
            int TotalPax = 0;

            if (BkgstrtsfromSearchTILE==true)
            {
                NumofAdults = ADultsSelection;
                Numofchild = ChildSelection;
                NumofInfants = InfantSELECTION;
                TotalPax = (NumofAdults + Numofchild);
            }
            else if (BkgstrtsfromSearchTILE == false && IsPopupwithOKshown == true)
            {
                NumofAdults = ADultsSelection;
                Numofchild = ChildSelection;
                NumofInfants = InfantSELECTION;
                TotalPax = (NumofAdults + Numofchild);
            }
            else if (BkgstrtsfromSearchTILE == false && IsPopupwithOKshown == false)
            {
                NumofAdults = Convert.ToInt16(ConfigurationManager.AppSettings["NoofAdults"].ToString());
                Numofchild = Convert.ToInt16(ConfigurationManager.AppSettings["NoofChild"].ToString());
                NumofInfants = Convert.ToInt16(ConfigurationManager.AppSettings["NoofInfants"].ToString());
                TotalPax = (NumofAdults + Numofchild);
            }
            
            
            // ExtrasTotal should be calculated by summing up all the extras selected inclusing ADW,ATOL
            decimal ExtrasTotal = (ADWRATE+ATOLRATE);
            decimal BalanceDueAmount = (TOTALPRICE - DEPOSIT);
            decimal Perpersondeposit = (DEPOSIT / TotalPax);
            decimal PerpersonAdult = (ADULTRATE + (ExtrasTotal / TotalPax));
            decimal PerpersonAdultVO = (TOTALPRICE / TotalPax);
            PerpersonAdultVO = Math.Round(PerpersonAdultVO, 2);
            decimal PerpersonChild = (CHILDRATE + (ExtrasTotal / TotalPax));
            decimal PerpersonInfant = (INFANTRATE + (ExtrasTotal / TotalPax));

            string DepositDetailsFromDBifmorethan12weeks = string.Empty;
            string DepositDetailsFromDBiflessthan12weeks = string.Empty;
            string DepositDetailsFromDBifmorethan12weeksVO = string.Empty;
            string DepositDetailsFromDBiflessthan12weeksVO = string.Empty;

            if (DiffinWeeks >= 12 && LineTYPE == "Villa-PK")
            {
                if (ChildSelection != 0 && InfantSELECTION != 0)
                {
                    DepositDetailsFromDBifmorethan12weeks = "TotalHolidayCost£" + TOTALPRICE + "Priceperperson(approximate):Adult£" + PerpersonAdult + "Child£" + PerpersonChild + "Infant£" + PerpersonInfant + "Thedeposit£" + DEPOSIT + "(£" + Perpersondeposit + "perperson)ispayableimmediately.Thebalanceof£" + BalanceDueAmount + "isdueon" + BALANCEDUEDATE + "whichis12weeksbeforeyourdeparturedate.Justtoletyouknow,yourdepositpaymentof£" + DEPOSIT + "doesn’tincludeextrasorcarhire–justthevillaandflightscostalongwiththeinsurancepremiumifaddedbyyou.";
                }
                else if (ChildSelection == 0 && InfantSELECTION == 0)
                {
                    DepositDetailsFromDBifmorethan12weeks = "TotalHolidayCost£" + TOTALPRICE + "Priceperperson(approximate):Adult£" + PerpersonAdult + "Thedeposit£" + DEPOSIT + "(£" + Perpersondeposit + "perperson)ispayableimmediately.Thebalanceof£" + BalanceDueAmount + "isdueon" + BALANCEDUEDATE + "whichis12weeksbeforeyourdeparturedate.Justtoletyouknow,yourdepositpaymentof£" + DEPOSIT + "doesn’tincludeextrasorcarhire–justthevillaandflightscostalongwiththeinsurancepremiumifaddedbyyou.";
                }
                else if (ChildSelection != 0 && InfantSELECTION == 0)
                {
                    DepositDetailsFromDBifmorethan12weeks = "TotalHolidayCost£" + TOTALPRICE + "Priceperperson(approximate):Adult£" + PerpersonAdult + "Child£" + PerpersonChild + "Thedeposit£" + DEPOSIT + "(£" + Perpersondeposit + "perperson)ispayableimmediately.Thebalanceof£" + BalanceDueAmount + "isdueon" + BALANCEDUEDATE + "whichis12weeksbeforeyourdeparturedate.Justtoletyouknow,yourdepositpaymentof£" + DEPOSIT + "doesn’tincludeextrasorcarhire–justthevillaandflightscostalongwiththeinsurancepremiumifaddedbyyou.";
                }
                else if (ChildSelection == 0 && InfantSELECTION != 0)
                {
                    DepositDetailsFromDBifmorethan12weeks = "TotalHolidayCost£" + TOTALPRICE + "Priceperperson(approximate):Adult£" + PerpersonAdult + "Infant£" + PerpersonInfant + "Thedeposit£" + DEPOSIT + "(£" + Perpersondeposit + "perperson)ispayableimmediately.Thebalanceof£" + BalanceDueAmount + "isdueon" + BALANCEDUEDATE + "whichis12weeksbeforeyourdeparturedate.Justtoletyouknow,yourdepositpaymentof£" + DEPOSIT + "doesn’tincludeextrasorcarhire–justthevillaandflightscostalongwiththeinsurancepremiumifaddedbyyou.";
                }

                DepositDetailsFromDBifmorethan12weeks = DepositDetailsFromDBifmorethan12weeks.Replace(" ", string.Empty).Trim();
            }
            else if (DiffinWeeks < 12 && LineTYPE == "Villa-PK")
            {            
                if (ChildSelection != 0 && InfantSELECTION != 0)
                {
                    DepositDetailsFromDBiflessthan12weeks = "TotalHolidayCost£" + TOTALPRICE + "Priceperperson(approximate):Adult£" + PerpersonAdult + "Child£" + PerpersonChild +"Infant£"+PerpersonInfant+"Thefullamountispayableasyouaredepartinginlessthan12weeks";
                }
                else if (ChildSelection == 0 && InfantSELECTION == 0)
                {
                    DepositDetailsFromDBiflessthan12weeks = "TotalHolidayCost£" + TOTALPRICE + "Priceperperson(approximate):Adult£" + PerpersonAdult + "Thefullamountispayableasyouaredepartinginlessthan12weeks";
                }
                else if (ChildSelection != 0 && InfantSELECTION == 0)
                {
                    DepositDetailsFromDBiflessthan12weeks = "TotalHolidayCost£" + TOTALPRICE + "Priceperperson(approximate):Adult£" + PerpersonAdult + "Child£" + PerpersonChild + "Thefullamountispayableasyouaredepartinginlessthan12weeks";
                }
                else if (ChildSelection == 0 && InfantSELECTION != 0)
                {
                    DepositDetailsFromDBiflessthan12weeks = "TotalHolidayCost£" + TOTALPRICE + "Priceperperson(approximate):Adult£" + PerpersonAdult + "Infant£" + PerpersonInfant + "Thefullamountispayableasyouaredepartinginlessthan12weeks";
                }

                DepositDetailsFromDBiflessthan12weeks = DepositDetailsFromDBiflessthan12weeks.Replace(" ", string.Empty).Trim();
            }
            else if (DiffinWeeks >= 12 && LineTYPE != "Villa-PK")
            {
                DepositDetailsFromDBifmorethan12weeksVO = "TotalHolidayCost£" + TOTALPRICE + "Priceperperson(approximate):£" + PerpersonAdultVO + "Thedeposit£" + DEPOSIT + "(£" + Perpersondeposit + "perperson)ispayableimmediately.Thebalanceof£" + BalanceDueAmount + "isdueon" + BALANCEDUEDATE + "whichis12weeksbeforeyourdeparturedate.Justtoletyouknow,yourdepositpaymentof£" + DEPOSIT + "doesn’tincludeextrasorcarhire-justthevillaOnlyalongwiththeinsurancepremiumifaddedbyyou.";
                DepositDetailsFromDBifmorethan12weeksVO = DepositDetailsFromDBifmorethan12weeksVO.Replace(" ", string.Empty).Trim();
            }
            else if (DiffinWeeks < 12 && LineTYPE != "Villa-PK")
            {
                DepositDetailsFromDBiflessthan12weeksVO = "TotalHolidayCost£" + TOTALPRICE + "Priceperperson(approximate):£" + PerpersonAdultVO + "Thefullamountispayableasyouaredepartinginlessthan12weeks";
                DepositDetailsFromDBiflessthan12weeksVO = DepositDetailsFromDBiflessthan12weeksVO.Replace(" ", string.Empty).Trim();
            }

            try
            {
                if (DiffinWeeks >= 12 && LineTYPE == "Villa-PK")
                {
                    StringAssert.Equals(PriceDepPPPDetailsFromHSPageRegEx, DepositDetailsFromDBifmorethan12weeks);
                    WriteLogs("PASS : Deposit Text is Matched.");
                }
                else if (DiffinWeeks < 12 && LineTYPE == "Villa-PK")
                {
                    StringAssert.Equals(PriceDepPPPDetailsFromHSPageRegEx, DepositDetailsFromDBiflessthan12weeks);
                    WriteLogs("PASS : FULL PAYMENT Text is Matched.");
                }
                else if (DiffinWeeks >= 12 && LineTYPE == "Villa-On")
                {
                    StringAssert.Equals(PriceDepPPPDetailsFromHSPageRegEx, DepositDetailsFromDBifmorethan12weeksVO);
                    WriteLogs("PASS : Deposit Text For Villa Only Booking is Matched.");
                }
                else if (DiffinWeeks < 12 && LineTYPE == "Villa-On")
                {
                    StringAssert.Equals(PriceDepPPPDetailsFromHSPageRegEx, DepositDetailsFromDBiflessthan12weeksVO);
                    WriteLogs("PASS : FULL PAYMENT Text For Villa Only Booking is Matched.");
                }
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyDepositDetails");
                WriteLogs("FAIL : Depost Text is Not Matched.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

            return PriceDepPPPDetailsFromHSPageRegEx;
        }
        
        #region Properties
        public virtual verifyDepositDetails_MethodExpectedValues verifyDepositDetails_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyDepositDetails_MethodExpectedValues == null))
                {
                    this.mverifyDepositDetails_MethodExpectedValues = new verifyDepositDetails_MethodExpectedValues();
                }
                return this.mverifyDepositDetails_MethodExpectedValues;
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
        private verifyDepositDetails_MethodExpectedValues mverifyDepositDetails_MethodExpectedValues;
        
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyDepositDetails_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyDepositDetails_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'frmCalculateTotalCost' custom control contains '   
        /////<![CDATA[ var theForm = document.forms['frmCalculateTotalCost']; if (!theForm) { theForm = document.frmCalculateTotalCost; } function __doPostBack(eventTarget, eventArgument) { if (!theForm.onsubmit || (theForm.onsubmit() != false)) { theForm.__EVENTTARGET.value = eventTarget; theForm.__EVENTARGUMENT.value = eventArgument; theForm.submit(); } } //]]>    //<![CDATA[ if (typeof(Sys) === 'undefined') throw new Error('ASP.NET Ajax client-side framework failed to load.'); //]]>   
        /// 
        /// 
        ///Total Holiday Cost £2736.64
        ///
        ///
        ///
        /// 
        ///Price per person (approximate) : Adult £699.16   Child £669.16 
        ///
        /// 
        ///
        ///The deposit £2050.92 (£512.73 per person) is payable immediately. 
        ///The balance of £685.72 is due on 28 May 2014 which is 12 weeks before your departure date. 
        ///Just to let you know, your deposit payment of £2050.92 doesn’t include extras or car hire – just the villa and flights cost. 
        ///
        /// //Global Variables var getElementsID=new Array(0); var getElementsAttrib=new Array(0); if(getElementsVillaList==null) { var getElementsVillaList=new Array(0); } var cmPageID1 = ""; var cmCatID1 = ""; var cmAttributePatt1 = ""; var JSAttribute; var jsElementCat; var jsElementId; var countEle = 0; //Global Variables    //<![CDATA[ Sys.WebForms.PageRequestManager._initialize('CMtracking1$ctl00', 'frmCalculateTotalCost', [], [], [], 90, ''); //]]>  cmCreateShopAction5Tag("916","Villa Ibiscus","1","2736.64","CY-STD-S","C=Cyprus|D=Cyprus|R=Polis-_-20140820-_-20131213-_-250-_-7-_-Wed-_-OCC=4|Bed=2|Bath=2-_-A=2|C=2|I=0-_-Not Required-_--_--_-1000-_-26 x 13-_--_-");cmDisplayShop5s();'
        /// </summary>
        public string UIFrmCalculateTotalCosCustomInnerText = "   \r\n//<![CDATA[ var theForm = document.forms[\'frmCalculateTotalCost\']; if (!theF" +
            "orm) { theForm = document.frmCalculateTotalCost; } function __doPostBack(eventTa" +
            "rget, eventArgument) { if (!theForm.onsubmit || (theForm.onsubmit() != false)) {" +
            " theForm.__EVENTTARGET.value = eventTarget; theForm.__EVENTARGUMENT.value = even" +
            "tArgument; theForm.submit(); } } //]]>    //<![CDATA[ if (typeof(Sys) === \'undef" +
            "ined\') throw new Error(\'ASP.NET Ajax client-side framework failed to load.\'); //" +
            "]]>   \r\n \r\n \r\nTotal Holiday Cost £2736.64\r\n\r\n\r\n\r\n \r\nPrice per person (approximat" +
            "e) : Adult £699.16   Child £669.16 \r\n\r\n \r\n\r\nThe deposit £2050.92 (£512.73 per pe" +
            "rson) is payable immediately. \r\nThe balance of £685.72 is due on 28 May 2014 whi" +
            "ch is 12 weeks before your departure date. \r\nJust to let you know, your deposit " +
            "payment of £2050.92 doesn’t include extras or car hire – just the villa and flig" +
            "hts cost. \r\n\r\n //Global Variables var getElementsID=new Array(0); var getElement" +
            "sAttrib=new Array(0); if(getElementsVillaList==null) { var getElementsVillaList=" +
            "new Array(0); } var cmPageID1 = \"\"; var cmCatID1 = \"\"; var cmAttributePatt1 = \"\"" +
            "; var JSAttribute; var jsElementCat; var jsElementId; var countEle = 0; //Global" +
            " Variables    //<![CDATA[ Sys.WebForms.PageRequestManager._initialize(\'CMtrackin" +
            "g1$ctl00\', \'frmCalculateTotalCost\', [], [], [], 90, \'\'); //]]>  cmCreateShopActi" +
            "on5Tag(\"916\",\"Villa Ibiscus\",\"1\",\"2736.64\",\"CY-STD-S\",\"C=Cyprus|D=Cyprus|R=Polis" +
            "-_-20140820-_-20131213-_-250-_-7-_-Wed-_-OCC=4|Bed=2|Bath=2-_-A=2|C=2|I=0-_-Not " +
            "Required-_--_--_-1000-_-26 x 13-_--_-\");cmDisplayShop5s();";
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
            this.FilterProperties[HtmlFrame.PropertyNames.AbsolutePath] = "calculateTotalCost.aspx";
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.PageUrl, "calculateTotalCost.aspx?refNo=", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlFrame.PropertyNames.ControlDefinition] = "name=\"iFrmTotalCost\" id=\"iFrmTotalCost\" ";
            this.WindowTitles.Add("Your Holiday Summary");
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
            this.WindowTitles.Add("Your Holiday Summary");
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
                    this.mUIFrmCalculateTotalCosCustom.WindowTitles.Add("Your Holiday Summary");
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
