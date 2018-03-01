using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.UIMap.HomePage.openBrowser_MapClasses;
using TestAutomation.UIMap.ProductPage.enterURL_MapClasses;
using TestAutomation.UIMap.ResortPage.setIE9StandardsInDeveloperTools_MapClasses;
using TestAutomation.UIMap.BalancePayment.verifyBPpgOpen_MapClasses;
using TestAutomation.UIMap.BalancePayment.verifyPayNowBtnVisible_MapClasses;
using TestAutomation.UIMap.BalancePayment.VerifyHolidayCostSection_MapClasses;
using TestAutomation.UIMap.BalancePayment.PayHistoryClasses;
using TestAutomation.UIMap.BalancePayment.VerifyPaymentHistorySection_MapClasses;
using TestAutomation.UIMap.BalancePayment.VerifyPayHistorySection_MapClasses;
using TestAutomation.UIMap.BalancePayment.VerifyHolidayDetailsSection_MapClasses;
using TestAutomation.UIMap.BalancePayment.Verifypayonlinepage_MapClasses;

namespace TestAutomation.Utility
{
    class InitiateBalancePayment
    {
        private setIE9StandardsInDeveloperTools_Map setIE9StandardsInDeveloperTools = null;
        private openBrowser_Map openBrowser = null;
        private enterURL_Map enterURL = null;
        private verifyBPpgOpen_Map verifyBPpgOpen = null;
        private verifyPayNowBtnVisible_Map verifyPayNowBtnVisible = null;
        private VerifyHolidayCostSection_Map VerifyHolidayCostSection = null;
        private VerifyPaymentHistorySection_Map VerifyPaymentHistorySection = null;
        private PayHistory_Map PayHistory = null;
        private VerifyPayHistorySection_Map VerifyPayHistorySection = null;
        private VerifyHolidayDetailsSection_Map VerifyHolidayDetailsSection = null;
        private Verifypayonlinepage_Map Verifypayonlinepage = null;


        public InitiateBalancePayment()
        {
            openBrowser = new openBrowser_Map();
        }

        public openBrowser_Map OpenBrowser_Obj
        {
            get { return openBrowser; }
            set { openBrowser = value; }
        }

        public enterURL_Map enterURL_Obj
        {
            get
            {
                if (enterURL == null)
                {
                    enterURL = new enterURL_Map();
                    enterURL.UIBlankPageWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterURL;
            }
        }

        public verifyBPpgOpen_Map verifyBPpgOpen_Obj
        {
            get
            {
                if (verifyBPpgOpen == null)
                {
                    verifyBPpgOpen = new verifyBPpgOpen_Map();
                    verifyBPpgOpen.UIVillaPlusBalancePaymWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyBPpgOpen;
            }
        }

        public verifyPayNowBtnVisible_Map verifyPayNowBtnVisible_Obj
        {
            get
            {
                if (verifyPayNowBtnVisible == null)
                {
                    verifyPayNowBtnVisible = new verifyPayNowBtnVisible_Map();
                    verifyPayNowBtnVisible.UIVillaPlusBalancePaymWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyPayNowBtnVisible;
            }
        }

        public VerifyHolidayCostSection_Map VerifyHolidayCostSection_obj
        {
            get
            {
                if (VerifyHolidayCostSection == null)
                {
                    VerifyHolidayCostSection = new VerifyHolidayCostSection_Map();
                    VerifyHolidayCostSection.UIVillaPlusBalancePaymWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return VerifyHolidayCostSection;
            }
        }

        public VerifyPaymentHistorySection_Map VerifyPaymentHistorySection_obj
        {
            get
            {
                if (VerifyPaymentHistorySection == null)
                {
                    VerifyPaymentHistorySection = new VerifyPaymentHistorySection_Map();
                    VerifyPaymentHistorySection.UIVillaPlusBalancePaymWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return VerifyPaymentHistorySection;
            }
        }

        public VerifyPayHistorySection_Map VerifyPayHistorySection_obj
        {
            get
            {
                if (VerifyPayHistorySection == null)
                {
                    VerifyPayHistorySection = new VerifyPayHistorySection_Map();
                    VerifyPayHistorySection.UIVillaPlusBalancePaymWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return VerifyPayHistorySection;
            }
        }

        public PayHistory_Map PayHistory_obj
        {
            get
            {
                if (PayHistory == null)
                {
                    PayHistory = new PayHistory_Map();
                    PayHistory.UIVillaPlusBalancePaymWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return PayHistory;
            }
        }

        public VerifyHolidayDetailsSection_Map VerifyHolidayDetailsSection_obj
        {
            get
            {
                if (VerifyHolidayDetailsSection == null)
                {
                    VerifyHolidayDetailsSection = new VerifyHolidayDetailsSection_Map();
                    VerifyHolidayDetailsSection.UIVillaPlusBalancePaymWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return VerifyHolidayDetailsSection;
            }
        }

        public Verifypayonlinepage_Map Verifypayonlinepage_obj
        {
            get
            {
                if (Verifypayonlinepage == null)
                {
                    Verifypayonlinepage = new Verifypayonlinepage_Map();
                    Verifypayonlinepage.UIVillaPlusBalancePaymWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return Verifypayonlinepage;
            }
        }


    }
}
