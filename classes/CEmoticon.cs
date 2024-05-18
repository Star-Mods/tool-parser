
class CEmoticon
{
	CStringLink Name; //fieldtype: String
	CStringLink NameAlternate; //fieldtype: String
	CStringLink NameInvalid; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionLocked; //fieldtype: String
	STextureSheetEntry Image //struct
	{
		CTextureSheetLink TextureSheet; //fieldtype: CatalogLink
		uint32 Index; //fieldtype: IntUnsigned
		uint32 Count; //fieldtype: IntUnsigned
		uint32 DurationPerFrame; //fieldtype: IntUnsigned
	}
	bool8 Hidden; //fieldtype: Unknown
	CRewardLink RequiredReward; //fieldtype: CatalogLink
}

class CEmoticonPack
{
	bool8 Default; //fieldtype: Unknown
	CStringLink Name; //fieldtype: String
	CStringLink ShortName; //fieldtype: String
	CStringLink StoreName; //fieldtype: String
	CStringLink Description; //fieldtype: String
	STextureSheetEntry Image //struct
	{
		CTextureSheetLink TextureSheet; //fieldtype: CatalogLink
		uint32 Index; //fieldtype: IntUnsigned
		uint32 Count; //fieldtype: IntUnsigned
		uint32 DurationPerFrame; //fieldtype: IntUnsigned
	}
	TBattleProductId ProductId; //fieldtype: IntSigned
	SEmoticonPackCampaign RequiredCampaign //struct
	{
		CCampaignLink Campaign; //fieldtype: CatalogLink
	}
	CCommanderLink RequiredCommander; //fieldtype: CatalogLink
	CRewardLink[] RequiredRewardArray; //fieldtype: CatalogLink
	SProductReleaseDate ReleaseDate; //fieldtype: Unknown
	CEmoticonLink[] EmoticonArray; //fieldtype: CatalogLink
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	bool8 Hidden; //fieldtype: Unknown
	bool8 HideAchievement; //fieldtype: Unknown
	CStringLink StoreTypeName; //fieldtype: String
}
