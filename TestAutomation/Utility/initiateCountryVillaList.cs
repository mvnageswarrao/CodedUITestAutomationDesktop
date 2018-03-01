using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.UIMap.CountryVillaList.OpenBrowserIE_MapClasses;
using TestAutomation.UIMap.CountryVillaList.OpenHomePage_MapClasses;
using TestAutomation.UIMap.CountryVillaList.OpenDestPage_MapClasses;
using TestAutomation.UIMap.CountryVillaList.OpenVillalistfromDestPage_MapClasses;
using TestAutomation.UIMap.CountryVillaList.VerifyIntroText_MapClasses;
using TestAutomation.UIMap.CountryVillaList.ClickViewVillabtn_MapClasses;
using TestAutomation.UIMap.CountryVillaList.ClickMapView_MapClasses;
using TestAutomation.UIMap.CountryVillaList.ClickListView_MapClasses;
using TestAutomation.UIMap.CountryVillaList.ClickBacktoVillas_MapClasses;
using TestAutomation.UIMap.CountryVillaList.ClickAlllink_MapClasses;
using TestAutomation.UIMap.CountryVillaList.VerifyVillaOverview_MapClasses;
using TestAutomation.UIMap.CountryVillaList.getFirstVillaName_MapClasses;
using TestAutomation.UIMap.CountryVillaList.ResortFilters_MapClasses;

namespace TestAutomation.Utility
{
    public class initiateCountryVillaList
    {
        private OpenBrowserIE_Map OpenBrowserIE = null;
        private OpenHomePage_Map OpenHomePage = null;
        private OpenDestPage_Map OpenDestPage = null;
        private OpenVillalistfromDestPage_Map OpenVillalistfromDestPage = null;
        private VerifyIntroText_Map VerifyIntrotext = null;
        private ClickViewVillabtn_Map ClickViewVillabtn = null;
        private ClickMapView_Map ClickMapView = null;
        private ClickListView_Map ClickListView = null;
        private ClickBacktoVillas_Map ClickBacktoVillas = null;
        private ClickAlllink_Map ClickAllLink = null;
        private VerifyVillaOverview_Map VerifyVillaOverView = null;
        private getFirstVillaName_Map getFirstVillaName = null;
        private ResortFilters_Map ResortFilters = null;

        public initiateCountryVillaList()
        {
            OpenBrowserIE = new OpenBrowserIE_Map();
        }

        public OpenBrowserIE_Map OpenBrowser_Obj
        {
            get { return OpenBrowserIE;  }
            set { OpenBrowserIE = value; }
        }

        public OpenHomePage_Map OpenHomePage_Obj
        {
            get 
            {
                if (OpenHomePage == null)
                {
                    OpenHomePage = new OpenHomePage_Map();
                  //  OpenHomePage.UIBlankPageWindowsInteWindow.CopyFrom(OpenHomePage.UIBlankPageWindowsInteWindow);
                }
                return OpenHomePage;
            }
        
        }

        public OpenDestPage_Map OpenDestPage_Obj
        {
            get
            {
                if (OpenDestPage == null)
                {
                    OpenDestPage = new OpenDestPage_Map();
                    OpenDestPage.UIHomePageWindowsInterWindow.CopyFrom(OpenHomePage.UIBlankPageWindowsInteWindow);
                }
                return OpenDestPage;
            }
        }

        public OpenVillalistfromDestPage_Map OpenVillalistfromDestPage_Obj
         {
        get
            {
                if (OpenVillalistfromDestPage == null)
                {
                    OpenVillalistfromDestPage = new OpenVillalistfromDestPage_Map();
                    OpenVillalistfromDestPage.UIHttpnimbusalgarvehomWindow.CopyFrom(OpenHomePage.UIBlankPageWindowsInteWindow);
              
                }
                return (OpenVillalistfromDestPage);
            } 
  
        }

        public VerifyIntroText_Map VerifyIntroText_Obj
        {
            get
            {
                if (VerifyIntrotext == null)
                {
                    VerifyIntrotext = new VerifyIntroText_Map();
                    VerifyIntrotext.UIHttpnimbusAlgarvevilWindow.CopyFrom(OpenHomePage.UIBlankPageWindowsInteWindow);
                }
                return (VerifyIntrotext);
            }
        }

        public ClickViewVillabtn_Map ClickViewVillabtn_Obj
        {
            get
            {
                if (ClickViewVillabtn == null)
                {
                    ClickViewVillabtn = new ClickViewVillabtn_Map();
                    ClickViewVillabtn.UIHttpnimbusAlgarvevilWindow.CopyFrom(OpenHomePage.UIBlankPageWindowsInteWindow);
                }
                return (ClickViewVillabtn);
            }
        }

        public ClickMapView_Map ClickMapView_Obj
        {
            get
            {
                if(ClickMapView == null)
                {
                    ClickMapView = new ClickMapView_Map();
                    ClickMapView.UIHttpnimbusAlgarvevilWindow.CopyFrom(OpenHomePage.UIBlankPageWindowsInteWindow);
                }
                return (ClickMapView);
            }
        }
        public ClickListView_Map ClickListView_Obj
        {
            get
            {
                if (ClickListView == null)
                {
                    ClickListView = new ClickListView_Map();
                    ClickListView.UIHttpnimbusAlgarvevilWindow.CopyFrom(OpenHomePage.UIBlankPageWindowsInteWindow);
                }
                return (ClickListView);
            }
        }
        public ClickBacktoVillas_Map ClickBacktoVillas_Obj
        {
            get
            {
                if (ClickBacktoVillas == null)
                {
                    ClickBacktoVillas = new ClickBacktoVillas_Map();
                    ClickBacktoVillas.UICanas1bdrmEQuintadoLWindow.CopyFrom(OpenHomePage.UIBlankPageWindowsInteWindow);
                }
                return (ClickBacktoVillas);
            }
        }
        public ClickAlllink_Map ClickAllLink_Obj
        {
            get
            {
                if (ClickAllLink == null)
                {
                    ClickAllLink = new ClickAlllink_Map();
                    ClickAllLink.UIHttpnimbusAlgarvevilWindow.CopyFrom(OpenHomePage.UIBlankPageWindowsInteWindow);
                }
                return ClickAllLink;
            }
         }
        public VerifyVillaOverview_Map VerifyVillaOverView_Obj
        {
            get
            {
                if (VerifyVillaOverView == null)
                {
                    VerifyVillaOverView = new VerifyVillaOverview_Map();
                    VerifyVillaOverView.UIHttpnimbusAlgarvevilWindow.CopyFrom(OpenHomePage.UIBlankPageWindowsInteWindow);
                }
                return VerifyVillaOverView;
            }
        }


        public getFirstVillaName_Map getFirstVillaName_Obj
        {
            get
            {
                if (getFirstVillaName == null)
                {
                    getFirstVillaName = new getFirstVillaName_Map();
                    getFirstVillaName.UIHttpnimbusAlgarvevilWindow.CopyFrom(OpenHomePage.UIBlankPageWindowsInteWindow);
                }
                return getFirstVillaName;
            }
        }
        public ResortFilters_Map ResortFilters_Obj
        {
            get
            {
                if(ResortFilters == null)
                {
                    ResortFilters = new ResortFilters_Map();
                    ResortFilters.UIHttpnimbusAlgarvevilWindow.CopyFrom(OpenHomePage.UIBlankPageWindowsInteWindow);
                }
                return ResortFilters;
            }
        }
    }
}
