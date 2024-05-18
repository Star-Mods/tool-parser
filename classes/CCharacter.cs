
class CCharacter
{
	CStringLink Name; //fieldtype: String
	uint32 Age; //fieldtype: IntUnsigned
	ECharacterGender Gender; //enum
	ECharacterRace Race; //enum
	CStringLink RaceCustom; //fieldtype: String
	CStringLink Attitude; //fieldtype: String
	CStringLink Timbre; //fieldtype: String
	CStringLink Dialect; //fieldtype: String
	CStringLink VoiceRef; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CImagePath Image; //fieldtype: String
	ECharacterRelevance Relevance; //enum
	CString Voice; //fieldtype: String
	int32 Pitch; //fieldtype: IntSigned
	CColor Color; //fieldtype: Unknown
	CUnitLink Unit; //fieldtype: CatalogLink
	SCharacterVariation[] Variations //struct
	{
		CStringLink Name; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
		CActorLink Actor; //fieldtype: CatalogLink
		CString[] DefaultCategories; //fieldtype: String
	}
}
