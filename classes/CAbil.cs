
class CAbil
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
}

class CAbilProgress
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	CStringLink Activity; //fieldtype: String
	bool8 Cancelable; //fieldtype: Unknown
	CFixed[] VitalStartFactor; //fieldtype: Fixed
}

class CAbilEffect
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	uint32 Levels; //fieldtype: IntUnsigned
	uint32 VeterancyLevelMin; //fieldtype: IntUnsigned
	uint32 VeterancyLevelSkip; //fieldtype: IntUnsigned
	CStringLink Activity; //fieldtype: String
	CEffectLink[] PrepEffect; //fieldtype: CatalogLink
	CEffectLink[] Effect; //fieldtype: CatalogLink
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
	CFlagArray<e_abilEffectFlagCount>[] Flags; //fieldtype: Flags
	SCost[] Cost //struct
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
	SAccumulatedFixed[] ExtraVitalCost //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	SCost[] CancelCost //struct
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
	CFlagArray<e_abilEffectStageCount>[] RefundArray; //fieldtype: Flags
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CFlagArray<e_abilEffectStageCount>[] InterruptArray; //fieldtype: Flags
	SCost InterruptCost //struct
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
	CUnitLink Placeholder; //fieldtype: CatalogLink
	CTargetFilters[] TargetFilters; //fieldtype: Unknown
	STargetSorts TargetSorts //struct
	{
		CTargetSortLink[] SortArray; //fieldtype: CatalogLink
		uint32 RequestCount; //fieldtype: IntUnsigned
		CFixed RequestPercentage; //fieldtype: Fixed
	}
	CFixed[] Range; //fieldtype: Fixed
	CFixed RangeSlop; //fieldtype: Fixed
	CFangleArc Arc; //fieldtype: Fixed
	CFangleArc ArcSlop; //fieldtype: Fixed
	CFangleArc TrackingArc; //fieldtype: Fixed
	uint32 SmartPriority; //fieldtype: IntUnsigned
	CValidatorLink[] SmartValidatorArray; //fieldtype: CatalogLink
	EAcquireLevel AutoCastAcquireLevel; //enum
	CTargetFilters AutoCastFilters; //fieldtype: Unknown
	CFixed AutoCastRange; //fieldtype: Fixed
	CValidatorLink[] AutoCastValidatorArray; //fieldtype: CatalogLink
	CFixed CastMovementLimit; //fieldtype: Fixed
	CGameTime[] Precast; //fieldtype: Fixed
	CGameTime[] PrepTime; //fieldtype: Fixed
	CGameTime[] CastIntroTime; //fieldtype: Fixed
	CGameTime[] CastOutroTime; //fieldtype: Fixed
	CGameTime[] FinishTime; //fieldtype: Fixed
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CFlagArray<e_abilEffectStageCount>[] UseMarkerArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] ShowProgressArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] CancelableArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] PauseableArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] PreemptableArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] UninterruptibleArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] ValidatedArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] InheritAttackPriorityArray; //fieldtype: Flags
	CAlertLink ErrorAlert; //fieldtype: CatalogLink
	CAlertLink[] AlertArray; //fieldtype: CatalogLink
	CEffectLink[] CursorEffect; //fieldtype: CatalogLink
	CEffectLink[] CastOutroTimeEffect; //fieldtype: CatalogLink
	CEffectLink CalldownEffect; //fieldtype: CatalogLink
	CEffectLink AINotifyEffect; //fieldtype: CatalogLink
	CUnitLink[] ProducedUnitArray; //fieldtype: CatalogLink
	CButtonLink[] ProgressButtonArray; //fieldtype: CatalogLink
	CCmdResult DefaultError; //fieldtype: Unknown
	CImagePath[] LevelButtonImage; //fieldtype: String
	CStringLink[] LevelButtonName; //fieldtype: String
	CStringLink[] LevelButtonTooltip; //fieldtype: String
	CImagePath[] LevelButtonTooltipImage; //fieldtype: String
	CfRange[] EffectRange; //fieldtype: Unknown
	CImagePath[] LearnButtonImage; //fieldtype: String
	CStringLink[] LearnButtonName; //fieldtype: String
	CStringLink[] LearnButtonTooltip; //fieldtype: String
	CImagePath[] LearnButtonTooltipImage; //fieldtype: String
	CTargetFilters IgnoreFilters; //fieldtype: Unknown
	uint32 AcquirePriority; //fieldtype: IntUnsigned
	ECursorRangeMode CursorRangeMode; //enum
	EAbilLastTarget SetLastTarget; //fieldtype: Unknown
	SAbilTargetCursorInfo TargetCursorInfo //struct
	{
		CCursorLink Invalid; //fieldtype: CatalogLink
		CCursorLink Normal; //fieldtype: CatalogLink
		CCursorLink Allied; //fieldtype: CatalogLink
		CCursorLink Enemy; //fieldtype: CatalogLink
	}
	CEffectLink[] CancelEffect; //fieldtype: CatalogLink
	CGameTime[] CancelDelay; //fieldtype: Fixed
}

class CAbilQueueable
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CAlertLink ErrorAlert; //fieldtype: CatalogLink
	CStringLink Activity; //fieldtype: String
}

class CAbilRedirect
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	CAbilLink Abil; //fieldtype: CatalogLink
	TAbilCmdIndex Index; //fieldtype: IntUnsigned
	CFlags[] Flags; //fieldtype: Flags
}

class CAbilArmMagazine
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CAlertLink ErrorAlert; //fieldtype: CatalogLink
	CStringLink Activity; //fieldtype: String
	EAbilArmMagazineLaunch Launch; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFixed Leash; //fieldtype: Fixed
	SAbilArmMagazineInfo[] InfoArray //struct
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
		uint32 Count; //fieldtype: IntUnsigned
		uint32 CountStart; //fieldtype: IntUnsigned
		CFixed Distance; //fieldtype: Fixed
		CFlags[] Flags; //fieldtype: Flags
		EAbilArmMagazineManage Manage; //enum
		CUnitLink Unit; //fieldtype: CatalogLink
	}
	CAlertLink Alert; //fieldtype: CatalogLink
	CEffectLink[] EffectArray; //fieldtype: CatalogLink
	CFixed ReturnLifeFraction; //fieldtype: Fixed
	CEffectLink CalldownEffect; //fieldtype: CatalogLink
	CFangle[] ExternalAngle; //fieldtype: Fixed
	uint32 MaxCount; //fieldtype: IntUnsigned
}

class CAbilAttack
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CTargetFilters AcquireFilters; //fieldtype: Unknown
	CTargetFilters SmartFilters; //fieldtype: Unknown
	uint32 SmartPriority; //fieldtype: IntUnsigned
	CTargetFilters SupportedFilters; //fieldtype: Unknown
	CFixed MinAttackSpeedMultiplier; //fieldtype: Fixed
	CFixed MaxAttackSpeedMultiplier; //fieldtype: Fixed
	uint32 AcquirePriority; //fieldtype: IntUnsigned
	CFlags[] Flags; //fieldtype: Flags
	SAbilTargetCursorInfo TargetCursorInfo //struct
	{
		CCursorLink Invalid; //fieldtype: CatalogLink
		CCursorLink Normal; //fieldtype: CatalogLink
		CCursorLink Allied; //fieldtype: CatalogLink
		CCursorLink Enemy; //fieldtype: CatalogLink
	}
}

class CAbilAugment
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CFlags[] Flags; //fieldtype: Flags
	CAbilCommand AbilCmd; //fieldtype: Unknown
	EEffectLocationType TargetType; //enum
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
	CTargetFilters AutoCastFilters; //fieldtype: Unknown
	CValidatorLink[] AutoCastValidatorArray; //fieldtype: CatalogLink
	uint32 SmartPriority; //fieldtype: IntUnsigned
	CValidatorLink[] SmartValidatorArray; //fieldtype: CatalogLink
}

class CAbilAttackModifier
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	uint32 Levels; //fieldtype: IntUnsigned
	uint32 VeterancyLevelMin; //fieldtype: IntUnsigned
	uint32 VeterancyLevelSkip; //fieldtype: IntUnsigned
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CFlags[] Flags; //fieldtype: Flags
	EEffectLocationType TargetType; //enum
	SCost[] Cost //struct
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
	CTargetFilters AutoCastFilters; //fieldtype: Unknown
	CValidatorLink[] AutoCastValidatorArray; //fieldtype: CatalogLink
	uint32 SmartPriority; //fieldtype: IntUnsigned
	CValidatorLink[] SmartValidatorArray; //fieldtype: CatalogLink
	CBehaviorLink AttackModifierBehavior; //fieldtype: CatalogLink
}

class CAbilBattery
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CFlags[] Flags; //fieldtype: Flags
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CFixed Range; //fieldtype: Fixed
	CTargetFilters EnumFilters; //fieldtype: Unknown
	CFixed EnumRange; //fieldtype: Fixed
	CEffectLink Effect; //fieldtype: CatalogLink
	uint32 SmartPriority; //fieldtype: IntUnsigned
	CTargetFilters AutoCastFilters; //fieldtype: Unknown
	CFixed AutoCastRange; //fieldtype: Fixed
	CValidatorLink[] AutoCastValidatorArray; //fieldtype: CatalogLink
}

class CAbilBeacon
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	uint32 SmartPriority; //fieldtype: IntUnsigned
}

class CAbilBehavior
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	uint32 Levels; //fieldtype: IntUnsigned
	uint32 VeterancyLevelMin; //fieldtype: IntUnsigned
	uint32 VeterancyLevelSkip; //fieldtype: IntUnsigned
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CFlags[] Flags; //fieldtype: Flags
	SCost[] Cost //struct
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
	SCost[] OffCost //struct
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
	SCost[] ExpireCost //struct
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
	CBehaviorLinkArray[] BehaviorArray; //fieldtype: Unknown
	EAbilBehaviorCycleMode CycleMode; //enum
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] AutoCastValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] AutoCastToggleOnValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] AutoCastToggleOffValidatorArray; //fieldtype: CatalogLink
	CImagePath[] LevelButtonOnImage; //fieldtype: String
	CStringLink[] LevelButtonOnName; //fieldtype: String
	CStringLink[] LevelButtonOnTooltip; //fieldtype: String
	CImagePath[] LevelButtonOnTooltipImage; //fieldtype: String
	CImagePath[] LevelButtonOffImage; //fieldtype: String
	CStringLink[] LevelButtonOffName; //fieldtype: String
	CStringLink[] LevelButtonOffTooltip; //fieldtype: String
	CImagePath[] LevelButtonOffTooltipImage; //fieldtype: String
	CImagePath[] LearnButtonImage; //fieldtype: String
	CStringLink[] LearnButtonName; //fieldtype: String
	CStringLink[] LearnButtonTooltip; //fieldtype: String
	CImagePath[] LearnButtonTooltipImage; //fieldtype: String
}

class CAbilBuild
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilCmdButton HaltCmdButton //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CAbilLink BuildMorphAbil; //fieldtype: CatalogLink
	CAbilLink UnlinkMorphAbil; //fieldtype: CatalogLink
	CFlagArray<e_abilBuildFlagCount>[] FlagArray; //fieldtype: Flags
	CAlertLink Alert; //fieldtype: CatalogLink
	CAlertLink ErrorAlert; //fieldtype: CatalogLink
	SAbilBuildInfo[] InfoArray //struct
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
		CUnitLink Unit; //fieldtype: CatalogLink
		CGameTime Delay; //fieldtype: Fixed
		CGameTime Time; //fieldtype: Fixed
		CAlertLink Alert; //fieldtype: CatalogLink
		CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
		int32 AddOnParentCmdPriority; //fieldtype: IntSigned
		bool8 PeonKillFinish; //fieldtype: Unknown
	}
	EAbilBuildType Type; //enum
	CFixed Range; //fieldtype: Fixed
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CGameTime FidgetDelayMin; //fieldtype: Fixed
	CGameTime FidgetDelayMax; //fieldtype: Fixed
	CMoverLink ConstructionMover; //fieldtype: CatalogLink
	CEffectLink[] EffectArray; //fieldtype: CatalogLink
	uint32 SmartPriority; //fieldtype: IntUnsigned
}

class CAbilBuildable
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	CStringLink Activity; //fieldtype: String
	bool8 Cancelable; //fieldtype: Unknown
	CFixed[] VitalStartFactor; //fieldtype: Fixed
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	uint32 MaxBuilders; //fieldtype: IntUnsigned
	CFixed PowerBuildBonusRate; //fieldtype: Fixed
	CFixed PowerBuildCostFactor; //fieldtype: Fixed
}

class CAbilEffectInstant
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	uint32 Levels; //fieldtype: IntUnsigned
	uint32 VeterancyLevelMin; //fieldtype: IntUnsigned
	uint32 VeterancyLevelSkip; //fieldtype: IntUnsigned
	CStringLink Activity; //fieldtype: String
	CEffectLink[] PrepEffect; //fieldtype: CatalogLink
	CEffectLink[] Effect; //fieldtype: CatalogLink
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
	CFlagArray<e_abilEffectFlagCount>[] Flags; //fieldtype: Flags
	SCost[] Cost //struct
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
	SAccumulatedFixed[] ExtraVitalCost //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	SCost[] CancelCost //struct
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
	CFlagArray<e_abilEffectStageCount>[] RefundArray; //fieldtype: Flags
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CFlagArray<e_abilEffectStageCount>[] InterruptArray; //fieldtype: Flags
	SCost InterruptCost //struct
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
	CUnitLink Placeholder; //fieldtype: CatalogLink
	CTargetFilters[] TargetFilters; //fieldtype: Unknown
	STargetSorts TargetSorts //struct
	{
		CTargetSortLink[] SortArray; //fieldtype: CatalogLink
		uint32 RequestCount; //fieldtype: IntUnsigned
		CFixed RequestPercentage; //fieldtype: Fixed
	}
	CFixed[] Range; //fieldtype: Fixed
	CFixed RangeSlop; //fieldtype: Fixed
	CFangleArc Arc; //fieldtype: Fixed
	CFangleArc ArcSlop; //fieldtype: Fixed
	CFangleArc TrackingArc; //fieldtype: Fixed
	uint32 SmartPriority; //fieldtype: IntUnsigned
	CValidatorLink[] SmartValidatorArray; //fieldtype: CatalogLink
	EAcquireLevel AutoCastAcquireLevel; //enum
	CTargetFilters AutoCastFilters; //fieldtype: Unknown
	CFixed AutoCastRange; //fieldtype: Fixed
	CValidatorLink[] AutoCastValidatorArray; //fieldtype: CatalogLink
	CFixed CastMovementLimit; //fieldtype: Fixed
	CGameTime[] Precast; //fieldtype: Fixed
	CGameTime[] PrepTime; //fieldtype: Fixed
	CGameTime[] CastIntroTime; //fieldtype: Fixed
	CGameTime[] CastOutroTime; //fieldtype: Fixed
	CGameTime[] FinishTime; //fieldtype: Fixed
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CFlagArray<e_abilEffectStageCount>[] UseMarkerArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] ShowProgressArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] CancelableArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] PauseableArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] PreemptableArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] UninterruptibleArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] ValidatedArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] InheritAttackPriorityArray; //fieldtype: Flags
	CAlertLink ErrorAlert; //fieldtype: CatalogLink
	CAlertLink[] AlertArray; //fieldtype: CatalogLink
	CEffectLink[] CursorEffect; //fieldtype: CatalogLink
	CEffectLink[] CastOutroTimeEffect; //fieldtype: CatalogLink
	CEffectLink CalldownEffect; //fieldtype: CatalogLink
	CEffectLink AINotifyEffect; //fieldtype: CatalogLink
	CUnitLink[] ProducedUnitArray; //fieldtype: CatalogLink
	CButtonLink[] ProgressButtonArray; //fieldtype: CatalogLink
	CCmdResult DefaultError; //fieldtype: Unknown
	CImagePath[] LevelButtonImage; //fieldtype: String
	CStringLink[] LevelButtonName; //fieldtype: String
	CStringLink[] LevelButtonTooltip; //fieldtype: String
	CImagePath[] LevelButtonTooltipImage; //fieldtype: String
	CfRange[] EffectRange; //fieldtype: Unknown
	CImagePath[] LearnButtonImage; //fieldtype: String
	CStringLink[] LearnButtonName; //fieldtype: String
	CStringLink[] LearnButtonTooltip; //fieldtype: String
	CImagePath[] LearnButtonTooltipImage; //fieldtype: String
	CTargetFilters IgnoreFilters; //fieldtype: Unknown
	uint32 AcquirePriority; //fieldtype: IntUnsigned
	ECursorRangeMode CursorRangeMode; //enum
	EAbilLastTarget SetLastTarget; //fieldtype: Unknown
	SAbilTargetCursorInfo TargetCursorInfo //struct
	{
		CCursorLink Invalid; //fieldtype: CatalogLink
		CCursorLink Normal; //fieldtype: CatalogLink
		CCursorLink Allied; //fieldtype: CatalogLink
		CCursorLink Enemy; //fieldtype: CatalogLink
	}
	CEffectLink[] CancelEffect; //fieldtype: CatalogLink
	CGameTime[] CancelDelay; //fieldtype: Fixed
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
}

class CAbilEffectTarget
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	uint32 Levels; //fieldtype: IntUnsigned
	uint32 VeterancyLevelMin; //fieldtype: IntUnsigned
	uint32 VeterancyLevelSkip; //fieldtype: IntUnsigned
	CStringLink Activity; //fieldtype: String
	CEffectLink[] PrepEffect; //fieldtype: CatalogLink
	CEffectLink[] Effect; //fieldtype: CatalogLink
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
	CFlagArray<e_abilEffectFlagCount>[] Flags; //fieldtype: Flags
	SCost[] Cost //struct
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
	SAccumulatedFixed[] ExtraVitalCost //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
	SCost[] CancelCost //struct
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
	CFlagArray<e_abilEffectStageCount>[] RefundArray; //fieldtype: Flags
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CFlagArray<e_abilEffectStageCount>[] InterruptArray; //fieldtype: Flags
	SCost InterruptCost //struct
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
	CUnitLink Placeholder; //fieldtype: CatalogLink
	CTargetFilters[] TargetFilters; //fieldtype: Unknown
	STargetSorts TargetSorts //struct
	{
		CTargetSortLink[] SortArray; //fieldtype: CatalogLink
		uint32 RequestCount; //fieldtype: IntUnsigned
		CFixed RequestPercentage; //fieldtype: Fixed
	}
	CFixed[] Range; //fieldtype: Fixed
	CFixed RangeSlop; //fieldtype: Fixed
	CFangleArc Arc; //fieldtype: Fixed
	CFangleArc ArcSlop; //fieldtype: Fixed
	CFangleArc TrackingArc; //fieldtype: Fixed
	uint32 SmartPriority; //fieldtype: IntUnsigned
	CValidatorLink[] SmartValidatorArray; //fieldtype: CatalogLink
	EAcquireLevel AutoCastAcquireLevel; //enum
	CTargetFilters AutoCastFilters; //fieldtype: Unknown
	CFixed AutoCastRange; //fieldtype: Fixed
	CValidatorLink[] AutoCastValidatorArray; //fieldtype: CatalogLink
	CFixed CastMovementLimit; //fieldtype: Fixed
	CGameTime[] Precast; //fieldtype: Fixed
	CGameTime[] PrepTime; //fieldtype: Fixed
	CGameTime[] CastIntroTime; //fieldtype: Fixed
	CGameTime[] CastOutroTime; //fieldtype: Fixed
	CGameTime[] FinishTime; //fieldtype: Fixed
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CFlagArray<e_abilEffectStageCount>[] UseMarkerArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] ShowProgressArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] CancelableArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] PauseableArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] PreemptableArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] UninterruptibleArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] ValidatedArray; //fieldtype: Flags
	CFlagArray<e_abilEffectStageCount>[] InheritAttackPriorityArray; //fieldtype: Flags
	CAlertLink ErrorAlert; //fieldtype: CatalogLink
	CAlertLink[] AlertArray; //fieldtype: CatalogLink
	CEffectLink[] CursorEffect; //fieldtype: CatalogLink
	CEffectLink[] CastOutroTimeEffect; //fieldtype: CatalogLink
	CEffectLink CalldownEffect; //fieldtype: CatalogLink
	CEffectLink AINotifyEffect; //fieldtype: CatalogLink
	CUnitLink[] ProducedUnitArray; //fieldtype: CatalogLink
	CButtonLink[] ProgressButtonArray; //fieldtype: CatalogLink
	CCmdResult DefaultError; //fieldtype: Unknown
	CImagePath[] LevelButtonImage; //fieldtype: String
	CStringLink[] LevelButtonName; //fieldtype: String
	CStringLink[] LevelButtonTooltip; //fieldtype: String
	CImagePath[] LevelButtonTooltipImage; //fieldtype: String
	CfRange[] EffectRange; //fieldtype: Unknown
	CImagePath[] LearnButtonImage; //fieldtype: String
	CStringLink[] LearnButtonName; //fieldtype: String
	CStringLink[] LearnButtonTooltip; //fieldtype: String
	CImagePath[] LearnButtonTooltipImage; //fieldtype: String
	CTargetFilters IgnoreFilters; //fieldtype: Unknown
	uint32 AcquirePriority; //fieldtype: IntUnsigned
	ECursorRangeMode CursorRangeMode; //enum
	EAbilLastTarget SetLastTarget; //fieldtype: Unknown
	SAbilTargetCursorInfo TargetCursorInfo //struct
	{
		CCursorLink Invalid; //fieldtype: CatalogLink
		CCursorLink Normal; //fieldtype: CatalogLink
		CCursorLink Allied; //fieldtype: CatalogLink
		CCursorLink Enemy; //fieldtype: CatalogLink
	}
	CEffectLink[] CancelEffect; //fieldtype: CatalogLink
	CGameTime[] CancelDelay; //fieldtype: Fixed
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CUnitLink PlaceUnit; //fieldtype: CatalogLink
	bool8 AcquireAttackers; //fieldtype: Unknown
	CFixed FollowRange; //fieldtype: Fixed
	CAbilCommand FinishCommand; //fieldtype: Unknown
}

class CAbilHarvest
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CFlagArray<e_abilHarvestFlagCount>[] FlagArray; //fieldtype: Flags
	CFixed Range; //fieldtype: Fixed
	CFixed AcquireRadius; //fieldtype: Fixed
	CEffectLink Effect; //fieldtype: CatalogLink
	CGameTime EffectDelay; //fieldtype: Fixed
	SMarker ReservedMarker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	CFlagArray<e_resourceTypeCount>[] ResourceAcquire; //fieldtype: Flags
	CFlagArray<e_resourceTypeCount>[] ResourceAllowed; //fieldtype: Flags
	CFlagArray<e_resourceTypeCount>[] ResourceDestroy; //fieldtype: Flags
	uint32[] ResourceAmountBonus; //fieldtype: IntUnsigned
	CFixed[] ResourceAmountMultiplier; //fieldtype: Fixed
	uint32[] ResourceAmountRequest; //fieldtype: IntUnsigned
	uint32[] ResourceAmountCapacity; //fieldtype: IntUnsigned
	CGameTime[] ResourceTimeBonus; //fieldtype: Fixed
	CFixed[] ResourceTimeMultiplier; //fieldtype: Fixed
	CFlagArray<e_abilHarvestStageCount>[] CancelableArray; //fieldtype: Flags
	CFlagArray<e_abilHarvestStageCount>[] UninterruptibleArray; //fieldtype: Flags
	uint32 SmartPriority; //fieldtype: IntUnsigned
	uint32 ResourceQueueIndex; //fieldtype: IntUnsigned
}

class CAbilInteract
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CFlags[] Flags; //fieldtype: Flags
	CFixed Range; //fieldtype: Fixed
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	uint32 SmartPriority; //fieldtype: IntUnsigned
	CValidatorLink[] SmartValidatorArray; //fieldtype: CatalogLink
	CTargetFilters AutoCastFilters; //fieldtype: Unknown
	CFixed AutoCastRange; //fieldtype: Fixed
	CValidatorLink[] AutoCastValidatorArray; //fieldtype: CatalogLink
}

class CAbilInventory
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CFlags[] Flags; //fieldtype: Flags
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CFixed Range; //fieldtype: Fixed
	CFixed MaxDropRange; //fieldtype: Fixed
	SAbilInventoryInfo[] InfoArray //struct
	{
		EAbilInventoryAlignment Alignment; //enum
		CItemContainerLink Container; //fieldtype: CatalogLink
		CUnitLink Item; //fieldtype: CatalogLink
		CButtonLink EmptyFace; //fieldtype: CatalogLink
		CItemClassLink[] Classes; //fieldtype: CatalogLink
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	}
	uint32 SmartPriority; //fieldtype: IntUnsigned
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
}

class CAbilLearn
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CAlertLink ErrorAlert; //fieldtype: CatalogLink
	CStringLink Activity; //fieldtype: String
	SAbilLearnInfo[] InfoArray //struct
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
	CFlags[] Flags; //fieldtype: Flags
	uint32 Points; //fieldtype: IntUnsigned
	uint32 PointsPerLevel; //fieldtype: IntUnsigned
	CBehaviorLink VeterancyBehavior; //fieldtype: CatalogLink
}

class CAbilMerge
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CFlags[] Flags; //fieldtype: Flags
	CAlertLink Alert; //fieldtype: CatalogLink
	CEffectLink Effect; //fieldtype: CatalogLink
	SAbilMergeInfo Info //struct
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
		CUnitLink Unit; //fieldtype: CatalogLink
		CGameTime Time; //fieldtype: Fixed
	}
	CFixed Range; //fieldtype: Fixed
}

class CAbilMergeable
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	CStringLink Activity; //fieldtype: String
	bool8 Cancelable; //fieldtype: Unknown
	CFixed[] VitalStartFactor; //fieldtype: Fixed
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
}

class CAbilMorph
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	uint32 VeterancyLevelMin; //fieldtype: IntUnsigned
	uint32 VeterancyLevelSkip; //fieldtype: IntUnsigned
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CDataSoupKey ActorKey; //fieldtype: String
	CFlags[] Flags; //fieldtype: Flags
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
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
	SCost CostUnmorph //struct
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
	CUnitLink CancelUnit; //fieldtype: CatalogLink
	SAbilMorphInfo[] InfoArray //struct
	{
		bool8 Score; //fieldtype: Unknown
		CUnitLink Unit; //fieldtype: CatalogLink
		CFixed CollideRange; //fieldtype: Fixed
		SAbilMorphSection[] SectionArray //struct
		{
			CGameTime[] DurationArray; //fieldtype: Fixed
			bool8[] UseBuildTimeArray; //fieldtype: Unknown
			CEffectLink[] EffectArray; //fieldtype: CatalogLink
		}
		EAbilMorphPhase RallyResetPhase; //enum
		EAbilMorphSection RallyResetSection; //enum
		CGameTime RandomDelayMin; //fieldtype: Fixed
		CGameTime RandomDelayMax; //fieldtype: Fixed
	}
	SAbilMorphInfo[] InfoArrayUnmorph //struct
	{
		bool8 Score; //fieldtype: Unknown
		CUnitLink Unit; //fieldtype: CatalogLink
		CFixed CollideRange; //fieldtype: Fixed
		SAbilMorphSection[] SectionArray //struct
		{
			CGameTime[] DurationArray; //fieldtype: Fixed
			bool8[] UseBuildTimeArray; //fieldtype: Unknown
			CEffectLink[] EffectArray; //fieldtype: CatalogLink
		}
		EAbilMorphPhase RallyResetPhase; //enum
		EAbilMorphSection RallyResetSection; //enum
		CGameTime RandomDelayMin; //fieldtype: Fixed
		CGameTime RandomDelayMax; //fieldtype: Fixed
	}
	CAlertLink StartGlobalAlert; //fieldtype: CatalogLink
	CAlertLink FinishGlobalAlert; //fieldtype: CatalogLink
	CAlertLink Alert; //fieldtype: CatalogLink
	CAlertLink ErrorAlert; //fieldtype: CatalogLink
	CFixed Range; //fieldtype: Fixed
	EAcquireLevel AutoCastAcquireLevel; //enum
	CTargetFilters AutoCastFilters; //fieldtype: Unknown
	CValidatorLink[] AutoCastValidatorArray; //fieldtype: CatalogLink
	CFixed AutoCastRange; //fieldtype: Fixed
	uint32 AutoCastCountMin; //fieldtype: IntUnsigned
	uint32 AutoCastCountMax; //fieldtype: IntUnsigned
	STargetSorts TargetSorts //struct
	{
		CTargetSortLink[] SortArray; //fieldtype: CatalogLink
		uint32 RequestCount; //fieldtype: IntUnsigned
		CFixed RequestPercentage; //fieldtype: Fixed
	}
	CCmdResult CantFindTargetError; //fieldtype: Unknown
	CCmdResult CantFindTargetErrorUnmorph; //fieldtype: Unknown
	CStringLink Activity; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] ValidatorArrayUnmorph; //fieldtype: CatalogLink
	CFlagArray<e_classIdCAbilCount>[] AbilClassEnableArray; //fieldtype: Flags
	CFlagArray<e_classIdCAbilCount>[] AbilClassDisableArray; //fieldtype: Flags
	CAbilLink[] AbilLinkEnableArray; //fieldtype: CatalogLink
	CAbilLink[] AbilLinkDisableArray; //fieldtype: CatalogLink
	CButtonLink ProgressButton; //fieldtype: CatalogLink
	uint32 AcquirePriority; //fieldtype: IntUnsigned
	CBehaviorLink BehaviorOn; //fieldtype: CatalogLink
	CBehaviorLink BehaviorOff; //fieldtype: CatalogLink
}

class CAbilMorphPlacement
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	uint32 VeterancyLevelMin; //fieldtype: IntUnsigned
	uint32 VeterancyLevelSkip; //fieldtype: IntUnsigned
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CDataSoupKey ActorKey; //fieldtype: String
	CFlags[] Flags; //fieldtype: Flags
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
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
	SCost CostUnmorph //struct
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
	CUnitLink CancelUnit; //fieldtype: CatalogLink
	SAbilMorphInfo[] InfoArray //struct
	{
		bool8 Score; //fieldtype: Unknown
		CUnitLink Unit; //fieldtype: CatalogLink
		CFixed CollideRange; //fieldtype: Fixed
		SAbilMorphSection[] SectionArray //struct
		{
			CGameTime[] DurationArray; //fieldtype: Fixed
			bool8[] UseBuildTimeArray; //fieldtype: Unknown
			CEffectLink[] EffectArray; //fieldtype: CatalogLink
		}
		EAbilMorphPhase RallyResetPhase; //enum
		EAbilMorphSection RallyResetSection; //enum
		CGameTime RandomDelayMin; //fieldtype: Fixed
		CGameTime RandomDelayMax; //fieldtype: Fixed
	}
	SAbilMorphInfo[] InfoArrayUnmorph //struct
	{
		bool8 Score; //fieldtype: Unknown
		CUnitLink Unit; //fieldtype: CatalogLink
		CFixed CollideRange; //fieldtype: Fixed
		SAbilMorphSection[] SectionArray //struct
		{
			CGameTime[] DurationArray; //fieldtype: Fixed
			bool8[] UseBuildTimeArray; //fieldtype: Unknown
			CEffectLink[] EffectArray; //fieldtype: CatalogLink
		}
		EAbilMorphPhase RallyResetPhase; //enum
		EAbilMorphSection RallyResetSection; //enum
		CGameTime RandomDelayMin; //fieldtype: Fixed
		CGameTime RandomDelayMax; //fieldtype: Fixed
	}
	CAlertLink StartGlobalAlert; //fieldtype: CatalogLink
	CAlertLink FinishGlobalAlert; //fieldtype: CatalogLink
	CAlertLink Alert; //fieldtype: CatalogLink
	CAlertLink ErrorAlert; //fieldtype: CatalogLink
	CFixed Range; //fieldtype: Fixed
	EAcquireLevel AutoCastAcquireLevel; //enum
	CTargetFilters AutoCastFilters; //fieldtype: Unknown
	CValidatorLink[] AutoCastValidatorArray; //fieldtype: CatalogLink
	CFixed AutoCastRange; //fieldtype: Fixed
	uint32 AutoCastCountMin; //fieldtype: IntUnsigned
	uint32 AutoCastCountMax; //fieldtype: IntUnsigned
	STargetSorts TargetSorts //struct
	{
		CTargetSortLink[] SortArray; //fieldtype: CatalogLink
		uint32 RequestCount; //fieldtype: IntUnsigned
		CFixed RequestPercentage; //fieldtype: Fixed
	}
	CCmdResult CantFindTargetError; //fieldtype: Unknown
	CCmdResult CantFindTargetErrorUnmorph; //fieldtype: Unknown
	CStringLink Activity; //fieldtype: String
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] ValidatorArrayUnmorph; //fieldtype: CatalogLink
	CFlagArray<e_classIdCAbilCount>[] AbilClassEnableArray; //fieldtype: Flags
	CFlagArray<e_classIdCAbilCount>[] AbilClassDisableArray; //fieldtype: Flags
	CAbilLink[] AbilLinkEnableArray; //fieldtype: CatalogLink
	CAbilLink[] AbilLinkDisableArray; //fieldtype: CatalogLink
	CButtonLink ProgressButton; //fieldtype: CatalogLink
	uint32 AcquirePriority; //fieldtype: IntUnsigned
	CBehaviorLink BehaviorOn; //fieldtype: CatalogLink
	CBehaviorLink BehaviorOff; //fieldtype: CatalogLink
}

class CAbilMove
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CFixed FleeRange; //fieldtype: Fixed
	CGameTime FleeTime; //fieldtype: Fixed
	CFixed FollowRangeSlop; //fieldtype: Fixed
	CFixed FollowAcquireRange; //fieldtype: Fixed
	CFixed MinPatrolDistance; //fieldtype: Fixed
	CTargetFilters FollowFilters; //fieldtype: Unknown
	CTargetFilters MoveFilters; //fieldtype: Unknown
	CFlags[] Flags; //fieldtype: Flags
	uint32 MoveSmartPriority; //fieldtype: IntUnsigned
	uint32 BoardBunkerSmartPriority; //fieldtype: IntUnsigned
	uint32 BoardTransportSmartPriority; //fieldtype: IntUnsigned
	uint32 PowerupSmartPriority; //fieldtype: IntUnsigned
	uint32 RechargeSmartPriority; //fieldtype: IntUnsigned
	CFixed IgnoreRange; //fieldtype: Fixed
}

class CAbilPawn
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilPawnInfo[] InfoArray //struct
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
		CItemClassLink ClassRequired; //fieldtype: CatalogLink
		CItemClassLink[] ClassesExcluded; //fieldtype: CatalogLink
		CFixed[] RefundFraction; //fieldtype: Fixed
		CTargetFilters TargetFilters; //fieldtype: Unknown
		CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	}
	CFlags[] Flags; //fieldtype: Flags
	CFixed Range; //fieldtype: Fixed
}

class CAbilQueue
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	uint32 QueueCount; //fieldtype: IntUnsigned
	uint32 QueueSize; //fieldtype: IntUnsigned
	CFlags[] Flags; //fieldtype: Flags
	CFlagArray<e_classIdCAbilCount>[] AddOnParentAbilClassDisableArray; //fieldtype: Flags
}

class CAbilRally
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	SAbilRallyInfo[] InfoArray //struct
	{
		bool8 AllowSetOnGround; //fieldtype: Unknown
		CTargetFilters AllowSetFilters; //fieldtype: Unknown
		CValidatorLink[] AllowSetValidators; //fieldtype: CatalogLink
		bool8 SetOnGround; //fieldtype: Unknown
		CTargetFilters SetFilters; //fieldtype: Unknown
		CValidatorLink[] SetValidators; //fieldtype: CatalogLink
		CTargetFilters UseFilters; //fieldtype: Unknown
		CValidatorLink[] UseValidators; //fieldtype: CatalogLink
	}
	CFlags[] Flags; //fieldtype: Flags
	uint32 SmartPriority; //fieldtype: IntUnsigned
}

class CAbilRedirectInstant
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	CAbilLink Abil; //fieldtype: CatalogLink
	TAbilCmdIndex Index; //fieldtype: IntUnsigned
	CFlags[] Flags; //fieldtype: Flags
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
}

class CAbilRedirectTarget
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	CAbilLink Abil; //fieldtype: CatalogLink
	TAbilCmdIndex Index; //fieldtype: IntUnsigned
	CFlags[] Flags; //fieldtype: Flags
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
}

class CAbilResearch
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CAlertLink ErrorAlert; //fieldtype: CatalogLink
	CStringLink Activity; //fieldtype: String
	SAbilResearchInfo[] InfoArray //struct
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
		CUpgradeLink Upgrade; //fieldtype: CatalogLink
	}
	CFlags[] Flags; //fieldtype: Flags
}

class CAbilRevive
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CAlertLink ErrorAlert; //fieldtype: CatalogLink
	CStringLink Activity; //fieldtype: String
	SAbilReviveCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
		uint32 ReviverIndex; //fieldtype: IntUnsigned
		CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	}
	CFlags[] Flags; //fieldtype: Flags
	SAbilReviveInfo BaseInfo //struct
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
		CAlertLink Alert; //fieldtype: CatalogLink
	}
	SAbilReviveInfo LevelInfo //struct
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
		CAlertLink Alert; //fieldtype: CatalogLink
	}
	SAbilReviveInfoMax MaxInfo //struct
	{
		CFixed[] ResourceFactor; //fieldtype: Fixed
		CFixed TimeFactor; //fieldtype: Fixed
		int32[] Resource; //fieldtype: IntSigned
		CGameTime Time; //fieldtype: Fixed
	}
	SCostFactor BaseUnitCostFactor //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	SCostFactor LevelUnitCostFactor //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CFixed LevelUnitBuildTimeFactor; //fieldtype: Fixed
	CDataSoupKey ActorKey; //fieldtype: String
	CEffectLink Effect; //fieldtype: CatalogLink
	CGamePoint[] Offset; //fieldtype: Unknown
	CFixed Range; //fieldtype: Fixed
	EAbilReviveVital[] VitalArray; //enum
	CAlertLink Alert; //fieldtype: CatalogLink
	CStringLink NameOverride; //fieldtype: String
	CTargetFilters ReplaceFilters; //fieldtype: Unknown
	EDeathType ReplaceDeathType; //enum
	EAbilReviveCmd SelfReviveCmd; //enum
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	EEffectLocationType TargetType; //enum
	CBehaviorLink VeterancyBehavior; //fieldtype: CatalogLink
}

class CAbilSpecialize
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CAlertLink ErrorAlert; //fieldtype: CatalogLink
	CStringLink Activity; //fieldtype: String
	SAbilSpecializeInfo[] InfoArray //struct
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
		CEffectLink Effect; //fieldtype: CatalogLink
		CFlags[] Flags; //fieldtype: Flags
	}
	uint32 MaxCount; //fieldtype: IntUnsigned
	CAlertLink Alert; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
}

class CAbilStop
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CFlags[] Flags; //fieldtype: Flags
	uint32 RequestPickupBunkerSmartPriority; //fieldtype: IntUnsigned
	uint32 RequestPickupTransportSmartPriority; //fieldtype: IntUnsigned
}

class CAbilTrain
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CAlertLink ErrorAlert; //fieldtype: CatalogLink
	CStringLink Activity; //fieldtype: String
	CDataSoupKey ActorKey; //fieldtype: String
	CFlags[] Flags; //fieldtype: Flags
	CUnitLink MorphUnit; //fieldtype: CatalogLink
	CGamePoint[] Offset; //fieldtype: Unknown
	CFixed Range; //fieldtype: Fixed
	SAbilTrainInfo[] InfoArray //struct
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
		CUnitLink[] Unit; //fieldtype: CatalogLink
		CEffectLink Effect; //fieldtype: CatalogLink
		EAbilTrainLocation Location; //enum
		EAbilTrainRotation Rotation; //enum
		CFlags[] Flags; //fieldtype: Flags
	}
	const CTechRequirementsGraph* IgnoreUnitCostRequirements; //fieldtype: Unknown
	CAlertLink Alert; //fieldtype: CatalogLink
	CGamePoint[] ProxyOffset; //fieldtype: Unknown
	CUnitLink ProxyUnit; //fieldtype: CatalogLink
	EDeathType DeathTypeOnFinish; //enum
	EDeathType DeathTypeOnCancel; //enum
	CValidatorLink AgentUnitValidator; //fieldtype: CatalogLink
}

class CAbilTransport
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CFlags[] Flags; //fieldtype: Flags
	CFixed Range; //fieldtype: Fixed
	CFixed MaxUnloadRange; //fieldtype: Fixed
	uint32 MaxCargoCount; //fieldtype: IntUnsigned
	TCargoSize MaxCargoSize; //fieldtype: Unknown
	TCargoCapacity TotalCargoSpace; //fieldtype: IntUnsigned
	CBehaviorLink LoadCargoBehavior; //fieldtype: CatalogLink
	CEffectLink LoadCargoEffect; //fieldtype: CatalogLink
	CEffectLink LoadTransportEffect; //fieldtype: CatalogLink
	CBehaviorLink LoadTransportBehavior; //fieldtype: CatalogLink
	CBehaviorLink UnloadCargoBehavior; //fieldtype: CatalogLink
	CEffectLink UnloadCargoEffect; //fieldtype: CatalogLink
	CEffectLink UnloadTransportEffect; //fieldtype: CatalogLink
	CBehaviorLink UnloadTransportBehavior; //fieldtype: CatalogLink
	CGameTime InitialLoadDelay; //fieldtype: Fixed
	CGameTime InitialUnloadDelay; //fieldtype: Fixed
	CGameTime LoadPeriod; //fieldtype: Fixed
	CGameTime UnloadPeriod; //fieldtype: Fixed
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CFixed SearchRadius; //fieldtype: Fixed
	CValidatorLink[] LoadValidatorArray; //fieldtype: CatalogLink
	CValidatorLink[] UnloadValidatorArray; //fieldtype: CatalogLink
	STargetSorts TargetSorts //struct
	{
		CTargetSortLink[] SortArray; //fieldtype: CatalogLink
		uint32 RequestCount; //fieldtype: IntUnsigned
		CFixed RequestPercentage; //fieldtype: Fixed
	}
	CEffectLink CalldownEffect; //fieldtype: CatalogLink
	CEffectLink DeathUnloadEffect; //fieldtype: CatalogLink
	CAlertLink ErrorAlert; //fieldtype: CatalogLink
	uint32 LoadSmartPriority; //fieldtype: IntUnsigned
	CIdentifier CargoFilter; //fieldtype: String
}

class CAbilWarpable
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	CStringLink Activity; //fieldtype: String
	bool8 Cancelable; //fieldtype: Unknown
	CFixed[] VitalStartFactor; //fieldtype: Fixed
	SAbilCmdButton[] CmdButtonArray //struct
	{
		CIdentifier AutoQueueId; //fieldtype: String
		CButtonLink DefaultButtonFace; //fieldtype: CatalogLink
		CAbilCmdFlags[] Flags; //fieldtype: Flags
		EAbilCmdState State; //enum
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		TPreemptLevel PreemptLevel; //fieldtype: IntSigned
	}
	CBehaviorLink PowerUserBehavior; //fieldtype: CatalogLink
}

class CAbilWarpTrain
{
	CStringLink Name; //fieldtype: String
	EAbilTechPlayer TechPlayer; //enum
	EAbilAlignment Alignment; //enum
	SAbilOrderDisplay[] OrderArray //struct
	{
		EAbilOrderDisplayType DisplayType; //enum
		CColor Color; //fieldtype: Unknown
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		CImagePath LineTexture; //fieldtype: String
	}
	CAbilSetId AbilSetId; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	uint32 InfoTooltipPriority; //fieldtype: IntUnsigned
	CStringLink TargetMessage; //fieldtype: String
	TTechAlias[] TechAliasArray; //fieldtype: String
	CFlagArray<e_abilSharedFlagCount>[] SharedFlags; //fieldtype: Flags
	bool8 DebugTrace; //fieldtype: Unknown
	CFlags[] AbilityCategories; //fieldtype: Flags
	TGalaxyFunction TacticalAIFunc; //fieldtype: String
	CBehaviorLink StateBehavior; //fieldtype: CatalogLink
	CFourCC DefaultButtonCardId; //fieldtype: FourCC
	CDataCollectionLink DataCollection; //fieldtype: CatalogLink
	SAbilWarpTrainInfo[] InfoArray //struct
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
		CUnitLink Unit; //fieldtype: CatalogLink
	}
	CAlertLink Alert; //fieldtype: CatalogLink
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CFlags[] Flags; //fieldtype: Flags
}
