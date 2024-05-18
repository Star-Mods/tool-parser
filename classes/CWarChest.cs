
class CWarChest
{
	bool8 Default; //fieldtype: Unknown
	CStringLink Name; //fieldtype: String
	CStringLink ShortName; //fieldtype: String
	CStringLink StoreName; //fieldtype: String
	TProductHyperlinkId HyperlinkId; //fieldtype: String
	TBattleProductId ProductId; //fieldtype: IntSigned
	SProductReleaseDate ReleaseDate; //fieldtype: Unknown
	CStringLink SeasonId; //fieldtype: String
	bool8 IsBundle; //fieldtype: Unknown
	CIdentifier CelebrationString; //fieldtype: String
	CStringLink StoreTypeName; //fieldtype: String
}

class CWarChestSeason
{
	CStringLink Name; //fieldtype: String
	CStringLink ESportsSeason; //fieldtype: String
	CStringLink ESportsName; //fieldtype: String
	CStringLink ESportsLocation; //fieldtype: String
	CStringLink ESportsDate; //fieldtype: String
	bool8 ESportsShowPlayers; //fieldtype: Unknown
	CStringLink HowItWorks1; //fieldtype: String
	CStringLink HowItWorks2; //fieldtype: String
	CStringLink HowItWorks3; //fieldtype: String
	CStringLink HowItWorks4; //fieldtype: String
	CStringLink LearnMoreTitle1; //fieldtype: String
	CStringLink LearnMoreTitle2; //fieldtype: String
	CStringLink LearnMoreTitle3; //fieldtype: String
	CStringLink LearnMoreDescription1; //fieldtype: String
	CStringLink LearnMoreDescription2; //fieldtype: String
	CStringLink LearnMoreDescription3; //fieldtype: String
	CImagePath LearnMoreImage1; //fieldtype: String
	CImagePath LearnMoreImage2; //fieldtype: String
	CImagePath LearnMoreImage3; //fieldtype: String
	CStringLink PurchaseTitle; //fieldtype: String
	CStringLink PurchaseDescription; //fieldtype: String
	CStringLink PurchaseWarning; //fieldtype: String
	CImagePath PurchaseImage; //fieldtype: String
}
