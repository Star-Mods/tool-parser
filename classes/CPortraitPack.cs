
class CPortraitPack
{
	bool8 Default; //fieldtype: Unknown
	CStringLink Name; //fieldtype: String
	CStringLink ShortName; //fieldtype: String
	CStringLink StoreName; //fieldtype: String
	CStringLink Description; //fieldtype: String
	STextureSheetEntry Image //struct
	{
		CTextureSheetLink TextureSheet; //fieldtype: CatalogLink
		uint32 Index; //fieldtype: IntUnsigned
		uint32 Count; //fieldtype: IntUnsigned
		uint32 DurationPerFrame; //fieldtype: IntUnsigned
	}
	TBattleProductId ProductId; //fieldtype: IntSigned
	SProductReleaseDate ReleaseDate; //fieldtype: Unknown
	CRewardLink[] PortraitArray; //fieldtype: CatalogLink
	CStringLink StoreTypeName; //fieldtype: String
}
