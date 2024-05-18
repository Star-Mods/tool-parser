
class CBehavior
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
}

class CBehaviorAttackModifier
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	SAccumulatedFixed Chance //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CIdentifier UniqueSetId; //fieldtype: String
	CFlags[] AttackModifierFlags; //fieldtype: Flags
	CFlags[] WeaponIndexEnableArray; //fieldtype: Flags
	CFlags[] WeaponIndexDisableArray; //fieldtype: Flags
	uint32 MaxStackCount; //fieldtype: IntUnsigned
	SAccumulatedFixed[] DamageDealtScaled //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	SAccumulatedFixed[] DamageDealtFraction //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	SAccumulatedFixed[] DamageDealtUnscaled //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	SAccumulatedFixed[] DamageTotalMultiplier //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CEffectLink PreImpactEffect; //fieldtype: CatalogLink
	CEffectLink ImpactDamageInheritEffect; //fieldtype: CatalogLink
	CEffectLink MultishotSearchPattern; //fieldtype: CatalogLink
}

class CBehaviorAttribute
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	CStringLink PrimaryName; //fieldtype: String
	CStringLink PrimaryTooltip; //fieldtype: String
	int32 MinPoints; //fieldtype: IntSigned
	int32 MaxPoints; //fieldtype: IntSigned
	SModification Modification //struct
	{
		CFlagArray<e_behaviorModifyCount>[] ModifyFlags; //fieldtype: Flags
		CFlagArray<e_behaviorStateCount>[] StateFlags; //fieldtype: Flags
		TAttackTargetPriority AttackTargetPriority; //fieldtype: IntSigned
		CFixed RadiusMultiplier; //fieldtype: Fixed
		CFixed Height; //fieldtype: Fixed
		CGameTime[] HeightTime; //fieldtype: Fixed
		CFixed SightBonus; //fieldtype: Fixed
		CFixed SightMaximum; //fieldtype: Fixed
		CFixed SightMinimum; //fieldtype: Fixed
		int32 QueueCount; //fieldtype: IntSigned
		int32 QueueSize; //fieldtype: IntSigned
		CFixed TimeScale; //fieldtype: Fixed
		CFixed HealDealtMultiplier; //fieldtype: Fixed
		CFixed HealTakenMultiplier; //fieldtype: Fixed
		CFixed HealDealtAdditiveMultiplier; //fieldtype: Fixed
		CFixed HealTakenAdditiveMultiplier; //fieldtype: Fixed
		CGameSpeed MoveSpeedBaseMaximumBonus; //fieldtype: Fixed
		CGameSpeed MoveSpeedMaximum; //fieldtype: Fixed
		CGameSpeed MoveSpeedMinimum; //fieldtype: Fixed
		CGameSpeed MoveSpeedBonus; //fieldtype: Fixed
		CFixed MoveSpeedMultiplier; //fieldtype: Fixed
		CFixed UnifiedMoveSpeedFactor; //fieldtype: Fixed
		SAccumulatedFixed AdditiveMoveSpeedFactor //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CGameAcceleration AccelerationBonus; //fieldtype: Fixed
		CFixed AccelerationMultiplier; //fieldtype: Fixed
		CGameAcceleration DecelerationBonus; //fieldtype: Fixed
		CFixed DecelerationMultiplier; //fieldtype: Fixed
		CFixed SnareMultiplier; //fieldtype: Fixed
		CFixed AttackSpeedMultiplier; //fieldtype: Fixed
		CFixed UnifiedAttackSpeedFactor; //fieldtype: Fixed
		SAccumulatedFixed AdditiveAttackSpeedFactor //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CFixed WeaponRange; //fieldtype: Fixed
		CFixed MeleeWeaponRange; //fieldtype: Fixed
		CFixed RangedWeaponRange; //fieldtype: Fixed
		CFixed WeaponMinRange; //fieldtype: Fixed
		CFixed[] DamageDealtScaled; //fieldtype: Fixed
		SAccumulatedFixed[] DamageDealtFraction //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		SAccumulatedFixed[] DamageDealtUnscaled //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CFixed[] DamageDealtMaximum; //fieldtype: Fixed
		CFixed[] DamageDealtMinimum; //fieldtype: Fixed
		CFixed[] DamageDealtAttributeScaled; //fieldtype: Fixed
		CFixed[] DamageDealtAttributeMultiplier; //fieldtype: Fixed
		CFixed[] DamageDealtAttributeUnscaled; //fieldtype: Fixed
		CFixed[] DamageTakenScaled; //fieldtype: Fixed
		CFixed[] DamageTakenFraction; //fieldtype: Fixed
		CFixed[] DamageTakenUnscaled; //fieldtype: Fixed
		CFixed[] DamageTakenMaximum; //fieldtype: Fixed
		CFixed[] DamageTakenMinimum; //fieldtype: Fixed
		CFixed[] DamageTotalMultiplier; //fieldtype: Fixed
		CFixed[] UnifiedDamageDealtFraction; //fieldtype: Fixed
		CFixed[] UnifiedDamageTakenFraction; //fieldtype: Fixed
		SAccumulatedFixed LifeArmorBonus //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CFixed LifeArmorMultiplier; //fieldtype: Fixed
		CFixed ShieldArmorBonus; //fieldtype: Fixed
		CFixed ShieldArmorMultiplier; //fieldtype: Fixed
		CFixed EnergyArmorBonus; //fieldtype: Fixed
		CFixed EnergyArmorMultiplier; //fieldtype: Fixed
		CFixed ShieldDamageRatioBonus; //fieldtype: Fixed
		CFixed ShieldDamageRatioMultiplier; //fieldtype: Fixed
		SAccumulatedFixed EnergyDamageRatioBonus //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CFixed EnergyDamageRatioMultiplier; //fieldtype: Fixed
		uint32[] ResourceHarvestAmountBonus; //fieldtype: IntUnsigned
		CFixed[] ResourceHarvestAmountMultiplier; //fieldtype: Fixed
		CGameTime[] ResourceHarvestTimeBonus; //fieldtype: Fixed
		CFixed[] ResourceHarvestTimeMultiplier; //fieldtype: Fixed
		CFlagArray<e_unitVitalCount>[] VitalMaxIncreaseAffectsCurrentArray; //fieldtype: Flags
		CFlagArray<e_unitVitalCount>[] VitalMaxDecreaseAffectsCurrentArray; //fieldtype: Flags
		CFixed[] VitalMaxArray; //fieldtype: Fixed
		CFixed[] VitalMaxFractionArray; //fieldtype: Fixed
		CFixed[] VitalMaxAdditiveMultiplierArray; //fieldtype: Fixed
		SAccumulatedGameRate[] VitalRegenArray //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CFixed[] VitalRegenMultiplier; //fieldtype: Fixed
		SDamageKind[] VitalDamageGainArray //struct
		{
			CFixed[] KindArray; //fieldtype: Fixed
		}
		SScoreValueUpdate[] VitalDamageGainScoreArray //struct
		{
			CValidatorLink Validator; //fieldtype: CatalogLink
			CScoreValueLink Value; //fieldtype: CatalogLink
		}
		SDamageKind[] VitalDamageLeechArray //struct
		{
			CFixed[] KindArray; //fieldtype: Fixed
		}
		SScoreValueUpdate[] VitalDamageLeechScoreArray //struct
		{
			CValidatorLink Validator; //fieldtype: CatalogLink
			CScoreValueLink Value; //fieldtype: CatalogLink
		}
		SUnitResourceRatio[] ResourceDamageLeech //struct
		{
			CFixed[] Amount; //fieldtype: Fixed
		}
		CFlags[] AbilCategoriesEnable; //fieldtype: Flags
		CFlags[] AbilCategoriesDisable; //fieldtype: Flags
		CFlagArray<e_classIdCAbilCount>[] AbilClassEnableArray; //fieldtype: Flags
		CFlagArray<e_classIdCAbilCount>[] AbilClassDisableArray; //fieldtype: Flags
		TTechAlias[] AbilTechAliasEnableArray; //fieldtype: String
		TTechAlias[] AbilTechAliasDisableArray; //fieldtype: String
		CAbilLink[] AbilLinkEnableArray; //fieldtype: CatalogLink
		CAbilLink[] AbilLinkDisableArray; //fieldtype: CatalogLink
		CBehaviorCategoryFlags[] BehaviorCategoriesEnable; //fieldtype: Flags
		CBehaviorCategoryFlags[] BehaviorCategoriesDisable; //fieldtype: Flags
		CFixed[] BehaviorCategoryDurationFactor; //fieldtype: Fixed
		CFlagArray<e_classIdCBehaviorCount>[] BehaviorClassEnableArray; //fieldtype: Flags
		CFlagArray<e_classIdCBehaviorCount>[] BehaviorClassDisableArray; //fieldtype: Flags
		CBehaviorLink[] BehaviorLinkEnableArray; //fieldtype: CatalogLink
		CBehaviorLink[] BehaviorLinkDisableArray; //fieldtype: CatalogLink
		SUnitWeaponData[] WeaponArray //struct
		{
			CWeaponLink Link; //fieldtype: CatalogLink
			CTurretLink Turret; //fieldtype: CatalogLink
		}
		CFixed WeaponScanBonus; //fieldtype: Fixed
		CFixed WeaponScanLimit; //fieldtype: Fixed
		CWeaponLink[] WeaponEnableArray; //fieldtype: CatalogLink
		CWeaponLink[] WeaponDisableArray; //fieldtype: CatalogLink
		CTurretLink[] TurretEnableArray; //fieldtype: CatalogLink
		CTurretLink[] TurretDisableArray; //fieldtype: CatalogLink
		CSoundLink[] SoundArray; //fieldtype: CatalogLink
		CFixed Detect; //fieldtype: Fixed
		CFangleArc DetectArc; //fieldtype: Fixed
		CFixed DetectBonus; //fieldtype: Fixed
		CTargetFilters DetectFilters; //fieldtype: Unknown
		CFixed Radar; //fieldtype: Fixed
		CFangleArc RadarArc; //fieldtype: Fixed
		CTargetFilters RadarFilters; //fieldtype: Unknown
		CFixed Food; //fieldtype: Fixed
		SAttributeChange[] AttributeChangeArray //struct
		{
			CBehaviorLink Attribute; //fieldtype: CatalogLink
			int32 Points; //fieldtype: IntSigned
		}
		CFixed[] RateMultiplierArray; //fieldtype: Fixed
		SDeathResponse DeathResponse //struct
		{
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
			CEffectLink Effect; //fieldtype: CatalogLink
			CFlagArray<e_playerRelationshipCount>[] Relationship; //fieldtype: Flags
			CFlagArray<e_deathTypeCount>[] Type; //fieldtype: Flags
		}
		int8[] PlaneDelta; //fieldtype: IntSigned
		int32 ScoreKillBonus; //fieldtype: IntSigned
		int32 ScoreLostBonus; //fieldtype: IntSigned
		int16 SubgroupPriority; //fieldtype: IntSigned
		CStringLink UnitNameOverride; //fieldtype: String
		CFixed XPMultiplier; //fieldtype: Fixed
		CFixed XPScaledBonus; //fieldtype: Fixed
		CFixed XPUnscaledBonus; //fieldtype: Fixed
		int32 KillXPBonus; //fieldtype: IntSigned
		CFixed CriticalAttackChanceMultiplier; //fieldtype: Fixed
		CFixed CriticalAttackChanceScaledBonus; //fieldtype: Fixed
		CFixed CriticalAttackChanceUnscaledBonus; //fieldtype: Fixed
	}
	CEffectLink PointGainEffect; //fieldtype: CatalogLink
	CEffectLink PointLossEffect; //fieldtype: CatalogLink
	CFlagArray<e_equipmentDisplayFlagCount>[] PointDisplayFlags; //fieldtype: Flags
}

class CBehaviorUnitTracker
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	CValidatorLink[] TrackingValidatorArray; //fieldtype: CatalogLink
	uint32 MaxTrackedUnits; //fieldtype: IntUnsigned
	EBehaviorUnitTrackerAtMaxRule UnitAddedAtMaxRule; //fieldtype: Unknown
	CEffectLink ReplacedEffect; //fieldtype: CatalogLink
	CFlags[] UnitTrackerFlags; //fieldtype: Flags
	SEffectWhichLocation WhichLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CFixed SnapRange; //fieldtype: Fixed
	SAccumulatedUInt32 SnapCount //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	EBehaviorUnitTrackerSnapRule SnapRule; //fieldtype: Unknown
	CFangle SnapAngleAdjustment; //fieldtype: Fixed
	SEffectWhichPlayer SharedListPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
}

class CBehaviorBuff
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] DisplayDuration; //fieldtype: Flags
	CFlags[] DisplayShield; //fieldtype: Flags
	CValidatorLink[] DisableValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] RemoveValidatorArray; //fieldtype: CatalogLink
	CFlags[] BuffFlags; //fieldtype: Flags
	uint32 MaxStackCount; //fieldtype: IntUnsigned
	uint32 MaxStackCountPerCaster; //fieldtype: IntUnsigned
	SEffectWhichTimeScale TimeScaleSource //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectTimeScale Value; //enum
	}
	SAccumulatedGameTime Duration //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	SBehaviorDuration[] DurationOverride //struct
	{
		SAccumulatedGameTime Duration //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	}
	CGameTime DurationShield; //fieldtype: Fixed
	CGameTime[] DurationVitalArray; //fieldtype: Fixed
	CGameTime[] DurationVitalMaxArray; //fieldtype: Fixed
	CGameTime DurationRandomMin; //fieldtype: Fixed
	CGameTime DurationRandomMax; //fieldtype: Fixed
	CGameTime DurationBonusMin; //fieldtype: Fixed
	CGameTime DurationBonusMax; //fieldtype: Fixed
	CGameTime Period; //fieldtype: Fixed
	uint32 PeriodCount; //fieldtype: IntUnsigned
	CEffectLink InitialEffect; //fieldtype: CatalogLink
	CEffectLink RefreshEffect; //fieldtype: CatalogLink
	CEffectLink PeriodicEffect; //fieldtype: CatalogLink
	SAccumulatedFixed PeriodicEffectRateMultiplier //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	CEffectLink[] PeriodicDisplayEffect; //fieldtype: CatalogLink
	CEffectLink FinalEffect; //fieldtype: CatalogLink
	CEffectLink ExpireEffect; //fieldtype: CatalogLink
	SEffectWhichPlayer Player //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SEffectWhichPlayer AcquirePlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	SModification Modification //struct
	{
		CFlagArray<e_behaviorModifyCount>[] ModifyFlags; //fieldtype: Flags
		CFlagArray<e_behaviorStateCount>[] StateFlags; //fieldtype: Flags
		TAttackTargetPriority AttackTargetPriority; //fieldtype: IntSigned
		CFixed RadiusMultiplier; //fieldtype: Fixed
		CFixed Height; //fieldtype: Fixed
		CGameTime[] HeightTime; //fieldtype: Fixed
		CFixed SightBonus; //fieldtype: Fixed
		CFixed SightMaximum; //fieldtype: Fixed
		CFixed SightMinimum; //fieldtype: Fixed
		int32 QueueCount; //fieldtype: IntSigned
		int32 QueueSize; //fieldtype: IntSigned
		CFixed TimeScale; //fieldtype: Fixed
		CFixed HealDealtMultiplier; //fieldtype: Fixed
		CFixed HealTakenMultiplier; //fieldtype: Fixed
		CFixed HealDealtAdditiveMultiplier; //fieldtype: Fixed
		CFixed HealTakenAdditiveMultiplier; //fieldtype: Fixed
		CGameSpeed MoveSpeedBaseMaximumBonus; //fieldtype: Fixed
		CGameSpeed MoveSpeedMaximum; //fieldtype: Fixed
		CGameSpeed MoveSpeedMinimum; //fieldtype: Fixed
		CGameSpeed MoveSpeedBonus; //fieldtype: Fixed
		CFixed MoveSpeedMultiplier; //fieldtype: Fixed
		CFixed UnifiedMoveSpeedFactor; //fieldtype: Fixed
		SAccumulatedFixed AdditiveMoveSpeedFactor //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CGameAcceleration AccelerationBonus; //fieldtype: Fixed
		CFixed AccelerationMultiplier; //fieldtype: Fixed
		CGameAcceleration DecelerationBonus; //fieldtype: Fixed
		CFixed DecelerationMultiplier; //fieldtype: Fixed
		CFixed SnareMultiplier; //fieldtype: Fixed
		CFixed AttackSpeedMultiplier; //fieldtype: Fixed
		CFixed UnifiedAttackSpeedFactor; //fieldtype: Fixed
		SAccumulatedFixed AdditiveAttackSpeedFactor //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CFixed WeaponRange; //fieldtype: Fixed
		CFixed MeleeWeaponRange; //fieldtype: Fixed
		CFixed RangedWeaponRange; //fieldtype: Fixed
		CFixed WeaponMinRange; //fieldtype: Fixed
		CFixed[] DamageDealtScaled; //fieldtype: Fixed
		SAccumulatedFixed[] DamageDealtFraction //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		SAccumulatedFixed[] DamageDealtUnscaled //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CFixed[] DamageDealtMaximum; //fieldtype: Fixed
		CFixed[] DamageDealtMinimum; //fieldtype: Fixed
		CFixed[] DamageDealtAttributeScaled; //fieldtype: Fixed
		CFixed[] DamageDealtAttributeMultiplier; //fieldtype: Fixed
		CFixed[] DamageDealtAttributeUnscaled; //fieldtype: Fixed
		CFixed[] DamageTakenScaled; //fieldtype: Fixed
		CFixed[] DamageTakenFraction; //fieldtype: Fixed
		CFixed[] DamageTakenUnscaled; //fieldtype: Fixed
		CFixed[] DamageTakenMaximum; //fieldtype: Fixed
		CFixed[] DamageTakenMinimum; //fieldtype: Fixed
		CFixed[] DamageTotalMultiplier; //fieldtype: Fixed
		CFixed[] UnifiedDamageDealtFraction; //fieldtype: Fixed
		CFixed[] UnifiedDamageTakenFraction; //fieldtype: Fixed
		SAccumulatedFixed LifeArmorBonus //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CFixed LifeArmorMultiplier; //fieldtype: Fixed
		CFixed ShieldArmorBonus; //fieldtype: Fixed
		CFixed ShieldArmorMultiplier; //fieldtype: Fixed
		CFixed EnergyArmorBonus; //fieldtype: Fixed
		CFixed EnergyArmorMultiplier; //fieldtype: Fixed
		CFixed ShieldDamageRatioBonus; //fieldtype: Fixed
		CFixed ShieldDamageRatioMultiplier; //fieldtype: Fixed
		SAccumulatedFixed EnergyDamageRatioBonus //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CFixed EnergyDamageRatioMultiplier; //fieldtype: Fixed
		uint32[] ResourceHarvestAmountBonus; //fieldtype: IntUnsigned
		CFixed[] ResourceHarvestAmountMultiplier; //fieldtype: Fixed
		CGameTime[] ResourceHarvestTimeBonus; //fieldtype: Fixed
		CFixed[] ResourceHarvestTimeMultiplier; //fieldtype: Fixed
		CFlagArray<e_unitVitalCount>[] VitalMaxIncreaseAffectsCurrentArray; //fieldtype: Flags
		CFlagArray<e_unitVitalCount>[] VitalMaxDecreaseAffectsCurrentArray; //fieldtype: Flags
		CFixed[] VitalMaxArray; //fieldtype: Fixed
		CFixed[] VitalMaxFractionArray; //fieldtype: Fixed
		CFixed[] VitalMaxAdditiveMultiplierArray; //fieldtype: Fixed
		SAccumulatedGameRate[] VitalRegenArray //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CFixed[] VitalRegenMultiplier; //fieldtype: Fixed
		SDamageKind[] VitalDamageGainArray //struct
		{
			CFixed[] KindArray; //fieldtype: Fixed
		}
		SScoreValueUpdate[] VitalDamageGainScoreArray //struct
		{
			CValidatorLink Validator; //fieldtype: CatalogLink
			CScoreValueLink Value; //fieldtype: CatalogLink
		}
		SDamageKind[] VitalDamageLeechArray //struct
		{
			CFixed[] KindArray; //fieldtype: Fixed
		}
		SScoreValueUpdate[] VitalDamageLeechScoreArray //struct
		{
			CValidatorLink Validator; //fieldtype: CatalogLink
			CScoreValueLink Value; //fieldtype: CatalogLink
		}
		SUnitResourceRatio[] ResourceDamageLeech //struct
		{
			CFixed[] Amount; //fieldtype: Fixed
		}
		CFlags[] AbilCategoriesEnable; //fieldtype: Flags
		CFlags[] AbilCategoriesDisable; //fieldtype: Flags
		CFlagArray<e_classIdCAbilCount>[] AbilClassEnableArray; //fieldtype: Flags
		CFlagArray<e_classIdCAbilCount>[] AbilClassDisableArray; //fieldtype: Flags
		TTechAlias[] AbilTechAliasEnableArray; //fieldtype: String
		TTechAlias[] AbilTechAliasDisableArray; //fieldtype: String
		CAbilLink[] AbilLinkEnableArray; //fieldtype: CatalogLink
		CAbilLink[] AbilLinkDisableArray; //fieldtype: CatalogLink
		CBehaviorCategoryFlags[] BehaviorCategoriesEnable; //fieldtype: Flags
		CBehaviorCategoryFlags[] BehaviorCategoriesDisable; //fieldtype: Flags
		CFixed[] BehaviorCategoryDurationFactor; //fieldtype: Fixed
		CFlagArray<e_classIdCBehaviorCount>[] BehaviorClassEnableArray; //fieldtype: Flags
		CFlagArray<e_classIdCBehaviorCount>[] BehaviorClassDisableArray; //fieldtype: Flags
		CBehaviorLink[] BehaviorLinkEnableArray; //fieldtype: CatalogLink
		CBehaviorLink[] BehaviorLinkDisableArray; //fieldtype: CatalogLink
		SUnitWeaponData[] WeaponArray //struct
		{
			CWeaponLink Link; //fieldtype: CatalogLink
			CTurretLink Turret; //fieldtype: CatalogLink
		}
		CFixed WeaponScanBonus; //fieldtype: Fixed
		CFixed WeaponScanLimit; //fieldtype: Fixed
		CWeaponLink[] WeaponEnableArray; //fieldtype: CatalogLink
		CWeaponLink[] WeaponDisableArray; //fieldtype: CatalogLink
		CTurretLink[] TurretEnableArray; //fieldtype: CatalogLink
		CTurretLink[] TurretDisableArray; //fieldtype: CatalogLink
		CSoundLink[] SoundArray; //fieldtype: CatalogLink
		CFixed Detect; //fieldtype: Fixed
		CFangleArc DetectArc; //fieldtype: Fixed
		CFixed DetectBonus; //fieldtype: Fixed
		CTargetFilters DetectFilters; //fieldtype: Unknown
		CFixed Radar; //fieldtype: Fixed
		CFangleArc RadarArc; //fieldtype: Fixed
		CTargetFilters RadarFilters; //fieldtype: Unknown
		CFixed Food; //fieldtype: Fixed
		SAttributeChange[] AttributeChangeArray //struct
		{
			CBehaviorLink Attribute; //fieldtype: CatalogLink
			int32 Points; //fieldtype: IntSigned
		}
		CFixed[] RateMultiplierArray; //fieldtype: Fixed
		SDeathResponse DeathResponse //struct
		{
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
			CEffectLink Effect; //fieldtype: CatalogLink
			CFlagArray<e_playerRelationshipCount>[] Relationship; //fieldtype: Flags
			CFlagArray<e_deathTypeCount>[] Type; //fieldtype: Flags
		}
		int8[] PlaneDelta; //fieldtype: IntSigned
		int32 ScoreKillBonus; //fieldtype: IntSigned
		int32 ScoreLostBonus; //fieldtype: IntSigned
		int16 SubgroupPriority; //fieldtype: IntSigned
		CStringLink UnitNameOverride; //fieldtype: String
		CFixed XPMultiplier; //fieldtype: Fixed
		CFixed XPScaledBonus; //fieldtype: Fixed
		CFixed XPUnscaledBonus; //fieldtype: Fixed
		int32 KillXPBonus; //fieldtype: IntSigned
		CFixed CriticalAttackChanceMultiplier; //fieldtype: Fixed
		CFixed CriticalAttackChanceScaledBonus; //fieldtype: Fixed
		CFixed CriticalAttackChanceUnscaledBonus; //fieldtype: Fixed
	}
	EDeathType DeathType; //enum
	CEffectLink AINotifyEffect; //fieldtype: CatalogLink
	SDamageResponse DamageResponse //struct
	{
		CFixed ClampMaximum; //fieldtype: Fixed
		CFixed ClampMinimum; //fieldtype: Fixed
		CEffectLink Exhausted; //fieldtype: CatalogLink
		bool8 Evade; //fieldtype: Unknown
		bool8 Fatal; //fieldtype: Unknown
		CEffectLink Handled; //fieldtype: CatalogLink
		CFixed[] Ignore; //fieldtype: Fixed
		CFlagArray<e_damageKindCount>[] Kind; //fieldtype: Flags
		EDamageLocation Location; //enum
		CFixed Maximum; //fieldtype: Fixed
		CFixed Minimum; //fieldtype: Fixed
		SAccumulatedFixed ModifyAmount //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CFixed ModifyFraction; //fieldtype: Fixed
		CFixed ModifyLimit; //fieldtype: Fixed
		CFixed[] ModifyLimitVitalMaxFractionArray; //fieldtype: Fixed
		bool8 ModifyMinimumDamage; //fieldtype: Unknown
		CTargetFilters TargetFilters; //fieldtype: Unknown
		CEffectLink[] RequireEffectArray; //fieldtype: CatalogLink
		CEffectLink[] ExcludeEffectArray; //fieldtype: CatalogLink
		CEffectLink[] RequireEffectInChainArray; //fieldtype: CatalogLink
		CEffectLink[] ExcludeEffectInChainArray; //fieldtype: CatalogLink
		CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
		EDamageResponseDamageValue DamageValue; //enum
		SScoreValueUpdate[] ModifyScoreArray //struct
		{
			CValidatorLink Validator; //fieldtype: CatalogLink
			CScoreValueLink Value; //fieldtype: CatalogLink
		}
		int8 Priority; //fieldtype: IntSigned
		CFlagArray<e_damageResponseCategoryCount>[] ProvideCategories; //fieldtype: Flags
		CFlagArray<e_damageResponseCategoryCount>[] PreventCategories; //fieldtype: Flags
		SAccumulatedFixed BlockChance //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		SAccumulatedFixed DeflectChance //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		SAccumulatedFixed MissingChance //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		SAccumulatedFixed Chance //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
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
		CFlagArray<e_attackTypeResponseCount>[] AttackType; //fieldtype: Flags
		CFlagArray<e_damageTypeResponseCount>[] DamageType; //fieldtype: Flags
		EDamageResponseHandledValue HandledValue; //enum
	}
	SEffectWhichUnit KillCredit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	EBehaviorBuffReplace Replace; //enum
	SEffectWhichLocation ReplaceLocation //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
	CHerdNodeLink HerdNode; //fieldtype: CatalogLink
	SVitalRegenVitalRemain[] VitalRegenVitalsRemain //struct
	{
		CFixed AmountMissing; //fieldtype: Fixed
		CGameRate RegenModification; //fieldtype: Fixed
	}
	SVitalRegenVitalRemain[] VitalRegenVitalsRemainPercent //struct
	{
		CFixed AmountMissing; //fieldtype: Fixed
		CGameRate RegenModification; //fieldtype: Fixed
	}
	SEffectWhichUnit RevealUnit //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectUnit Value; //enum
		EEffectHistory History; //enum
	}
	CIdentifier StackAlias; //fieldtype: String
	uint32 StackAliasPriority; //fieldtype: IntUnsigned
}

class CBehaviorClickResponse
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	CFixed Chance; //fieldtype: Fixed
	uint32 Count; //fieldtype: IntUnsigned
	CGameTime CountDelay; //fieldtype: Fixed
	CEffectLink CountEffect; //fieldtype: CatalogLink
	CFlagArray<e_playerRelationshipCount>[] Relationship; //fieldtype: Flags
	CGameTime ResetDelay; //fieldtype: Fixed
	CEffectLink ResetEffect; //fieldtype: CatalogLink
}

class CBehaviorConjoined
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] ConjoinedFlags; //fieldtype: Flags
	CFixed Radius; //fieldtype: Fixed
}

class CBehaviorCreepSource
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	CGameTime Delay; //fieldtype: Fixed
	CGameTime Period; //fieldtype: Fixed
	CFootprintLink Build; //fieldtype: CatalogLink
	CFootprintLink Start; //fieldtype: CatalogLink
	CFootprintLink Birth; //fieldtype: CatalogLink
	CFootprintLink Grown; //fieldtype: CatalogLink
	CValidatorLink[] DisableValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] RemoveValidatorArray; //fieldtype: CatalogLink
}

class CBehaviorJump
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	CFixed TriggerHeightDeltaMin; //fieldtype: Fixed
	CFixed TriggerHeightDeltaMax; //fieldtype: Fixed
	CFixed InitiateRangeUp; //fieldtype: Fixed
	CFixed InitiateRangeDown; //fieldtype: Fixed
	CFixed JumpRangeMax; //fieldtype: Fixed
	CEffectLink JumpEffectUp; //fieldtype: CatalogLink
	CEffectLink JumpEffectDown; //fieldtype: CatalogLink
	CMoverLink Mover; //fieldtype: CatalogLink
	CMoverLink MoverUp; //fieldtype: CatalogLink
	CMoverLink MoverDown; //fieldtype: CatalogLink
	CGameTime DurationPreLaunch; //fieldtype: Fixed
	CGameTime DurationPostLand; //fieldtype: Fixed
	CGameTime DurationMoveOut; //fieldtype: Fixed
	CUnitLink Placeholder; //fieldtype: CatalogLink
	CFixed LandAdjustmentUp; //fieldtype: Fixed
	CFixed LandAdjustmentDown; //fieldtype: Fixed
	CFixed LandArrivalRange; //fieldtype: Fixed
	CFixed LandCheckRadius; //fieldtype: Fixed
	CEffectLink LandEffectUp; //fieldtype: CatalogLink
	CEffectLink LandEffectDown; //fieldtype: CatalogLink
}

class CBehaviorPowerSource
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	TPowerLevel PowerLevel; //fieldtype: IntUnsigned
	CFixed Radius; //fieldtype: Fixed
	TPowerLink PowerLink; //fieldtype: String
	CFlagArray<e_cliffLevelCompareCount>[] CliffLevelFlags; //fieldtype: Flags
	CFlags[] Flags; //fieldtype: Flags
}

class CBehaviorPowerUser
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	TPowerLink PowerLink; //fieldtype: String
	TPowerLevel PlacementMinPowerLevel; //fieldtype: IntUnsigned
	CFlags[] Flags; //fieldtype: Flags
	bool8 PoweredWhileUnderConstruction; //fieldtype: Unknown
	SPowerStage[] PowerStageArray //struct
	{
		uint32 MaxStackCount; //fieldtype: IntUnsigned
		TPowerLevel MinPowerLevel; //fieldtype: IntUnsigned
		SModification Modification //struct
		{
			CFlagArray<e_behaviorModifyCount>[] ModifyFlags; //fieldtype: Flags
			CFlagArray<e_behaviorStateCount>[] StateFlags; //fieldtype: Flags
			TAttackTargetPriority AttackTargetPriority; //fieldtype: IntSigned
			CFixed RadiusMultiplier; //fieldtype: Fixed
			CFixed Height; //fieldtype: Fixed
			CGameTime[] HeightTime; //fieldtype: Fixed
			CFixed SightBonus; //fieldtype: Fixed
			CFixed SightMaximum; //fieldtype: Fixed
			CFixed SightMinimum; //fieldtype: Fixed
			int32 QueueCount; //fieldtype: IntSigned
			int32 QueueSize; //fieldtype: IntSigned
			CFixed TimeScale; //fieldtype: Fixed
			CFixed HealDealtMultiplier; //fieldtype: Fixed
			CFixed HealTakenMultiplier; //fieldtype: Fixed
			CFixed HealDealtAdditiveMultiplier; //fieldtype: Fixed
			CFixed HealTakenAdditiveMultiplier; //fieldtype: Fixed
			CGameSpeed MoveSpeedBaseMaximumBonus; //fieldtype: Fixed
			CGameSpeed MoveSpeedMaximum; //fieldtype: Fixed
			CGameSpeed MoveSpeedMinimum; //fieldtype: Fixed
			CGameSpeed MoveSpeedBonus; //fieldtype: Fixed
			CFixed MoveSpeedMultiplier; //fieldtype: Fixed
			CFixed UnifiedMoveSpeedFactor; //fieldtype: Fixed
			SAccumulatedFixed AdditiveMoveSpeedFactor //struct
			{
				CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
			}
			CGameAcceleration AccelerationBonus; //fieldtype: Fixed
			CFixed AccelerationMultiplier; //fieldtype: Fixed
			CGameAcceleration DecelerationBonus; //fieldtype: Fixed
			CFixed DecelerationMultiplier; //fieldtype: Fixed
			CFixed SnareMultiplier; //fieldtype: Fixed
			CFixed AttackSpeedMultiplier; //fieldtype: Fixed
			CFixed UnifiedAttackSpeedFactor; //fieldtype: Fixed
			SAccumulatedFixed AdditiveAttackSpeedFactor //struct
			{
				CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
			}
			CFixed WeaponRange; //fieldtype: Fixed
			CFixed MeleeWeaponRange; //fieldtype: Fixed
			CFixed RangedWeaponRange; //fieldtype: Fixed
			CFixed WeaponMinRange; //fieldtype: Fixed
			CFixed[] DamageDealtScaled; //fieldtype: Fixed
			SAccumulatedFixed[] DamageDealtFraction //struct
			{
				CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
			}
			SAccumulatedFixed[] DamageDealtUnscaled //struct
			{
				CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
			}
			CFixed[] DamageDealtMaximum; //fieldtype: Fixed
			CFixed[] DamageDealtMinimum; //fieldtype: Fixed
			CFixed[] DamageDealtAttributeScaled; //fieldtype: Fixed
			CFixed[] DamageDealtAttributeMultiplier; //fieldtype: Fixed
			CFixed[] DamageDealtAttributeUnscaled; //fieldtype: Fixed
			CFixed[] DamageTakenScaled; //fieldtype: Fixed
			CFixed[] DamageTakenFraction; //fieldtype: Fixed
			CFixed[] DamageTakenUnscaled; //fieldtype: Fixed
			CFixed[] DamageTakenMaximum; //fieldtype: Fixed
			CFixed[] DamageTakenMinimum; //fieldtype: Fixed
			CFixed[] DamageTotalMultiplier; //fieldtype: Fixed
			CFixed[] UnifiedDamageDealtFraction; //fieldtype: Fixed
			CFixed[] UnifiedDamageTakenFraction; //fieldtype: Fixed
			SAccumulatedFixed LifeArmorBonus //struct
			{
				CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
			}
			CFixed LifeArmorMultiplier; //fieldtype: Fixed
			CFixed ShieldArmorBonus; //fieldtype: Fixed
			CFixed ShieldArmorMultiplier; //fieldtype: Fixed
			CFixed EnergyArmorBonus; //fieldtype: Fixed
			CFixed EnergyArmorMultiplier; //fieldtype: Fixed
			CFixed ShieldDamageRatioBonus; //fieldtype: Fixed
			CFixed ShieldDamageRatioMultiplier; //fieldtype: Fixed
			SAccumulatedFixed EnergyDamageRatioBonus //struct
			{
				CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
			}
			CFixed EnergyDamageRatioMultiplier; //fieldtype: Fixed
			uint32[] ResourceHarvestAmountBonus; //fieldtype: IntUnsigned
			CFixed[] ResourceHarvestAmountMultiplier; //fieldtype: Fixed
			CGameTime[] ResourceHarvestTimeBonus; //fieldtype: Fixed
			CFixed[] ResourceHarvestTimeMultiplier; //fieldtype: Fixed
			CFlagArray<e_unitVitalCount>[] VitalMaxIncreaseAffectsCurrentArray; //fieldtype: Flags
			CFlagArray<e_unitVitalCount>[] VitalMaxDecreaseAffectsCurrentArray; //fieldtype: Flags
			CFixed[] VitalMaxArray; //fieldtype: Fixed
			CFixed[] VitalMaxFractionArray; //fieldtype: Fixed
			CFixed[] VitalMaxAdditiveMultiplierArray; //fieldtype: Fixed
			SAccumulatedGameRate[] VitalRegenArray //struct
			{
				CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
			}
			CFixed[] VitalRegenMultiplier; //fieldtype: Fixed
			SDamageKind[] VitalDamageGainArray //struct
			{
				CFixed[] KindArray; //fieldtype: Fixed
			}
			SScoreValueUpdate[] VitalDamageGainScoreArray //struct
			{
				CValidatorLink Validator; //fieldtype: CatalogLink
				CScoreValueLink Value; //fieldtype: CatalogLink
			}
			SDamageKind[] VitalDamageLeechArray //struct
			{
				CFixed[] KindArray; //fieldtype: Fixed
			}
			SScoreValueUpdate[] VitalDamageLeechScoreArray //struct
			{
				CValidatorLink Validator; //fieldtype: CatalogLink
				CScoreValueLink Value; //fieldtype: CatalogLink
			}
			SUnitResourceRatio[] ResourceDamageLeech //struct
			{
				CFixed[] Amount; //fieldtype: Fixed
			}
			CFlags[] AbilCategoriesEnable; //fieldtype: Flags
			CFlags[] AbilCategoriesDisable; //fieldtype: Flags
			CFlagArray<e_classIdCAbilCount>[] AbilClassEnableArray; //fieldtype: Flags
			CFlagArray<e_classIdCAbilCount>[] AbilClassDisableArray; //fieldtype: Flags
			TTechAlias[] AbilTechAliasEnableArray; //fieldtype: String
			TTechAlias[] AbilTechAliasDisableArray; //fieldtype: String
			CAbilLink[] AbilLinkEnableArray; //fieldtype: CatalogLink
			CAbilLink[] AbilLinkDisableArray; //fieldtype: CatalogLink
			CBehaviorCategoryFlags[] BehaviorCategoriesEnable; //fieldtype: Flags
			CBehaviorCategoryFlags[] BehaviorCategoriesDisable; //fieldtype: Flags
			CFixed[] BehaviorCategoryDurationFactor; //fieldtype: Fixed
			CFlagArray<e_classIdCBehaviorCount>[] BehaviorClassEnableArray; //fieldtype: Flags
			CFlagArray<e_classIdCBehaviorCount>[] BehaviorClassDisableArray; //fieldtype: Flags
			CBehaviorLink[] BehaviorLinkEnableArray; //fieldtype: CatalogLink
			CBehaviorLink[] BehaviorLinkDisableArray; //fieldtype: CatalogLink
			SUnitWeaponData[] WeaponArray //struct
			{
				CWeaponLink Link; //fieldtype: CatalogLink
				CTurretLink Turret; //fieldtype: CatalogLink
			}
			CFixed WeaponScanBonus; //fieldtype: Fixed
			CFixed WeaponScanLimit; //fieldtype: Fixed
			CWeaponLink[] WeaponEnableArray; //fieldtype: CatalogLink
			CWeaponLink[] WeaponDisableArray; //fieldtype: CatalogLink
			CTurretLink[] TurretEnableArray; //fieldtype: CatalogLink
			CTurretLink[] TurretDisableArray; //fieldtype: CatalogLink
			CSoundLink[] SoundArray; //fieldtype: CatalogLink
			CFixed Detect; //fieldtype: Fixed
			CFangleArc DetectArc; //fieldtype: Fixed
			CFixed DetectBonus; //fieldtype: Fixed
			CTargetFilters DetectFilters; //fieldtype: Unknown
			CFixed Radar; //fieldtype: Fixed
			CFangleArc RadarArc; //fieldtype: Fixed
			CTargetFilters RadarFilters; //fieldtype: Unknown
			CFixed Food; //fieldtype: Fixed
			SAttributeChange[] AttributeChangeArray //struct
			{
				CBehaviorLink Attribute; //fieldtype: CatalogLink
				int32 Points; //fieldtype: IntSigned
			}
			CFixed[] RateMultiplierArray; //fieldtype: Fixed
			SDeathResponse DeathResponse //struct
			{
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
				CEffectLink Effect; //fieldtype: CatalogLink
				CFlagArray<e_playerRelationshipCount>[] Relationship; //fieldtype: Flags
				CFlagArray<e_deathTypeCount>[] Type; //fieldtype: Flags
			}
			int8[] PlaneDelta; //fieldtype: IntSigned
			int32 ScoreKillBonus; //fieldtype: IntSigned
			int32 ScoreLostBonus; //fieldtype: IntSigned
			int16 SubgroupPriority; //fieldtype: IntSigned
			CStringLink UnitNameOverride; //fieldtype: String
			CFixed XPMultiplier; //fieldtype: Fixed
			CFixed XPScaledBonus; //fieldtype: Fixed
			CFixed XPUnscaledBonus; //fieldtype: Fixed
			int32 KillXPBonus; //fieldtype: IntSigned
			CFixed CriticalAttackChanceMultiplier; //fieldtype: Fixed
			CFixed CriticalAttackChanceScaledBonus; //fieldtype: Fixed
			CFixed CriticalAttackChanceUnscaledBonus; //fieldtype: Fixed
		}
		CEffectLink LevelGainEffect; //fieldtype: CatalogLink
		CEffectLink LevelLossEffect; //fieldtype: CatalogLink
		SAbilReplace[] AbilReplace //struct
		{
			CAbilLink Origin; //fieldtype: CatalogLink
			CAbilLink New; //fieldtype: CatalogLink
		}
		SAbilAdd[] AbilAdd //struct
		{
			CAbilLink Abil; //fieldtype: CatalogLink
			bool8 OverrideCardId; //fieldtype: Unknown
			CFourCC CardId; //fieldtype: FourCC
		}
	}
}

class CBehaviorResource
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	uint32 Capacity; //fieldtype: IntUnsigned
	uint32 Contents; //fieldtype: IntUnsigned
	CGameTime HarvestTime; //fieldtype: Fixed
	uint32 HarvestAmount; //fieldtype: IntUnsigned
	EDeathType EmptyDeathType; //enum
	uint32 EmptyHarvestAmount; //fieldtype: IntUnsigned
	CUnitLink EmptyUnit; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	EAllianceId RequiredAlliance; //enum
	CGameTime ReturnDelay; //fieldtype: Fixed
	CAlertLink ExhaustedAlert; //fieldtype: CatalogLink
	CAlertLink DepletionAlert; //fieldtype: CatalogLink
	uint32 DepletionThreshold; //fieldtype: IntUnsigned
	uint32 DepletionVariationCount; //fieldtype: IntUnsigned
	CBehaviorLink CarryResourceBehavior; //fieldtype: CatalogLink
	uint32 IdealHarvesterCount; //fieldtype: IntUnsigned
	CTargetFilters EnabledSearchFilters; //fieldtype: Unknown
	CFixed EnabledSearchRadius; //fieldtype: Fixed
}

class CBehaviorReveal
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	CGameTime Duration; //fieldtype: Fixed
	CTargetFilters SearchFilters; //fieldtype: Unknown
}

class CBehaviorSpawn
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] DisplayDuration; //fieldtype: Flags
	SSpawnInfo[] InfoArray //struct
	{
		CUnitLink Unit; //fieldtype: CatalogLink
		uint32 Count; //fieldtype: IntUnsigned
		uint32 MaxCount; //fieldtype: IntUnsigned
		uint32 StartCount; //fieldtype: IntUnsigned
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		CGameTime Delay; //fieldtype: Fixed
		CEffectLink Effect; //fieldtype: CatalogLink
	}
	CGamePoint Center; //fieldtype: Unknown
	CGamePoint[] Offset; //fieldtype: Unknown
	CFixed Slop; //fieldtype: Fixed
	CEffectLink Effect; //fieldtype: CatalogLink
	CFixed Range; //fieldtype: Fixed
	CFlags[] Flags; //fieldtype: Flags
	uint32 Limit; //fieldtype: IntUnsigned
	EDeathType LimitDeath; //enum
	CBehaviorLink ConjoinedLink; //fieldtype: CatalogLink
}

class CBehaviorVeterancy
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] Flags; //fieldtype: Flags
	CTargetFilters[] ShareFilters; //fieldtype: Unknown
	CTargetFilters[] TargetFilters; //fieldtype: Unknown
	CFixed[] XPFraction; //fieldtype: Fixed
	CFixed[] SharedXPRadius; //fieldtype: Fixed
	CFixed[] SharedXPFraction; //fieldtype: Fixed
	uint32[] SharedXPMaxCount; //fieldtype: IntUnsigned
	SVeterancyLevel[] VeterancyLevelArray //struct
	{
		CImagePath InfoIcon; //fieldtype: String
		uint32 MinVeterancyXP; //fieldtype: IntUnsigned
		SModification Modification //struct
		{
			CFlagArray<e_behaviorModifyCount>[] ModifyFlags; //fieldtype: Flags
			CFlagArray<e_behaviorStateCount>[] StateFlags; //fieldtype: Flags
			TAttackTargetPriority AttackTargetPriority; //fieldtype: IntSigned
			CFixed RadiusMultiplier; //fieldtype: Fixed
			CFixed Height; //fieldtype: Fixed
			CGameTime[] HeightTime; //fieldtype: Fixed
			CFixed SightBonus; //fieldtype: Fixed
			CFixed SightMaximum; //fieldtype: Fixed
			CFixed SightMinimum; //fieldtype: Fixed
			int32 QueueCount; //fieldtype: IntSigned
			int32 QueueSize; //fieldtype: IntSigned
			CFixed TimeScale; //fieldtype: Fixed
			CFixed HealDealtMultiplier; //fieldtype: Fixed
			CFixed HealTakenMultiplier; //fieldtype: Fixed
			CFixed HealDealtAdditiveMultiplier; //fieldtype: Fixed
			CFixed HealTakenAdditiveMultiplier; //fieldtype: Fixed
			CGameSpeed MoveSpeedBaseMaximumBonus; //fieldtype: Fixed
			CGameSpeed MoveSpeedMaximum; //fieldtype: Fixed
			CGameSpeed MoveSpeedMinimum; //fieldtype: Fixed
			CGameSpeed MoveSpeedBonus; //fieldtype: Fixed
			CFixed MoveSpeedMultiplier; //fieldtype: Fixed
			CFixed UnifiedMoveSpeedFactor; //fieldtype: Fixed
			SAccumulatedFixed AdditiveMoveSpeedFactor //struct
			{
				CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
			}
			CGameAcceleration AccelerationBonus; //fieldtype: Fixed
			CFixed AccelerationMultiplier; //fieldtype: Fixed
			CGameAcceleration DecelerationBonus; //fieldtype: Fixed
			CFixed DecelerationMultiplier; //fieldtype: Fixed
			CFixed SnareMultiplier; //fieldtype: Fixed
			CFixed AttackSpeedMultiplier; //fieldtype: Fixed
			CFixed UnifiedAttackSpeedFactor; //fieldtype: Fixed
			SAccumulatedFixed AdditiveAttackSpeedFactor //struct
			{
				CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
			}
			CFixed WeaponRange; //fieldtype: Fixed
			CFixed MeleeWeaponRange; //fieldtype: Fixed
			CFixed RangedWeaponRange; //fieldtype: Fixed
			CFixed WeaponMinRange; //fieldtype: Fixed
			CFixed[] DamageDealtScaled; //fieldtype: Fixed
			SAccumulatedFixed[] DamageDealtFraction //struct
			{
				CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
			}
			SAccumulatedFixed[] DamageDealtUnscaled //struct
			{
				CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
			}
			CFixed[] DamageDealtMaximum; //fieldtype: Fixed
			CFixed[] DamageDealtMinimum; //fieldtype: Fixed
			CFixed[] DamageDealtAttributeScaled; //fieldtype: Fixed
			CFixed[] DamageDealtAttributeMultiplier; //fieldtype: Fixed
			CFixed[] DamageDealtAttributeUnscaled; //fieldtype: Fixed
			CFixed[] DamageTakenScaled; //fieldtype: Fixed
			CFixed[] DamageTakenFraction; //fieldtype: Fixed
			CFixed[] DamageTakenUnscaled; //fieldtype: Fixed
			CFixed[] DamageTakenMaximum; //fieldtype: Fixed
			CFixed[] DamageTakenMinimum; //fieldtype: Fixed
			CFixed[] DamageTotalMultiplier; //fieldtype: Fixed
			CFixed[] UnifiedDamageDealtFraction; //fieldtype: Fixed
			CFixed[] UnifiedDamageTakenFraction; //fieldtype: Fixed
			SAccumulatedFixed LifeArmorBonus //struct
			{
				CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
			}
			CFixed LifeArmorMultiplier; //fieldtype: Fixed
			CFixed ShieldArmorBonus; //fieldtype: Fixed
			CFixed ShieldArmorMultiplier; //fieldtype: Fixed
			CFixed EnergyArmorBonus; //fieldtype: Fixed
			CFixed EnergyArmorMultiplier; //fieldtype: Fixed
			CFixed ShieldDamageRatioBonus; //fieldtype: Fixed
			CFixed ShieldDamageRatioMultiplier; //fieldtype: Fixed
			SAccumulatedFixed EnergyDamageRatioBonus //struct
			{
				CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
			}
			CFixed EnergyDamageRatioMultiplier; //fieldtype: Fixed
			uint32[] ResourceHarvestAmountBonus; //fieldtype: IntUnsigned
			CFixed[] ResourceHarvestAmountMultiplier; //fieldtype: Fixed
			CGameTime[] ResourceHarvestTimeBonus; //fieldtype: Fixed
			CFixed[] ResourceHarvestTimeMultiplier; //fieldtype: Fixed
			CFlagArray<e_unitVitalCount>[] VitalMaxIncreaseAffectsCurrentArray; //fieldtype: Flags
			CFlagArray<e_unitVitalCount>[] VitalMaxDecreaseAffectsCurrentArray; //fieldtype: Flags
			CFixed[] VitalMaxArray; //fieldtype: Fixed
			CFixed[] VitalMaxFractionArray; //fieldtype: Fixed
			CFixed[] VitalMaxAdditiveMultiplierArray; //fieldtype: Fixed
			SAccumulatedGameRate[] VitalRegenArray //struct
			{
				CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
			}
			CFixed[] VitalRegenMultiplier; //fieldtype: Fixed
			SDamageKind[] VitalDamageGainArray //struct
			{
				CFixed[] KindArray; //fieldtype: Fixed
			}
			SScoreValueUpdate[] VitalDamageGainScoreArray //struct
			{
				CValidatorLink Validator; //fieldtype: CatalogLink
				CScoreValueLink Value; //fieldtype: CatalogLink
			}
			SDamageKind[] VitalDamageLeechArray //struct
			{
				CFixed[] KindArray; //fieldtype: Fixed
			}
			SScoreValueUpdate[] VitalDamageLeechScoreArray //struct
			{
				CValidatorLink Validator; //fieldtype: CatalogLink
				CScoreValueLink Value; //fieldtype: CatalogLink
			}
			SUnitResourceRatio[] ResourceDamageLeech //struct
			{
				CFixed[] Amount; //fieldtype: Fixed
			}
			CFlags[] AbilCategoriesEnable; //fieldtype: Flags
			CFlags[] AbilCategoriesDisable; //fieldtype: Flags
			CFlagArray<e_classIdCAbilCount>[] AbilClassEnableArray; //fieldtype: Flags
			CFlagArray<e_classIdCAbilCount>[] AbilClassDisableArray; //fieldtype: Flags
			TTechAlias[] AbilTechAliasEnableArray; //fieldtype: String
			TTechAlias[] AbilTechAliasDisableArray; //fieldtype: String
			CAbilLink[] AbilLinkEnableArray; //fieldtype: CatalogLink
			CAbilLink[] AbilLinkDisableArray; //fieldtype: CatalogLink
			CBehaviorCategoryFlags[] BehaviorCategoriesEnable; //fieldtype: Flags
			CBehaviorCategoryFlags[] BehaviorCategoriesDisable; //fieldtype: Flags
			CFixed[] BehaviorCategoryDurationFactor; //fieldtype: Fixed
			CFlagArray<e_classIdCBehaviorCount>[] BehaviorClassEnableArray; //fieldtype: Flags
			CFlagArray<e_classIdCBehaviorCount>[] BehaviorClassDisableArray; //fieldtype: Flags
			CBehaviorLink[] BehaviorLinkEnableArray; //fieldtype: CatalogLink
			CBehaviorLink[] BehaviorLinkDisableArray; //fieldtype: CatalogLink
			SUnitWeaponData[] WeaponArray //struct
			{
				CWeaponLink Link; //fieldtype: CatalogLink
				CTurretLink Turret; //fieldtype: CatalogLink
			}
			CFixed WeaponScanBonus; //fieldtype: Fixed
			CFixed WeaponScanLimit; //fieldtype: Fixed
			CWeaponLink[] WeaponEnableArray; //fieldtype: CatalogLink
			CWeaponLink[] WeaponDisableArray; //fieldtype: CatalogLink
			CTurretLink[] TurretEnableArray; //fieldtype: CatalogLink
			CTurretLink[] TurretDisableArray; //fieldtype: CatalogLink
			CSoundLink[] SoundArray; //fieldtype: CatalogLink
			CFixed Detect; //fieldtype: Fixed
			CFangleArc DetectArc; //fieldtype: Fixed
			CFixed DetectBonus; //fieldtype: Fixed
			CTargetFilters DetectFilters; //fieldtype: Unknown
			CFixed Radar; //fieldtype: Fixed
			CFangleArc RadarArc; //fieldtype: Fixed
			CTargetFilters RadarFilters; //fieldtype: Unknown
			CFixed Food; //fieldtype: Fixed
			SAttributeChange[] AttributeChangeArray //struct
			{
				CBehaviorLink Attribute; //fieldtype: CatalogLink
				int32 Points; //fieldtype: IntSigned
			}
			CFixed[] RateMultiplierArray; //fieldtype: Fixed
			SDeathResponse DeathResponse //struct
			{
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
				CEffectLink Effect; //fieldtype: CatalogLink
				CFlagArray<e_playerRelationshipCount>[] Relationship; //fieldtype: Flags
				CFlagArray<e_deathTypeCount>[] Type; //fieldtype: Flags
			}
			int8[] PlaneDelta; //fieldtype: IntSigned
			int32 ScoreKillBonus; //fieldtype: IntSigned
			int32 ScoreLostBonus; //fieldtype: IntSigned
			int16 SubgroupPriority; //fieldtype: IntSigned
			CStringLink UnitNameOverride; //fieldtype: String
			CFixed XPMultiplier; //fieldtype: Fixed
			CFixed XPScaledBonus; //fieldtype: Fixed
			CFixed XPUnscaledBonus; //fieldtype: Fixed
			int32 KillXPBonus; //fieldtype: IntSigned
			CFixed CriticalAttackChanceMultiplier; //fieldtype: Fixed
			CFixed CriticalAttackChanceScaledBonus; //fieldtype: Fixed
			CFixed CriticalAttackChanceUnscaledBonus; //fieldtype: Fixed
		}
		CEffectLink LevelGainEffect; //fieldtype: CatalogLink
		CEffectLink LevelLossEffect; //fieldtype: CatalogLink
		CStringLink RankNameSchema; //fieldtype: String
	}
	SBehaviorFraction[] XPReceiveFraction //struct
	{
		SAccumulatedFixed Fraction //struct
		{
			CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
		}
		CTargetFilters TargetFilters; //fieldtype: Unknown
	}
	uint32 Levels; //fieldtype: IntUnsigned
	CFixed MinVeterancyXPLevelFactor; //fieldtype: Fixed
	CFixed MinVeterancyXPPreviousValueFactor; //fieldtype: Fixed
	uint32 MinVeterancyXPBonusPerLevel; //fieldtype: IntUnsigned
}

class CBehaviorWander
{
	CButtonLink Face; //fieldtype: CatalogLink
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	EBehaviorAlignment Alignment; //enum
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
	CFlags[] BehaviorFlags; //fieldtype: Flags
	CFlags[] InfoFlags; //fieldtype: Flags
	CImagePath InfoIcon; //fieldtype: String
	CBehaviorCategoryFlags[] BehaviorCategories; //fieldtype: Flags
	TEditorCategories EditorCategories; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	TTechAlias[] TechAliasArray; //fieldtype: String
	int32 SortIndex; //fieldtype: IntSigned
	bool8 DebugTrace; //fieldtype: Unknown
	bool8 Leash; //fieldtype: Unknown
	bool8 Override; //fieldtype: Unknown
	CFixed TimeLimitFactor; //fieldtype: Fixed
	CFixed MinimumRange; //fieldtype: Fixed
	CFixed Range; //fieldtype: Fixed
	CGameTime Delay; //fieldtype: Fixed
}
