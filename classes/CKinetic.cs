
class CKinetic
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	uint32 Cycles; //fieldtype: IntUnsigned
	CGameTime Duration; //fieldtype: Fixed
}

class CKineticFollow
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	uint32 Cycles; //fieldtype: IntUnsigned
	CGameTime Duration; //fieldtype: Fixed
	SEffectWhichLocation Where //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	EKineticFollow Follow; //fieldtype: Unknown
}

class CKineticRotate
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	uint32 Cycles; //fieldtype: IntUnsigned
	CGameTime Duration; //fieldtype: Fixed
	SEffectWhichLocation Around //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CVariatorGameFangle Pitch; //fieldtype: Unknown
	CVariatorGameFangle Roll; //fieldtype: Unknown
	CVariatorGameFangle Yaw; //fieldtype: Unknown
}

class CKineticSequence
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	uint32 Cycles; //fieldtype: IntUnsigned
	CGameTime Duration; //fieldtype: Fixed
	CKineticLink[] KineticArray; //fieldtype: CatalogLink
}

class CKineticSet
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	uint32 Cycles; //fieldtype: IntUnsigned
	CGameTime Duration; //fieldtype: Fixed
	CKineticLink[] KineticArray; //fieldtype: CatalogLink
}

class CKineticTranslate
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	uint32 Cycles; //fieldtype: IntUnsigned
	CGameTime Duration; //fieldtype: Fixed
	CVariatorGameFixed XOffset; //fieldtype: Unknown
	CVariatorGameFixed YOffset; //fieldtype: Unknown
	CVariatorGameFixed ZOffset; //fieldtype: Unknown
}

class CKineticDistance
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	uint32 Cycles; //fieldtype: IntUnsigned
	CGameTime Duration; //fieldtype: Fixed
	SEffectWhichLocation DistanceAwayFrom //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SAccumulatedFixed Distance //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
}
