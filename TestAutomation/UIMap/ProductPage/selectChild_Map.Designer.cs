﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.ProductPage.selectChild_MapClasses
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
    using System.Configuration;
    using TestAutomation.Utility;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class selectChild_Map:logWriter
    {
        
        /// <summary>
        /// selectChild_Method - Use 'selectChild_MethodParams' to pass parameters into this method.
        /// </summary>
        public void selectChild_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDdChildrenComboBox = this.UIVillaPoppyPolisCypruWindow.UIVillaPoppyPolisCypruDocument.UIDdChildrenComboBox;
            #endregion

            // Select '1' in 'ddChildren' combo box
            uIDdChildrenComboBox.SelectedItem = this.selectChild_MethodParams.UIDdChildrenComboBoxSelectedItem;

        }

        public void selectChildForBookings_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDdChildrenComboBox = this.UIVillaPoppyPolisCypruWindow.UIVillaPoppyPolisCypruDocument.UIDdChildrenComboBox;
            #endregion

            // Select '1' in 'ddChildren' combo box
            uIDdChildrenComboBox.SelectedItem = ConfigurationManager.AppSettings["NoofChild"].ToString();

        }

        public void selectChildbyreducing_Method(int ChildSELECTION)
        {
            #region Variable Declarations
            HtmlComboBox uIDdChildrenComboBox = this.UIVillaPoppyPolisCypruWindow.UIVillaPoppyPolisCypruDocument.UIDdChildrenComboBox;
            #endregion

            // Select '1' in 'ddChildren' combo box
            //uIDdChildrenComboBox.SelectedItem = this.selectChild_MethodParams.UIDdChildrenComboBoxSelectedItem;
            uIDdChildrenComboBox.SelectedIndex = ChildSELECTION;
            WriteLogs("INFO : Num Of Child is Reduced to " + ChildSELECTION +" as Your Selection is Crossed Max Occupancy.");
        }

        public HtmlComboBox getselectChildDropDown_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDdChildrenComboBox = this.UIVillaPoppyPolisCypruWindow.UIVillaPoppyPolisCypruDocument.UIDdChildrenComboBox;
            #endregion

            return uIDdChildrenComboBox;
        }
        
        #region Properties
        public virtual selectChild_MethodParams selectChild_MethodParams
        {
            get
            {
                if ((this.mselectChild_MethodParams == null))
                {
                    this.mselectChild_MethodParams = new selectChild_MethodParams();
                }
                return this.mselectChild_MethodParams;
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
        private selectChild_MethodParams mselectChild_MethodParams;
        
        private UIVillaPoppyPolisCypruWindow mUIVillaPoppyPolisCypruWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'selectChild_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class selectChild_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Select '1' in 'ddChildren' combo box
        /// </summary>
        public string UIDdChildrenComboBoxSelectedItem = "1";
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
        public HtmlComboBox UIDdChildrenComboBox
        {
            get
            {
                if ((this.mUIDdChildrenComboBox == null))
                {
                    this.mUIDdChildrenComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdChildrenComboBox.SearchProperties[HtmlComboBox.PropertyNames.Id] = "MainContent_VillaAvailability_ddChildren";
                    this.mUIDdChildrenComboBox.SearchProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.Name, "$VillaAvailability$ddChildren", PropertyExpressionOperator.Contains));
                    this.mUIDdChildrenComboBox.FilterProperties[HtmlComboBox.PropertyNames.Size] = "0";
                    this.mUIDdChildrenComboBox.FilterProperties[HtmlComboBox.PropertyNames.LabeledBy] = "";
                    this.mUIDdChildrenComboBox.FilterProperties[HtmlComboBox.PropertyNames.Title] = "";
                    this.mUIDdChildrenComboBox.FilterProperties[HtmlComboBox.PropertyNames.Class] = "";
                    this.mUIDdChildrenComboBox.FilterProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.ControlDefinition, "id=MainContent_VillaAvailability_ddChild", PropertyExpressionOperator.Contains));
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
