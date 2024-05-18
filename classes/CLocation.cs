
class CLocation
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CMoviePath Movie; //fieldtype: String
	CStringLink MissionTitle; //fieldtype: String
	CStringLink MissionText; //fieldtype: String
	CStringLink PlanetToolTip; //fieldtype: String
	CStringLink PrimaryObjectiveTitle; //fieldtype: String
	CStringLink PrimaryObjectiveText; //fieldtype: String
	CStringLink SecondaryObjectiveTitle; //fieldtype: String
	CStringLink SecondaryObjectiveText; //fieldtype: String
	CStringLink RewardTitle; //fieldtype: String
	CStringLink RewardText; //fieldtype: String
	CStringLink BonusTitle; //fieldtype: String
	CStringLink BonusText; //fieldtype: String
	CStringLink ContactName; //fieldtype: String
	CModelLink ContactModel; //fieldtype: CatalogLink
	CActorLink ContactActor; //fieldtype: CatalogLink
	CModelLink PlanetModel; //fieldtype: CatalogLink
	CModelLink BackgroundModel; //fieldtype: CatalogLink
	CImagePath BackgroundImage; //fieldtype: String
	SMissionCategory[] MissionCategoryArray //struct
	{
		CStringLink Name; //fieldtype: String
		CMapLink Map; //fieldtype: CatalogLink
		CStringLink Tooltip; //fieldtype: String
		CStringLink CompletedTooltip; //fieldtype: String
		CImagePath RewardImage; //fieldtype: String
		CStringLink RewardTooltip; //fieldtype: String
		EMissionState State; //enum
	}
	CSoundtrackLink AmbientSound; //fieldtype: CatalogLink
	CUserReference UserReference; //fieldtype: Unknown
}
