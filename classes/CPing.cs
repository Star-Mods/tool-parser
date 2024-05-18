
class CPing
{
	CModelLink Model; //fieldtype: CatalogLink
	CSoundLink Sound; //fieldtype: CatalogLink
	CActorLink ActorSound; //fieldtype: CatalogLink
	CColor Color; //fieldtype: Unknown
	CFixed Duration; //fieldtype: Fixed
	CFixed Scale; //fieldtype: Fixed
	CFixed Rotation; //fieldtype: Fixed
	CStringLink Tooltip; //fieldtype: String
	CFlagArray<e_pingFlagCount>[] Flags; //fieldtype: Flags
}
