
class CTacCooldown
{
	CUnitLink UnitLink; //fieldtype: CatalogLink
	STacAbilData[] TacAbilData //struct
	{
		CAbilLink AbilLink; //fieldtype: CatalogLink
		CFixed[] Cooldown; //fieldtype: Fixed
	}
}
