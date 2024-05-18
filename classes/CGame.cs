
class CGame
{
	CBehaviorLink AttackRevealBehavior; //fieldtype: CatalogLink
	CFixed AcquireMovementLimit; //fieldtype: Fixed
	CFixed AcquireLeashRadius; //fieldtype: Fixed
	CFixed AcquireLeashResetRadius; //fieldtype: Fixed
	CGameTime CallForHelpPeriod; //fieldtype: Fixed
	CFixed CallForHelpRadius; //fieldtype: Fixed
	CGameTime CreepBlendTime; //fieldtype: Fixed
	uint32 CreepDecayLimit; //fieldtype: IntUnsigned
	CSoundLink CreepDecaySound; //fieldtype: CatalogLink
	CGameTime CreepDecayTime; //fieldtype: Fixed
	uint32 CreepDecayWeightMultiplier; //fieldtype: IntUnsigned
	uint32 CreepDecayWeightUnscaledBonus; //fieldtype: IntUnsigned
	CSoundLink CreepGrowSound; //fieldtype: CatalogLink
	CGameTime DensityDecayTime; //fieldtype: Fixed
	bool8 DensityPersistent; //fieldtype: Unknown
	CFixed DamageMinimum; //fieldtype: Fixed
	CGameTime AttackRevealTime; //fieldtype: Fixed
	CGameTime PenaltyRevealTime; //fieldtype: Fixed
	CGameTime StalemateTestTime; //fieldtype: Fixed
	CGameTime StalemateWarningTime; //fieldtype: Fixed
	SDifficultyLevel[] DifficultyLevels //struct
	{
		CFourCC AttributeId; //fieldtype: FourCC
		CStringLink Name; //fieldtype: String
		CStringLink NameCampaign; //fieldtype: String
		CStringLink NameMelee; //fieldtype: String
		CStringLink MenuTooltip; //fieldtype: String
		bool32 Enabled; //fieldtype: Unknown
		CFlags[] Flags; //fieldtype: Flags
		int32 ActionsPerMinute; //fieldtype: IntSigned
		uint8 DefaultRebuildUnit; //fieldtype: IntUnsigned
		uint8 DefaultRebuildStructure; //fieldtype: IntUnsigned
	}
	TDifficultyLevel DifficultyDefault; //fieldtype: IntSigned
	SAIBuild[] AIBuilds //struct
	{
		CFourCC AttributeId; //fieldtype: FourCC
		CStringLink Name; //fieldtype: String
		CStringLink MenuTooltip; //fieldtype: String
		bool32 Enabled; //fieldtype: Unknown
		CRaceLink Race; //fieldtype: CatalogLink
		NNet::Game::TDifficulty MinDiff; //fieldtype: IntUnsigned
		NNet::Game::TDifficulty MaxDiff; //fieldtype: IntUnsigned
		int32 BuildScriptNum; //fieldtype: IntSigned
	}
	NNet::Game::TAIBuild AIBuildDefault; //fieldtype: IntUnsigned
	SHandicap[] HandicapValues //struct
	{
		CStringLink MenuTooltip; //fieldtype: String
		NNet::Game::THandicap Percent; //fieldtype: IntUnsigned
	}
	CFixed AirFormationDiameter; //fieldtype: Fixed
	CFixed MixedFormationDiameter; //fieldtype: Fixed
	CFixed FormationSeparationFactor; //fieldtype: Fixed
	SMapSize[] MapSizes //struct
	{
		CStringLink Name; //fieldtype: String
		uint32 MaxCells; //fieldtype: IntUnsigned
	}
	CiQuad UnpathableMargin; //fieldtype: Unknown
	CiQuad CameraMargin; //fieldtype: Unknown
	SAspectMargin[] CameraMarginAspectAdjust //struct
	{
		uint32 AspectWidth; //fieldtype: IntUnsigned
		uint32 AspectHeight; //fieldtype: IntUnsigned
		CiQuad Margin; //fieldtype: Unknown
	}
	STeamColor[] TeamColors //struct
	{
		real32 HDRMultiplier; //fieldtype: Float
		CStringLink Name; //fieldtype: String
		C4Vector[] Value; //fieldtype: Unknown
		bool32 UserChoice; //fieldtype: Unknown
		int32 MinPlayerCount; //fieldtype: IntSigned
		CFourCC AttributeId; //fieldtype: FourCC
	}
	CEffectLink SplashDamageEffect; //fieldtype: CatalogLink
	EAttackType DefaultAttackType; //fieldtype: Unknown
	CFixed WeaponHighGroundChanceToMiss; //fieldtype: Fixed
	CFixed UnitSightRangeDead; //fieldtype: Fixed
	CFixed UnitSightRangeUnderConstruction; //fieldtype: Fixed
	SAIDescription[] AI //struct
	{
		CFourCC Id; //fieldtype: FourCC
		CStringLink Name; //fieldtype: String
		CIdentifier File; //fieldtype: String
		CString32 Suffix; //fieldtype: String
	}
	STriggerLib[] TriggerLibs //struct
	{
		TTriggerLibId Id; //fieldtype: String
		CString IncludePath; //fieldtype: String
	}
	STargetFilterResult[] FilterResults //struct
	{
		CTargetFilters Filter; //fieldtype: Unknown
		TCmdResult Result; //fieldtype: Unknown
	}
	SBeaconInfo[] BeaconInfoArray //struct
	{
		CAlertLink Alert; //fieldtype: CatalogLink
		CUnitLink Unit; //fieldtype: CatalogLink
		CStringLink Tooltip; //fieldtype: String
		CFlags[] Clear; //fieldtype: Flags
	}
	CAbilLink SprayAbil; //fieldtype: CatalogLink
	CButtonLink[] SprayButtonReplacementTarget; //fieldtype: CatalogLink
	CAbilLink TauntAbil; //fieldtype: CatalogLink
	CGameTime UncontestedCombatPeriod; //fieldtype: Fixed
	uint32[] AIResourceRequest; //fieldtype: IntUnsigned
	SDamageTypeInfo[] DamageCategories //struct
	{
		EDamageCategory Category; //enum
		CTargetFilters SupportedFilters; //fieldtype: Unknown
	}
	SAttackTypeInfo[] AttackArmorTable //struct
	{
		CFixed[] ArmorFactor; //fieldtype: Fixed
		CTargetFilters SupportedFilters; //fieldtype: Unknown
		bool8 FailThroughToDamageType; //fieldtype: Unknown
	}
	CFixed VeterancySearchRadius; //fieldtype: Fixed
	CTargetFilters VeterancySearchFilters; //fieldtype: Unknown
	uint32 VeterancySearchMaxCount; //fieldtype: IntUnsigned
	CTargetFilters VeterancyKillerFilters; //fieldtype: Unknown
	uint32[] UnitLevelKillXPTable; //fieldtype: IntUnsigned
	CFixed UnitLevelKillXPLevelFactor; //fieldtype: Fixed
	CFixed UnitLevelKillXPPreviousValueFactor; //fieldtype: Fixed
	uint32 UnitLevelKillXPBonusPerLevel; //fieldtype: IntUnsigned
	uint32[] VeterancyLevelKillXPTable; //fieldtype: IntUnsigned
	CFixed VeterancyLevelKillXPLevelFactor; //fieldtype: Fixed
	CFixed VeterancyLevelKillXPPreviousValueFactor; //fieldtype: Fixed
	uint32 VeterancyLevelKillXPBonusPerLevel; //fieldtype: IntUnsigned
	SResourceConvert[] ResourceConvertArray //struct
	{
		CFixed[] RatioArray; //fieldtype: Fixed
	}
	CFixed DamageHistoryIntervalMax; //fieldtype: Fixed
	SMeleePointThreshold MeleePointsThreshold //struct
	{
		uint32 Value; //fieldtype: IntUnsigned
		CFixed Factor; //fieldtype: Fixed
	}
	CGameTime MeleePointsGameDurationMin; //fieldtype: Fixed
	CFixed FoodCappedMax; //fieldtype: Fixed
	CFixed[] TeleportResetRange; //fieldtype: Fixed
	bool8 CalculateFullVision; //fieldtype: Unknown
	bool8 JoinInProgress; //fieldtype: Unknown
	CFlags8[] PathingConfig; //fieldtype: Flags
	CFlagArray<e_playerLeaveFlagCount>[] PlayerLeaveFlags; //fieldtype: Flags
	CFixed HeroOverlapPercent; //fieldtype: Fixed
	bool8 SmartCommandContinuous; //fieldtype: Unknown
	CScoreResultLink EnforcedGameResultScoreResult; //fieldtype: CatalogLink
	uint16 DefaultPauseCountPerPlayer; //fieldtype: IntUnsigned
	bool8 UnlimitedPause; //fieldtype: Unknown
	bool8 EnableRewardSkins; //fieldtype: Unknown
	bool8 EnableRewardVoicePacks; //fieldtype: Unknown
	bool8 EnableRewardConsoleSkins; //fieldtype: Unknown
	uint32 PlayersRequiredForLargeFormat; //fieldtype: IntUnsigned
	CFixed DeepWaterThreshold; //fieldtype: Fixed
	bool8 GenerateWaterPathing; //fieldtype: Unknown
	CValidatorLink NeutralPlayerScanValidator; //fieldtype: CatalogLink
}

class CGameUI
{
	SChallengeCategory[] ChallengeCategory //struct
	{
		CStringLink Name; //fieldtype: String
		SChallenge[] Challenge //struct
		{
			CString Id; //fieldtype: String
			CStringLink Name; //fieldtype: String
			CStringLink Description; //fieldtype: String
			CStringLink Score; //fieldtype: String
			CAssetPath MapPath; //fieldtype: String
			CAssetPath ThumbnailImagePath; //fieldtype: String
			CAchievementLink[] Achievement; //fieldtype: CatalogLink
			bool32 IsAllowedInTrial; //fieldtype: Unknown
		}
	}
	CAchievementLink[] ChallengeMasterAchievement; //fieldtype: CatalogLink
	CCampaignLink[] Campaign; //fieldtype: CatalogLink
	uint32 StartupCampaign; //fieldtype: IntUnsigned
	SMovieConfig[] StartupMovieArray //struct
	{
		CStringLink Name; //fieldtype: String
		CMoviePath Path; //fieldtype: String
		CIdentifier Source; //fieldtype: String
	}
	CSoundtrackLink[] MusicArray; //fieldtype: CatalogLink
	uint32 StartupMusic; //fieldtype: IntUnsigned
	CSoundtrackLink IntroMusic; //fieldtype: CatalogLink
	CSoundtrackLink PostGameMusic; //fieldtype: CatalogLink
	CSoundtrackLink CreditsMusic; //fieldtype: CatalogLink
	CSoundtrackLink MatchmakingMusic; //fieldtype: CatalogLink
	CSoundtrackLink LoopAmbience; //fieldtype: CatalogLink
	SSoundQuality[] SoundQuality //struct
	{
		uint32 AutoDetectCPUCoreMaximum; //fieldtype: IntUnsigned
		uint32 Channels; //fieldtype: IntUnsigned
		CFlags[] Flags; //fieldtype: Flags
		CStringLink Name; //fieldtype: String
		ESoundFormat Format; //enum
		ESoundResampler Resampler; //enum
		uint32 SampleRate; //fieldtype: IntUnsigned
		ESpeakerMode SpeakerMode; //enum
		uint32[] VariationMaximum; //fieldtype: IntUnsigned
	}
	SMinimapData MinimapData //struct
	{
		CColor InnerBorderColor; //fieldtype: Unknown
		CColor OuterBorderColor; //fieldtype: Unknown
		CColor FrustumColor; //fieldtype: Unknown
		CColor ResourceUnitColor; //fieldtype: Unknown
		CColor ResourceUnitColorBlindColor; //fieldtype: Unknown
		CColor BlipUnitColor; //fieldtype: Unknown
		CColor UnitBorderColor; //fieldtype: Unknown
		CColor SelectedUnitBorderColor; //fieldtype: Unknown
		CColor BackGroundColor; //fieldtype: Unknown
		real32 BorderSize; //fieldtype: Float
		real32 SelectedBorderSize; //fieldtype: Float
		real32 MinUnitDotSize; //fieldtype: Float
		uint8 RadarAlpha; //fieldtype: IntUnsigned
	}
	SSelectionData SelectionData //struct
	{
		real32 SelectionWidth; //fieldtype: Float
		real32 SelectionFallOff; //fieldtype: Float
		C3Vector SelectionAlpha; //fieldtype: Unknown
		C3Vector SelectionTiming; //fieldtype: Unknown
		uint32 SelectionSegmentCount; //fieldtype: IntUnsigned
		real32 SelectionSegmentPercentSolid; //fieldtype: Float
		real32 SelectionRotationSpeed; //fieldtype: Float
		real32 SelectionInnerOffsetRatio; //fieldtype: Float
		real32 SelectionInnerBoundaryRatio; //fieldtype: Float
		real32 SelectionInnerBoundaryFallOffRatio; //fieldtype: Float
		real32 PreselectionWidth; //fieldtype: Float
		real32 PreselectionFallOff; //fieldtype: Float
		C3Vector PreselectionAlpha; //fieldtype: Unknown
		C3Vector PreselectionTiming; //fieldtype: Unknown
		uint32 PreselectionSegmentCount; //fieldtype: IntUnsigned
		real32 PreselectionSegmentPercentSolid; //fieldtype: Float
		real32 PreselectionRotationSpeed; //fieldtype: Float
	}
	SSoundData[] SoundData //struct
	{
		ESoundBlend DupeFadeBlend; //enum
		SVolumeFade[] DupeFadeIn //struct
		{
			uint32 Time; //fieldtype: IntUnsigned
			CVolume Volume; //fieldtype: Unknown
		}
		SVolumeFade[] DupeFadeOut //struct
		{
			uint32 Time; //fieldtype: IntUnsigned
			CVolume Volume; //fieldtype: Unknown
		}
		ESoundBlend FogFadeBlend; //enum
		SVolumeFade[] FogFadeIn //struct
		{
			uint32 Time; //fieldtype: IntUnsigned
			CVolume Volume; //fieldtype: Unknown
		}
		SVolumeFade[] FogFadeOut //struct
		{
			uint32 Time; //fieldtype: IntUnsigned
			CVolume Volume; //fieldtype: Unknown
		}
		int16 MixerPriority; //fieldtype: IntSigned
		int16 MixerPriorityNonLocal; //fieldtype: IntSigned
		bool32 Mute; //fieldtype: Unknown
		ESoundBlend MuteFadeBlend; //enum
		SVolumeFade[] MuteFadeIn //struct
		{
			uint32 Time; //fieldtype: IntUnsigned
			CVolume Volume; //fieldtype: Unknown
		}
		SVolumeFade[] MuteFadeOut //struct
		{
			uint32 Time; //fieldtype: IntUnsigned
			CVolume Volume; //fieldtype: Unknown
		}
		ESoundBlend ReverbRolloffBlend; //enum
		SReverbRolloff[] ReverbRolloffPoints //struct
		{
			real32 Distance; //fieldtype: Float
			real32 Direct; //fieldtype: Float
			real32 Room; //fieldtype: Float
		}
		bool32 Solo; //fieldtype: Unknown
		uint32 ThresholdFadeTime; //fieldtype: IntUnsigned
		SVolumeThreshold[] ThresholdPoints //struct
		{
			uint32 Count; //fieldtype: IntUnsigned
			CVolume Volume; //fieldtype: Unknown
		}
		CVolume Volume; //fieldtype: Unknown
		CVolume VolumeBaseline; //fieldtype: Unknown
		ESoundBlend VolumeRolloffBlend; //enum
		ESoundBlend VolumeRolloffFadeBlend; //enum
		SVolumeFade[] VolumeRolloffFadeIn //struct
		{
			uint32 Time; //fieldtype: IntUnsigned
			CVolume Volume; //fieldtype: Unknown
		}
		SVolumeFade[] VolumeRolloffFadeOut //struct
		{
			uint32 Time; //fieldtype: IntUnsigned
			CVolume Volume; //fieldtype: Unknown
		}
		SVolumeRolloff[] VolumeRolloffPoints //struct
		{
			real32 Distance; //fieldtype: Float
			CVolume Volume; //fieldtype: Unknown
		}
		ESoundBlend MaxFadeBlend; //enum
		SVolumeFade[] MaxFadeOut //struct
		{
			uint32 Time; //fieldtype: IntUnsigned
			CVolume Volume; //fieldtype: Unknown
		}
		uint32 AlertFadeTimeOut; //fieldtype: IntUnsigned
		uint32 AlertFadeTimeIn; //fieldtype: IntUnsigned
		CVolumeRange AlertFadeVolume; //fieldtype: Unknown
		CDSPLink[] StartupDSPArray; //fieldtype: CatalogLink
		CDSPLink[] DSPArray; //fieldtype: CatalogLink
		CFlags[] Flags; //fieldtype: Flags
		EMuteControl MuteControl; //enum
		EVolumeControl VolumeControl; //enum
		CVolumeRange LocalVolumeAdjustment; //fieldtype: Unknown
		CVolumeRange NonLocalVolumeAdjustment; //fieldtype: Unknown
		uint32 CategoryDuckingFadeTimeIn; //fieldtype: IntUnsigned
		uint32 CategoryDuckingFadeTimeOut; //fieldtype: IntUnsigned
		CVolume[] CategoryDucking; //fieldtype: Unknown
		CVolume[] CategoryDuckingNonLocal; //fieldtype: Unknown
		CVolume MinimumDuckingLevel; //fieldtype: Unknown
		ESoundMaxMethod MaxMethod; //enum
		uint16 MaxCountPerPlayer; //fieldtype: IntUnsigned
		uint16 MaxCountGlobal; //fieldtype: IntUnsigned
		ESoundMaxPrioritization MaxPrioritization; //fieldtype: Unknown
	}
	SMixRoute[] MixRouting //struct
	{
		ESoundCategory ParentCategory; //enum
	}
	SGlobalSoundData GlobalSoundData //struct
	{
		real32 SoundDistanceFactor; //fieldtype: Float
		real32 SoundDopplerFactor; //fieldtype: Float
		real32 SoundRolloffFactor; //fieldtype: Float
		real32 HeadphoneModeMinAngle; //fieldtype: Float
		real32 HeadphoneModeMaxAngle; //fieldtype: Float
		real32 HeadphoneModeFrequency; //fieldtype: Float
	}
	CDSPLink[] StartupDSPArray; //fieldtype: CatalogLink
	CDSPLink[] DSPArray; //fieldtype: CatalogLink
	SPointModel[] PointModels //struct
	{
		CModelPath Model; //fieldtype: String
		real32 Scale; //fieldtype: Float
		uint32 NameSize; //fieldtype: IntUnsigned
		real32 HeightOffset; //fieldtype: Float
		C3Vector SelectionOffset; //fieldtype: Unknown
		real32 SelectionRadius; //fieldtype: Float
	}
	uint32 RegionNameSize; //fieldtype: IntUnsigned
	SLookAtType[] LookAtTypes //struct
	{
		CString80 Id; //fieldtype: String
		CStringLink Name; //fieldtype: String
		SLookAtTypeInfo[] Start //struct
		{
			CActorKey Group; //fieldtype: String
			CFixed Weight; //fieldtype: Fixed
			uint32 Time; //fieldtype: IntUnsigned
			CActorAngle Rate; //fieldtype: Unknown
		}
		SLookAtTypeInfo[] Stop //struct
		{
			CActorKey Group; //fieldtype: String
			CFixed Weight; //fieldtype: Fixed
			uint32 Time; //fieldtype: IntUnsigned
			CActorAngle Rate; //fieldtype: Unknown
		}
	}
	SCameraShakeAmplitude[] CameraShakeAmplitudes //struct
	{
		CString80 Id; //fieldtype: String
		CStringLink Name; //fieldtype: String
		C3Vector Position; //fieldtype: Unknown
		SCameraShakeRotation Rotation //struct
		{
			real32 Yaw; //fieldtype: Float
			real32 Pitch; //fieldtype: Float
			real32 Roll; //fieldtype: Float
		}
	}
	SCameraShakeFrequency[] CameraShakeFrequencies //struct
	{
		CString80 Id; //fieldtype: String
		CStringLink Name; //fieldtype: String
		C3Vector Position; //fieldtype: Unknown
		SCameraShakeRotation Rotation //struct
		{
			real32 Yaw; //fieldtype: Float
			real32 Pitch; //fieldtype: Float
			real32 Roll; //fieldtype: Float
		}
	}
	SListenerRolloff[] ListenerAngleRolloff //struct
	{
		real32 CameraValue; //fieldtype: Float
		real32 ListenerFactor; //fieldtype: Float
	}
	SListenerRolloff[] ListenerDistanceRolloff //struct
	{
		real32 CameraValue; //fieldtype: Float
		real32 ListenerFactor; //fieldtype: Float
	}
	CModelLink PlanetPanelDefaultBackground; //fieldtype: CatalogLink
	EUIColorRelation[] PlayerIdObserverColorMap; //enum
	CColor[] BehaviorIconColors; //fieldtype: Unknown
	CColor[] BehaviorBorderColors; //fieldtype: Unknown
	SVitalColor[] VitalColors //struct
	{
		CColor[] ColorArray; //fieldtype: Unknown
	}
	CColor[] SelectionColors; //fieldtype: Unknown
	CColor[] SelectionColorBlindColors; //fieldtype: Unknown
	uint8 RadarAlpha; //fieldtype: IntUnsigned
	STeamColor[] OverrideColors //struct
	{
		real32 HDRMultiplier; //fieldtype: Float
		CStringLink Name; //fieldtype: String
		C4Vector[] Value; //fieldtype: Unknown
		bool32 UserChoice; //fieldtype: Unknown
		int32 MinPlayerCount; //fieldtype: IntSigned
		CFourCC AttributeId; //fieldtype: FourCC
	}
	STeamColor[] ColorBlindColors //struct
	{
		real32 HDRMultiplier; //fieldtype: Float
		CStringLink Name; //fieldtype: String
		C4Vector[] Value; //fieldtype: Unknown
		bool32 UserChoice; //fieldtype: Unknown
		int32 MinPlayerCount; //fieldtype: IntSigned
		CFourCC AttributeId; //fieldtype: FourCC
	}
	CColor[] WireframeColorArray; //fieldtype: Unknown
	SUnitSpeedText[] MovementSpeedArray //struct
	{
		CGameSpeed MinSpeed; //fieldtype: Fixed
		CStringLink Text; //fieldtype: String
	}
	SWeaponSpeedText[] WeaponSpeedArray //struct
	{
		CGameTime MinSpeed; //fieldtype: Fixed
		CStringLink Text; //fieldtype: String
	}
	CColor InfoColorBuffed; //fieldtype: Unknown
	CColor InfoColorDebuffed; //fieldtype: Unknown
	CColor InfoColorUpgraded; //fieldtype: Unknown
	CColor RequirementsSatisfiedColor; //fieldtype: Unknown
	CColor RequirementsUnsatisfiedColor; //fieldtype: Unknown
	CImagePath RandomRaceIcon; //fieldtype: String
	bool32 DisplayScaledTime; //fieldtype: Unknown
	bool32 DisplayTimeInSeconds; //fieldtype: Unknown
	uint32 UnitDamageFlashDuration; //fieldtype: IntUnsigned
	uint32 UnitDamageNotificationCooldown; //fieldtype: IntUnsigned
	uint32 UnitDamageNotificationDelay; //fieldtype: IntUnsigned
	CButtonLink CancelTargetModeButtonFace; //fieldtype: CatalogLink
	CButtonLink CancelPlacementModeButtonFace; //fieldtype: CatalogLink
	uint32 PlacementDisplayBonusRadius; //fieldtype: IntUnsigned
	uint32 PlacementDisplayMinimumRadius; //fieldtype: IntUnsigned
	CColor PlacementErrorColor; //fieldtype: Unknown
	CColor PlacementWarningColor; //fieldtype: Unknown
	CColor PlacementPerfectColor; //fieldtype: Unknown
	CColor PlacementColorBlindErrorColor; //fieldtype: Unknown
	CColor PlacementColorBlindWarningColor; //fieldtype: Unknown
	CColor PlacementColorBlindDefaultColor; //fieldtype: Unknown
	C2iVector PlacementGridDimensions; //fieldtype: Unknown
	CGameTime PossibleEnemyPlacementPingDuration; //fieldtype: Fixed
	CModelLink PossibleEnemyPlacementPingModel; //fieldtype: CatalogLink
	CColor PossibleEnemyPlacementPingColor; //fieldtype: Unknown
	uint32 ScreenModeTransitionDuration; //fieldtype: IntUnsigned
	CColor[] CostDisplayColor; //fieldtype: Unknown
	CGameTime CostDisplayFade; //fieldtype: Fixed
	uint32 CostDisplayHeight; //fieldtype: IntUnsigned
	CFixed CostDisplayHeightOffset; //fieldtype: Fixed
	CGameSpeed CostDisplaySpeed; //fieldtype: Fixed
	CGameTime CostDisplayTime; //fieldtype: Fixed
	real32 WayPointMultiUnitFadePoint; //fieldtype: Float
	real32 WayPointMultiUnitFadeAlpha; //fieldtype: Float
	real32 WayPointLineWidth; //fieldtype: Float
	real32 WayPointTileLength; //fieldtype: Float
	CColor[] DefaultPathColor; //fieldtype: Unknown
	real32[] DefaultPathLineWidth; //fieldtype: Float
	real32[] DefaultPathTileLength; //fieldtype: Float
	CImagePath[] DefaultPathTexture; //fieldtype: String
	CModelPath[] DefaultPathStepModel; //fieldtype: String
	real32[] DefaultPathStepModelScale; //fieldtype: Float
	uint32 StrobeCycleLength; //fieldtype: IntUnsigned
	real32 StrobeFalloff; //fieldtype: Float
	real32 StrobeHeight; //fieldtype: Float
	real32 StrobeHaloEmission; //fieldtype: Float
	CColor StrobeHighlightColor; //fieldtype: Unknown
	C3Vector GlowPeakMultiplier; //fieldtype: Unknown
	CRect TransmissionSoundRect; //fieldtype: Unknown
	real32 TransmissionSoundDepth; //fieldtype: Float
	CString DefaultInfoTooltipTypes; //fieldtype: String
	SObjectGroupData[] ObjectGroupData //struct
	{
		uint32 MinLevel; //fieldtype: IntUnsigned
		CImagePath MinimapIcon; //fieldtype: String
	}
	SLoadingScreenHelp[] LoadingScreenHelpIntro //struct
	{
		CStringLink Text; //fieldtype: String
		CRaceLink Race; //fieldtype: CatalogLink
	}
	SLoadingScreenHelp[] LoadingScreenHelp //struct
	{
		CStringLink Text; //fieldtype: String
		CRaceLink Race; //fieldtype: CatalogLink
	}
	SLoadingBar[] LoadingBars //struct
	{
		CStringLink Name; //fieldtype: String
		CString FrameSuffix; //fieldtype: String
	}
	SUnitKillRank[] UnitKillRank //struct
	{
		uint32 MinKills; //fieldtype: IntUnsigned
		CStringLink Text; //fieldtype: String
	}
	real32 AlertPanMaxDuration; //fieldtype: Float
	real32 AlertPanMinDuration; //fieldtype: Float
	real32 AlertPanMaxVelocity; //fieldtype: Float
	CImagePath BeaconMinimapIcon; //fieldtype: String
	CActorKey BeaconMinimapRenderPriority; //fieldtype: String
	CFourCC[] AchievementTags; //fieldtype: FourCC
	SGameCategory[] GameCategories //struct
	{
		EGameCategoryUsage Usage; //enum
		SGameModeInfo Info //struct
		{
			uint32 Id; //fieldtype: IntUnsigned
			bool32 CanOverrideText; //fieldtype: Unknown
			bool32 IsTutorial; //fieldtype: Unknown
			CStringLink Name; //fieldtype: String
			CStringLink Description; //fieldtype: String
		}
		SGameModeInfo[] Modes //struct
		{
			uint32 Id; //fieldtype: IntUnsigned
			bool32 CanOverrideText; //fieldtype: Unknown
			bool32 IsTutorial; //fieldtype: Unknown
			CStringLink Name; //fieldtype: String
			CStringLink Description; //fieldtype: String
		}
	}
	SDefaultGameVariant AutoVariantArcade //struct
	{
		uint32 CategoryId; //fieldtype: IntUnsigned
		uint32 ModeId; //fieldtype: IntUnsigned
		int32 MinPlayers; //fieldtype: IntSigned
		int32 MaxPlayers; //fieldtype: IntSigned
		int32 TeamCount; //fieldtype: IntSigned
		int32 PlayersPerTeam; //fieldtype: IntSigned
		int32 PlayersPerTandem; //fieldtype: IntSigned
		TDifficultyLevel AIDifficulty; //fieldtype: IntSigned
		CFlags[] Options; //fieldtype: Flags
		CFourCC[] AchievementTags; //fieldtype: FourCC
	}
	SDefaultGameVariant AutoVariantMelee //struct
	{
		uint32 CategoryId; //fieldtype: IntUnsigned
		uint32 ModeId; //fieldtype: IntUnsigned
		int32 MinPlayers; //fieldtype: IntSigned
		int32 MaxPlayers; //fieldtype: IntSigned
		int32 TeamCount; //fieldtype: IntSigned
		int32 PlayersPerTeam; //fieldtype: IntSigned
		int32 PlayersPerTandem; //fieldtype: IntSigned
		TDifficultyLevel AIDifficulty; //fieldtype: IntSigned
		CFlags[] Options; //fieldtype: Flags
		CFourCC[] AchievementTags; //fieldtype: FourCC
	}
	SDefaultGameVariant[] DefaultVariants //struct
	{
		uint32 CategoryId; //fieldtype: IntUnsigned
		uint32 ModeId; //fieldtype: IntUnsigned
		int32 MinPlayers; //fieldtype: IntSigned
		int32 MaxPlayers; //fieldtype: IntSigned
		int32 TeamCount; //fieldtype: IntSigned
		int32 PlayersPerTeam; //fieldtype: IntSigned
		int32 PlayersPerTandem; //fieldtype: IntSigned
		TDifficultyLevel AIDifficulty; //fieldtype: IntSigned
		CFlags[] Options; //fieldtype: Flags
		CFourCC[] AchievementTags; //fieldtype: FourCC
	}
	CRaceLink DefaultUIRace; //fieldtype: CatalogLink
	CSoundtrackLink ObserverSoundtrack; //fieldtype: CatalogLink
	bool8 UseMaxCooldown; //fieldtype: Unknown
	uint8 CooldownDurationPrecision; //fieldtype: IntUnsigned
	CGameTime MinCooldownDisplayDuration; //fieldtype: Fixed
	CGameTime MinTimeDisplayDuration; //fieldtype: Fixed
	STutorialConfig[] TutorialArray //struct
	{
		CStringLink Title; //fieldtype: String
		CStringLink Description; //fieldtype: String
		CImagePath Icon; //fieldtype: String
		CMoviePath Movie; //fieldtype: String
	}
	SHotkeyInfo[] HotkeyInfoArray //struct
	{
		CStringLink Category; //fieldtype: String
		CStringLink Name; //fieldtype: String
		CStringLink Tooltip; //fieldtype: String
	}
	CFontStylePath[] FontStyleFileArray; //fieldtype: String
	CLayoutPath[] CustomLayoutFileArray; //fieldtype: String
	SResourceUI[] ResourceArray //struct
	{
		CAssetLink Icon; //fieldtype: Unknown
		CAssetLink IconBackground; //fieldtype: Unknown
		CStringLink Tooltip; //fieldtype: String
	}
	CAssetPath[] TrialAllowedSinglePlayerMaps; //fieldtype: String
	bool8 CommandHotkeyRepeatIgnored; //fieldtype: Unknown
	bool8 AllowReturnToGameplayWhenDefeated; //fieldtype: Unknown
	bool8 ActivateLobbyChatOnJoin; //fieldtype: Unknown
	CFixed CameraEventThresholdDistance; //fieldtype: Fixed
	CFangle CameraEventThresholdPitch; //fieldtype: Fixed
	CFangle CameraEventThresholdYaw; //fieldtype: Fixed
	CFixed CameraEventThresholdTarget; //fieldtype: Fixed
	SHelpControlCategoryInfo[] HelpControlCategories //struct
	{
		CStringLink Name; //fieldtype: String
		CStringLink Description; //fieldtype: String
	}
	SHelpControlInfo[] HelpControls //struct
	{
		CStringLink Category; //fieldtype: String
		CStringLink Name; //fieldtype: String
		CStringLink Description; //fieldtype: String
		bool8 Basic; //fieldtype: Unknown
	}
	SHelpGameMechanicInfo[] HelpGameMechanics //struct
	{
		CAssetLink Icon; //fieldtype: Unknown
		CAssetLink IconBackground; //fieldtype: Unknown
		CStringLink Name; //fieldtype: String
		CStringLink Description; //fieldtype: String
	}
	CStringLink HelpTechTitle; //fieldtype: String
	bool8 HelpHiddenInGlue; //fieldtype: Unknown
	CString HelpTechTreeSuffix; //fieldtype: String
	SAltSoundtrack[] AltSoundtrack //struct
	{
		CStringLink AltSoundtrackName; //fieldtype: String
		CString Suffix; //fieldtype: String
	}
	TPlayerId DefaultObservedPlayerId; //fieldtype: IntUnsigned
	bool8 SuppressSkinsForParticipants; //fieldtype: Unknown
	bool8 SuppressSkinsInReplay; //fieldtype: Unknown
	CScoreValueLink MapMechanicScoreValue; //fieldtype: CatalogLink
	ETargetModeValidation TargetModeValidation; //fieldtype: Unknown
	EQuickCastMode QuickCastMode; //fieldtype: Unknown
	CStringLink[] CutsceneThemeChoiceArray; //fieldtype: String
	SCutsceneAssetPath[] CutsceneAssetPath //struct
	{
		CAssetLink Path; //fieldtype: Unknown
		EGlueTheme Theme; //enum
	}
	EGlueTheme CutsceneLatest; //enum
}
