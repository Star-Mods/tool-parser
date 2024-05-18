
class CWeapon
{
	CStringLink Name; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink Tip; //fieldtype: String
	CFlags[] Options; //fieldtype: Flags
	CImagePath Icon; //fieldtype: String
	CEffectLink DisplayEffect; //fieldtype: CatalogLink
	uint32 DisplayAttackCount; //fieldtype: IntUnsigned
	CStringLink DisplayName; //fieldtype: String
	uint32 Level; //fieldtype: IntUnsigned
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CTargetFilters ChaseFilters; //fieldtype: Unknown
	CTargetFilters SupportedFilters; //fieldtype: Unknown
	CTargetFilters AcquireFilters; //fieldtype: Unknown
	CTargetFilters AcquireCallForHelpFilters; //fieldtype: Unknown
	CTargetFilters AcquireProvokeFilters; //fieldtype: Unknown
	CTargetFilters AcquireScanFilters; //fieldtype: Unknown
	STargetSorts AcquireTargetSorts //struct
	{
		CTargetSortLink[] SortArray; //fieldtype: CatalogLink
		uint32 RequestCount; //fieldtype: IntUnsigned
		CFixed RequestPercentage; //fieldtype: Fixed
	}
	EWeaponPrioritization AcquirePrioritization; //enum
	CfRange AcquireCliffLevelRange; //fieldtype: Unknown
	CFixed MinScanRange; //fieldtype: Fixed
	CFixed Range; //fieldtype: Fixed
	CFixed RangeSlop; //fieldtype: Fixed
	CFlagArray<e_equipmentDisplayFlagCount>[] RangeDisplayFlags; //fieldtype: Flags
	CFixed MinimumRange; //fieldtype: Fixed
	CFixed TeleportResetRange; //fieldtype: Fixed
	CFangleArc Arc; //fieldtype: Fixed
	CFangleArc ArcSlop; //fieldtype: Fixed
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
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
	CGameTime Period; //fieldtype: Fixed
	CFlagArray<e_equipmentDisplayFlagCount>[] PeriodDisplayFlags; //fieldtype: Flags
	CFixed RateMultiplier; //fieldtype: Fixed
	EAttackType AttackType; //fieldtype: Unknown
	CGameTime DamagePoint; //fieldtype: Fixed
	CGameTime PreswingBeforeAttack; //fieldtype: Fixed
	CGameTime PreswingBetweenAttacks; //fieldtype: Fixed
	CGameTime Backswing; //fieldtype: Fixed
	CEffectLink Effect; //fieldtype: CatalogLink
	CEffectLink PreEffect; //fieldtype: CatalogLink
	SEffectBehavior PreEffectBehavior //struct
	{
		CBehaviorLink Behavior; //fieldtype: CatalogLink
		uint32 Count; //fieldtype: IntUnsigned
		CFlags[] Flags; //fieldtype: Flags
		CGameTime Duration; //fieldtype: Fixed
	}
	SEffectBehavior PostEffectBehavior //struct
	{
		CBehaviorLink Behavior; //fieldtype: CatalogLink
		uint32 Count; //fieldtype: IntUnsigned
		CFlags[] Flags; //fieldtype: Flags
		CGameTime Duration; //fieldtype: Fixed
	}
	CFixed CriticalChance; //fieldtype: Fixed
	CEffectLink CriticalEffect; //fieldtype: CatalogLink
	ECursorRangeMode CursorRangeMode; //enum
}

class CWeaponLegacy
{
	CStringLink Name; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink Tip; //fieldtype: String
	CFlags[] Options; //fieldtype: Flags
	CImagePath Icon; //fieldtype: String
	CEffectLink DisplayEffect; //fieldtype: CatalogLink
	uint32 DisplayAttackCount; //fieldtype: IntUnsigned
	CStringLink DisplayName; //fieldtype: String
	uint32 Level; //fieldtype: IntUnsigned
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CTargetFilters ChaseFilters; //fieldtype: Unknown
	CTargetFilters SupportedFilters; //fieldtype: Unknown
	CTargetFilters AcquireFilters; //fieldtype: Unknown
	CTargetFilters AcquireCallForHelpFilters; //fieldtype: Unknown
	CTargetFilters AcquireProvokeFilters; //fieldtype: Unknown
	CTargetFilters AcquireScanFilters; //fieldtype: Unknown
	STargetSorts AcquireTargetSorts //struct
	{
		CTargetSortLink[] SortArray; //fieldtype: CatalogLink
		uint32 RequestCount; //fieldtype: IntUnsigned
		CFixed RequestPercentage; //fieldtype: Fixed
	}
	EWeaponPrioritization AcquirePrioritization; //enum
	CfRange AcquireCliffLevelRange; //fieldtype: Unknown
	CFixed MinScanRange; //fieldtype: Fixed
	CFixed Range; //fieldtype: Fixed
	CFixed RangeSlop; //fieldtype: Fixed
	CFlagArray<e_equipmentDisplayFlagCount>[] RangeDisplayFlags; //fieldtype: Flags
	CFixed MinimumRange; //fieldtype: Fixed
	CFixed TeleportResetRange; //fieldtype: Fixed
	CFangleArc Arc; //fieldtype: Fixed
	CFangleArc ArcSlop; //fieldtype: Fixed
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
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
	CGameTime Period; //fieldtype: Fixed
	CFlagArray<e_equipmentDisplayFlagCount>[] PeriodDisplayFlags; //fieldtype: Flags
	CFixed RateMultiplier; //fieldtype: Fixed
	EAttackType AttackType; //fieldtype: Unknown
	CGameTime DamagePoint; //fieldtype: Fixed
	CGameTime PreswingBeforeAttack; //fieldtype: Fixed
	CGameTime PreswingBetweenAttacks; //fieldtype: Fixed
	CGameTime Backswing; //fieldtype: Fixed
	CEffectLink Effect; //fieldtype: CatalogLink
	CEffectLink PreEffect; //fieldtype: CatalogLink
	SEffectBehavior PreEffectBehavior //struct
	{
		CBehaviorLink Behavior; //fieldtype: CatalogLink
		uint32 Count; //fieldtype: IntUnsigned
		CFlags[] Flags; //fieldtype: Flags
		CGameTime Duration; //fieldtype: Fixed
	}
	SEffectBehavior PostEffectBehavior //struct
	{
		CBehaviorLink Behavior; //fieldtype: CatalogLink
		uint32 Count; //fieldtype: IntUnsigned
		CFlags[] Flags; //fieldtype: Flags
		CGameTime Duration; //fieldtype: Fixed
	}
	CFixed CriticalChance; //fieldtype: Fixed
	CEffectLink CriticalEffect; //fieldtype: CatalogLink
	ECursorRangeMode CursorRangeMode; //enum
	CFlags[] LegacyOptions; //fieldtype: Flags
	EWeaponLegacyMovement AllowedMovement; //enum
	CUnitLink PathingAmmoUnit; //fieldtype: CatalogLink
	CGameTime ReloadDuration; //fieldtype: Fixed
	CGameTime RandomDelayMin; //fieldtype: Fixed
	CGameTime RandomDelayMax; //fieldtype: Fixed
	CGameTime UninterruptibleDelay; //fieldtype: Fixed
	CGameTime UninterruptibleDuration; //fieldtype: Fixed
}

class CWeaponStrafe
{
	CStringLink Name; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink Tip; //fieldtype: String
	CFlags[] Options; //fieldtype: Flags
	CImagePath Icon; //fieldtype: String
	CEffectLink DisplayEffect; //fieldtype: CatalogLink
	uint32 DisplayAttackCount; //fieldtype: IntUnsigned
	CStringLink DisplayName; //fieldtype: String
	uint32 Level; //fieldtype: IntUnsigned
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CTargetFilters ChaseFilters; //fieldtype: Unknown
	CTargetFilters SupportedFilters; //fieldtype: Unknown
	CTargetFilters AcquireFilters; //fieldtype: Unknown
	CTargetFilters AcquireCallForHelpFilters; //fieldtype: Unknown
	CTargetFilters AcquireProvokeFilters; //fieldtype: Unknown
	CTargetFilters AcquireScanFilters; //fieldtype: Unknown
	STargetSorts AcquireTargetSorts //struct
	{
		CTargetSortLink[] SortArray; //fieldtype: CatalogLink
		uint32 RequestCount; //fieldtype: IntUnsigned
		CFixed RequestPercentage; //fieldtype: Fixed
	}
	EWeaponPrioritization AcquirePrioritization; //enum
	CfRange AcquireCliffLevelRange; //fieldtype: Unknown
	CFixed MinScanRange; //fieldtype: Fixed
	CFixed Range; //fieldtype: Fixed
	CFixed RangeSlop; //fieldtype: Fixed
	CFlagArray<e_equipmentDisplayFlagCount>[] RangeDisplayFlags; //fieldtype: Flags
	CFixed MinimumRange; //fieldtype: Fixed
	CFixed TeleportResetRange; //fieldtype: Fixed
	CFangleArc Arc; //fieldtype: Fixed
	CFangleArc ArcSlop; //fieldtype: Fixed
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
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
	CGameTime Period; //fieldtype: Fixed
	CFlagArray<e_equipmentDisplayFlagCount>[] PeriodDisplayFlags; //fieldtype: Flags
	CFixed RateMultiplier; //fieldtype: Fixed
	EAttackType AttackType; //fieldtype: Unknown
	CGameTime DamagePoint; //fieldtype: Fixed
	CGameTime PreswingBeforeAttack; //fieldtype: Fixed
	CGameTime PreswingBetweenAttacks; //fieldtype: Fixed
	CGameTime Backswing; //fieldtype: Fixed
	CEffectLink Effect; //fieldtype: CatalogLink
	CEffectLink PreEffect; //fieldtype: CatalogLink
	SEffectBehavior PreEffectBehavior //struct
	{
		CBehaviorLink Behavior; //fieldtype: CatalogLink
		uint32 Count; //fieldtype: IntUnsigned
		CFlags[] Flags; //fieldtype: Flags
		CGameTime Duration; //fieldtype: Fixed
	}
	SEffectBehavior PostEffectBehavior //struct
	{
		CBehaviorLink Behavior; //fieldtype: CatalogLink
		uint32 Count; //fieldtype: IntUnsigned
		CFlags[] Flags; //fieldtype: Flags
		CGameTime Duration; //fieldtype: Fixed
	}
	CFixed CriticalChance; //fieldtype: Fixed
	CEffectLink CriticalEffect; //fieldtype: CatalogLink
	ECursorRangeMode CursorRangeMode; //enum
	CFixed LoiterInnerRadius; //fieldtype: Fixed
	CFixed LoiterRadius; //fieldtype: Fixed
}
