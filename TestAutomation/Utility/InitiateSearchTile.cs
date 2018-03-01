using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestAutomation.UIMap.ProductPage.openBrowser_MapClasses;
using TestAutomation.UIMap.ProductPage.enterURL_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyIncompleteBookingpopupDisplay_MapClasses;
using TestAutomation.UIMap.SearchTile.clickNOBtnFrmIncompletePopup_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyDestinationListBox_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyDurationListBox_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyAdultListBox_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyChildListBox_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyInfantListbox_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyAirportListBox_MapClasses;
using TestAutomation.UIMap.SearchTile.clickCalenderIcon_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyCalenderDisplay_MapClasses;
using TestAutomation.UIMap.SearchTile.selectMonthFrmCalender_MapClasses;
using TestAutomation.UIMap.SearchTile.selectaDateFrmCalender_MapClasses;
using TestAutomation.UIMap.SearchTile.clickSearchBtn_MapClasses;
using TestAutomation.UIMap.SearchTile.verifySearchResultsPageOpened_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyIncorrectInputPopupDisplayed_MapClasses;
using TestAutomation.UIMap.SearchTile.clickOKFrmIncorrectPopup_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyNoVillasMsgDisplayed_MapClasses;
using TestAutomation.UIMap.SearchTile.clickBookVillaFlightLink_MapClasses;
using TestAutomation.UIMap.SearchTile.clickVillaNFlightsLinkFrmSearchResultsPage_MapClasses;
using TestAutomation.UIMap.SearchTile.clickBookVillaOnlyLINKFrmSRPage_MapClasses;
using TestAutomation.UIMap.SearchTile.clickBookVillaOnlyBTNFrmSRPage_MapClasses;
using TestAutomation.UIMap.SearchTile.clickVillaNameTabfromSearchTile_MapClasses;
using TestAutomation.UIMap.SearchTile.enterAnyCharInVillaNameTxtBox_MapClasses;
using TestAutomation.UIMap.SearchTile.selectaVillaFromList_MapClasses;
using TestAutomation.UIMap.SearchTile.clickViewVillaFrmSearchTile_MapClasses;
using TestAutomation.UIMap.SearchTile.clickViewVillaBtnFrmSearchResultsPage_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyProductPageOpened_MapClasses;
using TestAutomation.UIMap.ProductPage.clickVillaNFlightsBtnFrmProductPage_MapClasses;
using TestAutomation.UIMap.ProductPage.clickBookVillaOnlyBtnFrmProductPage_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyHSPKOpened_MapClasses;
using TestAutomation.UIMap.VillaOnlyPriceCheck.GetVillaOnlyPriceFrmProductPage_mapclasses;
//using TestAutomation.UIMap.VillaOnlyPriceCheck.Dummy_MapClasses;
using TestAutomation.UIMap.VillaOnlyPriceCheck.getVillaNameFrmSRPage_MapClasses;
using TestAutomation.UIMap.VillaOnlyPriceCheck.getVillaOnlyPriceFrmSRPage_MapClasses;
using TestAutomation.UIMap.VillaOnlyPriceCheck.getVOPriceFrmHSPage_MapClasses;
//using TestAutomation.UIMap.VillaOnlyPriceCheck.GetVillaOnlyPriceFrmProductPage_mapclasses;


namespace TestAutomation.Utility
{
    public class InitiateSearchTile
    {
        private openBrowser_Map openBrowser = null;
        private enterURL_Map enterURL = null;
        private verifyIncompleteBookingpopupDisplay_Map verifyIncompleteBookingpopupDisplay = null;
        private clickNOBtnFrmIncompletePopup_Map clickNOBtnFrmIncompletePopup = null;
        private verifyDestinationListBox_Map verifyDestinationListBox = null;
        private verifyDurationListBox_Map verifyDurationListBox = null;
        private verifyAdultListBox_Map verifyAdultListBox = null;
        private verifyChildListBox_Map verifyChildListBox = null;
        private verifyInfantListbox_Map verifyInfantListbox = null;
        private verifyAirportListBox_Map verifyAirportListBox = null;
        private clickCalenderIcon_Map clickCalenderIcon = null;
        private verifyCalenderDisplay_Map verifyCalenderDisplay = null;
        private selectMonthFrmCalender_Map selectMonthFrmCalender = null;
        private selectaDateFrmCalender_Map selectaDateFrmCalender = null;
        private clickSearchBtn_Map clickSearchBtn = null;
        private verifySearchResultsPageOpened_Map verifySearchResultsPageOpened = null;
        private verifyIncorrectInputPopupDisplayed_Map verifyIncorrectInputPopupDisplayed = null;
        private clickOKFrmIncorrectPopup_Map clickOKFrmIncorrectPopup = null;
        private verifyNoVillasMsgDisplayed_Map verifyNoVillasMsgDisplayed = null;
        private clickVillaNameTabfromSearchTile_Map clickVillaNameTabfromSearchTile = null;
        private enterAnyCharInVillaNameTxtBox_Map enterAnyCharInVillaNameTxtBox = null;
        private selectaVillaFromList_Map selectaVillaFromList = null;
        private clickViewVillaFrmSearchTile_Map clickViewVillaFrmSearchTile = null;
        private verifyProductPageOpened_Map verifyProductPageOpened = null;
        private clickVillaNFlightsLinkFrmSearchResultsPage_Map clickVillaNFlightsLinkFrmSearchResultsPage = null;
        private clickBookVillaFlightLink_Map clickBookVillaFlightLink = null;
        private clickBookVillaOnlyLINKFrmSRPage_Map clickBookVillaOnlyLINKFrmSRPage = null;
        private clickBookVillaOnlyBTNFrmSRPage_Map clickBookVillaOnlyBTNFrmSRPage = null;
        private clickViewVillaBtnFrmSearchResultsPage_Map clickViewVillaBtnFrmSearchResultsPage = null;
        private clickVillaNFlightsBtnFrmProductPage_Map clickVillaNFlightsBtnFrmProductPage = null;
        private clickBookVillaOnlyBtnFrmProductPage_Map clickBookVillaOnlyBtnFrmProductPage = null;
        private verifyHSPKOpened_Map verifyHSPKOpened = null; 
		private getVOPriceFrmHSPage_Map getVOPriceFrmHSPage = null;
		private getVillaNameFrmSRPage_Map getVillaNameFrmSRPage = null;
        private getVillaOnlyPriceFrmSRPage_Map getVillaOnlyPriceFrmSRPage = null;
        private GetVillaOnlyPriceFrmProductPage_map GetVillaOnlyPriceFrmProductPage = null;
        //private Dummy_Map Dummy = null;
        
        public InitiateSearchTile()
        {
            openBrowser = new openBrowser_Map();
        }
        public openBrowser_Map openBrowser_Obj
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
        public verifyIncompleteBookingpopupDisplay_Map verifyIncompleteBookingpopupDisplay_Obj
        {
            get
            {
                if (verifyIncompleteBookingpopupDisplay == null)
                {
                    verifyIncompleteBookingpopupDisplay = new verifyIncompleteBookingpopupDisplay_Map();
                    verifyIncompleteBookingpopupDisplay.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyIncompleteBookingpopupDisplay;
            }
        }
        public clickNOBtnFrmIncompletePopup_Map clickNOBtnFrmIncompletePopup_Obj
        {
            get
            {
                if (clickNOBtnFrmIncompletePopup == null)
                {
                    clickNOBtnFrmIncompletePopup = new clickNOBtnFrmIncompletePopup_Map();
                    clickNOBtnFrmIncompletePopup.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickNOBtnFrmIncompletePopup;
            }
        }
        public verifyDestinationListBox_Map verifyDestinationListBox_Obj
        {
            get
            {
                if (verifyDestinationListBox == null)
                {
                    verifyDestinationListBox = new verifyDestinationListBox_Map();
                    verifyDestinationListBox.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyDestinationListBox;
            }
        }
        public verifyDurationListBox_Map verifyDurationListBox_Obj
        {
            get
            {
                if (verifyDurationListBox == null)
                {
                    verifyDurationListBox = new verifyDurationListBox_Map();
                    verifyDurationListBox.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyDurationListBox;
            }
        }
        public verifyAdultListBox_Map verifyAdultListBox_Obj
        {
            get
            {
                if (verifyAdultListBox == null)
                {
                    verifyAdultListBox = new verifyAdultListBox_Map();
                    verifyAdultListBox.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAdultListBox;
            }
        }
        public verifyChildListBox_Map verifyChildListBox_Obj
        {
            get
            {
                if (verifyChildListBox == null)
                {
                    verifyChildListBox = new verifyChildListBox_Map();
                    verifyChildListBox.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyChildListBox;
            }
        }
        public verifyInfantListbox_Map verifyInfantListbox_Obj
        {
            get
            {
                if (verifyInfantListbox == null)
                {
                    verifyInfantListbox = new verifyInfantListbox_Map();
                    verifyInfantListbox.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyInfantListbox;
            }
        }
        public verifyAirportListBox_Map verifyAirportListBox_Obj
        {
            get
            {
                if (verifyAirportListBox == null)
                {
                    verifyAirportListBox = new verifyAirportListBox_Map();
                    verifyAirportListBox.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAirportListBox;
            }
        }
        public clickCalenderIcon_Map clickCalenderIcon_Obj
        {
            get
            {
                if (clickCalenderIcon == null)
                {
                    clickCalenderIcon = new clickCalenderIcon_Map();
                    clickCalenderIcon.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickCalenderIcon;
            }
        }
        public verifyCalenderDisplay_Map verifyCalenderDisplay_Obj
        {
            get
            {
                if (verifyCalenderDisplay == null)
                {
                    verifyCalenderDisplay = new verifyCalenderDisplay_Map();
                    verifyCalenderDisplay.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyCalenderDisplay;
            }
        }
        public selectMonthFrmCalender_Map selectMonthFrmCalender_Obj
        {
            get
            {
                if (selectMonthFrmCalender == null)
                {
                    selectMonthFrmCalender = new selectMonthFrmCalender_Map();
                    selectMonthFrmCalender.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectMonthFrmCalender;
            }
        }
        public selectaDateFrmCalender_Map selectaDateFrmCalender_Obj
        {
            get
            {
                if (selectaDateFrmCalender == null)
                {
                    selectaDateFrmCalender = new selectaDateFrmCalender_Map();
                    selectaDateFrmCalender.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectaDateFrmCalender;
            }
        }
        public clickSearchBtn_Map clickSearchBtn_Obj
        {
            get
            {
                if (clickSearchBtn == null)
                {
                    clickSearchBtn = new clickSearchBtn_Map();
                    clickSearchBtn.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSearchBtn;
            }
        }
        public verifyIncorrectInputPopupDisplayed_Map verifyIncorrectInputPopupDisplayed_Obj
        {
            get
            {
                if (verifyIncorrectInputPopupDisplayed == null)
                {
                    verifyIncorrectInputPopupDisplayed = new verifyIncorrectInputPopupDisplayed_Map();
                    verifyIncorrectInputPopupDisplayed.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyIncorrectInputPopupDisplayed;
            }
        }
        public clickOKFrmIncorrectPopup_Map clickOKFrmIncorrectPopup_Obj
        {
            get
            {
                if (clickOKFrmIncorrectPopup == null)
                {
                    clickOKFrmIncorrectPopup = new clickOKFrmIncorrectPopup_Map();
                    clickOKFrmIncorrectPopup.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickOKFrmIncorrectPopup;
            }
        }
        public clickVillaNameTabfromSearchTile_Map clickVillaNameTabfromSearchTile_Obj
        {
            get
            {
                if (clickVillaNameTabfromSearchTile == null)
                {
                    clickVillaNameTabfromSearchTile = new clickVillaNameTabfromSearchTile_Map();
                    clickVillaNameTabfromSearchTile.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickVillaNameTabfromSearchTile;
            }
        }
        public enterAnyCharInVillaNameTxtBox_Map enterAnyCharInVillaNameTxtBox_Obj
        {
            get
            {
                if (enterAnyCharInVillaNameTxtBox == null)
                {
                    enterAnyCharInVillaNameTxtBox = new enterAnyCharInVillaNameTxtBox_Map();
                    enterAnyCharInVillaNameTxtBox.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterAnyCharInVillaNameTxtBox;
            }
        }
        public selectaVillaFromList_Map selectaVillaFromList_Obj
        {
            get
            {
                if (selectaVillaFromList == null)
                {
                    selectaVillaFromList = new selectaVillaFromList_Map();
                    selectaVillaFromList.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectaVillaFromList;
            }
        }
        public clickViewVillaFrmSearchTile_Map clickViewVillaFrmSearchTile_Obj
        {
            get
            {
                if (clickViewVillaFrmSearchTile == null)
                {
                    clickViewVillaFrmSearchTile = new clickViewVillaFrmSearchTile_Map();
                    clickViewVillaFrmSearchTile.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickViewVillaFrmSearchTile;
            }
        }
        public clickViewVillaBtnFrmSearchResultsPage_Map clickViewVillaBtnFrmSearchResultsPage_Obj
        {
            get
            {
                if (clickViewVillaBtnFrmSearchResultsPage == null)
                {
                    clickViewVillaBtnFrmSearchResultsPage = new clickViewVillaBtnFrmSearchResultsPage_Map();
                    clickViewVillaBtnFrmSearchResultsPage.UIYoursearchfound23VilWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickViewVillaBtnFrmSearchResultsPage;
            }
        }
        public verifyProductPageOpened_Map verifyProductPageOpened_Obj
        {
            get
            {
                if (verifyProductPageOpened == null)
                {
                    verifyProductPageOpened = new verifyProductPageOpened_Map();
                    verifyProductPageOpened.UIVillaCoelhoInPraiadaWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyProductPageOpened;
            }
        }
        public clickVillaNFlightsBtnFrmProductPage_Map clickVillaNFlightsBtnFrmProductPage_Obj
        {
            get
            {
                if (clickVillaNFlightsBtnFrmProductPage == null)
                {
                    clickVillaNFlightsBtnFrmProductPage = new clickVillaNFlightsBtnFrmProductPage_Map();
                    clickVillaNFlightsBtnFrmProductPage.UIVillaBrisasMarInCorrWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickVillaNFlightsBtnFrmProductPage;
            }
        }
        public clickBookVillaOnlyBtnFrmProductPage_Map clickBookVillaOnlyBtnFrmProductPage_Obj
        {
            get
            {
                if (clickBookVillaOnlyBtnFrmProductPage == null)
                {
                    clickBookVillaOnlyBtnFrmProductPage = new clickBookVillaOnlyBtnFrmProductPage_Map();
                    clickBookVillaOnlyBtnFrmProductPage.UIVillaIfaraInCostaAdeWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBookVillaOnlyBtnFrmProductPage;
            }
        }

        public verifySearchResultsPageOpened_Map verifySearchResultsPageOpened_Obj
        {
            get
            {
                if (verifySearchResultsPageOpened == null)
                {
                    verifySearchResultsPageOpened = new verifySearchResultsPageOpened_Map();
                    verifySearchResultsPageOpened.UIYoursearchfound60VilWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifySearchResultsPageOpened;
            }
        }
        public verifyNoVillasMsgDisplayed_Map verifyNoVillasMsgDisplayed_Obj
        {
            get
            {
                if (verifyNoVillasMsgDisplayed == null)
                {
                    verifyNoVillasMsgDisplayed = new verifyNoVillasMsgDisplayed_Map();
                    verifyNoVillasMsgDisplayed.UIYoursearchfound0VillWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyNoVillasMsgDisplayed;
            }
        }
        public clickVillaNFlightsLinkFrmSearchResultsPage_Map clickVillaNFlightsLinkFrmSearchResultsPage_Obj
        {
            get
            {
                if (clickVillaNFlightsLinkFrmSearchResultsPage == null)
                {
                    clickVillaNFlightsLinkFrmSearchResultsPage = new clickVillaNFlightsLinkFrmSearchResultsPage_Map();
                    clickVillaNFlightsLinkFrmSearchResultsPage.UIYoursearchfound2VillWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickVillaNFlightsLinkFrmSearchResultsPage;
            }
        }
        public clickBookVillaFlightLink_Map clickBookVillaFlightLink_Obj
        {
            get
            {
                if (clickBookVillaFlightLink == null)
                {
                    clickBookVillaFlightLink = new clickBookVillaFlightLink_Map();
                    clickBookVillaFlightLink.UIYoursearchfound39VilWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBookVillaFlightLink;
            }
        }
        public clickBookVillaOnlyLINKFrmSRPage_Map clickBookVillaOnlyLINKFrmSRPage_Obj
        {
            get
            {
                if (clickBookVillaOnlyLINKFrmSRPage == null)
                {
                    clickBookVillaOnlyLINKFrmSRPage = new clickBookVillaOnlyLINKFrmSRPage_Map();
                    clickBookVillaOnlyLINKFrmSRPage.UIYoursearchfound31VilWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBookVillaOnlyLINKFrmSRPage;
            }
        }
        public clickBookVillaOnlyBTNFrmSRPage_Map clickBookVillaOnlyBTNFrmSRPage_Obj
        {
            get
            {
                if (clickBookVillaOnlyBTNFrmSRPage == null)
                {
                    clickBookVillaOnlyBTNFrmSRPage = new clickBookVillaOnlyBTNFrmSRPage_Map();
                    clickBookVillaOnlyBTNFrmSRPage.UIYoursearchfound43VilWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBookVillaOnlyBTNFrmSRPage;
            }
        }
        
        public verifyHSPKOpened_Map verifyHSPKOpened_Obj
        {
            get
            {
                if (verifyHSPKOpened == null)
                {
                    verifyHSPKOpened = new verifyHSPKOpened_Map();
                    verifyHSPKOpened.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyHSPKOpened;
            }
        }

        public getVillaNameFrmSRPage_Map getVillaNameFrmSRPage_Obj
        {
            get
            {
                if (getVillaNameFrmSRPage == null)
                {
                    getVillaNameFrmSRPage = new getVillaNameFrmSRPage_Map();
                    getVillaNameFrmSRPage.UIYoursearchfound39VilWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return getVillaNameFrmSRPage;
            }
        }

        public getVillaOnlyPriceFrmSRPage_Map getVillaOnlyPriceFrmSRPage_obj
        {
            get
            {
                if (getVillaOnlyPriceFrmSRPage == null)
                {
                    getVillaOnlyPriceFrmSRPage = new getVillaOnlyPriceFrmSRPage_Map();
                    getVillaOnlyPriceFrmSRPage.UIYoursearchfound11VilWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return getVillaOnlyPriceFrmSRPage;
            }
        }

        public GetVillaOnlyPriceFrmProductPage_map GetVillaOnlyPriceFrmProductPage_obj
        {
            get
            {
                if (GetVillaOnlyPriceFrmProductPage == null)
                {
                    GetVillaOnlyPriceFrmProductPage = new GetVillaOnlyPriceFrmProductPage_map();
                    GetVillaOnlyPriceFrmProductPage.UIVillaTamarellInCalanWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return GetVillaOnlyPriceFrmProductPage;
            }
        }

        public getVOPriceFrmHSPage_Map getVOPriceFrmHSPage_obj
        {
            get
            {
                if (getVOPriceFrmHSPage == null)
                {
                    getVOPriceFrmHSPage = new getVOPriceFrmHSPage_Map();
                    getVOPriceFrmHSPage.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return getVOPriceFrmHSPage;
            }
        }
   }
}
