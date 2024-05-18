
class CArmyCategory
{
	CStringLink Name; //fieldtype: String
	CStringLink Title; //fieldtype: String
	CStringLink Help; //fieldtype: String
	CStringLink CategoryHelp; //fieldtype: String
	CStringLink UnitHelp; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	SBankPath BankPath //struct
	{
		CString File; //fieldtype: String
		CString Section; //fieldtype: String
		CString Key; //fieldtype: String
	}
	CStringLink Description; //fieldtype: String
	EArmyCategoryState State; //enum
	CFlags[] Flags; //fieldtype: Flags
	CUnitLink Unit; //fieldtype: CatalogLink
	CUpgradeLink[] UpgradeArray; //fieldtype: CatalogLink
	CAbilCommand[] AbilCommandArray; //fieldtype: Unknown
	CArmyUnitLink[] ArmyUnitArray; //fieldtype: CatalogLink
	CArmyUpgradeLink[] ArmyUpgradeArray; //fieldtype: CatalogLink
	CUserReference UserReference; //fieldtype: Unknown
	int32 ExtraUpgradeRequirement; //fieldtype: IntSigned
	int32 SplitRequirement; //fieldtype: IntSigned
}

class CArmyUnit
{
	CStringLink Name; //fieldtype: String
	CStringLink Title; //fieldtype: String
	CStringLink Help; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	SBankPath BankPath //struct
	{
		CString File; //fieldtype: String
		CString Section; //fieldtype: String
		CString Key; //fieldtype: String
	}
	CStringLink Description; //fieldtype: String
	CStringLink Confirmation; //fieldtype: String
	CMoviePath Movie; //fieldtype: String
	int32 Cost; //fieldtype: IntSigned
	EArmyUnitState State; //enum
	CUnitLink Unit; //fieldtype: CatalogLink
	CUpgradeLink[] UpgradeArray; //fieldtype: CatalogLink
	CAbilCommand[] AbilCommandArray; //fieldtype: Unknown
	CArmyUpgradeLink[] ArmyUpgradeArray; //fieldtype: CatalogLink
	CUserReference UserReference; //fieldtype: Unknown
	CString EnableButton; //fieldtype: String
	CSkinLink Skin; //fieldtype: CatalogLink
}

class CArmyUpgrade
{
	CStringLink Name; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	CStringLink Requirements; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	int32 Cost; //fieldtype: IntSigned
	CMoviePath Movie; //fieldtype: String
	EArmyUpgradeState State; //enum
	CUpgradeLink[] UpgradeArray; //fieldtype: CatalogLink
	CAbilCommand[] AbilCommandArray; //fieldtype: Unknown
	CUserReference UserReference; //fieldtype: Unknown
}
