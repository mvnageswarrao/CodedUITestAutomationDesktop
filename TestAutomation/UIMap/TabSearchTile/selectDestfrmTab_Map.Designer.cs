﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.TabSearchTile.selectDestfrmTab_MapClasses
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
    public partial class selectDestfrmTab_Map:logWriter
    {
        
        /// <summary>
        /// selectDestfrmTab_Method
        /// </summary>
        public string selectDestfrmTab_Method(List<string> centreNAMEList)
        {
            #region Variable Declarations
            HtmlDiv uIItemPane = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIDdDestPane.UIItemPane;
            HtmlCustom uIAlgarveCustom = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIDdDest_optionsPane.UIAlgarveCustom;
            #endregion

            // Click pane
            Mouse.Click(uIItemPane, new Point(10, 2));

            UITestControlCollection ui = uIAlgarveCustom.FindMatchingControls();
            int NumofCentersFrmPage = ui.Count;
            int NumofCentersFrmDB = centreNAMEList.Count;
            Random rnd = new Random();
            int randomcenterindex = rnd.Next(0, NumofCentersFrmDB);
            string SelectableCenter = centreNAMEList[randomcenterindex];

            SelectableCenter = SelectableCenter.Trim();
            string selectedcenter = string.Empty;
            try
            {
                for (int i = 0; i < NumofCentersFrmPage; i++)
                {
                    Mouse.Click(ui[i]);
                    selectedcenter = ui[i].FriendlyName.Trim();
                    if (selectedcenter == SelectableCenter)
                    {
                        WriteLogs("PASS : " + selectedcenter + " is Selected as Destination.");
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
                takeImage("selectDestfrmTab");
                WriteLogs("FAIL : Could Not Select Destination.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

            return selectedcenter;
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
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public UIDdDestPane UIDdDestPane
        {
            get
            {
                if ((this.mUIDdDestPane == null))
                {
                    this.mUIDdDestPane = new UIDdDestPane(this);
                }
                return this.mUIDdDestPane;
            }
        }
        
        public UIDdDest_optionsPane UIDdDest_optionsPane
        {
            get
            {
                if ((this.mUIDdDest_optionsPane == null))
                {
                    this.mUIDdDest_optionsPane = new UIDdDest_optionsPane(this);
                }
                return this.mUIDdDest_optionsPane;
            }
        }
        #endregion
        
        #region Fields
        private UIDdDestPane mUIDdDestPane;
        
        private UIDdDest_optionsPane mUIDdDest_optionsPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDdDestPane : HtmlDiv
    {
        
        public UIDdDestPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "ddDest";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Any Destination", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "spinnerContainer";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"spinnerContainer\" id=\"ddDest\" style=\"width: 210px; height: 35px;\"";
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
    public class UIDdDest_optionsPane : HtmlDiv
    {
        
        public UIDdDest_optionsPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "ddDest_options";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.InnerText, "Any Destination", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "spinnerContainer customDropDownOptions";
            this.FilterProperties.Add(new PropertyExpression(HtmlDiv.PropertyNames.ControlDefinition, "class=\"spinnerContainer customDropDownOptions\" id=\"ddDest_options\" ", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlCustom UIAlgarveCustom
        {
            get
            {
                if ((this.mUIAlgarveCustom == null))
                {
                    this.mUIAlgarveCustom = new HtmlCustom(this);
                    #region Search Criteria
                    this.mUIAlgarveCustom.SearchProperties["TagName"] = "LI";
                    this.mUIAlgarveCustom.FilterProperties.Add(new PropertyExpression("ControlDefinition", "data-value=", PropertyExpressionOperator.Contains));
                    this.mUIAlgarveCustom.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIAlgarveCustom;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCustom mUIAlgarveCustom;
        #endregion
    }
}
