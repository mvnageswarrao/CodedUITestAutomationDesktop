﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.OtherPaxPage.enteringTestDataInOtherPaxPage_MapClasses
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
    public partial class enteringTestDataInOtherPaxPage_Map : logWriter
    {

        /// <summary>
        /// enteringTestDataInOtherPaxPage_Method - Use 'enteringTestDataInOtherPaxPage_MethodParams' to pass parameters into this method.
        /// </summary>
        public void enteringTestDataInOtherPaxPage_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDdlAdultMrComboBox = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UIDdlAdultMrComboBox;
            HtmlEdit uITxtAdultFNameEdit = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UITxtAdultFNameEdit;
            HtmlEdit uITxtAdultLNameEdit = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UITxtAdultLNameEdit;
            HtmlComboBox uIDdlAdultAgeComboBox = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UIDdlAdultAgeComboBox;
            HtmlComboBox uIDdlAdultNationalityComboBox = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UIDdlAdultNationalityComboBox;
            HtmlEdit uITxtAdultFNameEdit1 = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UITxtAdultFNameEdit1;
            HtmlEdit uITxtAdultLNameEdit1 = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UITxtAdultLNameEdit1;
            HtmlComboBox uIDdlAdultAgeComboBox1 = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UIDdlAdultAgeComboBox1;
            HtmlComboBox uIDdlAdultNationalityComboBox1 = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UIDdlAdultNationalityComboBox1;
            HtmlEdit uITxtAdultFNameEdit2 = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UITxtAdultFNameEdit2;
            HtmlEdit uITxtAdultLNameEdit2 = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UITxtAdultLNameEdit2;
            HtmlComboBox uIDdlAdultAgeComboBox2 = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UIDdlAdultAgeComboBox2;
            HtmlComboBox uIDdlAdultNationalityComboBox2 = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UIDdlAdultNationalityComboBox2;
            HtmlComboBox uIDdlChildMrComboBox = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UIDdlChildMrComboBox;
            HtmlEdit uITxtChildFNameEdit = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UITxtChildFNameEdit;
            HtmlEdit uITxtChildLNameEdit = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UITxtChildLNameEdit;
            HtmlComboBox uIDdlChildAgeComboBox = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UIDdlChildAgeComboBox;
            HtmlComboBox uIDdlChildNationalityComboBox = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UIDdlChildNationalityComboBox;
            #endregion
           
            try
            {
                // Select 'Mrs' in 'ddlAdultMr' combo box
                uIDdlAdultMrComboBox.SelectedItem = this.enteringTestDataInOtherPaxPage_MethodParams.UIDdlAdultMrComboBoxSelectedItem;

                // Type 'Test One' in 'txtAdultFName' text box
                uITxtAdultFNameEdit.Text = this.enteringTestDataInOtherPaxPage_MethodParams.UITxtAdultFNameEditText;

                // Type 'Test Last' in 'txtAdultLName' text box
                uITxtAdultLNameEdit.Text = this.enteringTestDataInOtherPaxPage_MethodParams.UITxtAdultLNameEditText;

                // Select '18-25' in 'ddlAdultAge' combo box
                uIDdlAdultAgeComboBox.SelectedItem = this.enteringTestDataInOtherPaxPage_MethodParams.UIDdlAdultAgeComboBoxSelectedItem;

                // Select 'United Kingdom' in 'ddlAdultNationality' combo box
                uIDdlAdultNationalityComboBox.SelectedItem = this.enteringTestDataInOtherPaxPage_MethodParams.UIDdlAdultNationalityComboBoxSelectedItem;

                // Click 'txtAdultFName' text box
                Mouse.Click(uITxtAdultFNameEdit1, new Point(55, 10));

                // Type 'Test Two' in 'txtAdultFName' text box
                uITxtAdultFNameEdit1.Text = this.enteringTestDataInOtherPaxPage_MethodParams.UITxtAdultFNameEdit1Text;

                // Type 'Test Last' in 'txtAdultLName' text box
                uITxtAdultLNameEdit1.Text = this.enteringTestDataInOtherPaxPage_MethodParams.UITxtAdultLNameEdit1Text;

                // Select '18-25' in 'ddlAdultAge' combo box
                uIDdlAdultAgeComboBox1.SelectedItem = this.enteringTestDataInOtherPaxPage_MethodParams.UIDdlAdultAgeComboBox1SelectedItem;

                // Select 'United Kingdom' in 'ddlAdultNationality' combo box
                uIDdlAdultNationalityComboBox1.SelectedItem = this.enteringTestDataInOtherPaxPage_MethodParams.UIDdlAdultNationalityComboBox1SelectedItem;

                // Type 'Test Three' in 'txtAdultFName' text box
                uITxtAdultFNameEdit2.Text = this.enteringTestDataInOtherPaxPage_MethodParams.UITxtAdultFNameEdit2Text;

                // Type 'Test Last' in 'txtAdultLName' text box
                uITxtAdultLNameEdit2.Text = this.enteringTestDataInOtherPaxPage_MethodParams.UITxtAdultLNameEdit2Text;

                // Select '18-25' in 'ddlAdultAge' combo box
                uIDdlAdultAgeComboBox2.SelectedItem = this.enteringTestDataInOtherPaxPage_MethodParams.UIDdlAdultAgeComboBox2SelectedItem;

                // Select 'United Kingdom' in 'ddlAdultNationality' combo box
                uIDdlAdultNationalityComboBox2.SelectedItem = this.enteringTestDataInOtherPaxPage_MethodParams.UIDdlAdultNationalityComboBox2SelectedItem;

                // Select 'Master' in 'ddlChildMr' combo box
                uIDdlChildMrComboBox.SelectedItem = this.enteringTestDataInOtherPaxPage_MethodParams.UIDdlChildMrComboBoxSelectedItem;

                // Type 'Child One' in 'txtChildFName' text box
                uITxtChildFNameEdit.Text = this.enteringTestDataInOtherPaxPage_MethodParams.UITxtChildFNameEditText;

                // Type 'Child Last' in 'txtChildLName' text box
                uITxtChildLNameEdit.Text = this.enteringTestDataInOtherPaxPage_MethodParams.UITxtChildLNameEditText;

                // Select '3-11' in 'ddlChildAge' combo box
                uIDdlChildAgeComboBox.SelectedItem = this.enteringTestDataInOtherPaxPage_MethodParams.UIDdlChildAgeComboBoxSelectedItem;

                // Select 'United Kingdom' in 'ddlChildNationality' combo box
                uIDdlChildNationalityComboBox.SelectedItem = this.enteringTestDataInOtherPaxPage_MethodParams.UIDdlChildNationalityComboBoxSelectedItem;

                WriteLogs("PASS : Test Data is entered in Other Pax Page.");
            }
            catch (AssertFailedException ex)
            {
                takeImage("enteringTestDataInOtherPaxPage");
                WriteLogs("FAIL : Could not enter Test Data in Other Pax Page.");
                WriteLogs("-----------------" + ex.Message.ToString());
            }

        }

        public HtmlComboBox getAdultTitleCombo_Method()
        {
            HtmlComboBox uIDdlAdultMrComboBox = this.UIOtherPassengersDetaiWindow.UIOtherPassengersDetaiDocument.UIDdlAdultMrComboBox;
            return uIDdlAdultMrComboBox;
        }

        
        #region Properties
        public virtual enteringTestDataInOtherPaxPage_MethodParams enteringTestDataInOtherPaxPage_MethodParams
        {
            get
            {
                if ((this.menteringTestDataInOtherPaxPage_MethodParams == null))
                {
                    this.menteringTestDataInOtherPaxPage_MethodParams = new enteringTestDataInOtherPaxPage_MethodParams();
                }
                return this.menteringTestDataInOtherPaxPage_MethodParams;
            }
        }
        
        public UIOtherPassengersDetaiWindow UIOtherPassengersDetaiWindow
        {
            get
            {
                if ((this.mUIOtherPassengersDetaiWindow == null))
                {
                    this.mUIOtherPassengersDetaiWindow = new UIOtherPassengersDetaiWindow();
                }
                return this.mUIOtherPassengersDetaiWindow;
            }
        }
        #endregion
        
        #region Fields
        private enteringTestDataInOtherPaxPage_MethodParams menteringTestDataInOtherPaxPage_MethodParams;
        
        private UIOtherPassengersDetaiWindow mUIOtherPassengersDetaiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'enteringTestDataInOtherPaxPage_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class enteringTestDataInOtherPaxPage_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'Mrs' in 'ddlAdultMr' combo box
        /// </summary>
        public string UIDdlAdultMrComboBoxSelectedItem = "Mrs";
        
        /// <summary>
        /// Type 'Test One' in 'txtAdultFName' text box
        /// </summary>
        public string UITxtAdultFNameEditText = "Test One";
        
        /// <summary>
        /// Type 'Test Last' in 'txtAdultLName' text box
        /// </summary>
        public string UITxtAdultLNameEditText = "Test Last";
        
        /// <summary>
        /// Select '18-25' in 'ddlAdultAge' combo box
        /// </summary>
        public string UIDdlAdultAgeComboBoxSelectedItem = "18-25";
        
        /// <summary>
        /// Select 'United Kingdom' in 'ddlAdultNationality' combo box
        /// </summary>
        public string UIDdlAdultNationalityComboBoxSelectedItem = "United Kingdom";
        
        /// <summary>
        /// Type 'Test Two' in 'txtAdultFName' text box
        /// </summary>
        public string UITxtAdultFNameEdit1Text = "Test Two";
        
        /// <summary>
        /// Type 'Test Last' in 'txtAdultLName' text box
        /// </summary>
        public string UITxtAdultLNameEdit1Text = "Test Last";
        
        /// <summary>
        /// Select '18-25' in 'ddlAdultAge' combo box
        /// </summary>
        public string UIDdlAdultAgeComboBox1SelectedItem = "18-25";
        
        /// <summary>
        /// Select 'United Kingdom' in 'ddlAdultNationality' combo box
        /// </summary>
        public string UIDdlAdultNationalityComboBox1SelectedItem = "United Kingdom";
        
        /// <summary>
        /// Type 'Test Three' in 'txtAdultFName' text box
        /// </summary>
        public string UITxtAdultFNameEdit2Text = "Test Three";
        
        /// <summary>
        /// Type 'Test Last' in 'txtAdultLName' text box
        /// </summary>
        public string UITxtAdultLNameEdit2Text = "Test Last";
        
        /// <summary>
        /// Select '18-25' in 'ddlAdultAge' combo box
        /// </summary>
        public string UIDdlAdultAgeComboBox2SelectedItem = "18-25";
        
        /// <summary>
        /// Select 'United Kingdom' in 'ddlAdultNationality' combo box
        /// </summary>
        public string UIDdlAdultNationalityComboBox2SelectedItem = "United Kingdom";
        
        /// <summary>
        /// Select 'Master' in 'ddlChildMr' combo box
        /// </summary>
        public string UIDdlChildMrComboBoxSelectedItem = "Master";
        
        /// <summary>
        /// Type 'Child One' in 'txtChildFName' text box
        /// </summary>
        public string UITxtChildFNameEditText = "Child One";
        
        /// <summary>
        /// Type 'Child Last' in 'txtChildLName' text box
        /// </summary>
        public string UITxtChildLNameEditText = "Child Last";
        
        /// <summary>
        /// Select '3-11' in 'ddlChildAge' combo box
        /// </summary>
        public string UIDdlChildAgeComboBoxSelectedItem = "3-11";
        
        /// <summary>
        /// Select 'United Kingdom' in 'ddlChildNationality' combo box
        /// </summary>
        public string UIDdlChildNationalityComboBoxSelectedItem = "United Kingdom";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIOtherPassengersDetaiWindow : BrowserWindow
    {
        
        public UIOtherPassengersDetaiWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Other Passengers Details", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Other Passengers Details");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIOtherPassengersDetaiDocument UIOtherPassengersDetaiDocument
        {
            get
            {
                if ((this.mUIOtherPassengersDetaiDocument == null))
                {
                    this.mUIOtherPassengersDetaiDocument = new UIOtherPassengersDetaiDocument(this);
                }
                return this.mUIOtherPassengersDetaiDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIOtherPassengersDetaiDocument mUIOtherPassengersDetaiDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIOtherPassengersDetaiDocument : HtmlDocument
    {
        
        public UIOtherPassengersDetaiDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Other Passengers Details", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/allocatePax.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/allocatePax.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Other Passengers Details");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UITxtAdultFNameEdit
        {
            get
            {
                if ((this.mUITxtAdultFNameEdit == null))
                {
                    this.mUITxtAdultFNameEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUITxtAdultFNameEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "FlightRepeater_ctl01_reptAdult_ctl02_txtAdultFName";
                    this.mUITxtAdultFNameEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "FlightRepeater$ctl01$reptAdult$ctl02$txtAdultFName";
                    this.mUITxtAdultFNameEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtAdultFNameEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "greyText";
                    this.mUITxtAdultFNameEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptAdult$ctl";
                    this.mUITxtAdultFNameEdit.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUITxtAdultFNameEdit;
            }
        }
        
        public HtmlComboBox UIDdlAdultMrComboBox
        {
            get
            {
                if ((this.mUIDdlAdultMrComboBox == null))
                {
                    this.mUIDdlAdultMrComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdlAdultMrComboBox.SearchProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.Id, "ddlAdultMr", PropertyExpressionOperator.Contains));
                    this.mUIDdlAdultMrComboBox.SearchProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.Name, "$ddlAdultMr", PropertyExpressionOperator.Contains));
                    this.mUIDdlAdultMrComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = "greyText";
                    this.mUIDdlAdultMrComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptAdult$ctl";
                    this.mUIDdlAdultMrComboBox.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUIDdlAdultMrComboBox;
            }
        }
        
        public HtmlEdit UITxtAdultLNameEdit
        {
            get
            {
                if ((this.mUITxtAdultLNameEdit == null))
                {
                    this.mUITxtAdultLNameEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUITxtAdultLNameEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "FlightRepeater_ctl01_reptAdult_ctl02_txtAdultLName";
                    this.mUITxtAdultLNameEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "FlightRepeater$ctl01$reptAdult$ctl02$txtAdultLName";
                    this.mUITxtAdultLNameEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtAdultLNameEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "greyText";
                    this.mUITxtAdultLNameEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptAdult$ctl";
                    this.mUITxtAdultLNameEdit.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUITxtAdultLNameEdit;
            }
        }
        
        public HtmlComboBox UIDdlAdultAgeComboBox
        {
            get
            {
                if ((this.mUIDdlAdultAgeComboBox == null))
                {
                    this.mUIDdlAdultAgeComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdlAdultAgeComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "FlightRepeater_ctl01_reptAdult_ctl02_ddlAdultAge";
                    this.mUIDdlAdultAgeComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "FlightRepeater$ctl01$reptAdult$ctl02$ddlAdultAge";
                    this.mUIDdlAdultAgeComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = "greyText";
                    this.mUIDdlAdultAgeComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptAdult$ctl";
                    this.mUIDdlAdultAgeComboBox.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUIDdlAdultAgeComboBox;
            }
        }
        
        public HtmlComboBox UIDdlAdultNationalityComboBox
        {
            get
            {
                if ((this.mUIDdlAdultNationalityComboBox == null))
                {
                    this.mUIDdlAdultNationalityComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdlAdultNationalityComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "FlightRepeater_ctl01_reptAdult_ctl02_ddlAdultNationality";
                    this.mUIDdlAdultNationalityComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "FlightRepeater$ctl01$reptAdult$ctl02$ddlAdultNationality";
                    this.mUIDdlAdultNationalityComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = "greyText";
                    this.mUIDdlAdultNationalityComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptAdult$ctl";
                    this.mUIDdlAdultNationalityComboBox.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUIDdlAdultNationalityComboBox;
            }
        }
        
        public HtmlEdit UITxtAdultFNameEdit1
        {
            get
            {
                if ((this.mUITxtAdultFNameEdit1 == null))
                {
                    this.mUITxtAdultFNameEdit1 = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUITxtAdultFNameEdit1.SearchProperties[HtmlEdit.PropertyNames.Id] = "FlightRepeater_ctl01_reptAdult_ctl03_txtAdultFName";
                    this.mUITxtAdultFNameEdit1.SearchProperties[HtmlEdit.PropertyNames.Name] = "FlightRepeater$ctl01$reptAdult$ctl03$txtAdultFName";
                    this.mUITxtAdultFNameEdit1.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtAdultFNameEdit1.FilterProperties[HtmlEdit.PropertyNames.Class] = "greyText";
                    this.mUITxtAdultFNameEdit1.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptAdult$ctl";
                    this.mUITxtAdultFNameEdit1.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUITxtAdultFNameEdit1;
            }
        }
        
        public HtmlEdit UITxtAdultLNameEdit1
        {
            get
            {
                if ((this.mUITxtAdultLNameEdit1 == null))
                {
                    this.mUITxtAdultLNameEdit1 = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUITxtAdultLNameEdit1.SearchProperties[HtmlEdit.PropertyNames.Id] = "FlightRepeater_ctl01_reptAdult_ctl03_txtAdultLName";
                    this.mUITxtAdultLNameEdit1.SearchProperties[HtmlEdit.PropertyNames.Name] = "FlightRepeater$ctl01$reptAdult$ctl03$txtAdultLName";
                    this.mUITxtAdultLNameEdit1.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtAdultLNameEdit1.FilterProperties[HtmlEdit.PropertyNames.Class] = "greyText";
                    this.mUITxtAdultLNameEdit1.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptAdult$ctl";
                    this.mUITxtAdultLNameEdit1.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUITxtAdultLNameEdit1;
            }
        }
        
        public HtmlComboBox UIDdlAdultAgeComboBox1
        {
            get
            {
                if ((this.mUIDdlAdultAgeComboBox1 == null))
                {
                    this.mUIDdlAdultAgeComboBox1 = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdlAdultAgeComboBox1.SearchProperties[HtmlComboBox.PropertyNames.Id] = "FlightRepeater_ctl01_reptAdult_ctl03_ddlAdultAge";
                    this.mUIDdlAdultAgeComboBox1.SearchProperties[HtmlComboBox.PropertyNames.Name] = "FlightRepeater$ctl01$reptAdult$ctl03$ddlAdultAge";
                    this.mUIDdlAdultAgeComboBox1.FilterProperties[HtmlComboBox.PropertyNames.Class] = "greyText";
                    this.mUIDdlAdultAgeComboBox1.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptAdult$ctl";
                    this.mUIDdlAdultAgeComboBox1.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUIDdlAdultAgeComboBox1;
            }
        }
        
        public HtmlComboBox UIDdlAdultNationalityComboBox1
        {
            get
            {
                if ((this.mUIDdlAdultNationalityComboBox1 == null))
                {
                    this.mUIDdlAdultNationalityComboBox1 = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdlAdultNationalityComboBox1.SearchProperties[HtmlComboBox.PropertyNames.Id] = "FlightRepeater_ctl01_reptAdult_ctl03_ddlAdultNationality";
                    this.mUIDdlAdultNationalityComboBox1.SearchProperties[HtmlComboBox.PropertyNames.Name] = "FlightRepeater$ctl01$reptAdult$ctl03$ddlAdultNationality";
                    this.mUIDdlAdultNationalityComboBox1.FilterProperties[HtmlComboBox.PropertyNames.Class] = "greyText";
                    this.mUIDdlAdultNationalityComboBox1.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptAdult$ctl";
                    this.mUIDdlAdultNationalityComboBox1.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUIDdlAdultNationalityComboBox1;
            }
        }
        
        public HtmlEdit UITxtAdultFNameEdit2
        {
            get
            {
                if ((this.mUITxtAdultFNameEdit2 == null))
                {
                    this.mUITxtAdultFNameEdit2 = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUITxtAdultFNameEdit2.SearchProperties[HtmlEdit.PropertyNames.Id] = "FlightRepeater_ctl01_reptAdult_ctl04_txtAdultFName";
                    this.mUITxtAdultFNameEdit2.SearchProperties[HtmlEdit.PropertyNames.Name] = "FlightRepeater$ctl01$reptAdult$ctl04$txtAdultFName";
                    this.mUITxtAdultFNameEdit2.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtAdultFNameEdit2.FilterProperties[HtmlEdit.PropertyNames.Class] = "greyText";
                    this.mUITxtAdultFNameEdit2.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptAdult$ctl";
                    this.mUITxtAdultFNameEdit2.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUITxtAdultFNameEdit2;
            }
        }
        
        public HtmlEdit UITxtAdultLNameEdit2
        {
            get
            {
                if ((this.mUITxtAdultLNameEdit2 == null))
                {
                    this.mUITxtAdultLNameEdit2 = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUITxtAdultLNameEdit2.SearchProperties[HtmlEdit.PropertyNames.Id] = "FlightRepeater_ctl01_reptAdult_ctl04_txtAdultLName";
                    this.mUITxtAdultLNameEdit2.SearchProperties[HtmlEdit.PropertyNames.Name] = "FlightRepeater$ctl01$reptAdult$ctl04$txtAdultLName";
                    this.mUITxtAdultLNameEdit2.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtAdultLNameEdit2.FilterProperties[HtmlEdit.PropertyNames.Class] = "greyText";
                    this.mUITxtAdultLNameEdit2.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptAdult$ctl";
                    this.mUITxtAdultLNameEdit2.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUITxtAdultLNameEdit2;
            }
        }
        
        public HtmlComboBox UIDdlAdultAgeComboBox2
        {
            get
            {
                if ((this.mUIDdlAdultAgeComboBox2 == null))
                {
                    this.mUIDdlAdultAgeComboBox2 = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdlAdultAgeComboBox2.SearchProperties[HtmlComboBox.PropertyNames.Id] = "FlightRepeater_ctl01_reptAdult_ctl04_ddlAdultAge";
                    this.mUIDdlAdultAgeComboBox2.SearchProperties[HtmlComboBox.PropertyNames.Name] = "FlightRepeater$ctl01$reptAdult$ctl04$ddlAdultAge";
                    this.mUIDdlAdultAgeComboBox2.FilterProperties[HtmlComboBox.PropertyNames.Class] = "greyText";
                    this.mUIDdlAdultAgeComboBox2.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptAdult$ctl";
                    this.mUIDdlAdultAgeComboBox2.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUIDdlAdultAgeComboBox2;
            }
        }
        
        public HtmlComboBox UIDdlAdultNationalityComboBox2
        {
            get
            {
                if ((this.mUIDdlAdultNationalityComboBox2 == null))
                {
                    this.mUIDdlAdultNationalityComboBox2 = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdlAdultNationalityComboBox2.SearchProperties[HtmlComboBox.PropertyNames.Id] = "FlightRepeater_ctl01_reptAdult_ctl04_ddlAdultNationality";
                    this.mUIDdlAdultNationalityComboBox2.SearchProperties[HtmlComboBox.PropertyNames.Name] = "FlightRepeater$ctl01$reptAdult$ctl04$ddlAdultNationality";
                    this.mUIDdlAdultNationalityComboBox2.FilterProperties[HtmlComboBox.PropertyNames.Class] = "greyText";
                    this.mUIDdlAdultNationalityComboBox2.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptAdult$ctl";
                    this.mUIDdlAdultNationalityComboBox2.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUIDdlAdultNationalityComboBox2;
            }
        }
        
        public HtmlComboBox UIDdlChildMrComboBox
        {
            get
            {
                if ((this.mUIDdlChildMrComboBox == null))
                {
                    this.mUIDdlChildMrComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdlChildMrComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "FlightRepeater_ctl01_reptChild_ctl01_ddlChildMr";
                    this.mUIDdlChildMrComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "FlightRepeater$ctl01$reptChild$ctl01$ddlChildMr";
                    this.mUIDdlChildMrComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = "greyText";
                    this.mUIDdlChildMrComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptChild$ctl";
                    this.mUIDdlChildMrComboBox.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUIDdlChildMrComboBox;
            }
        }
        
        public HtmlEdit UITxtChildFNameEdit
        {
            get
            {
                if ((this.mUITxtChildFNameEdit == null))
                {
                    this.mUITxtChildFNameEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUITxtChildFNameEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "FlightRepeater_ctl01_reptChild_ctl01_txtChildFName";
                    this.mUITxtChildFNameEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "FlightRepeater$ctl01$reptChild$ctl01$txtChildFName";
                    this.mUITxtChildFNameEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtChildFNameEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "greyText";
                    this.mUITxtChildFNameEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptChild$ctl";
                    this.mUITxtChildFNameEdit.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUITxtChildFNameEdit;
            }
        }
        
        public HtmlEdit UITxtChildLNameEdit
        {
            get
            {
                if ((this.mUITxtChildLNameEdit == null))
                {
                    this.mUITxtChildLNameEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUITxtChildLNameEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "FlightRepeater_ctl01_reptChild_ctl01_txtChildLName";
                    this.mUITxtChildLNameEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "FlightRepeater$ctl01$reptChild$ctl01$txtChildLName";
                    this.mUITxtChildLNameEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtChildLNameEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "greyText";
                    this.mUITxtChildLNameEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptChild$ctl";
                    this.mUITxtChildLNameEdit.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUITxtChildLNameEdit;
            }
        }
        
        public HtmlComboBox UIDdlChildAgeComboBox
        {
            get
            {
                if ((this.mUIDdlChildAgeComboBox == null))
                {
                    this.mUIDdlChildAgeComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdlChildAgeComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "FlightRepeater_ctl01_reptChild_ctl01_ddlChildAge";
                    this.mUIDdlChildAgeComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "FlightRepeater$ctl01$reptChild$ctl01$ddlChildAge";
                    this.mUIDdlChildAgeComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = "greyText";
                    this.mUIDdlChildAgeComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptChild$ctl";
                    this.mUIDdlChildAgeComboBox.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUIDdlChildAgeComboBox;
            }
        }
        
        public HtmlComboBox UIDdlChildNationalityComboBox
        {
            get
            {
                if ((this.mUIDdlChildNationalityComboBox == null))
                {
                    this.mUIDdlChildNationalityComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdlChildNationalityComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "FlightRepeater_ctl01_reptChild_ctl01_ddlChildNationality";
                    this.mUIDdlChildNationalityComboBox.SearchProperties[HtmlComboBox.PropertyNames.Name] = "FlightRepeater$ctl01$reptChild$ctl01$ddlChildNationality";
                    this.mUIDdlChildNationalityComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = "greyText";
                    this.mUIDdlChildNationalityComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"FlightRepeater$ctl01$reptChild$ctl";
                    this.mUIDdlChildNationalityComboBox.WindowTitles.Add("Other Passengers Details");
                    #endregion
                }
                return this.mUIDdlChildNationalityComboBox;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUITxtAdultFNameEdit;
        
        private HtmlComboBox mUIDdlAdultMrComboBox;
        
        private HtmlEdit mUITxtAdultLNameEdit;
        
        private HtmlComboBox mUIDdlAdultAgeComboBox;
        
        private HtmlComboBox mUIDdlAdultNationalityComboBox;
        
        private HtmlEdit mUITxtAdultFNameEdit1;
        
        private HtmlEdit mUITxtAdultLNameEdit1;
        
        private HtmlComboBox mUIDdlAdultAgeComboBox1;
        
        private HtmlComboBox mUIDdlAdultNationalityComboBox1;
        
        private HtmlEdit mUITxtAdultFNameEdit2;
        
        private HtmlEdit mUITxtAdultLNameEdit2;
        
        private HtmlComboBox mUIDdlAdultAgeComboBox2;
        
        private HtmlComboBox mUIDdlAdultNationalityComboBox2;
        
        private HtmlComboBox mUIDdlChildMrComboBox;
        
        private HtmlEdit mUITxtChildFNameEdit;
        
        private HtmlEdit mUITxtChildLNameEdit;
        
        private HtmlComboBox mUIDdlChildAgeComboBox;
        
        private HtmlComboBox mUIDdlChildNationalityComboBox;
        #endregion
    }
}
