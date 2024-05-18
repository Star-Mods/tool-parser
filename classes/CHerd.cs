
class CHerd
{
	EHerdClosestTo ClosestTo; //fieldtype: Unknown
	real32 PositionBias; //fieldtype: Float
	real32 NodeSearchRadius; //fieldtype: Float
	SHerdLevel[] Levels //struct
	{
		real32 Weight; //fieldtype: Float
	}
	SHerdNode[] Nodes //struct
	{
		real32 Weight; //fieldtype: Float
		CHerdNodeLink Link; //fieldtype: CatalogLink
	}
	CRange SpeedLimit; //fieldtype: Unknown
}

class CHerdNode
{
}
