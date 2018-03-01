using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestAutomation.UIMap.HomePage.openBrowser_MapClasses;
using TestAutomation.UIMap.HomePage.enterURL_MapClasses;
using TestAutomation.UIMap.HomePage.clickHomePageLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickThinkSeaViewslink_MapClasses;
using TestAutomation.UIMap.HomePage.clickThinkVillasHeatedPools_MapClasses;
using TestAutomation.UIMap.HomePage.clickWiFiVillas_MapClasses;
using TestAutomation.UIMap.HomePage.clickImageSeaViews_MapClasses;
using TestAutomation.UIMap.HomePage.clickImageHeatedPools_MapClasses;
using TestAutomation.UIMap.HomePage.clickImageWiFi_MapClasses;
using TestAutomation.UIMap.HomePage.clickBrowseSeaViewsLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickBrowseVillasHeatedPoolsLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickBrowseWiFiVillasLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickThinkDestinationsLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickAlgarveMapLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickKefaloniaMapLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickCyprusMapLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickCorfuListLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickMenorcaListLink_mapClasses;
using TestAutomation.UIMap.HomePage.clickDestinitaionsLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickThinkSunshineLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickViewMoreVideosLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickAboutVillaPlusLink_MapClasses;
using TestAutomation.UIMap.HomePage.cickReadMoreAboutUsLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickVoteVillaPlusLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickVoteNowLink_MapClasses;
using TestAutomation.UIMap.HomePage.verifyWhatPeopleSayLink_MapClasses;
using TestAutomation.UIMap.HomePage.verifyVisitTrustPilotLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickContactUsLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickHowToBookLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickVillaOwnersLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickTermsofUseLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickHolidayGamesGuideLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickSitemapLink_MapClasses;
using TestAutomation.UIMap.HomePage.click2323ATOLLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickABTALink_MapClasses;
using TestAutomation.UIMap.HomePage.click28YearsLogoLink_MapClasses;
using TestAutomation.UIMap.HomePage.verifyFacebookLink_MapClasses;
using TestAutomation.UIMap.HomePage.verifyTwitterLink_MapClasses;
using TestAutomation.UIMap.HomePage.verifyGoogleLink_MapClasses;
using TestAutomation.UIMap.HomePage.click2323ATOLPLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickDestinationsMenuLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickDestLandingPage_MapClasses;
using TestAutomation.UIMap.HomePage.clickDestVillasPageLink_MapClasses;
using TestAutomation.UIMap.HomePage.ClickDestResortPageLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickVillasLandingPage_MapClasses;
using TestAutomation.UIMap.HomePage.clickWhyVillaPlusLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickLowDepostMenuBarLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickBrochureRequestLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickFAQsLink_MapClasses;
using TestAutomation.UIMap.HomePage.clickContactUsMenuLink_MapClasses;

namespace TestAutomation.Utility
{
    public class InitiateHomePage
    {
        private openBrowser_Map  OpenBrowser = null;
        private enterURL_Map  EnterURL = null;
        private clickHomePageLink_Map clickHomePageLink = null;
        private clickThinkSeaViewslink_Map clickThinkSeaViewslink = null;
        private clickThinkVillasHeatedPools_Map clickThinkVillasHeatedPools = null;
        private clickWiFiVillas_Map clickWiFiVillas = null;
        private clickImageSeaViews_Map clickImageSeaViews = null;
        private clickImageHeatedPools_Map clickImageHeatedPools = null;
        private clickImageWiFi_Map clickImageWiFi = null;
        private clickBrowseSeaViewsLink_Map clickBrowseSeaViewsLink = null;
        private clickBrowseVillasHeatedPoolsLink_Map clickBrowseVillasHeatedPoolsLink = null;
        private clickBrowseWiFiVillasLink_Map clickBrowseWiFiVillasLink = null;
        private clickThinkDestinationsLink_Map clickThinkDestinationsLink = null;
        private clickAlgarveMapLink_Map clickAlgarveMapLink = null;
        private clickKefaloniaMapLink_Map clickKefaloniaMapLink = null;
        private clickCyprusMapLink_Map clickCyprusMapLink = null;
        private clickCorfuListLink_Map clickCorfuListLink = null;
        private clickMenorcaListLink_map clickMenorcaListLink = null;
        private clickDestinitaionsLink_Map clickDestinitaionsLink = null;
        private clickThinkSunshineLink_Map clickThinkSunshineLink = null;
        private clickViewMoreVideosLink_Map clickViewMoreVideosLink = null;
        private clickAboutVillaPlusLink_Map clickAboutVillaPlusLink = null;
        private cickReadMoreAboutUsLink_Map cickReadMoreAboutUsLink = null;
        private clickVoteVillaPlusLink_Map clickVoteVillaPlusLink = null;
        private clickVoteNowLink_Map clickVoteNowLink = null;
        private verifyWhatPeopleSayLink_Map verifyWhatPeopleSayLink = null;
        private verifyVisitTrustPilotLink_Map verifyVisitTrustPilotLink = null;
        private clickContactUsLink_Map clickContactUsLink = null;
        private clickHowToBookLink_Map clickHowToBookLink = null;
        private clickVillaOwnersLink_Map clickVillaOwnersLink = null;
        private clickTermsofUseLink_Map clickTermsofUseLink = null;
        private clickHolidayGamesGuideLink_Map clickHolidayGamesGuideLink = null;
        private clickSitemapLink_Map clickSitemapLink = null;
        private click2323ATOLLink_Map click2323ATOLLink = null;
        private clickABTALink_Map clickABTALink = null;
        private click28YearsLogoLink_Map click28YearsLogoLink = null;
        private verifyFacebookLink_Map verifyFacebookLink = null;
        private verifyTwitterLink_Map verifyTwitterLink = null;
        private verifyGoogleLink_Map verifyGoogleLink = null;
        private click2323ATOLPLink_Map click2323ATOLPLink = null;
        private clickDestinationsMenuLink_Map clickDestinationsMenuLink = null;
        private clickDestLandingPage_Map clickDestLandingPage = null;
        private clickDestVillasPageLink_Map clickDestVillasPageLink = null;
        private ClickDestResortPageLink_Map ClickDestResortPageLink = null;
        private clickVillasLandingPage_Map clickVillasLandingPage = null;
        private clickWhyVillaPlusLink_Map clickWhyVillaPlusLink = null;
        private clickLowDepostMenuBarLink_Map clickLowDepostMenuBarLink = null;
        private clickBrochureRequestLink_Map clickBrochureRequestLink = null;
        private clickFAQsLink_Map clickFAQsLink = null;
        private clickContactUsMenuLink_Map clickContactUsMenuLink = null;

        public InitiateHomePage()
        {
            OpenBrowser = new openBrowser_Map ();
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

        public clickHomePageLink_Map clickHomePageLink_Obj
        {
            get
            {
                if (clickHomePageLink == null)
                {
                    clickHomePageLink = new clickHomePageLink_Map();
                    clickHomePageLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickHomePageLink;
            }
        }

        public clickThinkSeaViewslink_Map clickThinkSeaViewslink_Obj
        {
            get
            {
                if (clickThinkSeaViewslink == null)
                {
                    clickThinkSeaViewslink = new clickThinkSeaViewslink_Map();
                    clickThinkSeaViewslink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickThinkSeaViewslink;
            }
        }

        public clickThinkVillasHeatedPools_Map clickThinkVillasHeatedPools_Obj
        {
            get
            {
                if (clickThinkVillasHeatedPools == null)
                {
                    clickThinkVillasHeatedPools = new clickThinkVillasHeatedPools_Map();
                    clickThinkVillasHeatedPools.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickThinkVillasHeatedPools;
            }
        }

        public clickWiFiVillas_Map clickWiFiVillas_Obj
        {
            get
            {
                if (clickWiFiVillas == null)
                {
                    clickWiFiVillas = new clickWiFiVillas_Map();
                    clickWiFiVillas.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickWiFiVillas;
            }
        }

        public clickImageSeaViews_Map clickImageSeaViews_Obj
        {
            get
            {
                if (clickImageSeaViews == null)
                {
                    clickImageSeaViews = new clickImageSeaViews_Map();
                    clickImageSeaViews.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickImageSeaViews;
            }
        }

        public clickImageHeatedPools_Map clickImageHeatedPools_Obj
        {
            get
            {
                if (clickImageHeatedPools == null)
                {
                    clickImageHeatedPools = new clickImageHeatedPools_Map();
                    clickImageHeatedPools.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickImageHeatedPools;
            }
        }

        public clickImageWiFi_Map clickImageWiFi_Obj
        {
            get
            {
                if (clickImageWiFi == null)
                {
                    clickImageWiFi = new clickImageWiFi_Map();
                    clickImageWiFi.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickImageWiFi;
            }
        }

        public clickBrowseSeaViewsLink_Map clickBrowseSeaViewsLink_Obj
        {
            get
            {
                if (clickBrowseSeaViewsLink == null)
                {
                    clickBrowseSeaViewsLink = new clickBrowseSeaViewsLink_Map();
                    clickBrowseSeaViewsLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBrowseSeaViewsLink;
            }
        }


        public clickBrowseVillasHeatedPoolsLink_Map clickBrowseVillasHeatedPoolsLink_Obj
        {
            get
            {
                if (clickBrowseVillasHeatedPoolsLink == null)
                {
                    clickBrowseVillasHeatedPoolsLink = new clickBrowseVillasHeatedPoolsLink_Map();
                    clickBrowseVillasHeatedPoolsLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBrowseVillasHeatedPoolsLink;
            }
        }

        public clickBrowseWiFiVillasLink_Map clickBrowseWiFiVillasLink_Obj
        {
            get
            {
                if (clickBrowseWiFiVillasLink == null)
                {
                    clickBrowseWiFiVillasLink = new clickBrowseWiFiVillasLink_Map();
                    clickBrowseWiFiVillasLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBrowseWiFiVillasLink;
            }
        }

        public clickThinkDestinationsLink_Map clickThinkDestinationsLink_Obj
        {
            get
            {
                if (clickThinkDestinationsLink == null)
                {
                    clickThinkDestinationsLink = new clickThinkDestinationsLink_Map();
                    clickThinkDestinationsLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickThinkDestinationsLink;
            }
        }

        public clickAlgarveMapLink_Map clickAlgarveMapLink_Obj
        {
            get
            {
                if (clickAlgarveMapLink == null)
                {
                    clickAlgarveMapLink = new clickAlgarveMapLink_Map();
                    clickAlgarveMapLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAlgarveMapLink;
            }
        }

        public clickKefaloniaMapLink_Map clickKefaloniaMapLink_Obj
        {
            get
            {
                if (clickKefaloniaMapLink == null)
                {
                    clickKefaloniaMapLink = new clickKefaloniaMapLink_Map();
                    clickKefaloniaMapLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickKefaloniaMapLink;
            }
        }


        public clickCyprusMapLink_Map clickCyprusMapLink_Obj
        {
            get
            {
                if (clickCyprusMapLink == null)
                {
                    clickCyprusMapLink = new clickCyprusMapLink_Map();
                    clickCyprusMapLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickCyprusMapLink;
            }
        }

        public clickCorfuListLink_Map clickCorfuListLink_Obj
        {
            get
            {
                if (clickCorfuListLink == null)
                {
                    clickCorfuListLink = new clickCorfuListLink_Map();
                    clickCorfuListLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickCorfuListLink;
            }
        }

        public clickMenorcaListLink_map clickMenorcaListLink_Obj
        {
            get
            {
                if (clickMenorcaListLink == null)
                {
                    clickMenorcaListLink = new clickMenorcaListLink_map();
                    clickMenorcaListLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickMenorcaListLink;
            }
        }

        public clickDestinitaionsLink_Map clickDestinitaionsLink_Obj
        {
            get
            {
                if (clickDestinitaionsLink == null)
                {
                    clickDestinitaionsLink = new clickDestinitaionsLink_Map();
                    clickDestinitaionsLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickDestinitaionsLink;
            }
        }

        public clickThinkSunshineLink_Map clickThinkSunshineLink_Obj
        {
            get
            {
                if (clickThinkSunshineLink == null)
                {
                    clickThinkSunshineLink = new clickThinkSunshineLink_Map();
                    clickThinkSunshineLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickThinkSunshineLink;
            }
        }

        public clickViewMoreVideosLink_Map clickViewMoreVideosLink_Obj
        {
            get
            {
                if (clickViewMoreVideosLink == null)
                {
                    clickViewMoreVideosLink = new clickViewMoreVideosLink_Map();
                    clickViewMoreVideosLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickViewMoreVideosLink;
            }
        }

        public clickAboutVillaPlusLink_Map clickAboutVillaPlusLink_Obj
        {
            get
            {
                if (clickAboutVillaPlusLink == null)
                {
                    clickAboutVillaPlusLink = new clickAboutVillaPlusLink_Map();
                    clickAboutVillaPlusLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAboutVillaPlusLink;
            }
        }

        public cickReadMoreAboutUsLink_Map cickReadMoreAboutUsLink_Obj
        {
            get
            {
                if (cickReadMoreAboutUsLink == null)
                {
                    cickReadMoreAboutUsLink = new cickReadMoreAboutUsLink_Map();
                    cickReadMoreAboutUsLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return cickReadMoreAboutUsLink;
            }
        }

        public clickVoteVillaPlusLink_Map clickVoteVillaPlusLink_Obj
        {
            get
            {
                if (clickVoteVillaPlusLink == null)
                {
                    clickVoteVillaPlusLink = new clickVoteVillaPlusLink_Map();
                    clickVoteVillaPlusLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickVoteVillaPlusLink;
            }
        }

        public clickVoteNowLink_Map clickVoteNowLink_Obj
        {
            get
            {
                if (clickVoteNowLink == null)
                {
                    clickVoteNowLink = new clickVoteNowLink_Map();
                    clickVoteNowLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickVoteNowLink;
            }
        }

        public verifyWhatPeopleSayLink_Map verifyWhatPeopleSayLink_Obj
        {
            get
            {
                if (verifyWhatPeopleSayLink == null)
                {
                    verifyWhatPeopleSayLink = new verifyWhatPeopleSayLink_Map();
                    verifyWhatPeopleSayLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyWhatPeopleSayLink;
            }
        }

        public verifyVisitTrustPilotLink_Map verifyVisitTrustPilotLink_Obj
        {
            get
            {
                if (verifyVisitTrustPilotLink == null)
                {
                    verifyVisitTrustPilotLink = new verifyVisitTrustPilotLink_Map();
                    verifyVisitTrustPilotLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyVisitTrustPilotLink;
            }
        }

        public clickContactUsLink_Map clickContactUsLink_Obj
        {
            get
            {
                if (clickContactUsLink == null)
                {
                    clickContactUsLink = new clickContactUsLink_Map();
                    clickContactUsLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickContactUsLink;
            }
        }

        public clickHowToBookLink_Map clickHowToBookLink_Obj
        {
            get
            {
                if (clickHowToBookLink == null)
                {
                    clickHowToBookLink = new clickHowToBookLink_Map();
                    clickHowToBookLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickHowToBookLink;
            }
        }

        public clickVillaOwnersLink_Map clickVillaOwnersLink_Obj
        {
            get
            {
                if (clickVillaOwnersLink == null)
                {
                    clickVillaOwnersLink = new clickVillaOwnersLink_Map();
                    clickVillaOwnersLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickVillaOwnersLink;
            }
        }

        public clickTermsofUseLink_Map clickTermsofUseLink_Obj
        {
            get
            {
                if (clickTermsofUseLink == null)
                {
                    clickTermsofUseLink = new clickTermsofUseLink_Map();
                    clickTermsofUseLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickTermsofUseLink;
            }
        }

        public clickHolidayGamesGuideLink_Map clickHolidayGamesGuideLink_Obj
        {
            get
            {
                if (clickHolidayGamesGuideLink == null)
                {
                    clickHolidayGamesGuideLink = new clickHolidayGamesGuideLink_Map();
                    clickHolidayGamesGuideLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickHolidayGamesGuideLink;
            }
        }

        public clickSitemapLink_Map clickSitemapLink_Obj
        {
            get
            {
                if (clickSitemapLink == null)
                {
                    clickSitemapLink = new clickSitemapLink_Map();
                    clickSitemapLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSitemapLink;
            }
        }

        public click2323ATOLLink_Map click2323ATOLLink_Obj
        {
            get
            {
                if (click2323ATOLLink == null)
                {
                    click2323ATOLLink = new click2323ATOLLink_Map();
                    click2323ATOLLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return click2323ATOLLink;
            }
        }

        public clickABTALink_Map clickABTALink_Obj
        {
            get
            {
                if (clickABTALink == null)
                {
                    clickABTALink = new clickABTALink_Map();
                    clickABTALink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickABTALink;
            }
        }

        public click28YearsLogoLink_Map click28YearsLogoLink_Obj
        {
            get
            {
                if (click28YearsLogoLink == null)
                {
                    click28YearsLogoLink = new click28YearsLogoLink_Map();
                    click28YearsLogoLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return click28YearsLogoLink;
            }
        }

        public verifyFacebookLink_Map verifyFacebookLink_Obj
        {
            get
            {
                if (verifyFacebookLink == null)
                {
                    verifyFacebookLink = new verifyFacebookLink_Map();
                    verifyFacebookLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyFacebookLink;
            }
        }

        public verifyTwitterLink_Map verifyTwitterLink_Obj
        {
            get
            {
                if (verifyTwitterLink == null)
                {
                    verifyTwitterLink = new verifyTwitterLink_Map();
                    verifyTwitterLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyTwitterLink;
            }
        }

        public verifyGoogleLink_Map verifyGoogleLink_Obj
        {
            get
            {
                if (verifyGoogleLink == null)
                {
                    verifyGoogleLink = new verifyGoogleLink_Map();
                    verifyGoogleLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyGoogleLink;
            }
        }

        public click2323ATOLPLink_Map click2323ATOLPLink_Obj
        {
            get
            {
                if (click2323ATOLPLink == null)
                {
                    click2323ATOLPLink = new click2323ATOLPLink_Map();
                    click2323ATOLPLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return click2323ATOLPLink;
            }
        }

        public clickDestinationsMenuLink_Map clickDestinationsMenuLink_Obj
        {
            get
            {
                if (clickDestinationsMenuLink == null)
                {
                    clickDestinationsMenuLink = new clickDestinationsMenuLink_Map();
                    clickDestinationsMenuLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickDestinationsMenuLink;
            }
        }

        public clickDestLandingPage_Map clickDestLandingPage_Obj
        {
            get
            {
                if (clickDestLandingPage == null)
                {
                    clickDestLandingPage = new clickDestLandingPage_Map();
                    clickDestLandingPage.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickDestLandingPage;
            }
        }

        public clickDestVillasPageLink_Map clickDestVillasPageLink_Obj
        {
            get
            {
                if (clickDestVillasPageLink == null)
                {
                    clickDestVillasPageLink = new clickDestVillasPageLink_Map();
                    clickDestVillasPageLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickDestVillasPageLink;
            }
        }

        public ClickDestResortPageLink_Map ClickDestResortPageLink_Obj
        {
            get
            {
                if (ClickDestResortPageLink == null)
                {
                    ClickDestResortPageLink = new ClickDestResortPageLink_Map();
                    ClickDestResortPageLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return ClickDestResortPageLink;
            }
        }

        public clickVillasLandingPage_Map clickVillasLandingPage_Obj
        {
            get
            {
                if (clickVillasLandingPage == null)
                {
                    clickVillasLandingPage = new clickVillasLandingPage_Map();
                    clickVillasLandingPage.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickVillasLandingPage;
            }
        }

        public clickWhyVillaPlusLink_Map clickWhyVillaPlusLink_Obj
        {
            get
            {
                if (clickWhyVillaPlusLink == null)
                {
                    clickWhyVillaPlusLink = new clickWhyVillaPlusLink_Map();
                    clickWhyVillaPlusLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickWhyVillaPlusLink;
            }
        }

        public clickLowDepostMenuBarLink_Map clickLowDepostMenuBarLink_Obj
        {
            get
            {
                if (clickLowDepostMenuBarLink == null)
                {
                    clickLowDepostMenuBarLink = new clickLowDepostMenuBarLink_Map();
                    clickLowDepostMenuBarLink.UIVillaHolidaysThatYouWindow1.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickLowDepostMenuBarLink;
            }
        }

        public clickBrochureRequestLink_Map clickBrochureRequestLink_Obj
        {
            get
            {
                if (clickBrochureRequestLink == null)
                {
                    clickBrochureRequestLink = new clickBrochureRequestLink_Map();
                    clickBrochureRequestLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBrochureRequestLink;
            }
        }

        public clickFAQsLink_Map clickFAQsLink_Obj
        {
            get
            {
                if (clickFAQsLink == null)
                {
                    clickFAQsLink = new clickFAQsLink_Map();
                    clickFAQsLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickFAQsLink;
            }
        }

        public clickContactUsMenuLink_Map clickContactUsMenuLink_Obj
        {
            get
            {
                if (clickContactUsMenuLink == null)
                {
                    clickContactUsMenuLink = new clickContactUsMenuLink_Map();
                    clickContactUsMenuLink.UIVillaHolidaysThatYouWindow.CopyFrom(OpenBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickContactUsMenuLink;
            }
        }

    }

    }
