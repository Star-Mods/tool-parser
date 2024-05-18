
class CValidator
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
}

class CValidatorCombine
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	EValidateCombine Type; //enum
	CValidatorLink[] CombineArray; //fieldtype: CatalogLink
	bool8 Negate; //fieldtype: Unknown
}

class CValidatorCondition
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SValidatorCondition[] IfArray //struct
	{
		CValidatorLink Test; //fieldtype: CatalogLink
		CValidatorLink Return; //fieldtype: CatalogLink
	}
	CValidatorLink Else; //fieldtype: CatalogLink
}

class CValidatorFunction
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SValidatorFunction[] Line //struct
	{
		CValidatorLink Test; //fieldtype: CatalogLink
		CValidatorLink Return; //fieldtype: CatalogLink
		CValidatorLink Success; //fieldtype: CatalogLink
		CValidatorLink Failure; //fieldtype: CatalogLink
		CValidatorLink Ignored; //fieldtype: CatalogLink
		bool8 Break; //fieldtype: Unknown
	}
	CCmdResult ResultFallback; //fieldtype: Unknown
}

class CValidatorEffect
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	CEffectLink WhichEffect; //fieldtype: CatalogLink
	CCmdResult ResultNoEffect; //fieldtype: Unknown
}

class CValidatorEffectCompare
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	CEffectLink WhichEffect; //fieldtype: CatalogLink
	CCmdResult ResultNoEffect; //fieldtype: Unknown
	CEffectLink OtherEffect; //fieldtype: CatalogLink
	EValueCompare Compare; //enum
}

class CValidatorEffectCompareDodged
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	CEffectLink WhichEffect; //fieldtype: CatalogLink
	CCmdResult ResultNoEffect; //fieldtype: Unknown
	CEffectLink OtherEffect; //fieldtype: CatalogLink
	EValueCompare Compare; //enum
	uint32 Value; //fieldtype: IntUnsigned
}

class CValidatorEffectCompareEvaded
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	CEffectLink WhichEffect; //fieldtype: CatalogLink
	CCmdResult ResultNoEffect; //fieldtype: Unknown
	CEffectLink OtherEffect; //fieldtype: CatalogLink
	EValueCompare Compare; //enum
	uint32 Value; //fieldtype: IntUnsigned
}

class CValidatorEffectTreeUserData
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	bool8 CheckExistence; //fieldtype: Unknown
	CCmdResult ResultNoKey; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CIdentifier Key; //fieldtype: String
	SAccumulatedFixed Value //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	SEffectWhichBehavior BehaviorScope //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
		CBehaviorLink Behavior; //fieldtype: CatalogLink
	}
}

class CValidatorGameCompareTimeEvent
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	EValueCompare Compare; //enum
	EGameTimeEvent TimeEvent; //fieldtype: Unknown
}

class CValidatorGameCompareTimeOfDay
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CTimeOfDay Value; //fieldtype: Unknown
}

class CValidatorGameCompareTerrain
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CTerrainLink Value; //fieldtype: CatalogLink
}

class CValidatorGameCommanderActive
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	CCommanderLink Commander; //fieldtype: CatalogLink
}

class CValidatorLocation
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
}

class CValidatorLocationCompareCliffLevel
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichLocation OtherLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	EValueCompare Compare; //enum
	TCliffLevel Value; //fieldtype: IntUnsigned
}

class CValidatorLocationComparePower
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit FromUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	TPowerLink PowerLink; //fieldtype: String
	CBehaviorLink[] PowerSource; //fieldtype: CatalogLink
	EValueCompare Compare; //enum
	TPowerLevel Value; //fieldtype: IntUnsigned
}

class CValidatorLocationCompareRange
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	EValueCompare Compare; //enum
	CFixed Range; //fieldtype: Fixed
	bool8 Pathing; //fieldtype: Unknown
	SEffectWhichLocation Value //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
}

class CValidatorLocationArc
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichLocation OtherLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Find; //fieldtype: Unknown
	CFangleArc Arc; //fieldtype: Fixed
	SEffectWhichLocation Value //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
}

class CValidatorLocationCreep
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	bool8 Find; //fieldtype: Unknown
	CFixed RadiusBonus; //fieldtype: Fixed
}

class CValidatorLocationCrossChasm
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichLocation OtherLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Find; //fieldtype: Unknown
}

class CValidatorLocationCrossCliff
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichLocation OtherLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Find; //fieldtype: Unknown
	bool8 CrossRamp; //fieldtype: Unknown
}

class CValidatorLocationEnumArea
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SValidatorEnumArea[] AreaArray //struct
	{
		CFangleArc Arc; //fieldtype: Fixed
		EValueCompare Compare; //enum
		uint32 Count; //fieldtype: IntUnsigned
		CFixed Radius; //fieldtype: Fixed
		CFixed RadiusBonus; //fieldtype: Fixed
		CValidatorLink Validator; //fieldtype: CatalogLink
	}
	EValueCompare Compare; //enum
	uint32 Count; //fieldtype: IntUnsigned
	CFlags[] SearchFlags; //fieldtype: Flags
	SEffectWhichLocation LaunchLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CTargetFilters SearchFilters; //fieldtype: Unknown
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
	CIdentifier CachedSearch; //fieldtype: String
	EUnitVital CombinedVital; //enum
	EValueCompare CombinedVitalCompare; //enum
	SEffectWhichUnit CombinedVitalUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	uint32 CombinedVitalValue; //fieldtype: IntUnsigned
}

class CValidatorLocationPathable
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Find; //fieldtype: Unknown
	CFlagArray<e_pathingTypeCount>[] Types; //fieldtype: Flags
}

class CValidatorLocationInPlayableMapArea
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Find; //fieldtype: Unknown
}

class CValidatorLocationPlacement
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit FromUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CFixed Range; //fieldtype: Fixed
	CUnitLink Unit; //fieldtype: CatalogLink
}

class CValidatorLocationShrub
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	bool8 Find; //fieldtype: Unknown
}

class CValidatorLocationType
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CValidatorLink None; //fieldtype: CatalogLink
	CValidatorLink Point; //fieldtype: CatalogLink
	CValidatorLink Unit; //fieldtype: CatalogLink
}

class CValidatorLocationVision
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	bool8 Find; //fieldtype: Unknown
}

class CValidatorPlayer
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer OtherPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CCmdResult ResultNoPlayer; //fieldtype: Unknown
}

class CValidatorPlayerAlliance
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer OtherPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CCmdResult ResultNoPlayer; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
	SEffectWhichPlayer WithPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	EAllianceId Value; //enum
}

class CValidatorPlayerRequirement
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer OtherPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CCmdResult ResultNoPlayer; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
	bool8 UnitSelectionNotRequired; //fieldtype: Unknown
	const CTechRequirementsGraph* Value; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
}

class CValidatorPlayerTalent
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer OtherPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CCmdResult ResultNoPlayer; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
	CTalentLink Value; //fieldtype: CatalogLink
}

class CValidatorPlayerFood
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer OtherPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CCmdResult ResultNoPlayer; //fieldtype: Unknown
	bool8 AllowCheat; //fieldtype: Unknown
	CFixed Value; //fieldtype: Fixed
	CUnitLink TestUnitType; //fieldtype: CatalogLink
	SEffectWhichUnit TypeFallbackUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	uint32 Count; //fieldtype: IntUnsigned
	CCmdResult ResultFoodMax; //fieldtype: Unknown
}

class CValidatorPlayerCompare
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer OtherPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CCmdResult ResultNoPlayer; //fieldtype: Unknown
	EValueCompare Compare; //enum
}

class CValidatorPlayerCompareDifficulty
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer OtherPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CCmdResult ResultNoPlayer; //fieldtype: Unknown
	EValueCompare Compare; //enum
	TDifficultyLevel Value; //fieldtype: IntSigned
}

class CValidatorPlayerCompareFoodAvailable
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer OtherPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CCmdResult ResultNoPlayer; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CFixed Value; //fieldtype: Fixed
}

class CValidatorPlayerCompareFoodMade
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer OtherPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CCmdResult ResultNoPlayer; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CFixed Value; //fieldtype: Fixed
}

class CValidatorPlayerCompareFoodUsed
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer OtherPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CCmdResult ResultNoPlayer; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CFixed Value; //fieldtype: Fixed
}

class CValidatorPlayerCompareRace
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer OtherPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CCmdResult ResultNoPlayer; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CRaceLink Value; //fieldtype: CatalogLink
}

class CValidatorPlayerCompareResource
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer OtherPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CCmdResult ResultNoPlayer; //fieldtype: Unknown
	EValueCompare Compare; //enum
	EResourceType Resource; //enum
	uint32 Value; //fieldtype: IntUnsigned
}

class CValidatorPlayerCompareResult
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer OtherPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CCmdResult ResultNoPlayer; //fieldtype: Unknown
	EValueCompare Compare; //enum
	EGameResult Value; //enum
}

class CValidatorPlayerCompareType
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer OtherPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CCmdResult ResultNoPlayer; //fieldtype: Unknown
	EValueCompare Compare; //enum
	EPlayerType Value; //enum
}

class CValidatorUnit
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
}

class CValidatorUnitInWeaponRange
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
}

class CValidatorUnitAI
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
	EUnitAIFlag Flag; //enum
}

class CValidatorUnitCombatAI
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
}

class CValidatorUnitAlliance
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
	SEffectWhichPlayer WithPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	EAllianceId Value; //enum
	EAlliancePlayer AlliancePlayer; //enum
}

class CValidatorUnitAbil
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
	EClassIdCAbil AbilClass; //enum
	CAbilLink AbilLink; //fieldtype: CatalogLink
}

class CValidatorUnitBehaviorStackAlias
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
	bool8 IgnoreDisabledBehavior; //fieldtype: Unknown
	CIdentifier StackAlias; //fieldtype: String
}

class CValidatorUnitBehaviorState
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	bool8 Enabled; //fieldtype: Unknown
	EBehaviorState BehaviorState; //enum
}

class CValidatorUnitState
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	bool8 Enabled; //fieldtype: Unknown
	EUnitTestState State; //enum
}

class CValidatorUnitDetected
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	bool8 Detected; //fieldtype: Unknown
	CFlags[] Flags; //fieldtype: Flags
}

class CValidatorUnitArmor
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
	EArmorType ArmorType; //enum
}

class CValidatorUnitFilters
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	CTargetFilters Filters; //fieldtype: Unknown
}

class CValidatorUnitFlying
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
}

class CValidatorUnitInventory
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	CCmdResult ResultNoInventory; //fieldtype: Unknown
	bool8 RequireEnabled; //fieldtype: Unknown
}

class CValidatorUnitInventoryIsFull
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	CCmdResult ResultNoInventory; //fieldtype: Unknown
	bool8 RequireEnabled; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
}

class CValidatorUnitInventoryContainsItem
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	CCmdResult ResultNoInventory; //fieldtype: Unknown
	bool8 RequireEnabled; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
	CUnitLink Item; //fieldtype: CatalogLink
}

class CValidatorUnitLastDamagePlayer
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EPlayerRelationship Relationship; //enum
}

class CValidatorUnitKinetic
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	CKineticLink Value; //fieldtype: CatalogLink
	bool8 Find; //fieldtype: Unknown
}

class CValidatorUnitMissileNullified
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
}

class CValidatorUnitMover
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	CMoverLink Value; //fieldtype: CatalogLink
	bool8 Find; //fieldtype: Unknown
}

class CValidatorUnitOrder
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	CAbilLink AbilLink; //fieldtype: CatalogLink
	TAbilCmdIndex AbilCmdIndex; //fieldtype: IntUnsigned
	CCmdFlags[] CmdFlags; //fieldtype: Flags
	SEffectWhichLocation Target //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	bool8 CheckStateOnly; //fieldtype: Unknown
}

class CValidatorUnitOrderQueue
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	CAbilLink AbilLink; //fieldtype: CatalogLink
	EClassIdCAbil AbilClass; //enum
	TTechAlias AbilTechAlias; //fieldtype: String
	TAbilCmdIndex AbilCmdIndex; //fieldtype: IntUnsigned
	bool8 Find; //fieldtype: Unknown
	bool8 Queued; //fieldtype: Unknown
	SEffectWhichLocation Target //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CItemLink Item; //fieldtype: CatalogLink
}

class CValidatorUnitOrderTargetPathable
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	CAbilLink AbilLink; //fieldtype: CatalogLink
	TAbilCmdIndex AbilCmdIndex; //fieldtype: IntUnsigned
	bool8 Find; //fieldtype: Unknown
	CFixed MaxDistance; //fieldtype: Fixed
}

class CValidatorUnitOrderTargetType
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	CAbilLink AbilLink; //fieldtype: CatalogLink
	TAbilCmdIndex AbilCmdIndex; //fieldtype: IntUnsigned
	bool8 Find; //fieldtype: Unknown
	EEffectLocationType Type; //enum
}

class CValidatorUnitPathable
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	bool8 Find; //fieldtype: Unknown
	CFixed Range; //fieldtype: Fixed
	CFixed MaxDistance; //fieldtype: Fixed
}

class CValidatorUnitPathing
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
}

class CValidatorUnitScanning
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
}

class CValidatorUnitType
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	CUnitLink Value; //fieldtype: CatalogLink
	bool8 Find; //fieldtype: Unknown
	EUnitType Type; //enum
}

class CValidatorUnitWeaponAnimating
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	CWeaponLink Weapon; //fieldtype: CatalogLink
	bool8 Find; //fieldtype: Unknown
}

class CValidatorUnitWeaponFiring
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	CWeaponLink Weapon; //fieldtype: CatalogLink
	bool8 Find; //fieldtype: Unknown
}

class CValidatorUnitWeaponPlane
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
	EPlane Plane; //enum
}

class CValidatorUnitTestWeaponType
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
	EWeaponType WeaponType; //enum
	bool8 RequireActivated; //fieldtype: Unknown
	bool8 RequireEnabled; //fieldtype: Unknown
}

class CValidatorUnitCompare
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
}

class CValidatorUnitCompareAIAreaEvalRatio
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CFixed Radius; //fieldtype: Fixed
	CFixed Value; //fieldtype: Fixed
}

class CValidatorUnitCompareAbilLevel
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CAbilLink AbilLink; //fieldtype: CatalogLink
	uint32 Value; //fieldtype: IntUnsigned
}

class CValidatorUnitCompareAbilSkillPoint
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CAbilLink AbilLink; //fieldtype: CatalogLink
	ESkillPoint CountType; //fieldtype: Unknown
	int32 Value; //fieldtype: IntSigned
}

class CValidatorUnitCompareAbilStage
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	EAbilEffectStage AbilityStage; //fieldtype: Unknown
	CAbilLink Ability; //fieldtype: CatalogLink
}

class CValidatorUnitCompareAttackPriority
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	SEffectWhichUnit Attacker //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CUnitLink AttackerAlternateType; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	TAttackTargetPriority Value; //fieldtype: IntSigned
}

class CValidatorUnitCompareBehaviorCount
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	SAccumulatedUInt32 Value //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	CBehaviorCategoryFlags[] Categories; //fieldtype: Flags
	EEffectRemoveBehaviorAlignment BehaviorAlignment; //enum
	EBehaviorHeroicState Heroic; //enum
	SEffectWhichPlayer ExcludeOriginPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichUnit ExcludeCasterUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichPlayer RequireOriginPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichUnit RequireCasterUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
}

class CValidatorUnitCompareCargo
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	ECargoSpace Type; //enum
	uint8 Value; //fieldtype: IntUnsigned
}

class CValidatorUnitCompareChargeUsed
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	TChargeLink ChargeLink; //fieldtype: String
	EChargeLocation Location; //enum
	CAbilLink Ability; //fieldtype: CatalogLink
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	CFixed Value; //fieldtype: Fixed
}

class CValidatorUnitCompareCooldown
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	TCooldownLink CooldownLink; //fieldtype: String
	ECooldownLocation Location; //enum
	CAbilLink Ability; //fieldtype: CatalogLink
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	CFixed Value; //fieldtype: Fixed
}

class CValidatorUnitCompareDamageDealtTime
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CGameTime Value; //fieldtype: Fixed
}

class CValidatorUnitCompareDamageTakenTime
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CGameTime Value; //fieldtype: Fixed
}

class CValidatorUnitCompareDeath
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	EDeathType Value; //enum
}

class CValidatorUnitCompareDetectRange
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CFixed Value; //fieldtype: Fixed
	bool8 Radar; //fieldtype: Unknown
}

class CValidatorUnitCompareField
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	TCatalogFieldPath Field; //fieldtype: String
	CIdentifier Value; //fieldtype: String
}

class CValidatorUnitCompareKillCount
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	uint16 Value; //fieldtype: IntUnsigned
}

class CValidatorUnitCompareMarkerCount
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	uint32 Value; //fieldtype: IntUnsigned
}

class CValidatorUnitCompareMoverPhase
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	uint32 Value; //fieldtype: IntUnsigned
}

class CValidatorUnitCompareOrderCount
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CAbilLink AbilLink; //fieldtype: CatalogLink
	TAbilCmdIndex AbilCmdIndex; //fieldtype: IntUnsigned
	uint32 Value; //fieldtype: IntUnsigned
}

class CValidatorUnitCompareOrderTargetRange
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CAbilLink AbilLink; //fieldtype: CatalogLink
	TAbilCmdIndex AbilCmdIndex; //fieldtype: IntUnsigned
	CFixed Value; //fieldtype: Fixed
	bool8 Pathing; //fieldtype: Unknown
}

class CValidatorUnitComparePowerSourceLevel
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	uint32 Value; //fieldtype: IntUnsigned
	CBehaviorLink Behavior; //fieldtype: CatalogLink
}

class CValidatorUnitComparePowerUserLevel
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	uint32 Value; //fieldtype: IntUnsigned
	CBehaviorLink Behavior; //fieldtype: CatalogLink
}

class CValidatorUnitCompareRallyPointCount
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	uint32 Value; //fieldtype: IntUnsigned
	CAbilLink AbilLink; //fieldtype: CatalogLink
	uint32 Point; //fieldtype: IntUnsigned
}

class CValidatorUnitCompareResourceContents
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	uint32 Value; //fieldtype: IntUnsigned
	CBehaviorLink Behavior; //fieldtype: CatalogLink
}

class CValidatorUnitCompareResourceHarvesters
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	uint32 Value; //fieldtype: IntUnsigned
	bool8 Active; //fieldtype: Unknown
	bool8 Queued; //fieldtype: Unknown
	CBehaviorLink Behavior; //fieldtype: CatalogLink
}

class CValidatorUnitCompareSpeed
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CGameSpeed Value; //fieldtype: Fixed
}

class CValidatorUnitCompareVeterancyLevel
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	uint32 Value; //fieldtype: IntUnsigned
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	CCmdResult ResultMaxLevel; //fieldtype: Unknown
}

class CValidatorUnitCompareVital
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	EVitalType Type; //enum
	CFixed Value; //fieldtype: Fixed
	EUnitVital Vital; //enum
}

class CValidatorUnitCompareVitality
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	EVitalType Type; //enum
	CFixed Value; //fieldtype: Fixed
}

class CValidatorUnitCompareHeight
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit OtherUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CCmdResult ResultNoUnit; //fieldtype: Unknown
	EValueCompare Compare; //enum
	CFixed CasterAdd; //fieldtype: Fixed
	CFixed TargetAdd; //fieldtype: Fixed
	bool8 CasterHeight; //fieldtype: Unknown
	bool8 CasterGroundHeight; //fieldtype: Unknown
	bool8 CasterZ; //fieldtype: Unknown
	bool8 TargetHeight; //fieldtype: Unknown
	bool8 TargetGroundHeight; //fieldtype: Unknown
	bool8 TargetZ; //fieldtype: Unknown
}

class CValidatorCompareTrackedUnitsCount
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	EValueCompare Compare; //enum
	uint32 Value; //fieldtype: IntUnsigned
	CBehaviorLink BehaviorLink; //fieldtype: CatalogLink
	SEffectWhichUnit TrackerUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CValidatorLink[] TrackedUnitValidatorArray; //fieldtype: CatalogLink
	CTargetFilters TrackedUnitFilters; //fieldtype: Unknown
}

class CValidatorIsUnitTracked
{
	uint8 IgnoreWhileChanneling; //fieldtype: IntUnsigned
	CCmdResult ResultFailed; //fieldtype: Unknown
	bool8 Find; //fieldtype: Unknown
	CBehaviorLink BehaviorLink; //fieldtype: CatalogLink
	SEffectWhichUnit TrackerUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit TrackedUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
}
