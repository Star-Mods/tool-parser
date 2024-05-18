
class CCommander
{
	CStringLink Name; //fieldtype: String
	CStringLink ShortName; //fieldtype: String
	CFourCC AttributeId; //fieldtype: FourCC
	uint64 LevelAchievementId; //fieldtype: IntUnsigned
	CRaceLink Race; //fieldtype: CatalogLink
	CCampaignLink Campaign; //fieldtype: CatalogLink
	CStringLink Description; //fieldtype: String
	CStringLink PurchaseMessage; //fieldtype: String
	CStringLink Details; //fieldtype: String
	CImagePath Portrait; //fieldtype: String
	CImagePath HomePanelImage; //fieldtype: String
	CIdentifier CutsceneFilterSelf; //fieldtype: String
	CIdentifier CutsceneFilterAlly; //fieldtype: String
	SCommanderUnit[] UnitArray //struct
	{
		CUnitLink Unit; //fieldtype: CatalogLink
		CUnitLink Upgrade; //fieldtype: CatalogLink
	}
	SCommanderTalentTree[] TalentTreeArray //struct
	{
		CTalentLink Talent; //fieldtype: CatalogLink
		CUnitLink Unit; //fieldtype: CatalogLink
		TCommanderLevel Level; //fieldtype: IntUnsigned
		ECommanderTalentType Type; //fieldtype: Unknown
		bool8 IsHidden; //fieldtype: Unknown
	}
	SCommanderMasteryTalent[] MasteryTalentArray //struct
	{
		CTalentLink Talent; //fieldtype: CatalogLink
		real32 ValuePerRank; //fieldtype: Float
		uint32 MaxRank; //fieldtype: IntUnsigned
		ECommanderMasteryTalentType Type; //fieldtype: Unknown
		uint32 Bucket; //fieldtype: IntUnsigned
		uint32 MinValuePrecision; //fieldtype: IntUnsigned
		uint32 MaxValuePrecision; //fieldtype: IntUnsigned
	}
	uint32 MasteryMaxRank; //fieldtype: IntUnsigned
	CUserReference UserReference; //fieldtype: Unknown
	CImagePath LoadingImage; //fieldtype: String
	CImagePath LoadingImageAlly; //fieldtype: String
	CImagePath TraitIcon; //fieldtype: String
	CStringLink CommanderAbilTitle; //fieldtype: String
	SCommanderAbil[] CommanderAbilArray //struct
	{
		CAbilLink Abil; //fieldtype: CatalogLink
		CButtonLink Button; //fieldtype: CatalogLink
	}
	CMoviePath Movie; //fieldtype: String
	TBattleProductId ProductId; //fieldtype: IntSigned
	CRewardLink[] RequiredRewardArray; //fieldtype: CatalogLink
	CImagePath PurchaseImage; //fieldtype: String
	CStringLink StoreName; //fieldtype: String
	CConsoleSkinLink ConsoleSkin; //fieldtype: CatalogLink
	CImagePath FeaturedImagePath; //fieldtype: String
	CStringLink FeaturedDescription; //fieldtype: String
	CImagePath ProfileImagePath; //fieldtype: String
	CStringLink StoreTypeName; //fieldtype: String
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
	CButtonLink[] PrestigeArray; //fieldtype: CatalogLink
	CColor Color; //fieldtype: Unknown
	CRect LoadingScreenCoordinates; //fieldtype: Unknown
	CDataCollectionLink[] DataCollectionAllowed; //fieldtype: CatalogLink
	CIdentifier[] CommanderArtifactKeyArray; //fieldtype: String
	uint64 CommanderPrestigeAchievementId; //fieldtype: IntUnsigned
}
