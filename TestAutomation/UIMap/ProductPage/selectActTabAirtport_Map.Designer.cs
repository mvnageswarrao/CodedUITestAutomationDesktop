﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.selectActTabAirtport_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class selectActTabAirtport_Map
    {
        
        /// <summary>
        /// selectActTabAirport_Method - Use 'selectActTabAirport_MethodParams' to pass parameters into this method.
        /// </summary>
        public void selectActTabAirport_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDdAirportsComboBox = this.UIVillaPoppyPolisCypruWindow.UIVillaPoppyPolisCypruDocument.UIDdAirportsComboBox;
            #endregion

            // Select 'Villa only' in 'ddAirports' combo box
            uIDdAirportsComboBox.SelectedItem = this.selectActTabAirport_MethodParams.UIDdAirportsComboBoxSelectedItem;
        }
        public HtmlComboBox getAirportCombo_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDdAirportsComboBox = this.UIVillaPoppyPolisCypruWindow.UIVillaPoppyPolisCypruDocument.UIDdAirportsComboBox;
            #endregion

            return uIDdAirportsComboBox;
        }
        #region Properties
        public virtual selectActTabAirport_MethodParams selectActTabAirport_MethodParams
        {
            get
            {
                if ((this.mselectActTabAirport_MethodParams == null))
                {
                    this.mselectActTabAirport_MethodParams = new selectActTabAirport_MethodParams();
                }
                return this.mselectActTabAirport_MethodParams;
            }
        }
        
        public UIVillaPoppyPolisCypruWindow UIVillaPoppyPolisCypruWindow
        {
            get
            {
                if ((this.mUIVillaPoppyPolisCypruWindow == null))
                {
                    this.mUIVillaPoppyPolisCypruWindow = new UIVillaPoppyPolisCypruWindow();
                }
                return this.mUIVillaPoppyPolisCypruWindow;
            }
        }
        #endregion
        
        #region Fields
        private selectActTabAirport_MethodParams mselectActTabAirport_MethodParams;
        
        private UIVillaPoppyPolisCypruWindow mUIVillaPoppyPolisCypruWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'selectActTabAirport_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class selectActTabAirport_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'Villa only' in 'ddAirports' combo box
        /// </summary>
        public string UIDdAirportsComboBoxSelectedItem = "Villa only";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIVillaPoppyPolisCypruWindow : BrowserWindow
    {
        
        public UIVillaPoppyPolisCypruWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Villa Plus", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIVillaPoppyPolisCypruDocument UIVillaPoppyPolisCypruDocument
        {
            get
            {
                if ((this.mUIVillaPoppyPolisCypruDocument == null))
                {
                    this.mUIVillaPoppyPolisCypruDocument = new UIVillaPoppyPolisCypruDocument(this);
                }
                return this.mUIVillaPoppyPolisCypruDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPoppyPolisCypruDocument mUIVillaPoppyPolisCypruDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIVillaPoppyPolisCypruDocument : HtmlDocument
    {
        
        public UIVillaPoppyPolisCypruDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/product.aspx";
            #endregion
        }
        
        #region Properties
        public UICtl01Custom UICtl01Custom
        {
            get
            {
                if ((this.mUICtl01Custom == null))
                {
                    this.mUICtl01Custom = new UICtl01Custom(this);
                }
                return this.mUICtl01Custom;
            }
        }
        
        public HtmlComboBox UIDdAirportsComboBox
        {
            get
            {
                if ((this.mUIDdAirportsComboBox == null))
                {
                    this.mUIDdAirportsComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdAirportsComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "MainContent_VillaAvailability_ddAirports";
                    this.mUIDdAirportsComboBox.SearchProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.Name, "$VillaAvailability$ddAirports", PropertyExpressionOperator.Contains));
                    this.mUIDdAirportsComboBox.FilterProperties[HtmlComboBox.PropertyNames.Size] = "0";
                    this.mUIDdAirportsComboBox.FilterProperties[HtmlComboBox.PropertyNames.LabeledBy] = "";
                    this.mUIDdAirportsComboBox.FilterProperties[HtmlComboBox.PropertyNames.Title] = "";
                    this.mUIDdAirportsComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = "";
                    this.mUIDdAirportsComboBox.FilterProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.ControlDefinition, "id=MainContent_VillaAvailability_ddAirpo", PropertyExpressionOperator.Contains));
                    #endregion
                }
                return this.mUIDdAirportsComboBox;
            }
        }
        #endregion
        
        #region Fields
        private UICtl01Custom mUICtl01Custom;
        
        private HtmlComboBox mUIDdAirportsComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UICtl01Custom : HtmlCustom
    {
        
        public UICtl01Custom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["Id"] = "ctl01";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.SearchProperties["TagName"] = "FORM";
            this.FilterProperties["Class"] = "";
            this.FilterProperties.Add(new PropertyExpression("ControlDefinition", "method=post action=product.aspx", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public HtmlTable UIItemTable
        {
            get
            {
                if ((this.mUIItemTable == null))
                {
                    this.mUIItemTable = new HtmlTable(this);
                    #region Search Criteria
                    this.mUIItemTable.SearchProperties[HtmlTable.PropertyNames.Id] = null;
                    this.mUIItemTable.SearchProperties[HtmlTable.PropertyNames.Name] = null;
                    this.mUIItemTable.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.InnerText, "About Villa Plus", PropertyExpressionOperator.Contains));
                    this.mUIItemTable.FilterProperties.Add(new PropertyExpression(HtmlTable.PropertyNames.ControlDefinition, "style=\"PADDING-LEFT", PropertyExpressionOperator.Contains));
                    this.mUIItemTable.FilterProperties[HtmlTable.PropertyNames.RowCount] = "9";
                    this.mUIItemTable.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "1";
                    this.mUIItemTable.FilterProperties[HtmlTable.PropertyNames.Class] = "";
                    #endregion
                }
                return this.mUIItemTable;
            }
        }
        #endregion
        
        #region Fields
        private HtmlTable mUIItemTable;
        #endregion
    }
}
