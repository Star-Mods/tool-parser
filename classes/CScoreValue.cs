
class CScoreValue
{
	CStringLink Name; //fieldtype: String
	CStringLink PublishName; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CFlagArray<e_scoreValueFlagCount>[] Flags; //fieldtype: Flags
	EScoreSort Sort; //enum
	EScoreValueReport Report; //enum
	CFourCC UniqueTag; //fieldtype: FourCC
}

class CScoreValueCustom
{
	CStringLink Name; //fieldtype: String
	CStringLink PublishName; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CFlagArray<e_scoreValueFlagCount>[] Flags; //fieldtype: Flags
	EScoreSort Sort; //enum
	EScoreValueReport Report; //enum
	CFourCC UniqueTag; //fieldtype: FourCC
	EScoreCollapse Collapse; //enum
	EScoreValueType Type; //enum
}

class CScoreValueStandard
{
	CStringLink Name; //fieldtype: String
	CStringLink PublishName; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CFlagArray<e_scoreValueFlagCount>[] Flags; //fieldtype: Flags
	EScoreSort Sort; //enum
	EScoreValueReport Report; //enum
	CFourCC UniqueTag; //fieldtype: FourCC
	EScoreValue Value; //enum
}

class CScoreValueConstant
{
	CStringLink Name; //fieldtype: String
	CStringLink PublishName; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CFlagArray<e_scoreValueFlagCount>[] Flags; //fieldtype: Flags
	EScoreSort Sort; //enum
	EScoreValueReport Report; //enum
	CFourCC UniqueTag; //fieldtype: FourCC
	EScoreCollapse Collapse; //enum
	EScoreValueType Type; //enum
	CFixed Value; //fieldtype: Fixed
}

class CScoreValueCombine
{
	CStringLink Name; //fieldtype: String
	CStringLink PublishName; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CFlagArray<e_scoreValueFlagCount>[] Flags; //fieldtype: Flags
	EScoreSort Sort; //enum
	EScoreValueReport Report; //enum
	CFourCC UniqueTag; //fieldtype: FourCC
	EScoreCollapse Collapse; //enum
	EScoreValueType Type; //enum
	EScoreValueOperation Operation; //enum
	CScoreValueLink[] ValueTable; //fieldtype: CatalogLink
}
