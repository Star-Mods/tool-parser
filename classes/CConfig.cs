
class CConfig
{
	CStringLink Name; //fieldtype: String
	SGameContentCreationData[] GameContentArray; //fieldtype: Unknown
	CIdentifier BoostLicense; //fieldtype: String
	uint32 SilencePenaltyLicense; //fieldtype: IntUnsigned
	uint32 FreeNonKRIGRLicense; //fieldtype: IntUnsigned
	CCommanderLink CommanderMastery; //fieldtype: CatalogLink
	SCommanderDifficultyLevel[] CommanderDifficultyLevels //struct
	{
		TDifficultyLevel DifficultyLevel; //fieldtype: IntSigned
		TCommanderLevel CommanderLevel; //fieldtype: IntUnsigned
		CStringLink Name; //fieldtype: String
		CStringLink Description; //fieldtype: String
		uint32 BonusModifier; //fieldtype: IntUnsigned
		bool8 IsDefault; //fieldtype: Unknown
		CImagePath Icon; //fieldtype: String
		TDifficultyLevel AISkillLevel; //fieldtype: IntSigned
		uint8 BeyondBrutalLevel; //fieldtype: IntUnsigned
		bool8 RequirePartyToQueue; //fieldtype: Unknown
		bool8 IsRetry; //fieldtype: Unknown
	}
	uint32 CommanderAchievementCategoryId; //fieldtype: IntUnsigned
	uint32 CoopCampaignAchievementCategoryId; //fieldtype: IntUnsigned
}
