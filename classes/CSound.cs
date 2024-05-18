
class CSound
{
	TEditorCategories EditorCategories; //fieldtype: String
	SSoundAsset[] AssetArray //struct
	{
		CString TemplateParam; //fieldtype: String
		CSoundPath File; //fieldtype: String
		int32 LoopCount; //fieldtype: IntSigned
		CiRange LoopTime; //fieldtype: Unknown
		CiRange Offset; //fieldtype: Unknown
		CPitchRange Pitch; //fieldtype: Unknown
		uint32[] SyncPoints; //fieldtype: IntUnsigned
		SSyncPointRange[] SyncPointRanges //struct
		{
			C2iVector BarAndBeat; //fieldtype: Unknown
			C2iVector TimeSignature; //fieldtype: Unknown
			uint16 BeatsPerMinute; //fieldtype: IntUnsigned
			uint16 SyncPointsPerBar; //fieldtype: IntUnsigned
		}
		CVolumeRange Volume; //fieldtype: Unknown
		TSoundWeight Weight; //fieldtype: IntSigned
		CIdentifier FacialAnim; //fieldtype: String
		CIdentifier FacialGroup; //fieldtype: String
		CIdentifier PortraitAnim; //fieldtype: String
		CFacialPath FacialFile; //fieldtype: String
		CModelLink PortraitModel; //fieldtype: CatalogLink
		CActorLink PortraitActor; //fieldtype: CatalogLink
		CStringLink Speaker; //fieldtype: String
		CStringLink Subtitle; //fieldtype: String
	}
	SSoundAssetTemplate AssetArrayTemplate //struct
	{
		CIdentifier File; //fieldtype: String
		CIdentifier FacialAnim; //fieldtype: String
		CIdentifier FacialGroup; //fieldtype: String
		CIdentifier FacialFile; //fieldtype: String
		CIdentifier PortraitAnim; //fieldtype: String
	}
	CFlags[] Flags; //fieldtype: Flags
	ESoundCategory Category; //enum
	ESoundCategory CategoryLocal; //enum
	uint8 Chance; //fieldtype: IntUnsigned
	CRange ConeAngle; //fieldtype: Unknown
	C3Vector ConeOrientation; //fieldtype: Unknown
	CRange ConeVolume; //fieldtype: Unknown
	real32 DopplerLevel; //fieldtype: Float
	uint16 DupeDestroyCount; //fieldtype: IntUnsigned
	uint16 DupeDestroyCountPerPlayer; //fieldtype: IntUnsigned
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
	uint16 DupeHistoryCount; //fieldtype: IntUnsigned
	ESoundDupe DupeMaximumMethod; //enum
	uint16 DupeMuteCount; //fieldtype: IntUnsigned
	uint16 DupeMuteCountPerPlayer; //fieldtype: IntUnsigned
	uint16 DupeRepeatCount; //fieldtype: IntUnsigned
	uint32 DupeThresholdFadeTime; //fieldtype: IntUnsigned
	SVolumeThreshold[] DupeThresholdPoints //struct
	{
		uint32 Count; //fieldtype: IntUnsigned
		CVolume Volume; //fieldtype: Unknown
	}
	CiRange DupeWait; //fieldtype: Unknown
	ESoundDupePriority DupePrioritization; //fieldtype: Unknown
	CSoundExclusivityLink Exclusivity; //fieldtype: CatalogLink
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
	CHerdNodeLink HerdNode; //fieldtype: CatalogLink
	SSoundLocaleFlags[] LocaleFlags //struct
	{
		TLocaleId Locale; //fieldtype: FourCC
		CFlags[] Flags; //fieldtype: Flags
	}
	int32 LoopCount; //fieldtype: IntSigned
	CiRange LoopDelay; //fieldtype: Unknown
	real32 LowPassGain; //fieldtype: Float
	int16 MixerPriority; //fieldtype: IntSigned
	int16 MixerPriorityNonLocal; //fieldtype: IntSigned
	ESoundMode Mode; //enum
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
	CRange OcclusionDirect; //fieldtype: Unknown
	CRange OcclusionReverb; //fieldtype: Unknown
	ESoundBlend OffsetFadeBlend; //enum
	SVolumeFade[] OffsetFadeIn //struct
	{
		uint32 Time; //fieldtype: IntUnsigned
		CVolume Volume; //fieldtype: Unknown
	}
	SVolumeFade[] OffsetFadeOut //struct
	{
		uint32 Time; //fieldtype: IntUnsigned
		CVolume Volume; //fieldtype: Unknown
	}
	ESoundBlend OffsetShiftBlend; //enum
	SPitchShift[] OffsetShiftIn //struct
	{
		uint32 Time; //fieldtype: IntUnsigned
		CPitch Pitch; //fieldtype: Unknown
	}
	SPitchShift[] OffsetShiftOut //struct
	{
		uint32 Time; //fieldtype: IntUnsigned
		CPitch Pitch; //fieldtype: Unknown
	}
	real32 OverlapPitchDelta; //fieldtype: Float
	uint16 OverlapTimeDelta; //fieldtype: IntUnsigned
	CRange Pan; //fieldtype: Unknown
	real32 PanLevel; //fieldtype: Float
	real32 PanLevelNonLocal; //fieldtype: Float
	CPitchRange Pitch; //fieldtype: Unknown
	CiRange PlayDelay; //fieldtype: Unknown
	C3Vector PositionRandomOffset; //fieldtype: Unknown
	real32 PositionRandomOffsetPower; //fieldtype: Float
	uint8 ResourcePriority; //fieldtype: IntUnsigned
	SReverbBalance ReverbBalance //struct
	{
		TSoundBalance Direct; //fieldtype: IntSigned
		TSoundBalance Room; //fieldtype: IntSigned
	}
	ESoundBlend ReverbRolloffBlend; //enum
	SReverbRolloff[] ReverbRolloffPoints //struct
	{
		real32 Distance; //fieldtype: Float
		real32 Direct; //fieldtype: Float
		real32 Room; //fieldtype: Float
	}
	ESoundSelect Select; //enum
	bool32 Solo; //fieldtype: Unknown
	real32[] SpeakerMix; //fieldtype: Float
	real32[] SpeakerMixNonLocal; //fieldtype: Float
	real32 Spread; //fieldtype: Float
	ESoundBlend SustainFadeBlend; //enum
	SVolumeFade[] SustainFade //struct
	{
		uint32 Time; //fieldtype: IntUnsigned
		CVolume Volume; //fieldtype: Unknown
	}
	uint32 Timeout; //fieldtype: IntUnsigned
	uint32 VariationMinimum; //fieldtype: IntUnsigned
	CVolumeRange Volume; //fieldtype: Unknown
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
	CVolumeRange LocalVolumeAdjustment; //fieldtype: Unknown
	CVolumeRange NonLocalVolumeAdjustment; //fieldtype: Unknown
	CSoundMixSnapshotLink CategoryDuckingLocal; //fieldtype: CatalogLink
	CSoundMixSnapshotLink CategoryDuckingNonLocal; //fieldtype: CatalogLink
}

class CSoundExclusivity
{
	uint32 Group; //fieldtype: IntUnsigned
	real32 Priority; //fieldtype: Float
	EExclusivityAction CollideWithLower; //enum
	EExclusivityAction CollideWithEqual; //enum
	EExclusivityAction CollideWithHigher; //enum
	EExclusivityQueueAction QCollideWithLower; //enum
	EExclusivityQueueAction QCollideWithEqual; //enum
	EExclusivityQueueAction QCollideWithHigher; //enum
	uint32 QTimeout; //fieldtype: IntUnsigned
	uint32 QDelay; //fieldtype: IntUnsigned
	ESoundBlend InterruptFadeBlend; //enum
	SVolumeFade[] InterruptFade //struct
	{
		uint32 Time; //fieldtype: IntUnsigned
		CVolume Volume; //fieldtype: Unknown
	}
	uint32 InterruptDelay; //fieldtype: IntUnsigned
	CFlags[] Flags; //fieldtype: Flags
	uint32[] SuppressGroups; //fieldtype: IntUnsigned
	uint32 DupeWait; //fieldtype: IntUnsigned
}

class CSoundMixSnapshot
{
	uint32 Attack; //fieldtype: IntUnsigned
	uint32 Hold; //fieldtype: IntUnsigned
	uint32 Release; //fieldtype: IntUnsigned
	CFlags[] Flags; //fieldtype: Flags
	CVolume[] MixGlobal; //fieldtype: Unknown
	CVolume[] MixNonLocal; //fieldtype: Unknown
}

class CSoundtrack
{
	SSoundtrackCue[] CueArray //struct
	{
		SSoundtrackMasterLayer MasterLayer //struct
		{
			CSoundLink Sound; //fieldtype: CatalogLink
		}
		SSoundtrackSlaveLayer[] SlaveLayers //struct
		{
			SSoundtrackSection[] Sections //struct
			{
				real32 Chance; //fieldtype: Float
				CSoundLink Sound; //fieldtype: CatalogLink
				uint32 Start; //fieldtype: IntUnsigned
			}
		}
		TSoundWeight Weight; //fieldtype: IntSigned
	}
	CiRange Delay; //fieldtype: Unknown
	CFlags[] Flags; //fieldtype: Flags
	ESoundSelect Select; //enum
	CSoundtrackLink Next; //fieldtype: CatalogLink
}
