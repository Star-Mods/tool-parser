
class CTactical
{
}

class CTacticalOrder
{
	CAbilLink Abil; //fieldtype: CatalogLink
	TAbilCmdIndex AbilCmdIndex; //fieldtype: IntUnsigned
	SMarker Marker //struct
	{
		TMarkerCount Count; //fieldtype: IntSigned
		CGameTime Duration; //fieldtype: Fixed
		CMarkerFlags[] MatchFlags; //fieldtype: Flags
		CMarkerFlags[] MismatchFlags; //fieldtype: Flags
		TMarkerLink Link; //fieldtype: String
	}
	bool8 Retreat; //fieldtype: Unknown
	CTargetFindLink TargetFind; //fieldtype: CatalogLink
	CValidatorLink Validator; //fieldtype: CatalogLink
}

class CTacticalSet
{
	CTacticalLink[] Array; //fieldtype: CatalogLink
}