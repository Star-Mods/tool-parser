
class CLight
{
	CTimeOfDay TimePerDay; //fieldtype: Unknown
	CTimeOfDay TimePerLoop; //fieldtype: Unknown
	CTimeOfDay TimeStart; //fieldtype: Unknown
	STimeEvent[] TimeEventArray //struct
	{
		CTimeOfDay Time; //fieldtype: Unknown
		CStringLink Name; //fieldtype: String
	}
	SLightInfo[] ToDInfoArray //struct
	{
		CIdentifier Id; //fieldtype: String
		CTimeOfDay TimeOfDay; //fieldtype: Unknown
		C3Vector AmbientColor; //fieldtype: Unknown
		real32 AmbientEnvironmentMultiplier; //fieldtype: Float
		int8 OperatorHDR; //fieldtype: IntSigned
		bool8 TerrainUseBackLight; //fieldtype: Unknown
		bool8 DirectionalLightShadows; //fieldtype: Unknown
		bool8 CorrectGamma; //fieldtype: Unknown
		real32[] Param; //fieldtype: Float
		SDirectionalLight[] DirectionalLight //struct
		{
			bool32 UseAmbientOcclusion; //fieldtype: Unknown
			C3Vector Color; //fieldtype: Unknown
			real32 ColorMultiplier; //fieldtype: Float
			C3Vector SpecularColor; //fieldtype: Unknown
			real32 SpecColorMultiplier; //fieldtype: Float
			C3Vector Direction; //fieldtype: Unknown
		}
		uint32 TriggerTransition; //fieldtype: IntUnsigned
		bool32 Colorize; //fieldtype: Unknown
		bool32 UseSeparateDetailSSAO; //fieldtype: Unknown
		SVariationConfig[] Variations //struct
		{
			EVariationCommands Command; //enum
			uint32 Sensitivity; //fieldtype: IntUnsigned
			ETonemapRegionTypes Region; //enum
		}
		SLightRegionInfo[] LightRegions //struct
		{
			bool32 UseDefault; //fieldtype: Unknown
			C3Vector AmbientColor; //fieldtype: Unknown
			real32 AmbientEnvironmentMultiplier; //fieldtype: Float
			C3Vector[] DiffuseColor; //fieldtype: Unknown
			real32[] DiffuseMultiplier; //fieldtype: Float
			C3Vector SpecularColor; //fieldtype: Unknown
			real32 SpecularMultiplier; //fieldtype: Float
			C3Vector FogColor; //fieldtype: Unknown
		}
	}
	TEditorCategories EditorCategories; //fieldtype: String
	CTexturePath AmbientEnvironmentMap; //fieldtype: String
	CTexturePath LightingRegionMap; //fieldtype: String
}
