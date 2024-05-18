
class CCampaign
{
	CStringLink Name; //fieldtype: String
	CStringLink ShortName; //fieldtype: String
	CStringLink StoreName; //fieldtype: String
	TBattleProductId ProductId; //fieldtype: IntSigned
	SCampaignData CampaignData //struct
	{
		CString Id; //fieldtype: String
		CStringLink Name; //fieldtype: String
		CStringLink Subtitle; //fieldtype: String
		CStringLink Description; //fieldtype: String
		CImagePath ImagePath; //fieldtype: String
		CString LaunchMap; //fieldtype: String
		CString ProgressLaunchMap; //fieldtype: String
		CString TutorialMap; //fieldtype: String
		CString SaveName; //fieldtype: String
		CString CompletedSaveName; //fieldtype: String
		CString PublishArchiveName; //fieldtype: String
		CAchievementLink ProgressAchievement; //fieldtype: CatalogLink
		SMovieConfig Movie //struct
		{
			CStringLink Name; //fieldtype: String
			CMoviePath Path; //fieldtype: String
			CIdentifier Source; //fieldtype: String
		}
		CString[] CampaignBanks; //fieldtype: String
		CString[] TransitionBanks; //fieldtype: String
		bool32 ShowArchivesButton; //fieldtype: Unknown
		CStringLink ArchiveDisabledTooltip; //fieldtype: String
		CString PrerequisiteCampaignId; //fieldtype: String
		CStringLink PrerequisitesNotMetTooltip; //fieldtype: String
		TBattleProductId PromoProduct; //fieldtype: IntSigned
		CStringLink PromoPurchaseWarningTitle; //fieldtype: String
		CStringLink PromoPurchaseWarningMessage; //fieldtype: String
		CStringLink PromoText; //fieldtype: String
		CStringLink PromoTextCN; //fieldtype: String
		CImagePath CinematicsImagePath; //fieldtype: String
		CImagePath StorySoFarImagePath; //fieldtype: String
		SMovieConfig StorySoFarMovie //struct
		{
			CStringLink Name; //fieldtype: String
			CMoviePath Path; //fieldtype: String
			CIdentifier Source; //fieldtype: String
		}
		CImagePath SubPanelImage; //fieldtype: String
		CStringLink SubPanelName; //fieldtype: String
		CStringLink UnavailableMessageNotPurchased; //fieldtype: String
		CStringLink UnavailableMessagePreReleaseOwned; //fieldtype: String
		CStringLink UnavailableMessagePreReleaseNotOwned; //fieldtype: String
		CImagePath CompletedCampaignImagePath; //fieldtype: String
		CImagePath FeaturedImagePath; //fieldtype: String
		CStringLink FeaturedDescription; //fieldtype: String
	}
	TBattleProductId[] PurchaseProductIdArray; //fieldtype: IntSigned
	CStringLink StoreTypeName; //fieldtype: String
	CImagePath ScreenshotImage1; //fieldtype: String
	CImagePath ScreenshotImage2; //fieldtype: String
	CImagePath ScreenshotImage3; //fieldtype: String
	CImagePath ScreenshotImage4; //fieldtype: String
	CImagePath ScreenshotImage5; //fieldtype: String
	CImagePath LearnMoreBackgroundImage; //fieldtype: String
	CImagePath LearnMoreImage1; //fieldtype: String
	CImagePath LearnMoreImage2; //fieldtype: String
	CImagePath LearnMoreImage3; //fieldtype: String
	CStringLink LearnMoreTitleText1; //fieldtype: String
	CStringLink LearnMoreTitleText2; //fieldtype: String
	CStringLink LearnMoreTitleText3; //fieldtype: String
	CStringLink LearnMoreBodyText1; //fieldtype: String
	CStringLink LearnMoreBodyText2; //fieldtype: String
	CStringLink LearnMoreBodyText3; //fieldtype: String
}
