
class CBankCondition
{
}

class CBankConditionCompare
{
	CString Bank; //fieldtype: String
	CString Section; //fieldtype: String
	CString Key; //fieldtype: String
	CString ValueName; //fieldtype: String
	EValueCompare Compare; //enum
}

class CBankConditionCompareValueCount
{
	CString Bank; //fieldtype: String
	CString Section; //fieldtype: String
	CString Key; //fieldtype: String
	CString ValueName; //fieldtype: String
	EValueCompare Compare; //enum
	EValueCompare AddCompare; //enum
	int32 AddValue; //fieldtype: IntSigned
	uint32 Value; //fieldtype: IntUnsigned
}

class CBankConditionCompareValueInteger
{
	CString Bank; //fieldtype: String
	CString Section; //fieldtype: String
	CString Key; //fieldtype: String
	CString ValueName; //fieldtype: String
	EValueCompare Compare; //enum
	int32 Value; //fieldtype: IntSigned
}

class CBankConditionCompareValueString
{
	CString Bank; //fieldtype: String
	CString Section; //fieldtype: String
	CString Key; //fieldtype: String
	CString ValueName; //fieldtype: String
	EValueCompare Compare; //enum
	CString Value; //fieldtype: String
}

class CBankConditionCompareValueSum
{
	CString Bank; //fieldtype: String
	CString Section; //fieldtype: String
	CString Key; //fieldtype: String
	CString ValueName; //fieldtype: String
	EValueCompare Compare; //enum
	EValueCompare AddCompare; //enum
	int32 AddValue; //fieldtype: IntSigned
	int32 Value; //fieldtype: IntSigned
}

class CBankConditionCombine
{
	EBankConditionCombine Type; //enum
	CBankConditionLink[] CombineArray; //fieldtype: CatalogLink
	bool8 Negate; //fieldtype: Unknown
}

class CBankConditionCurrentMap
{
	CString Map; //fieldtype: String
}
