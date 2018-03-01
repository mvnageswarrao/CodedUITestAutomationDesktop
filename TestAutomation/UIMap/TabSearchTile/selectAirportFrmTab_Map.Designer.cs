﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.TabSearchTile.selectAirportFrmTab_MapClasses
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
    public partial class selectAirportFrmTab_Map:logWriter
    {
        
        /// <summary>
        /// selectAirportFrmTab_Method
        /// </summary>
        public string selectAirportFrmTab_Method()
        {
            #region Variable Declarations
            HtmlDiv uIItemPane = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIDdDepAirportPane.UIItemPane;
            HtmlCustom uIAllNorthWestCustom = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIDdDepAirport_optionsPane.UIAllNorthWestCustom;
            #endregion

            // Click pane
            Mouse.Click(uIItemPane, new Point(5, 1));

            //// Click 'All North West' custom control
            //Mouse.Click(uIAllNorthWestCustom, new Point(132, 25));

            UITestControlCollection ui = uIAllNorthWestCustom.FindMatchingControls();
            int NumofAirportFrmPage = ui.Count;
            Random rnd = new Random();
            int randomAiportsindex = rnd.Next(0, NumofAirportFrmPage);
            //string SelectableAiport = centreNAMEList[randomcenterindex];

            //SelectableCenter = SelectableCenter.Trim();
            string selectedAirport = string.Empty;

            try
            {
                for (int i = 0; i <= randomAiportsindex; i++)
                {
                    Mouse.Click(ui[i]);
                    selectedAirport = ui[i].FriendlyName.Trim();
                    if (i == randomAiportsindex)
                    {
                        WriteLogs("PASS : " + selectedAirport + " Selected as Airport.");
                        break;
                    }
                    else
                    {
                        Mouse.Click(uIItemPane, new Point(10, 2));
                    }
                }
            }
            catch (AssertFailedException ex)
            {
                takeImage("selectAirportFrmTab");
                WriteLogs("FAIL : Could Not Select Airport.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

            return selectedAirport;
        }
        
        #region Properties
        public UIVillaHolidaysThatYouWindow UIVillaHolidaysThatYouWindow
        {
            get
            {
                if ((this.mUIVillaHolidaysThatYouWindow == null))
                {
                    this.mUIVillaHolidaysThatYouWindow = new UIVillaHolidaysThatYouWindow();
                }
                return this.mUIVillaHolidaysThatYouWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaHolidaysThatYouWindow mUIVillaHolidaysThatYouWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaHolidaysThatYouWindow : BrowserWindow
    {
        
        public UIVillaHolidaysThatYouWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "| Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaHolidaysThatYouDocument UIVillaHolidaysThatYouDocument
        {
            get
            {
                if ((this.mUIVillaHolidaysThatYouDocument == null))
                {
                    this.mUIVillaHolidaysThatYouDocument = new UIVillaHolidaysThatYouDocument(this);
                }
                return this.mUIVillaHolidaysThatYouDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaHolidaysThatYouDocument mUIVillaHolidaysThatYouDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaHolidaysThatYouDocument : HtmlDocument
    {
        
        public UIVillaHolidaysThatYouDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "| Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIDdDepAirportPane UIDdDepAirportPane
        {
            get
            {
                if ((this.mUIDdDepAirportPane == null))
                {
                    this.mUIDdDepAirportPane = new UIDdDepAirportPane(this);
                }
                return this.mUIDdDepAirportPane;
            }
        }
        
        public UIDdDepAirport_optionsPane UIDdDepAirport_optionsPane
        {
            get
            {
                if ((this.mUIDdDepAirport_optionsPane == null))
                {
                    this.mUIDdDepAirport_optionsPane = new UIDdDepAirport_optionsPane(this);
                }
                return this.mUIDdDepAirport_optionsPane;
            }
        }
        #endregion
        
        #region Fields
        private UIDdDepAirportPane mUIDdDepAirportPane;
        
        private UIDdDepAirport_optionsPane mUIDdDepAirport_optionsPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDdDepAirportPane : HtmlDiv
    {
        
        public UIDdDepAirportPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "ddDepAirport";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "All London", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "spinnerContainer";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"spinnerContainer\" id=\"ddDepAirport\" style=\"width: 210px; height: 35px;\"";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIItemPane
        {
            get
            {
                if ((this.mUIItemPane == null))
                {
                    this.mUIItemPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "dropDownArrow";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"dropDownArrow\" style=\"margin-top: 12px;\"";
                    this.mUIItemPane.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIItemPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIItemPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDdDepAirport_optionsPane : HtmlDiv
    {
        
        public UIDdDepAirport_optionsPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "ddDepAirport_options";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "All London", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "spinnerContainer customDropDownOptions";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"spinnerContainer customDropDownOptions\" id=\"ddDepAirport_options\" style=\"l" +
                "eft: 0px; top: 35px; min-width: 210px;\" data-parent=\"ddDepAirport\"";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlCustom UIAllNorthWestCustom
        {
            get
            {
                if ((this.mUIAllNorthWestCustom == null))
                {
                    this.mUIAllNorthWestCustom = new HtmlCustom(this);
                    #region Search Criteria
                    this.mUIAllNorthWestCustom.SearchProperties["TagName"] = "LI";
                    this.mUIAllNorthWestCustom.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIAllNorthWestCustom;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCustom mUIAllNorthWestCustom;
        #endregion
    }
}