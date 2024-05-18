
class CMap
{
	CStringLink Name; //fieldtype: String
	CString File; //fieldtype: String
	EMapKind Kind; //enum
	CStringLink Description; //fieldtype: String
	CStringLink MissionTitle; //fieldtype: String
	CStringLink MissionText; //fieldtype: String
	CImagePath MissionBackgroundImage; //fieldtype: String
	CStringLink PrimaryObjectiveTitle; //fieldtype: String
	CStringLink PrimaryObjectiveText; //fieldtype: String
	CStringLink PrimaryObjectiveTooltip; //fieldtype: String
	CStringLink SecondaryObjectiveTitle; //fieldtype: String
	CStringLink SecondaryObjectiveText; //fieldtype: String
	CStringLink SecondaryObjectiveTooltip; //fieldtype: String
	CStringLink RewardTitle; //fieldtype: String
	CStringLink RewardText; //fieldtype: String
	CStringLink RewardTooltip; //fieldtype: String
	CStringLink ResearchTitle; //fieldtype: String
	CStringLink ResearchText; //fieldtype: String
	CStringLink ResearchTooltip; //fieldtype: String
	CStringLink BonusTitle; //fieldtype: String
	CStringLink BonusText; //fieldtype: String
	CStringLink BonusTooltip; //fieldtype: String
	CStringLink TechnologyTitle; //fieldtype: String
	CStringLink TechnologyNameText; //fieldtype: String
	CStringLink TechnologyDescriptionText; //fieldtype: String
	CStringLink TechnologyTooltip; //fieldtype: String
	CUnitLink TechnologyUnitLink; //fieldtype: CatalogLink
	CStringLink ContactTitle; //fieldtype: String
	CStringLink ContactNameText; //fieldtype: String
	CModelLink ContactModelLink; //fieldtype: CatalogLink
	CStringLink ContactTooltip; //fieldtype: String
	CActorLink ContactActor; //fieldtype: CatalogLink
	CImagePath LoadingImage; //fieldtype: String
	CStringLink LoadingTitle; //fieldtype: String
	CStringLink LoadingSubtitle; //fieldtype: String
	CStringLink LoadingBody; //fieldtype: String
	CStringLink LoadingHelp; //fieldtype: String
	CStringLink LoadingHelpRestart; //fieldtype: String
	CStringLink LoadingHelpAlternate; //fieldtype: String
	C2iVector LoadingTextOffset; //fieldtype: Unknown
	uint32 LoadingTextWidth; //fieldtype: IntUnsigned
	uint32 LoadingTextHeight; //fieldtype: IntUnsigned
	CStyleName LoadingTextStyle; //fieldtype: String
	CArmyCategoryLink ArmyCategory; //fieldtype: CatalogLink
	CLocationLink Location; //fieldtype: CatalogLink
	CObjectiveLink[] ObjectiveArray; //fieldtype: CatalogLink
	CStringLink Summary; //fieldtype: String
	CUserReference UserReference; //fieldtype: Unknown
}
