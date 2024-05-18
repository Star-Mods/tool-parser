
class CTrophy
{
	uint32 DefinitionId; //fieldtype: IntUnsigned
	CString TopCutsceneFilter; //fieldtype: String
	CString BottomCutsceneFilter; //fieldtype: String
	CCutscenePath CutsceneFile; //fieldtype: String
	CModelLink GameModel; //fieldtype: CatalogLink
	CSkinLink Skin; //fieldtype: CatalogLink
}

class CTurret
{
	ETurretIdle Idle; //enum
	CFangle YawStart; //fieldtype: Fixed
	CFangleArc YawArc; //fieldtype: Fixed
	CFangleRate YawRate; //fieldtype: Unknown
	CFangleRate YawIdleRate; //fieldtype: Unknown
	SFidget Fidget //struct
	{
		uint8[] ChanceArray; //fieldtype: IntUnsigned
		CGameTime DelayMax; //fieldtype: Fixed
		CGameTime DelayMin; //fieldtype: Fixed
		CFixed DistanceMax; //fieldtype: Fixed
		CFixed DistanceMin; //fieldtype: Fixed
		CFangle TurnAngle; //fieldtype: Fixed
		CFangleRate TurningRate; //fieldtype: Unknown
	}
}
