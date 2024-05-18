
class CScoreResult
{
	CStringLink Name; //fieldtype: String
	CStringLink PublishName; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CFlagArray<e_scoreResultFlagCount>[] Flags; //fieldtype: Flags
	int32 SortValue; //fieldtype: IntSigned
}

class CScoreResultRoot
{
	CStringLink Name; //fieldtype: String
	CStringLink PublishName; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CFlagArray<e_scoreResultFlagCount>[] Flags; //fieldtype: Flags
	int32 SortValue; //fieldtype: IntSigned
	CScoreResultLink[] HeaderTable; //fieldtype: CatalogLink
}

class CScoreResultScore
{
	CStringLink Name; //fieldtype: String
	CStringLink PublishName; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CFlagArray<e_scoreResultFlagCount>[] Flags; //fieldtype: Flags
	int32 SortValue; //fieldtype: IntSigned
	CScoreValueLink[] ValueTable; //fieldtype: CatalogLink
}

class CScoreResultGraph
{
	CStringLink Name; //fieldtype: String
	CStringLink PublishName; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CFlagArray<e_scoreResultFlagCount>[] Flags; //fieldtype: Flags
	int32 SortValue; //fieldtype: IntSigned
	CScoreValueLink[] ValueTable; //fieldtype: CatalogLink
}

class CScoreResultPane
{
	CStringLink Name; //fieldtype: String
	CStringLink PublishName; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CFlagArray<e_scoreResultFlagCount>[] Flags; //fieldtype: Flags
	int32 SortValue; //fieldtype: IntSigned
	CScoreValueLink[] ValueTable; //fieldtype: CatalogLink
}

class CScoreResultBuildOrder
{
	CStringLink Name; //fieldtype: String
	CStringLink PublishName; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CFlagArray<e_scoreResultFlagCount>[] Flags; //fieldtype: Flags
	int32 SortValue; //fieldtype: IntSigned
}

class CScoreResultCallouts
{
	CStringLink Name; //fieldtype: String
	CStringLink PublishName; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CFlagArray<e_scoreResultFlagCount>[] Flags; //fieldtype: Flags
	int32 SortValue; //fieldtype: IntSigned
}

class CScoreResultExperience
{
	CStringLink Name; //fieldtype: String
	CStringLink PublishName; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CFlagArray<e_scoreResultFlagCount>[] Flags; //fieldtype: Flags
	int32 SortValue; //fieldtype: IntSigned
	CScoreValueLink[] ValueTable; //fieldtype: CatalogLink
}

class CScoreResultPerformance
{
	CStringLink Name; //fieldtype: String
	CStringLink PublishName; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CFlagArray<e_scoreResultFlagCount>[] Flags; //fieldtype: Flags
	int32 SortValue; //fieldtype: IntSigned
	CScoreValueLink[] ValueTable; //fieldtype: CatalogLink
}
