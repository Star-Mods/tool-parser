
class CRequirement
{
	TEditorCategories EditorCategories; //fieldtype: String
	CFlagArray<e_requirementCount>[] CanBeSuppressed; //fieldtype: Flags
	SRequirementNode[] NodeArray //struct
	{
		CRequirementNodeLink Link; //fieldtype: CatalogLink
	}
}

class CRequirementNode
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
}

class CRequirementGT
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementLT
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementGTE
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementLTE
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementEq
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementNE
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementAnd
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementOr
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementXor
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementNot
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementOdd
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementDiv
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementMod
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementMul
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementSum
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CRequirementNodeLink[] OperandArray; //fieldtype: CatalogLink
}

class CRequirementConst
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	int32 Value; //fieldtype: IntSigned
}

class CRequirementAllowAbil
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CAbilLink Link; //fieldtype: CatalogLink
	uint32 Index; //fieldtype: IntUnsigned
}

class CRequirementAllowBehavior
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CBehaviorLink Link; //fieldtype: CatalogLink
}

class CRequirementAllowUnit
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CUnitLink Link; //fieldtype: CatalogLink
}

class CRequirementAllowUpgrade
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	CUpgradeLink Link; //fieldtype: CatalogLink
}

class CRequirementCountAbil
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	SRequirementCount Count //struct
	{
		TTechAlias Link; //fieldtype: String
		ERequirementState State; //enum
		TTechAlias Unlock; //fieldtype: String
	}
}

class CRequirementCountBehavior
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	SRequirementCount Count //struct
	{
		TTechAlias Link; //fieldtype: String
		ERequirementState State; //enum
		TTechAlias Unlock; //fieldtype: String
	}
}

class CRequirementCountEffect
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	SRequirementCount Count //struct
	{
		TTechAlias Link; //fieldtype: String
		ERequirementState State; //enum
		TTechAlias Unlock; //fieldtype: String
	}
}

class CRequirementCountUnit
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	SRequirementCount Count //struct
	{
		TTechAlias Link; //fieldtype: String
		ERequirementState State; //enum
		TTechAlias Unlock; //fieldtype: String
	}
}

class CRequirementCountUpgrade
{
	CFlags[] Flags; //fieldtype: Flags
	CStringLink Tooltip; //fieldtype: String
	SRequirementCount Count //struct
	{
		TTechAlias Link; //fieldtype: String
		ERequirementState State; //enum
		TTechAlias Unlock; //fieldtype: String
	}
}
