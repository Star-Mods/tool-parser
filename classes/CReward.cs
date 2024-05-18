
class CReward
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
}

class CRewardDecal
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	CDecalPackLink DecalPack; //fieldtype: CatalogLink
	CTextureLink Texture; //fieldtype: CatalogLink
	CSprayLink Spray; //fieldtype: CatalogLink
}

class CRewardIcon
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
}

class CRewardModel
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	CModelLink Model; //fieldtype: CatalogLink
}

class CRewardPortrait
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	CModelLink Model; //fieldtype: CatalogLink
	CPortraitPackLink PortraitPack; //fieldtype: CatalogLink
}

class CRewardBadge
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	CTextureLink Texture; //fieldtype: CatalogLink
}

class CRewardPoints
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	uint32 Points; //fieldtype: IntUnsigned
}

class CRewardTrophy
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	CTrophyLink Trophy; //fieldtype: CatalogLink
}

class CRewardEmoticon
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	CEmoticonLink Emoticon; //fieldtype: CatalogLink
}

class CRewardVoicePack
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	CVoicePackLink VoicePack; //fieldtype: CatalogLink
	SGameReplacement[] ReplacementArray //struct
	{
		EGameCatalog Catalog; //enum
		CIdentifier From; //fieldtype: String
		CIdentifier To; //fieldtype: String
	}
}

class CRewardPortraitInGame
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	bool8 Enabled; //fieldtype: Unknown
}

class CRewardConsoleSkin
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	CConsoleSkinLink ConsoleSkin; //fieldtype: CatalogLink
}

class CRewardSpray
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	CTextureLink Texture; //fieldtype: CatalogLink
	CSprayLink Spray; //fieldtype: CatalogLink
}

class CRewardSprayUseDecal
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	bool8 Enabled; //fieldtype: Unknown
}

class CRewardRaceBanner
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	CRaceBannerPackLink RaceBannerPack; //fieldtype: CatalogLink
	CImagePath Image1v1; //fieldtype: String
	CImagePath Image2v2; //fieldtype: String
	CImagePath Image3v3; //fieldtype: String
	CImagePath Image4v4; //fieldtype: String
}

class CRewardStim
{
	SRewardCategory Category //struct
	{
		CString File; //fieldtype: String
		CFourCC Tag; //fieldtype: FourCC
	}
	CFlagArray<e_rewardFlagCount>[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink DescriptionUnearned; //fieldtype: String
	CImagePath IconFile; //fieldtype: String
	uint32 IconCols; //fieldtype: IntUnsigned
	uint32 IconRows; //fieldtype: IntUnsigned
	uint32 IconSlot; //fieldtype: IntUnsigned
	bool8 IgnorePlayerRace; //fieldtype: Unknown
	CRaceLink Race; //fieldtype: CatalogLink
	CHeroLink Hero; //fieldtype: CatalogLink
	TBattleLicenseName License; //fieldtype: String
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
	uint32 UIOrderHint; //fieldtype: IntUnsigned
	CImagePath LargeImage; //fieldtype: String
	SRewardSpecificUI[] RewardSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	CStimPackLink StimPack; //fieldtype: CatalogLink
	CTextureLink Texture; //fieldtype: CatalogLink
}
