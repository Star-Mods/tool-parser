
class CPreload
{
	CBankConditionLink[] NormalConditions; //fieldtype: CatalogLink
	EPreloadTiming NormalTiming; //enum
	CBankConditionLink[] QueuedConditions; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
}

class CPreloadAsset
{
	CBankConditionLink[] NormalConditions; //fieldtype: CatalogLink
	EPreloadTiming NormalTiming; //enum
	CBankConditionLink[] QueuedConditions; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CAssetPath File; //fieldtype: String
}

class CPreloadScene
{
	CBankConditionLink[] NormalConditions; //fieldtype: CatalogLink
	EPreloadTiming NormalTiming; //enum
	CBankConditionLink[] QueuedConditions; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CString File; //fieldtype: String
	CString Filter; //fieldtype: String
}

class CPreloadActor
{
	CBankConditionLink[] NormalConditions; //fieldtype: CatalogLink
	EPreloadTiming NormalTiming; //enum
	CBankConditionLink[] QueuedConditions; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CActorLink Link; //fieldtype: CatalogLink
}

class CPreloadConversation
{
	CBankConditionLink[] NormalConditions; //fieldtype: CatalogLink
	EPreloadTiming NormalTiming; //enum
	CBankConditionLink[] QueuedConditions; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CConversationLink Link; //fieldtype: CatalogLink
}

class CPreloadModel
{
	CBankConditionLink[] NormalConditions; //fieldtype: CatalogLink
	EPreloadTiming NormalTiming; //enum
	CBankConditionLink[] QueuedConditions; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CModelLink Link; //fieldtype: CatalogLink
	CString Variations; //fieldtype: String
	CFlags[] ModelFlags; //fieldtype: Flags
}

class CPreloadSound
{
	CBankConditionLink[] NormalConditions; //fieldtype: CatalogLink
	EPreloadTiming NormalTiming; //enum
	CBankConditionLink[] QueuedConditions; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CSoundLink Link; //fieldtype: CatalogLink
	CString Variations; //fieldtype: String
}

class CPreloadUnit
{
	CBankConditionLink[] NormalConditions; //fieldtype: CatalogLink
	EPreloadTiming NormalTiming; //enum
	CBankConditionLink[] QueuedConditions; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CUnitLink Link; //fieldtype: CatalogLink
}
