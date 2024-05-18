
class CItem
{
	CButtonLink Face; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CItemClassLink Class; //fieldtype: CatalogLink
	CItemContainerLink Container; //fieldtype: CatalogLink
	uint32 Level; //fieldtype: IntUnsigned
	SCharge Charge //struct
	{
		CFixed CountMax; //fieldtype: Fixed
		CFixed CountStart; //fieldtype: Fixed
		CFixed CountUse; //fieldtype: Fixed
		bool32 HideCount; //fieldtype: Unknown
		TChargeLink Link; //fieldtype: String
		EChargeLocation Location; //enum
		CGameTime TimeDelay; //fieldtype: Fixed
		CGameTime TimeStart; //fieldtype: Fixed
		CGameTime TimeUse; //fieldtype: Fixed
		CFlags[] Flags; //fieldtype: Flags
	}
	TCooldownLink GroupCooldownLink; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	CBehaviorLink[] CarryBehaviorArray; //fieldtype: CatalogLink
	SUnitWeaponData[] CarryWeaponArray //struct
	{
		CWeaponLink Link; //fieldtype: CatalogLink
		CTurretLink Turret; //fieldtype: CatalogLink
	}
	CBehaviorLink[] EquipBehaviorArray; //fieldtype: CatalogLink
	SUnitWeaponData[] EquipWeaponArray //struct
	{
		CWeaponLink Link; //fieldtype: CatalogLink
		CTurretLink Turret; //fieldtype: CatalogLink
	}
}

class CItemAbil
{
	CButtonLink Face; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CItemClassLink Class; //fieldtype: CatalogLink
	CItemContainerLink Container; //fieldtype: CatalogLink
	uint32 Level; //fieldtype: IntUnsigned
	SCharge Charge //struct
	{
		CFixed CountMax; //fieldtype: Fixed
		CFixed CountStart; //fieldtype: Fixed
		CFixed CountUse; //fieldtype: Fixed
		bool32 HideCount; //fieldtype: Unknown
		TChargeLink Link; //fieldtype: String
		EChargeLocation Location; //enum
		CGameTime TimeDelay; //fieldtype: Fixed
		CGameTime TimeStart; //fieldtype: Fixed
		CGameTime TimeUse; //fieldtype: Fixed
		CFlags[] Flags; //fieldtype: Flags
	}
	TCooldownLink GroupCooldownLink; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	CBehaviorLink[] CarryBehaviorArray; //fieldtype: CatalogLink
	SUnitWeaponData[] CarryWeaponArray //struct
	{
		CWeaponLink Link; //fieldtype: CatalogLink
		CTurretLink Turret; //fieldtype: CatalogLink
	}
	CBehaviorLink[] EquipBehaviorArray; //fieldtype: CatalogLink
	SUnitWeaponData[] EquipWeaponArray //struct
	{
		CWeaponLink Link; //fieldtype: CatalogLink
		CTurretLink Turret; //fieldtype: CatalogLink
	}
	CAbilLink Abil; //fieldtype: CatalogLink
	CButtonLink ToggledFace; //fieldtype: CatalogLink
	CFlags[] AbilFlags; //fieldtype: Flags
}

class CItemAbilPowerUp
{
	CButtonLink Face; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CItemClassLink Class; //fieldtype: CatalogLink
	CItemContainerLink Container; //fieldtype: CatalogLink
	uint32 Level; //fieldtype: IntUnsigned
	SCharge Charge //struct
	{
		CFixed CountMax; //fieldtype: Fixed
		CFixed CountStart; //fieldtype: Fixed
		CFixed CountUse; //fieldtype: Fixed
		bool32 HideCount; //fieldtype: Unknown
		TChargeLink Link; //fieldtype: String
		EChargeLocation Location; //enum
		CGameTime TimeDelay; //fieldtype: Fixed
		CGameTime TimeStart; //fieldtype: Fixed
		CGameTime TimeUse; //fieldtype: Fixed
		CFlags[] Flags; //fieldtype: Flags
	}
	TCooldownLink GroupCooldownLink; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	CBehaviorLink[] CarryBehaviorArray; //fieldtype: CatalogLink
	SUnitWeaponData[] CarryWeaponArray //struct
	{
		CWeaponLink Link; //fieldtype: CatalogLink
		CTurretLink Turret; //fieldtype: CatalogLink
	}
	CBehaviorLink[] EquipBehaviorArray; //fieldtype: CatalogLink
	SUnitWeaponData[] EquipWeaponArray //struct
	{
		CWeaponLink Link; //fieldtype: CatalogLink
		CTurretLink Turret; //fieldtype: CatalogLink
	}
	CAbilLink Abil; //fieldtype: CatalogLink
	CButtonLink ToggledFace; //fieldtype: CatalogLink
	CFlags[] AbilFlags; //fieldtype: Flags
	CTargetFilters CasterFilters; //fieldtype: Unknown
	bool8 KillAfterUse; //fieldtype: Unknown
}

class CItemEffect
{
	CButtonLink Face; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CItemClassLink Class; //fieldtype: CatalogLink
	CItemContainerLink Container; //fieldtype: CatalogLink
	uint32 Level; //fieldtype: IntUnsigned
	SCharge Charge //struct
	{
		CFixed CountMax; //fieldtype: Fixed
		CFixed CountStart; //fieldtype: Fixed
		CFixed CountUse; //fieldtype: Fixed
		bool32 HideCount; //fieldtype: Unknown
		TChargeLink Link; //fieldtype: String
		EChargeLocation Location; //enum
		CGameTime TimeDelay; //fieldtype: Fixed
		CGameTime TimeStart; //fieldtype: Fixed
		CGameTime TimeUse; //fieldtype: Fixed
		CFlags[] Flags; //fieldtype: Flags
	}
	TCooldownLink GroupCooldownLink; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	CBehaviorLink[] CarryBehaviorArray; //fieldtype: CatalogLink
	SUnitWeaponData[] CarryWeaponArray //struct
	{
		CWeaponLink Link; //fieldtype: CatalogLink
		CTurretLink Turret; //fieldtype: CatalogLink
	}
	CBehaviorLink[] EquipBehaviorArray; //fieldtype: CatalogLink
	SUnitWeaponData[] EquipWeaponArray //struct
	{
		CWeaponLink Link; //fieldtype: CatalogLink
		CTurretLink Turret; //fieldtype: CatalogLink
	}
	CEffectLink Effect; //fieldtype: CatalogLink
	SCost EffectCost //struct
	{
		int32[] Resource; //fieldtype: IntSigned
		CFlags[] Display; //fieldtype: Flags
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		SCharge Charge //struct
		{
			CFixed CountMax; //fieldtype: Fixed
			CFixed CountStart; //fieldtype: Fixed
			CFixed CountUse; //fieldtype: Fixed
			bool32 HideCount; //fieldtype: Unknown
			TChargeLink Link; //fieldtype: String
			EChargeLocation Location; //enum
			CGameTime TimeDelay; //fieldtype: Fixed
			CGameTime TimeStart; //fieldtype: Fixed
			CGameTime TimeUse; //fieldtype: Fixed
			CFlags[] Flags; //fieldtype: Flags
		}
		SCooldown Cooldown //struct
		{
			TCooldownLink Link; //fieldtype: String
			ECooldownLocation Location; //enum
			CGameTime TimeStart; //fieldtype: Fixed
			ECooldownOperation Operation; //enum
			CGameTime TimeUse; //fieldtype: Fixed
		}
	}
	CFlags[] EffectFlags; //fieldtype: Flags
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CFixed Range; //fieldtype: Fixed
}

class CItemEffectInstant
{
	CButtonLink Face; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CItemClassLink Class; //fieldtype: CatalogLink
	CItemContainerLink Container; //fieldtype: CatalogLink
	uint32 Level; //fieldtype: IntUnsigned
	SCharge Charge //struct
	{
		CFixed CountMax; //fieldtype: Fixed
		CFixed CountStart; //fieldtype: Fixed
		CFixed CountUse; //fieldtype: Fixed
		bool32 HideCount; //fieldtype: Unknown
		TChargeLink Link; //fieldtype: String
		EChargeLocation Location; //enum
		CGameTime TimeDelay; //fieldtype: Fixed
		CGameTime TimeStart; //fieldtype: Fixed
		CGameTime TimeUse; //fieldtype: Fixed
		CFlags[] Flags; //fieldtype: Flags
	}
	TCooldownLink GroupCooldownLink; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	CBehaviorLink[] CarryBehaviorArray; //fieldtype: CatalogLink
	SUnitWeaponData[] CarryWeaponArray //struct
	{
		CWeaponLink Link; //fieldtype: CatalogLink
		CTurretLink Turret; //fieldtype: CatalogLink
	}
	CBehaviorLink[] EquipBehaviorArray; //fieldtype: CatalogLink
	SUnitWeaponData[] EquipWeaponArray //struct
	{
		CWeaponLink Link; //fieldtype: CatalogLink
		CTurretLink Turret; //fieldtype: CatalogLink
	}
	CEffectLink Effect; //fieldtype: CatalogLink
	SCost EffectCost //struct
	{
		int32[] Resource; //fieldtype: IntSigned
		CFlags[] Display; //fieldtype: Flags
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		SCharge Charge //struct
		{
			CFixed CountMax; //fieldtype: Fixed
			CFixed CountStart; //fieldtype: Fixed
			CFixed CountUse; //fieldtype: Fixed
			bool32 HideCount; //fieldtype: Unknown
			TChargeLink Link; //fieldtype: String
			EChargeLocation Location; //enum
			CGameTime TimeDelay; //fieldtype: Fixed
			CGameTime TimeStart; //fieldtype: Fixed
			CGameTime TimeUse; //fieldtype: Fixed
			CFlags[] Flags; //fieldtype: Flags
		}
		SCooldown Cooldown //struct
		{
			TCooldownLink Link; //fieldtype: String
			ECooldownLocation Location; //enum
			CGameTime TimeStart; //fieldtype: Fixed
			ECooldownOperation Operation; //enum
			CGameTime TimeUse; //fieldtype: Fixed
		}
	}
	CFlags[] EffectFlags; //fieldtype: Flags
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CFixed Range; //fieldtype: Fixed
}

class CItemEffectTarget
{
	CButtonLink Face; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
	CItemClassLink Class; //fieldtype: CatalogLink
	CItemContainerLink Container; //fieldtype: CatalogLink
	uint32 Level; //fieldtype: IntUnsigned
	SCharge Charge //struct
	{
		CFixed CountMax; //fieldtype: Fixed
		CFixed CountStart; //fieldtype: Fixed
		CFixed CountUse; //fieldtype: Fixed
		bool32 HideCount; //fieldtype: Unknown
		TChargeLink Link; //fieldtype: String
		EChargeLocation Location; //enum
		CGameTime TimeDelay; //fieldtype: Fixed
		CGameTime TimeStart; //fieldtype: Fixed
		CGameTime TimeUse; //fieldtype: Fixed
		CFlags[] Flags; //fieldtype: Flags
	}
	TCooldownLink GroupCooldownLink; //fieldtype: String
	const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
	CBehaviorLink[] CarryBehaviorArray; //fieldtype: CatalogLink
	SUnitWeaponData[] CarryWeaponArray //struct
	{
		CWeaponLink Link; //fieldtype: CatalogLink
		CTurretLink Turret; //fieldtype: CatalogLink
	}
	CBehaviorLink[] EquipBehaviorArray; //fieldtype: CatalogLink
	SUnitWeaponData[] EquipWeaponArray //struct
	{
		CWeaponLink Link; //fieldtype: CatalogLink
		CTurretLink Turret; //fieldtype: CatalogLink
	}
	CEffectLink Effect; //fieldtype: CatalogLink
	SCost EffectCost //struct
	{
		int32[] Resource; //fieldtype: IntSigned
		CFlags[] Display; //fieldtype: Flags
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		SCharge Charge //struct
		{
			CFixed CountMax; //fieldtype: Fixed
			CFixed CountStart; //fieldtype: Fixed
			CFixed CountUse; //fieldtype: Fixed
			bool32 HideCount; //fieldtype: Unknown
			TChargeLink Link; //fieldtype: String
			EChargeLocation Location; //enum
			CGameTime TimeDelay; //fieldtype: Fixed
			CGameTime TimeStart; //fieldtype: Fixed
			CGameTime TimeUse; //fieldtype: Fixed
			CFlags[] Flags; //fieldtype: Flags
		}
		SCooldown Cooldown //struct
		{
			TCooldownLink Link; //fieldtype: String
			ECooldownLocation Location; //enum
			CGameTime TimeStart; //fieldtype: Fixed
			ECooldownOperation Operation; //enum
			CGameTime TimeUse; //fieldtype: Fixed
		}
	}
	CFlags[] EffectFlags; //fieldtype: Flags
	SCostFactor RefundFraction //struct
	{
		CFixed[] Vital; //fieldtype: Fixed
		CFixed[] VitalFraction; //fieldtype: Fixed
		CFixed[] Resource; //fieldtype: Fixed
		CFixed Charge; //fieldtype: Fixed
		CFixed Cooldown; //fieldtype: Fixed
	}
	CTargetFilters TargetFilters; //fieldtype: Unknown
	CFixed Range; //fieldtype: Fixed
}

class CItemClass
{
	CStringLink Name; //fieldtype: String
}

class CItemContainer
{
	CModelLink Model; //fieldtype: CatalogLink
	uint32 ModelHeight; //fieldtype: IntUnsigned
	uint32 ModelWidth; //fieldtype: IntUnsigned
	SItemContainerSlot[] Slots //struct
	{
		CButtonLink EmptyFace; //fieldtype: CatalogLink
		CItemClassLink[] Classes; //fieldtype: CatalogLink
		const CTechRequirementsGraph* Requirements; //fieldtype: Unknown
		bool8 Equip; //fieldtype: Unknown
		uint8 Row; //fieldtype: IntUnsigned
		uint8 Column; //fieldtype: IntUnsigned
	}
}
