
class CUnit
{
	CStringLink Name; //fieldtype: String
	CStringLink UserTag; //fieldtype: String
	CStringLink[] RandomNameArray; //fieldtype: String
	CStringLink Subtitle; //fieldtype: String
	CStringLink Description; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CGameTime DeathTime; //fieldtype: Fixed
	CTargetFilters DeathRevealFilters; //fieldtype: Unknown
	CFixed DeathRevealRadius; //fieldtype: Fixed
	CGameTime DeathRevealDuration; //fieldtype: Fixed
	EDeathReveal DeathRevealType; //enum
	CGameTime ReviveDelay; //fieldtype: Fixed
	CUnitLink ReviveType; //fieldtype: CatalogLink
	CFacing Facing; //fieldtype: Fixed
	CFangle EditorFacingAlignment; //fieldtype: Fixed
	CRaceLink Race; //fieldtype: CatalogLink
	EUnitMob Mob; //enum
	EUnitGender Gender; //enum
	CFlagArray<e_unitFlagCount>[] FlagArray; //fieldtype: Flags
	CFlagArray<e_unitUserFlagCount>[] UserFlagArray; //fieldtype: Flags
	EResourceState ResourceState; //enum
	EResourceType ResourceType; //enum
	CFlagArray<e_resourceTypeCount>[] ResourceDropOff; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	CFlagArray<e_editorFlagCount>[] EditorFlags; //fieldtype: Flags
	CFlagArray<e_planeCount>[] PlaneArray; //fieldtype: Flags
	CFixed PushPriority; //fieldtype: Fixed
	CFlags[] Collide; //fieldtype: Flags
	EAcquireLevel DefaultAcquireLevel; //enum
	EUnitResponse Response; //enum
	CFlagArray<e_unitAttributeCount>[] Attributes; //fieldtype: Flags
	uint32 Level; //fieldtype: IntUnsigned
	EArmorType ArmorType; //enum
	CFixed LifeStart; //fieldtype: Fixed
	CFixed LifeMax; //fieldtype: Fixed
	CFixed LifeArmor; //fieldtype: Fixed
	SUnitArmorFormula LifeArmorFormula //struct
	{
		CFixed NegativeArmorMultiplier; //fieldtype: Fixed
		CFixed NegativeDamageBase; //fieldtype: Fixed
		CFixed NegativeDamageUnscaled; //fieldtype: Fixed
		CFixed PositiveArmorMultiplier; //fieldtype: Fixed
		CFixed PositiveDamageRatio; //fieldtype: Fixed
	}
	CFlagArray<e_equipmentDisplayFlagCount>[] LifeArmorDisplayFlags; //fieldtype: Flags
	CGameTime LifeRegenDelay; //fieldtype: Fixed
	CGameRate LifeRegenRate; //fieldtype: Fixed
	CGameRate LifeRegenRateCreep; //fieldtype: Fixed
	CGameRate LifeRegenRateNight; //fieldtype: Fixed
	CStringLink LifeArmorName; //fieldtype: String
	CStringLink LifeArmorTip; //fieldtype: String
	uint32 LifeArmorLevel; //fieldtype: IntUnsigned
	CFixed[] LifeDamageGain; //fieldtype: Fixed
	CFixed[] LifeDamageLeech; //fieldtype: Fixed
	CFixed EnergyStart; //fieldtype: Fixed
	CFixed EnergyMax; //fieldtype: Fixed
	CFixed EnergyArmor; //fieldtype: Fixed
	SUnitArmorFormula EnergyArmorFormula //struct
	{
		CFixed NegativeArmorMultiplier; //fieldtype: Fixed
		CFixed NegativeDamageBase; //fieldtype: Fixed
		CFixed NegativeDamageUnscaled; //fieldtype: Fixed
		CFixed PositiveArmorMultiplier; //fieldtype: Fixed
		CFixed PositiveDamageRatio; //fieldtype: Fixed
	}
	CGameTime EnergyRegenDelay; //fieldtype: Fixed
	CGameRate EnergyRegenRate; //fieldtype: Fixed
	CGameRate EnergyRegenRateCreep; //fieldtype: Fixed
	CGameRate EnergyRegenRateNight; //fieldtype: Fixed
	CFixed[] EnergyDamageGain; //fieldtype: Fixed
	CFixed[] EnergyDamageLeech; //fieldtype: Fixed
	CFixed EnergyDamageRatio; //fieldtype: Fixed
	CFixed ShieldsStart; //fieldtype: Fixed
	CFixed ShieldsMax; //fieldtype: Fixed
	CFixed ShieldArmor; //fieldtype: Fixed
	SUnitArmorFormula ShieldArmorFormula //struct
	{
		CFixed NegativeArmorMultiplier; //fieldtype: Fixed
		CFixed NegativeDamageBase; //fieldtype: Fixed
		CFixed NegativeDamageUnscaled; //fieldtype: Fixed
		CFixed PositiveArmorMultiplier; //fieldtype: Fixed
		CFixed PositiveDamageRatio; //fieldtype: Fixed
	}
	CFlagArray<e_equipmentDisplayFlagCount>[] ShieldArmorDisplayFlags; //fieldtype: Flags
	CGameTime ShieldRegenDelay; //fieldtype: Fixed
	CGameRate ShieldRegenRate; //fieldtype: Fixed
	CGameRate ShieldRegenRateCreep; //fieldtype: Fixed
	CGameRate ShieldRegenRateNight; //fieldtype: Fixed
	CStringLink ShieldArmorName; //fieldtype: String
	CStringLink ShieldArmorTip; //fieldtype: String
	uint32 ShieldArmorLevel; //fieldtype: IntUnsigned
	CFixed[] ShieldDamageGain; //fieldtype: Fixed
	CFixed[] ShieldDamageLeech; //fieldtype: Fixed
	CFixed ShieldDamageRatio; //fieldtype: Fixed
	SUnitResourceRatio[] ResourceDamageLeech //struct
	{
		CFixed[] Amount; //fieldtype: Fixed
	}
	CTargetFilters ResourceDamageLeechFilters; //fieldtype: Unknown
	CFixed[] VitalBonusDensity; //fieldtype: Fixed
	CFixed[] VitalMultiplierDensity; //fieldtype: Fixed
	CMoverLink Mover; //fieldtype: CatalogLink
	CGameSpeed Speed; //fieldtype: Fixed
	CFlagArray<e_equipmentDisplayFlagCount>[] SpeedDisplayFlags; //fieldtype: Flags
	CGameSpeed SpeedBonusCreep; //fieldtype: Fixed
	CFixed SpeedMultiplierCreep; //fieldtype: Fixed
	CGameSpeed SpeedMaximum; //fieldtype: Fixed
	CGameSpeed SpeedMinimum; //fieldtype: Fixed
	CFixed AttackSpeedMultiplierCreep; //fieldtype: Fixed
	CGameAcceleration Acceleration; //fieldtype: Fixed
	CGameAcceleration Deceleration; //fieldtype: Fixed
	CGameAcceleration LateralAcceleration; //fieldtype: Fixed
	CFangleRate StationaryTurningRate; //fieldtype: Unknown
	CFangleRate TurningRate; //fieldtype: Unknown
	CFixed Sight; //fieldtype: Fixed
	CFixed[] SightBonus; //fieldtype: Fixed
	CFixed Height; //fieldtype: Fixed
	CFixed VisionHeight; //fieldtype: Fixed
	CFixed OccludeHeight; //fieldtype: Fixed
	TCliffLevel BoostedCliffLevel; //fieldtype: IntUnsigned
	CFixed[] BoostedHeight; //fieldtype: Fixed
	CFixed Food; //fieldtype: Fixed
	ECostCategory CostCategory; //enum
	int32[] CostResource; //fieldtype: IntSigned
	SStockCharge StockCharge //struct
	{
		CFixed CountMax; //fieldtype: Fixed
		CGameTime TimeDelay; //fieldtype: Fixed
		CGameTime TimeUse; //fieldtype: Fixed
	}
	CFixed PawnItemReduction; //fieldtype: Fixed
	CGameTime BuildTime; //fieldtype: Fixed
	CGameTime RepairTime; //fieldtype: Fixed
	CGameTime ReviveTime; //fieldtype: Fixed
	TAttackTargetPriority AttackTargetPriority; //fieldtype: IntSigned
	TAttackTargetPriority AIOverideTargetPriority; //fieldtype: IntSigned
	uint32 DamageDealtXP; //fieldtype: IntUnsigned
	uint32 DamageTakenXP; //fieldtype: IntUnsigned
	uint32 KillXP; //fieldtype: IntUnsigned
	int32[] KillResource; //fieldtype: IntSigned
	SUnitAbilData[] AbilArray //struct
	{
		CAbilLink Link; //fieldtype: CatalogLink
	}
	SUnitBehaviorData[] BehaviorArray //struct
	{
		CBehaviorLink Link; //fieldtype: CatalogLink
	}
	CTurretLink[] TurretArray; //fieldtype: CatalogLink
	SUnitWeaponData[] WeaponArray //struct
	{
		CWeaponLink Link; //fieldtype: CatalogLink
		CTurretLink Turret; //fieldtype: CatalogLink
	}
	CEffectLink[] EffectArray; //fieldtype: CatalogLink
	SCardLayout[] CardLayouts //struct
	{
		CCardId CardId; //fieldtype: FourCC
		SCardLayoutButton[] LayoutButtons //struct
		{
			CButtonLink Face; //fieldtype: CatalogLink
			ECardButtonType Type; //enum
			CAbilCommand AbilCmd; //fieldtype: Unknown
			CBehaviorLink Behavior; //fieldtype: CatalogLink
			const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
			CAbilLink SubmenuAbilState; //fieldtype: CatalogLink
			CCardId SubmenuCardId; //fieldtype: FourCC
			bool8 SubmenuFullSubCmdValidation; //fieldtype: Unknown
			bool8 SubmenuIsSticky; //fieldtype: Unknown
			bool8 ShowInGlossary; //fieldtype: Unknown
			uint8 Row; //fieldtype: IntUnsigned
			uint8 Column; //fieldtype: IntUnsigned
		}
		CStringLink[] RowText; //fieldtype: String
	}
	TUnitRadius Radius; //fieldtype: Fixed
	TUnitRadius DeadRadius; //fieldtype: Fixed
	CFixed SeparationRadius; //fieldtype: Fixed
	uint8 FormationRank; //fieldtype: IntUnsigned
	TUnitRadius InnerRadius; //fieldtype: Fixed
	CFixed InnerRadiusSafetyMultiplier; //fieldtype: Fixed
	TUnitRadius DeadInnerRadius; //fieldtype: Fixed
	CTargetFilters CargoOverlapFilters; //fieldtype: Unknown
	TCargoSize CargoSize; //fieldtype: Unknown
	CFootprintLink Footprint; //fieldtype: CatalogLink
	CFootprintLink DeadFootprint; //fieldtype: CatalogLink
	CFootprintLink PlacementFootprint; //fieldtype: CatalogLink
	SAddedOnData[] AddedOnArray //struct
	{
		CUnitLink UnitLink; //fieldtype: CatalogLink
		CBehaviorLink BehaviorLink; //fieldtype: CatalogLink
		CBehaviorLink ParentBehaviorLink; //fieldtype: CatalogLink
	}
	CFixed AddOnOffsetX; //fieldtype: Fixed
	CFixed AddOnOffsetY; //fieldtype: Fixed
	CUnitLink[] BuiltOn; //fieldtype: CatalogLink
	CUnitLink[] BuildOnAs; //fieldtype: CatalogLink
	int32 ScoreMake; //fieldtype: IntSigned
	CFixed[] ScoreMakeCostFactor; //fieldtype: Fixed
	int32 ScoreKill; //fieldtype: IntSigned
	CFixed[] ScoreKillCostFactor; //fieldtype: Fixed
	int32 ScoreLost; //fieldtype: IntSigned
	CFixed[] ScoreLostCostFactor; //fieldtype: Fixed
	CScoreResultLink ScoreResult; //fieldtype: CatalogLink
	uint8 SubgroupPriority; //fieldtype: IntUnsigned
	int16 SubgroupPriorityDelta; //fieldtype: IntSigned
	CFixed MinimapRadius; //fieldtype: Fixed
	TEditorCategories EditorCategories; //fieldtype: String
	CTacticalLink TacticalAI; //fieldtype: CatalogLink
	TGalaxyFunction TacticalAIRange; //fieldtype: String
	TGalaxyFunction TacticalAIThink; //fieldtype: String
	TGalaxyFunction TacticalAIChannel; //fieldtype: String
	CTargetFilters TacticalAIFilters; //fieldtype: Unknown
	CFixed AIKiteRange; //fieldtype: Fixed
	CFixed AIEvalFactor; //fieldtype: Fixed
	CFixed AIEvalConstant; //fieldtype: Fixed
	CItemLink Item; //fieldtype: CatalogLink
	CFixed Mass; //fieldtype: Fixed
	SCost PowerupCost //struct
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
	CEffectLink PowerupEffect; //fieldtype: CatalogLink
	CTargetFilters PowerupFilters; //fieldtype: Unknown
	CFixed PowerupRange; //fieldtype: Fixed
	CUnitLink LeaderAlias; //fieldtype: CatalogLink
	CUnitLink HotkeyAlias; //fieldtype: CatalogLink
	CUnitLink SelectAlias; //fieldtype: CatalogLink
	CUnitLink SubgroupAlias; //fieldtype: CatalogLink
	TTechAlias[] TechAliasArray; //fieldtype: String
	SUnitEquipment[] EquipmentArray //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		CImagePath Icon; //fieldtype: String
		CStringLink Name; //fieldtype: String
		CStringLink Tooltip; //fieldtype: String
		CWeaponLink Weapon; //fieldtype: CatalogLink
	}
	CSyncModelDataPath SyncModelData; //fieldtype: String
	CEffectLink AINotifyEffect; //fieldtype: CatalogLink
	CStringLink GlossaryCategory; //fieldtype: String
	int32 GlossaryPriority; //fieldtype: IntSigned
	CUnitLink[] GlossaryStrongArray; //fieldtype: CatalogLink
	CUnitLink[] GlossaryWeakArray; //fieldtype: CatalogLink
	CUnitLink GlossaryAlias; //fieldtype: CatalogLink
	CStringLink HotkeyCategory; //fieldtype: String
	EKillDisplay KillDisplay; //enum
	ERankDisplay RankDisplay; //enum
	CUnitLink AIEvaluateAlias; //fieldtype: CatalogLink
	CUnitLink[] TechTreeProducedUnitArray; //fieldtype: CatalogLink
	CUnitLink[] TechTreeUnlockedUnitArray; //fieldtype: CatalogLink
	SFidget Fidget //struct
	{
		uint8[] ChanceArray; //fieldtype: IntUnsigned
		CGameTime DelayMax; //fieldtype: Fixed
		CGameTime DelayMin; //fieldtype: Fixed
		CFixed DistanceMax; //fieldtype: Fixed
		CFixed DistanceMin; //fieldtype: Fixed
		CFangle TurnAngle; //fieldtype: Fixed
		CFangleRate TurningRate; //fieldtype: Unknown
	}
	CLootLink[] LootArray; //fieldtype: CatalogLink
	CGameTime[] TauntDuration; //fieldtype: Fixed
	CFlags[] TauntDoesntStopUnit; //fieldtype: Flags
	CAbilCommand IdleCommand; //fieldtype: Unknown
	SUnitReviveInfo ReviveInfoBase //struct
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
		CGameTime Time; //fieldtype: Fixed
	}
	SUnitReviveInfo ReviveInfoLevel //struct
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
		CGameTime Time; //fieldtype: Fixed
	}
	uint8 OverlapIndex; //fieldtype: IntUnsigned
	int8 AlliedPushPriority; //fieldtype: IntSigned
	CFixed AcquireMovementLimit; //fieldtype: Fixed
	CFixed AcquireLeashRadius; //fieldtype: Fixed
	CFixed AcquireLeashResetRadius; //fieldtype: Fixed
	uint32 OrderDisplayMinimum; //fieldtype: IntUnsigned
	uint16[] EffectHistoryLimit; //fieldtype: IntUnsigned
	uint8 TargetingHitTestPriority; //fieldtype: IntUnsigned
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
}

class CUnitHero
{
	CStringLink Name; //fieldtype: String
	CStringLink UserTag; //fieldtype: String
	CStringLink[] RandomNameArray; //fieldtype: String
	CStringLink Subtitle; //fieldtype: String
	CStringLink Description; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CGameTime DeathTime; //fieldtype: Fixed
	CTargetFilters DeathRevealFilters; //fieldtype: Unknown
	CFixed DeathRevealRadius; //fieldtype: Fixed
	CGameTime DeathRevealDuration; //fieldtype: Fixed
	EDeathReveal DeathRevealType; //enum
	CGameTime ReviveDelay; //fieldtype: Fixed
	CUnitLink ReviveType; //fieldtype: CatalogLink
	CFacing Facing; //fieldtype: Fixed
	CFangle EditorFacingAlignment; //fieldtype: Fixed
	CRaceLink Race; //fieldtype: CatalogLink
	EUnitMob Mob; //enum
	EUnitGender Gender; //enum
	CFlagArray<e_unitFlagCount>[] FlagArray; //fieldtype: Flags
	CFlagArray<e_unitUserFlagCount>[] UserFlagArray; //fieldtype: Flags
	EResourceState ResourceState; //enum
	EResourceType ResourceType; //enum
	CFlagArray<e_resourceTypeCount>[] ResourceDropOff; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	CFlagArray<e_editorFlagCount>[] EditorFlags; //fieldtype: Flags
	CFlagArray<e_planeCount>[] PlaneArray; //fieldtype: Flags
	CFixed PushPriority; //fieldtype: Fixed
	CFlags[] Collide; //fieldtype: Flags
	EAcquireLevel DefaultAcquireLevel; //enum
	EUnitResponse Response; //enum
	CFlagArray<e_unitAttributeCount>[] Attributes; //fieldtype: Flags
	uint32 Level; //fieldtype: IntUnsigned
	EArmorType ArmorType; //enum
	CFixed LifeStart; //fieldtype: Fixed
	CFixed LifeMax; //fieldtype: Fixed
	CFixed LifeArmor; //fieldtype: Fixed
	SUnitArmorFormula LifeArmorFormula //struct
	{
		CFixed NegativeArmorMultiplier; //fieldtype: Fixed
		CFixed NegativeDamageBase; //fieldtype: Fixed
		CFixed NegativeDamageUnscaled; //fieldtype: Fixed
		CFixed PositiveArmorMultiplier; //fieldtype: Fixed
		CFixed PositiveDamageRatio; //fieldtype: Fixed
	}
	CFlagArray<e_equipmentDisplayFlagCount>[] LifeArmorDisplayFlags; //fieldtype: Flags
	CGameTime LifeRegenDelay; //fieldtype: Fixed
	CGameRate LifeRegenRate; //fieldtype: Fixed
	CGameRate LifeRegenRateCreep; //fieldtype: Fixed
	CGameRate LifeRegenRateNight; //fieldtype: Fixed
	CStringLink LifeArmorName; //fieldtype: String
	CStringLink LifeArmorTip; //fieldtype: String
	uint32 LifeArmorLevel; //fieldtype: IntUnsigned
	CFixed[] LifeDamageGain; //fieldtype: Fixed
	CFixed[] LifeDamageLeech; //fieldtype: Fixed
	CFixed EnergyStart; //fieldtype: Fixed
	CFixed EnergyMax; //fieldtype: Fixed
	CFixed EnergyArmor; //fieldtype: Fixed
	SUnitArmorFormula EnergyArmorFormula //struct
	{
		CFixed NegativeArmorMultiplier; //fieldtype: Fixed
		CFixed NegativeDamageBase; //fieldtype: Fixed
		CFixed NegativeDamageUnscaled; //fieldtype: Fixed
		CFixed PositiveArmorMultiplier; //fieldtype: Fixed
		CFixed PositiveDamageRatio; //fieldtype: Fixed
	}
	CGameTime EnergyRegenDelay; //fieldtype: Fixed
	CGameRate EnergyRegenRate; //fieldtype: Fixed
	CGameRate EnergyRegenRateCreep; //fieldtype: Fixed
	CGameRate EnergyRegenRateNight; //fieldtype: Fixed
	CFixed[] EnergyDamageGain; //fieldtype: Fixed
	CFixed[] EnergyDamageLeech; //fieldtype: Fixed
	CFixed EnergyDamageRatio; //fieldtype: Fixed
	CFixed ShieldsStart; //fieldtype: Fixed
	CFixed ShieldsMax; //fieldtype: Fixed
	CFixed ShieldArmor; //fieldtype: Fixed
	SUnitArmorFormula ShieldArmorFormula //struct
	{
		CFixed NegativeArmorMultiplier; //fieldtype: Fixed
		CFixed NegativeDamageBase; //fieldtype: Fixed
		CFixed NegativeDamageUnscaled; //fieldtype: Fixed
		CFixed PositiveArmorMultiplier; //fieldtype: Fixed
		CFixed PositiveDamageRatio; //fieldtype: Fixed
	}
	CFlagArray<e_equipmentDisplayFlagCount>[] ShieldArmorDisplayFlags; //fieldtype: Flags
	CGameTime ShieldRegenDelay; //fieldtype: Fixed
	CGameRate ShieldRegenRate; //fieldtype: Fixed
	CGameRate ShieldRegenRateCreep; //fieldtype: Fixed
	CGameRate ShieldRegenRateNight; //fieldtype: Fixed
	CStringLink ShieldArmorName; //fieldtype: String
	CStringLink ShieldArmorTip; //fieldtype: String
	uint32 ShieldArmorLevel; //fieldtype: IntUnsigned
	CFixed[] ShieldDamageGain; //fieldtype: Fixed
	CFixed[] ShieldDamageLeech; //fieldtype: Fixed
	CFixed ShieldDamageRatio; //fieldtype: Fixed
	SUnitResourceRatio[] ResourceDamageLeech //struct
	{
		CFixed[] Amount; //fieldtype: Fixed
	}
	CTargetFilters ResourceDamageLeechFilters; //fieldtype: Unknown
	CFixed[] VitalBonusDensity; //fieldtype: Fixed
	CFixed[] VitalMultiplierDensity; //fieldtype: Fixed
	CMoverLink Mover; //fieldtype: CatalogLink
	CGameSpeed Speed; //fieldtype: Fixed
	CFlagArray<e_equipmentDisplayFlagCount>[] SpeedDisplayFlags; //fieldtype: Flags
	CGameSpeed SpeedBonusCreep; //fieldtype: Fixed
	CFixed SpeedMultiplierCreep; //fieldtype: Fixed
	CGameSpeed SpeedMaximum; //fieldtype: Fixed
	CGameSpeed SpeedMinimum; //fieldtype: Fixed
	CFixed AttackSpeedMultiplierCreep; //fieldtype: Fixed
	CGameAcceleration Acceleration; //fieldtype: Fixed
	CGameAcceleration Deceleration; //fieldtype: Fixed
	CGameAcceleration LateralAcceleration; //fieldtype: Fixed
	CFangleRate StationaryTurningRate; //fieldtype: Unknown
	CFangleRate TurningRate; //fieldtype: Unknown
	CFixed Sight; //fieldtype: Fixed
	CFixed[] SightBonus; //fieldtype: Fixed
	CFixed Height; //fieldtype: Fixed
	CFixed VisionHeight; //fieldtype: Fixed
	CFixed OccludeHeight; //fieldtype: Fixed
	TCliffLevel BoostedCliffLevel; //fieldtype: IntUnsigned
	CFixed[] BoostedHeight; //fieldtype: Fixed
	CFixed Food; //fieldtype: Fixed
	ECostCategory CostCategory; //enum
	int32[] CostResource; //fieldtype: IntSigned
	SStockCharge StockCharge //struct
	{
		CFixed CountMax; //fieldtype: Fixed
		CGameTime TimeDelay; //fieldtype: Fixed
		CGameTime TimeUse; //fieldtype: Fixed
	}
	CFixed PawnItemReduction; //fieldtype: Fixed
	CGameTime BuildTime; //fieldtype: Fixed
	CGameTime RepairTime; //fieldtype: Fixed
	CGameTime ReviveTime; //fieldtype: Fixed
	TAttackTargetPriority AttackTargetPriority; //fieldtype: IntSigned
	TAttackTargetPriority AIOverideTargetPriority; //fieldtype: IntSigned
	uint32 DamageDealtXP; //fieldtype: IntUnsigned
	uint32 DamageTakenXP; //fieldtype: IntUnsigned
	uint32 KillXP; //fieldtype: IntUnsigned
	int32[] KillResource; //fieldtype: IntSigned
	SUnitAbilData[] AbilArray //struct
	{
		CAbilLink Link; //fieldtype: CatalogLink
	}
	SUnitBehaviorData[] BehaviorArray //struct
	{
		CBehaviorLink Link; //fieldtype: CatalogLink
	}
	CTurretLink[] TurretArray; //fieldtype: CatalogLink
	SUnitWeaponData[] WeaponArray //struct
	{
		CWeaponLink Link; //fieldtype: CatalogLink
		CTurretLink Turret; //fieldtype: CatalogLink
	}
	CEffectLink[] EffectArray; //fieldtype: CatalogLink
	SCardLayout[] CardLayouts //struct
	{
		CCardId CardId; //fieldtype: FourCC
		SCardLayoutButton[] LayoutButtons //struct
		{
			CButtonLink Face; //fieldtype: CatalogLink
			ECardButtonType Type; //enum
			CAbilCommand AbilCmd; //fieldtype: Unknown
			CBehaviorLink Behavior; //fieldtype: CatalogLink
			const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
			CAbilLink SubmenuAbilState; //fieldtype: CatalogLink
			CCardId SubmenuCardId; //fieldtype: FourCC
			bool8 SubmenuFullSubCmdValidation; //fieldtype: Unknown
			bool8 SubmenuIsSticky; //fieldtype: Unknown
			bool8 ShowInGlossary; //fieldtype: Unknown
			uint8 Row; //fieldtype: IntUnsigned
			uint8 Column; //fieldtype: IntUnsigned
		}
		CStringLink[] RowText; //fieldtype: String
	}
	TUnitRadius Radius; //fieldtype: Fixed
	TUnitRadius DeadRadius; //fieldtype: Fixed
	CFixed SeparationRadius; //fieldtype: Fixed
	uint8 FormationRank; //fieldtype: IntUnsigned
	TUnitRadius InnerRadius; //fieldtype: Fixed
	CFixed InnerRadiusSafetyMultiplier; //fieldtype: Fixed
	TUnitRadius DeadInnerRadius; //fieldtype: Fixed
	CTargetFilters CargoOverlapFilters; //fieldtype: Unknown
	TCargoSize CargoSize; //fieldtype: Unknown
	CFootprintLink Footprint; //fieldtype: CatalogLink
	CFootprintLink DeadFootprint; //fieldtype: CatalogLink
	CFootprintLink PlacementFootprint; //fieldtype: CatalogLink
	SAddedOnData[] AddedOnArray //struct
	{
		CUnitLink UnitLink; //fieldtype: CatalogLink
		CBehaviorLink BehaviorLink; //fieldtype: CatalogLink
		CBehaviorLink ParentBehaviorLink; //fieldtype: CatalogLink
	}
	CFixed AddOnOffsetX; //fieldtype: Fixed
	CFixed AddOnOffsetY; //fieldtype: Fixed
	CUnitLink[] BuiltOn; //fieldtype: CatalogLink
	CUnitLink[] BuildOnAs; //fieldtype: CatalogLink
	int32 ScoreMake; //fieldtype: IntSigned
	CFixed[] ScoreMakeCostFactor; //fieldtype: Fixed
	int32 ScoreKill; //fieldtype: IntSigned
	CFixed[] ScoreKillCostFactor; //fieldtype: Fixed
	int32 ScoreLost; //fieldtype: IntSigned
	CFixed[] ScoreLostCostFactor; //fieldtype: Fixed
	CScoreResultLink ScoreResult; //fieldtype: CatalogLink
	uint8 SubgroupPriority; //fieldtype: IntUnsigned
	int16 SubgroupPriorityDelta; //fieldtype: IntSigned
	CFixed MinimapRadius; //fieldtype: Fixed
	TEditorCategories EditorCategories; //fieldtype: String
	CTacticalLink TacticalAI; //fieldtype: CatalogLink
	TGalaxyFunction TacticalAIRange; //fieldtype: String
	TGalaxyFunction TacticalAIThink; //fieldtype: String
	TGalaxyFunction TacticalAIChannel; //fieldtype: String
	CTargetFilters TacticalAIFilters; //fieldtype: Unknown
	CFixed AIKiteRange; //fieldtype: Fixed
	CFixed AIEvalFactor; //fieldtype: Fixed
	CFixed AIEvalConstant; //fieldtype: Fixed
	CItemLink Item; //fieldtype: CatalogLink
	CFixed Mass; //fieldtype: Fixed
	SCost PowerupCost //struct
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
	CEffectLink PowerupEffect; //fieldtype: CatalogLink
	CTargetFilters PowerupFilters; //fieldtype: Unknown
	CFixed PowerupRange; //fieldtype: Fixed
	CUnitLink LeaderAlias; //fieldtype: CatalogLink
	CUnitLink HotkeyAlias; //fieldtype: CatalogLink
	CUnitLink SelectAlias; //fieldtype: CatalogLink
	CUnitLink SubgroupAlias; //fieldtype: CatalogLink
	TTechAlias[] TechAliasArray; //fieldtype: String
	SUnitEquipment[] EquipmentArray //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		CImagePath Icon; //fieldtype: String
		CStringLink Name; //fieldtype: String
		CStringLink Tooltip; //fieldtype: String
		CWeaponLink Weapon; //fieldtype: CatalogLink
	}
	CSyncModelDataPath SyncModelData; //fieldtype: String
	CEffectLink AINotifyEffect; //fieldtype: CatalogLink
	CStringLink GlossaryCategory; //fieldtype: String
	int32 GlossaryPriority; //fieldtype: IntSigned
	CUnitLink[] GlossaryStrongArray; //fieldtype: CatalogLink
	CUnitLink[] GlossaryWeakArray; //fieldtype: CatalogLink
	CUnitLink GlossaryAlias; //fieldtype: CatalogLink
	CStringLink HotkeyCategory; //fieldtype: String
	EKillDisplay KillDisplay; //enum
	ERankDisplay RankDisplay; //enum
	CUnitLink AIEvaluateAlias; //fieldtype: CatalogLink
	CUnitLink[] TechTreeProducedUnitArray; //fieldtype: CatalogLink
	CUnitLink[] TechTreeUnlockedUnitArray; //fieldtype: CatalogLink
	SFidget Fidget //struct
	{
		uint8[] ChanceArray; //fieldtype: IntUnsigned
		CGameTime DelayMax; //fieldtype: Fixed
		CGameTime DelayMin; //fieldtype: Fixed
		CFixed DistanceMax; //fieldtype: Fixed
		CFixed DistanceMin; //fieldtype: Fixed
		CFangle TurnAngle; //fieldtype: Fixed
		CFangleRate TurningRate; //fieldtype: Unknown
	}
	CLootLink[] LootArray; //fieldtype: CatalogLink
	CGameTime[] TauntDuration; //fieldtype: Fixed
	CFlags[] TauntDoesntStopUnit; //fieldtype: Flags
	CAbilCommand IdleCommand; //fieldtype: Unknown
	SUnitReviveInfo ReviveInfoBase //struct
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
		CGameTime Time; //fieldtype: Fixed
	}
	SUnitReviveInfo ReviveInfoLevel //struct
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
		CGameTime Time; //fieldtype: Fixed
	}
	uint8 OverlapIndex; //fieldtype: IntUnsigned
	int8 AlliedPushPriority; //fieldtype: IntSigned
	CFixed AcquireMovementLimit; //fieldtype: Fixed
	CFixed AcquireLeashRadius; //fieldtype: Fixed
	CFixed AcquireLeashResetRadius; //fieldtype: Fixed
	uint32 OrderDisplayMinimum; //fieldtype: IntUnsigned
	uint16[] EffectHistoryLimit; //fieldtype: IntUnsigned
	uint8 TargetingHitTestPriority; //fieldtype: IntUnsigned
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAttributePointsInfo[] AttributePointsInfoArray //struct
	{
		CBehaviorLink Attribute; //fieldtype: CatalogLink
		int32 Points; //fieldtype: IntSigned
		CFixed PointsPerLevel; //fieldtype: Fixed
	}
	SAbilLearnInfo[] LearnInfoArray //struct
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
		SAbilCmdButton Button //struct
		{
			CIdentifier AutoQueueId; //fieldtype: String
			CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
			CAbilCmdFlags[] Flags; //fieldtype: Flags
			EAbilCmdState State; //enum
			const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
			TPreemptLevel PreemptLevel; //fieldtype: IntSigned
		}
		CGameTime Time; //fieldtype: Fixed
		CAlertLink Alert; //fieldtype: CatalogLink
		CAbilLink Abil; //fieldtype: CatalogLink
		uint32 VeterancyLevelMin; //fieldtype: IntUnsigned
		uint32 VeterancyLevelSkip; //fieldtype: IntUnsigned
	}
	CBehaviorLink MainAttribute; //fieldtype: CatalogLink
	CFixed[] MainAttributeDamageBonus; //fieldtype: Fixed
	const CTechRequirementsGraph*[] TierRequirements; //fieldtype: Unknown
}
