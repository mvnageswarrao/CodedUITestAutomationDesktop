﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestAutomation.UIMap.DestinationsPage.verifyNoOfVillasPerCentre_MapClasses
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class verifyNoOfVillasPerCentre_Map:logWriter
    {
        
        /// <summary>
        /// verifyNoOfVillasPerCentre_Method - Use 'verifyNoOfVillasPerCentre_MethodExpectedValues' to pass parameters into this method.
        /// </summary>
        public void verifyNoOfVillasPerCentre_Method(string villaCount, string villaCentrerName)
        {
            #region Variable Declarations
            HtmlDiv uIAlgarve170VillasTheAPane = this.UIHttpnimbusdestinatioWindow.UIHttpnimbusdestinatioDocument.UIListViewTabPane.UIAlgarve170VillasTheAPane;
            #endregion

            // Verify that the 'InnerText' property of 'Algarve - 170 Villas The Algarve's cont' pane contains '
            //Algarve - 170 Villas
            //The Algarve's continued popularity for holidaymakers derives predominantly from its coastal location and enviable climat
            //
            //
            //    
            //
            //
            //Costa Blanca - 56 Villas
            //The Costa Blanca is one of Europe's most popular holiday destinations offering fantastic white sandy beaches lapped by sparkl
            //
            //
            //    
            //
            //
            //Corfu - 78 Villas
            //Corfu is one of the most popular and beautiful islands in Greece. With a wealth of natural beauty, a rich culture that sp
            //
            //
            //    
            //
            //
            //Crete - 8 Villas
            //Crete is the largest, and most famous Greek island. The island has stunning mountainous landscapes, a coast lined with bea
            //
            //
            //    
            //
            //
            //Cyprus - 79 Villas
            //Cyprus truly has something for everyone. It is full of contrast from ancient and traditional to modern and innovative. A 
            //
            //
            //   
            //
            //
            //Fuerteventura - 23 Villas
            //Fuerteventura lies in the Atlantic Ocean, 60 miles from the coast of Africa. The second largest of the Canary Island
            //
            //
            //    
            //
            //
            //Kefalonia - 25 Villas
            //Kefalonia is the largest of the Ionian Islands in western Greece and perhaps the most varied. It is one of the least inhab
            //
            //
            //    
            //
            //
            //Lanzarote - 88 Villas
            //Located only 90 miles off the Africa coast and enjoying 40 years of tourism, Lanzarote has developed into one of the most 
            //
            //
            //   
            //
            //
            //Mallorca - 144 Villas
            //Mallorca has always been one of the most popular holiday destinations in the Mediterranean. In over 50 years of modern tou
            //
            //
            //    
            //
            //
            //Menorca - 127 Villas
            //"The quiet one", Menorca is the 2nd largest of the Balearic Islands - just 33 miles from West to East and 14.5 miles from 
            //
            //
            //   
            //
            //
            //Rhodes - 9 Villas
            //Rhodes has spectacular ancient towns, stretches of beautiful coastline and is very popular with writers, artists and film
            //
            //
            //    
            //
            //
            //Costa del Sol - 84 Villas
            //Andalucia has so much to seduce its visitors - especially its 100 miles of coastline, stretching from Cadiz in the west to
            //
            //
            //    
            //
            //
            //Tenerife - 15 Villas
            //It's no surprise that Tenerife, the largest and most popular of the volcanic Canary Islands, has been attracting visi
            //
            //
            //    '
            //StringAssert.Contains(uIAlgarve170VillasTheAPane.InnerText, this.verifyNoOfVillasPerCentre_MethodExpectedValues.UIAlgarve170VillasTheAPaneInnerText);
            string ToCompare = villaCentrerName + " - " + villaCount + " Villas";
            try
            {
                StringAssert.Contains(uIAlgarve170VillasTheAPane.InnerText, ToCompare);
                WriteLogs("PASS: "+ToCompare);
            }
            catch (AssertFailedException ex)
            {
                takeImage("verifyNoOfVillasPerCentre");
                WriteLogs("FAIL: " + ToCompare);
                WriteLogs("-----------------" + ex.Message.ToString());
            }
        }
        
        #region Properties
        public virtual verifyNoOfVillasPerCentre_MethodExpectedValues verifyNoOfVillasPerCentre_MethodExpectedValues
        {
            get
            {
                if ((this.mverifyNoOfVillasPerCentre_MethodExpectedValues == null))
                {
                    this.mverifyNoOfVillasPerCentre_MethodExpectedValues = new verifyNoOfVillasPerCentre_MethodExpectedValues();
                }
                return this.mverifyNoOfVillasPerCentre_MethodExpectedValues;
            }
        }
        
        public UIHttpnimbusdestinatioWindow UIHttpnimbusdestinatioWindow
        {
            get
            {
                if ((this.mUIHttpnimbusdestinatioWindow == null))
                {
                    this.mUIHttpnimbusdestinatioWindow = new UIHttpnimbusdestinatioWindow();
                }
                return this.mUIHttpnimbusdestinatioWindow;
            }
        }
        #endregion
        
        #region Fields
        private verifyNoOfVillasPerCentre_MethodExpectedValues mverifyNoOfVillasPerCentre_MethodExpectedValues;
        
        private UIHttpnimbusdestinatioWindow mUIHttpnimbusdestinatioWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'verifyNoOfVillasPerCentre_Method'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class verifyNoOfVillasPerCentre_MethodExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'Algarve - 170 Villas The Algarve's cont' pane contains '
        ///Algarve - 170 Villas
        ///The Algarve's continued popularity for holidaymakers derives predominantly from its coastal location and enviable climat
        ///
        ///
        ///    
        ///
        ///
        ///Costa Blanca - 56 Villas
        ///The Costa Blanca is one of Europe's most popular holiday destinations offering fantastic white sandy beaches lapped by sparkl
        ///
        ///
        ///    
        ///
        ///
        ///Corfu - 78 Villas
        ///Corfu is one of the most popular and beautiful islands in Greece. With a wealth of natural beauty, a rich culture that sp
        ///
        ///
        ///    
        ///
        ///
        ///Crete - 8 Villas
        ///Crete is the largest, and most famous Greek island. The island has stunning mountainous landscapes, a coast lined with bea
        ///
        ///
        ///    
        ///
        ///
        ///Cyprus - 79 Villas
        ///Cyprus truly has something for everyone. It is full of contrast from ancient and traditional to modern and innovative. A 
        ///
        ///
        ///   
        ///
        ///
        ///Fuerteventura - 23 Villas
        ///Fuerteventura lies in the Atlantic Ocean, 60 miles from the coast of Africa. The second largest of the Canary Island
        ///
        ///
        ///    
        ///
        ///
        ///Kefalonia - 25 Villas
        ///Kefalonia is the largest of the Ionian Islands in western Greece and perhaps the most varied. It is one of the least inhab
        ///
        ///
        ///    
        ///
        ///
        ///Lanzarote - 88 Villas
        ///Located only 90 miles off the Africa coast and enjoying 40 years of tourism, Lanzarote has developed into one of the most 
        ///
        ///
        ///   
        ///
        ///
        ///Mallorca - 144 Villas
        ///Mallorca has always been one of the most popular holiday destinations in the Mediterranean. In over 50 years of modern tou
        ///
        ///
        ///    
        ///
        ///
        ///Menorca - 127 Villas
        ///"The quiet one", Menorca is the 2nd largest of the Balearic Islands - just 33 miles from West to East and 14.5 miles from 
        ///
        ///
        ///   
        ///
        ///
        ///Rhodes - 9 Villas
        ///Rhodes has spectacular ancient towns, stretches of beautiful coastline and is very popular with writers, artists and film
        ///
        ///
        ///    
        ///
        ///
        ///Costa del Sol - 84 Villas
        ///Andalucia has so much to seduce its visitors - especially its 100 miles of coastline, stretching from Cadiz in the west to
        ///
        ///
        ///    
        ///
        ///
        ///Tenerife - 15 Villas
        ///It's no surprise that Tenerife, the largest and most popular of the volcanic Canary Islands, has been attracting visi
        ///
        ///
        ///    '
        /// </summary>
        public string UIAlgarve170VillasTheAPaneInnerText = "\r\nAlgarve - 170 Villas\r\nThe Algarve\'s continued popularity for holidaymakers deri" +
            "ves predominantly from its coastal location and enviable climat\r\n\r\n\r\n    \r\n\r\n\r\nC" +
            "osta Blanca - 56 Villas\r\nThe Costa Blanca is one of Europe\'s most popular holida" +
            "y destinations offering fantastic white sandy beaches lapped by sparkl\r\n\r\n\r\n    " +
            "\r\n\r\n\r\nCorfu - 78 Villas\r\nCorfu is one of the most popular and beautiful islands " +
            "in Greece. With a wealth of natural beauty, a rich culture that sp\r\n\r\n\r\n    \r\n\r\n" +
            "\r\nCrete - 8 Villas\r\nCrete is the largest, and most famous Greek island. The isla" +
            "nd has stunning mountainous landscapes, a coast lined with bea\r\n\r\n\r\n    \r\n\r\n\r\nCy" +
            "prus - 79 Villas\r\nCyprus truly has something for everyone. It is full of contras" +
            "t from ancient and traditional to modern and innovative. A \r\n\r\n\r\n   \r\n\r\n\r\nFuerte" +
            "ventura - 23 Villas\r\nFuerteventura lies in the Atlantic Ocean, 60 miles from the" +
            " coast of Africa. The second largest of the Canary Island\r\n\r\n\r\n    \r\n\r\n\r\nKefalon" +
            "ia - 25 Villas\r\nKefalonia is the largest of the Ionian Islands in western Greece" +
            " and perhaps the most varied. It is one of the least inhab\r\n\r\n\r\n    \r\n\r\n\r\nLanzar" +
            "ote - 88 Villas\r\nLocated only 90 miles off the Africa coast and enjoying 40 year" +
            "s of tourism, Lanzarote has developed into one of the most \r\n\r\n\r\n   \r\n\r\n\r\nMallor" +
            "ca - 144 Villas\r\nMallorca has always been one of the most popular holiday destin" +
            "ations in the Mediterranean. In over 50 years of modern tou\r\n\r\n\r\n    \r\n\r\n\r\nMenor" +
            "ca - 127 Villas\r\n\"The quiet one\", Menorca is the 2nd largest of the Balearic Isl" +
            "ands - just 33 miles from West to East and 14.5 miles from \r\n\r\n\r\n   \r\n\r\n\r\nRhodes" +
            " - 9 Villas\r\nRhodes has spectacular ancient towns, stretches of beautiful coastl" +
            "ine and is very popular with writers, artists and film\r\n\r\n\r\n    \r\n\r\n\r\nCosta del " +
            "Sol - 84 Villas\r\nAndalucia has so much to seduce its visitors - especially its 1" +
            "00 miles of coastline, stretching from Cadiz in the west to\r\n\r\n\r\n    \r\n\r\n\r\nTener" +
            "ife - 15 Villas\r\nIt\'s no surprise that Tenerife, the largest and most popular of" +
            " the volcanic Canary Islands, has been attracting visi\r\n\r\n\r\n    ";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHttpnimbusdestinatioWindow : BrowserWindow
    {
        
        public UIHttpnimbusdestinatioWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "destinations.aspx", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("http://nimbus/destinations.aspx");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHttpnimbusdestinatioDocument UIHttpnimbusdestinatioDocument
        {
            get
            {
                if ((this.mUIHttpnimbusdestinatioDocument == null))
                {
                    this.mUIHttpnimbusdestinatioDocument = new UIHttpnimbusdestinatioDocument(this);
                }
                return this.mUIHttpnimbusdestinatioDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpnimbusdestinatioDocument mUIHttpnimbusdestinatioDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIHttpnimbusdestinatioDocument : HtmlDocument
    {
        
        public UIHttpnimbusdestinatioDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/destinations.aspx";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://nimbus/destinations.aspx";
            this.WindowTitles.Add("http://nimbus/destinations.aspx");
            #endregion
        }
        
        #region Properties
        public UIListViewTabPane UIListViewTabPane
        {
            get
            {
                if ((this.mUIListViewTabPane == null))
                {
                    this.mUIListViewTabPane = new UIListViewTabPane(this);
                }
                return this.mUIListViewTabPane;
            }
        }
        #endregion
        
        #region Fields
        private UIListViewTabPane mUIListViewTabPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIListViewTabPane : HtmlDiv
    {
        
        public UIListViewTabPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "ListViewTab";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "\r\n\r\nAlgarve - 170 Villas\r\nThe Algarve\'s ";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "font11 overflow-hidden padding0 bglightblue ui-tabs-panel ui-widget-content ui-co" +
                "rner-bottom";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"ListViewTab\" class=\"font11 overflow-";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "21";
            this.WindowTitles.Add("http://nimbus/destinations.aspx");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIAlgarve170VillasTheAPane
        {
            get
            {
                if ((this.mUIAlgarve170VillasTheAPane == null))
                {
                    this.mUIAlgarve170VillasTheAPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIAlgarve170VillasTheAPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIAlgarve170VillasTheAPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIAlgarve170VillasTheAPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "\r\nAlgarve - 170 Villas\r\nThe Algarve\'s co";
                    this.mUIAlgarve170VillasTheAPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIAlgarve170VillasTheAPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "dest-item-container";
                    this.mUIAlgarve170VillasTheAPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"dest-item-container\"";
                    this.mUIAlgarve170VillasTheAPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "1";
                    this.mUIAlgarve170VillasTheAPane.WindowTitles.Add("http://nimbus/destinations.aspx");
                    #endregion
                }
                return this.mUIAlgarve170VillasTheAPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIAlgarve170VillasTheAPane;
        #endregion
    }
}
