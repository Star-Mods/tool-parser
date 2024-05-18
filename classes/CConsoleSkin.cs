
class CConsoleSkin
{
	bool8 Default; //fieldtype: Unknown
	CStringLink Name; //fieldtype: String
	CStringLink ShortName; //fieldtype: String
	CStringLink StoreName; //fieldtype: String
	TBattleProductId ProductId; //fieldtype: IntSigned
	CRewardLink RequiredReward; //fieldtype: CatalogLink
	SProductReleaseDate ReleaseDate; //fieldtype: Unknown
	SConsoleSkinModel MinimapPanelModel //struct
	{
		CString Model; //fieldtype: String
		C3Vector Position; //fieldtype: Unknown
		C3Vector Scale; //fieldtype: Unknown
	}
	SConsoleSkinModel InfoPanelModel //struct
	{
		CString Model; //fieldtype: String
		C3Vector Position; //fieldtype: Unknown
		C3Vector Scale; //fieldtype: Unknown
	}
	SConsoleSkinModel CommandPanelModel //struct
	{
		CString Model; //fieldtype: String
		C3Vector Position; //fieldtype: Unknown
		C3Vector Scale; //fieldtype: Unknown
	}
	CImagePath MinimapPanelImage; //fieldtype: String
	CImagePath InfoPanelImage; //fieldtype: String
	CImagePath CommandPanelImage; //fieldtype: String
	CString Light; //fieldtype: String
	CStringLink StoreTypeName; //fieldtype: String
	CImagePath ThumbnailImage; //fieldtype: String
	CImagePath FeaturedImage; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CString SkinId; //fieldtype: String
}
