
class CMount
{
	CStringLink Name; //fieldtype: String
	CStringLink InfoText; //fieldtype: String
	CFourCC AttributeId; //fieldtype: FourCC
	CFlagArray<e_mountFlagCount>[] Flags; //fieldtype: Flags
	CModelLink Model; //fieldtype: CatalogLink
	bool8 Attached; //fieldtype: Unknown
	CRewardLink[] RequiredRewardArray; //fieldtype: CatalogLink
	CSoundLink[] VOArray; //fieldtype: CatalogLink
	CImagePath VariationIcon; //fieldtype: String
	CMountLink[] VariationArray; //fieldtype: CatalogLink
	TMountCategory MountCategory; //fieldtype: String
}
