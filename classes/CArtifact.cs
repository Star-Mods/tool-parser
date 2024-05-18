
class CArtifact
{
	TEditorCategories EditorCategories; //fieldtype: String
	CStringLink Name; //fieldtype: String
	CStringLink InfoText; //fieldtype: String
	CFourCC AttributeId; //fieldtype: FourCC
	CModelLink Model; //fieldtype: CatalogLink
	SArtifactRank[] RankArray //struct
	{
		CRewardLink[] RequiredRewardArray; //fieldtype: CatalogLink
		TBattleProductId ProductId; //fieldtype: IntSigned
	}
	EHeroUniverse Universe; //fieldtype: Unknown
	CAssetPath TileCutsceneFile; //fieldtype: String
	CAssetPath PreviewCutsceneFile; //fieldtype: String
	CAssetPath HeroSelectCutsceneFile; //fieldtype: String
	SHeroReleaseDate ReleaseDate //struct
	{
		uint32 Month; //fieldtype: IntUnsigned
		uint32 Day; //fieldtype: IntUnsigned
		uint32 Year; //fieldtype: IntUnsigned
	}
	CStringLink AdditionalSearchText; //fieldtype: String
	CTalentLink Talent; //fieldtype: CatalogLink
	EArtifactType Type; //fieldtype: Unknown
	THyperlinkId HyperlinkId; //fieldtype: String
	CIdentifier[] AllowedCommanderKeyArray; //fieldtype: String
	CItemLink[] Item; //fieldtype: CatalogLink
	CUpgradeLink[] Upgrades; //fieldtype: CatalogLink
	CPlayerResponseLink[] PlayerResponses; //fieldtype: CatalogLink
	CButtonLink Face; //fieldtype: CatalogLink
	CFlagArray<e_playerRelationshipCount>[] ApplyTo; //fieldtype: Flags
}

class CArtifactSlot
{
	CStringLink Name; //fieldtype: String
	CRewardLink RequiredReward; //fieldtype: CatalogLink
	TBattleProductId ProductId; //fieldtype: IntSigned
	CFlagArray<e_artifactTypeCount>[] AllowedTypes; //fieldtype: Flags
}
