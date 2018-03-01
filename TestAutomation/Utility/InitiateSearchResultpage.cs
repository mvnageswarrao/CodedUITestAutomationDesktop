using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.UIMap.HomePage.openBrowser_MapClasses;
using TestAutomation.UIMap.HomePage.enterURL_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyDestinationListBox_MapClasses;
using TestAutomation.UIMap.TabSearchTile.selectDestfrmTab_MapClasses;
using TestAutomation.UIMap.SearchTile.clickCalenderIcon_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyCalenderDisplay_MapClasses;
using TestAutomation.UIMap.SearchTile.selectaDateFrmCalender_MapClasses;
using TestAutomation.UIMap.SearchTile.selectMonthFrmCalender_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyDurationListBox_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyAdultListBox_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyChildListBox_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyInfantListbox_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyAirportListBox_MapClasses;
using TestAutomation.UIMap.SearchTile.clickSearchBtn_MapClasses;
using TestAutomation.UIMap.SearchTile.verifySearchResultsPageOpened_MapClasses;
using TestAutomation.UIMap.SearchResultPage.VerifyHeadingText_MapClasses;
using TestAutomation.UIMap.SearchResultPage.VerifySearchResultCriteriaText_MapClasses;
using TestAutomation.UIMap.SearchResultPage.VerifyViewVillaBtnFrmSearchResultsPage_MapClasses;
using TestAutomation.UIMap.CountryVillaList.getFirstVillaName_MapClasses;
using TestAutomation.UIMap.SearchResultPage.VerifyVillaOverview_MapClasses;
using TestAutomation.UIMap.SearchResultPage.getvillablockDetails_MapClasses;
using TestAutomation.UIMap.SearchResultPage.ClickViewVillaButton_MapClasses;
using TestAutomation.UIMap.SearchResultPage.VerifyVillaDestinationsFilter_MapClasses;
using TestAutomation.UIMap.SearchResultPage.VerifyResortsFilter_MapClasses;
using TestAutomation.UIMap.SearchResultPage.verifyProdPageOpened_MapClasses;
using TestAutomation.UIMap.SearchResultPage.VerifyVillaTypeFilter_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyNoVillasMsgDisplayed_MapClasses;
using TestAutomation.UIMap.SearchResultPage.verifyBedRoomFilter_MapClasses;
using TestAutomation.UIMap.SearchResultPage.verifyVillaDetailsFilter_MapClasses;
using TestAutomation.UIMap.SearchResultPage.verifySortByOrder_MapClasses;
using TestAutomation.UIMap.SearchResultPage.clickIncludeFlights_MapClasses;
using TestAutomation.UIMap.SearchResultPage.verifyIncludeFlightPopupDisplay_MapClasses;
using TestAutomation.UIMap.SearchTile.clickCloseFrmIncludeFlights_MapClasses;


namespace TestAutomation.Utility
{
    public class InitiateSearchResultpage
    {
        private openBrowser_Map OpenBrowser = null;
        private enterURL_Map EnterURL = null;
        private verifyDestinationListBox_Map verifyDestinationListBox = null;
        private selectDestfrmTab_Map selectDestfrmTab = null;
        private clickCalenderIcon_Map clickCalenderIcon = null;
        private verifyCalenderDisplay_Map verifyCalenderDisplay = null;
        private selectaDateFrmCalender_Map selectaDateFrmCalender = null;
        private selectMonthFrmCalender_Map selectMonthFrmCalender = null;
        private verifyDurationListBox_Map verifyDurationListBox = null;
        private verifyAdultListBox_Map verifyAdultListBox = null;
        private verifyChildListBox_Map verifyChildListBox = null;
        private verifyInfantListbox_Map verifyInfantListbox = null;
        private verifyAirportListBox_Map verifyAirportListBox = null;
        private clickSearchBtn_Map clickSearchBtn = null;
        private verifySearchResultsPageOpened_Map verifySearchResultsPageOpened = null;
        private VerifyHeadingText_Map VerifyHeadingText = null;
        private VerifySearchResultCriteriaText_Map VerifySearchResultCriteriaText = null;
        private VerifyViewVillaBtnFrmSearchResultsPage_Map ViewVillaBtnFrmSearchResultsPage = null;
        private getFirstVillaName_Map getFirstVillaName = null;
        private VerifyVillaOverview_Map VerifyVillaOverview = null;
        private getvillablockDetails_Map getvillablockDetails = null;
        private ClickViewVillaButton_Map ClickViewVillaButton = null;
        private VerifyVillaDestinationsFilter_Map VerifyVillaDestinationsFilter = null;
        private VerifyResortsFilter_Map VerifyResortsFilter = null;
        private verifyProdPageOpened_Map verifyProdPageOpened = null;
        private VerifyVillaTypeFilter_Map VerifyVillaTypeFilter = null;
        private verifyNoVillasMsgDisplayed_Map verifyNoVillasMsgDisplayed = null;
        private verifyBedRoomFilter_Map verifyBedRoomFilter = null;
        private verifyVillaDetailsFilter_Map verifyVillaDetailsFilter = null;
        private verifySortByOrder_Map verifySortByOrder = null;
        private clickIncludeFlights_Map clickIncludeFlights = null;
        private verifyIncludeFlightPopupDisplay_Map verifyIncludeFlightPopupDisplay = null;
        private clickCloseFrmIncludeFlights_Map clickCloseFrmIncludeFlights = null;

        public InitiateSearchResultpage()
        {
            OpenBrowser = new openBrowser_Map();
        }
        public openBrowser_Map OpenBrowser_Obj
        {
            get { return OpenBrowser; }
            set { OpenBrowser = value; }
        }
        public enterURL_Map EnterURL_Obj
        {
            get
            {
                if (EnterURL == null)
                {
                    EnterURL = new enterURL_Map();
                    EnterURL.UIBlankPageWindowsInteWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return EnterURL;
            }
        }
        public verifyDestinationListBox_Map verifyDestinationListBox_Obj
        {
            get
            {
                if (verifyDestinationListBox == null)
                {
                    verifyDestinationListBox = new verifyDestinationListBox_Map();
                    verifyDestinationListBox.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyDestinationListBox;
            }

        }
        public selectDestfrmTab_Map selectDestfrmTab_Obj
        {
            get
            {
                if (selectDestfrmTab == null)
                {
                    selectDestfrmTab = new selectDestfrmTab_Map();
                    selectDestfrmTab.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectDestfrmTab;
            }

        }
        public clickCalenderIcon_Map clickCalenderIcon_Obj
        {
            get
            {
                if (clickCalenderIcon == null)
                {
                    clickCalenderIcon = new clickCalenderIcon_Map();
                    clickCalenderIcon.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
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
                    verifyCalenderDisplay.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
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
                    selectMonthFrmCalender.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
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
                    selectaDateFrmCalender.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectaDateFrmCalender;
            }
        }
        public verifyDurationListBox_Map verifyDurationListBox_Obj
        {
            get
            {
                if (verifyDurationListBox == null)
                {
                    verifyDurationListBox = new verifyDurationListBox_Map();
                    verifyDurationListBox.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
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
                    verifyAdultListBox.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
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
                    verifyChildListBox.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
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
                    verifyInfantListbox.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
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
                    verifyAirportListBox.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAirportListBox;
            }
        }
        public clickSearchBtn_Map clickSearchBtn_Obj
        {
            get
            {
                if (clickSearchBtn == null)
                {
                    clickSearchBtn = new clickSearchBtn_Map();
                    clickSearchBtn.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSearchBtn;
            }
        }
        public verifySearchResultsPageOpened_Map verifySearchResultsPageOpened_Obj
        {
            get
            {
                if (verifySearchResultsPageOpened == null)
                {
                    verifySearchResultsPageOpened = new verifySearchResultsPageOpened_Map();
                    verifySearchResultsPageOpened.UIYoursearchfound60VilWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifySearchResultsPageOpened;
            }
        }
        public VerifyHeadingText_Map VerifyHeadingText_Obj
        {
            get
            {
                if (VerifyHeadingText == null)
                {
                    VerifyHeadingText = new VerifyHeadingText_Map();
                    VerifyHeadingText.UIYoursearchfound3VillWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);

                }
                return VerifyHeadingText;
            }

        }
        public VerifySearchResultCriteriaText_Map VerifySearchResultCriteriaText_Obj
        {
            get
            {
                if (VerifySearchResultCriteriaText == null)
                {
                    VerifySearchResultCriteriaText = new VerifySearchResultCriteriaText_Map();
                    VerifySearchResultCriteriaText.UIYoursearchfound204ViWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return VerifySearchResultCriteriaText;
            }
        }
        public VerifyViewVillaBtnFrmSearchResultsPage_Map VerifyViewVillaBtnFrmSearchResultsPage_Obj
        {
            get
            {
                if (ViewVillaBtnFrmSearchResultsPage == null)
                {
                    ViewVillaBtnFrmSearchResultsPage = new VerifyViewVillaBtnFrmSearchResultsPage_Map();
                    ViewVillaBtnFrmSearchResultsPage.UIYoursearchfound214ViWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return ViewVillaBtnFrmSearchResultsPage;
            }
        }
        public getFirstVillaName_Map getFirstVillaName_Obj
        {
            get
            {
                if (getFirstVillaName == null)
                {
                    getFirstVillaName = new getFirstVillaName_Map();
                    getFirstVillaName.UIHttpnimbusAlgarvevilWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return getFirstVillaName;
            }
        }
        public VerifyVillaOverview_Map VerifyVillaOverView_Obj
        {
            get
            {
                if (VerifyVillaOverview == null)
                {
                    VerifyVillaOverview = new VerifyVillaOverview_Map();
                    VerifyVillaOverview.UIYoursearchfound214ViWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return VerifyVillaOverview;
            }
        }
        public getvillablockDetails_Map getvillablockDetails_Obj
        {
            get
            {
                if (getvillablockDetails == null)
                {
                    getvillablockDetails = new getvillablockDetails_Map();
                    getvillablockDetails.UIYoursearchfound214ViWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return getvillablockDetails;
            }
        }
        public ClickViewVillaButton_Map ClickViewVillaButton_Obj
        {
            get
            {
                if (ClickViewVillaButton == null)
                {
                    ClickViewVillaButton = new ClickViewVillaButton_Map();
                    ClickViewVillaButton.UIYoursearchfound170ViWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return (ClickViewVillaButton);
            }
        }
        public VerifyVillaDestinationsFilter_Map verifyVillaDestinationsFilter_Obj
        {
            get
            {
                if (VerifyVillaDestinationsFilter == null)
                {
                    VerifyVillaDestinationsFilter = new VerifyVillaDestinationsFilter_Map();
                    VerifyVillaDestinationsFilter.UIYoursearchfound31VilWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return VerifyVillaDestinationsFilter;
            }
        }
        public VerifyResortsFilter_Map VerifyResortsFilter_Obj
        {
            get
            {
                if (VerifyResortsFilter == null)
                {
                    VerifyResortsFilter = new VerifyResortsFilter_Map();
                    VerifyResortsFilter.UIYoursearchfound4VillWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return VerifyResortsFilter;
            }
        }
        public verifyProdPageOpened_Map verifyProdPageOpened_Obj
        {
            get
            {
                if (verifyProdPageOpened == null)
                {
                    verifyProdPageOpened = new verifyProdPageOpened_Map();
                    verifyProdPageOpened.UIVillaLourdasIthakiInWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyProdPageOpened;
            }
        }
        public VerifyVillaTypeFilter_Map VerifyVillaTypeFilter_Obj
        {
            get
            {
                if (VerifyVillaTypeFilter == null)
                {
                    VerifyVillaTypeFilter = new VerifyVillaTypeFilter_Map();
                    VerifyVillaTypeFilter.UIYoursearchfound49VilWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return VerifyVillaTypeFilter;

            }
        }
        public verifyNoVillasMsgDisplayed_Map verifyNoVillasMsgDisplayed_Obj
        {
            get
            {
                if (verifyNoVillasMsgDisplayed == null)
                {
                    verifyNoVillasMsgDisplayed = new verifyNoVillasMsgDisplayed_Map();
                    verifyNoVillasMsgDisplayed.UIYoursearchfound0VillWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyNoVillasMsgDisplayed;
            }
        }
        public verifyBedRoomFilter_Map verifyBedRoomFilter_Obj
        {
            get
            {
                if (verifyBedRoomFilter == null)
                {
                    verifyBedRoomFilter = new verifyBedRoomFilter_Map();
                    verifyBedRoomFilter.UIYoursearchfound38VilWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyBedRoomFilter;
            }
        }
        public verifyVillaDetailsFilter_Map verifyVillaDetailsFilter_Obj
        {
            get
            {
                if (verifyVillaDetailsFilter == null)
                {
                    verifyVillaDetailsFilter = new verifyVillaDetailsFilter_Map();
                    verifyVillaDetailsFilter.UIYoursearchfound38VilWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyVillaDetailsFilter;
            }
        }
        public verifySortByOrder_Map verifySortByOrder_Obj
        {
            get
            {
                if (verifySortByOrder == null)
                {
                    verifySortByOrder = new verifySortByOrder_Map();
                    verifySortByOrder.UIYoursearchfound9VillWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifySortByOrder;
            }
        }
        public clickIncludeFlights_Map clickIncludeFlights_Obj
        {
            get
            {
                if (clickIncludeFlights == null)
                {
                    clickIncludeFlights = new clickIncludeFlights_Map();
                    clickIncludeFlights.UIYoursearchfound9VillWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickIncludeFlights;
            }
        }
        public verifyIncludeFlightPopupDisplay_Map verifyIncludeFlightPopupDisplay_Obj
        {
            get
            {
                if (verifyIncludeFlightPopupDisplay == null)
                {
                    verifyIncludeFlightPopupDisplay = new verifyIncludeFlightPopupDisplay_Map();
                    verifyIncludeFlightPopupDisplay.UIYoursearchfound9VillWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyIncludeFlightPopupDisplay;
            }
        }
        public clickCloseFrmIncludeFlights_Map clickCloseFrmIncludeFlights_Obj
        {
            get
            {
                if (clickCloseFrmIncludeFlights == null)
                {
                    clickCloseFrmIncludeFlights = new clickCloseFrmIncludeFlights_Map();
                    clickCloseFrmIncludeFlights.UIYoursearchfound1VillWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickCloseFrmIncludeFlights;
            }
        }


    }
}
    


    
