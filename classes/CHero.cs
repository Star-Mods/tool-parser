
class CHero
{
	CStringLink Name; //fieldtype: String
	CStringLink StoreName; //fieldtype: String
	CFourCC AttributeId; //fieldtype: FourCC
	CFlagArray<e_heroFlagCount>[] Flags; //fieldtype: Flags
	CModelLink Model; //fieldtype: CatalogLink
	CModelLink[] DisplayModel; //fieldtype: CatalogLink
	uint32 Level; //fieldtype: IntUnsigned
	EHeroState State; //enum
	SHeroAbilCategory[] AbilCategoryArray //struct
	{
		CStringLink Name; //fieldtype: String
		CStringLink Tooltip; //fieldtype: String
		CImagePath Image; //fieldtype: String
		uint32 RequiredLevel; //fieldtype: IntUnsigned
		EHeroAbilCategoryState State; //enum
		CHeroAbilLink[] AbilArray; //fieldtype: CatalogLink
		CUserReference UserReference; //fieldtype: Unknown
	}
	CHeroStatLink[] StatArray; //fieldtype: CatalogLink
	CUserReference UserReference; //fieldtype: Unknown
	CUnitLink Unit; //fieldtype: CatalogLink
	CUnitLink[] AlternateUnitArray; //fieldtype: CatalogLink
	EHeroRole Role; //fieldtype: Unknown
	bool8 Melee; //fieldtype: Unknown
	CStringLink Description; //fieldtype: String
	CStringLink InfoText; //fieldtype: String
	CStringLink Title; //fieldtype: String
	CImagePath Portrait; //fieldtype: String
	CImagePath SelectScreenButtonImage; //fieldtype: String
	CImagePath PartyPanelButtonImage; //fieldtype: String
	CImagePath LeaderboardImage; //fieldtype: String
	CImagePath ScoreScreenImage; //fieldtype: String
	CImagePath DraftScreenLargeImage; //fieldtype: String
	CImagePath DraftScreenLargeImageBackground; //fieldtype: String
	CImagePath DraftScreenPortrait; //fieldtype: String
	CImagePath DraftScreenPortraitBackground; //fieldtype: String
	EHeroImageFacing ImageFacing; //fieldtype: Unknown
	EHeroCutsceneSize IntroCutsceneSize; //fieldtype: Unknown
	CButtonLink PassiveButton; //fieldtype: CatalogLink
	CAbilLink PassiveAbil; //fieldtype: CatalogLink
	SHeroAbil[] HeroAbilArray //struct
	{
		CAbilLink Abil; //fieldtype: CatalogLink
		CButtonLink Button; //fieldtype: CatalogLink
		CUnitLink Unit; //fieldtype: CatalogLink
		CFlagArray<e_heroAbilFlagCount>[] Flags; //fieldtype: Flags
	}
	SHeroHeroicAbility[] HeroicAbilArray //struct
	{
		CAbilLink Abil; //fieldtype: CatalogLink
	}
	CSkinLink[] SkinArray; //fieldtype: CatalogLink
	CMountLink DefaultMount; //fieldtype: CatalogLink
	CSoundLink[] VOArray; //fieldtype: CatalogLink
	SHeroSpecificVO[] SpecificKillVOArray //struct
	{
		CUnitLink Target; //fieldtype: CatalogLink
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CRewardLink[] RequiredRewardArray; //fieldtype: CatalogLink
	CRewardLink[] CanPurchaseUltimateSkinRewardArray; //fieldtype: CatalogLink
	CTalentProfileLink[] TalentProfileArray; //fieldtype: CatalogLink
	SHeroTalentTree[] TalentTreeArray //struct
	{
		CTalentLink Talent; //fieldtype: CatalogLink
		uint32 Tier; //fieldtype: IntUnsigned
		uint32 Column; //fieldtype: IntUnsigned
		CTalentLink[] PrerequisiteTalentArray; //fieldtype: CatalogLink
	}
	SHeroTalentTier[] TalentTierArray //struct
	{
		uint32 Tier; //fieldtype: IntUnsigned
		uint32 Level; //fieldtype: IntUnsigned
	}
	CRewardLink[] SkinVariationRequiredReward; //fieldtype: CatalogLink
	CRewardLink[] MountVariationRequiredReward; //fieldtype: CatalogLink
	CCutscenePath HeroSelectCutsceneFile; //fieldtype: String
	CCutscenePath ScoreScreenCutsceneFile; //fieldtype: String
	CCutscenePath MiniPortraitCutsceneFile; //fieldtype: String
	CCutscenePath InGameUnitStatusCutsceneFile; //fieldtype: String
	CImagePath VariationIcon; //fieldtype: String
	EHeroDifficulty Difficulty; //fieldtype: Unknown
	SHeroSpecificIntroVO[] SpecificIntroVOArray //struct
	{
		CUnitLink Target; //fieldtype: CatalogLink
		CSoundLink Question; //fieldtype: CatalogLink
		CSoundLink Response; //fieldtype: CatalogLink
	}
	uint64 HeroTierAchievementId; //fieldtype: IntUnsigned
	CImagePath CollectionIcon; //fieldtype: String
	EHeroGender Gender; //fieldtype: Unknown
	EHeroUniverse Universe; //fieldtype: Unknown
	CImagePath UniverseIcon; //fieldtype: String
	TBattleProductId ProductId; //fieldtype: IntSigned
	CCutscenePath PreviewCutsceneFile; //fieldtype: String
	CCutscenePath TileCutsceneFile; //fieldtype: String
	SHeroLevelScaling[] LevelScalingArray //struct
	{
		CAbilLink Ability; //fieldtype: CatalogLink
		SHeroLevelModification[] Modifications //struct
		{
			EGameCatalog Catalog; //enum
			CIdentifier Entry; //fieldtype: String
			CIdentifier Field; //fieldtype: String
			bool8 FieldIsInteger; //fieldtype: Unknown
			real32 Value; //fieldtype: Float
			bool8 AffectedByAbilityPower; //fieldtype: Unknown
			bool8 AffectedByOverdrive; //fieldtype: Unknown
		}
	}
	CStringLink AdditionalSearchText; //fieldtype: String
	CSkinLink[] VariationArray; //fieldtype: CatalogLink
	SHeroReleaseDate ReleaseDate //struct
	{
		uint32 Month; //fieldtype: IntUnsigned
		uint32 Day; //fieldtype: IntUnsigned
		uint32 Year; //fieldtype: IntUnsigned
	}
	THyperlinkId HyperlinkId; //fieldtype: String
	TMountCategory[] AllowedMountCategoryArray; //fieldtype: String
	SHeroRatings Ratings //struct
	{
		uint8 Damage; //fieldtype: IntUnsigned
		uint8 Utility; //fieldtype: IntUnsigned
		uint8 Survivability; //fieldtype: IntUnsigned
		uint8 Complexity; //fieldtype: IntUnsigned
	}
	CCutscenePath HomeScreenCutsceneFile; //fieldtype: String
	SHeroAITalentBuild[] TalentAIBuildsArray //struct
	{
		EHeroAITalentBuildType BuildType; //enum
		bool8 AIOnly; //fieldtype: Unknown
		uint8 ChanceToPick; //fieldtype: IntUnsigned
		NNet::Game::TDifficulty MinDifficulty; //fieldtype: IntUnsigned
		NNet::Game::TDifficulty MaxDifficulty; //fieldtype: IntUnsigned
		CTalentLink[] TalentsArray; //fieldtype: CatalogLink
	}
	CLayoutPath LayoutFile; //fieldtype: String
	SHeroSpecificUI[] HeroSpecificUIArray //struct
	{
		CIdentifier Location; //fieldtype: String
		CString DescName; //fieldtype: String
	}
	CStringLink PurchaseWarning; //fieldtype: String
	EPurchaseWarningCondition PurchaseWarningCondition; //enum
}

class CHeroAbil
{
	CStringLink Name; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Image; //fieldtype: String
	CMoviePath Movie; //fieldtype: String
	uint32 RequiredLevel; //fieldtype: IntUnsigned
	CMapLink RequiredMission; //fieldtype: CatalogLink
	EHeroAbilState State; //enum
	CUpgradeLink[] UpgradeArray; //fieldtype: CatalogLink
	CUpgradeLink[] LevelUpgradeArray; //fieldtype: CatalogLink
	CAbilCommand[] AbilCommandArray; //fieldtype: Unknown
	SHeroStatModifier[] StatModifierArray //struct
	{
		CHeroStatLink Stat; //fieldtype: CatalogLink
		int32 Value; //fieldtype: IntSigned
		EHeroStatState State; //enum
	}
	CUserReference UserReference; //fieldtype: Unknown
}

class CHeroStat
{
	CStringLink Name; //fieldtype: String
	int32 Value; //fieldtype: IntSigned
	CUserReference UserReference; //fieldtype: Unknown
}
