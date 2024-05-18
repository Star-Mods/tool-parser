
class CBundle
{
	TEditorCategories EditorCategories; //fieldtype: String
	CStringLink Name; //fieldtype: String
	CStringLink ShortName; //fieldtype: String
	CStringLink StoreName; //fieldtype: String
	TBattleProductId ProductId; //fieldtype: IntSigned
	CFlagArray<e_bundleFlagCount>[] Flags; //fieldtype: Flags
	EHeroUniverse Universe; //fieldtype: Unknown
	CBoostLink BoostBonus; //fieldtype: CatalogLink
	CAssetPath TileCutsceneFile; //fieldtype: String
	CImagePath TileTexture; //fieldtype: String
	CImagePath MediumTileTexture; //fieldtype: String
	CImagePath LargeTileTexture; //fieldtype: String
	CAssetPath PreviewCutsceneFile; //fieldtype: String
	SHeroReleaseDate ReleaseDate //struct
	{
		uint32 Month; //fieldtype: IntUnsigned
		uint32 Day; //fieldtype: IntUnsigned
		uint32 Year; //fieldtype: IntUnsigned
	}
	THyperlinkId HyperlinkId; //fieldtype: String
	CStringLink Description; //fieldtype: String
	SGameContentCreationData[] GameContentArray; //fieldtype: Unknown
	CStringLink StoreTypeName; //fieldtype: String
	CImagePath CinematicsImagePath; //fieldtype: String
	CImagePath LearnMoreBackgroundImage; //fieldtype: String
	CImagePath LearnMoreImage1; //fieldtype: String
	CImagePath LearnMoreImage2; //fieldtype: String
	CImagePath LearnMoreImage3; //fieldtype: String
	CStringLink LearnMoreTitleText1; //fieldtype: String
	CStringLink LearnMoreTitleText2; //fieldtype: String
	CStringLink LearnMoreTitleText3; //fieldtype: String
	CStringLink LearnMoreBodyText1; //fieldtype: String
	CStringLink LearnMoreBodyText2; //fieldtype: String
	CStringLink LearnMoreBodyText3; //fieldtype: String
	CStringLink[] SuppressCountryArray; //fieldtype: String
	CString ExternalHyperlink; //fieldtype: String
}
