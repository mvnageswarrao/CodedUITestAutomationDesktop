﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.TabSearchTile.enterNumofChildinTab_MapClasses
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
    public partial class enterNumofChildinTab_Map:logWriter
    {
        
        /// <summary>
        /// enterNumofChildinTab_Method - Use 'enterNumofChildinTab_MethodParams' to pass parameters into this method.
        /// </summary>
        public int enterNumofChildinTab_Method(int MaxOCCUPANCY)
        {
            #region Variable Declarations
            HtmlEdit uIItemEdit = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIChildrenPane.UIItemEdit;
            #endregion

            //int Numofitems = MaxOCCUPANCY / 2;
            int Numofitems = 5;
            Random rnd = new Random();
            int randomChildNum = rnd.Next(1, Numofitems);
            int NumofChildSelected = 0;
                    
            try
            {
                // Type '2' in text box
                uIItemEdit.Text =Convert.ToString(randomChildNum);
                NumofChildSelected = randomChildNum;
                WriteLogs("PASS : \"" + NumofChildSelected + "\" Child Selected.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("enterNumofChildinTab");
                WriteLogs("FAIL : Could Not Select Num of Child in Tablet Search Tile.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

            return NumofChildSelected;
        }
        
        #region Properties
        public virtual enterNumofChildinTab_MethodParams enterNumofChildinTab_MethodParams
        {
            get
            {
                if ((this.menterNumofChildinTab_MethodParams == null))
                {
                    this.menterNumofChildinTab_MethodParams = new enterNumofChildinTab_MethodParams();
                }
                return this.menterNumofChildinTab_MethodParams;
            }
        }
        
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
        private enterNumofChildinTab_MethodParams menterNumofChildinTab_MethodParams;
        
        private UIVillaHolidaysThatYouWindow mUIVillaHolidaysThatYouWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'enterNumofChildinTab_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class enterNumofChildinTab_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Type '2' in text box
        /// </summary>
        public string UIItemEditText = "2";
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
        public UIChildrenPane UIChildrenPane
        {
            get
            {
                if ((this.mUIChildrenPane == null))
                {
                    this.mUIChildrenPane = new UIChildrenPane(this);
                }
                return this.mUIChildrenPane;
            }
        }
        #endregion
        
        #region Fields
        private UIChildrenPane mUIChildrenPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIChildrenPane : HtmlDiv
    {
        
        public UIChildrenPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "divChildren";
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Children";
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "spinnerContainer";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"spinnerContainer\" id=\"divChildren\" style=\"width: 185px; height: 35px;\"";
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.SearchProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIItemEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "spinnerTextInput calendarHeaders";
                    this.mUIItemEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "class=\"spinnerTextInput calendarHeaders\"";
                    this.mUIItemEdit.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUIItemEdit;
        #endregion
    }
}
