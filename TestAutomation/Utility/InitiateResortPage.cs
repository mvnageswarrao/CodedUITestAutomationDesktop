using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestAutomation.UIMap.ResortPage.openBrowser_MapClasses;
using TestAutomation.UIMap.ResortPage.enterURL_MapClasses;
using TestAutomation.UIMap.ResortPage.setIE9StandardsInDeveloperTools_MapClasses;
using TestAutomation.UIMap.ResortPage.clickListViewTab_MapClasses;
using TestAutomation.UIMap.ResortPage.clickMapViewTab_MapClasses;
using TestAutomation.UIMap.ResortPage.verifyHeadingText_MapClasses;
using TestAutomation.UIMap.ResortPage.verifyResortsIntroText_MapClasses;
using TestAutomation.UIMap.ResortPage.verifyResortsCount_MapClasses;
using TestAutomation.UIMap.ResortPage.clickViewVillasBtn_MapClasses;
using TestAutomation.UIMap.ResortPage.clickFindOutMore_MapClasses;
using TestAutomation.UIMap.ResortPage.clickResortImage_MapClasses;
using TestAutomation.UIMap.ResortPage.verifyResortDescriptionText_MapClasses;

namespace TestAutomation.Utility
{
    public class InitiateResortPage
    {
        private setIE9StandardsInDeveloperTools_Map setIE9StandardsInDeveloperTools = null;
        private openBrowser_Map openBrowser = null;
        private enterURL_Map enterURL = null;

        private clickListViewTab_Map clickListViewTab = null;
        private clickMapViewTab_Map clickMapViewTab = null;
        private verifyHeadingText_Map verifyHeadingText = null;
        private verifyResortsIntroText_Map verifyResortsIntroText = null;
        private verifyResortsCount_Map verifyResortsCount = null;
        private clickViewVillasBtn_Map clickViewVillasBtn = null;
        private clickFindOutMore_Map clickFindOutMore = null;
        private clickResortImage_Map clickResortImage = null;
        private verifyResortDescriptionText_Map verifyResortDescriptionText = null;

        public InitiateResortPage()
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
                    clickListViewTab.UIHolidayVillaResortsiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
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
                    clickMapViewTab.UIHolidayVillaResortsiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
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
                    verifyHeadingText.UIHolidayVillaResortsiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyHeadingText;
            }
        }

        public verifyResortsIntroText_Map verifyResortsIntroText_Obj
        {
            get
            {
                if (verifyResortsIntroText == null)
                {
                    verifyResortsIntroText = new verifyResortsIntroText_Map();
                    verifyResortsIntroText.UIHolidayVillaResortsiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyResortsIntroText;
            }
        }

        public verifyResortsCount_Map verifyResortsCount_Obj
        {
            get
            {
                if (verifyResortsCount == null)
                {
                    verifyResortsCount = new verifyResortsCount_Map();
                    verifyResortsCount.UIHolidayVillaResortsiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyResortsCount;
            }
        }

        public clickViewVillasBtn_Map clickViewVillasBtn_Obj
        {
            get
            {
                if (clickViewVillasBtn == null)
                {
                    clickViewVillasBtn = new clickViewVillasBtn_Map();
                    clickViewVillasBtn.UIHolidayVillaResortsiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickViewVillasBtn;
            }
        }

        public clickFindOutMore_Map clickFindOutMore_Obj
        {
            get
            {
                if (clickFindOutMore == null)
                {
                    clickFindOutMore = new clickFindOutMore_Map();
                    clickFindOutMore.UIHolidayVillaResortsiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickFindOutMore;
            }
        }

        public clickResortImage_Map clickResortImage_Obj
        {
            get
            {
                if (clickResortImage == null)
                {
                    clickResortImage = new clickResortImage_Map();
                    clickResortImage.UIHolidayVillaResortsiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickResortImage;
            }
        }

        public verifyResortDescriptionText_Map verifyResortDescriptionText_Obj
        {
            get
            {
                if (verifyResortDescriptionText == null)
                {
                    verifyResortDescriptionText = new verifyResortDescriptionText_Map();
                    verifyResortDescriptionText.UIHolidayVillaResortsiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyResortDescriptionText;
            }
        }
    }
}
