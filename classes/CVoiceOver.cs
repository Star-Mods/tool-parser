
class CVoiceOver
{
	CCharacterLink Character; //fieldtype: CatalogLink
	SVoiceOverSkin[] Skins //struct
	{
		TVoiceOverSkinId Id; //fieldtype: String
		EVoiceOverSkinState State; //enum
	}
	SVoiceOverGroup[] Groups //struct
	{
		TVoiceOverGroupId Id; //fieldtype: String
		CSoundLink SoundParent; //fieldtype: CatalogLink
	}
	SVoiceOverLine[] Lines //struct
	{
		TVoiceOverGroupId Group; //fieldtype: String
		int32 SoundIndex; //fieldtype: IntSigned
		EVoiceOverSoundType SoundType; //enum
		CString SoundText; //fieldtype: String
		CString Comment; //fieldtype: String
		CString FacialAnim; //fieldtype: String
		uint32 FacialBlend; //fieldtype: IntUnsigned
		bool8 FacialAsVoiceDir; //fieldtype: Unknown
		SVoiceOverSkin[] Skins //struct
		{
			TVoiceOverSkinId Id; //fieldtype: String
			EVoiceOverSkinState State; //enum
		}
	}
}

class CVoicePack
{
	bool8 Default; //fieldtype: Unknown
	CStringLink Name; //fieldtype: String
	CStringLink ShortName; //fieldtype: String
	CStringLink StoreName; //fieldtype: String
	CStringLink TypeName; //fieldtype: String
	CStringLink Description; //fieldtype: String
	CImagePath Icon; //fieldtype: String
	TBattleProductId ProductId; //fieldtype: IntSigned
	CRewardLink[] UnlockedRewardArray; //fieldtype: CatalogLink
	SVoicePackExampleLine[] ExampleLineArray //struct
	{
		CStringLink Description; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	SProductReleaseDate ReleaseDate; //fieldtype: Unknown
	CBundleLink ParentBundle; //fieldtype: CatalogLink
	CFourCC LocaleRestriction; //fieldtype: FourCC
	bool8 IsPurchaseHidden; //fieldtype: Unknown
	CImagePath ImageTexture; //fieldtype: String
	CStringLink StoreTypeName; //fieldtype: String
}
