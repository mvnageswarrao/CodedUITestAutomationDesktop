using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestAutomation.UIMap.DestinationsPage.openBrowser_MapClasses;
using TestAutomation.UIMap.DestinationsPage.enterURL_MapClasses;
using TestAutomation.UIMap.DestinationsPage.setIE9StandardsInDeveloperTools_MapClasses;
using TestAutomation.UIMap.DestinationsPage.verifyHeadingText_MapClasses;
using TestAutomation.UIMap.DestinationsPage.verifyNoOfVillasPerCentre_MapClasses;
using TestAutomation.UIMap.DestinationsPage.clickListViewTab_MapClasses;
using TestAutomation.UIMap.DestinationsPage.clickMapViewTab_MapClasses;
using TestAutomation.UIMap.DestinationsPage.clickViewVillas_MapClasses;
using TestAutomation.UIMap.DestinationsPage.clickViewResorts_MapClasses;
using TestAutomation.UIMap.DestinationsPage.clickCountryImage_MapClasses;
using TestAutomation.UIMap.DestinationsPage.verifyHrefInCountryName_MapClasses;
using TestAutomation.UIMap.DestinationsPage.verifyImageAltTag_MapClasses;


namespace TestAutomation.Utility
{
    public class InitiateDestinationPage
    {
        private setIE9StandardsInDeveloperTools_Map setIE9StandardsInDeveloperTools = null;
        private openBrowser_Map openBrowser = null;
        private enterURL_Map enterURL = null;
        private clickListViewTab_Map clickListViewTab = null;
        private clickMapViewTab_Map clickMapViewTab = null;
        private clickViewVillas_Map clickViewVillas = null;
        private clickViewResorts_Map clickViewResorts = null;
        private clickCountryImage_Map clickCountryImage = null;
        
        private verifyHeadingText_Map verifyHeadingText = null;
        private verifyNoOfVillasPerCentre_Map verifyNoOfVillasPerCentre = null;
        private verifyHrefInCountryName_Map verifyHrefInCountryName = null;
        private verifyImageAltTag_Map verifyImageAltTag = null;

        public InitiateDestinationPage()
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

        public setIE9StandardsInDeveloperTools_Map setIE9StandardsInDeveloperTools_Obj
        {
            get
            {
                if (setIE9StandardsInDeveloperTools == null)
                {
                    setIE9StandardsInDeveloperTools = new setIE9StandardsInDeveloperTools_Map();
                    setIE9StandardsInDeveloperTools.UIHttpnimbusdestinatioWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return setIE9StandardsInDeveloperTools;
            }
        }

        public clickListViewTab_Map clickListViewTab_Obj
        {
            get
            {
                if (clickListViewTab == null)
                {
                    clickListViewTab = new clickListViewTab_Map();
                    clickListViewTab.UIHttpnimbusdestinatioWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickListViewTab;
            }
        }

        public clickMapViewTab_Map clickMapViewTab_Obj
        {
            get
            {
                if (clickMapViewTab == null)
                {
                    clickMapViewTab = new clickMapViewTab_Map();
                    clickMapViewTab.UIHttpnimbusdestinatioWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickMapViewTab;
            }
        }

        public verifyHeadingText_Map verifyHeadingText_Obj
        {
            get
            {
                if (verifyHeadingText == null)
                {
                    verifyHeadingText = new verifyHeadingText_Map();
                    verifyHeadingText.UIHttpnimbusdestinatioWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyHeadingText;
            }
        }

        public verifyNoOfVillasPerCentre_Map verifyNoOfVillasPerCentre_Obj
        {
            get
            {
                if (verifyNoOfVillasPerCentre == null)
                {
                    verifyNoOfVillasPerCentre = new verifyNoOfVillasPerCentre_Map();
                    verifyNoOfVillasPerCentre.UIHttpnimbusdestinatioWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyNoOfVillasPerCentre;
            }
        }

        public clickViewVillas_Map clickViewVillas_Obj
        {
            get
            {
                if (clickViewVillas == null)
                {
                    clickViewVillas = new clickViewVillas_Map();
                    clickViewVillas.UIHttpnimbusdestinatioWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickViewVillas;
            }
        }

        public clickViewResorts_Map clickViewResorts_Obj
        {
            get
            {
                if (clickViewResorts == null)
                {
                    clickViewResorts = new clickViewResorts_Map();
                    clickViewResorts.UIHttpnimbusdestinatioWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickViewResorts;
            }
        }

        public clickCountryImage_Map clickCountryImage_Obj
        {
            get
            {
                if (clickCountryImage == null)
                {
                    clickCountryImage = new clickCountryImage_Map();
                    clickCountryImage.UIHttpnimbusdestinatioWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickCountryImage;
            }
        }

        public verifyHrefInCountryName_Map verifyHrefInCountryName_Obj
        {
            get
            {
                if (verifyHrefInCountryName == null)
                {
                    verifyHrefInCountryName = new verifyHrefInCountryName_Map();
                    verifyHrefInCountryName.UIHttpnimbusdestinatioWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyHrefInCountryName;
            }
        }

        public verifyImageAltTag_Map verifyImageAltTag_Obj
        {
            get
            {
                if (verifyImageAltTag == null)
                {
                    verifyImageAltTag = new verifyImageAltTag_Map();
                    verifyImageAltTag.UIHttpnimbusdestinatioWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyImageAltTag;
            }
        }
    }
}
