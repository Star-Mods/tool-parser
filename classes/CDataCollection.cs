
class CDataCollection
{
	CStringLink Name; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	EGameCatalog EditorIconSource; //enum
	CStringLink InfoText; //fieldtype: String
	SDataCollectionRecord[] DataRecord //struct
	{
		CCatalogGameLink Entry; //fieldtype: Unknown
	}
	CButtonLink Button; //fieldtype: CatalogLink
	EImplementionLevel ImplementionLevel; //enum
	CDataCollectionPatternLink Pattern; //fieldtype: CatalogLink
}

class CDataCollectionUnit
{
	CStringLink Name; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	EGameCatalog EditorIconSource; //enum
	CStringLink InfoText; //fieldtype: String
	SDataCollectionRecord[] DataRecord //struct
	{
		CCatalogGameLink Entry; //fieldtype: Unknown
	}
	CButtonLink Button; //fieldtype: CatalogLink
	EImplementionLevel ImplementionLevel; //enum
	CDataCollectionPatternLink Pattern; //fieldtype: CatalogLink
	CAbilLink[] AbilInfoNormal; //fieldtype: CatalogLink
	CAbilLink[] AbilInfoLearned; //fieldtype: CatalogLink
	CUnitLink[] AbilInfoUpgradeTo; //fieldtype: CatalogLink
	CUnitLink[] AbilInfoBuilt; //fieldtype: CatalogLink
	CUnitLink[] AbilInfoTrainUnit; //fieldtype: CatalogLink
	CAbilLink[] AbilInfoResearch; //fieldtype: CatalogLink
	CUnitLink[] AbilInfoSellUnit; //fieldtype: CatalogLink
	CUnitLink[] AbilInfoSellItem; //fieldtype: CatalogLink
	CUnitLink[] AbilInfoMakeItem; //fieldtype: CatalogLink
	CFixed UpgradeInfoUnitLifeArmorPerLevel; //fieldtype: Fixed
	SUpgradeInfoWeapon[] UpgradeInfoWeapon //struct
	{
		CWeaponLink UpgradeWeapon; //fieldtype: CatalogLink
		CEffectLink UpgradeEffect; //fieldtype: CatalogLink
		CFixed DamagePerDice; //fieldtype: Fixed
	}
	CUnitLink TechInfoUnit; //fieldtype: CatalogLink
	CUnitLink TechInfoUnitReplaced; //fieldtype: CatalogLink
	CUpgradeLink[] TechInfoUpgradeUsed; //fieldtype: CatalogLink
}

class CDataCollectionUpgrade
{
	CStringLink Name; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	EGameCatalog EditorIconSource; //enum
	CStringLink InfoText; //fieldtype: String
	SDataCollectionRecord[] DataRecord //struct
	{
		CCatalogGameLink Entry; //fieldtype: Unknown
	}
	CButtonLink Button; //fieldtype: CatalogLink
	EImplementionLevel ImplementionLevel; //enum
	CDataCollectionPatternLink Pattern; //fieldtype: CatalogLink
	CUpgradeLink TechInfoUpgrade; //fieldtype: CatalogLink
	CUpgradeLink TechInfoUpgradeReplaced; //fieldtype: CatalogLink
}

class CDataCollectionAbil
{
	CStringLink Name; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	EGameCatalog EditorIconSource; //enum
	CStringLink InfoText; //fieldtype: String
	SDataCollectionRecord[] DataRecord //struct
	{
		CCatalogGameLink Entry; //fieldtype: Unknown
	}
	CButtonLink Button; //fieldtype: CatalogLink
	EImplementionLevel ImplementionLevel; //enum
	CDataCollectionPatternLink Pattern; //fieldtype: CatalogLink
	CAbilLink TechInfoAbil; //fieldtype: CatalogLink
	CAbilLink TechInfoAbilReplaced; //fieldtype: CatalogLink
}

class CDataCollectionPattern
{
	SDataFieldsPattern[] Fields //struct
	{
		CString Reference; //fieldtype: String
		CStringLink NameOverride; //fieldtype: String
		CIdentifier UserData; //fieldtype: String
	}
	SDataTokensPattern[] Tokens //struct
	{
		CString Reference; //fieldtype: String
		CStringLink NameOverride; //fieldtype: String
		CIdentifier UserData; //fieldtype: String
	}
}
