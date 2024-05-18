
class CConversation
{
	TEditorCategories EditorCategories; //fieldtype: String
	int32 AnimBlendDefault; //fieldtype: IntSigned
	int32 AnimBlendOut; //fieldtype: IntSigned
	SConversationProductionLevel[] ProductionLevelInfo //struct
	{
		CString SubtitlePrefix; //fieldtype: String
		CFlagArray<e_conversationProductionLevelFlagCount>[] Flags; //fieldtype: Flags
	}
	EConversationProductionLevel ProductionLevel; //enum
	CConversationStateLink[] ObjectStates; //fieldtype: CatalogLink
	CCharacterLink DefaultSpeaker1; //fieldtype: CatalogLink
	CCharacterLink DefaultSpeaker2; //fieldtype: CatalogLink
	CSoundLink SoundParent; //fieldtype: CatalogLink
	SConversationConditionSet[] FixedConditions //struct
	{
		SConversationCondition[] Conditions //struct
		{
			TConversationStateOpId FixedId; //fieldtype: String
			CConversationStateLink State; //fieldtype: CatalogLink
			TConversationStateIndexId Index; //fieldtype: String
			SConversationUserValue User //struct
			{
				CUserLink Type; //fieldtype: CatalogLink
				TUserFieldId Field; //fieldtype: String
				int32 Index; //fieldtype: IntSigned
				TUserInstanceId Instance; //fieldtype: String
			}
			EConversationConditionOp Operation; //enum
			int32 Value; //fieldtype: IntSigned
		}
		CStringLink Text; //fieldtype: String
	}
	SConversationActionSet[] FixedActions //struct
	{
		SConversationAction[] Actions //struct
		{
			TConversationStateOpId FixedId; //fieldtype: String
			CConversationStateLink State; //fieldtype: CatalogLink
			TConversationStateIndexId Index; //fieldtype: String
			SConversationUserValue User //struct
			{
				CUserLink Type; //fieldtype: CatalogLink
				TUserFieldId Field; //fieldtype: String
				int32 Index; //fieldtype: IntSigned
				TUserInstanceId Instance; //fieldtype: String
			}
			EConversationActionOp Operation; //enum
			int32 Value; //fieldtype: IntSigned
		}
		CStringLink Text; //fieldtype: String
	}
	SConversationFacialAnim[] FacialAnims //struct
	{
		TConversationItemId Id; //fieldtype: String
		CStringLink Text; //fieldtype: String
		CString SpeechTag; //fieldtype: String
		CString SpeechAtts; //fieldtype: String
		CString AnimTag; //fieldtype: String
		CString AnimAtts; //fieldtype: String
	}
	SConversationLine[] Lines //struct
	{
		TConversationItemId Id; //fieldtype: String
		CStringLink Text; //fieldtype: String
		CString Comment; //fieldtype: String
		TConversationItemId FacialAnim; //fieldtype: String
		uint32 FacialBlend; //fieldtype: IntUnsigned
		bool8 FacialAsVoiceDir; //fieldtype: Unknown
		CSoundLink Sound; //fieldtype: CatalogLink
		int32 SoundIndex; //fieldtype: IntSigned
		uint32 FixedDuration; //fieldtype: IntUnsigned
		bool8 NoWait; //fieldtype: Unknown
		uint32 OverlapPrevious; //fieldtype: IntUnsigned
		CAnimProps AnimProps; //fieldtype: Unknown
		int32 AnimBlendIn; //fieldtype: IntSigned
		int32 AnimBlendOut; //fieldtype: IntSigned
		CString LookAtType; //fieldtype: String
		CAttachMethods LookAtAttach; //fieldtype: Unknown
		TConversationStateIndexId[] Objects; //fieldtype: String
		TConversationStateVariation[] Variations; //fieldtype: String
		CStringLink CustomSpeaker; //fieldtype: String
		CCharacterLink SpeakerCharacter; //fieldtype: CatalogLink
		CString SpeakerVariation; //fieldtype: String
		CCharacterLink ListenerCharacter; //fieldtype: CatalogLink
		bool8 AltLine; //fieldtype: Unknown
		bool8 AltLineMatchText; //fieldtype: Unknown
		EConversationConditionCheck ConditionCheck; //enum
		SConversationCondition[] Conditions //struct
		{
			TConversationStateOpId FixedId; //fieldtype: String
			CConversationStateLink State; //fieldtype: CatalogLink
			TConversationStateIndexId Index; //fieldtype: String
			SConversationUserValue User //struct
			{
				CUserLink Type; //fieldtype: CatalogLink
				TUserFieldId Field; //fieldtype: String
				int32 Index; //fieldtype: IntSigned
				TUserInstanceId Instance; //fieldtype: String
			}
			EConversationConditionOp Operation; //enum
			int32 Value; //fieldtype: IntSigned
		}
		SConversationAction[] Actions //struct
		{
			TConversationStateOpId FixedId; //fieldtype: String
			CConversationStateLink State; //fieldtype: CatalogLink
			TConversationStateIndexId Index; //fieldtype: String
			SConversationUserValue User //struct
			{
				CUserLink Type; //fieldtype: CatalogLink
				TUserFieldId Field; //fieldtype: String
				int32 Index; //fieldtype: IntSigned
				TUserInstanceId Instance; //fieldtype: String
			}
			EConversationActionOp Operation; //enum
			int32 Value; //fieldtype: IntSigned
		}
		CString CutsceneFile; //fieldtype: String
		CGamePoint3D CutscenePosition; //fieldtype: Unknown
		TConversationTag[] Tags; //fieldtype: String
	}
	SConversationRunActions[] RunActions //struct
	{
		TConversationItemId Id; //fieldtype: String
		EConversationConditionCheck ConditionCheck; //enum
		SConversationCondition[] Conditions //struct
		{
			TConversationStateOpId FixedId; //fieldtype: String
			CConversationStateLink State; //fieldtype: CatalogLink
			TConversationStateIndexId Index; //fieldtype: String
			SConversationUserValue User //struct
			{
				CUserLink Type; //fieldtype: CatalogLink
				TUserFieldId Field; //fieldtype: String
				int32 Index; //fieldtype: IntSigned
				TUserInstanceId Instance; //fieldtype: String
			}
			EConversationConditionOp Operation; //enum
			int32 Value; //fieldtype: IntSigned
		}
		SConversationAction[] Actions //struct
		{
			TConversationStateOpId FixedId; //fieldtype: String
			CConversationStateLink State; //fieldtype: CatalogLink
			TConversationStateIndexId Index; //fieldtype: String
			SConversationUserValue User //struct
			{
				CUserLink Type; //fieldtype: CatalogLink
				TUserFieldId Field; //fieldtype: String
				int32 Index; //fieldtype: IntSigned
				TUserInstanceId Instance; //fieldtype: String
			}
			EConversationActionOp Operation; //enum
			int32 Value; //fieldtype: IntSigned
		}
	}
	SConversationWait[] Waits //struct
	{
		TConversationItemId Id; //fieldtype: String
		uint32 Duration; //fieldtype: IntUnsigned
		EConversationConditionCheck ConditionCheck; //enum
		SConversationCondition[] Conditions //struct
		{
			TConversationStateOpId FixedId; //fieldtype: String
			CConversationStateLink State; //fieldtype: CatalogLink
			TConversationStateIndexId Index; //fieldtype: String
			SConversationUserValue User //struct
			{
				CUserLink Type; //fieldtype: CatalogLink
				TUserFieldId Field; //fieldtype: String
				int32 Index; //fieldtype: IntSigned
				TUserInstanceId Instance; //fieldtype: String
			}
			EConversationConditionOp Operation; //enum
			int32 Value; //fieldtype: IntSigned
		}
	}
	SConversationJump[] Jumps //struct
	{
		TConversationItemId Id; //fieldtype: String
		TConversationItemId Location; //fieldtype: String
		EConversationConditionCheck ConditionCheck; //enum
		SConversationCondition[] Conditions //struct
		{
			TConversationStateOpId FixedId; //fieldtype: String
			CConversationStateLink State; //fieldtype: CatalogLink
			TConversationStateIndexId Index; //fieldtype: String
			SConversationUserValue User //struct
			{
				CUserLink Type; //fieldtype: CatalogLink
				TUserFieldId Field; //fieldtype: String
				int32 Index; //fieldtype: IntSigned
				TUserInstanceId Instance; //fieldtype: String
			}
			EConversationConditionOp Operation; //enum
			int32 Value; //fieldtype: IntSigned
		}
	}
	SConversationChoice[] Choices //struct
	{
		TConversationItemId Id; //fieldtype: String
		CStringLink Text; //fieldtype: String
		CString Comment; //fieldtype: String
		bool8 RequiresPrevious; //fieldtype: Unknown
		bool8 Permanent; //fieldtype: Unknown
		EConversationConditionCheck ConditionCheck; //enum
		SConversationCondition[] Conditions //struct
		{
			TConversationStateOpId FixedId; //fieldtype: String
			CConversationStateLink State; //fieldtype: CatalogLink
			TConversationStateIndexId Index; //fieldtype: String
			SConversationUserValue User //struct
			{
				CUserLink Type; //fieldtype: CatalogLink
				TUserFieldId Field; //fieldtype: String
				int32 Index; //fieldtype: IntSigned
				TUserInstanceId Instance; //fieldtype: String
			}
			EConversationConditionOp Operation; //enum
			int32 Value; //fieldtype: IntSigned
		}
		SConversationAction[] Actions //struct
		{
			TConversationStateOpId FixedId; //fieldtype: String
			CConversationStateLink State; //fieldtype: CatalogLink
			TConversationStateIndexId Index; //fieldtype: String
			SConversationUserValue User //struct
			{
				CUserLink Type; //fieldtype: CatalogLink
				TUserFieldId Field; //fieldtype: String
				int32 Index; //fieldtype: IntSigned
				TUserInstanceId Instance; //fieldtype: String
			}
			EConversationActionOp Operation; //enum
			int32 Value; //fieldtype: IntSigned
		}
		TConversationItemId[] Children; //fieldtype: String
	}
	SConversationGroup[] Groups //struct
	{
		TConversationItemId Id; //fieldtype: String
		CStringLink Name; //fieldtype: String
		CString Comment; //fieldtype: String
		EConversationSelectionMethod ChoiceSelection; //enum
		uint32 MaxChoices; //fieldtype: IntUnsigned
		EConversationSelectionMethod LineSelection; //enum
		uint32 MaxLines; //fieldtype: IntUnsigned
		bool8 PlayOnceOnly; //fieldtype: Unknown
		bool8 NoWait; //fieldtype: Unknown
		TConversationStateIndexId ChoiceCamera; //fieldtype: String
		EConversationConditionCheck ConditionCheck; //enum
		SConversationCondition[] Conditions //struct
		{
			TConversationStateOpId FixedId; //fieldtype: String
			CConversationStateLink State; //fieldtype: CatalogLink
			TConversationStateIndexId Index; //fieldtype: String
			SConversationUserValue User //struct
			{
				CUserLink Type; //fieldtype: CatalogLink
				TUserFieldId Field; //fieldtype: String
				int32 Index; //fieldtype: IntSigned
				TUserInstanceId Instance; //fieldtype: String
			}
			EConversationConditionOp Operation; //enum
			int32 Value; //fieldtype: IntSigned
		}
		TConversationItemId[] Children; //fieldtype: String
		CString CutsceneFile; //fieldtype: String
		CGamePoint3D CutscenePosition; //fieldtype: Unknown
		bool8 ApplyCutsceneToChildren; //fieldtype: Unknown
		TConversationTag[] Tags; //fieldtype: String
	}
	SConversationComment[] Comments //struct
	{
		TConversationItemId Id; //fieldtype: String
		CStringLink Text; //fieldtype: String
	}
	TConversationItemId[] RootItems; //fieldtype: String
}

class CConversationState
{
	CFlagArray<e_conversationStateFlagCount>[] Flags; //fieldtype: Flags
	SConversationStateIndex[] Indices //struct
	{
		TConversationStateIndexId Id; //fieldtype: String
		CStringLink Name; //fieldtype: String
		CStringLink EditorPrefix; //fieldtype: String
		CStringLink EditorSuffix; //fieldtype: String
		CColor Color; //fieldtype: Unknown
		CImagePath ImagePath; //fieldtype: String
		ETextTagEdge ImageEdge; //enum
		EAttachmentID ImageAttach; //enum
		CMoviePath MoviePath; //fieldtype: String
		SConversationStateInfoText[] InfoText //struct
		{
			TConversationStateInfoId Id; //fieldtype: String
			CStringLink Text; //fieldtype: String
		}
		SConversationStateInfoValue[] InfoValue //struct
		{
			TConversationStateInfoId Id; //fieldtype: String
			CFixed Value; //fieldtype: Fixed
		}
		SConversationStateInfoModel[] InfoModel //struct
		{
			TConversationStateInfoId Id; //fieldtype: String
			CModelLink Model; //fieldtype: CatalogLink
		}
		SConversationStateInfoUpgrade[] InfoUpgrade //struct
		{
			TConversationStateInfoId Id; //fieldtype: String
			CUpgradeLink Upgrade; //fieldtype: CatalogLink
		}
		SConversationStateInfoAbilCmd[] InfoAbilCmd //struct
		{
			TConversationStateInfoId Id; //fieldtype: String
			CAbilLink Abil; //fieldtype: CatalogLink
			TAbilCmdIndex Cmd; //fieldtype: IntUnsigned
		}
		SConversationStateVariation[] Variations //struct
		{
			TConversationStateVariation Value; //fieldtype: String
			CString80[] DefaultCategories; //fieldtype: String
		}
	}
	CiRange ValueRange; //fieldtype: Unknown
	CColor[] CustomColors; //fieldtype: Unknown
	SConversationStateInfoIds[] InfoIds //struct
	{
		TConversationStateInfoId[] Id; //fieldtype: String
	}
}
