
class CSkin
{
	CStringLink Name; //fieldtype: String
	CStringLink InfoText; //fieldtype: String
	CFourCC AttributeId; //fieldtype: FourCC
	SGameReplacement[] ReplacementArray //struct
	{
		EGameCatalog Catalog; //enum
		CIdentifier From; //fieldtype: String
		CIdentifier To; //fieldtype: String
	}
	CImagePath VariationIcon; //fieldtype: String
	CModelLink[] DisplayModel; //fieldtype: CatalogLink
	SSkinModelGroup[] ModelGroups //struct
	{
		CIdentifier Name; //fieldtype: String
		CModelLink[] Models; //fieldtype: CatalogLink
	}
	SSkinModelMacroRun[] ModelMacroRun //struct
	{
		CIdentifier Models; //fieldtype: String
		CActorLink Macro; //fieldtype: CatalogLink
	}
	SUpgradeEffect[] EffectArray //struct
	{
		EUpgradeOperation Operation; //enum
		CCatalogReference Reference; //fieldtype: Unknown
		TUpgradeEffectValue Value; //fieldtype: String
	}
	CString Camera; //fieldtype: String
	int32 Rotation; //fieldtype: IntSigned
	CString WarChestUILight; //fieldtype: String
	CModelLink WarChestDisplayModel; //fieldtype: CatalogLink
	CActorLink WarChestDisplayActor; //fieldtype: CatalogLink
	CModelLink CollectionDisplayModel; //fieldtype: CatalogLink
	CUnitLink CollectionDisplayUnit; //fieldtype: CatalogLink
	CModelLink CollectionDisplayModelAlternate; //fieldtype: CatalogLink
	CUnitLink CollectionDisplayUnitAlternate; //fieldtype: CatalogLink
	CActorLink CollectionDisplayActor; //fieldtype: CatalogLink
	bool8 IsDefaultSkin; //fieldtype: Unknown
}

class CSkinPack
{
	bool8 Default; //fieldtype: Unknown
	CStringLink Name; //fieldtype: String
	CStringLink ShortName; //fieldtype: String
	CStringLink StoreName; //fieldtype: String
	TBattleProductId ProductId; //fieldtype: IntSigned
	SSkinPackEntry[] EntryArray //struct
	{
		CUnitLink Unit; //fieldtype: CatalogLink
		CRewardLink Reward; //fieldtype: CatalogLink
		CUnitLink UnitAlternate; //fieldtype: CatalogLink
		CRewardLink RewardAlternate; //fieldtype: CatalogLink
	}
	SProductReleaseDate ReleaseDate; //fieldtype: Unknown
	CStringLink StoreTypeName; //fieldtype: String
	CIdentifier CollectionId; //fieldtype: String
}
