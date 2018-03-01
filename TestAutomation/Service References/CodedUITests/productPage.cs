using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using TestAutomation.Utility;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Net;
using HtmlAgilityPack;
using System.Data;
using System.Data.SqlClient;



namespace TestAutomation
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class productPage : logWriter
    {
        public productPage()
        {
        }

        [TestMethod]
        public void productPageVerf()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463

            string villaIDList = ConfigurationManager.AppSettings["villaID"].ToString();
            string noOfVillas = ConfigurationManager.AppSettings["noOfVillas"].ToString();
            string randomVillas = ConfigurationManager.AppSettings["randomVillas"].ToString();
            List<string> villaIDlst = new List<string>();
            string sqlQuery = "";
            getFromDB getData = new getFromDB();
            SqlDataReader dataReader = null;
            SqlDataReader dataReaderVillaID = null;
            string page = string.Empty;
            InitiateProductPage runScript = new InitiateProductPage();

            #region Get Villa IDs
            if (randomVillas == "1")
            {
                string sqlQuery1 = "EXEC QAsp_GetRandomVillaIDsforAllCentres";
                dataReader = getData.getData(sqlQuery1);
                while (dataReader.Read())
                {
                    villaIDlst.Add(dataReader[0].ToString());
                }
            }
            else
            {
                if (villaIDList != string.Empty)
                {
                    string[] villaidArr = villaIDList.Split(',');
                    for (int i = 0; i < villaidArr.GetLength(0); i++)
                    {
                        villaIDlst.Add(villaidArr[i].ToString());
                    }
                }
                else
                {
                    sqlQuery = "SELECT TOP " + noOfVillas + " VillaId FROM tblVIllaAvailability where available='A' ORDER BY NEWID()";
                    dataReaderVillaID = getData.getData(sqlQuery);
                    while (dataReaderVillaID.Read())
                    {
                        villaIDlst.Add(dataReaderVillaID[0].ToString());
                    }

                }
            }
            #endregion

            #region Open Villa page and verify all details

            runScript.OpenBrowser_Obj.openBrowser_Method();
            foreach (string villaID in villaIDlst)
            {
                try
                {
                    #region Variables Declaration

                    string villaSummary = "";
                    string villaOverviewText = "";
                    string villaLayoutText = "";
                    string villaLocTabLocText = "";
                    string villaLocTabLocFeaturestxt = "";
                    string villaLocTabGPSLat = "";
                    string villaLocTabGPSLang = "";
                    string villaResortID = "";
                    string villaFacilityText = "";
                    string villaFacilityTextFinal = "Villa facilities";
                    string villaLocTabInThisAreatxt = "";
                    string villaLocTabInThisAreatxtFinal = "";
                    string villaFullName = "";
                    string villaSubTitle = "";
                    string villaCenter = "";
                    string villaHeader = "";
                    string custName = "";
                    string custCommentDate = "";
                    string custComment = "";
                    string custNameComment = "";
                    string noOfCustGivenRating = "";
                    string noOfImages = "";
                    string noOfTours = "";
                    string QualityID = "";
                    // string keyNotes = "";
                    int maxoccupancy = 0;
                    int extrachildren = 0;
                    int minoccupancy = 0;
                    List<string> activityHeadings = new List<string>();
                    List<string> objlinks = new List<string>();
                    List<string> keyNotes = new List<string>();
                    string breacrumbList = string.Empty;
                    var villaFeatures = new List<string>();
                    string[] lstBreadcrumb = { };

                    #endregion

                    #region Start Test

                    WriteLogs("########## START ########## Villa ID : " + villaID + " : " + DateTime.Now.ToString() + "##########");

                    #endregion

                    #region Get Villa Details from DB

                    string sqlQuery1 = "EXEC QAsp_GetVillaDetails " + villaID;
                    DataSet dataset1 = getData.getdatafrmdtset(sqlQuery1);
                    DataTable datatable1 = new DataTable();
                    datatable1 = dataset1.Tables[0];

                    villaSummary = datatable1.Rows[0]["summary"].ToString();
                    villaOverviewText = datatable1.Rows[0]["accommodationtext"].ToString();
                    villaLayoutText = datatable1.Rows[0]["accommodationdetails"].ToString();
                    villaLocTabLocText = datatable1.Rows[0]["locationtext"].ToString();
                    villaLocTabLocFeaturestxt = datatable1.Rows[0]["locationdetails"].ToString();
                    villaLocTabGPSLat = datatable1.Rows[0]["latitude"].ToString();
                    villaLocTabGPSLang = datatable1.Rows[0]["longitude"].ToString();
                    villaResortID = datatable1.Rows[0]["resortid"].ToString();
                    villaFullName = datatable1.Rows[0]["fullname"].ToString();
                    villaSubTitle = datatable1.Rows[0]["subtitle"].ToString();
                    villaCenter = datatable1.Rows[0]["centre"].ToString();
                    QualityID = datatable1.Rows[0]["QualityID"].ToString();
                    maxoccupancy = Convert.ToInt32(datatable1.Rows[0]["maxoccupancy"].ToString());
                    extrachildren = Convert.ToInt32(datatable1.Rows[0]["extrachildren"].ToString());
                    minoccupancy = Convert.ToInt32(datatable1.Rows[0]["minoccupancy"].ToString());

                    datatable1 = dataset1.Tables[1];
                    villaCenter = datatable1.Rows[0]["CentreName"].ToString();

                    datatable1 = dataset1.Tables[2];
                    for (int i = 0; i < datatable1.Rows.Count; i++)
                    {
                        activityHeadings.Add(datatable1.Rows[i][0].ToString());
                    }

                    datatable1 = dataset1.Tables[3];
                    breacrumbList = datatable1.Rows[0][0].ToString();
                    lstBreadcrumb = breacrumbList.Split('|');
                    foreach (String listBreadcrumbTags in lstBreadcrumb)
                    {
                        string[] breadcrumbKeyword = listBreadcrumbTags.ToString().Split(',');
                        if (breadcrumbKeyword.Length > 2)
                        {
                            string tempBredcrumb = "";
                            for (int i = 0; i < breadcrumbKeyword.Length - 1; i++)
                            {
                                if (i == 0)
                                {
                                    tempBredcrumb = breadcrumbKeyword[i];
                                }
                                else
                                {
                                    tempBredcrumb = tempBredcrumb + ", " + breadcrumbKeyword[i];
                                }
                            }
                            objlinks.Add(tempBredcrumb);
                        }
                        else
                        {
                            objlinks.Add(breadcrumbKeyword[0]);
                        }
                    }

                    datatable1 = dataset1.Tables[4];
                    for (int i = 0; i < datatable1.Rows.Count; i++)
                    {
                        keyNotes.Add(datatable1.Rows[i][0].ToString());
                    }

                    datatable1 = dataset1.Tables[5];
                    for (int i = 0; i < datatable1.Rows.Count; i++)
                    {
                        villaFacilityText = datatable1.Rows[i][0].ToString();
                        villaFacilityText = villaFacilityText.Trim();
                        villaFacilityTextFinal = villaFacilityTextFinal + villaFacilityText;
                    }

                    datatable1 = dataset1.Tables[6];
                    for (int i = 0; i < datatable1.Rows.Count; i++)
                    {
                        villaLocTabInThisAreatxt = datatable1.Rows[i][0].ToString();
                        villaLocTabInThisAreatxt = villaLocTabInThisAreatxt.Trim();
                        villaLocTabInThisAreatxtFinal = villaLocTabInThisAreatxtFinal + villaLocTabInThisAreatxt;
                    }

                    datatable1 = dataset1.Tables[7];
                    noOfCustGivenRating = datatable1.Rows[0][0].ToString();

                    datatable1 = dataset1.Tables[8];
                    for (int i = 0; i < datatable1.Rows.Count; i++)
                    {
                        villaFeatures.Add(datatable1.Rows[i][0].ToString());
                    }

                    datatable1 = dataset1.Tables[9];
                    noOfImages = datatable1.Rows[0][0].ToString();

                    datatable1 = dataset1.Tables[10];
                    noOfTours = datatable1.Rows[0][0].ToString();

                    #endregion

                    #region Prepare Product URL

                    string strURL = ConfigurationManager.AppSettings["URL"].ToString() + "product.aspx?villaid=" + villaID;

                    #endregion

                    #region Download the page and get the breadcrumb

                    WebClient web = new WebClient();
                    web.UseDefaultCredentials = true;
                    page = null;
                    page = web.DownloadString(strURL);
                    web.Dispose();


                    List<string> lstBreadCrumb = new List<string> { };
                    HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
                    htmlDoc.LoadHtml(page);


                    HtmlNode cnode = htmlDoc.DocumentNode.SelectSingleNode("//div[@id='breadcrumb']");
                    HtmlNodeCollection nCollectyion = cnode.SelectNodes("//span[@itemprop='title']");

                    foreach (HtmlNode mnode in nCollectyion)
                    {
                        string linkTitle = mnode.InnerText.ToString();
                        lstBreadCrumb.Add(linkTitle);
                    }

                    #endregion

                    #region Open Product Page

                    WriteLogs("INFO : Product page opened - Villa ID - " + villaID + " - " + villaFullName + ", " + villaSubTitle + ", " + villaCenter + "  : VERIFICATION");
                    runScript.enterURL_Obj.enterURL_Method(strURL);
                    takeImage(villaID + "_VillaPage");

                    #endregion

                    #region Verify Main Page

                    verifyProductMainPage(runScript, villaID, villaSummary, villaHeader, noOfCustGivenRating, villaFeatures, noOfImages);
                    WriteLogs("PASS : Main Page Contents Verified. : VERIFICATION");

                    #endregion

                    #region Verify Overview Tab

                    verifyOverviewTab(runScript, villaID, villaOverviewText, villaLayoutText, villaFacilityTextFinal);
                    takeImage(villaID + "_VillaPageTabs");
                    //WriteLogs("PASS : Overview Tab Contents Verified. : VERIFICATION");
                    #endregion

                    #region Verify BreadCrumb

                    runScript.verifyBreadcrumbTag_Obj.verifyBreadcrumbTag_Method(objlinks, lstBreadCrumb);
                    runScript.clickAcceptCookiesButton_Obj.clickAcceptCookiesButton_Method();
                    //runScript.clickChatWindow_Obj.clickChatWindow_Method();
                    WriteLogs("PASS : Breadcrumbs Verified. : VERIFICATION");

                    #endregion

                    #region Verify View Map

                    delayExecution("www");
                    runScript.clickViewMap_Obj.clickViewMap_Method();

                    #endregion

                    #region Verify Description Tab

                    runScript.clickDescriptionTab_Obj.clickDescriptionTab_Method();
                    runScript.verifyDescKeyNotes_Obj.verifyDescKeyNotes_Method(keyNotes);
                    //WriteLogs("PASS : Description Tab Contents Verified. : VERIFICATION");

                    #endregion

                    #region Verify Photo Tab

                    runScript.clickPhtoTab_Obj.clickPhotoTab_Method();
                    runScript.clickClicktoEnlarge_Obj.clickClicktoEnlarge_Method();
                    WriteLogs("PASS : Photo Tab Contents Verified. : VERIFICATION");
                    #endregion

                    #region Verify Location Tab

                    runScript.clickLocationTab_Obj.clickLocationTab_Method();
                    verifyLocationTab(runScript, villaID, villaLocTabLocText, villaLocTabLocFeaturestxt, villaLocTabGPSLat, villaLocTabGPSLang, villaResortID, villaLocTabInThisAreatxtFinal);
                    //WriteLogs("PASS : Location Tab Contents Verified. : VERIFICATION");

                    #endregion

                    #region Verify Activities Tab

                    runScript.clickActivitiesTab_Obj.clickActivitiesTab_Method(page);
                    runScript.verifyActivitiesTabHeadings_obj.verifyActivitiesTabHeadings_Method(activityHeadings);
                    WriteLogs("PASS : Activities Tab Content Verified : VERIFICATION");

                    #endregion

                    #region Verify Virtual Tour Tab

                    runScript.clickVirtualTourTab_Obj.clickVirtualTourTab_Method();
                    runScript.verifyNumberOfTours_Obj.verifyNumberOfTours_Method(noOfTours);
                    WriteLogs("PASS : Virtual Tour Tab Verified : VERIFICATION");

                    #endregion

                    #region Verify Review Tab

                    Boolean reviewTabAvailabiltiy = runScript.checkTabAvailablity_Obj.checkTabAvailablity_Method("Reviews");
                    if (reviewTabAvailabiltiy == true)
                    {
                        runScript.clickReviewsTab_Obj.clickReviewsTab_Method();
                        sqlQuery = "SELECT top 1 custname, feedbackdate, custcomments from dbo.tblVillaComments where villaid=" + villaID + " order by feedbackdate desc";
                        dataReader = getData.getData(sqlQuery);
                        while (dataReader.Read())
                        {
                            custName = dataReader[0].ToString();
                            custCommentDate = dataReader[1].ToString();
                            custComment = dataReader[2].ToString();
                        }
                        custCommentDate = Convert.ToDateTime(custCommentDate).ToString("dd-MMM-yyyy");
                        custNameComment = custName + "," + custCommentDate + custComment;
                        verifyReviewTab(runScript, custNameComment);
                    }

                    #endregion

                    #region Verify Availability Tab

                    runScript.clickAvailabilityTab_Obj.clickAvailabilityTab_Method();

                    //runScript.clickViewOnMap_Obj.clickViewOnMap_Method();
                    runScript.clickCheckAvaiandPricesBtn_Obj.clickCheckAvaiandPricesBtn_Method();

                    #endregion

                    #region Verify Min Max Adult Child

                    HtmlComboBox uIDdCalenderMonthsComboBox = runScript.selectActTabDepartsOn_Obj.getCombo_Method();
                    HtmlComboBox uIDdAdultsComboBox = runScript.selectAdult_Obj.getselectAdultDropDown_Method();
                    HtmlComboBox uIDdChildrenComboBox = runScript.selectChild_Obj.getselectChildDropDown_Method();
                    int lastitem = uIDdAdultsComboBox.Items.Count;
                    uIDdAdultsComboBox.SelectedIndex = minoccupancy - 1;
                    int minoccupancyPax = minoccupancy - 1;

                    if (Convert.ToInt32(uIDdAdultsComboBox.SelectedItem) == minoccupancyPax)
                    {
                        WriteLogs("PASS : Min Adult Drop Down value");
                        WriteLogs("PASS : Min Adult Occupancy Verified : VERIFICATION");
                    }
                    else
                    {
                        WriteLogs("FAIL : Min Adult Drop Down value");
                    }

                    uIDdAdultsComboBox.SelectedIndex = lastitem - 1;
                    uIDdChildrenComboBox.SelectedIndex = lastitem - 1;

                    if (Convert.ToInt32(uIDdAdultsComboBox.SelectedItem) == maxoccupancy)
                    {
                        WriteLogs("PASS : Max Adult Drop Down value");
                        WriteLogs("PASS : Max Adult Occupancy Verified : VERIFICATION");
                    }
                    else
                    {
                        WriteLogs("FAIL : Max Adult Drop Down value");
                    }

                    if (Convert.ToInt32(uIDdChildrenComboBox.SelectedItem) == maxoccupancy)
                    {
                        WriteLogs("PASS : Max Child Drop Down value");
                        WriteLogs("PASS : Max Child Occupancy Verified : VERIFICATION");
                    }
                    else
                    {
                        WriteLogs("FAIL : Max Child Drop Down value");
                    }

                    #endregion

                    #region Verify Availability and Price
                    Boolean wht = false;

                    for (int i = 0; i < uIDdCalenderMonthsComboBox.Items.Count; i++)
                    {
                        uIDdCalenderMonthsComboBox.SelectedIndex = i;
                        wht = runScript.selectActTabDate_Obj.selectActTabDate_Method();
                        if (wht == true)
                        {
                            // runScript.selectActTabAirtport_Obj.selectActTabAirport_Method();

                            #region Verify Max Occupancy
                            if (lastitem == 3)
                            {
                                uIDdAdultsComboBox.SelectedIndex = lastitem - 1;
                                uIDdChildrenComboBox.SelectedIndex = lastitem - 1;
                                runScript.clickActTabBookVillaBtn_Obj.selectActTabBookVillaBtn_Method();
                                runScript.verifyMaxOccupancyonPopUp_Obj.verifyMaxOccupancyonPopUp_Method(maxoccupancy + extrachildren);
                                runScript.clickOKonMaxOccupancyPopUp_Obj.clickOKonMaxOccupancyPopUp_Method();
                            }
                            else
                            {
                                uIDdAdultsComboBox.SelectedIndex = lastitem - 1;
                                uIDdChildrenComboBox.SelectedIndex = lastitem - 2;
                                runScript.clickActTabBookVillaBtn_Obj.selectActTabBookVillaBtn_Method();
                                runScript.verifyMaxOccupancyonPopUp_Obj.verifyMaxOccupancyonPopUp_Method(maxoccupancy + extrachildren);
                                runScript.clickOKonMaxOccupancyPopUp_Obj.clickOKonMaxOccupancyPopUp_Method();
                            }

                            #endregion

                            #region Verify Min Occupancy

                            uIDdAdultsComboBox.SelectedIndex = minoccupancy - 1;
                            uIDdChildrenComboBox.SelectedIndex = lastitem - lastitem;
                            runScript.clickActTabBookVillaBtn_Obj.selectActTabBookVillaBtn_Method();
                            runScript.verifyMinOccupancyonPopup_obj.verifyMinOccupancyonPopup_Method(minoccupancy);
                            runScript.clickOnOKMinOccupancyPopup_obj.clickOnOKMinOccupancyPopup_Method();

                            #endregion

                            #region Verify Book with zero adults

                            uIDdAdultsComboBox.SelectedIndex = 0;
                            uIDdChildrenComboBox.SelectedIndex = lastitem - 2;
                            runScript.clickActTabBookVillaBtn_Obj.selectActTabBookVillaBtn_Method();
                            runScript.verifyZeroAdultMessage_obj.verifyZeroAdultMessage_Method();
                            runScript.clickOkFromZeroAdultMessage_obj.clickOkFromZeroAdultMessage_Method();

                            #endregion

                            #region Verify Booking Popup

                            runScript.selectAdult_Obj.selectAdult_Method();
                            runScript.selectChild_Obj.selectChild_Method();
                            runScript.clickActTabBookVillaBtn_Obj.selectActTabBookVillaBtn_Method();
                            string strTemp = runScript.getDateforPriceCompare_Obj.getDateforPriceCompare_Method();
                            string strDate = strTemp.Split(' ')[2];
                            string strMonth = strTemp.Split(' ')[3];
                            string strYear = strTemp.Split(' ')[4];
                            string dt = strDate + " " + strMonth + " " + strYear;
                            WriteLogs("INFO : Date for Price Calculation : " + dt);
                            string villaOnlyPrice = "";
                            sqlQuery = "EXEC dbo.QAsp_CalculateVillaTotalPrice @paramvID = " + villaID +
                                                ", @departureDate = N'" + dt + "', @weeks = 1";

                            dataReader = getData.getData(sqlQuery);
                            while (dataReader.Read())
                            {
                                villaOnlyPrice = dataReader[0].ToString();
                            }
                            decimal price = Convert.ToDecimal(villaOnlyPrice);
                            price = Math.Round(price, 0);
                            villaOnlyPrice = Convert.ToString(price);
                            runScript.verifyActTabVillaOnlyPrice_Obj.verifyActTabVillaOnlyPrice_Method(villaOnlyPrice, dt);
                            break;

                            #endregion
                        }
                    }
                    if (wht == false)
                    {
                        WriteLogs("INFO : Not able to select date for price calculation.");
                    }

                    WriteLogs("PASS : Prices and Availability Verified : VERIFICATION");

                    #endregion

                    #region Verify VeryVillaPlus

                    if (Convert.ToInt32(QualityID) == 3)
                    {
                        runScript.verifyVeryVillaPlus_Obj.verifyVeryVillaPlus_Method();
                    }
                    else
                    {
                        WriteLogs("INFO : NOT VeryVillaPlus Villa");
                    }

                    #endregion

                    #region End Test

                    WriteLogs("########## END ########## Villa ID : " + villaID + " : " + DateTime.Now.ToString() + "##########" + '\n');
                }
                catch (Exception ex)
                {
                    WriteLogs("INFO : Script Failed - " + ex.Message.ToString().Replace("\r\n", string.Empty));
                    WriteLogs("########## END ########## Villa ID : " + villaID + " : " + DateTime.Now.ToString() + "##########" + '\n');
                }
                    #endregion
            }
            #endregion
            runScript.OpenBrowser_Obj.closeBrowser_Method();
        }

        public void verifyReviewTab(InitiateProductPage runScript, string custNameComment)
        {
            custNameComment = custNameComment.Replace("\r\n", string.Empty);
            custNameComment = custNameComment.Trim();
            custNameComment = custNameComment.Replace(" ", string.Empty);
            runScript.verifyReviewTabReviews_Obj.verifyReviewTabReviews_Method(custNameComment);
        }

        public void verifyProductMainPage(InitiateProductPage runScript, string villaID, string villaSummary, string villaHeader, string noOfCustGivenRating, List<string> villaFeatures, string noOfImages)
        {
            
            runScript.verifyMainPageSubTitle_Obj.verifyMainPageSubTitle_Method(villaHeader);

            villaSummary = villaSummary.Replace("\r\n", string.Empty);
            villaSummary = villaSummary.Trim();
            villaSummary = villaSummary.Replace(" ", string.Empty);
            runScript.verifyVillaSummary_Obj.verifyVillaSummary_Method(villaSummary);
            WriteLogs("PASS : Product Page Summary Verified : VERIFICATION");

            

            foreach (string villaFeaturesTxt in villaFeatures)
            {
                runScript.verifyVillaFeatures_Obj.verifyVillaFeatures_Method(villaFeaturesTxt);
                
            }
            WriteLogs("PASS : Product Page Features Verified : VERIFICATION");
            runScript.verifyMainPageNoOfCustGivenRating_Obj.verifyMainPageNoOfCustGivenRating_Method(noOfCustGivenRating);
            runScript.verifyNoOfImages_Obj.verifyNoOfImages_Method(noOfImages);
            WriteLogs("PASS : Product Page Images Verified : VERIFICATION");
        }

        public void verifyOverviewTab(InitiateProductPage runScript, string villaID, string villaOverviewText, string villaLayoutText, string villaFacilityTextFinal)
        {
            
            villaOverviewText = villaOverviewText.Replace("\r\n", string.Empty);
            villaOverviewText = villaOverviewText.Trim();
            runScript.verifyVillaLocationText_Obj.verifyVillaOverViewText_Method(villaOverviewText);

            //villaLayoutText = villaLayoutText.Replace("\r\n", string.Empty);
            //villaLayoutText = villaLayoutText.Trim();
            //runScript.verifyVillaLayoutText_Obj.verifyVillaLayoutText_Method(villaLayoutText);

            villaFacilityTextFinal = villaFacilityTextFinal.Replace("\r\n", string.Empty);
            villaFacilityTextFinal = villaFacilityTextFinal.Trim();
            villaFacilityTextFinal = villaFacilityTextFinal.Replace(" ", string.Empty);

            runScript.verifyVillaFacilityText_Obj.verifyVillaFacilitiesText_Method(villaFacilityTextFinal);
        }

        public void verifyLocationTab(InitiateProductPage runScript, string villaID, string villaLocTabLocText, string villaLocTabLocFeaturestxt, string villaLocTabGPSLat, string villaLocTabGPSLang, string villaResortID, string villaLocTabInThisAreatxtFinal)
        {
            villaLocTabLocText = villaLocTabLocText.Replace("\r\n", string.Empty);
            villaLocTabLocText = villaLocTabLocText.Trim();
            villaLocTabLocText = villaLocTabLocText.Replace(" ", string.Empty);
            runScript.verifyLocationTablocText_Obj.verifyLocationTabLocText_Method(villaLocTabLocText);

            villaLocTabLocFeaturestxt = villaLocTabLocFeaturestxt.Replace("\r\n", string.Empty);
            villaLocTabLocFeaturestxt = villaLocTabLocFeaturestxt.Trim();
            runScript.verifyLocationTabLocFeatures_Obj.verifyLocationTabLocFeatures_Method(villaLocTabLocFeaturestxt);

            villaLocTabInThisAreatxtFinal = villaLocTabInThisAreatxtFinal.Replace("\r\n", string.Empty);
            villaLocTabInThisAreatxtFinal = villaLocTabInThisAreatxtFinal.Trim();
            villaLocTabInThisAreatxtFinal = villaLocTabInThisAreatxtFinal.Replace(" ", string.Empty);
            runScript.verifyLocTabInThisArea_Obj.verifyLocTabInThisArea_Method(villaLocTabInThisAreatxtFinal);

            runScript.verifyLocTabGPSCord_Obj.verifyLocTanLatLang_Method(villaLocTabGPSLat, villaLocTabGPSLang);

            villaResortID = "resortID=" + villaResortID;
            runScript.verifyocTabMAbResort_Obj.verifyLocTabMAresort_Method(villaResortID);
            WriteLogs("PASS : Product Page Contents Verified : VERIFICATION");
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
