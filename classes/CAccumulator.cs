
class CAccumulator
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
}

class CAccumulatorConstant
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	CFixed Amount; //fieldtype: Fixed
}

class CAccumulatorVitals
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	CFixed Ratio; //fieldtype: Fixed
	bool8 Missing; //fieldtype: Unknown
	EUnitVital VitalType; //enum
	SEffectWhichUnit UnitSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EVitalsAccumulatorModificationType ModificationType; //fieldtype: Unknown
	bool8 ClampToMaxVitalForFractionalDamage; //fieldtype: Unknown
}

class CAccumulatorDistance
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	SEffectWhichLocation StartLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichLocation EndLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CFixed Scale; //fieldtype: Fixed
}

class CAccumulatorBehavior
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	SEffectWhichUnit UnitSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EAccumulatorBehaviorType Type; //fieldtype: Unknown
}

class CAccumulatorAttributePoints
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	CBehaviorLink Attribute; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	SEffectWhichUnit UnitSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CFixed Scale; //fieldtype: Fixed
}

class CAccumulatorTrackedUnitCount
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	CFixed Scale; //fieldtype: Fixed
	SEffectWhichUnit TrackerUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CBehaviorLink TrackingBehavior; //fieldtype: CatalogLink
	CValidatorLink[] TrackedUnitValidatorArray; //fieldtype: CatalogLink
	CTargetFilters TrackedUnitFilters; //fieldtype: Unknown
}

class CAccumulatorLevel
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	CFixed[] Amount; //fieldtype: Fixed
	CFixed LevelFactor; //fieldtype: Fixed
	CFixed PreviousValueFactor; //fieldtype: Fixed
	CFixed BonusPerLevel; //fieldtype: Fixed
}

class CAccumulatorAbilLevel
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	CFixed[] Amount; //fieldtype: Fixed
	CFixed LevelFactor; //fieldtype: Fixed
	CFixed PreviousValueFactor; //fieldtype: Fixed
	CFixed BonusPerLevel; //fieldtype: Fixed
}

class CAccumulatorUnitLevel
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	CFixed[] Amount; //fieldtype: Fixed
	CFixed LevelFactor; //fieldtype: Fixed
	CFixed PreviousValueFactor; //fieldtype: Fixed
	CFixed BonusPerLevel; //fieldtype: Fixed
	SEffectWhichUnit UnitSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
}

class CAccumulatorVeterancyLevel
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	CFixed[] Amount; //fieldtype: Fixed
	CFixed LevelFactor; //fieldtype: Fixed
	CFixed PreviousValueFactor; //fieldtype: Fixed
	CFixed BonusPerLevel; //fieldtype: Fixed
	SEffectWhichUnit UnitSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
}

class CAccumulatorCargo
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	SEffectWhichUnit UnitSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	ECargoSpace Type; //enum
}

class CAccumulatorEffectAmount
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	EEffectAmount AmountType; //enum
	bool8 Total; //fieldtype: Unknown
}

class CAccumulatorUserData
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	CIdentifier Key; //fieldtype: String
	CFixed FallbackValue; //fieldtype: Fixed
	SEffectWhichBehavior BehaviorScope //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
		CBehaviorLink Behavior; //fieldtype: CatalogLink
	}
}

class CAccumulatorUnitCustomValue
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	int32 Index; //fieldtype: IntSigned
	CFixed FallbackValue; //fieldtype: Fixed
	SEffectWhichUnit UnitSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
}

class CAccumulatorSwitch
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	SAccumulatorSwitchCase[] CaseArray //struct
	{
		CValidatorLink Validator; //fieldtype: CatalogLink
		CAccumulatorLink Accumulator; //fieldtype: CatalogLink
		bool8 FallThrough; //fieldtype: Unknown
	}
	CAccumulatorLink CaseDefault; //fieldtype: CatalogLink
}

class CAccumulatorArithmetic
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	SAccumulatedFixed[] Parameters //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	EAccumulatorOperation Operation; //enum
}

class CAccumulatorPlayerScoreValue
{
	CEffectLink SourceEffect; //fieldtype: CatalogLink
	CFixed MinAccumulation; //fieldtype: Fixed
	CFixed MaxAccumulation; //fieldtype: Fixed
	EAccumulatorApplicationRule ApplicationRule; //fieldtype: Unknown
	SEffectWhichPlayer Player //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CScoreValueLink Value; //fieldtype: CatalogLink
}
