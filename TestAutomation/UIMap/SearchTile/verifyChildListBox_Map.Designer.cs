﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.SearchTile.verifyChildListBox_MapClasses
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
    public partial class verifyChildListBox_Map:logWriter
    {
        
        /// <summary>
        /// verifyChildListBox_Method - Use 'verifyChildListBox_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyChildListBox_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDdChildrenComboBox = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIDdChildrenComboBox;
            #endregion

            try
            {
                // Verify that the 'InnerText' property of 'ddChildren' combo box equals '0123456789101112131415161718'
                StringAssert.Contains(this.verifyChildListBox_MethodExpectedValues.UIDdChildrenComboBoxInnerText, uIDdChildrenComboBox.InnerText);
                WriteLogs("PASS : \"Child\" List From Search Tile is Populated properly.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyChildListBox");
                WriteLogs("FAIL : \"Child\" List is Not Populated.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }
            
        }

        public int selectChild_Method(int MaxOCCUPANCY)
        {
            #region Variable Declarations
            HtmlComboBox uIDdChildrenComboBox = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIDdChildrenComboBox;
            #endregion

            string[] ChildList = uIDdChildrenComboBox.GetContent();
            int NumofChildSelected = 0;
            int randomChildNum = 0;
            int Numofitems = MaxOCCUPANCY / 4;
            if (Numofitems > 2)
            {
                Random rnd = new Random();
                randomChildNum = rnd.Next(1, Numofitems);
            }
            else
            {
                randomChildNum = 2;
            }
   
            try
            {
                uIDdChildrenComboBox.SelectedIndex = randomChildNum;
                NumofChildSelected =Convert.ToInt32(uIDdChildrenComboBox.SelectedItem);
                WriteLogs("PASS : \"" + NumofChildSelected + "\" Child Selected.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("selectChild");
                WriteLogs("FAIL : Could Not Select Num of Children.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

            return NumofChildSelected;

        }

        public int ModifyChildNum_Method(int valuetoSELECT)
        {
            #region Variable Declarations
            HtmlComboBox uIDdChildrenComboBox = this.UIVillaHolidaysThatYouWindow.UIVillaHolidaysThatYouDocument.UIDdChildrenComboBox;
            #endregion

            string[] ChildList = uIDdChildrenComboBox.GetContent();
            int NumofChildSelected = 0;

            try
            {
                uIDdChildrenComboBox.SelectedIndex = (valuetoSELECT-1);
                NumofChildSelected = Convert.ToInt32(uIDdChildrenComboBox.SelectedItem);
                WriteLogs("PASS : Modified Num of Child to \"" + NumofChildSelected + "\".");
            }
            catch (AssertFailedException ex)
            {
                takeImage("ModifyChildNum");
                WriteLogs("FAIL : Could Not Modify Num of Child.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

            return NumofChildSelected;

        }

        #region Properties
        public virtual verifyChildListBox_MethodExpectedValues verifyChildListBox_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyChildListBox_MethodExpectedValues == null))
                {
                    this.mverifyChildListBox_MethodExpectedValues = new verifyChildListBox_MethodExpectedValues();
                }
                return this.mverifyChildListBox_MethodExpectedValues;
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
        private verifyChildListBox_MethodExpectedValues mverifyChildListBox_MethodExpectedValues;
        
        private UIVillaHolidaysThatYouWindow mUIVillaHolidaysThatYouWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyChildListBox_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class verifyChildListBox_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'ddChildren' combo box equals '0123456789101112131415161718'
        /// </summary>
        public string UIDdChildrenComboBoxInnerText = "0123456789101112131415161718";
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
        public HtmlComboBox UIDdChildrenComboBox
        {
            get
            {
                if ((this.mUIDdChildrenComboBox == null))
                {
                    this.mUIDdChildrenComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdChildrenComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "ddChildren";
                    this.mUIDdChildrenComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "ctl00$MainContent$quickSearch$ddChildren";
                    this.mUIDdChildrenComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"ctl00$MainContent$quickSearch$ddCh";
                    this.mUIDdChildrenComboBox.WindowTitles.Add("Villa Holidays That You’ll Love More | Villa Plus");
                    #endregion
                }
                return this.mUIDdChildrenComboBox;
            }
        }
        #endregion
        
        #region Fields
        private HtmlComboBox mUIDdChildrenComboBox;
        #endregion
    }
}
