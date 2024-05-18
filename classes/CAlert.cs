
class CAlert
{
	CFlags[] PrimaryActions; //fieldtype: Flags
	CFlags[] SecondaryActions; //fieldtype: Flags
	CFlags[] Display; //fieldtype: Flags
	CFlags[] Flags; //fieldtype: Flags
	real32 Fade; //fieldtype: Float
	CImagePath Icon; //fieldtype: String
	real32 Life; //fieldtype: Float
	real32 OverlapDuration; //fieldtype: Float
	uint32 OverlapGlobalCount; //fieldtype: IntUnsigned
	uint32 OverlapLocalCount; //fieldtype: IntUnsigned
	CFixed OverlapLocalRadius; //fieldtype: Fixed
	CColor PingColor; //fieldtype: Unknown
	CModelLink PingModel; //fieldtype: CatalogLink
	real32 PingTime; //fieldtype: Float
	real32 QueueTime; //fieldtype: Float
	CSoundLink Sound; //fieldtype: CatalogLink
	CStringLink Text; //fieldtype: String
	CStringLink Tooltip; //fieldtype: String
	EUnitSound Voice; //enum
	EAlertPeripheral Peripheral; //enum
	real32 SupersededVolume; //fieldtype: Float
}
