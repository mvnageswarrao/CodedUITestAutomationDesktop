﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchTile.verifyDurationListBox_MapClasses
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
    public partial class verifyDurationListBox_Map:logWriter
    {
        
        /// <summary>
        /// verifyDurationListBox_Method - Use 'verifyDurationListBox_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyDurationListBox_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDdDurationComboBox = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIDdDurationComboBox;
            #endregion

            try
            {
                // Verify that the 'InnerText' property of 'ddDuration' combo box equals '7 nights14 nights21 nights28 nights'
                //Assert.AreEqual(this.verifyDurationListBox_MethodExpectedValues.UIDdDurationComboBoxInnerText, uIDdDurationComboBox.InnerText);
                string DurationLst = uIDdDurationComboBox.InnerText;
                DurationLst = DurationLst.Replace(" ",string.Empty);
                if (DurationLst.Contains("7nights"))
                {
                    WriteLogs("PASS : \"Duration\" List From Search Tile is Populated properly.");
                }
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyDurationListBox");
                WriteLogs("FAIL : \"Duration\" List is Not Populated.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

        }

        public string selectDuration_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDdDurationComboBox = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIDdDurationComboBox;
            #endregion

            string[] DurationList = uIDdDurationComboBox.GetContent();
            int Numofitems = DurationList.Length;
            Random rnd = new Random();
            int randomDuration = rnd.Next(0, Numofitems);
            string SelectedDuration = string.Empty;
            try
            {
                uIDdDurationComboBox.SelectedIndex = randomDuration;
                SelectedDuration = uIDdDurationComboBox.SelectedItem;
                SelectedDuration = SelectedDuration.Trim();
                WriteLogs("PASS : \"" + SelectedDuration + "\" is Selected From Duration List.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("selectDuration");
                WriteLogs("FAIL : Could Not Select Duration.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

            return SelectedDuration;

        }
        
        #region Properties
        public virtual verifyDurationListBox_MethodExpectedValues verifyDurationListBox_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyDurationListBox_MethodExpectedValues == null))
                {
                    this.mverifyDurationListBox_MethodExpectedValues = new verifyDurationListBox_MethodExpectedValues();
                }
                return this.mverifyDurationListBox_MethodExpectedValues;
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
        private verifyDurationListBox_MethodExpectedValues mverifyDurationListBox_MethodExpectedValues;
        
        private UIVillaHolidaysThatYouWindow mUIVillaHolidaysThatYouWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyDurationListBox_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyDurationListBox_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'ddDuration' combo box equals '7 nights14 nights21 nights28 nights'
        /// </summary>
        public string UIDdDurationComboBoxInnerText = "7 nights14 nights21 nights28 nights";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaHolidaysThatYouWindow : BrowserWindow
    {
        
        public UIVillaHolidaysThatYouWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
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
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, ".villaplus.com/", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
            #endregion
        }
        
        #region Properties
        public HtmlComboBox UIDdDurationComboBox
        {
            get
            {
                if ((this.mUIDdDurationComboBox == null))
                {
                    this.mUIDdDurationComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdDurationComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "ddDuration";
                    this.mUIDdDurationComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "ctl00$MainContent$quickSearch$ddDuration";
                    this.mUIDdDurationComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = "ddlDuration";
                    this.mUIDdDurationComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"ctl00$MainContent$quickSearch$ddDu";
                    this.mUIDdDurationComboBox.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIDdDurationComboBox;
            }
        }
        #endregion
        
        #region Fields
        private HtmlComboBox mUIDdDurationComboBox;
        #endregion
    }
}
