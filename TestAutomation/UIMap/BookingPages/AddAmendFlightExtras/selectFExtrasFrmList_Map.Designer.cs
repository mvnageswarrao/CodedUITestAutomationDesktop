﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.BookingPages.AddAmendFlightExtras.selectFExtrasFrmList_MapClasses
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
    public partial class selectFExtrasFrmList_Map:logWriter
    {
        
        /// <summary>
        /// selectFExtrasFrmList_Method - Use 'selectFExtrasFrmList_MethodParams' to pass parameters into this method.
        /// </summary>
        public void selectFExtrasFrmList_Method()
        {
            #region Variable Declarations
            HtmlComboBox uITxtQtyComboBox = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAmendFlightExtraSeleFrame.UIUntitledPageDocument.UITxtQtyComboBox;
            #endregion

            Boolean IsListboxesthere = uITxtQtyComboBox.TryFind();

            if (IsListboxesthere == true)
            {
                try
                {
                    UITestControlCollection FExtrasListboxestoSelect = uITxtQtyComboBox.FindMatchingControls();
                    foreach (HtmlComboBox ListBox in FExtrasListboxestoSelect)
                    {
                        if (ListBox.Enabled == true)
                        {
                            string FExtraQTYstoSelect = ListBox.InnerText;
                            FExtraQTYstoSelect = FExtraQTYstoSelect.Trim();
                            string[] FExtraQTYstoSelectArr = FExtraQTYstoSelect.Split(' ');
                            int MaxCount = FExtraQTYstoSelectArr.Length;
                            ListBox.SelectedItem = FExtraQTYstoSelectArr[new Random().Next(1, MaxCount)];
                        }
                        else
                        {
                            WriteLogs("PASS : The List Box is Disabled and Could Not Select a Qty.");
                        }
                    }
                    WriteLogs("PASS : Quantity is Selected for all the listed Flight Extras.");
                }
                catch (AssertFailedException ex)
                {
                    takeImage("selectFExtrasFrmList");
                    WriteLogs("FAIL : Could Not Select Quantity for all/Few of the listed Flight Extras.");
                    WriteLogs("-----------------" + ex.Message.ToString());
                }
            }

            // Select '1' in 'txtQty' combo box
            //uITxtQtyComboBox.SelectedItem = this.selectFExtrasFrmList_MethodParams.UITxtQtyComboBoxSelectedItem;
        }

        public Boolean IsFExtrasLSTboxthere_Method()
        {
            #region Variable Declarations
            HtmlComboBox uITxtQtyComboBox = this.UIYourHolidaySummaryWiWindow.UIYourHolidaySummaryDocument.UIAmendFlightExtraSeleFrame.UIUntitledPageDocument.UITxtQtyComboBox;
            #endregion

            Boolean IsListBoxthere = false;
            IsListBoxthere = uITxtQtyComboBox.TryFind();

            if (IsListBoxthere == true)
            {
                IsListBoxthere = true;
            }
            else
            {
                IsListBoxthere = false;
            }
            return IsListBoxthere;
        }
        
        #region Properties
        public virtual selectFExtrasFrmList_MethodParams selectFExtrasFrmList_MethodParams
        {
            get
            {
                if ((this.mselectFExtrasFrmList_MethodParams == null))
                {
                    this.mselectFExtrasFrmList_MethodParams = new selectFExtrasFrmList_MethodParams();
                }
                return this.mselectFExtrasFrmList_MethodParams;
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
        private selectFExtrasFrmList_MethodParams mselectFExtrasFrmList_MethodParams;
        
        private UIYourHolidaySummaryWiWindow mUIYourHolidaySummaryWiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'selectFExtrasFrmList_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class selectFExtrasFrmList_MethodParams
    {
        
        #region Fields
        /// <summary>
        /// Select '1' in 'txtQty' combo box
        /// </summary>
        public string UITxtQtyComboBoxSelectedItem = "1";
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
        public UIAmendFlightExtraSeleFrame UIAmendFlightExtraSeleFrame
        {
            get
            {
                if ((this.mUIAmendFlightExtraSeleFrame == null))
                {
                    this.mUIAmendFlightExtraSeleFrame = new UIAmendFlightExtraSeleFrame(this);
                }
                return this.mUIAmendFlightExtraSeleFrame;
            }
        }
        #endregion
        
        #region Fields
        private UIAmendFlightExtraSeleFrame mUIAmendFlightExtraSeleFrame;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAmendFlightExtraSeleFrame : HtmlIFrame
    {
        
        public UIAmendFlightExtraSeleFrame(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlFrame.PropertyNames.Id] = "amendFlightExtraSelection";
            this.SearchProperties[HtmlFrame.PropertyNames.Name] = "amendFlightExtraSelection";
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.AbsolutePath, "amendFlightExtra.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlFrame.PropertyNames.PageUrl, "amendFlightExtra.aspx?refNo=", PropertyExpressionOperator.Contains));
            this.FilterProperties[HtmlFrame.PropertyNames.ControlDefinition] = "name=\"amendFlightExtraSelection\" id=\"ame";
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public UIUntitledPageDocument UIUntitledPageDocument
        {
            get
            {
                if ((this.mUIUntitledPageDocument == null))
                {
                    this.mUIUntitledPageDocument = new UIUntitledPageDocument(this);
                }
                return this.mUIUntitledPageDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIUntitledPageDocument mUIUntitledPageDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIUntitledPageDocument : HtmlDocument
    {
        
        public UIUntitledPageDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "True";
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.AbsolutePath, "/code_net/booking/amendFlightExtra.aspx", PropertyExpressionOperator.Contains));
            this.FilterProperties.Add(new PropertyExpression(HtmlDocument.PropertyNames.PageUrl, "/code_net/booking/amendFlightExtra.aspx?refNo=", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Your Holiday Summary");
            #endregion
        }
        
        #region Properties
        public HtmlComboBox UITxtQtyComboBox
        {
            get
            {
                if ((this.mUITxtQtyComboBox == null))
                {
                    this.mUITxtQtyComboBox = new HtmlComboBox(this);
                    #region Search Criteria
                    this.mUITxtQtyComboBox.SearchProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.Id, "ctl00_ContentPlaceHolder1_rptAmend_", PropertyExpressionOperator.Contains));
                    this.mUITxtQtyComboBox.SearchProperties.Add(new PropertyExpression(HtmlComboBox.PropertyNames.Name, "ctl00$ContentPlaceHolder1$rptAmend$", PropertyExpressionOperator.Contains));
                    this.mUITxtQtyComboBox.FilterProperties[HtmlComboBox.PropertyNames.ControlDefinition] = "name=\"ctl00$ContentPlaceHolder1$rptAmend";
                    this.mUITxtQtyComboBox.WindowTitles.Add("Your Holiday Summary");
                    #endregion
                }
                return this.mUITxtQtyComboBox;
            }
        }
        #endregion
        
        #region Fields
        private HtmlComboBox mUITxtQtyComboBox;
        #endregion
    }
}
