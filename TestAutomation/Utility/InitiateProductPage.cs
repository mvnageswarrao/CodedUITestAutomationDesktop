using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TestAutomation.UIMap.ProductPage.openBrowser_MapClasses;
using TestAutomation.UIMap.ProductPage.enterURL_MapClasses;
using TestAutomation.UIMap.ProductPage.clickViewFloorPlan_MapClasses;
using TestAutomation.UIMap.ProductPage.clickPhotoTab_MapClasses;
using TestAutomation.UIMap.ProductPage.clickClicktoEnlarge_MapClasses;
using TestAutomation.UIMap.ProductPage.clickVirtualTourTab_MapClasses;
using TestAutomation.UIMap.ProductPage.clickLocationTab_MapClasses;
using TestAutomation.UIMap.ProductPage.clickActivitiesTab_MapClasses;
using TestAutomation.UIMap.ProductPage.clickReviewsTab_MapClasses;
using TestAutomation.UIMap.ProductPage.clickAvailabilityTab_MapClasses;
using TestAutomation.UIMap.ProductPage.clickViewOnMap_MapClasses;
using TestAutomation.UIMap.ProductPage.clickCheckAvaiandPricesBtn_MapClasses;
using TestAutomation.UIMap.ProductPage.verfiyPriceRangedFrom_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyMainPageSubTitle_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyVillaSummary_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyVillaLocationText_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyVillaLayoutText_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyVillaFeatures_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyVillaFacilityText_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyLocationTablocText_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyLocationTabLocFeatures_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyLocTabInThisArea_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyLocTabGPSCord_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyocTabMAbResort_mapClasses;
using TestAutomation.UIMap.ProductPage.verifyReviewTabReviews_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyMainPageNoOfCustGivenRating_MapClasses;
using TestAutomation.UIMap.ProductPage.selectActTabDepartsOn_MapClasses;
using TestAutomation.UIMap.ProductPage.selectActTabDate_MapClasses;
using TestAutomation.UIMap.ProductPage.selectActTabAirtport_MapClasses;
using TestAutomation.UIMap.ProductPage.clickActTabBookVillaBtn_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyActTabVillaOnlyPrice_MapClasses;
using TestAutomation.UIMap.ProductPage.getDateforPriceCompare_MapClasses;
using TestAutomation.UIMap.ProductPage.clickActTabClosePriceWindow_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyNoOfImages_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyVeryVillaPlus_MapClasses;
using TestAutomation.UIMap.ProductPage.setIE9StandardsInDeveloperTools_MapClasses;
using TestAutomation.UIMap.ProductPage.clickDescriptionTab_MapClasses;
using TestAutomation.UIMap.ProductPage.selectAdult_MapClasses;
using TestAutomation.UIMap.ProductPage.selectChild_MapClasses;
using TestAutomation.UIMap.ProductPage.checkTabAvailablity_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyMaxOccupancyonPopUp_MapClasses;
using TestAutomation.UIMap.ProductPage.clickOKonMaxOccupancyPopUp_MapClasses;
using TestAutomation.UIMap.ProductPage.clickOkFromZeroAdultMessage_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyZeroAdultMessage_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyActivitiesTabHeadings_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyNumberOfTours_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyDescKeyNotes_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyBreadcrumbTag_MapClasses;
using TestAutomation.UIMap.ProductPage.clickViewMap_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyMinOccupancyonPopup_MapClasses;
using TestAutomation.UIMap.ProductPage.clickOnOKMinOccupancyPopup_MapClasses;
using TestAutomation.UIMap.ProductPage.selectDateFrmProductPage_MapClasses;
using TestAutomation.UIMap.ProductPage.clickChatWindow_MapClasses;
using TestAutomation.UIMap.ProductPage.clickAcceptCookiesButton_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyExpertComment_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyVillaTypes_MapClasses;
using TestAutomation.UIMap.ProductPage.clickCheckAvailabilitybutton_MapClasses;

namespace TestAutomation.Utility
{
    public class InitiateProductPage
    {
        private setIE9StandardsInDeveloperTools_Map setIE9StandardsInDeveloperTools = null;
        private openBrowser_Map openBrowser = null;
        private enterURL_Map enterURL = null;

        private verfiyPriceRangedFrom_Map verfiyPriceRangedFrom = null;
        private verifyMainPageSubTitle_Map verifyMainPageSubTitle = null;
        private verifyMainPageNoOfCustGivenRating_Map verifyMainPageNoOfCustGivenRating = null;

        private verifyBreadcrumbTag_Map verifyBreadcrumbTag = null;
        private clickViewMap_Map clickViewMap = null;


        private clickViewFloorPlan_Map clickViewFloorPlan = null;
        private verifyDescKeyNotes_Map verifyDescKeyNotes = null;
        private verifyExpertComment_Map verifyExpertComment = null;

        private clickPhotoTab_Map clickPhotoTab = null;
        private clickClicktoEnlarge_Map clickClicktoEnlarge = null;

        private clickVirtualTourTab_Map clickVirtualTourTab = null;
        private verifyNumberOfTours_Map verifyNumberOfTours = null;
        
        private clickLocationTab_Map clickLocationTab = null;
        private verifyLocationTablocText_Map verifyLocationTablocText = null;
        private verifyLocationTabLocFeatures_Map verifyLocationTabLocFeatures = null;
        private verifyLocTabInThisArea_Map verifyLocTabInThisArea = null;
        private verifyLocTabGPSCord_Map verifyLocTabGPSCord=null;
        private verifyocTabMAbResort_map verifyocTabMAbResort = null;
        private verifyVillaTypes_Map verifyVillaTypes = null;

        private clickActivitiesTab_Map clickActivitiesTab = null;

        private clickChatWindow_Map clickChatWindow = null;
        
        private clickReviewsTab_Map clickReviewsTab = null;
        private verifyReviewTabReviews_Map verifyReviewTabReviews = null;

        private clickAvailabilityTab_Map clickAvailabilityTab = null;
        private clickViewOnMap_Map clickViewOnMap = null;
        private clickCheckAvaiandPricesBtn_Map clickCheckAvaiandPricesBtn = null;
        private clickCheckAvailabilitybutton_Map clickCheckAvailabilitybutton = null;

        private selectActTabDepartsOn_Map selectActTabDepartsOn = null;
        private selectActTabDate_Map selectActTabDate = null;
        private selectActTabAirtport_Map selectActTabAirtport = null;
        private clickActTabBookVillaBtn_Map clickActTabBookVillaBtn = null;
        private verifyActTabVillaOnlyPrice_Map verifyActTabVillaOnlyPrice = null;
        private getDateforPriceCompare_Map getDateforPriceCompare = null;
        private clickActTabClosePriceWindow_Map clickActTabClosePriceWindow = null;
        private selectDateFrmProductPage_Map selectDateFrmProductPage = null;

        private verifyVillaSummary_Map verifyVillaSummary = null;
        private verifyVillaLocationText_Map verifyVillaLocationText = null;
        private verifyVillaLayoutText_Map verifyVillaLayoutText = null;
        private verifyVillaFeatures_Map verifyVillaFeatures = null;
        private verifyVillaFacilityText_Map verifyVillaFacilityText = null;
        private verifyNoOfImages_Map verifyNoOfImages = null;

        private verifyVeryVillaPlus_Map verifyVeryVillaPlus = null;
        private clickDescriptionTab_Map clickDescriptionTab = null;

        private selectAdult_Map selectAdult = null;
        private selectChild_Map selectChild = null;

        private checkTabAvailablity_Map checkTabAvailablity = null;
        private verifyActivitiesTabHeadings_Map verifyActivitiesTabHeadings = null;

        private verifyMaxOccupancyonPopUp_Map verifyMaxOccupancyonPopUp = null;
        private clickOKonMaxOccupancyPopUp_Map clickOKonMaxOccupancyPopUp = null;
        private verifyZeroAdultMessage_Map verifyZeroAdultMessage = null;
        private clickOkFromZeroAdultMessage_Map clickOkFromZeroAdultMessage = null;
        private verifyMinOccupancyonPopup_Map verifyMinOccupancyonPopup = null;
        private clickOnOKMinOccupancyPopup_Map clickOnOKMinOccupancyPopup = null;

        private clickAcceptCookiesButton_Map clickAcceptCookiesButton = null;

        

        public InitiateProductPage()
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

        public verfiyPriceRangedFrom_Map verfiyPriceRangedFrom_Obj
        {
            get
            {
                if (verfiyPriceRangedFrom == null)
                {
                    verfiyPriceRangedFrom = new verfiyPriceRangedFrom_Map();
                    verfiyPriceRangedFrom.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verfiyPriceRangedFrom;
            }
        }

        public clickChatWindow_Map clickChatWindow_Obj
        {
            get
            {
                if (clickChatWindow == null)
                {
                    clickChatWindow = new clickChatWindow_Map();
                    clickChatWindow.UIVillaVolentinaInPuerWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickChatWindow;
            }
        }

        public verifyMainPageSubTitle_Map verifyMainPageSubTitle_Obj
        {
            get
            {
                if (verifyMainPageSubTitle == null)
                {
                    verifyMainPageSubTitle = new verifyMainPageSubTitle_Map();
                    verifyMainPageSubTitle.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyMainPageSubTitle;
            }
        }

       
        public clickViewMap_Map clickViewMap_Obj
        {
            get
            {
                if (clickViewMap == null)
                {
                    clickViewMap = new clickViewMap_Map();
                    clickViewMap.UIVillaVolentinaInPuerWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickViewMap;
            }
        }

        public clickAcceptCookiesButton_Map clickAcceptCookiesButton_Obj
        {
            get
            {
                if (clickAcceptCookiesButton == null)
                {
                    clickAcceptCookiesButton = new clickAcceptCookiesButton_Map();
                    clickAcceptCookiesButton.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAcceptCookiesButton;
            }
        }

        public verifyMainPageNoOfCustGivenRating_Map verifyMainPageNoOfCustGivenRating_Obj
        {
            get
            {
                if (verifyMainPageNoOfCustGivenRating == null)
                {
                    verifyMainPageNoOfCustGivenRating = new verifyMainPageNoOfCustGivenRating_Map();
                    verifyMainPageNoOfCustGivenRating.UIVillaPietraGiallaInAWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyMainPageNoOfCustGivenRating;
            }
        }


        public verifyBreadcrumbTag_Map verifyBreadcrumbTag_Obj
        {
            get
            {
                if (verifyBreadcrumbTag == null)
                {
                    verifyBreadcrumbTag = new verifyBreadcrumbTag_Map();
                    verifyBreadcrumbTag.UIVillaHermesInCoralBaWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyBreadcrumbTag;
            }
        }

        public verifyExpertComment_Map verifyExpertComment_Obj
        {
            get
            {
                if (verifyExpertComment == null)
                {
                    verifyExpertComment = new verifyExpertComment_Map();
                    verifyExpertComment.UIVillaUtopiaInAlcudiaWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyExpertComment;
            }
        }



        public verifyNumberOfTours_Map verifyNumberOfTours_Obj
        {
            get
            {
                if (verifyNumberOfTours == null)
                {
                    verifyNumberOfTours = new verifyNumberOfTours_Map();
                    verifyNumberOfTours.UIVillaVolentinaInPuerWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyNumberOfTours;
            }
        }

        public verifyDescKeyNotes_Map verifyDescKeyNotes_Obj
        {
            get
            {
                if (verifyDescKeyNotes == null)
                {
                    verifyDescKeyNotes = new verifyDescKeyNotes_Map();
                    verifyDescKeyNotes.UIVillaHesperaInTrapezWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyDescKeyNotes;
            }
        }

        public clickViewFloorPlan_Map clickViewFloorPlan_Obj
        {
            get
            {
                if (clickViewFloorPlan == null)
                {
                    clickViewFloorPlan = new clickViewFloorPlan_Map();
                    clickViewFloorPlan.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickViewFloorPlan;
            }
        }

        public clickPhotoTab_Map clickPhtoTab_Obj
        {
            get
            {
                if (clickPhotoTab == null)
                {
                    clickPhotoTab = new clickPhotoTab_Map();
                    clickPhotoTab.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickPhotoTab;
            }
        }

        public clickClicktoEnlarge_Map clickClicktoEnlarge_Obj
        {
            get
            {
                if (clickClicktoEnlarge == null)
                {
                    clickClicktoEnlarge = new clickClicktoEnlarge_Map();
                    clickClicktoEnlarge.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickClicktoEnlarge;
            }
        }

        public clickVirtualTourTab_Map clickVirtualTourTab_Obj
        {
            get
            {
                if (clickVirtualTourTab == null)
                {
                    clickVirtualTourTab = new clickVirtualTourTab_Map();
                    clickVirtualTourTab.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickVirtualTourTab;
            }
        }

        public clickLocationTab_Map clickLocationTab_Obj
        {
            get
            {
                if (clickLocationTab == null)
                {
                    clickLocationTab = new clickLocationTab_Map();
                    clickLocationTab.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickLocationTab;
            }
        }

   
        public verifyLocationTablocText_Map verifyLocationTablocText_Obj
        {
            get
            {
                if (verifyLocationTablocText == null)
                {
                    verifyLocationTablocText = new verifyLocationTablocText_Map();
                    verifyLocationTablocText.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyLocationTablocText;
            }
        }


        public verifyLocationTabLocFeatures_Map verifyLocationTabLocFeatures_Obj
        {
            get
            {
                if (verifyLocationTabLocFeatures == null)
                {
                    verifyLocationTabLocFeatures = new verifyLocationTabLocFeatures_Map();
                    verifyLocationTabLocFeatures.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyLocationTabLocFeatures;
            }
        }

        public verifyLocTabInThisArea_Map verifyLocTabInThisArea_Obj
        {
            get
            {
                if (verifyLocTabInThisArea == null)
                {
                    verifyLocTabInThisArea = new verifyLocTabInThisArea_Map();
                    verifyLocTabInThisArea.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyLocTabInThisArea;
            }
        }

        public verifyLocTabGPSCord_Map verifyLocTabGPSCord_Obj
        {
            get
            {
                if (verifyLocTabGPSCord == null)
                {
                    verifyLocTabGPSCord = new verifyLocTabGPSCord_Map();
                    verifyLocTabGPSCord.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyLocTabGPSCord;
            }
        }


        public verifyVillaTypes_Map verifyVillaTypes_Obj
        {
            get
            {
                if (verifyVillaTypes == null)
                {
                    verifyVillaTypes = new verifyVillaTypes_Map();
                    verifyVillaTypes.UIVillaVelazcoInCalanFWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyVillaTypes;
            }
        }

        public verifyocTabMAbResort_map verifyocTabMAbResort_Obj
        {
            get
            {
                if (verifyocTabMAbResort == null)
                {
                    verifyocTabMAbResort = new verifyocTabMAbResort_map();
                    verifyocTabMAbResort.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyocTabMAbResort;
            }
        }

        public clickActivitiesTab_Map clickActivitiesTab_Obj
        {
            get
            {
                if (clickActivitiesTab == null)
                {
                    clickActivitiesTab = new clickActivitiesTab_Map();
                    clickActivitiesTab.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickActivitiesTab;
            }
        }

        public clickReviewsTab_Map clickReviewsTab_Obj
        {
            get
            {
                if (clickReviewsTab == null)
                {
                    clickReviewsTab = new clickReviewsTab_Map();
                    clickReviewsTab.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickReviewsTab;
            }
        }

        public verifyReviewTabReviews_Map verifyReviewTabReviews_Obj
        {
            get
            {
                if (verifyReviewTabReviews == null)
                {
                    verifyReviewTabReviews = new verifyReviewTabReviews_Map();
                    verifyReviewTabReviews.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyReviewTabReviews;
            }
        }

        public clickAvailabilityTab_Map clickAvailabilityTab_Obj
        {
            get
            {
                if (clickAvailabilityTab == null)
                {
                    clickAvailabilityTab = new clickAvailabilityTab_Map();
                    clickAvailabilityTab.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAvailabilityTab;
            }
        }


        public clickCheckAvailabilitybutton_Map clickCheckAvailabilitybutton_Obj
        {
            get
            {
                if (clickCheckAvailabilitybutton == null)
                {
                    clickCheckAvailabilitybutton = new clickCheckAvailabilitybutton_Map();
                    clickCheckAvailabilitybutton.UIVillaPineaInValeVerdWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickCheckAvailabilitybutton;
            }
        }


      
        public clickViewOnMap_Map clickViewOnMap_Obj
        {
            get
            {
                if (clickViewOnMap == null)
                {
                    clickViewOnMap = new clickViewOnMap_Map();
                    clickViewOnMap.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickViewOnMap;
            }
        }

        public clickCheckAvaiandPricesBtn_Map clickCheckAvaiandPricesBtn_Obj
        {
            get
            {
                if (clickCheckAvaiandPricesBtn == null)
                {
                    clickCheckAvaiandPricesBtn = new clickCheckAvaiandPricesBtn_Map();
                    //clickCheckAvaiandPricesBtn.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickCheckAvaiandPricesBtn;
            }
        }

        public verifyVillaSummary_Map verifyVillaSummary_Obj
        {
            get
            {
                if (verifyVillaSummary == null)
                {
                    verifyVillaSummary = new verifyVillaSummary_Map();
                    verifyVillaSummary.UIVillaEborosOldSkalaKWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyVillaSummary;
            }
        }
        
        public verifyVillaLocationText_Map verifyVillaLocationText_Obj
        {
            get
            {
                if (verifyVillaLocationText == null)
                {
                    verifyVillaLocationText = new verifyVillaLocationText_Map();
                    verifyVillaLocationText.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyVillaLocationText;
            }
        }

        public verifyVillaLayoutText_Map verifyVillaLayoutText_Obj
        {
            get
            {
                if (verifyVillaLayoutText == null)
                {
                    verifyVillaLayoutText = new verifyVillaLayoutText_Map();
                    verifyVillaLayoutText.UIVillaEborosOldSkalaKWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyVillaLayoutText;
            }
        }


        public verifyVillaFeatures_Map verifyVillaFeatures_Obj
        {
            get
            {
                if (verifyVillaFeatures == null)
                {
                    verifyVillaFeatures = new verifyVillaFeatures_Map();
                    verifyVillaFeatures.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyVillaFeatures;
            }
        }


        public verifyVillaFacilityText_Map verifyVillaFacilityText_Obj
        {
            get
            {
                if (verifyVillaFacilityText == null)
                {
                    verifyVillaFacilityText = new verifyVillaFacilityText_Map();
                    verifyVillaFacilityText.UIVillaEborosOldSkalaKWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyVillaFacilityText;
            }
        }

        public selectActTabDepartsOn_Map selectActTabDepartsOn_Obj
        {
            get
            {
                if (selectActTabDepartsOn == null)
                {
                    selectActTabDepartsOn = new selectActTabDepartsOn_Map();
                    selectActTabDepartsOn.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectActTabDepartsOn;
            }
        }

        public selectActTabDate_Map selectActTabDate_Obj
        {
            get
            {
                if (selectActTabDate == null)
                {
                    selectActTabDate = new selectActTabDate_Map();
                    selectActTabDate.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectActTabDate;
            }
        }


        public selectDateFrmProductPage_Map selectDateFrmProductPage_Obj
        {
            get
            {
                if (selectDateFrmProductPage == null)
                {
                    selectDateFrmProductPage = new selectDateFrmProductPage_Map();
                    selectDateFrmProductPage.UIVillaLArestaInPollenWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectDateFrmProductPage;
            }
        }

        public selectActTabAirtport_Map selectActTabAirtport_Obj
        {
            get
            {
                if (selectActTabAirtport == null)
                {
                    selectActTabAirtport = new selectActTabAirtport_Map();
                    selectActTabAirtport.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectActTabAirtport;
            }
        }

        public clickActTabBookVillaBtn_Map clickActTabBookVillaBtn_Obj
        {
            get
            {
                if (clickActTabBookVillaBtn == null)
                {
                    clickActTabBookVillaBtn = new clickActTabBookVillaBtn_Map();
                    clickActTabBookVillaBtn.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickActTabBookVillaBtn;
            }
        }

        public verifyActTabVillaOnlyPrice_Map verifyActTabVillaOnlyPrice_Obj
        {
            get
            {
                if (verifyActTabVillaOnlyPrice == null)
                {
                    verifyActTabVillaOnlyPrice = new verifyActTabVillaOnlyPrice_Map();
                    verifyActTabVillaOnlyPrice.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyActTabVillaOnlyPrice;
            }
        }

        public getDateforPriceCompare_Map getDateforPriceCompare_Obj
        {
            get
            {
                if (getDateforPriceCompare == null)
                {
                    getDateforPriceCompare = new getDateforPriceCompare_Map();
                    getDateforPriceCompare.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return getDateforPriceCompare;
            }
        }
        
        public clickActTabClosePriceWindow_Map clickActTabClosePriceWindow_Obj
        {
            get
            {
                if (clickActTabClosePriceWindow == null)
                {
                    clickActTabClosePriceWindow = new clickActTabClosePriceWindow_Map();
                    clickActTabClosePriceWindow.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickActTabClosePriceWindow;
            }
        }


        public verifyNoOfImages_Map verifyNoOfImages_Obj
        {
            get
            {
                if (verifyNoOfImages == null)
                {
                    verifyNoOfImages = new verifyNoOfImages_Map();
                    verifyNoOfImages.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyNoOfImages;
            }
        }

        public setIE9StandardsInDeveloperTools_Map setIE9StandardsInDeveloperTools_Obj
        {
            get
            {
                if (setIE9StandardsInDeveloperTools == null)
                {
                    setIE9StandardsInDeveloperTools = new setIE9StandardsInDeveloperTools_Map();
                    setIE9StandardsInDeveloperTools.UIBlankPageWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return setIE9StandardsInDeveloperTools;
            }
        }

        public verifyVeryVillaPlus_Map verifyVeryVillaPlus_Obj
        {
            get
            {
                if (verifyVeryVillaPlus == null)
                {
                    verifyVeryVillaPlus = new verifyVeryVillaPlus_Map();
                    verifyVeryVillaPlus.UIVillaFilipaGuiaAlgarWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyVeryVillaPlus;
            }
        }

        public clickDescriptionTab_Map clickDescriptionTab_Obj
        {
            get
            {
                if (clickDescriptionTab == null)
                {
                    clickDescriptionTab = new clickDescriptionTab_Map();
                    clickDescriptionTab.UICasaCamposGuiaAlgarvWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickDescriptionTab;
            }
        }

        public selectAdult_Map selectAdult_Obj
        {
            get
            {
                if (selectAdult == null)
                {
                    selectAdult = new selectAdult_Map();
                    selectAdult.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectAdult;
            }
        }
        
        public selectChild_Map selectChild_Obj
        {
            get
            {
                if (selectChild == null)
                {
                    selectChild = new selectChild_Map();
                    selectChild.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectChild;
            }
        }

        public checkTabAvailablity_Map checkTabAvailablity_Obj
        {
            get
            {
                if (checkTabAvailablity == null)
                {
                    checkTabAvailablity = new checkTabAvailablity_Map();
                    checkTabAvailablity.UICasaDuasInVilamouraAWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return checkTabAvailablity;
            }
        }

        public verifyMaxOccupancyonPopUp_Map verifyMaxOccupancyonPopUp_Obj
        {
            get
            {
                if (verifyMaxOccupancyonPopUp == null)
                {
                    verifyMaxOccupancyonPopUp = new verifyMaxOccupancyonPopUp_Map();
                    verifyMaxOccupancyonPopUp.UISaraInCalanPorterMenWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyMaxOccupancyonPopUp;
            }
        }

        public clickOKonMaxOccupancyPopUp_Map clickOKonMaxOccupancyPopUp_Obj
        {
            get
            {
                if (clickOKonMaxOccupancyPopUp == null)
                {
                    clickOKonMaxOccupancyPopUp = new clickOKonMaxOccupancyPopUp_Map();
                    clickOKonMaxOccupancyPopUp.UISaraInCalanPorterMenWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickOKonMaxOccupancyPopUp;
            }
        }

        public verifyZeroAdultMessage_Map verifyZeroAdultMessage_obj
        {
            get
            {
                if (verifyZeroAdultMessage == null)
                {
                    verifyZeroAdultMessage = new verifyZeroAdultMessage_Map();
                    verifyZeroAdultMessage.UIVillaDamascoInPraiadWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyZeroAdultMessage;
            }
        }

        public verifyActivitiesTabHeadings_Map verifyActivitiesTabHeadings_obj
        {
            get
            {
                if (verifyActivitiesTabHeadings == null)
                {
                    verifyActivitiesTabHeadings = new verifyActivitiesTabHeadings_Map();
                    verifyActivitiesTabHeadings.UIVillaBellinaInAgiosSWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyActivitiesTabHeadings;
            }
        }

        public verifyMinOccupancyonPopup_Map verifyMinOccupancyonPopup_obj
        {
            get
            {
                if (verifyMinOccupancyonPopup == null)
                {
                    verifyMinOccupancyonPopup = new verifyMinOccupancyonPopup_Map();
                    verifyMinOccupancyonPopup.UIVillaKapilaInProtaraWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyMinOccupancyonPopup;
            }
        }


        public clickOnOKMinOccupancyPopup_Map clickOnOKMinOccupancyPopup_obj
        {
            get
            {
                if (clickOnOKMinOccupancyPopup == null)
                {
                    clickOnOKMinOccupancyPopup = new clickOnOKMinOccupancyPopup_Map();
                    clickOnOKMinOccupancyPopup.UIVillaKapilaInProtaraWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickOnOKMinOccupancyPopup;
            }
        }



        public clickOkFromZeroAdultMessage_Map clickOkFromZeroAdultMessage_obj
        {
            get
            {
                if (clickOkFromZeroAdultMessage == null)
                {
                    clickOkFromZeroAdultMessage = new clickOkFromZeroAdultMessage_Map();
                    clickOkFromZeroAdultMessage.UIVillaDamascoInPraiadWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickOkFromZeroAdultMessage;
            }
        }

    }
}
