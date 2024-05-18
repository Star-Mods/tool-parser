
class CPlayerResponse
{
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 Priority; //fieldtype: IntUnsigned
	EDamageLocation Location; //enum
}

class CPlayerResponseUnit
{
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 Priority; //fieldtype: IntUnsigned
	EDamageLocation Location; //enum
	CFixed Chance; //fieldtype: Fixed
	SCost Cost //struct
	{
		int32[] Resource; //fieldtype: IntSigned
		CFlags[] Display; //fieldtype: Flags
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		SCharge Charge //struct
		{
			CFixed CountMax; //fieldtype: Fixed
			CFixed CountStart; //fieldtype: Fixed
			CFixed CountUse; //fieldtype: Fixed
			bool32 HideCount; //fieldtype: Unknown
			TChargeLink Link; //fieldtype: String
			EChargeLocation Location; //enum
			CGameTime TimeDelay; //fieldtype: Fixed
			CGameTime TimeStart; //fieldtype: Fixed
			CGameTime TimeUse; //fieldtype: Fixed
			CFlags[] Flags; //fieldtype: Flags
		}
		SCooldown Cooldown //struct
		{
			TCooldownLink Link; //fieldtype: String
			ECooldownLocation Location; //enum
			CGameTime TimeStart; //fieldtype: Fixed
			ECooldownOperation Operation; //enum
			CGameTime TimeUse; //fieldtype: Fixed
		}
	}
	CEffectLink Handled; //fieldtype: CatalogLink
	CTargetFilters CasterFilters; //fieldtype: Unknown
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	EResponseContinueMethod ContinueMethod; //enum
	CFlagArray<e_damageResponseCategoryCount>[] ProvideCategories; //fieldtype: Flags
	CFlagArray<e_damageResponseCategoryCount>[] PreventCategories; //fieldtype: Flags
}

class CPlayerResponseUnitDamage
{
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 Priority; //fieldtype: IntUnsigned
	EDamageLocation Location; //enum
	CFixed Chance; //fieldtype: Fixed
	SCost Cost //struct
	{
		int32[] Resource; //fieldtype: IntSigned
		CFlags[] Display; //fieldtype: Flags
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		SCharge Charge //struct
		{
			CFixed CountMax; //fieldtype: Fixed
			CFixed CountStart; //fieldtype: Fixed
			CFixed CountUse; //fieldtype: Fixed
			bool32 HideCount; //fieldtype: Unknown
			TChargeLink Link; //fieldtype: String
			EChargeLocation Location; //enum
			CGameTime TimeDelay; //fieldtype: Fixed
			CGameTime TimeStart; //fieldtype: Fixed
			CGameTime TimeUse; //fieldtype: Fixed
			CFlags[] Flags; //fieldtype: Flags
		}
		SCooldown Cooldown //struct
		{
			TCooldownLink Link; //fieldtype: String
			ECooldownLocation Location; //enum
			CGameTime TimeStart; //fieldtype: Fixed
			ECooldownOperation Operation; //enum
			CGameTime TimeUse; //fieldtype: Fixed
		}
	}
	CEffectLink Handled; //fieldtype: CatalogLink
	CTargetFilters CasterFilters; //fieldtype: Unknown
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	EResponseContinueMethod ContinueMethod; //enum
	CFlagArray<e_damageResponseCategoryCount>[] ProvideCategories; //fieldtype: Flags
	CFlagArray<e_damageResponseCategoryCount>[] PreventCategories; //fieldtype: Flags
	CFlagArray<e_deathTypeCount>[] DeathType; //fieldtype: Flags
	CFixed ClampMaximum; //fieldtype: Fixed
	CFixed ClampMinimum; //fieldtype: Fixed
	CEffectLink Exhausted; //fieldtype: CatalogLink
	bool8 Evade; //fieldtype: Unknown
	bool8 Fatal; //fieldtype: Unknown
	CFixed[] Ignore; //fieldtype: Fixed
	CFlagArray<e_damageKindCount>[] Kind; //fieldtype: Flags
	CFixed Maximum; //fieldtype: Fixed
	CFixed Minimum; //fieldtype: Fixed
	CFixed ModifyAmount; //fieldtype: Fixed
	CFixed ModifyFraction; //fieldtype: Fixed
	CFixed ModifyLimit; //fieldtype: Fixed
	CFixed[] ModifyLimitVitalMaxFractionArray; //fieldtype: Fixed
	bool8 ModifyMinimumDamage; //fieldtype: Unknown
	CEffectLink[] RequireEffectArray; //fieldtype: CatalogLink
	CEffectLink[] ExcludeEffectArray; //fieldtype: CatalogLink
	CEffectLink[] RequireEffectInChainArray; //fieldtype: CatalogLink
	CEffectLink[] ExcludeEffectInChainArray; //fieldtype: CatalogLink
	EDamageResponseDamageValue DamageValue; //enum
	SScoreValueUpdate[] ModifyScoreArray //struct
	{
		CValidatorLink Validator; //fieldtype: CatalogLink
		CScoreValueLink Value; //fieldtype: CatalogLink
	}
}

class CPlayerResponseUnitDeath
{
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 Priority; //fieldtype: IntUnsigned
	EDamageLocation Location; //enum
	CFixed Chance; //fieldtype: Fixed
	SCost Cost //struct
	{
		int32[] Resource; //fieldtype: IntSigned
		CFlags[] Display; //fieldtype: Flags
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		SCharge Charge //struct
		{
			CFixed CountMax; //fieldtype: Fixed
			CFixed CountStart; //fieldtype: Fixed
			CFixed CountUse; //fieldtype: Fixed
			bool32 HideCount; //fieldtype: Unknown
			TChargeLink Link; //fieldtype: String
			EChargeLocation Location; //enum
			CGameTime TimeDelay; //fieldtype: Fixed
			CGameTime TimeStart; //fieldtype: Fixed
			CGameTime TimeUse; //fieldtype: Fixed
			CFlags[] Flags; //fieldtype: Flags
		}
		SCooldown Cooldown //struct
		{
			TCooldownLink Link; //fieldtype: String
			ECooldownLocation Location; //enum
			CGameTime TimeStart; //fieldtype: Fixed
			ECooldownOperation Operation; //enum
			CGameTime TimeUse; //fieldtype: Fixed
		}
	}
	CEffectLink Handled; //fieldtype: CatalogLink
	CTargetFilters CasterFilters; //fieldtype: Unknown
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	EResponseContinueMethod ContinueMethod; //enum
	CFlagArray<e_damageResponseCategoryCount>[] ProvideCategories; //fieldtype: Flags
	CFlagArray<e_damageResponseCategoryCount>[] PreventCategories; //fieldtype: Flags
	CFlagArray<e_deathTypeCount>[] DeathType; //fieldtype: Flags
}

class CPlayerResponseUnitBirth
{
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 Priority; //fieldtype: IntUnsigned
	EDamageLocation Location; //enum
	CFixed Chance; //fieldtype: Fixed
	SCost Cost //struct
	{
		int32[] Resource; //fieldtype: IntSigned
		CFlags[] Display; //fieldtype: Flags
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		SCharge Charge //struct
		{
			CFixed CountMax; //fieldtype: Fixed
			CFixed CountStart; //fieldtype: Fixed
			CFixed CountUse; //fieldtype: Fixed
			bool32 HideCount; //fieldtype: Unknown
			TChargeLink Link; //fieldtype: String
			EChargeLocation Location; //enum
			CGameTime TimeDelay; //fieldtype: Fixed
			CGameTime TimeStart; //fieldtype: Fixed
			CGameTime TimeUse; //fieldtype: Fixed
			CFlags[] Flags; //fieldtype: Flags
		}
		SCooldown Cooldown //struct
		{
			TCooldownLink Link; //fieldtype: String
			ECooldownLocation Location; //enum
			CGameTime TimeStart; //fieldtype: Fixed
			ECooldownOperation Operation; //enum
			CGameTime TimeUse; //fieldtype: Fixed
		}
	}
	CEffectLink Handled; //fieldtype: CatalogLink
	CTargetFilters CasterFilters; //fieldtype: Unknown
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	EResponseContinueMethod ContinueMethod; //enum
	CFlagArray<e_damageResponseCategoryCount>[] ProvideCategories; //fieldtype: Flags
	CFlagArray<e_damageResponseCategoryCount>[] PreventCategories; //fieldtype: Flags
	CFlagArray<e_responseUnitBirthTypeCount>[] BirthType; //fieldtype: Flags
}
