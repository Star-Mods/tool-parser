
class CFootprint
{
	CFlagArray<e_footprintFlagCount>[] Flags; //fieldtype: Flags
	SFootprintLayer[] Layers //struct
	{
		CiQuad Area; //fieldtype: Unknown
		SFootprintBitSet[] Sets //struct
		{
			CString4 Character; //fieldtype: String
			CFlags[] Positive; //fieldtype: Flags
			CFlags[] Negative; //fieldtype: Flags
		}
		CString50[] Rows; //fieldtype: String
	}
	SFootprintShape Shape //struct
	{
		EFootprintShapeMode Mode; //enum
		CFixed Radius; //fieldtype: Fixed
		TFootprintOffsets Offsets; //fieldtype: Unknown
		TFootprintBorders Borders; //fieldtype: Unknown
	}
	TEditorCategories EditorCategories; //fieldtype: String
}
