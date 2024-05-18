
class CButton
{
	CStringLink Name; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	STooltipBlock[] TooltipAppender //struct
	{
		CValidatorLink Validator; //fieldtype: CatalogLink
		CStringLink Text; //fieldtype: String
		CButtonLink Face; //fieldtype: CatalogLink
	}
	CImagePath TooltipImage; //fieldtype: String
	CFlags[] TooltipFlags; //fieldtype: Flags
	CStringLink[] TooltipResourceName; //fieldtype: String
	CStringLink[] TooltipVitalName; //fieldtype: String
	CStringLink TooltipSupplyName; //fieldtype: String
	CStringLink TooltipCooldownOverrideText; //fieldtype: String
	CStringLink[] TooltipVitalOverrideText; //fieldtype: String
	STooltipTimeAbilCmd TooltipTimeOverrideAbilCmd //struct
	{
		CAbilCommand AbilCmd; //fieldtype: Unknown
	}
	CImagePath Icon; //fieldtype: String
	CStringLink AlertName; //fieldtype: String
	CStringLink AlertTooltip; //fieldtype: String
	CImagePath AlertIcon; //fieldtype: String
	CHotkeyLink Hotkey; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	bool8 TintRacially; //fieldtype: Unknown
	CButtonLink HotkeyAlias; //fieldtype: CatalogLink
	CIdentifier HotkeySet; //fieldtype: String
	CUnitLink HotkeyToggleUnit; //fieldtype: CatalogLink
	bool8 Universal; //fieldtype: Unknown
	CStringLink SimpleDisplayText; //fieldtype: String
	bool32 HidesForSimpleText; //fieldtype: Unknown
	bool8 UseHotkeyLabel; //fieldtype: Unknown
	bool8 Placeholder; //fieldtype: Unknown
	CStringLink ChargeText; //fieldtype: String
	SButtonCardLayout DefaultButtonLayout //struct
	{
		uint8 Row; //fieldtype: IntUnsigned
		uint8 Column; //fieldtype: IntUnsigned
		CFourCC CardId; //fieldtype: FourCC
	}
}
