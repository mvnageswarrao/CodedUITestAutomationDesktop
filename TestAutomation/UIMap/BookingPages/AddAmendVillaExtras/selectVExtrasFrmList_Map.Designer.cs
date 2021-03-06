﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.AddAmendVillaExtras.selectVExtrasFrmList_MapClasses
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
    public partial class selectVExtrasFrmList_Map:logWriter
    {
        
        /// <summary>
        /// selectVExtrasFrmList_Method - Use 'selectVExtrasFrmList_MethodParams' to pass parameters into this method.
        /// </summary>
        public void selectVExtrasFrmList_Method()
        {
            #region Variable Declarations
            HtmlComboBox uIDdlQtyComboBox1 = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAmendVillaExtrasSeleFrame.UIVillaPlusPackageHoliDocument.UIDdlQtyComboBox1;
            #endregion

            Boolean IsListboxesthere = uIDdlQtyComboBox1.TryFind();

            if (IsListboxesthere == true)
            {
                try
                {
                    UITestControlCollection VExtrasListboxestoSelect = uIDdlQtyComboBox1.FindMatchingControls();
                    foreach (HtmlComboBox ListBox in VExtrasListboxestoSelect)
                    {
                        if (ListBox.Enabled == true)
                        {
                            string VExtraQTYstoSelect = ListBox.InnerText;
                            VExtraQTYstoSelect = VExtraQTYstoSelect.Trim();
                            string[] VExtraQTYstoSelectArr = VExtraQTYstoSelect.Split(' ');
                            int MaxCount = VExtraQTYstoSelectArr.Length;
                            if (MaxCount > 1)
                            {
                                ListBox.SelectedItem = VExtraQTYstoSelectArr[new Random().Next(1, MaxCount)];
                            }
                            else
                            {
                                ListBox.SelectedItem = VExtraQTYstoSelectArr[0];
                            }
                        }
                        else
                        {
                            WriteLogs("PASS : The List Box is Disabled and Could Not Select a Qty.");
                        }
                    }
                    WriteLogs("PASS : Quantity is Selected for all the listed Villa Extras.");
                }
                catch (AssertFailedException ex)
                {
                    takeImage("selectVExtrasFrmList");
                    WriteLogs("FAIL : Could Not Select Quantity for all/Few of the listed Villa Extras.");
                    WriteLogs("-----------------" + ex.Message.ToString());
                }
            }

        

            // Select '1' in 'ddlQty' combo box
            //uIDdlQtyComboBox1.SelectedItem = this.selectVExtrasFrmList_MethodParams.UIDdlQtyComboBox1SelectedItem;
        }
        
        #region Properties
        public virtual selectVExtrasFrmList_MethodParams selectVExtrasFrmList_MethodParams
        {
            get
            {
                if ((this.mselectVExtrasFrmList_MethodParams == null))
                {
                    this.mselectVExtrasFrmList_MethodParams = new selectVExtrasFrmList_MethodParams();
                }
                return this.mselectVExtrasFrmList_MethodParams;
            }
        }
        
        public UIYourHolidaySummaryWiWindow UIYourHolidaySummaryWiWindow
        {
            get
            {
                if ((this.mUIYourHolidaySummaryWiWindow == null))
                {
                    this.mUIYourHolidaySummaryWiWindow = new UIYourHolidaySummaryWiWindow();
                }
                return this.mUIYourHolidaySummaryWiWindow;
            }
        }
        #endregion
        
        #region Fields
        private selectVExtrasFrmList_MethodParams mselectVExtrasFrmList_MethodParams;
        
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'selectVExtrasFrmList_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class selectVExtrasFrmList_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Select '1' in 'ddlQty' combo box
        /// </summary>
        public string UIDdlQtyComboBox1SelectedItem = "1";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIYourHolidaySummaryWiWindow : BrowserWindow
    {
        
        public UIYourHolidaySummaryWiWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Your Holiday Summary", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIYourHolidaySummaryDocument UIYourHolidaySummaryDocument
        {
            get
            {
                if ((this.mUIYourHolidaySummaryDocument == null))
                {
                    this.mUIYourHolidaySummaryDocument = new UIYourHolidaySummaryDocument(this);
                }
                return this.mUIYourHolidaySummaryDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIYourHolidaySummaryDocument mUIYourHolidaySummaryDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIYourHolidaySummaryDocument : HtmlDocument
    {
        
        public UIYourHolidaySummaryDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Your Holiday Summary", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/default.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/default.aspx", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIAmendVillaExtrasSeleFrame UIAmendVillaExtrasSeleFrame
        {
            get
            {
                if ((this.mUIAmendVillaExtrasSeleFrame == null))
                {
                    this.mUIAmendVillaExtrasSeleFrame = new UIAmendVillaExtrasSeleFrame(this);
                }
                return this.mUIAmendVillaExtrasSeleFrame;
            }
        }
        #endregion
        
        #region Fields
        private UIAmendVillaExtrasSeleFrame mUIAmendVillaExtrasSeleFrame;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAmendVillaExtrasSeleFrame : HtmlIFrame
    {
        
        public UIAmendVillaExtrasSeleFrame(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "amendVillaExtrasSelection";
            this.SearchProperties[HtmlFrame.PropertyNames.Name] = "amendVillaExtrasSelection";
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.AbsolutePath, "amendVillaExtra.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.PageUrl, "amendVillaExtra.aspx?", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlFrame.PropertyNames.ControlDefinition] = "name=\"amendVillaExtrasSelection\" id=\"ame";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIVillaPlusPackageHoliDocument UIVillaPlusPackageHoliDocument
        {
            get
            {
                if ((this.mUIVillaPlusPackageHoliDocument == null))
                {
                    this.mUIVillaPlusPackageHoliDocument = new UIVillaPlusPackageHoliDocument(this);
                }
                return this.mUIVillaPlusPackageHoliDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIVillaPlusPackageHoliDocument mUIVillaPlusPackageHoliDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVillaPlusPackageHoliDocument : HtmlDocument
    {
        
        public UIVillaPlusPackageHoliDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.Title, "Villa Plus", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/amendVillaExtra.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/amendVillaExtra.aspx?", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlCheckBox UICtl00ContentPlaceHolCheckBox
        {
            get
            {
                if ((this.mUICtl00ContentPlaceHolCheckBox == null))
                {
                    this.mUICtl00ContentPlaceHolCheckBox = new HtmlCheckBox(this);
                    #region Search Criteria
                    this.mUICtl00ContentPlaceHolCheckBox.SearchProperties[HtmlCheckBox.PropertyNames.Id] = "ctl00_ContentPlaceHolder1_rept1_";
                    this.mUICtl00ContentPlaceHolCheckBox.SearchProperties[HtmlCheckBox.PropertyNames.Name] = "ctl00$ContentPlaceHolder1$rept1$";
                    this.mUICtl00ContentPlaceHolCheckBox.FilterProperties[HtmlCheckBox.PropertyNames.Value] = "on";
                    this.mUICtl00ContentPlaceHolCheckBox.FilterProperties[HtmlCheckBox.PropertyNames.ControlDefinition] = "name=\"ctl00$ContentPlaceHolder1$rept1$ct";
                    this.mUICtl00ContentPlaceHolCheckBox.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUICtl00ContentPlaceHolCheckBox;
            }
        }
        
        public HtmlComboBox UIDdlQtyComboBox1
        {
            get
            {
                if ((this.mUIDdlQtyComboBox1 == null))
                {
                    this.mUIDdlQtyComboBox1 = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUIDdlQtyComboBox1.SearchProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.Id, "ctl00_ContentPlaceHolder1_rept1_", PropertyExpressionOperator.Contains));
                    this.mUIDdlQtyComboBox1.SearchProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.Name, "ctl00$ContentPlaceHolder1$rept1$", PropertyExpressionOperator.Contains));
                    this.mUIDdlQtyComboBox1.FilterProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.ControlDefinition, "name=\"ctl00$ContentPlaceHolder1$", PropertyExpressionOperator.Contains));
                    this.mUIDdlQtyComboBox1.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUIDdlQtyComboBox1;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCheckBox mUICtl00ContentPlaceHolCheckBox;
        
        private HtmlComboBox mUIDdlQtyComboBox1;
        #endregion
    }
}
