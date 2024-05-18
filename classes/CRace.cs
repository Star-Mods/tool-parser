
class CRace
{
	CStringLink Name; //fieldtype: String
	CFourCC AttributeId; //fieldtype: FourCC
	CImagePath Icon; //fieldtype: String
	CImagePath RaceIcon; //fieldtype: String
	CAlertLink StartLocationAlert; //fieldtype: CatalogLink
	CSoundtrackLink GameMusic; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CFlagArray<e_resourceTypeCount>[] ShowResource; //fieldtype: Flags
	SStartingUnit[] StartingUnitArray //struct
	{
		uint32 Count; //fieldtype: IntUnsigned
		CFlags[] Flags; //fieldtype: Flags
		CGamePoint[] Offset; //fieldtype: Unknown
		CFixed Range; //fieldtype: Fixed
		CUnitLink Unit; //fieldtype: CatalogLink
	}
	uint32[] StartingResource; //fieldtype: IntUnsigned
	uint32 FoodCeiling; //fieldtype: IntUnsigned
	SUpkeepTax[] UpkeepTax //struct
	{
		uint32 FoodLevel; //fieldtype: IntUnsigned
		CFixed[] Tax; //fieldtype: Fixed
	}
	uint32 GlossaryTeamColorIndex; //fieldtype: IntUnsigned
	CColor MiniMapBorderColor; //fieldtype: Unknown
	CColor PlacementGridColorBlindColor; //fieldtype: Unknown
	CSoundLink VictorySound; //fieldtype: CatalogLink
	CSoundLink DefeatSound; //fieldtype: CatalogLink
	uint32 ExpansionOrder; //fieldtype: IntUnsigned
	uint64 LevelAchievementId; //fieldtype: IntUnsigned
	CConsoleSkinLink DefaultConsoleSkin; //fieldtype: CatalogLink
}

class CRaceBannerPack
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
	SProductReleaseDate ReleaseDate; //fieldtype: Unknown
	CRewardLink[] RaceBannerArray; //fieldtype: CatalogLink
	CStringLink StoreTypeName; //fieldtype: String
}
