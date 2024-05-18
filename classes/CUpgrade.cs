
class CUpgrade
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Name; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	uint32 WebPriority; //fieldtype: IntUnsigned
	CImagePath Icon; //fieldtype: String
	CAlertLink Alert; //fieldtype: CatalogLink
	CRaceLink Race; //fieldtype: CatalogLink
	uint32 ScoreAmount; //fieldtype: IntUnsigned
	EScoreValue ScoreCount; //enum
	EScoreValue ScoreValue; //enum
	CScoreResultLink ScoreResult; //fieldtype: CatalogLink
	SUpgradeEffect[] EffectArray //struct
	{
		EUpgradeOperation Operation; //enum
		CCatalogReference Reference; //fieldtype: Unknown
		TUpgradeEffectValue Value; //fieldtype: String
	}
	SUpgradeEffectTemplate[] EffectArrayTemplate //struct
	{
		EUpgradeOperation Operation; //enum
		CString Reference; //fieldtype: String
		CString Value; //fieldtype: String
	}
	CUnitLink[] UnitAllowed; //fieldtype: CatalogLink
	CUnitLink[] UnitDisallowed; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CUnitLink[] AffectedUnitArray; //fieldtype: CatalogLink
	uint8 MaxLevel; //fieldtype: IntUnsigned
	CUpgradeLink LeaderAlias; //fieldtype: CatalogLink
	uint32 LeaderPriority; //fieldtype: IntUnsigned
	uint32 LeaderLevel; //fieldtype: IntUnsigned
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	CFlagArray<e_unitUserFlagCount>[] EnumRequiredUserFlags; //fieldtype: Flags
	CFlagArray<e_unitUserFlagCount>[] EnumExcludedUserFlags; //fieldtype: Flags
	CButtonLink[] LevelButton; //fieldtype: CatalogLink
	const CTechRequirementsGraph*[] LevelRequirements; //fieldtype: Unknown
	int32[] BonusResourcePerLevel; //fieldtype: IntSigned
	CGameTime BonusTimePerLevel; //fieldtype: Fixed
}
