using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestAutomation.UIMap.ProductPage.openBrowser_MapClasses;
using TestAutomation.UIMap.ProductPage.enterURL_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyIncompleteBookingpopupDisplay_MapClasses;
using TestAutomation.UIMap.HomePage.verifyChatWndwDisplay_MapClasses;
using TestAutomation.UIMap.SearchTile.clickNOBtnFrmIncompletePopup_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyDestinationListBox_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyDurationListBox_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyAdultListBox_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyChildListBox_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyInfantListbox_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyAirportListBox_MapClasses;
using TestAutomation.UIMap.SearchTile.clickCalenderIcon_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyCalenderDisplay_MapClasses;
using TestAutomation.UIMap.SearchTile.selectMonthFrmCalender_MapClasses;
using TestAutomation.UIMap.SearchTile.selectaDateFrmCalender_MapClasses;
using TestAutomation.UIMap.SearchTile.clickSearchBtn_MapClasses;
using TestAutomation.UIMap.SearchTile.verifySearchResultsPageOpened_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyIncorrectInputPopupDisplayed_MapClasses;
using TestAutomation.UIMap.SearchTile.clickOKFrmIncorrectPopup_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyNoVillasMsgDisplayed_MapClasses;
using TestAutomation.UIMap.SearchTile.clickBookVillaFlightLink_MapClasses;
using TestAutomation.UIMap.SearchTile.clickVillaNFlightsLinkFrmSearchResultsPage_MapClasses;
using TestAutomation.UIMap.SearchTile.clickVillaNameTabfromSearchTile_MapClasses;
using TestAutomation.UIMap.SearchTile.enterAnyCharInVillaNameTxtBox_MapClasses;
using TestAutomation.UIMap.SearchTile.selectaVillaFromList_MapClasses;
using TestAutomation.UIMap.SearchTile.clickViewVillaFrmSearchTile_MapClasses;
using TestAutomation.UIMap.SearchTile.clickBookVillaOnlyLINKFrmSRPage_MapClasses;
using TestAutomation.UIMap.SearchTile.clickBookVillaOnlyBTNFrmSRPage_MapClasses;
using TestAutomation.UIMap.SearchTile.verifyProductPageOpened_MapClasses;
using TestAutomation.UIMap.SearchTile.clickViewVillaBtnFrmSearchResultsPage_MapClasses;
using TestAutomation.UIMap.ProductPage.clickCheckAvaiandPricesBtn_MapClasses;
using TestAutomation.UIMap.ProductPage.selectActTabDepartsOn_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyanydateselectable_MapClasses;
using TestAutomation.UIMap.ProductPage.selectDateFrmProductPage_MapClasses;
using TestAutomation.UIMap.ProductPage.selectActTabDate_MapClasses;
using TestAutomation.UIMap.ProductPage.selectActTabAirtport_MapClasses;
using TestAutomation.UIMap.ProductPage.clickActTabBookVillaBtn_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyVeryVillaPlus_MapClasses;
using TestAutomation.UIMap.ProductPage.setIE9StandardsInDeveloperTools_MapClasses;
using TestAutomation.UIMap.ProductPage.selectAdult_MapClasses;
using TestAutomation.UIMap.ProductPage.selectChild_MapClasses;
using TestAutomation.UIMap.ProductPage.selectInfant_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyMaxOccupancyonPopUp_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyZeroAdultMessage_MapClasses;
using TestAutomation.UIMap.ProductPage.clickOKonMaxOccupancyPopUp_MapClasses;
using TestAutomation.UIMap.ProductPage.clickBookVillaPKonPopup_MapClasses;
using TestAutomation.UIMap.ProductPage.clickBookVillaVOonPopup_MapClasses;
using TestAutomation.UIMap.ProductPage.clickVillaNFlightsBtnFrmProductPage_MapClasses;
using TestAutomation.UIMap.ProductPage.clickBookVillaOnlyBtnFrmProductPage_MapClasses;
using TestAutomation.UIMap.ProductPage.verifyHSPKOpened_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyPreSelctedFlights_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyVODetails_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyVOPrice_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyFExtraDfltTxt_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyVExtraDfltTxt_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyCarDefaultText_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyTransferDfltTxt_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyInsuranceDfltTxt_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyADWDfltTxt_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyATOLDfltTxt_MapClasses;
using TestAutomation.UIMap.BookingPages.getIndividualTotalCosts_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyTotalHolCost_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyDepositDetails_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyDfltTxtfrmIncludeFlts_MapClasses;
using TestAutomation.UIMap.BookingPages.clickIncludeFlightsBtn_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyAirportBoxOpened_MapClasses;
using TestAutomation.UIMap.BookingPages.selectAirporttoIncludeFlights_MapClasses;
using TestAutomation.UIMap.BookingPages.clickGOfrmIncludeFlights_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyHSPagecontent_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlights.clickAddAmendFlights_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlights.verifyAddAmendFltpopupOpened_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlights.clickHideOptions_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlights.clickViewFlightOptions_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlights.verifyNotesTextDisplay_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlights.verifyAlternativeFlightsPanedisplay_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlights.clickSelectBtnforOtherflight_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlights.clickChangeFlightLink_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlights.verifyGetFlightsBtnDisplayed_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlights.verifyAirportListEnabled_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlights.selectAirportForFlight1_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlights.clickGetFlightsBtn_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlights.verifyNoFlightsErrMsgDisplay_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlights.clickDoneBtnFrmFlights_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlightExtras.verifyAddAmendFltExtrasBtnEnabled_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlightExtras.clickAddAmendFlightExtras_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlightExtras.verifyAddAmendFlightExtraspopupOpened_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlightExtras.verifyFlight1tabinFExtrasPopup_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlightExtras.verifyNumofFExtrasDisplayedinPopup_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlightExtras.selectFExtrasFrmCHKbox_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlightExtras.selectFExtrasFrmList_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlightExtras.clickDoneBtnFrmFExtraspopup_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlightExtras.verifyErrPopupDisplayedforFextras_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlightExtras.clickOKFrmErrPopup_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendFlightExtras.clickSaveFlightExtrasBtn_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendVillaExtras.clickAddAmendVillaExtrasBtn_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendVillaExtras.verifyAddAmendVillaExtraspopupDisplay_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendVillaExtras.verifyNumofVExtrasDisplayedinPopup_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendVillaExtras.selectVExtrasFrmList_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendVillaExtras.selectVExtrasfrmChkBox_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendVillaExtras.clickSaveVillaExtrasBtn_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendVillaExtras.verifyselectedVExtrasSavedOnHSPage_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendCarHire.clickAddCarHireBtn_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendCarHire.verifyAddAmendCarHirepopupOpened_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendCarHire.verifyFlight1tabinCarsPopup_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendCarHire.verifyFlightdetailsinCarspopup_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendCarHire.clickSelectBtnfrmCars_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendCarHire.selectChildSeatsForaCar_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendCarHire.clickSaveCarfrmQtypopup_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendCarHire.clickDoneBtnfrmCarsPopup_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendCarHire.clickAmendBtnFrmCars_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendCarHire.clickDeleteBtnForCar_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendCarHire.clickAddAnotherCarBtn_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.clickAddAmendTransfers_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.verifyTransfersPopupOpened_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.verifyFlightDetailsinTransfersPopup_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.verifyFlt1TabfromTransfersPopup_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.clickSelectBtnForTransfers_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.clickSaveTransfers_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.amendTransferways_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.amendTransferQty_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.clickSaveBtnFrmAmendTransfer_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.clickDoneBtnFrmTransfers_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.verifyTransfersErrPopupDisplayed_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.clickOKBtnFrmTransfersErr_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.clickRemoveBtnForaTransfer_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.clickAmendForaTransfer_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.clickDeleteBtnFrmTransfer_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendTransfers.clickAddExtraTransfer_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendInsurance.clickAddInsuranceBtn_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendInsurance.verifyInsurancePopupOpened_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendInsurance.selectPolicyType_MapClasses;
using TestAutomation.UIMap.BookingPages.AddAmendInsurance.clickSaveInsuranceBtn_MapClasses;
using TestAutomation.UIMap.LeadPaxPage.verifyHoldItemsPopupDisplay_MapClasses;
using TestAutomation.UIMap.LeadPaxPage.clickYesFrmHoldItems_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyCheckInBagsPopupOpened_MapClasses;
using TestAutomation.UIMap.BookingPages.clickYesFrmCheckInBags_MapClasses;
using TestAutomation.UIMap.BookingPages.verifyFlightInfoPopupOpened_MapClasses;
using TestAutomation.UIMap.BookingPages.clickLaterFrmFlightInfoPopup_MapClasses;
using TestAutomation.UIMap.LeadPaxPage.clickConitueButton_MapClasses;
using TestAutomation.UIMap.LeadPaxPage.verifyLeadPaxPageOpened_MapClasses;
using TestAutomation.UIMap.LeadPaxPage.verifyLeadPaxPageOpenedForVO_MapClasses;
using TestAutomation.UIMap.LeadPaxPage.enteringLeadPaxDetails_MapClasses;
using TestAutomation.UIMap.LeadPaxPage.getPostCodeDetails_MapClasses;
using TestAutomation.UIMap.LeadPaxPage.verifyAddressListPopUp_MapClasses;
using TestAutomation.UIMap.LeadPaxPage.selectAddressFromList_MapClasses;
using TestAutomation.UIMap.LeadPaxPage.clickSubmitFromAdrsPopup_MapClasses;
using TestAutomation.UIMap.LeadPaxPage.clickNextFrmLeadPaxPage_MapClasses;
using TestAutomation.UIMap.LeadPaxPage.verifyAnotherBkfnd_MapClasses;
using TestAutomation.UIMap.LeadPaxPage.clickNoFrmAnotherBooking_MapClasses;
using TestAutomation.UIMap.LeadPaxPage.clickBackBtnFrmOtherPax_MapClasses;
using TestAutomation.UIMap.OtherPaxPage.verifyOtherPaxPageOpened_MapClasses;
using TestAutomation.UIMap.OtherPaxPage.verifyOtherPaxPageOpenedForVO_MapClasses;
using TestAutomation.UIMap.OtherPaxPage.enteringTestDataInOtherPaxPage_MapClasses;
using TestAutomation.UIMap.OtherPaxPage.selectAdultTitleCombo_MapClasses;
using TestAutomation.UIMap.OtherPaxPage.enterAdultFNames_MapClasses;
using TestAutomation.UIMap.OtherPaxPage.enterAdultLnames_MapClasses;
using TestAutomation.UIMap.OtherPaxPage.selectChildTitleCombo_MapClasses;
using TestAutomation.UIMap.OtherPaxPage.enterChildFNames_MapClasses;
using TestAutomation.UIMap.OtherPaxPage.enterChildLNames_MapClasses;
using TestAutomation.UIMap.OtherPaxPage.selectInfantTitleCombo_MapClasses;
using TestAutomation.UIMap.OtherPaxPage.enterInfantFNames_MapClasses;
using TestAutomation.UIMap.OtherPaxPage.enterInfantLNames_MapClasses;
using TestAutomation.UIMap.OtherPaxPage.clickNextFrmOtherPaxPage_MapClasses;
using TestAutomation.UIMap.ProvConfPage.verifyProvConfPageOpened_MapClasses;
using TestAutomation.UIMap.ProvConfPage.verifyFlightDetailsonProvConfPage_MapClasses;
using TestAutomation.UIMap.ProvConfPage.verifyTotalDepositPPPDetailsonProvConfPage_MapClasses;
using TestAutomation.UIMap.ProvConfPage.clickBookingCondCheckBox_MapClasses;
using TestAutomation.UIMap.ProvConfPage.clickOKFromBookingCondPopup_MapClasses;
using TestAutomation.UIMap.ProvConfPage.selectInsConditionsChkBox_MapClasses;
using TestAutomation.UIMap.ProvConfPage.clickOKBtnFrmInsCondPoupup_MapClasses;
using TestAutomation.UIMap.ProvConfPage.selectWheelChairChkBox_MapClasses;
using TestAutomation.UIMap.ProvConfPage.verifyWheelChairPopupOpened_MapClasses;
using TestAutomation.UIMap.ProvConfPage.selectWheelChairForPax_MapClasses;
using TestAutomation.UIMap.ProvConfPage.clickOKFrmWheelChairPopup_MapClasses;
using TestAutomation.UIMap.ProvConfPage.verifyWheelChairSelected_MapClasses;
using TestAutomation.UIMap.ProvConfPage.clickPayByPhoneButton_MapClasses;
using TestAutomation.UIMap.ProvConfPage.verifyInfopopupopened_MapClasses;
using TestAutomation.UIMap.ProvConfPage.clickContinueBtnforPhone_MapClasses;
using TestAutomation.UIMap.ProvConfPage.clickContinueBtnforOnline_MapClasses;
using TestAutomation.UIMap.ProvConfPage.clickPayOnlineButton_MapClasses;
using TestAutomation.UIMap.ProvConfPage.VerifyTLSpopupdisplayedClasses;
using TestAutomation.UIMap.ProvConfPage.ClickcontinuefromTLSpopupClasses;
using TestAutomation.UIMap.ProvConfPage.clickDisabilityBtn_MapClasses;
using TestAutomation.UIMap.ProvConfPage.selectAirAssistanceForPax_MapClasses;
using TestAutomation.UIMap.ProvConfPage.clickYesFrmPopup_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.verifyPayOnlinePagedisplay_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.clickEditAddressBtn_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.selectCountry_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.enterStreet_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.enterTownCity_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.enterPostCode_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.verifyCntryChngCnfrmppupdisplay_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.clickYESfrmCntryCnfrmPopup_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.selectCardType_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.enterCardNumber_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.selectExpiryMonth_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.selectExpiryYear_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.selectStartYear_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.selectStartMonth_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.enterSecurityCode_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.clickMakePaymentBtn_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.verifyAdviceBtnDisplayed_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.clickAdviceBtn_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.clickPaybyPhoneonPayment_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.verifyAnyErrMsgDispayed_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.isCertErrPageshown_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.clickContinueFrmCertiErrPage_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.clickCancelLinkFrm3DPage_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.enter3DPwd_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.clickSubmitFrm3D_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.clickSubmitFrmVISA3D_MapClasses;
using TestAutomation.UIMap.ThankYouPage.verifyThankYouRefPopupdisplay_MapClasses;
using TestAutomation.UIMap.ThankYouPage.selectRefFromList_MapClasses;
using TestAutomation.UIMap.ThankYouPage.clickNextfrmThankYouRefPopup_MapClasses;
using TestAutomation.UIMap.ThankYouPage.verifyBookingRefTextDisplay_MapClasses;
using TestAutomation.UIMap.ThankYouPage.verifyFlightDetailsonThankYouPage_MapClasses;
using TestAutomation.UIMap.ThankYouPage.verifyTotalDepositPPPThankYouPage_MapClasses;
using TestAutomation.UIMap.TabSearchTile.selectDestfrmTab_MapClasses;
using TestAutomation.UIMap.TabSearchTile.clickCalenderIconFrmTab_MapClasses;
using TestAutomation.UIMap.TabSearchTile.pickaDateFrmTabCalender_MapClasses;
using TestAutomation.UIMap.TabSearchTile.clickOKfromTabCalender_MapClasses;
using TestAutomation.UIMap.TabSearchTile.clickPaxBoxFrmTab_MapClasses;
using TestAutomation.UIMap.TabSearchTile.enterNumofAdultsinTab_MapClasses;
using TestAutomation.UIMap.TabSearchTile.enterNumofChildinTab_MapClasses;
using TestAutomation.UIMap.TabSearchTile.enterNumofInfantsinTab_MapClasses;
using TestAutomation.UIMap.TabSearchTile.clickOKBtnFrmTabPaxLayer_MapClasses;
using TestAutomation.UIMap.TabSearchTile.selectAirportFrmTab_MapClasses;
using TestAutomation.UIMap.TabSearchTile.clickNextArrowFrmCalender_MapClasses;
using TestAutomation.UIMap.TabSearchTile.verifyReqMonShownOnTabCalender_MapClasses;
using TestAutomation.UIMap.TabSearchTile.clickaDatetoMoveNext_MapClasses;
using TestAutomation.UIMap.TabSearchTile.getSelectedDate_MapClasses;
using TestAutomation.UIMap.TabSearchTile.enterDurationinTab_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.verifyAshTest3DpageOpened_MapClasses;
using TestAutomation.UIMap.PayOnlinePage.clickSubmitFrmAshTst3DPge_MapClasses;

namespace TestAutomation.Utility
{
    public class InitiateBookingBPages
    {
        private setIE9StandardsInDeveloperTools_Map setIE9StandardsInDeveloperTools = null;
        private openBrowser_Map openBrowser = null;
        private enterURL_Map enterURL = null;
        private verifyIncompleteBookingpopupDisplay_Map verifyIncompleteBookingpopupDisplay = null;
        private verifyChatWndwDisplay_Map verifyChatWndwDisplay = null;
        private clickNOBtnFrmIncompletePopup_Map clickNOBtnFrmIncompletePopup = null;
        private verifyDestinationListBox_Map verifyDestinationListBox = null;
        private verifyDurationListBox_Map verifyDurationListBox = null;
        private verifyAdultListBox_Map verifyAdultListBox = null;
        private verifyChildListBox_Map verifyChildListBox = null;
        private verifyInfantListbox_Map verifyInfantListbox = null;
        private verifyAirportListBox_Map verifyAirportListBox = null;
        private clickCalenderIcon_Map clickCalenderIcon = null;
        private verifyCalenderDisplay_Map verifyCalenderDisplay = null;
        private selectMonthFrmCalender_Map selectMonthFrmCalender = null;
        private verifyanydateselectable_Map verifyanydateselectable = null;
        private selectaDateFrmCalender_Map selectaDateFrmCalender = null;
        private clickSearchBtn_Map clickSearchBtn = null;
        private verifySearchResultsPageOpened_Map verifySearchResultsPageOpened = null;
        private verifyIncorrectInputPopupDisplayed_Map verifyIncorrectInputPopupDisplayed = null;
        private clickOKFrmIncorrectPopup_Map clickOKFrmIncorrectPopup = null;
        private verifyNoVillasMsgDisplayed_Map verifyNoVillasMsgDisplayed = null;
        private clickVillaNameTabfromSearchTile_Map clickVillaNameTabfromSearchTile = null;
        private enterAnyCharInVillaNameTxtBox_Map enterAnyCharInVillaNameTxtBox = null;
        private selectaVillaFromList_Map selectaVillaFromList = null;
        private clickViewVillaFrmSearchTile_Map clickViewVillaFrmSearchTile = null;
        private verifyProductPageOpened_Map verifyProductPageOpened = null;
        private clickVillaNFlightsLinkFrmSearchResultsPage_Map clickVillaNFlightsLinkFrmSearchResultsPage = null;
        private clickBookVillaFlightLink_Map clickBookVillaFlightLink = null;
        private clickBookVillaOnlyLINKFrmSRPage_Map clickBookVillaOnlyLINKFrmSRPage = null;
        private clickBookVillaOnlyBTNFrmSRPage_Map clickBookVillaOnlyBTNFrmSRPage = null;
        private clickViewVillaBtnFrmSearchResultsPage_Map clickViewVillaBtnFrmSearchResultsPage = null;
        private clickVillaNFlightsBtnFrmProductPage_Map clickVillaNFlightsBtnFrmProductPage = null;
        private clickBookVillaOnlyBtnFrmProductPage_Map clickBookVillaOnlyBtnFrmProductPage = null;
        private clickCheckAvaiandPricesBtn_Map clickCheckAvaiandPricesBtn = null;
        private selectActTabDepartsOn_Map selectActTabDepartsOn = null;
        private selectActTabDate_Map selectActTabDate = null;
        private selectDateFrmProductPage_Map selectDateFrmProductPage = null;
        private selectActTabAirtport_Map selectActTabAirtport = null;
        private clickActTabBookVillaBtn_Map clickActTabBookVillaBtn = null;
        private verifyVeryVillaPlus_Map verifyVeryVillaPlus = null;
        private selectAdult_Map selectAdult = null;
        private selectChild_Map selectChild = null;
        private selectInfant_Map selectInfant = null;
        private verifyMaxOccupancyonPopUp_Map verifyMaxOccupancyonPopUp = null;
        private verifyZeroAdultMessage_Map verifyZeroAdultMessage = null;
        private clickOKonMaxOccupancyPopUp_Map clickOKonMaxOccupancyPopUp = null;
        private clickBookVillaPKonPopup_Map clickBookVillaPKonPopup = null;
        private clickBookVillaVOonPopup_Map clickBookVillaVOonPopup = null;
        private verifyHSPKOpened_Map verifyHSPKOpened = null;
        private verifyPreSelctedFlights_Map verifyPreSelctedFlights = null;
        private verifyVODetails_Map verifyVODetails = null;
        private verifyVOPrice_Map verifyVOPrice = null;
        private verifyFExtraDfltTxt_Map verifyFExtraDfltTxt = null;
        private verifyVExtraDfltTxt_Map verifyVExtraDfltTxt = null;
        private verifyCarDefaultText_Map verifyCarDefaultText = null;
        private verifyTransferDfltTxt_Map verifyTransferDfltTxt = null;
        private verifyInsuranceDfltTxt_Map verifyInsuranceDfltTxt = null;
        private verifyADWDfltTxt_Map verifyADWDfltTxt = null;
        private verifyATOLDfltTxt_Map verifyATOLDfltTxt = null;
        private getIndividualTotalCosts_Map getIndividualTotalCosts = null;
        private verifyTotalHolCost_Map verifyTotalHolCost = null;
        private verifyDepositDetails_Map verifyDepositDetails = null;
        private verifyDfltTxtfrmIncludeFlts_Map verifyDfltTxtfrmIncludeFlts = null;
        private clickIncludeFlightsBtn_Map clickIncludeFlightsBtn = null;
        private verifyAirportBoxOpened_Map verifyAirportBoxOpened = null;
        private selectAirporttoIncludeFlights_Map selectAirporttoIncludeFlights = null;
        private clickGOfrmIncludeFlights_Map clickGOfrmIncludeFlights = null;
        private clickAddAmendFlights_Map clickAddAmendFlights = null;
        private verifyAddAmendFltpopupOpened_Map verifyAddAmendFltpopupOpened = null;
        private clickHideOptions_Map clickHideOptions = null;
        private clickViewFlightOptions_Map clickViewFlightOptions = null;
        private verifyNotesTextDisplay_Map verifyNotesTextDisplay = null;
        private verifyAlternativeFlightsPanedisplay_Map verifyAlternativeFlightsPanedisplay = null;
        private clickSelectBtnforOtherflight_Map clickSelectBtnforOtherflight = null;
        private clickChangeFlightLink_Map clickChangeFlightLink = null;
        private verifyGetFlightsBtnDisplayed_Map verifyGetFlightsBtnDisplayed = null;
        private verifyAirportListEnabled_Map verifyAirportListEnabled = null;
        private selectAirportForFlight1_Map selectAirportForFlight1 = null;
        private clickGetFlightsBtn_Map clickGetFlightsBtn = null;
        private verifyNoFlightsErrMsgDisplay_Map verifyNoFlightsErrMsgDisplay = null;
        private clickDoneBtnFrmFlights_Map clickDoneBtnFrmFlights = null;
        private verifyAddAmendFltExtrasBtnEnabled_Map verifyAddAmendFltExtrasBtnEnabled = null;
        private clickAddAmendFlightExtras_Map clickAddAmendFlightExtras = null;
        private verifyAddAmendFlightExtraspopupOpened_Map verifyAddAmendFlightExtraspopupOpened = null;
        private verifyFlight1tabinFExtrasPopup_Map verifyFlight1tabinFExtrasPopup = null;
        private verifyNumofFExtrasDisplayedinPopup_Map verifyNumofFExtrasDisplayedinPopup = null;
        private selectFExtrasFrmCHKbox_Map selectFExtrasFrmCHKbox = null;
        private selectFExtrasFrmList_Map selectFExtrasFrmList = null;
        private clickDoneBtnFrmFExtraspopup_Map clickDoneBtnFrmFExtraspopup = null;
        private verifyErrPopupDisplayedforFextras_Map verifyErrPopupDisplayedforFextras = null;
        private clickOKFrmErrPopup_Map clickOKFrmErrPopup = null;
        private clickSaveFlightExtrasBtn_Map clickSaveFlightExtrasBtn = null;
        private clickAddAmendVillaExtrasBtn_Map clickAddAmendVillaExtrasBtn = null;
        private verifyAddAmendVillaExtraspopupDisplay_Map verifyAddAmendVillaExtraspopupDisplay = null;
        private verifyNumofVExtrasDisplayedinPopup_Map verifyNumofVExtrasDisplayedinPopup = null;
        private selectVExtrasFrmList_Map selectVExtrasFrmList = null;
        private selectVExtrasfrmChkBox_Map selectVExtrasfrmChkBox = null;
        private clickSaveVillaExtrasBtn_Map clickSaveVillaExtrasBtn = null;
        private verifyselectedVExtrasSavedOnHSPage_Map verifyselectedVExtrasSavedOnHSPage = null;
        private clickAddCarHireBtn_Map clickAddCarHireBtn = null;
        private verifyAddAmendCarHirepopupOpened_Map verifyAddAmendCarHirepopupOpened = null;
        private verifyFlight1tabinCarsPopup_Map verifyFlight1tabinCarsPopup = null;
        private verifyFlightdetailsinCarspopup_Map verifyFlightdetailsinCarspopup = null;
        private clickSelectBtnfrmCars_Map clickSelectBtnfrmCars = null;
        private selectChildSeatsForaCar_Map selectChildSeatsForaCar = null;
        private clickSaveCarfrmQtypopup_Map clickSaveCarfrmQtypopup = null;
        private clickDoneBtnfrmCarsPopup_Map clickDoneBtnfrmCarsPopup = null;
        private clickAmendBtnFrmCars_Map clickAmendBtnFrmCars = null;
        private clickDeleteBtnForCar_Map clickDeleteBtnForCar = null;
        private clickAddAnotherCarBtn_Map clickAddAnotherCarBtn = null;
        private clickAddAmendTransfers_Map clickAddAmendTransfers = null;
        private verifyTransfersPopupOpened_Map verifyTransfersPopupOpened = null;
        private verifyFlightDetailsinTransfersPopup_Map verifyFlightDetailsinTransfersPopup = null;
        private verifyFlt1TabfromTransfersPopup_Map verifyFlt1TabfromTransfersPopup = null;
        private clickSelectBtnForTransfers_Map clickSelectBtnForTransfers = null;
        private clickSaveBtnFrmAmendTransfer_Map clickSaveBtnFrmAmendTransfer = null;
        private amendTransferways_Map amendTransferways = null;
        private amendTransferQty_Map amendTransferQty = null;
        private clickSaveTransfers_Map clickSaveTransfers = null;
        private clickDoneBtnFrmTransfers_Map clickDoneBtnFrmTransfers = null;
        private verifyTransfersErrPopupDisplayed_Map verifyTransfersErrPopupDisplayed = null;
        private clickOKBtnFrmTransfersErr_Map clickOKBtnFrmTransfersErr = null;
        private clickRemoveBtnForaTransfer_Map clickRemoveBtnForaTransfer = null;
        private clickAmendForaTransfer_Map clickAmendForaTransfer = null;
        private clickDeleteBtnFrmTransfer_Map clickDeleteBtnFrmTransfer = null;
        private clickAddExtraTransfer_Map clickAddExtraTransfer = null;
        private clickAddInsuranceBtn_Map clickAddInsuranceBtn = null;
        private verifyInsurancePopupOpened_Map verifyInsurancePopupOpened = null;
        private selectPolicyType_Map selectPolicyType = null;
        private clickSaveInsuranceBtn_Map clickSaveInsuranceBtn = null;
        private verifyFlightInfoPopupOpened_Map verifyFlightInfoPopupOpened = null;
        private clickLaterFrmFlightInfoPopup_Map clickLaterFrmFlightInfoPopup = null;
        private clickConitueButton_Map clickConitueButton = null;
        private verifyHSPagecontent_Map verifyHSPagecontent = null;
        private verifyHoldItemsPopupDisplay_Map verifyHoldItemsPopupDisplay = null;
        private clickYesFrmHoldItems_Map clickYesFrmHoldItems = null;
        private verifyCheckInBagsPopupOpened_Map verifyCheckInBagsPopupOpened = null;
        private clickYesFrmCheckInBags_Map clickYesFrmCheckInBags = null;
        private verifyLeadPaxPageOpened_Map verifyLeadPaxPageOpened = null;
        private verifyLeadPaxPageOpenedForVO_Map verifyLeadPaxPageOpenedForVO = null;
        private enteringLeadPaxDetails_Map enteringLeadPaxDetails = null;
        private getPostCodeDetails_Map getPostCodeDetails = null;
        private verifyAddressListPopUp_Map verifyAddressListPopUp = null;
        private selectAddressFromList_Map selectAddressFromList = null;
        private clickSubmitFromAdrsPopup_Map clickSubmitFromAdrsPopup = null;
        private clickNextFrmLeadPaxPage_Map clickNextFrmLeadPaxPage = null;
        private verifyAnotherBkfnd_Map verifyAnotherBkfnd = null;
        private clickNoFrmAnotherBooking_Map clickNoFrmAnotherBooking = null;
        private clickBackBtnFrmOtherPax_Map clickBackBtnFrmOtherPax = null;
        private verifyOtherPaxPageOpened_Map verifyOtherPaxPageOpened = null;
        private verifyOtherPaxPageOpenedForVO_Map verifyOtherPaxPageOpenedForVO = null;
        private enteringTestDataInOtherPaxPage_Map enteringTestDataInOtherPaxPage = null;
        private selectAdultTitleCombo_Map selectAdultTitleCombo = null;
        private enterAdultFNames_Map enterAdultFNames = null;
        private enterAdultLnames_Map enterAdultLnames = null;
        private selectChildTitleCombo_Map selectChildTitleCombo = null;
        private enterChildFNames_Map enterChildFNames = null;
        private enterChildLNames_Map enterChildLNames = null;
        private selectInfantTitleCombo_Map selectInfantTitleCombo = null;
        private enterInfantFNames_Map enterInfantFNames = null;
        private enterInfantLNames_Map enterInfantLNames = null;
        private clickNextFrmOtherPaxPage_Map clickNextFrmOtherPaxPage = null;
        private verifyProvConfPageOpened_Map verifyProvConfPageOpened = null;
        private verifyFlightDetailsonProvConfPage_Map verifyFlightDetailsonProvConfPage = null;
        private verifyTotalDepositPPPDetailsonProvConfPage_Map verifyTotalDepositPPPDetailsonProvConfPage = null;
        private clickBookingCondCheckBox_Map clickBookingCondCheckBox = null;
        private clickOKFromBookingCondPopup_Map clickOKFromBookingCondPopup = null;
        private selectInsConditionsChkBox_Map selectInsConditionsChkBox = null;
        private clickOKBtnFrmInsCondPoupup_Map clickOKBtnFrmInsCondPoupup = null;
        private selectWheelChairChkBox_Map selectWheelChairChkBox = null;
        private verifyWheelChairPopupOpened_Map verifyWheelChairPopupOpened = null;
        private selectWheelChairForPax_Map selectWheelChairForPax = null;
        private clickOKFrmWheelChairPopup_Map clickOKFrmWheelChairPopup = null;
        private verifyWheelChairSelected_Map verifyWheelChairSelected = null;
        private clickDisabilityBtn_Map clickDisabilityBtn = null;
        private selectAirAssistanceForPax_Map selectAirAssistanceForPax = null;
        private clickYesFrmPopup_Map clickYesFrmPopup = null;
        private clickPayByPhoneButton_Map clickPayByPhoneButton = null;
        private verifyInfopopupopened_Map verifyInfopopupopened = null;
        private clickContinueBtnforPhone_Map clickContinueBtnforPhone = null;
        private clickContinueBtnforOnline_Map clickContinueBtnforOnline = null; 
        private clickPayOnlineButton_Map clickPayOnlineButton = null;
        private verifyPayOnlinePagedisplay_Map verifyPayOnlinePagedisplay = null;
        private clickEditAddressBtn_Map clickEditAddressBtn = null;
        private selectCountry_Map selectCountry = null;
        private enterStreet_Map enterStreet = null;
        private enterTownCity_Map enterTownCity = null;
        private enterPostCode_Map enterPostCode = null;
        private verifyCntryChngCnfrmppupdisplay_Map verifyCntryChngCnfrmppupdisplay = null;
        private clickYESfrmCntryCnfrmPopup_Map clickYESfrmCntryCnfrmPopup = null;
        private selectCardType_Map selectCardType = null;
        private enterCardNumber_Map enterCardNumber = null;
        private selectExpiryMonth_Map selectExpiryMonth = null;
        private selectExpiryYear_Map selectExpiryYear = null;
        private selectStartYear_Map selectStartYear = null;
        private selectStartMonth_Map selectStartMonth = null;
        private enterSecurityCode_Map enterSecurityCode = null;
        private clickMakePaymentBtn_Map clickMakePaymentBtn = null;
        private verifyAdviceBtnDisplayed_Map verifyAdviceBtnDisplayed = null;
        private clickAdviceBtn_Map clickAdviceBtn = null;
        private clickPaybyPhoneonPayment_Map clickPaybyPhoneonPayment = null;
        private verifyAnyErrMsgDispayed_Map verifyAnyErrMsgDispayed = null;
        private isCertErrPageshown_Map isCertErrPageshown = null;
        private clickContinueFrmCertiErrPage_Map clickContinueFrmCertiErrPage = null;
        private enter3DPwd_Map enter3DPwd = null;
        private clickSubmitFrm3D_Map clickSubmitFrm3D = null;
        private clickSubmitFrmVISA3D_Map clickSubmitFrmVISA3D = null;
        private clickCancelLinkFrm3DPage_Map clickCancelLinkFrm3DPage = null;
        private verifyThankYouRefPopupdisplay_Map verifyThankYouRefPopupdisplay = null;
        private selectRefFromList_Map selectRefFromList = null;
        private clickNextfrmThankYouRefPopup_Map clickNextfrmThankYouRefPopup = null;
        private verifyBookingRefTextDisplay_Map verifyBookingRefTextDisplay = null;
        private verifyFlightDetailsonThankYouPage_Map verifyFlightDetailsonThankYouPage = null;
        private verifyTotalDepositPPPThankYouPage_Map verifyTotalDepositPPPThankYouPage = null;
        private selectDestfrmTab_Map selectDestfrmTab = null;
        private clickCalenderIconFrmTab_Map clickCalenderIconFrmTab = null;
        private pickaDateFrmTabCalender_Map pickaDateFrmTabCalender = null;
        private clickOKfromTabCalender_Map clickOKfromTabCalender = null;
        private clickPaxBoxFrmTab_Map clickPaxBoxFrmTab = null;
        private enterNumofAdultsinTab_Map enterNumofAdultsinTab = null;
        private enterNumofChildinTab_Map enterNumofChildinTab = null;
        private enterNumofInfantsinTab_Map enterNumofInfantsinTab = null;
        private clickOKBtnFrmTabPaxLayer_Map clickOKBtnFrmTabPaxLayer = null;
        private selectAirportFrmTab_Map selectAirportFrmTab = null;
        private clickNextArrowFrmCalender_Map clickNextArrowFrmCalender = null;
        private verifyReqMonShownOnTabCalender_Map verifyReqMonShownOnTabCalender = null;
        private clickaDatetoMoveNext_Map clickaDatetoMoveNext = null;
        private getSelectedDate_Map getSelectedDate = null;
        private enterDurationinTab_Map enterDurationinTab = null;
        private VerifyTLSpopupdisplayed_map VerifyTLSpopupdisplayed = null;
        private ClickcontinuefromTLSpopup_Map clickcontinuefromTLSpopup = null;
        private verifyAshTest3DpageOpened_Map verifyAshTest3DpageOpened = null;
        private clickSubmitFrmAshTst3DPge_Map clickSubmitFrmAshTst3DPge = null;
                
        public InitiateBookingBPages()
        {
            openBrowser = new openBrowser_Map();
        }
        public openBrowser_Map OpenBrowser_Obj
        {
            get { return openBrowser; }
            set { openBrowser = value; }
        }
        public enterURL_Map enterURL_Obj
        {
            get
            {
                if (enterURL == null)
                {
                    enterURL = new enterURL_Map();
                    enterURL.UIBlankPageWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterURL;
            }
        }
        
        //***Tab Search Tile***//
        public selectDestfrmTab_Map selectDestfrmTab_Obj
        {
            get
            {
                if (selectDestfrmTab == null)
                {
                    selectDestfrmTab = new selectDestfrmTab_Map();
                    selectDestfrmTab.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectDestfrmTab;
            }
        }
        public clickCalenderIconFrmTab_Map clickCalenderIconFrmTab_Obj
        {
            get
            {
                if (clickCalenderIconFrmTab == null)
                {
                    clickCalenderIconFrmTab = new clickCalenderIconFrmTab_Map();
                    clickCalenderIconFrmTab.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickCalenderIconFrmTab;
            }
        }
        public pickaDateFrmTabCalender_Map pickaDateFrmTabCalender_Obj
        {
            get
            {
                if (pickaDateFrmTabCalender == null)
                {
                    pickaDateFrmTabCalender = new pickaDateFrmTabCalender_Map();
                    pickaDateFrmTabCalender.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return pickaDateFrmTabCalender;
            }
        }
        public clickOKfromTabCalender_Map clickOKfromTabCalender_Obj
        {
            get
            {
                if (clickOKfromTabCalender == null)
                {
                    clickOKfromTabCalender = new clickOKfromTabCalender_Map();
                    clickOKfromTabCalender.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickOKfromTabCalender;
            }
        }
        public clickPaxBoxFrmTab_Map clickPaxBoxFrmTab_Obj
        {
            get
            {
                if (clickPaxBoxFrmTab == null)
                {
                    clickPaxBoxFrmTab = new clickPaxBoxFrmTab_Map();
                    clickPaxBoxFrmTab.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickPaxBoxFrmTab;
            }
        }
        public enterNumofAdultsinTab_Map enterNumofAdultsinTab_Obj
        {
            get
            {
                if (enterNumofAdultsinTab == null)
                {
                    enterNumofAdultsinTab = new enterNumofAdultsinTab_Map();
                    enterNumofAdultsinTab.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterNumofAdultsinTab;
            }
        }
        public enterNumofChildinTab_Map enterNumofChildinTab_Obj
        {
            get
            {
                if (enterNumofChildinTab == null)
                {
                    enterNumofChildinTab = new enterNumofChildinTab_Map();
                    enterNumofChildinTab.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterNumofChildinTab;
            }
        }
        public enterNumofInfantsinTab_Map enterNumofInfantsinTab_Obj
        {
            get
            {
                if (enterNumofInfantsinTab == null)
                {
                    enterNumofInfantsinTab = new enterNumofInfantsinTab_Map();
                    enterNumofInfantsinTab.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterNumofInfantsinTab;
            }
        }
        public clickOKBtnFrmTabPaxLayer_Map clickOKBtnFrmTabPaxLayer_Obj
        {
            get
            {
                if (clickOKBtnFrmTabPaxLayer == null)
                {
                    clickOKBtnFrmTabPaxLayer = new clickOKBtnFrmTabPaxLayer_Map();
                    clickOKBtnFrmTabPaxLayer.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickOKBtnFrmTabPaxLayer;
            }
        }
        public selectAirportFrmTab_Map selectAirportFrmTab_Obj
        {
            get
            {
                if (selectAirportFrmTab == null)
                {
                    selectAirportFrmTab = new selectAirportFrmTab_Map();
                    selectAirportFrmTab.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectAirportFrmTab;
            }
        }
        public clickNextArrowFrmCalender_Map clickNextArrowFrmCalender_Obj
        {
            get
            {
                if (clickNextArrowFrmCalender == null)
                {
                    clickNextArrowFrmCalender = new clickNextArrowFrmCalender_Map();
                    clickNextArrowFrmCalender.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickNextArrowFrmCalender;
            }
        }
        public verifyReqMonShownOnTabCalender_Map verifyReqMonShownOnTabCalender_Obj
        {
            get
            {
                if (verifyReqMonShownOnTabCalender == null)
                {
                    verifyReqMonShownOnTabCalender = new verifyReqMonShownOnTabCalender_Map();
                    verifyReqMonShownOnTabCalender.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyReqMonShownOnTabCalender;
            }
        }
        public clickaDatetoMoveNext_Map clickaDatetoMoveNext_Obj
        {
            get
            {
                if (clickaDatetoMoveNext == null)
                {
                    clickaDatetoMoveNext = new clickaDatetoMoveNext_Map();
                    clickaDatetoMoveNext.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickaDatetoMoveNext;
            }
        }
        public getSelectedDate_Map getSelectedDate_Obj
        {
            get
            {
                if (getSelectedDate == null)
                {
                    getSelectedDate = new getSelectedDate_Map();
                    getSelectedDate.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return getSelectedDate;
            }
        }
        public enterDurationinTab_Map enterDurationinTab_Obj
        {
            get
            {
                if (enterDurationinTab == null)
                {
                    enterDurationinTab = new enterDurationinTab_Map();
                    enterDurationinTab.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterDurationinTab;
            }
        }
                        
        //***Thank You Page***//
        public verifyThankYouRefPopupdisplay_Map verifyThankYouRefPopupdisplay_Obj
        {
            get
            {
                if (verifyThankYouRefPopupdisplay == null)
                {
                    verifyThankYouRefPopupdisplay = new verifyThankYouRefPopupdisplay_Map();
                    verifyThankYouRefPopupdisplay.UIThankYouWindowsInterWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyThankYouRefPopupdisplay;
            }
        }
        public selectRefFromList_Map selectRefFromList_Obj
        {
            get
            {
                if (selectRefFromList == null)
                {
                    selectRefFromList = new selectRefFromList_Map();
                    selectRefFromList.UIThankYouWindowsInterWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectRefFromList;
            }
        }
        public clickNextfrmThankYouRefPopup_Map clickNextfrmThankYouRefPopup_Obj
        {
            get
            {
                if (clickNextfrmThankYouRefPopup == null)
                {
                    clickNextfrmThankYouRefPopup = new clickNextfrmThankYouRefPopup_Map();
                    clickNextfrmThankYouRefPopup.UIThankYouWindowsInterWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickNextfrmThankYouRefPopup;
            }
        }
        public verifyBookingRefTextDisplay_Map verifyBookingRefTextDisplay_Obj
        {
            get
            {
                if (verifyBookingRefTextDisplay == null)
                {
                    verifyBookingRefTextDisplay = new verifyBookingRefTextDisplay_Map();
                    verifyBookingRefTextDisplay.UIThankYouWindowsInterWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyBookingRefTextDisplay;
            }
        }
        public verifyFlightDetailsonThankYouPage_Map verifyFlightDetailsonThankYouPage_Obj
        {
            get
            {
                if (verifyFlightDetailsonThankYouPage == null)
                {
                    verifyFlightDetailsonThankYouPage = new verifyFlightDetailsonThankYouPage_Map();
                    verifyFlightDetailsonThankYouPage.UIThankYouWindowsInterWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyFlightDetailsonThankYouPage;
            }
        }
        public verifyTotalDepositPPPThankYouPage_Map verifyTotalDepositPPPThankYouPage_Obj
        {
            get
            {
                if (verifyTotalDepositPPPThankYouPage == null)
                {
                    verifyTotalDepositPPPThankYouPage = new verifyTotalDepositPPPThankYouPage_Map();
                    verifyTotalDepositPPPThankYouPage.UIThankYouWindowsInterWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyTotalDepositPPPThankYouPage;
            }
        }

        //***Pay Online Page***//
        public verifyPayOnlinePagedisplay_Map verifyPayOnlinePagedisplay_Obj
        {
            get
            {
                if (verifyPayOnlinePagedisplay == null)
                {
                    verifyPayOnlinePagedisplay = new verifyPayOnlinePagedisplay_Map();
                    verifyPayOnlinePagedisplay.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyPayOnlinePagedisplay;
            }
        }
        public clickEditAddressBtn_Map clickEditAddressBtn_Obj
        {
            get
            {
                if (clickEditAddressBtn == null)
                {
                    clickEditAddressBtn = new clickEditAddressBtn_Map();
                    clickEditAddressBtn.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickEditAddressBtn;
            }
        }
        public selectCountry_Map selectCountry_Obj
        {
            get
            {
                if (selectCountry == null)
                {
                    selectCountry = new selectCountry_Map();
                    selectCountry.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectCountry;
            }
        }
        public enterStreet_Map enterStreet_Obj
        {
            get
            {
                if (enterStreet == null)
                {
                    enterStreet = new enterStreet_Map();
                    enterStreet.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterStreet;
            }
        }
        public enterTownCity_Map enterTownCity_Obj
        {
            get
            {
                if (enterTownCity == null)
                {
                    enterTownCity = new enterTownCity_Map();
                    enterTownCity.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterTownCity;
            }
        }
        public enterPostCode_Map enterPostCode_Obj
        {
            get
            {
                if (enterPostCode == null)
                {
                    enterPostCode = new enterPostCode_Map();
                    enterPostCode.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterPostCode;
            }
        }
        public verifyCntryChngCnfrmppupdisplay_Map verifyCntryChngCnfrmppupdisplay_Obj
        {
            get
            {
                if (verifyCntryChngCnfrmppupdisplay == null)
                {
                    verifyCntryChngCnfrmppupdisplay = new verifyCntryChngCnfrmppupdisplay_Map();
                    verifyCntryChngCnfrmppupdisplay.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyCntryChngCnfrmppupdisplay;
            }
        }
        public clickYESfrmCntryCnfrmPopup_Map clickYESfrmCntryCnfrmPopup_Obj
        {
            get
            {
                if (clickYESfrmCntryCnfrmPopup == null)
                {
                    clickYESfrmCntryCnfrmPopup = new clickYESfrmCntryCnfrmPopup_Map();
                    clickYESfrmCntryCnfrmPopup.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickYESfrmCntryCnfrmPopup;
            }
        }
        public selectCardType_Map selectCardType_Obj
        {
            get
            {
                if (selectCardType == null)
                {
                    selectCardType = new selectCardType_Map();
                    selectCardType.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectCardType;
            }
        }
        public enterCardNumber_Map enterCardNumber_Obj
        {
            get
            {
                if (enterCardNumber == null)
                {
                    enterCardNumber = new enterCardNumber_Map();
                    enterCardNumber.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterCardNumber;
            }
        }
        public selectExpiryMonth_Map selectExpiryMonth_Obj
        {
            get
            {
                if (selectExpiryMonth == null)
                {
                    selectExpiryMonth = new selectExpiryMonth_Map();
                    selectExpiryMonth.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectExpiryMonth;
            }
        }
        public selectExpiryYear_Map selectExpiryYear_Obj
        {
            get
            {
                if (selectExpiryYear == null)
                {
                    selectExpiryYear = new selectExpiryYear_Map();
                    selectExpiryYear.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectExpiryYear;
            }
        }
        public selectStartYear_Map selectStartYear_Obj
        {
            get
            {
                if (selectStartYear == null)
                {
                    selectStartYear = new selectStartYear_Map();
                    selectStartYear.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectStartYear;
            }
        }
        public selectStartMonth_Map selectStartMonth_Obj
        {
            get
            {
                if (selectStartMonth == null)
                {
                    selectStartMonth = new selectStartMonth_Map();
                    selectStartMonth.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectStartMonth;
            }
        }
        public enterSecurityCode_Map enterSecurityCode_Obj
        {
            get
            {
                if (enterSecurityCode == null)
                {
                    enterSecurityCode = new enterSecurityCode_Map();
                    enterSecurityCode.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterSecurityCode;
            }
        }
        public clickMakePaymentBtn_Map clickMakePaymentBtn_Obj
        {
            get
            {
                if (clickMakePaymentBtn == null)
                {
                    clickMakePaymentBtn = new clickMakePaymentBtn_Map();
                    clickMakePaymentBtn.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickMakePaymentBtn;
            }
        }
        public verifyAdviceBtnDisplayed_Map verifyAdviceBtnDisplayed_Obj
        {
            get
            {
                if (verifyAdviceBtnDisplayed == null)
                {
                    verifyAdviceBtnDisplayed = new verifyAdviceBtnDisplayed_Map();
                    verifyAdviceBtnDisplayed.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAdviceBtnDisplayed;
            }
        }
        public clickPaybyPhoneonPayment_Map clickPaybyPhoneonPayment_Obj
        {
            get
            {
                if (clickPaybyPhoneonPayment == null)
                {
                    clickPaybyPhoneonPayment = new clickPaybyPhoneonPayment_Map();
                    clickPaybyPhoneonPayment.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickPaybyPhoneonPayment;
            }
        }

        //***3D Security Page***//
        public isCertErrPageshown_Map isCertErrPageshown_Obj
        {
            get
            {
                if (isCertErrPageshown == null)
                {
                    isCertErrPageshown = new isCertErrPageshown_Map();
                    isCertErrPageshown.UICertificateErrorNaviWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return isCertErrPageshown;
            }
        }
        public verifyAnyErrMsgDispayed_Map verifyAnyErrMsgDispayed_Obj
        {
            get
            {
                if (verifyAnyErrMsgDispayed == null)
                {
                    verifyAnyErrMsgDispayed = new verifyAnyErrMsgDispayed_Map();
                    verifyAnyErrMsgDispayed.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAnyErrMsgDispayed;
            }
        }
        public clickContinueFrmCertiErrPage_Map clickContinueFrmCertiErrPage_Obj
        {
            get
            {
                if (clickContinueFrmCertiErrPage == null)
                {
                    clickContinueFrmCertiErrPage = new clickContinueFrmCertiErrPage_Map();
                    clickContinueFrmCertiErrPage.UICertificateErrorNaviWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickContinueFrmCertiErrPage;
            }
        }
        public enter3DPwd_Map enter3DPwd_Obj
        {
            get
            {
                if (enter3DPwd == null)
                {
                    enter3DPwd = new enter3DPwd_Map();
                    enter3DPwd.UIMasterCardSecureCodeWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enter3DPwd;
            }
        }
        public clickSubmitFrm3D_Map clickSubmitFrm3D_Obj
        {
            get
            {
                if (clickSubmitFrm3D == null)
                {
                    clickSubmitFrm3D = new clickSubmitFrm3D_Map();
                    clickSubmitFrm3D.UIMasterCardSecureCodeWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSubmitFrm3D;
            }
        }
        public clickCancelLinkFrm3DPage_Map clickCancelLinkFrm3DPage_Obj
        {
            get
            {
                if (clickCancelLinkFrm3DPage == null)
                {
                    clickCancelLinkFrm3DPage = new clickCancelLinkFrm3DPage_Map();
                    clickCancelLinkFrm3DPage.UIMasterCardSecureCodeWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickCancelLinkFrm3DPage;
            }
        }
        public clickAdviceBtn_Map clickAdviceBtn_Obj
        {
            get
            {
                if (clickAdviceBtn == null)
                {
                    clickAdviceBtn = new clickAdviceBtn_Map();
                    clickAdviceBtn.UIPayOnlineWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAdviceBtn;
            }
        }
        public clickSubmitFrmVISA3D_Map clickSubmitFrmVISA3D_Obj
        {
            get
            {
                if (clickSubmitFrmVISA3D == null)
                {
                    clickSubmitFrmVISA3D = new clickSubmitFrmVISA3D_Map();
                    clickSubmitFrmVISA3D.UIVerifiedbyVISAWindowWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSubmitFrmVISA3D;
            }
        }
        public verifyAshTest3DpageOpened_Map verifyAshTest3DpageOpened_Obj
        {
            get
            {
                if (verifyAshTest3DpageOpened == null)
                {
                    verifyAshTest3DpageOpened = new verifyAshTest3DpageOpened_Map();
                    verifyAshTest3DpageOpened.UIUntitledPageInternetWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAshTest3DpageOpened;
            }
        }
        public clickSubmitFrmAshTst3DPge_Map clickSubmitFrmAshTst3DPge_Obj
        {
            get
            {
                if (clickSubmitFrmAshTst3DPge == null)
                {
                    clickSubmitFrmAshTst3DPge = new clickSubmitFrmAshTst3DPge_Map();
                    clickSubmitFrmAshTst3DPge.UIUntitledPageInternetWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSubmitFrmAshTst3DPge;
            }
        }



        //***Prov Conf Page***//
        public verifyProvConfPageOpened_Map verifyProvConfPageOpened_Obj
        {
            get
            {
                if (verifyProvConfPageOpened == null)
                {
                    verifyProvConfPageOpened = new verifyProvConfPageOpened_Map();
                    verifyProvConfPageOpened.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyProvConfPageOpened;
            }
        }
        public verifyFlightDetailsonProvConfPage_Map verifyFlightDetailsonProvConfPage_Obj
        {
            get
            {
                if (verifyFlightDetailsonProvConfPage == null)
                {
                    verifyFlightDetailsonProvConfPage = new verifyFlightDetailsonProvConfPage_Map();
                    verifyFlightDetailsonProvConfPage.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyFlightDetailsonProvConfPage;
            }
        }
        public verifyTotalDepositPPPDetailsonProvConfPage_Map verifyTotalDepositPPPDetailsonProvConfPage_Obj
        {
            get
            {
                if (verifyTotalDepositPPPDetailsonProvConfPage == null)
                {
                    verifyTotalDepositPPPDetailsonProvConfPage = new verifyTotalDepositPPPDetailsonProvConfPage_Map();
                    verifyTotalDepositPPPDetailsonProvConfPage.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyTotalDepositPPPDetailsonProvConfPage;
            }
        }
        public clickBookingCondCheckBox_Map clickBookingCondCheckBox_Obj
        {
            get
            {
                if (clickBookingCondCheckBox == null)
                {
                    clickBookingCondCheckBox = new clickBookingCondCheckBox_Map();
                    clickBookingCondCheckBox.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBookingCondCheckBox;
            }
        }
        public clickOKFromBookingCondPopup_Map clickOKFromBookingCondPopup_Obj
        {
            get
            {
                if (clickOKFromBookingCondPopup == null)
                {
                    clickOKFromBookingCondPopup = new clickOKFromBookingCondPopup_Map();
                    clickOKFromBookingCondPopup.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickOKFromBookingCondPopup;
            }
        }
        public selectInsConditionsChkBox_Map selectInsConditionsChkBox_Obj
        {
            get
            {
                if (selectInsConditionsChkBox == null)
                {
                    selectInsConditionsChkBox = new selectInsConditionsChkBox_Map();
                    selectInsConditionsChkBox.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectInsConditionsChkBox;
            }
        }
        public clickOKBtnFrmInsCondPoupup_Map clickOKBtnFrmInsCondPoupup_Obj
        {
            get
            {
                if (clickOKBtnFrmInsCondPoupup == null)
                {
                    clickOKBtnFrmInsCondPoupup = new clickOKBtnFrmInsCondPoupup_Map();
                    clickOKBtnFrmInsCondPoupup.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickOKBtnFrmInsCondPoupup;
            }
        }
        public selectWheelChairChkBox_Map selectWheelChairChkBox_Obj
        {
            get
            {
                if (selectWheelChairChkBox == null)
                {
                    selectWheelChairChkBox = new selectWheelChairChkBox_Map();
                    selectWheelChairChkBox.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectWheelChairChkBox;
            }
        }
        public verifyWheelChairPopupOpened_Map verifyWheelChairPopupOpened_Obj
        {
            get
            {
                if (verifyWheelChairPopupOpened == null)
                {
                    verifyWheelChairPopupOpened = new verifyWheelChairPopupOpened_Map();
                    verifyWheelChairPopupOpened.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyWheelChairPopupOpened;
            }
        }
        public selectWheelChairForPax_Map selectWheelChairForPax_Obj
        {
            get
            {
                if (selectWheelChairForPax == null)
                {
                    selectWheelChairForPax = new selectWheelChairForPax_Map();
                    selectWheelChairForPax.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectWheelChairForPax;
            }
        }
        public clickOKFrmWheelChairPopup_Map clickOKFrmWheelChairPopup_Obj
        {
            get
            {
                if (clickOKFrmWheelChairPopup == null)
                {
                    clickOKFrmWheelChairPopup = new clickOKFrmWheelChairPopup_Map();
                    clickOKFrmWheelChairPopup.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickOKFrmWheelChairPopup;
            }
        }
        public verifyWheelChairSelected_Map verifyWheelChairSelected_Obj
        {
            get
            {
                if (verifyWheelChairSelected == null)
                {
                    verifyWheelChairSelected = new verifyWheelChairSelected_Map();
                    verifyWheelChairSelected.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyWheelChairSelected;
            }
        }
        public clickDisabilityBtn_Map clickDisabilityBtn_Obj
        {
            get
            {
                if (clickDisabilityBtn == null)
                {
                    clickDisabilityBtn = new clickDisabilityBtn_Map();
                    clickDisabilityBtn.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickDisabilityBtn;
            }
        }
        public selectAirAssistanceForPax_Map selectAirAssistanceForPax_Obj
        {
            get
            {
                if (selectAirAssistanceForPax == null)
                {
                    selectAirAssistanceForPax = new selectAirAssistanceForPax_Map();
                    selectAirAssistanceForPax.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectAirAssistanceForPax;
            }
        }
        public clickYesFrmPopup_Map clickYesFrmPopup_Obj
        {
            get
            {
                if (clickYesFrmPopup == null)
                {
                    clickYesFrmPopup = new clickYesFrmPopup_Map();
                    clickYesFrmPopup.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickYesFrmPopup;
            }
        }
        public clickPayByPhoneButton_Map clickPayByPhoneButton_Obj
        {
            get
            {
                if (clickPayByPhoneButton == null)
                {
                    clickPayByPhoneButton = new clickPayByPhoneButton_Map();
                    clickPayByPhoneButton.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickPayByPhoneButton;
            }
        }
        public verifyInfopopupopened_Map verifyInfopopupopened_Obj
        {
            get
            {
                if (verifyInfopopupopened == null)
                {
                    verifyInfopopupopened = new verifyInfopopupopened_Map();
                    verifyInfopopupopened.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyInfopopupopened;
            }
        }
        public clickContinueBtnforPhone_Map clickContinueBtnforPhone_Obj
        {
            get
            {
                if (clickContinueBtnforPhone == null)
                {
                    clickContinueBtnforPhone = new clickContinueBtnforPhone_Map();
                    clickContinueBtnforPhone.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickContinueBtnforPhone;
            }
        }
        public clickContinueBtnforOnline_Map clickContinueBtnforOnline_Obj
        {
            get
            {
                if (clickContinueBtnforOnline == null)
                {
                    clickContinueBtnforOnline = new clickContinueBtnforOnline_Map();
                    clickContinueBtnforOnline.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickContinueBtnforOnline;
            }
        }
        public clickPayOnlineButton_Map clickPayOnlineButton_Obj
        {
            get
            {
                if (clickPayOnlineButton == null)
                {
                    clickPayOnlineButton = new clickPayOnlineButton_Map();
                    clickPayOnlineButton.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickPayOnlineButton;
            }
        }
        public VerifyTLSpopupdisplayed_map VerifyTLSpopupdisplayed_obj
        {
            get
            {
                if (VerifyTLSpopupdisplayed == null)
                {
                    VerifyTLSpopupdisplayed = new VerifyTLSpopupdisplayed_map();
                    VerifyTLSpopupdisplayed.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return VerifyTLSpopupdisplayed;
            }
        }
        public ClickcontinuefromTLSpopup_Map clickcontinuefromTLSpopup_obj
        {
            get
            {
                if (clickcontinuefromTLSpopup == null)
                {
                    clickcontinuefromTLSpopup = new ClickcontinuefromTLSpopup_Map();
                    clickcontinuefromTLSpopup.UIVillaPlusHolidayBookWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickcontinuefromTLSpopup;
            }
        }
        
        //***Other Pax Page***//
        public verifyOtherPaxPageOpened_Map verifyOtherPaxPageOpened_Obj
        {
            get
            {
                if (verifyOtherPaxPageOpened == null)
                {
                    verifyOtherPaxPageOpened = new verifyOtherPaxPageOpened_Map();
                    verifyOtherPaxPageOpened.UIOtherPassengersDetaiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyOtherPaxPageOpened;
            }
        }
        public verifyOtherPaxPageOpenedForVO_Map verifyOtherPaxPageOpenedForVO_Obj
        {
            get
            {
                if (verifyOtherPaxPageOpenedForVO == null)
                {
                    verifyOtherPaxPageOpenedForVO = new verifyOtherPaxPageOpenedForVO_Map();
                    verifyOtherPaxPageOpenedForVO.UIOtherPartyMembersDetWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyOtherPaxPageOpenedForVO;
            }
        }
        public enteringTestDataInOtherPaxPage_Map enteringTestDataInOtherPaxPage_Obj
        {
            get
            {
                if (enteringTestDataInOtherPaxPage == null)
                {
                    enteringTestDataInOtherPaxPage = new enteringTestDataInOtherPaxPage_Map();
                    enteringTestDataInOtherPaxPage.UIOtherPassengersDetaiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enteringTestDataInOtherPaxPage;
            }
        }
        public selectAdultTitleCombo_Map selectAdultTitleCombo_Obj
        {
            get
            {
                if (selectAdultTitleCombo == null)
                {
                    selectAdultTitleCombo = new selectAdultTitleCombo_Map();
                    selectAdultTitleCombo.UIOtherPassengersDetaiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectAdultTitleCombo;
            }
        }
        public enterAdultFNames_Map enterAdultFNames_Obj
        {
            get
            {
                if (enterAdultFNames == null)
                {
                    enterAdultFNames = new enterAdultFNames_Map();
                    enterAdultFNames.UIOtherPassengersDetaiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterAdultFNames;
            }
        }
        public enterAdultLnames_Map enterAdultLnames_Obj
        {
            get
            {
                if (enterAdultLnames == null)
                {
                    enterAdultLnames = new enterAdultLnames_Map();
                    enterAdultLnames.UIOtherPassengersDetaiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterAdultLnames;
            }
        }
        public selectChildTitleCombo_Map selectChildTitleCombo_Obj
        {
            get
            {
                if (selectChildTitleCombo == null)
                {
                    selectChildTitleCombo = new selectChildTitleCombo_Map();
                    selectChildTitleCombo.UIOtherPassengersDetaiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectChildTitleCombo;
            }
        }
        public enterChildFNames_Map enterChildFNames_Obj
        {
            get
            {
                if (enterChildFNames == null)
                {
                    enterChildFNames = new enterChildFNames_Map();
                    enterChildFNames.UIOtherPassengersDetaiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterChildFNames;
            }
        }
        public enterChildLNames_Map enterChildLNames_Obj
        {
            get
            {
                if (enterChildLNames == null)
                {
                    enterChildLNames = new enterChildLNames_Map();
                    enterChildLNames.UIOtherPassengersDetaiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterChildLNames;
            }
        }
        public selectInfantTitleCombo_Map selectInfantTitleCombo_Obj
        {
            get
            {
                if (selectInfantTitleCombo == null)
                {
                    selectInfantTitleCombo = new selectInfantTitleCombo_Map();
                    selectInfantTitleCombo.UIOtherPassengersDetaiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectInfantTitleCombo;
            }
        }
        public enterInfantFNames_Map enterInfantFNames_Obj
        {
            get
            {
                if (enterInfantFNames == null)
                {
                    enterInfantFNames = new enterInfantFNames_Map();
                    enterInfantFNames.UIOtherPassengersDetaiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterInfantFNames;
            }
        }
        public enterInfantLNames_Map enterInfantLNames_Obj
        {
            get
            {
                if (enterInfantLNames == null)
                {
                    enterInfantLNames = new enterInfantLNames_Map();
                    enterInfantLNames.UIOtherPassengersDetaiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterInfantLNames;
            }
        }
        public clickNextFrmOtherPaxPage_Map clickNextFrmOtherPaxPage_Obj
        {
            get
            {
                if (clickNextFrmOtherPaxPage == null)
                {
                    clickNextFrmOtherPaxPage = new clickNextFrmOtherPaxPage_Map();
                    clickNextFrmOtherPaxPage.UIOtherPassengersDetaiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickNextFrmOtherPaxPage;
            }
        }

        //***Lead Pax Page***//
        public verifyFlightInfoPopupOpened_Map verifyFlightInfoPopupOpened_Obj
        {
            get
            {
                if (verifyFlightInfoPopupOpened == null)
                {
                    verifyFlightInfoPopupOpened = new verifyFlightInfoPopupOpened_Map();
                    verifyFlightInfoPopupOpened.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyFlightInfoPopupOpened;
            }
        }
        public clickLaterFrmFlightInfoPopup_Map clickLaterFrmFlightInfoPopup_Obj
        {
            get
            {
                if (clickLaterFrmFlightInfoPopup == null)
                {
                    clickLaterFrmFlightInfoPopup = new clickLaterFrmFlightInfoPopup_Map();
                    clickLaterFrmFlightInfoPopup.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickLaterFrmFlightInfoPopup;
            }
        }
        public clickConitueButton_Map clickConitueButton_Obj
        {
            get
            {
                if (clickConitueButton == null)
                {
                    clickConitueButton = new clickConitueButton_Map();
                    clickConitueButton.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickConitueButton;
            }
        }

        public verifyHoldItemsPopupDisplay_Map verifyHoldItemsPopupDisplay_Obj
        {
            get
            {
                if (verifyHoldItemsPopupDisplay == null)
                {
                    verifyHoldItemsPopupDisplay = new verifyHoldItemsPopupDisplay_Map();
                    verifyHoldItemsPopupDisplay.UIYourHolidaySummaryInWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyHoldItemsPopupDisplay;
            }
        }
        public clickYesFrmHoldItems_Map clickYesFrmHoldItems_Obj
        {
            get
            {
                if (clickYesFrmHoldItems == null)
                {
                    clickYesFrmHoldItems = new clickYesFrmHoldItems_Map();
                    clickYesFrmHoldItems.UIYourHolidaySummaryInWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickYesFrmHoldItems;
            }
        }

        public verifyLeadPaxPageOpened_Map verifyLeadPaxPageOpened_Obj
        {
            get
            {
                if (verifyLeadPaxPageOpened == null)
                {
                    verifyLeadPaxPageOpened = new verifyLeadPaxPageOpened_Map();
                    verifyLeadPaxPageOpened.UIAllocateLeadPassengeWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyLeadPaxPageOpened;
            }
        }
        public verifyLeadPaxPageOpenedForVO_Map verifyLeadPaxPageOpenedForVO_Obj
        {
            get
            {
                if (verifyLeadPaxPageOpenedForVO == null)
                {
                    verifyLeadPaxPageOpenedForVO = new verifyLeadPaxPageOpenedForVO_Map();
                    verifyLeadPaxPageOpenedForVO.UIAllocateLeadPartyMemWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyLeadPaxPageOpenedForVO;
            }
        }
        public enteringLeadPaxDetails_Map enteringLeadPaxDetails_Obj
        {
            get
            {
                if (enteringLeadPaxDetails == null)
                {
                    enteringLeadPaxDetails = new enteringLeadPaxDetails_Map();
                    enteringLeadPaxDetails.UIAllocateLeadPassengeWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enteringLeadPaxDetails;
            }
        }
        public getPostCodeDetails_Map getPostCodeDetails_Obj
        {
            get
            {
                if (getPostCodeDetails == null)
                {
                    getPostCodeDetails = new getPostCodeDetails_Map();
                    getPostCodeDetails.UIAllocateLeadPassengeWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return getPostCodeDetails;
            }
        }
        public verifyAddressListPopUp_Map verifyAddressListPopUp_Obj
        {
            get
            {
                if (verifyAddressListPopUp == null)
                {
                    verifyAddressListPopUp = new verifyAddressListPopUp_Map();
                    verifyAddressListPopUp.UIAllocateLeadPassengeWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAddressListPopUp;
            }
        }
        public selectAddressFromList_Map selectAddressFromList_Obj
        {
            get
            {
                if (selectAddressFromList == null)
                {
                    selectAddressFromList = new selectAddressFromList_Map();
                    selectAddressFromList.UIAllocateLeadPassengeWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectAddressFromList;
            }
        }
        public clickSubmitFromAdrsPopup_Map clickSubmitFromAdrsPopup_Obj
        {
            get
            {
                if (clickSubmitFromAdrsPopup == null)
                {
                    clickSubmitFromAdrsPopup = new clickSubmitFromAdrsPopup_Map();
                    clickSubmitFromAdrsPopup.UIAllocateLeadPassengeWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSubmitFromAdrsPopup;
            }
        }
        public clickNextFrmLeadPaxPage_Map clickNextFrmLeadPaxPage_Obj
        {
            get
            {
                if (clickNextFrmLeadPaxPage == null)
                {
                    clickNextFrmLeadPaxPage = new clickNextFrmLeadPaxPage_Map();
                    clickNextFrmLeadPaxPage.UIAllocateLeadPassengeWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickNextFrmLeadPaxPage;
            }
        }
        public verifyAnotherBkfnd_Map verifyAnotherBkfnd_Obj
        {
            get
            {
                if (verifyAnotherBkfnd == null)
                {
                    verifyAnotherBkfnd = new verifyAnotherBkfnd_Map();
                    verifyAnotherBkfnd.UIAllocateLeadPassengeWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAnotherBkfnd;
            }
        }
        public clickNoFrmAnotherBooking_Map clickNoFrmAnotherBooking_Obj
        {
            get
            {
                if (clickNoFrmAnotherBooking == null)
                {
                    clickNoFrmAnotherBooking = new clickNoFrmAnotherBooking_Map();
                    clickNoFrmAnotherBooking.UIAllocateLeadPassengeWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickNoFrmAnotherBooking;
            }
        }
        public clickBackBtnFrmOtherPax_Map clickBackBtnFrmOtherPax_Obj
        {
            get
            {
                if (clickBackBtnFrmOtherPax == null)
                {
                    clickBackBtnFrmOtherPax = new clickBackBtnFrmOtherPax_Map();
                    clickBackBtnFrmOtherPax.UIOtherPassengersDetaiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBackBtnFrmOtherPax;
            }
        }
        
        //***Add/Amend Insurnace Popup***//
        public clickAddInsuranceBtn_Map clickAddInsuranceBtn_Obj
        {
            get
            {
                if (clickAddInsuranceBtn == null)
                {
                    clickAddInsuranceBtn = new clickAddInsuranceBtn_Map();
                    clickAddInsuranceBtn.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAddInsuranceBtn;
            }
        }
        public verifyInsurancePopupOpened_Map verifyInsurancePopupOpened_Obj
        {
            get
            {
                if (verifyInsurancePopupOpened == null)
                {
                    verifyInsurancePopupOpened = new verifyInsurancePopupOpened_Map();
                    verifyInsurancePopupOpened.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyInsurancePopupOpened;
            }
        }
        public selectPolicyType_Map selectPolicyType_Obj
        {
            get
            {
                if (selectPolicyType == null)
                {
                    selectPolicyType = new selectPolicyType_Map();
                    selectPolicyType.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectPolicyType;
            }
        }
        public clickSaveInsuranceBtn_Map clickSaveInsuranceBtn_Obj
        {
            get
            {
                if (clickSaveInsuranceBtn == null)
                {
                    clickSaveInsuranceBtn = new clickSaveInsuranceBtn_Map();
                    clickSaveInsuranceBtn.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSaveInsuranceBtn;
            }
        }
        
        //***Add/Amend Transfers Popup***//
        public clickAddAmendTransfers_Map clickAddAmendTransfers_Obj
        {
            get
            {
                if (clickAddAmendTransfers == null)
                {
                    clickAddAmendTransfers = new clickAddAmendTransfers_Map();
                    clickAddAmendTransfers.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAddAmendTransfers;
            }
        }
        public verifyTransfersPopupOpened_Map verifyTransfersPopupOpened_Obj
        {
            get
            {
                if (verifyTransfersPopupOpened == null)
                {
                    verifyTransfersPopupOpened = new verifyTransfersPopupOpened_Map();
                    verifyTransfersPopupOpened.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyTransfersPopupOpened;
            }
        }
        public verifyFlightDetailsinTransfersPopup_Map verifyFlightDetailsinTransfersPopup_Obj
        {
            get
            {
                if (verifyFlightDetailsinTransfersPopup == null)
                {
                    verifyFlightDetailsinTransfersPopup = new verifyFlightDetailsinTransfersPopup_Map();
                    verifyFlightDetailsinTransfersPopup.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyFlightDetailsinTransfersPopup;
            }
        }
        public verifyFlt1TabfromTransfersPopup_Map verifyFlt1TabfromTransfersPopup_Obj
        {
            get
            {
                if (verifyFlt1TabfromTransfersPopup == null)
                {
                    verifyFlt1TabfromTransfersPopup = new verifyFlt1TabfromTransfersPopup_Map();
                    verifyFlt1TabfromTransfersPopup.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyFlt1TabfromTransfersPopup;
            }
        }
        public clickSelectBtnForTransfers_Map clickSelectBtnForTransfers_Obj
        {
            get
            {
                if (clickSelectBtnForTransfers == null)
                {
                    clickSelectBtnForTransfers = new clickSelectBtnForTransfers_Map();
                    clickSelectBtnForTransfers.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSelectBtnForTransfers;
            }
        }
        public clickSaveTransfers_Map clickSaveTransfers_Obj
        {
            get
            {
                if (clickSaveTransfers == null)
                {
                    clickSaveTransfers = new clickSaveTransfers_Map();
                    clickSaveTransfers.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSaveTransfers;
            }
        }
        public clickDoneBtnFrmTransfers_Map clickDoneBtnFrmTransfers_Obj
        {
            get
            {
                if (clickDoneBtnFrmTransfers == null)
                {
                    clickDoneBtnFrmTransfers = new clickDoneBtnFrmTransfers_Map();
                    clickDoneBtnFrmTransfers.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickDoneBtnFrmTransfers;
            }
        }
        public verifyTransfersErrPopupDisplayed_Map verifyTransfersErrPopupDisplayed_Obj
        {
            get
            {
                if (verifyTransfersErrPopupDisplayed == null)
                {
                    verifyTransfersErrPopupDisplayed = new verifyTransfersErrPopupDisplayed_Map();
                    verifyTransfersErrPopupDisplayed.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyTransfersErrPopupDisplayed;
            }
        }
        public clickOKBtnFrmTransfersErr_Map clickOKBtnFrmTransfersErr_Obj
        {
            get
            {
                if (clickOKBtnFrmTransfersErr == null)
                {
                    clickOKBtnFrmTransfersErr = new clickOKBtnFrmTransfersErr_Map();
                    clickOKBtnFrmTransfersErr.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickOKBtnFrmTransfersErr;
            }
        }
        public clickRemoveBtnForaTransfer_Map clickRemoveBtnForaTransfer_Obj
        {
            get
            {
                if (clickRemoveBtnForaTransfer == null)
                {
                    clickRemoveBtnForaTransfer = new clickRemoveBtnForaTransfer_Map();
                    clickRemoveBtnForaTransfer.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickRemoveBtnForaTransfer;
            }
        }
        public clickAmendForaTransfer_Map clickAmendForaTransfer_Obj
        {
            get
            {
                if (clickAmendForaTransfer == null)
                {
                    clickAmendForaTransfer = new clickAmendForaTransfer_Map();
                    clickAmendForaTransfer.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAmendForaTransfer;
            }
        }
        public amendTransferways_Map amendTransferways_Obj
        {
            get
            {
                if (amendTransferways == null)
                {
                    amendTransferways = new amendTransferways_Map();
                    amendTransferways.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return amendTransferways;
            }
        }
        public amendTransferQty_Map amendTransferQty_Obj
        {
            get
            {
                if (amendTransferQty == null)
                {
                    amendTransferQty = new amendTransferQty_Map();
                    amendTransferQty.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return amendTransferQty;
            }
        }
        public clickDeleteBtnFrmTransfer_Map clickDeleteBtnFrmTransfer_Obj
        {
            get
            {
                if (clickDeleteBtnFrmTransfer == null)
                {
                    clickDeleteBtnFrmTransfer = new clickDeleteBtnFrmTransfer_Map();
                    clickDeleteBtnFrmTransfer.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickDeleteBtnFrmTransfer;
            }
        }
        public clickAddExtraTransfer_Map clickAddExtraTransfer_Obj
        {
            get
            {
                if (clickAddExtraTransfer == null)
                {
                    clickAddExtraTransfer = new clickAddExtraTransfer_Map();
                    clickAddExtraTransfer.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAddExtraTransfer;
            }
        }
        public clickSaveBtnFrmAmendTransfer_Map clickSaveBtnFrmAmendTransfer_Obj
        {
            get
            {
                if (clickSaveBtnFrmAmendTransfer == null)
                {
                    clickSaveBtnFrmAmendTransfer = new clickSaveBtnFrmAmendTransfer_Map();
                    clickSaveBtnFrmAmendTransfer.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSaveBtnFrmAmendTransfer;
            }
        }

        //***Add/Amend Car Hire Popup***//
        public clickAddCarHireBtn_Map clickAddCarHireBtn_Obj
        {
            get
            {
                if (clickAddCarHireBtn == null)
                {
                    clickAddCarHireBtn = new clickAddCarHireBtn_Map();
                    clickAddCarHireBtn.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAddCarHireBtn;
            }
        }
        public verifyAddAmendCarHirepopupOpened_Map verifyAddAmendCarHirepopupOpened_Obj
        {
            get
            {
                if (verifyAddAmendCarHirepopupOpened == null)
                {
                    verifyAddAmendCarHirepopupOpened = new verifyAddAmendCarHirepopupOpened_Map();
                    verifyAddAmendCarHirepopupOpened.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAddAmendCarHirepopupOpened;
            }
        }
        public verifyFlight1tabinCarsPopup_Map verifyFlight1tabinCarsPopup_Obj
        {
            get
            {
                if (verifyFlight1tabinCarsPopup == null)
                {
                    verifyFlight1tabinCarsPopup = new verifyFlight1tabinCarsPopup_Map();
                    verifyFlight1tabinCarsPopup.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyFlight1tabinCarsPopup;
            }
        }
        public verifyFlightdetailsinCarspopup_Map verifyFlightdetailsinCarspopup_Obj
        {
            get
            {
                if (verifyFlightdetailsinCarspopup == null)
                {
                    verifyFlightdetailsinCarspopup = new verifyFlightdetailsinCarspopup_Map();
                    verifyFlightdetailsinCarspopup.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyFlightdetailsinCarspopup;
            }
        }
        public clickSelectBtnfrmCars_Map clickSelectBtnfrmCars_Obj
        {
            get
            {
                if (clickSelectBtnfrmCars == null)
                {
                    clickSelectBtnfrmCars = new clickSelectBtnfrmCars_Map();
                    clickSelectBtnfrmCars.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSelectBtnfrmCars;
            }
        }
        public selectChildSeatsForaCar_Map selectChildSeatsForaCar_Obj
        {
            get
            {
                if (selectChildSeatsForaCar == null)
                {
                    selectChildSeatsForaCar = new selectChildSeatsForaCar_Map();
                    selectChildSeatsForaCar.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectChildSeatsForaCar;
            }
        }
        public clickSaveCarfrmQtypopup_Map clickSaveCarfrmQtypopup_Obj
        {
            get
            {
                if (clickSaveCarfrmQtypopup == null)
                {
                    clickSaveCarfrmQtypopup = new clickSaveCarfrmQtypopup_Map();
                    clickSaveCarfrmQtypopup.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSaveCarfrmQtypopup;
            }
        }
        public clickDoneBtnfrmCarsPopup_Map clickDoneBtnfrmCarsPopup_Obj
        {
            get
            {
                if (clickDoneBtnfrmCarsPopup == null)
                {
                    clickDoneBtnfrmCarsPopup = new clickDoneBtnfrmCarsPopup_Map();
                    clickDoneBtnfrmCarsPopup.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickDoneBtnfrmCarsPopup;
            }
        }
        public clickAmendBtnFrmCars_Map clickAmendBtnFrmCars_Obj
        {
            get
            {
                if (clickAmendBtnFrmCars == null)
                {
                    clickAmendBtnFrmCars = new clickAmendBtnFrmCars_Map();
                    clickAmendBtnFrmCars.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAmendBtnFrmCars;
            }
        }
        public clickDeleteBtnForCar_Map clickDeleteBtnForCar_Obj
        {
            get
            {
                if (clickDeleteBtnForCar == null)
                {
                    clickDeleteBtnForCar = new clickDeleteBtnForCar_Map();
                    clickDeleteBtnForCar.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickDeleteBtnForCar;
            }
        }
        public clickAddAnotherCarBtn_Map clickAddAnotherCarBtn_Obj
        {
            get
            {
                if (clickAddAnotherCarBtn == null)
                {
                    clickAddAnotherCarBtn = new clickAddAnotherCarBtn_Map();
                    clickAddAnotherCarBtn.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAddAnotherCarBtn;
            }
        }
                        
        //***Add/Amend Villa Extras Popup***//
        public clickAddAmendVillaExtrasBtn_Map clickAddAmendVillaExtrasBtn_Obj
        {
            get
            {
                if (clickAddAmendVillaExtrasBtn == null)
                {
                    clickAddAmendVillaExtrasBtn = new clickAddAmendVillaExtrasBtn_Map();
                    clickAddAmendVillaExtrasBtn.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAddAmendVillaExtrasBtn;
            }
        }
        public verifyAddAmendVillaExtraspopupDisplay_Map verifyAddAmendVillaExtraspopupDisplay_Obj
        {
            get
            {
                if (verifyAddAmendVillaExtraspopupDisplay == null)
                {
                    verifyAddAmendVillaExtraspopupDisplay = new verifyAddAmendVillaExtraspopupDisplay_Map();
                    verifyAddAmendVillaExtraspopupDisplay.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAddAmendVillaExtraspopupDisplay;
            }
        }
        public verifyNumofVExtrasDisplayedinPopup_Map verifyNumofVExtrasDisplayedinPopup_Obj
        {
            get
            {
                if (verifyNumofVExtrasDisplayedinPopup == null)
                {
                    verifyNumofVExtrasDisplayedinPopup = new verifyNumofVExtrasDisplayedinPopup_Map();
                    verifyNumofVExtrasDisplayedinPopup.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyNumofVExtrasDisplayedinPopup;
            }
        }
        public selectVExtrasFrmList_Map selectVExtrasFrmList_Obj
        {
            get
            {
                if (selectVExtrasFrmList == null)
                {
                    selectVExtrasFrmList = new selectVExtrasFrmList_Map();
                    selectVExtrasFrmList.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectVExtrasFrmList;
            }
        }
        public selectVExtrasfrmChkBox_Map selectVExtrasfrmChkBox_Obj
        {
            get
            {
                if (selectVExtrasfrmChkBox == null)
                {
                    selectVExtrasfrmChkBox = new selectVExtrasfrmChkBox_Map();
                    selectVExtrasfrmChkBox.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectVExtrasfrmChkBox;
            }
        }
        public clickSaveVillaExtrasBtn_Map clickSaveVillaExtrasBtn_Obj
        {
            get
            {
                if (clickSaveVillaExtrasBtn == null)
                {
                    clickSaveVillaExtrasBtn = new clickSaveVillaExtrasBtn_Map();
                    clickSaveVillaExtrasBtn.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSaveVillaExtrasBtn;
            }
        }
        public verifyselectedVExtrasSavedOnHSPage_Map verifyselectedVExtrasSavedOnHSPage_Obj
        {
            get
            {
                if (verifyselectedVExtrasSavedOnHSPage == null)
                {
                    verifyselectedVExtrasSavedOnHSPage = new verifyselectedVExtrasSavedOnHSPage_Map();
                    verifyselectedVExtrasSavedOnHSPage.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyselectedVExtrasSavedOnHSPage;
            }
        }
        
        //***Add/Amend Flight Extras Popup***//
        public verifyAddAmendFltExtrasBtnEnabled_Map verifyAddAmendFltExtrasBtnEnabled_Obj
        {
            get
            {
                if (verifyAddAmendFltExtrasBtnEnabled == null)
                {
                    verifyAddAmendFltExtrasBtnEnabled = new verifyAddAmendFltExtrasBtnEnabled_Map();
                    verifyAddAmendFltExtrasBtnEnabled.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAddAmendFltExtrasBtnEnabled;
            }
        }
        public clickAddAmendFlightExtras_Map clickAddAmendFlightExtras_Obj
        {
            get
            {
                if (clickAddAmendFlightExtras == null)
                {
                    clickAddAmendFlightExtras = new clickAddAmendFlightExtras_Map();
                    clickAddAmendFlightExtras.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAddAmendFlightExtras;
            }
        }
        public verifyAddAmendFlightExtraspopupOpened_Map verifyAddAmendFlightExtraspopupOpened_Obj
        {
            get
            {
                if (verifyAddAmendFlightExtraspopupOpened == null)
                {
                    verifyAddAmendFlightExtraspopupOpened = new verifyAddAmendFlightExtraspopupOpened_Map();
                    verifyAddAmendFlightExtraspopupOpened.UIYourHolidaySummaryInWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAddAmendFlightExtraspopupOpened;
            }
        }
        public verifyFlight1tabinFExtrasPopup_Map verifyFlight1tabinFExtrasPopup_Obj
        {
            get
            {
                if (verifyFlight1tabinFExtrasPopup == null)
                {
                    verifyFlight1tabinFExtrasPopup = new verifyFlight1tabinFExtrasPopup_Map();
                    verifyFlight1tabinFExtrasPopup.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyFlight1tabinFExtrasPopup;
            }
        }
        public verifyNumofFExtrasDisplayedinPopup_Map verifyNumofFExtrasDisplayedinPopup_Obj
        {
            get
            {
                if (verifyNumofFExtrasDisplayedinPopup == null)
                {
                    verifyNumofFExtrasDisplayedinPopup = new verifyNumofFExtrasDisplayedinPopup_Map();
                    verifyNumofFExtrasDisplayedinPopup.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyNumofFExtrasDisplayedinPopup;
            }
        }
        public selectFExtrasFrmCHKbox_Map selectFExtrasFrmCHKbox_Obj
        {
            get
            {
                if (selectFExtrasFrmCHKbox == null)
                {
                    selectFExtrasFrmCHKbox = new selectFExtrasFrmCHKbox_Map();
                    selectFExtrasFrmCHKbox.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectFExtrasFrmCHKbox;
            }
        }
        public selectFExtrasFrmList_Map selectFExtrasFrmList_Obj
        {
            get
            {
                if (selectFExtrasFrmList == null)
                {
                    selectFExtrasFrmList = new selectFExtrasFrmList_Map();
                    selectFExtrasFrmList.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectFExtrasFrmList;
            }
        }
        public clickDoneBtnFrmFExtraspopup_Map clickDoneBtnFrmFExtraspopup_Obj
        {
            get
            {
                if (clickDoneBtnFrmFExtraspopup == null)
                {
                    clickDoneBtnFrmFExtraspopup = new clickDoneBtnFrmFExtraspopup_Map();
                    clickDoneBtnFrmFExtraspopup.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickDoneBtnFrmFExtraspopup;
            }
        }
        public verifyErrPopupDisplayedforFextras_Map verifyErrPopupDisplayedforFextras_Obj
        {
            get
            {
                if (verifyErrPopupDisplayedforFextras == null)
                {
                    verifyErrPopupDisplayedforFextras = new verifyErrPopupDisplayedforFextras_Map();
                    verifyErrPopupDisplayedforFextras.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyErrPopupDisplayedforFextras;
            }
        }
        public clickOKFrmErrPopup_Map clickOKFrmErrPopup_Obj
        {
            get
            {
                if (clickOKFrmErrPopup == null)
                {
                    clickOKFrmErrPopup = new clickOKFrmErrPopup_Map();
                    clickOKFrmErrPopup.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickOKFrmErrPopup;
            }
        }
        public clickSaveFlightExtrasBtn_Map clickSaveFlightExtrasBtn_Obj
        {
            get
            {
                if (clickSaveFlightExtrasBtn == null)
                {
                    clickSaveFlightExtrasBtn = new clickSaveFlightExtrasBtn_Map();
                    clickSaveFlightExtrasBtn.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSaveFlightExtrasBtn;
            }
        }
               
        //***Add/Amend Flights Popup***//
        public clickAddAmendFlights_Map clickAddAmendFlights_Obj
        {
            get
            {
                if (clickAddAmendFlights == null)
                {
                    clickAddAmendFlights = new clickAddAmendFlights_Map();
                    clickAddAmendFlights.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickAddAmendFlights;
            }
        }
        public verifyAddAmendFltpopupOpened_Map verifyAddAmendFltpopupOpened_obj
        {
            get
            {
                if (verifyAddAmendFltpopupOpened == null)
                {
                    verifyAddAmendFltpopupOpened = new verifyAddAmendFltpopupOpened_Map();
                    verifyAddAmendFltpopupOpened.UIYourHolidaySummaryInWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAddAmendFltpopupOpened;
            }
        }
        public clickHideOptions_Map clickHideOptions_obj
        {
            get
            {
                if (clickHideOptions == null)
                {
                    clickHideOptions = new clickHideOptions_Map();
                    clickHideOptions.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickHideOptions;
            }
        }
        public clickViewFlightOptions_Map clickViewFlightOptions_obj
        {
            get
            {
                if (clickViewFlightOptions == null)
                {
                    clickViewFlightOptions = new clickViewFlightOptions_Map();
                    clickViewFlightOptions.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickViewFlightOptions;
            }
        }
        public verifyNotesTextDisplay_Map verifyNotesTextDisplay_obj
        {
            get
            {
                if (verifyNotesTextDisplay == null)
                {
                    verifyNotesTextDisplay = new verifyNotesTextDisplay_Map();
                    verifyNotesTextDisplay.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyNotesTextDisplay;
            }
        }
        public verifyAlternativeFlightsPanedisplay_Map verifyAlternativeFlightsPanedisplay_obj
        {
            get
            {
                if (verifyAlternativeFlightsPanedisplay == null)
                {
                    verifyAlternativeFlightsPanedisplay = new verifyAlternativeFlightsPanedisplay_Map();
                    verifyAlternativeFlightsPanedisplay.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAlternativeFlightsPanedisplay;
            }
        }
        public clickSelectBtnforOtherflight_Map clickSelectBtnforOtherflight_Obj
        {
            get
            {
                if (clickSelectBtnforOtherflight == null)
                {
                    clickSelectBtnforOtherflight = new clickSelectBtnforOtherflight_Map();
                    clickSelectBtnforOtherflight.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSelectBtnforOtherflight;
            }
        }
        public clickChangeFlightLink_Map clickChangeFlightLink_obj
        {
            get
            {
                if (clickChangeFlightLink == null)
                {
                    clickChangeFlightLink = new clickChangeFlightLink_Map();
                    clickChangeFlightLink.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickChangeFlightLink;
            }
        }
        public verifyGetFlightsBtnDisplayed_Map verifyGetFlightsBtnDisplayed_obj
        {
            get
            {
                if (verifyGetFlightsBtnDisplayed == null)
                {
                    verifyGetFlightsBtnDisplayed = new verifyGetFlightsBtnDisplayed_Map();
                    verifyGetFlightsBtnDisplayed.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyGetFlightsBtnDisplayed;
            }
        }
        public verifyAirportListEnabled_Map verifyAirportListEnabled_obj
        {
            get
            {
                if (verifyAirportListEnabled == null)
                {
                    verifyAirportListEnabled = new verifyAirportListEnabled_Map();
                    verifyAirportListEnabled.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAirportListEnabled;
            }
        }
        public selectAirportForFlight1_Map selectAirportForFlight1_obj
        {
            get
            {
                if (selectAirportForFlight1 == null)
                {
                    selectAirportForFlight1 = new selectAirportForFlight1_Map();
                    selectAirportForFlight1.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectAirportForFlight1;
            }
        }
        public clickGetFlightsBtn_Map clickGetFlightsBtn_obj
        {
            get
            {
                if (clickGetFlightsBtn == null)
                {
                    clickGetFlightsBtn = new clickGetFlightsBtn_Map();
                    clickGetFlightsBtn.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickGetFlightsBtn;
            }
        }
        public verifyNoFlightsErrMsgDisplay_Map verifyNoFlightsErrMsgDisplay_obj
        {
            get
            {
                if (verifyNoFlightsErrMsgDisplay == null)
                {
                    verifyNoFlightsErrMsgDisplay = new verifyNoFlightsErrMsgDisplay_Map();
                    verifyNoFlightsErrMsgDisplay.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyNoFlightsErrMsgDisplay;
            }
        }
        public clickDoneBtnFrmFlights_Map clickDoneBtnFrmFlights_obj
        {
            get
            {
                if (clickDoneBtnFrmFlights == null)
                {
                    clickDoneBtnFrmFlights = new clickDoneBtnFrmFlights_Map();
                    clickDoneBtnFrmFlights.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickDoneBtnFrmFlights;
            }
        }

        //***HS PK Page***//
        public verifyCheckInBagsPopupOpened_Map verifyCheckInBagsPopupOpened_Obj
        {
            get
            {
                if (verifyCheckInBagsPopupOpened == null)
                {
                    verifyCheckInBagsPopupOpened = new verifyCheckInBagsPopupOpened_Map();
                    verifyCheckInBagsPopupOpened.UIYourHolidaySummaryInWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyCheckInBagsPopupOpened;
            }
        }
        public clickYesFrmCheckInBags_Map clickYesFrmCheckInBags_Obj
        {
            get
            {
                if (clickYesFrmCheckInBags == null)
                {
                    clickYesFrmCheckInBags = new clickYesFrmCheckInBags_Map();
                    clickYesFrmCheckInBags.UIYourHolidaySummaryInWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickYesFrmCheckInBags;
            }
        }
        public clickBookVillaPKonPopup_Map clickBookVillaPKonPopup_Obj
        {
            get
            {
                if (clickBookVillaPKonPopup == null)
                {
                    clickBookVillaPKonPopup = new clickBookVillaPKonPopup_Map();
                    clickBookVillaPKonPopup.UIFloresSolInNerjaCostWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBookVillaPKonPopup;
            }
        }
        public clickBookVillaVOonPopup_Map clickBookVillaVOonPopup_Obj
        {
            get
            {
                if (clickBookVillaVOonPopup == null)
                {
                    clickBookVillaVOonPopup = new clickBookVillaVOonPopup_Map();
                    clickBookVillaVOonPopup.UIVillaBrisasMarInCorrWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBookVillaVOonPopup;
            }
        }
        public verifyHSPKOpened_Map verifyHSPKOpened_Obj
        {
            get
            {
                if (verifyHSPKOpened == null)
                {
                    verifyHSPKOpened = new verifyHSPKOpened_Map();
                    verifyHSPKOpened.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyHSPKOpened;
            }
        }
        public verifyPreSelctedFlights_Map verifyPreSelctedFlights_Obj
        {
            get
            {
                if (verifyPreSelctedFlights == null)
                {
                    verifyPreSelctedFlights = new verifyPreSelctedFlights_Map();
                    verifyPreSelctedFlights.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyPreSelctedFlights;
            }
        }
        public verifyVODetails_Map verifyVODetails_Obj
        {
            get
            {
                if (verifyVODetails == null)
                {
                    verifyVODetails = new verifyVODetails_Map();
                    verifyVODetails.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyVODetails;
            }
        }
        public verifyVOPrice_Map verifyVOPrice_Obj
        {
            get
            {
                if (verifyVOPrice == null)
                {
                    verifyVOPrice = new verifyVOPrice_Map();
                    verifyVOPrice.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyVOPrice;
            }
        }
        public verifyFExtraDfltTxt_Map verifyFExtraDfltTxt_Obj
        {
            get
            {
                if (verifyFExtraDfltTxt == null)
                {
                    verifyFExtraDfltTxt = new verifyFExtraDfltTxt_Map();
                    verifyFExtraDfltTxt.UIYourHolidaySummaryInWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyFExtraDfltTxt;
            }
        }
        public verifyVExtraDfltTxt_Map verifyVExtraDfltTxt_Obj
        {
            get
            {
                if (verifyVExtraDfltTxt == null)
                {
                    verifyVExtraDfltTxt = new verifyVExtraDfltTxt_Map();
                    verifyVExtraDfltTxt.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyVExtraDfltTxt;
            }
        }
        public verifyCarDefaultText_Map verifyCarDefaultText_Obj
        {
            get
            {
                if (verifyCarDefaultText == null)
                {
                    verifyCarDefaultText = new verifyCarDefaultText_Map();
                    verifyCarDefaultText.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyCarDefaultText;
            }
        }
        public verifyTransferDfltTxt_Map verifyTransferDfltTxt_obj
        {
            get
            {
                if (verifyTransferDfltTxt == null)
                {
                    verifyTransferDfltTxt = new verifyTransferDfltTxt_Map();
                    verifyTransferDfltTxt.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyTransferDfltTxt;
            }
        }
        public verifyInsuranceDfltTxt_Map verifyInsuranceDfltTxt_obj
        {
            get
            {
                if (verifyInsuranceDfltTxt == null)
                {
                    verifyInsuranceDfltTxt = new verifyInsuranceDfltTxt_Map();
                    verifyInsuranceDfltTxt.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyInsuranceDfltTxt;
            }
        }
        public verifyADWDfltTxt_Map verifyADWDfltTxt_Obj
        {
            get
            {
                if (verifyADWDfltTxt == null)
                {
                    verifyADWDfltTxt = new verifyADWDfltTxt_Map();
                    verifyADWDfltTxt.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyADWDfltTxt;
            }
        }
        public verifyATOLDfltTxt_Map verifyATOLDfltTxt_obj
        {
            get
            {
                if (verifyATOLDfltTxt == null)
                {
                    verifyATOLDfltTxt = new verifyATOLDfltTxt_Map();
                    verifyATOLDfltTxt.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyATOLDfltTxt;
            }
        }
        public verifyTotalHolCost_Map verifyTotalHolCost_Obj
        {
            get
            {
                if (verifyTotalHolCost == null)
                {
                    verifyTotalHolCost = new verifyTotalHolCost_Map();
                    verifyTotalHolCost.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyTotalHolCost;
            }
        }
        public getIndividualTotalCosts_Map getIndividualTotalCosts_Obj
        {
            get
            {
                if (getIndividualTotalCosts == null)
                {
                    getIndividualTotalCosts = new getIndividualTotalCosts_Map();
                    getIndividualTotalCosts.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return getIndividualTotalCosts;
            }
        }
        public verifyDepositDetails_Map verifyDepositDetails_Obj
        {
            get
            {
                if (verifyDepositDetails == null)
                {
                    verifyDepositDetails = new verifyDepositDetails_Map();
                    verifyDepositDetails.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyDepositDetails;
            }
        }
        public verifyDfltTxtfrmIncludeFlts_Map verifyDfltTxtfrmIncludeFlts_Obj
        {
            get
            {
                if (verifyDfltTxtfrmIncludeFlts == null)
                {
                    verifyDfltTxtfrmIncludeFlts = new verifyDfltTxtfrmIncludeFlts_Map();
                    verifyDfltTxtfrmIncludeFlts.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyDfltTxtfrmIncludeFlts;
            }
        }
        public clickIncludeFlightsBtn_Map clickIncludeFlightsBtn_Obj
        {
            get
            {
                if (clickIncludeFlightsBtn == null)
                {
                    clickIncludeFlightsBtn = new clickIncludeFlightsBtn_Map();
                    clickIncludeFlightsBtn.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickIncludeFlightsBtn;
            }
        }
        public verifyAirportBoxOpened_Map verifyAirportBoxOpened_Obj
        {
            get
            {
                if (verifyAirportBoxOpened == null)
                {
                    verifyAirportBoxOpened = new verifyAirportBoxOpened_Map();
                    verifyAirportBoxOpened.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAirportBoxOpened;
            }
        }
        public selectAirporttoIncludeFlights_Map selectAirporttoIncludeFlights_Obj
        {
            get
            {
                if (selectAirporttoIncludeFlights == null)
                {
                    selectAirporttoIncludeFlights = new selectAirporttoIncludeFlights_Map();
                    selectAirporttoIncludeFlights.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectAirporttoIncludeFlights;
            }
        }
        public clickGOfrmIncludeFlights_Map clickGOfrmIncludeFlights_Obj
        {
            get
            {
                if (clickGOfrmIncludeFlights == null)
                {
                    clickGOfrmIncludeFlights = new clickGOfrmIncludeFlights_Map();
                    clickGOfrmIncludeFlights.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickGOfrmIncludeFlights;
            }
        }
        public verifyHSPagecontent_Map verifyHSPagecontent_Obj
        {
            get
            {
                if (verifyHSPagecontent == null)
                {
                    verifyHSPagecontent = new verifyHSPagecontent_Map();
                    verifyHSPagecontent.UIYourHolidaySummaryWiWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyHSPagecontent;
            }
        }

        //***Product Page Related***//
        public clickCheckAvaiandPricesBtn_Map clickCheckAvaiandPricesBtn_Obj
        {
            get
            {
                if (clickCheckAvaiandPricesBtn == null)
                {
                    clickCheckAvaiandPricesBtn = new clickCheckAvaiandPricesBtn_Map();
                    //clickCheckAvaiandPricesBtn.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickCheckAvaiandPricesBtn;
            }
        }
        public selectActTabDepartsOn_Map selectActTabDepartsOn_Obj
        {
            get
            {
                if (selectActTabDepartsOn == null)
                {
                    selectActTabDepartsOn = new selectActTabDepartsOn_Map();
                    selectActTabDepartsOn.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectActTabDepartsOn;
            }
        }
        public selectActTabDate_Map selectActTabDate_Obj
        {
            get
            {
                if (selectActTabDate == null)
                {
                    selectActTabDate = new selectActTabDate_Map();
                    selectActTabDate.UICanas1bdrmEQuintadoLWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectActTabDate;
            }
        }
        public selectActTabAirtport_Map selectActTabAirtport_Obj
        {
            get
            {
                if (selectActTabAirtport == null)
                {
                    selectActTabAirtport = new selectActTabAirtport_Map();
                    selectActTabAirtport.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectActTabAirtport;
            }
        }
        public clickActTabBookVillaBtn_Map clickActTabBookVillaBtn_Obj
        {
            get
            {
                if (clickActTabBookVillaBtn == null)
                {
                    clickActTabBookVillaBtn = new clickActTabBookVillaBtn_Map();
                    clickActTabBookVillaBtn.UICanas1bdrmEQuintadoLWindow.CopyFrom(OpenBrowser_Obj.UIBlankPageWindowsInteWindow);
                }
                return clickActTabBookVillaBtn;
            }
        }
        public setIE9StandardsInDeveloperTools_Map setIE9StandardsInDeveloperTools_Obj
        {
            get
            {
                if (setIE9StandardsInDeveloperTools == null)
                {
                    setIE9StandardsInDeveloperTools = new setIE9StandardsInDeveloperTools_Map();
                    setIE9StandardsInDeveloperTools.UIBlankPageWindowsInteWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return setIE9StandardsInDeveloperTools;
            }
        }
        public verifyVeryVillaPlus_Map verifyVeryVillaPlus_Obj
        {
            get
            {
                if (verifyVeryVillaPlus == null)
                {
                    verifyVeryVillaPlus = new verifyVeryVillaPlus_Map();
                    verifyVeryVillaPlus.UIVillaFilipaGuiaAlgarWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyVeryVillaPlus;
            }
        }
        public selectAdult_Map selectAdult_Obj
        {
            get
            {
                if (selectAdult == null)
                {
                    selectAdult = new selectAdult_Map();
                    selectAdult.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectAdult;
            }
        }
        public selectChild_Map selectChild_Obj
        {
            get
            {
                if (selectChild == null)
                {
                    selectChild = new selectChild_Map();
                    selectChild.UIVillaPoppyPolisCypruWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectChild;
            }
        }
        public selectInfant_Map selectInfant_Obj
        {
            get
            {
                if (selectInfant == null)
                {
                    selectInfant = new selectInfant_Map();
                    selectInfant.UIVillaFloresSalvajeInWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectInfant;
            }
        }
        public verifyMaxOccupancyonPopUp_Map verifyMaxOccupancyonPopUp_Obj
        {
            get
            {
                if (verifyMaxOccupancyonPopUp == null)
                {
                    verifyMaxOccupancyonPopUp = new verifyMaxOccupancyonPopUp_Map();
                    verifyMaxOccupancyonPopUp.UISaraInCalanPorterMenWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyMaxOccupancyonPopUp;
            }
        }
        public verifyZeroAdultMessage_Map verifyZeroAdultMessage_obj
        {
            get
            {
                if (verifyZeroAdultMessage == null)
                {
                    verifyZeroAdultMessage = new verifyZeroAdultMessage_Map();
                    verifyZeroAdultMessage.UIVillaDamascoInPraiadWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyZeroAdultMessage;
            }
        }
        public clickOKonMaxOccupancyPopUp_Map clickOKonMaxOccupancyPopUp_obj
        {
            get
            {
                if (clickOKonMaxOccupancyPopUp == null)
                {
                    clickOKonMaxOccupancyPopUp = new clickOKonMaxOccupancyPopUp_Map();
                    clickOKonMaxOccupancyPopUp.UISaraInCalanPorterMenWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickOKonMaxOccupancyPopUp;
            }
        }
        public clickVillaNFlightsBtnFrmProductPage_Map clickVillaNFlightsBtnFrmProductPage_Obj
        {
            get
            {
                if (clickVillaNFlightsBtnFrmProductPage == null)
                {
                    clickVillaNFlightsBtnFrmProductPage = new clickVillaNFlightsBtnFrmProductPage_Map();
                    clickVillaNFlightsBtnFrmProductPage.UIVillaBrisasMarInCorrWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickVillaNFlightsBtnFrmProductPage;
            }
        }
        public clickBookVillaOnlyBtnFrmProductPage_Map clickBookVillaOnlyBtnFrmProductPage_Obj
        {
            get
            {
                if (clickBookVillaOnlyBtnFrmProductPage == null)
                {
                    clickBookVillaOnlyBtnFrmProductPage = new clickBookVillaOnlyBtnFrmProductPage_Map();
                    clickBookVillaOnlyBtnFrmProductPage.UIVillaIfaraInCostaAdeWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBookVillaOnlyBtnFrmProductPage;
            }
        }
        public verifyanydateselectable_Map verifyanydateselectable_Obj
        {
            get
            {
                if (verifyanydateselectable == null)
                {
                    verifyanydateselectable = new verifyanydateselectable_Map();
                    verifyanydateselectable.UIVillaQuintaDoValeDaTWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyanydateselectable;
            }
        }
        public selectDateFrmProductPage_Map selectDateFrmProductPage_Obj
        {
            get
            {
                if (selectDateFrmProductPage == null)
                {
                    selectDateFrmProductPage = new selectDateFrmProductPage_Map();
                    selectDateFrmProductPage.UIVillaLArestaInPollenWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectDateFrmProductPage;
            }
        }

        //***Search Tile Related***//
        public verifyIncompleteBookingpopupDisplay_Map verifyIncompleteBookingpopupDisplay_Obj
        {
            get
            {
                if (verifyIncompleteBookingpopupDisplay == null)
                {
                    verifyIncompleteBookingpopupDisplay = new verifyIncompleteBookingpopupDisplay_Map();
                    verifyIncompleteBookingpopupDisplay.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyIncompleteBookingpopupDisplay;
            }
        }
        public verifyChatWndwDisplay_Map verifyChatWndwDisplay_Obj
        {
            get
            {
                if (verifyChatWndwDisplay == null)
                {
                    verifyChatWndwDisplay = new verifyChatWndwDisplay_Map();
                    verifyChatWndwDisplay.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyChatWndwDisplay;
            }
        }
        public clickNOBtnFrmIncompletePopup_Map clickNOBtnFrmIncompletePopup_Obj
        {
            get
            {
                if (clickNOBtnFrmIncompletePopup == null)
                {
                    clickNOBtnFrmIncompletePopup = new clickNOBtnFrmIncompletePopup_Map();
                    clickNOBtnFrmIncompletePopup.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickNOBtnFrmIncompletePopup;
            }
        }
        public verifyDestinationListBox_Map verifyDestinationListBox_Obj
        {
            get
            {
                if (verifyDestinationListBox == null)
                {
                    verifyDestinationListBox = new verifyDestinationListBox_Map();
                    verifyDestinationListBox.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyDestinationListBox;
            }
        }
        public verifyDurationListBox_Map verifyDurationListBox_Obj
        {
            get
            {
                if (verifyDurationListBox == null)
                {
                    verifyDurationListBox = new verifyDurationListBox_Map();
                    verifyDurationListBox.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyDurationListBox;
            }
        }
        public verifyAdultListBox_Map verifyAdultListBox_Obj
        {
            get
            {
                if (verifyAdultListBox == null)
                {
                    verifyAdultListBox = new verifyAdultListBox_Map();
                    verifyAdultListBox.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAdultListBox;
            }
        }
        public verifyChildListBox_Map verifyChildListBox_Obj
        {
            get
            {
                if (verifyChildListBox == null)
                {
                    verifyChildListBox = new verifyChildListBox_Map();
                    verifyChildListBox.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyChildListBox;
            }
        }
        public verifyInfantListbox_Map verifyInfantListbox_Obj
        {
            get
            {
                if (verifyInfantListbox == null)
                {
                    verifyInfantListbox = new verifyInfantListbox_Map();
                    verifyInfantListbox.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyInfantListbox;
            }
        }
        public verifyAirportListBox_Map verifyAirportListBox_Obj
        {
            get
            {
                if (verifyAirportListBox == null)
                {
                    verifyAirportListBox = new verifyAirportListBox_Map();
                    verifyAirportListBox.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyAirportListBox;
            }
        }
        public clickCalenderIcon_Map clickCalenderIcon_Obj
        {
            get
            {
                if (clickCalenderIcon == null)
                {
                    clickCalenderIcon = new clickCalenderIcon_Map();
                    clickCalenderIcon.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickCalenderIcon;
            }
        }
        public verifyCalenderDisplay_Map verifyCalenderDisplay_Obj
        {
            get
            {
                if (verifyCalenderDisplay == null)
                {
                    verifyCalenderDisplay = new verifyCalenderDisplay_Map();
                    verifyCalenderDisplay.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyCalenderDisplay;
            }
        }
        public selectMonthFrmCalender_Map selectMonthFrmCalender_Obj
        {
            get
            {
                if (selectMonthFrmCalender == null)
                {
                    selectMonthFrmCalender = new selectMonthFrmCalender_Map();
                    selectMonthFrmCalender.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectMonthFrmCalender;
            }
        }
        public selectaDateFrmCalender_Map selectaDateFrmCalender_Obj
        {
            get
            {
                if (selectaDateFrmCalender == null)
                {
                    selectaDateFrmCalender = new selectaDateFrmCalender_Map();
                    selectaDateFrmCalender.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectaDateFrmCalender;
            }
        }
        public clickSearchBtn_Map clickSearchBtn_Obj
        {
            get
            {
                if (clickSearchBtn == null)
                {
                    clickSearchBtn = new clickSearchBtn_Map();
                    clickSearchBtn.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickSearchBtn;
            }
        }
        public verifyIncorrectInputPopupDisplayed_Map verifyIncorrectInputPopupDisplayed_Obj
        {
            get
            {
                if (verifyIncorrectInputPopupDisplayed == null)
                {
                    verifyIncorrectInputPopupDisplayed = new verifyIncorrectInputPopupDisplayed_Map();
                    verifyIncorrectInputPopupDisplayed.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyIncorrectInputPopupDisplayed;
            }
        }
        public clickOKFrmIncorrectPopup_Map clickOKFrmIncorrectPopup_Obj
        {
            get
            {
                if (clickOKFrmIncorrectPopup == null)
                {
                    clickOKFrmIncorrectPopup = new clickOKFrmIncorrectPopup_Map();
                    clickOKFrmIncorrectPopup.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickOKFrmIncorrectPopup;
            }
        }
        public clickVillaNameTabfromSearchTile_Map clickVillaNameTabfromSearchTile_Obj
        {
            get
            {
                if (clickVillaNameTabfromSearchTile == null)
                {
                    clickVillaNameTabfromSearchTile = new clickVillaNameTabfromSearchTile_Map();
                    clickVillaNameTabfromSearchTile.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickVillaNameTabfromSearchTile;
            }
        }
        public enterAnyCharInVillaNameTxtBox_Map enterAnyCharInVillaNameTxtBox_Obj
        {
            get
            {
                if (enterAnyCharInVillaNameTxtBox == null)
                {
                    enterAnyCharInVillaNameTxtBox = new enterAnyCharInVillaNameTxtBox_Map();
                    enterAnyCharInVillaNameTxtBox.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return enterAnyCharInVillaNameTxtBox;
            }
        }
        public selectaVillaFromList_Map selectaVillaFromList_Obj
        {
            get
            {
                if (selectaVillaFromList == null)
                {
                    selectaVillaFromList = new selectaVillaFromList_Map();
                    selectaVillaFromList.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return selectaVillaFromList;
            }
        }
        public clickViewVillaFrmSearchTile_Map clickViewVillaFrmSearchTile_Obj
        {
            get
            {
                if (clickViewVillaFrmSearchTile == null)
                {
                    clickViewVillaFrmSearchTile = new clickViewVillaFrmSearchTile_Map();
                    clickViewVillaFrmSearchTile.UIVillaHolidaysThatYouWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickViewVillaFrmSearchTile;
            }
        }
        public clickViewVillaBtnFrmSearchResultsPage_Map clickViewVillaBtnFrmSearchResultsPage_Obj
        {
            get
            {
                if (clickViewVillaBtnFrmSearchResultsPage == null)
                {
                    clickViewVillaBtnFrmSearchResultsPage = new clickViewVillaBtnFrmSearchResultsPage_Map();
                    clickViewVillaBtnFrmSearchResultsPage.UIYoursearchfound23VilWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickViewVillaBtnFrmSearchResultsPage;
            }
        }
        public verifyProductPageOpened_Map verifyProductPageOpened_Obj
        {
            get
            {
                if (verifyProductPageOpened == null)
                {
                    verifyProductPageOpened = new verifyProductPageOpened_Map();
                    verifyProductPageOpened.UIVillaCoelhoInPraiadaWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyProductPageOpened;
            }
        }
        public verifySearchResultsPageOpened_Map verifySearchResultsPageOpened_Obj
        {
            get
            {
                if (verifySearchResultsPageOpened == null)
                {
                    verifySearchResultsPageOpened = new verifySearchResultsPageOpened_Map();
                    verifySearchResultsPageOpened.UIYoursearchfound60VilWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifySearchResultsPageOpened;
            }
        }
        public verifyNoVillasMsgDisplayed_Map verifyNoVillasMsgDisplayed_Obj
        {
            get
            {
                if (verifyNoVillasMsgDisplayed == null)
                {
                    verifyNoVillasMsgDisplayed = new verifyNoVillasMsgDisplayed_Map();
                    verifyNoVillasMsgDisplayed.UIYoursearchfound0VillWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return verifyNoVillasMsgDisplayed;
            }
        }
        public clickVillaNFlightsLinkFrmSearchResultsPage_Map clickVillaNFlightsLinkFrmSearchResultsPage_Obj
        {
            get
            {
                if (clickVillaNFlightsLinkFrmSearchResultsPage == null)
                {
                    clickVillaNFlightsLinkFrmSearchResultsPage = new clickVillaNFlightsLinkFrmSearchResultsPage_Map();
                    clickVillaNFlightsLinkFrmSearchResultsPage.UIYoursearchfound2VillWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickVillaNFlightsLinkFrmSearchResultsPage;
            }
        }
        public clickBookVillaFlightLink_Map clickBookVillaFlightLink_Obj
        {
            get
            {
                if (clickBookVillaFlightLink == null)
                {
                    clickBookVillaFlightLink = new clickBookVillaFlightLink_Map();
                    clickBookVillaFlightLink.UIYoursearchfound39VilWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBookVillaFlightLink;
            }
        }
        public clickBookVillaOnlyLINKFrmSRPage_Map clickBookVillaOnlyLINKFrmSRPage_Obj
        {
            get
            {
                if (clickBookVillaOnlyLINKFrmSRPage == null)
                {
                    clickBookVillaOnlyLINKFrmSRPage = new clickBookVillaOnlyLINKFrmSRPage_Map();
                    clickBookVillaOnlyLINKFrmSRPage.UIYoursearchfound31VilWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBookVillaOnlyLINKFrmSRPage;
            }
        }
        public clickBookVillaOnlyBTNFrmSRPage_Map clickBookVillaOnlyBTNFrmSRPage_Obj
        {
            get
            {
                if (clickBookVillaOnlyBTNFrmSRPage == null)
                {
                    clickBookVillaOnlyBTNFrmSRPage = new clickBookVillaOnlyBTNFrmSRPage_Map();
                    clickBookVillaOnlyBTNFrmSRPage.UIYoursearchfound43VilWindow.CopyFrom(openBrowser.UIBlankPageWindowsInteWindow);
                }
                return clickBookVillaOnlyBTNFrmSRPage;
            }
        }
        
      }
}
