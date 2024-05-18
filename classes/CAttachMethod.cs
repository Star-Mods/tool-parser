
class CAttachMethod
{
}

class CAttachMethodArcTest
{
	CFlags[] Tests; //fieldtype: Flags
	EAMArcTestType Type; //enum
}

class CAttachMethodBestMatch
{
	CAttachKeys Keys; //fieldtype: Unknown
	CFlags[] Flags; //fieldtype: Flags
}

class CAttachMethodFilter
{
	SAttachKey[] Keys //struct
	{
		EAttachKeyword Keyword; //enum
		TAttachPropIndex Index; //fieldtype: IntSigned
	}
	EAMFilterLogic Logic; //enum
	EAMFilterAttachType AttachType; //enum
	EAMFilterType FilterType; //enum
}

class CAttachMethodAttachType
{
	EAMAttachType AttachType; //enum
}

class CAttachMethodIncoming
{
}

class CAttachMethodLeastDeflection
{
}

class CAttachMethodNodeOccupancy
{
	CModelPath[] Targets; //fieldtype: String
	EAMOccupancyLogic Logic; //enum
}

class CAttachMethodNodeOccupancy2
{
	CModelLink[] Targets; //fieldtype: CatalogLink
	EAMOccupancyLogic Logic; //enum
}

class CAttachMethodNumericField
{
	EAMNumericField Field; //enum
	real32 Value; //fieldtype: Float
	EAMNumericFieldOp Operator; //enum
}

class CAttachMethodPattern
{
	EAMPatternType Type; //enum
	EAttachKeyword Keyword; //enum
	CDataSoupKey Base; //fieldtype: String
	uint32 Offset; //fieldtype: IntUnsigned
	uint32 Multiplier; //fieldtype: IntUnsigned
	CDataSoupKey Driver; //fieldtype: String
}

class CAttachMethodPortAllocator
{
	uint32 PortLimit; //fieldtype: IntUnsigned
}

class CAttachMethodProximity
{
	uint32 RequestCount; //fieldtype: IntUnsigned
	real32 DistanceMax; //fieldtype: Float
	bool8 SortResults; //fieldtype: Unknown
	SEffectWhichLocation Location //struct
	{
		CEffectLink Effect; //fieldtype: CatalogLink
		EEffectLocation Value; //enum
		EEffectHistory History; //enum
	}
}

class CAttachMethodRandom
{
	uint32 RequestCount; //fieldtype: IntUnsigned
	EAMRandomDistribution Distribution; //enum
	real32 ExponentialMean; //fieldtype: Float
}

class CAttachMethodReduction
{
	EAMReductionType ReductionType; //enum
	uint32 RequestCount; //fieldtype: IntUnsigned
	uint32 RequestCountRange; //fieldtype: IntUnsigned
	real32 RequestPercentage; //fieldtype: Float
	real32 PassChanceEach; //fieldtype: Float
	real32 PassChanceFull; //fieldtype: Float
}

class CAttachMethodVolumesRequery
{
}

class CAttachMethodVolumesTargets
{
}

class CAttachMethodVolumesWeightedPick
{
	real32 VolumeFactor; //fieldtype: Float
	real32 ProximityFactorNear; //fieldtype: Float
	real32 ProximityFactorFar; //fieldtype: Float
}
