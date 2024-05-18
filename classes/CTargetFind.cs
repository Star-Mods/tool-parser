
class CTargetFind
{
	CFlagArray<e_targetFindFlagCount>[] Flags; //fieldtype: Flags
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink CasterValidator; //fieldtype: CatalogLink
	CValidatorLink TargetValidator; //fieldtype: CatalogLink
}

class CTargetFindBestPoint
{
	CFlagArray<e_targetFindFlagCount>[] Flags; //fieldtype: Flags
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink CasterValidator; //fieldtype: CatalogLink
	CValidatorLink TargetValidator; //fieldtype: CatalogLink
	CFixed DamageBase; //fieldtype: Fixed
	CEffectLink Effect; //fieldtype: CatalogLink
	uint32 MinCount; //fieldtype: IntUnsigned
	CFixed MinScore; //fieldtype: Fixed
	EUnitAttribute BonusAttri; //enum
}

class CTargetFindWorkerRallyPoint
{
	CFlagArray<e_targetFindFlagCount>[] Flags; //fieldtype: Flags
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink CasterValidator; //fieldtype: CatalogLink
	CValidatorLink TargetValidator; //fieldtype: CatalogLink
	uint32 CommandIndex; //fieldtype: IntUnsigned
}

class CTargetFindRallyPoint
{
	CFlagArray<e_targetFindFlagCount>[] Flags; //fieldtype: Flags
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink CasterValidator; //fieldtype: CatalogLink
	CValidatorLink TargetValidator; //fieldtype: CatalogLink
	uint32 CommandIndex; //fieldtype: IntUnsigned
}

class CTargetFindEnumArea
{
	CFlagArray<e_targetFindFlagCount>[] Flags; //fieldtype: Flags
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink CasterValidator; //fieldtype: CatalogLink
	CValidatorLink TargetValidator; //fieldtype: CatalogLink
	SEffectWhichLocation LaunchLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichLocation ImpactLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit[] ExcludeArray //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit[] IncludeArray //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CTargetFilters SearchFilters; //fieldtype: Unknown
	CCmdResult MinCountError; //fieldtype: Unknown
	uint32 MinCount; //fieldtype: IntUnsigned
	SAccumulatedUInt32 MaxCount //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	uint32 RecycleCount; //fieldtype: IntUnsigned
	CFlags[] SearchFlags; //fieldtype: Flags
	STargetFindEnumArea[] AreaArray //struct
	{
		CFangleArc Arc; //fieldtype: Fixed
		uint32 MaxCount; //fieldtype: IntUnsigned
		CFixed Radius; //fieldtype: Fixed
		CFixed RadiusBonus; //fieldtype: Fixed
		CValidatorLink Validator; //fieldtype: CatalogLink
	}
	CAbilLink Abil; //fieldtype: CatalogLink
	CFixed ExtendRadius; //fieldtype: Fixed
	STargetSorts TargetSorts //struct
	{
		CTargetSortLink[] SortArray; //fieldtype: CatalogLink
		uint32 RequestCount; //fieldtype: IntUnsigned
		CFixed RequestPercentage; //fieldtype: Fixed
	}
}

class CTargetFindEffect
{
	CFlagArray<e_targetFindFlagCount>[] Flags; //fieldtype: Flags
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink CasterValidator; //fieldtype: CatalogLink
	CValidatorLink TargetValidator; //fieldtype: CatalogLink
	CEffectLink Effect; //fieldtype: CatalogLink
	CFixed ExtendRadius; //fieldtype: Fixed
	STargetSorts TargetSorts //struct
	{
		CTargetSortLink[] SortArray; //fieldtype: CatalogLink
		uint32 RequestCount; //fieldtype: IntUnsigned
		CFixed RequestPercentage; //fieldtype: Fixed
	}
}

class CTargetFindLastAttacker
{
	CFlagArray<e_targetFindFlagCount>[] Flags; //fieldtype: Flags
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink CasterValidator; //fieldtype: CatalogLink
	CValidatorLink TargetValidator; //fieldtype: CatalogLink
}

class CTargetFindOffset
{
	CFlagArray<e_targetFindFlagCount>[] Flags; //fieldtype: Flags
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink CasterValidator; //fieldtype: CatalogLink
	CValidatorLink TargetValidator; //fieldtype: CatalogLink
	CFangle Angle; //fieldtype: Fixed
	CfRange Distance; //fieldtype: Unknown
}

class CTargetFindOrder
{
	CFlagArray<e_targetFindFlagCount>[] Flags; //fieldtype: Flags
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink CasterValidator; //fieldtype: CatalogLink
	CValidatorLink TargetValidator; //fieldtype: CatalogLink
	CAbilLink Abil; //fieldtype: CatalogLink
	TAbilCmdIndex AbilCmdIndex; //fieldtype: IntUnsigned
}

class CTargetFindSet
{
	CFlagArray<e_targetFindFlagCount>[] Flags; //fieldtype: Flags
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink CasterValidator; //fieldtype: CatalogLink
	CValidatorLink TargetValidator; //fieldtype: CatalogLink
	ETargetFindSet Type; //enum
	CTargetFindLink[] Array; //fieldtype: CatalogLink
}

class CTargetSort
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
}

class CTargetSortAlliance
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	EAllianceId Alliance; //enum
	SEffectWhichPlayer WithPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
}

class CTargetSortAngle
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	SEffectWhichLocation LaunchLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichLocation ImpactLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
}

class CTargetSortBehaviorCount
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	uint32 Value; //fieldtype: IntUnsigned
}

class CTargetSortBehaviorDuration
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	CFixed Value; //fieldtype: Fixed
}

class CTargetSortChargeCount
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	CAbilLink Ability; //fieldtype: CatalogLink
	TChargeLink Charge; //fieldtype: String
	CFixed Value; //fieldtype: Fixed
}

class CTargetSortChargeRegen
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	CAbilLink Ability; //fieldtype: CatalogLink
	TChargeLink Charge; //fieldtype: String
	CFixed Value; //fieldtype: Fixed
}

class CTargetSortCooldown
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	CAbilLink Ability; //fieldtype: CatalogLink
	TCooldownLink Cooldown; //fieldtype: String
	CFixed Value; //fieldtype: Fixed
}

class CTargetSortDistance
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
}

class CTargetSortField
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	TCatalogFieldPath Field; //fieldtype: String
	CIdentifier Value; //fieldtype: String
}

class CTargetSortInterruptible
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	bool8 Value; //fieldtype: Unknown
}

class CTargetSortMarker
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	uint32 Value; //fieldtype: IntUnsigned
}

class CTargetSortPowerSourceLevel
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	uint32 Value; //fieldtype: IntUnsigned
}

class CTargetSortPowerUserLevel
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	uint32 Value; //fieldtype: IntUnsigned
}

class CTargetSortPriority
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	TAttackTargetPriority Value; //fieldtype: IntSigned
}

class CTargetSortRandom
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
}

class CTargetSortValidator
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	CValidatorLink Validator; //fieldtype: CatalogLink
}

class CTargetSortVeterancy
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	uint32 Value; //fieldtype: IntUnsigned
}

class CTargetSortVital
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	CFixed Value; //fieldtype: Fixed
	EUnitVital Vital; //enum
}

class CTargetSortVitalFraction
{
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Descending; //fieldtype: Unknown
	CFixed Value; //fieldtype: Fixed
	EUnitVital Vital; //enum
}
