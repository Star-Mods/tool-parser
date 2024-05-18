
class CPremiumMap
{
	bool8 Default; //fieldtype: Unknown
	CStringLink Name; //fieldtype: String
	CStringLink ShortName; //fieldtype: String
	CStringLink StoreName; //fieldtype: String
	CStringLink StoreTypeName; //fieldtype: String
	SProductReleaseDate ReleaseDate; //fieldtype: Unknown
	TProductHyperlinkId HyperlinkId; //fieldtype: String
	TBattleProductId ProductId; //fieldtype: IntSigned
	uint32 LicenseId; //fieldtype: IntUnsigned
	CStringLink Price; //fieldtype: String
	CImagePath[] ScreenShotImageArray; //fieldtype: String
	CStringLink[] ScreenShotDescriptionArray; //fieldtype: String
	CMoviePath Movie; //fieldtype: String
	CImagePath MoviePreviewImage; //fieldtype: String
	CStringLink MovieDescription; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CStringLink Title; //fieldtype: String
	bool8 PayToPlay; //fieldtype: Unknown
	CFourCC SuppressedRegion; //fieldtype: FourCC
	CStringLink ShortDescription; //fieldtype: String
	CStringLink LanguageWarning; //fieldtype: String
	CImagePath[] ScreenShotImageThumbnailArray; //fieldtype: String
	CImagePath MovieImageThumbnail; //fieldtype: String
	CStringLink CustomFeaturedDescription; //fieldtype: String
}
