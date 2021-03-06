﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchTile.verifyAirportListBox_MapClasses
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
    public partial class verifyAirportListBox_Map:logWriter
    {
        
        /// <summary>
        /// verifyAirportListBox_Method - Use 'verifyAirportListBox_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyAirportListBox_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDdAirportsComboBox = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIDdAirportsComboBox;
            #endregion

            string ExpAirportList = @"All London London Gatwick London Heathrow London Luton London Southend London Stansted Villa only All Midlands Birmingham Intl East Midlands All North East Doncaster Durham Humberside Leeds Bradford Newcastle All North West Liverpool Manchester All Scottish Aberdeen Edinburgh  Glasgow All South West Bournemouth Bristol Cardiff Exeter Southampton  All Northern Ireland Belfast Intl East England Norwich ";
            ExpAirportList = ExpAirportList.Replace(" ", string.Empty);

            string actualAirportList = uIDdAirportsComboBox.InnerText;
            actualAirportList = actualAirportList.Replace(" ", string.Empty);

            try
            {
                // Verify that the 'InnerText' property of 'ddAirports' combo box equals 'All London All North West All Midlands All Scottish All South West All North East Villa only Aberdeen Belfast Intl Blackpool Birmingham Intl Bournemouth Bristol Cardiff Coventry Doncaster Durham East Midlands Edinburgh  Exeter Glasgow Humberside Leeds Bradford Liverpool London Gatwick London Heathrow London Luton London Southend London Stansted Manchester Newcastle Intl Norwich Southampton  '
                //Assert.AreEqual(ExpAirportList, actualAirportList);
                StringAssert.Equals(ExpAirportList.Trim(), actualAirportList.Trim());
                WriteLogs("PASS : \"Airport\" List From Search Tile is Populated properly.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyAirportListBox");
                WriteLogs("FAIL : \"Airport\" List is Not Populated.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
            
        }

        public string selectAirport_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDdAirportsComboBox = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIDdAirportsComboBox;
            #endregion

            string[] AirportList = uIDdAirportsComboBox.GetContent();
            int Numofitems = AirportList.Length;
            Random rnd = new Random();
            int randomAirport = rnd.Next(0, Numofitems);
            string AirportSelected = string.Empty;

            try
            {
                uIDdAirportsComboBox.SelectedIndex = randomAirport;
                AirportSelected = uIDdAirportsComboBox.SelectedItem;
                WriteLogs("PASS : \"" + AirportSelected + "\" Selected as an Airport.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("selectAirport");
                WriteLogs("FAIL : Could Not Select Airport.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

            return AirportSelected;

        }
        
        #region Properties
        public virtual verifyAirportListBox_MethodExpectedValues verifyAirportListBox_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyAirportListBox_MethodExpectedValues == null))
                {
                    this.mverifyAirportListBox_MethodExpectedValues = new verifyAirportListBox_MethodExpectedValues();
                }
                return this.mverifyAirportListBox_MethodExpectedValues;
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
        private verifyAirportListBox_MethodExpectedValues mverifyAirportListBox_MethodExpectedValues;
        
        private UIVillaHolidaysThatYouWindow mUIVillaHolidaysThatYouWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyAirportListBox_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyAirportListBox_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'ddAirports' combo box equals 'All London All North West All Midlands All Scottish All South West All North East Villa only Aberdeen Belfast Intl Blackpool Birmingham Intl Bournemouth Bristol Cardiff Coventry Doncaster Durham East Midlands Edinburgh  Exeter Glasgow Humberside Leeds Bradford Liverpool London Gatwick London Heathrow London Luton London Southend London Stansted Manchester Newcastle Intl Norwich Southampton  '
        /// </summary>
        public string UIDdAirportsComboBoxInnerText = @"All London All North West All Midlands All Scottish All South West All North East Villa only Aberdeen Belfast Intl Blackpool Birmingham Intl Bournemouth Bristol Cardiff Coventry Doncaster Durham East Midlands Edinburgh  Exeter Glasgow Humberside Leeds Bradford Liverpool London Gatwick London Heathrow London Luton London Southend London Stansted Manchester Newcastle Intl Norwich Southampton  ";
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
        public HtmlComboBox UIDdAirportsComboBox
        {
            get
            {
                if ((this.mUIDdAirportsComboBox == null))
                {
                    this.mUIDdAirportsComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdAirportsComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "ddAirports";
                    this.mUIDdAirportsComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "ctl00$MainContent$quickSearch$ddAirports";
                    this.mUIDdAirportsComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"ctl00$MainContent$quickSearch$ddAi";
                    this.mUIDdAirportsComboBox.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIDdAirportsComboBox;
            }
        }
        #endregion
        
        #region Fields
        private HtmlComboBox mUIDdAirportsComboBox;
        #endregion
    }
}
