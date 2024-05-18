
class CWater
{
	CImagePath TextureKey; //fieldtype: String
	C4Vector TilingFreq; //fieldtype: Unknown
	C4Vector ScrollVectors; //fieldtype: Unknown
	real32 FramesPerSec; //fieldtype: Float
	SWaterStateDesc[] State //struct
	{
		CString32 Name; //fieldtype: String
		real32 Height; //fieldtype: Float
		C4Vector Color; //fieldtype: Unknown
		real32 ColorFallOff; //fieldtype: Float
		real32 CausticsFallOff; //fieldtype: Float
		real32 Specularity; //fieldtype: Float
		real32 SpecularScaler; //fieldtype: Float
		C4Vector UvRate; //fieldtype: Unknown
		real32 UvRotate; //fieldtype: Float
		real32 MeshRoughness; //fieldtype: Float
		real32 TextureRoughness; //fieldtype: Float
		real32 ReflectionDistortion; //fieldtype: Float
		real32 RefractionDistortion; //fieldtype: Float
		real32 ShadowDistortion; //fieldtype: Float
		real32 MinReflection; //fieldtype: Float
		real32 ReflectivityPower; //fieldtype: Float
	}
	real32 CausticsFPS; //fieldtype: Float
	C2Vector CausticsTilingFreq; //fieldtype: Unknown
	bool32 ReceiveShadows; //fieldtype: Unknown
	bool32 IsLava; //fieldtype: Unknown
	real32 Density; //fieldtype: Float
	real32 Drag; //fieldtype: Float
	real32 AngularDamping; //fieldtype: Float
	real32 MaxLinearVelocity; //fieldtype: Float
	CModelLink BeachShoreline; //fieldtype: CatalogLink
	CModelLink CliffShoreline; //fieldtype: CatalogLink
	CModelLink LavaModel; //fieldtype: CatalogLink
	SWaterDoodad[] Doodads //struct
	{
		CModelLink Model; //fieldtype: CatalogLink
		real32 Density; //fieldtype: Float
		real32 MinSize; //fieldtype: Float
		real32 MaxSize; //fieldtype: Float
		uint32 Lifetime; //fieldtype: IntUnsigned
	}
	CSoundLink Sound; //fieldtype: CatalogLink
	CTexturePath ReflectionCubeMap; //fieldtype: String
}
