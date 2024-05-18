
class CUser
{
	SUserField[] Fields //struct
	{
		TUserFieldId Id; //fieldtype: String
		EUserType Type; //enum
		EGameCatalog GameLinkType; //enum
		CUserLink UserType; //fieldtype: CatalogLink
		uint32 Count; //fieldtype: IntUnsigned
		CFlagArray<e_userFieldFlagCount>[] Flags; //fieldtype: Flags
		uint32 EditorColumn; //fieldtype: IntUnsigned
		EEditorTextType EditorText; //enum
	}
	SUserInstance[] Instances //struct
	{
		TUserInstanceId Id; //fieldtype: String
		SUserInstanceAbilCmd[] AbilCmd //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			CAbilLink Abil; //fieldtype: CatalogLink
			TAbilCmdIndex Cmd; //fieldtype: IntUnsigned
		}
		SUserInstanceActor[] Actor //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			CActorLink Actor; //fieldtype: CatalogLink
		}
		SUserInstanceColor[] Color //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			CColor Color; //fieldtype: Unknown
		}
		SUserInstanceCompare[] Compare //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			EValueCompare Compare; //enum
		}
		SUserInstanceFixed[] Fixed //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			CFixed Fixed; //fieldtype: Fixed
		}
		SUserInstanceGameLink[] GameLink //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			CString GameLink; //fieldtype: String
		}
		SUserInstanceImage[] Image //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			CImagePath Image; //fieldtype: String
			ETextTagEdge Edge; //enum
			EAttachmentID Attach; //enum
		}
		SUserInstanceInt[] Int //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			int32 Int; //fieldtype: IntSigned
		}
		SUserInstanceModel[] Model //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			CModelLink Model; //fieldtype: CatalogLink
		}
		SUserInstanceMovie[] Movie //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			CMoviePath Movie; //fieldtype: String
		}
		SUserInstanceSound[] Sound //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			CSoundLink Sound; //fieldtype: CatalogLink
		}
		SUserInstanceString[] String //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			CString String; //fieldtype: String
		}
		SUserInstanceText[] Text //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			CStringLink Text; //fieldtype: String
		}
		SUserInstanceUnit[] Unit //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			CUnitLink Unit; //fieldtype: CatalogLink
		}
		SUserInstanceUpgrade[] Upgrade //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			CUpgradeLink Upgrade; //fieldtype: CatalogLink
		}
		SUserInstanceUser[] User //struct
		{
			SUserInstanceField Field //struct
			{
				TUserFieldId Id; //fieldtype: String
				uint32 Index; //fieldtype: IntUnsigned
			}
			CUserLink Type; //fieldtype: CatalogLink
			TUserInstanceId Instance; //fieldtype: String
		}
	}
}
