
class CEffect
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
}

class CEffectResponse
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
}

class CEffectAddTrackedUnit
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
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

class CEffectClearTrackedUnits
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	CBehaviorLink BehaviorLink; //fieldtype: CatalogLink
	SEffectWhichUnit TrackerUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CValidatorLink[] ClearValidatorArray; //fieldtype: CatalogLink
}

class CEffectAddTrackedUnits
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	CBehaviorLink SourceBehaviorLink; //fieldtype: CatalogLink
	SEffectWhichUnit SourceTrackerUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CBehaviorLink TargetBehaviorLink; //fieldtype: CatalogLink
	SEffectWhichUnit TargetTrackerUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
}

class CEffectRemoveTrackedUnit
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
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

class CEffectApplyBehavior
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	bool8 KillHallucination; //fieldtype: Unknown
	SAccumulatedUInt32 Count //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CFlags[] Flags; //fieldtype: Flags
	CGameTime Duration; //fieldtype: Fixed
}

class CEffectApplyForce
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CFixed Amount; //fieldtype: Fixed
	CFixed MassFraction; //fieldtype: Fixed
	SEffectWhichTimeScale TimeScaleSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectTimeScale Value; //enum
	}
}

class CEffectApplyKinetic
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit ImpactUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CKineticLink Kinetic; //fieldtype: CatalogLink
}

class CEffectCancelOrder
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CAbilCommand AbilCmd; //fieldtype: Unknown
	uint32 Count; //fieldtype: IntUnsigned
	CFlags[] Flags; //fieldtype: Flags
}

class CEffectCreateHealer
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit LaunchUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit ImpactUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichTimeScale TimeScaleSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectTimeScale Value; //enum
	}
	CFlags[] Flags; //fieldtype: Flags
	uint32 PeriodCount; //fieldtype: IntUnsigned
	CValidatorLink PeriodicValidator; //fieldtype: CatalogLink
	CEffectLink PeriodicEffect; //fieldtype: CatalogLink
	CGameTime PeriodicPeriod; //fieldtype: Fixed
	CFixed PeriodicEffectRateMultiplier; //fieldtype: Fixed
	EUnitVital DrainVital; //enum
	SAccumulatedFixed DrainVitalCostFactor //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CFixed[] DrainResourceCostFactor; //fieldtype: Fixed
	EUnitVital RechargeVital; //enum
	CGameRate RechargeVitalFraction; //fieldtype: Fixed
	SAccumulatedGameRate RechargeVitalRate //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CGameRate RechargeVitalMax; //fieldtype: Fixed
	CFixed TimeFactor; //fieldtype: Fixed
	CEffectLink InitialEffect; //fieldtype: CatalogLink
	CEffectLink ExpireEffect; //fieldtype: CatalogLink
	CEffectLink FinalEffect; //fieldtype: CatalogLink
	SScoreValueUpdate[] AmountScoreArray //struct
	{
		CValidatorLink Validator; //fieldtype: CatalogLink
		CScoreValueLink Value; //fieldtype: CatalogLink
	}
}

class CEffectCreep
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SAccumulatedFixed Radius //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CFlags[] CreepFlags; //fieldtype: Flags
}

class CEffectCreatePersistent
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichTimeScale TimeScaleSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectTimeScale Value; //enum
	}
	SEffectWhichLocation OffsetVectorStartLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichLocation OffsetVectorEndLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichLocation OffsetFacingFallback //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CFlags[] Flags; //fieldtype: Flags
	CGameTime InitialDelay; //fieldtype: Fixed
	CEffectLink InitialEffect; //fieldtype: CatalogLink
	CEffectOffset InitialOffset; //fieldtype: Unknown
	SAccumulatedGameTime ExpireDelay //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CEffectLink ExpireEffect; //fieldtype: CatalogLink
	CEffectOffset ExpireOffset; //fieldtype: Unknown
	CEffectLink FinalEffect; //fieldtype: CatalogLink
	CEffectOffset FinalOffset; //fieldtype: Unknown
	SAccumulatedUInt32 PeriodCount //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CValidatorLink PeriodicValidator; //fieldtype: CatalogLink
	CEffectLink[] PeriodicEffectArray; //fieldtype: CatalogLink
	CEffectOffset[] PeriodicOffsetArray; //fieldtype: Unknown
	CGameTime[] PeriodicPeriodArray; //fieldtype: Fixed
	CFixed PeriodicEffectRateMultiplier; //fieldtype: Fixed
	SAccumulatedFixed RevealRadius //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CFlagArray<e_effectRevealFlagCount>[] RevealFlags; //fieldtype: Flags
	CFangleArc RevealArc; //fieldtype: Fixed
	CFangle RevealFacing; //fieldtype: Fixed
	CFixed RevealRectangleWidth; //fieldtype: Fixed
	CFixed RevealRectangleHeight; //fieldtype: Fixed
	CFlags[] TeleportTrack; //fieldtype: Flags
	CValidatorLink TeleportValidator; //fieldtype: CatalogLink
	CTargetFilters DetectFilters; //fieldtype: Unknown
	CTargetFilters RadarFilters; //fieldtype: Unknown
	EHeightMap HeightMap; //enum
	CEffectLink AINotifyEffect; //fieldtype: CatalogLink
	EListWalkMode EffectRandMode; //enum
	EListWalkMode OffsetRandMode; //enum
	EListWalkMode PeriodRandMode; //enum
}

class CEffectRandomPointInCircle
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CEffectLink Effect; //fieldtype: CatalogLink
	uint32 Count; //fieldtype: IntUnsigned
	SAccumulatedFixed Radius //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	bool8 RestrictToCircumference; //fieldtype: Unknown
}

class CEffectCreateUnit
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichLocation Origin //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CFlags[] CreateFlags; //fieldtype: Flags
	SEffectWhichUnit RallyUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichPlayer SpawnOwner //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CEffectLink SpawnEffect; //fieldtype: CatalogLink
	CUnitLink[] SpawnUnit; //fieldtype: CatalogLink
	SAccumulatedUInt32 SpawnCount //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CFixed SpawnRange; //fieldtype: Fixed
	CGamePoint[] SpawnOffset; //fieldtype: Unknown
	SEffectWhichUnit SelectUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit TypeFallbackUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
}

class CEffectDamage
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
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
	CValidatorLink ImpactUnitValidator; //fieldtype: CatalogLink
	CFixed[] AttributeBonus; //fieldtype: Fixed
	CFixed[] AttributeFactor; //fieldtype: Fixed
	CFlagArray<e_unitAttributeCount>[] AttributeForced; //fieldtype: Flags
	CFixed ShieldBonus; //fieldtype: Fixed
	CFixed ShieldFactor; //fieldtype: Fixed
	CFixed ArmorReduction; //fieldtype: Fixed
	EDamageVisibility Visibility; //enum
	CDamageFlags[] Flags; //fieldtype: Flags
	EDamageKind Kind; //enum
	EDamageKind KindSplash; //enum
	EDamageType Type; //enum
	EDamageTotal Total; //enum
	SAccumulatedFixed Amount //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	SAccumulatedFixed Fraction //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CFixed Random; //fieldtype: Fixed
	CFixed[] VitalBonus; //fieldtype: Fixed
	CFixed[] VitalFractionCurrent; //fieldtype: Fixed
	CFixed[] VitalFractionMax; //fieldtype: Fixed
	CFixed[] VitalBonusRandom; //fieldtype: Fixed
	CFixed[] VitalFractionCurrentRandom; //fieldtype: Fixed
	CFixed[] VitalFractionMaxRandom; //fieldtype: Fixed
	CFixed[] LeechFraction; //fieldtype: Fixed
	SScoreValueUpdate[] LeechScoreArray //struct
	{
		CValidatorLink Validator; //fieldtype: CatalogLink
		CScoreValueLink Value; //fieldtype: CatalogLink
	}
	EDeathType Death; //enum
	bool8 KillHallucination; //fieldtype: Unknown
	SEffectDamageArea[] AreaArray //struct
	{
		CFangleArc Arc; //fieldtype: Fixed
		uint32 MaxCount; //fieldtype: IntUnsigned
		CFixed Radius; //fieldtype: Fixed
		CFixed RectangleWidth; //fieldtype: Fixed
		CFixed RectangleHeight; //fieldtype: Fixed
		CFixed RadiusBonus; //fieldtype: Fixed
		CFangle FacingAdjustment; //fieldtype: Fixed
		CFixed Bonus; //fieldtype: Fixed
		CFixed Fraction; //fieldtype: Fixed
		CValidatorLink Validator; //fieldtype: CatalogLink
	}
	CGamePoint AreaRelativeOffset; //fieldtype: Unknown
	SEffectSearchRevealerParams RevealerParams //struct
	{
		CFlagArray<e_effectRevealFlagCount>[] RevealFlags; //fieldtype: Flags
		CTargetFilters DetectFilters; //fieldtype: Unknown
		CTargetFilters RadarFilters; //fieldtype: Unknown
		EHeightMap HeightMap; //enum
		CGameTime Duration; //fieldtype: Fixed
		CFixed ShapeExpansion; //fieldtype: Fixed
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
	STargetSorts TargetSorts //struct
	{
		CTargetSortLink[] SortArray; //fieldtype: CatalogLink
		uint32 RequestCount; //fieldtype: IntUnsigned
		CFixed RequestPercentage; //fieldtype: Fixed
	}
	CCmdResult MinCountError; //fieldtype: Unknown
	uint32 MinCount; //fieldtype: IntUnsigned
	SAccumulatedUInt32 MaxCount //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	uint32 RecycleCount; //fieldtype: IntUnsigned
	CFlags[] SearchFlags; //fieldtype: Flags
	CFlagArray<e_equipmentDisplayFlagCount>[] DisplayFlags; //fieldtype: Flags
	EEffectHistory SplashHistory; //enum
	SScoreValueUpdate[] AmountScoreArray //struct
	{
		CValidatorLink Validator; //fieldtype: CatalogLink
		CScoreValueLink Value; //fieldtype: CatalogLink
	}
	CFixed Minimum; //fieldtype: Fixed
	CFixed Maximum; //fieldtype: Fixed
	CEffectLink DamageInheritEffect; //fieldtype: CatalogLink
}

class CEffectDestroyHealer
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CEffectLink Effect; //fieldtype: CatalogLink
	uint32 Count; //fieldtype: IntUnsigned
	CFixed Radius; //fieldtype: Fixed
}

class CEffectDestroyPersistent
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CEffectLink Effect; //fieldtype: CatalogLink
	uint32 Count; //fieldtype: IntUnsigned
	CFixed Radius; //fieldtype: Fixed
}

class CEffectEnumArea
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
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
	STargetSorts TargetSorts //struct
	{
		CTargetSortLink[] SortArray; //fieldtype: CatalogLink
		uint32 RequestCount; //fieldtype: IntUnsigned
		CFixed RequestPercentage; //fieldtype: Fixed
	}
	SEffectEnumArea[] AreaArray //struct
	{
		CFangleArc Arc; //fieldtype: Fixed
		uint32 MaxCount; //fieldtype: IntUnsigned
		CFixed Radius; //fieldtype: Fixed
		CFixed RectangleWidth; //fieldtype: Fixed
		CFixed RectangleHeight; //fieldtype: Fixed
		CFixed RadiusBonus; //fieldtype: Fixed
		CFangle FacingAdjustment; //fieldtype: Fixed
		CEffectLink Effect; //fieldtype: CatalogLink
	}
	CGamePoint AreaRelativeOffset; //fieldtype: Unknown
	SEffectSearchRevealerParams RevealerParams //struct
	{
		CFlagArray<e_effectRevealFlagCount>[] RevealFlags; //fieldtype: Flags
		CTargetFilters DetectFilters; //fieldtype: Unknown
		CTargetFilters RadarFilters; //fieldtype: Unknown
		EHeightMap HeightMap; //enum
		CGameTime Duration; //fieldtype: Fixed
		CFixed ShapeExpansion; //fieldtype: Fixed
	}
	CCmdResult MinCountError; //fieldtype: Unknown
	uint32 MinCount; //fieldtype: IntUnsigned
	SAccumulatedUInt32 MaxCount //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	SAccumulatedFixed ExtraRadiusBonus //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	uint32 RecycleCount; //fieldtype: IntUnsigned
	CFlags[] SearchFlags; //fieldtype: Flags
	bool8 UnCreep; //fieldtype: Unknown
}

class CEffectEnumTrackedUnits
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	CBehaviorLink BehaviorLink; //fieldtype: CatalogLink
	SEffectWhichUnit TrackerUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CEffectLink Effect; //fieldtype: CatalogLink
	CTargetFilters TrackedUnitFilters; //fieldtype: Unknown
	bool8 DistributDamage; //fieldtype: Unknown
}

class CEffectEnumMagazine
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CTargetFilters SearchFilters; //fieldtype: Unknown
	uint32 MaxCount; //fieldtype: IntUnsigned
	CEffectLink EffectInternal; //fieldtype: CatalogLink
	CEffectLink EffectExternal; //fieldtype: CatalogLink
}

class CEffectEnumTransport
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CTargetFilters SearchFilters; //fieldtype: Unknown
	uint32 MaxCount; //fieldtype: IntUnsigned
	CEffectLink Effect; //fieldtype: CatalogLink
	bool8 CheckOuter; //fieldtype: Unknown
}

class CEffectEnumInventory
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CTargetFilters SearchFilters; //fieldtype: Unknown
	uint32 MaxCount; //fieldtype: IntUnsigned
	CEffectLink Effect; //fieldtype: CatalogLink
	bool8 CheckOuter; //fieldtype: Unknown
}

class CEffectLastTarget
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	EAbilLastTarget LastTargetType; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CEffectLink Effect; //fieldtype: CatalogLink
}

class CEffectLoadContainer
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	EEffectContainer ContainerType; //fieldtype: Unknown
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit ContainerUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CAbilLink ContainerAbil; //fieldtype: CatalogLink
}

class CEffectIssueOrder
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CAbilLink Abil; //fieldtype: CatalogLink
	TTechAlias AbilTechAlias; //fieldtype: String
	TAbilCmdIndex AbilCmdIndex; //fieldtype: IntUnsigned
	CCmdFlags[] CmdFlags; //fieldtype: Flags
	SEffectWhichPlayer Player //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichLocation Target //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
}

class CEffectLaunchMissile
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
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
	CEffectOffset LaunchOffset; //fieldtype: Unknown
	CEffectOffset ImpactOffset; //fieldtype: Unknown
	CEffectLink LaunchEffect; //fieldtype: CatalogLink
	CEffectLink ImpactEffect; //fieldtype: CatalogLink
	CEffectLink FinishEffect; //fieldtype: CatalogLink
	CEffectLink InterruptEffect; //fieldtype: CatalogLink
	CEffectLink SearchEffect; //fieldtype: CatalogLink
	CEffectLink SearchHitArriveEffect; //fieldtype: CatalogLink
	uint32 SearchMaxCount; //fieldtype: IntUnsigned
	uint32 PeriodCount; //fieldtype: IntUnsigned
	CEffectLink PeriodicEffect; //fieldtype: CatalogLink
	CGameTime PeriodicPeriod; //fieldtype: Fixed
	CValidatorLink PeriodicValidator; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] SearchFlags; //fieldtype: Flags
	CBehaviorLink TransferBehavior; //fieldtype: CatalogLink
	uint32 TransferCount; //fieldtype: IntUnsigned
	SEffectWhichPlayer AmmoOwner //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CUnitLink AmmoUnit; //fieldtype: CatalogLink
	CGameTime AmmoLife; //fieldtype: Fixed
	CUnitLink PlaceholderUnit; //fieldtype: CatalogLink
	CFixed PlacementMinDistance; //fieldtype: Fixed
	SEffectWhichLocation PlacementAround //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CFixed PlacementRange; //fieldtype: Fixed
	CFixed ImpactRange; //fieldtype: Fixed
	CTargetFilters RetargetFilters; //fieldtype: Unknown
	CFixed RetargetRange; //fieldtype: Fixed
	CGameTime ReturnDelay; //fieldtype: Fixed
	SEffectMover[] ReturnMovers //struct
	{
		CMoverLink Link; //fieldtype: CatalogLink
		CFixed IfRangeLTE; //fieldtype: Fixed
	}
	SEffectMover[] Movers //struct
	{
		CMoverLink Link; //fieldtype: CatalogLink
		CFixed IfRangeLTE; //fieldtype: Fixed
	}
	EMoverPatternType MoverRollingPattern; //enum
	uint32 MoverRollingJump; //fieldtype: IntUnsigned
	EMoverPatternType MoverExecutePattern; //enum
	uint32 MoverExecuteJump; //fieldtype: IntUnsigned
	uint32 MoverExecuteRange; //fieldtype: IntUnsigned
	EDeathType DeathType; //enum
	EDamageVisibility Visibility; //enum
	SEffectMissileBounce[] BounceArray //struct
	{
		CFixed DistanceMultiplier; //fieldtype: Fixed
		CEffectLink ImpactEffect; //fieldtype: CatalogLink
		CEffectOffset Offset; //fieldtype: Unknown
	}
}

class CEffectModifyPlayer
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	int32[] Resources; //fieldtype: IntSigned
	int32[] ResourcesCollected; //fieldtype: IntSigned
	SUpgradeEffect[] EffectArray //struct
	{
		EUpgradeOperation Operation; //enum
		CCatalogReference Reference; //fieldtype: Unknown
		TUpgradeEffectValue Value; //fieldtype: String
	}
	SEffectUpgrade[] Upgrades //struct
	{
		CUpgradeLink Upgrade; //fieldtype: CatalogLink
		int8 Count; //fieldtype: IntSigned
	}
	SEffectModifyPlayerCost Cost //struct
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
		CAbilLink Abil; //fieldtype: CatalogLink
		SEffectWhichUnit Unit //struct
		{
			CEffectLink Effect; //fieldtype: CatalogLink
			EEffectUnit Value; //enum
			EEffectHistory History; //enum
		}
	}
}

class CEffectModifyUnit
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit TransferUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit LaunchUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit ImpactUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit KillCreditUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 KillHallucination; //fieldtype: Unknown
	SEffectModifyUnitCost[] Cost //struct
	{
		CAbilCommand Abil; //fieldtype: Unknown
		CBehaviorLink Behavior; //fieldtype: CatalogLink
		SEffectWhichPlayer Player //struct
		{
			CEffectLink Effect; //fieldtype: CatalogLink
			EEffectPlayer Value; //enum
		}
		CFixed ChargeCountUse; //fieldtype: Fixed
		CGameTime ChargeTimeUse; //fieldtype: Fixed
		ECooldownOperation CooldownOperation; //enum
		CGameTime CooldownTimeUse; //fieldtype: Fixed
		SCostFactor Fraction //struct
		{
			CFixed[] Vital; //fieldtype: Fixed
			CFixed[] VitalFraction; //fieldtype: Fixed
			CFixed[] Resource; //fieldtype: Fixed
			CFixed Charge; //fieldtype: Fixed
			CFixed Cooldown; //fieldtype: Fixed
		}
	}
	SEffectModifyWeapon[] Weapon //struct
	{
		CWeaponLink Weapon; //fieldtype: CatalogLink
		ECooldownOperation CooldownOperation; //enum
		CGameTime CooldownAmount; //fieldtype: Fixed
		CFixed CooldownFraction; //fieldtype: Fixed
	}
	SEffectModifyVital[] VitalArray //struct
	{
		SAccumulatedFixed Change //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		SAccumulatedFixed ChangeFraction //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		SScoreValueUpdate[] ScoreArray //struct
		{
			CValidatorLink Validator; //fieldtype: CatalogLink
			CScoreValueLink Value; //fieldtype: CatalogLink
		}
	}
	CFixed Height; //fieldtype: Fixed
	CGameTime HeightTime; //fieldtype: Fixed
	CFlags[] ModifyFlags; //fieldtype: Flags
	CFixed XP; //fieldtype: Fixed
	CBehaviorLink VeterancyBehavior; //fieldtype: CatalogLink
	CAbilLink LearnAbilReset; //fieldtype: CatalogLink
	uint32 ResourceRestoreBonus; //fieldtype: IntUnsigned
	CFixed ResourceRestoreFraction; //fieldtype: Fixed
	int32 Resources; //fieldtype: IntSigned
	uint32 ResourcesHarvestedBonus; //fieldtype: IntUnsigned
	CFixed ResourcesHarvestedFraction; //fieldtype: Fixed
	SCostFactor SalvageFactor //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	int32 SpawnCount; //fieldtype: IntSigned
	uint32 CopyOrderCount; //fieldtype: IntUnsigned
	uint32 CopyRallyCount; //fieldtype: IntUnsigned
	SEffectWhichPlayer ModifyOwnerPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichUnit RallyUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectModifyTurret ModifyTurret //struct
	{
		EEffectModifyTurret Action; //enum
		CTurretLink Turret; //fieldtype: CatalogLink
		SEffectWhichLocation Target //struct
		{
			CEffectLink Effect; //fieldtype: CatalogLink
			EEffectLocation Value; //enum
			EEffectHistory History; //enum
		}
		CFlagArray<e_effectModifyTurretFlagCount>[] Flags; //fieldtype: Flags
		CEffectLink AimCompleteEffect; //fieldtype: CatalogLink
	}
	SEffectWhichUnit SelectTransferUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CFlagArray<e_selectionTransferFlagCount>[] SelectTransferFlags; //fieldtype: Flags
	SEffectWhichLocation FacingLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	EEffectModifyFacing FacingType; //fieldtype: Unknown
	CFangle FacingAdjustment; //fieldtype: Fixed
}

class CEffectMorph
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CDataSoupKey ActorKey; //fieldtype: String
	CFlags[] MorphFlags; //fieldtype: Flags
	CUnitLink MorphUnit; //fieldtype: CatalogLink
	SEffectWhichUnit TypeFallbackUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CAbilLink AbilKeyFallback; //fieldtype: CatalogLink
}

class CEffectRedirectMissile
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichLocation ImpactLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CTargetFilters ImpactFilters; //fieldtype: Unknown
	CFlags[] Flags; //fieldtype: Flags
	SEffectMover[] Movers //struct
	{
		CMoverLink Link; //fieldtype: CatalogLink
		CFixed IfRangeLTE; //fieldtype: Fixed
	}
	EMoverPatternType MoverRollingPattern; //enum
	uint32 MoverRollingJump; //fieldtype: IntUnsigned
	EMoverPatternType MoverExecutePattern; //enum
	uint32 MoverExecuteJump; //fieldtype: IntUnsigned
	uint32 MoverExecuteRange; //fieldtype: IntUnsigned
}

class CEffectReleaseMagazine
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
}

class CEffectRemoveBehavior
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	EClassIdCBehavior BehaviorClass; //enum
	CBehaviorLink BehaviorLink; //fieldtype: CatalogLink
	EEffectRemoveBehaviorAlignment BehaviorAlignment; //enum
	EBehaviorHeroicState Heroic; //enum
	CIdentifier StackAlias; //fieldtype: String
	bool8 KillHallucination; //fieldtype: Unknown
	bool8 MatchesAll; //fieldtype: Unknown
	uint32 Count; //fieldtype: IntUnsigned
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

class CEffectRemoveKinetic
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit ImpactUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CKineticLink KineticLink; //fieldtype: CatalogLink
}

class CEffectReturnMagazine
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CEffectLink MagazineEffect; //fieldtype: CatalogLink
}

class CEffectSet
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CEffectLink[] EffectArray; //fieldtype: CatalogLink
	bool8 Random; //fieldtype: Unknown
	bool8 RecycleCount; //fieldtype: Unknown
	bool8 SetSource; //fieldtype: Unknown
	SAccumulatedUInt32 MinCount //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	SAccumulatedUInt32 MaxCount //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	EEffectLocationType TargetLocationType; //enum
}

class CEffectSwitch
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectSwitchCase[] CaseArray //struct
	{
		CValidatorLink Validator; //fieldtype: CatalogLink
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FallThrough; //fieldtype: Unknown
	}
	CEffectLink CaseDefault; //fieldtype: CatalogLink
	EEffectLocationType TargetLocationType; //enum
}

class CEffectTeleport
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	bool8 ClearQueuedOrders; //fieldtype: Unknown
	CFixed MinDistance; //fieldtype: Fixed
	CFangleArc PlacementArc; //fieldtype: Fixed
	SEffectWhichLocation PlacementAround //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CFixed PlacementRange; //fieldtype: Fixed
	CFixed Range; //fieldtype: Fixed
	SEffectWhichLocation SourceLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichLocation TargetLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CFlags[] TeleportFlags; //fieldtype: Flags
	CEffectLink TeleportEffect; //fieldtype: CatalogLink
}

class CEffectTransferBehavior
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit LaunchUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	SEffectWhichUnit ImpactUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
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
	uint32 Count; //fieldtype: IntUnsigned
	bool8 Copy; //fieldtype: Unknown
	bool8 Preserve; //fieldtype: Unknown
}

class CEffectUseCalldown
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	uint32 CalldownCount; //fieldtype: IntUnsigned
	CEffectLink CalldownEffect; //fieldtype: CatalogLink
}

class CEffectUseMagazine
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CResponseFlags[] ResponseFlags; //fieldtype: Flags
	SEffectWhichUnit WhichUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CUnitLink AmmoUnit; //fieldtype: CatalogLink
	CEffectLink AmmoEffect; //fieldtype: CatalogLink
	CAbilLink MagazineAbil; //fieldtype: CatalogLink
	SEffectWhichLocation TargetLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
}

class CEffectUserData
{
	CStringLink Name; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] PreloadValidatorArray; //fieldtype: CatalogLink
	TEditorCategories EditorCategories; //fieldtype: String
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CNotifyAreaFlags[] AINotifyFlags; //fieldtype: Flags
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFixed Chance; //fieldtype: Fixed
	CAlertLink Alert; //fieldtype: CatalogLink
	SEffectWhichUnit DamageModifierSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EEffectHistory CasterHistory; //enum
	bool8 CanBeBlocked; //fieldtype: Unknown
	bool8 DebugTrace; //fieldtype: Unknown
	SEffectWhichPlayer OwningPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CIdentifier Key; //fieldtype: String
	SAccumulatedFixed Amount //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CIdentifier SourceKey; //fieldtype: String
	CFixed SourceFailBackValue; //fieldtype: Fixed
	EUpgradeOperation Operation; //enum
	SAccumulatedFixed ValidateMin //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	SAccumulatedFixed ValidateMax //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CEffectLink EffectSuccess; //fieldtype: CatalogLink
	CEffectLink EffectFailure; //fieldtype: CatalogLink
	EEffectLocationType TargetLocationType; //enum
	SEffectWhichBehavior BehaviorScope //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
		CBehaviorLink Behavior; //fieldtype: CatalogLink
	}
}
