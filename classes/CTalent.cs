
class CTalent
{
	CButtonLink Face; //fieldtype: CatalogLink
	CAbilLink Abil; //fieldtype: CatalogLink
	STalentRank[] RankArray //struct
	{
		CButtonLink Face; //fieldtype: CatalogLink
		CUnitLink Item; //fieldtype: CatalogLink
		CUpgradeLink Upgrade; //fieldtype: CatalogLink
		CBehaviorLink[] BehaviorArray; //fieldtype: CatalogLink
		CFixed AbilityPower; //fieldtype: Fixed
		CFixed CooldownReduction; //fieldtype: Fixed
		CFixed AttackDamage; //fieldtype: Fixed
		CFixed AttackSpeed; //fieldtype: Fixed
		CFixed Life; //fieldtype: Fixed
		CFixed Energy; //fieldtype: Fixed
		CFixed Shields; //fieldtype: Fixed
		CGameRate LifeRegenRate; //fieldtype: Fixed
		CGameRate EnergyRegenRate; //fieldtype: Fixed
		CGameRate ShieldRegenRate; //fieldtype: Fixed
		CFixed MovementSpeed; //fieldtype: Fixed
		CFixed LifeLeech; //fieldtype: Fixed
		CFixed SiegeDamage; //fieldtype: Fixed
		CFixed LifeRegenRateFraction; //fieldtype: Fixed
		CFixed CrowdControlReduction; //fieldtype: Fixed
		CFixed DeathTimerReduction; //fieldtype: Fixed
		CFixed AmplifiedHealing; //fieldtype: Fixed
		CFixed MountSpeed; //fieldtype: Fixed
	}
	STalentAbilityModification[] AbilityModificationArray //struct
	{
		CAbilLink ModifyAbil; //fieldtype: CatalogLink
		CButtonLink OriginalAbilButton; //fieldtype: CatalogLink
		CButtonLink ModifiedAbilButton; //fieldtype: CatalogLink
		STalentModification[] Modifications //struct
		{
			ETalentModification Type; //fieldtype: Unknown
			EGameCatalog Catalog; //enum
			CIdentifier Entry; //fieldtype: String
			CIdentifier Field; //fieldtype: String
			bool8 FieldIsInteger; //fieldtype: Unknown
			real32 Value; //fieldtype: Float
			CString StringReplacement; //fieldtype: String
		}
		CStringLink TooltipAddendum; //fieldtype: String
	}
	bool8 Active; //fieldtype: Unknown
	bool8 Trait; //fieldtype: Unknown
}

class CTalentProfile
{
	CStringLink Name; //fieldtype: String
	CTalentLink[] Talents; //fieldtype: CatalogLink
	CFlagArray<e_talentProfileFlagCount>[] Flags; //fieldtype: Flags
}
