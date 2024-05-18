
class CAchievement
{
	CStringLink Category; //fieldtype: String
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CRewardLink Icon; //fieldtype: CatalogLink
	uint32 Points; //fieldtype: IntUnsigned
	CRewardLink[] RewardTable; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CRaceLink Race; //fieldtype: CatalogLink
	CFlags[] Filters; //fieldtype: Flags
	uint32 MinTermCount; //fieldtype: IntUnsigned
	CAchievementTermLink[] TermTable; //fieldtype: CatalogLink
	CAchievementLink SharesTerms; //fieldtype: CatalogLink
	CAchievementLink Supersedes; //fieldtype: CatalogLink
	SAchievementTag[] Tags //struct
	{
		CFourCC Value; //fieldtype: FourCC
		EAchievementTagCheck Check; //enum
	}
}

class CAchievementTerm
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
}

class CAchievementTermAbil
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CAbilCommand AbilCmd; //fieldtype: Unknown
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermAbilInteract
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CAbilCommand AbilCmd; //fieldtype: Unknown
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermAbilLoad
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CAbilCommand AbilCmd; //fieldtype: Unknown
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermAbilUse
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CAbilCommand AbilCmd; //fieldtype: Unknown
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermAchievement
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CAchievementLink Child; //fieldtype: CatalogLink
}

class CAchievementTermBehavior
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CBehaviorLink Behavior; //fieldtype: CatalogLink
}

class CAchievementTermBehaviorAbsorbed
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CBehaviorLink Behavior; //fieldtype: CatalogLink
}

class CAchievementTermBehaviorCount
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CBehaviorLink Behavior; //fieldtype: CatalogLink
}

class CAchievementTermBehaviorElapsed
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	CGameTime ElapsedTime; //fieldtype: Fixed
	EValueCompare ElapsedCompare; //enum
}

class CAchievementTermBehaviorState
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	bool32 State; //fieldtype: Unknown
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermCombine
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	EAchievementTermCombine Type; //enum
	CAchievementTermLink[] ChildTable; //fieldtype: CatalogLink
}

class CAchievementTermEffect
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CEffectLink Effect; //fieldtype: CatalogLink
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermEffectAbsorbed
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CEffectLink Effect; //fieldtype: CatalogLink
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermEffectDamaged
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CEffectLink Effect; //fieldtype: CatalogLink
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermEffectDodged
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CEffectLink Effect; //fieldtype: CatalogLink
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermEffectHealed
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CEffectLink Effect; //fieldtype: CatalogLink
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermEffectKilled
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CEffectLink Effect; //fieldtype: CatalogLink
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermEffectUse
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CEffectLink Effect; //fieldtype: CatalogLink
	SEffectWhichPlayer WhichPlayer //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectPlayer Value; //enum
	}
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermGeneric
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
}

class CAchievementTermReplay
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
}

class CAchievementTermScoreValue
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CScoreValueLink ScoreValue; //fieldtype: CatalogLink
}

class CAchievementTermTime
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
}

class CAchievementTermUnit
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CUnitLink Unit; //fieldtype: CatalogLink
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermUnitBirth
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CUnitLink Unit; //fieldtype: CatalogLink
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermUnitDeath
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CUnitLink Unit; //fieldtype: CatalogLink
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermUnitKills
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CUnitLink Unit; //fieldtype: CatalogLink
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
}

class CAchievementTermUnitRegen
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CUnitLink Unit; //fieldtype: CatalogLink
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	EUnitVital Vital; //enum
}

class CAchievementTermUnitSupplyLoss
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EAchievementTermEvaluate Evaluate; //enum
	CFlags[] Flags; //fieldtype: Flags
	EValueCompare Compare; //enum
	EAchievementTermPrevious Previous; //enum
	uint64 Quantity; //fieldtype: IntUnsigned
	uint64 Repeat; //fieldtype: IntUnsigned
	CUnitLink Unit; //fieldtype: CatalogLink
	CValidatorLink[] ValidatorArray; //fieldtype: CatalogLink
	CGameTime Period; //fieldtype: Fixed
}
