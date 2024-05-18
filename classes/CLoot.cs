
class CLoot
{
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CLootSpawn
{
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	EEffectLocation SpawnLocation; //enum
	EEffectPlayer SpawnOwner; //enum
	CFixed SpawnRange; //fieldtype: Fixed
}

class CLootEffect
{
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CEffectLink Effect; //fieldtype: CatalogLink
}

class CLootItem
{
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	EEffectLocation SpawnLocation; //enum
	EEffectPlayer SpawnOwner; //enum
	CFixed SpawnRange; //fieldtype: Fixed
	CItemClassLink[] ClassArray; //fieldtype: CatalogLink
	uint32 MaxLevel; //fieldtype: IntUnsigned
	uint32 MinLevel; //fieldtype: IntUnsigned
}

class CLootSet
{
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	uint32 MinCount; //fieldtype: IntUnsigned
	uint32 MaxCount; //fieldtype: IntUnsigned
	SLootChoice[] ChildArray //struct
	{
		uint8 Chance; //fieldtype: IntUnsigned
		CLootLink Child; //fieldtype: CatalogLink
	}
}

class CLootUnit
{
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	EEffectLocation SpawnLocation; //enum
	EEffectPlayer SpawnOwner; //enum
	CFixed SpawnRange; //fieldtype: Fixed
	CUnitLink Unit; //fieldtype: CatalogLink
}
