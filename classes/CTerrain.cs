
class CTerrain
{
	CStringLink Name; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	bool32 EditorHidden; //fieldtype: Unknown
	CLightLink Lighting; //fieldtype: CatalogLink
	CImagePath LoadingScreen; //fieldtype: String
	CTextureProps TextureProp; //fieldtype: Unknown
	CCameraLink Camera; //fieldtype: CatalogLink
	CSoundtrackLink Ambience; //fieldtype: CatalogLink
	SDSPArray[] DSPArray //struct
	{
		CDSPLink[] LinkArray; //fieldtype: CatalogLink
	}
	CDSPLink[] DSPArrayMasterOutput; //fieldtype: CatalogLink
	CReverbLink ReverbGlobal; //fieldtype: CatalogLink
	CReverbLink ReverbAmbient; //fieldtype: CatalogLink
	real32 SoundDistanceFactor; //fieldtype: Float
	real32 SoundDopplerFactor; //fieldtype: Float
	real32 SoundRolloffFactor; //fieldtype: Float
	real32 TilingFreq; //fieldtype: Float
	real32 POMScale; //fieldtype: Float
	bool32 HideLowestLevel; //fieldtype: Unknown
	CColor MinimapBackgroundColor; //fieldtype: Unknown
	real32 MinimapBrightenFactor; //fieldtype: Float
	CTerrainTexLink[] BlendTextures; //fieldtype: CatalogLink
	CTileLink[] HardTiles; //fieldtype: CatalogLink
	CCliffLink[] CliffSets; //fieldtype: CatalogLink
	CActorCreateKey FixedSkyboxActor; //fieldtype: String
	CModelLink FixedSkyboxModel; //fieldtype: CatalogLink
	CActorCreateKey NonFixedSkyboxActor; //fieldtype: String
	CModelLink NonFixedSkyboxModel; //fieldtype: CatalogLink
	CImagePath EnvironmentMap; //fieldtype: String
	CColor FOWColor; //fieldtype: Unknown
	bool8 FOWPlaneEnabled; //fieldtype: Unknown
	bool8 FogEnabled; //fieldtype: Unknown
	CColor FogColor; //fieldtype: Unknown
	real32 FogDensity; //fieldtype: Float
	real32 FogFalloff; //fieldtype: Float
	real32 FogStartingHeight; //fieldtype: Float
	real32 FogNearPlane; //fieldtype: Float
	real32 FogFarPlane; //fieldtype: Float
	real32 FogDistanceFalloff; //fieldtype: Float
	real32 Gravity; //fieldtype: Float
	real32 PhysicsTimeScale; //fieldtype: Float
	real32 WindAngleHorizontal; //fieldtype: Float
	real32 WindAngleVertical; //fieldtype: Float
	real32 WindSpeed; //fieldtype: Float
	real32 WindTurbulencePower; //fieldtype: Float
	real32 WindTurbulenceSpeed; //fieldtype: Float
	CImagePath CreepBaseTexture; //fieldtype: String
	CImagePath CreepBaseSpecularMap; //fieldtype: String
	CImagePath CreepEdgeNormalMap; //fieldtype: String
	CImagePath CreepHeightMap; //fieldtype: String
	CImagePath CreepNoiseMap; //fieldtype: String
	SCreepSettings[] CreepSettingsArray //struct
	{
		real32 CreepOpaqueAlphaThreshold; //fieldtype: Float
		real32 CreepTranslucentMinThreshold; //fieldtype: Float
		real32 CreepTranslucentMaxThreshold; //fieldtype: Float
		real32 CreepNoiseSpeed; //fieldtype: Float
		real32 CreepNoiseTiling; //fieldtype: Float
		real32 CreepHeightMapStrength; //fieldtype: Float
		real32 CreepNoiseStrength; //fieldtype: Float
		C2Vector CreepBaseTextureTileValue; //fieldtype: Unknown
		C2Vector CreepBaseNormalMapTileValue; //fieldtype: Unknown
		C2Vector CreepEdgeNormalMapTileValue; //fieldtype: Unknown
		real32 CreepEdgeNormalMapMinRampThreshold; //fieldtype: Float
		C3Vector CreepTranslucentPassTint; //fieldtype: Unknown
		C3Vector CreepTranslucentPassEmissiveFactor; //fieldtype: Unknown
		C3Vector CreepDiffuseColorTint; //fieldtype: Unknown
		real32 CreepTextureRotation; //fieldtype: Float
		real32 CreepGroundNormalBlend; //fieldtype: Float
	}
	SFoliageSimulationConfig[] FoliageSettingsArray //struct
	{
		real32[] SamplingDistance; //fieldtype: Float
		bool32[] AcceptWorldForces; //fieldtype: Unknown
	}
	CFlags[] HeightFlags; //fieldtype: Flags
	bool8 HeightMapEnabled; //fieldtype: Unknown
	uint8 MinimumVisionCliffLevel; //fieldtype: IntUnsigned
	bool8 RampNoBuild; //fieldtype: Unknown
}

class CTerrainObject
{
	CModelPath Model; //fieldtype: String
	CFlagArray<e_editorFlagCount>[] EditorFlags; //fieldtype: Flags
	CModelLink EditorModel; //fieldtype: CatalogLink
	CImagePath EditorIcon; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	CFixed EditorCursorOffset; //fieldtype: Fixed
	CTerrainLink[] TexSets; //fieldtype: CatalogLink
	CFootprintLink Footprint; //fieldtype: CatalogLink
	CFixed Radius; //fieldtype: Fixed
	CFixed OccludeHeight; //fieldtype: Fixed
	TCliffLevel BoostedCliffLevel; //fieldtype: IntUnsigned
}

class CCliffDoodad
{
	CModelPath Model; //fieldtype: String
	CFlagArray<e_editorFlagCount>[] EditorFlags; //fieldtype: Flags
	CModelLink EditorModel; //fieldtype: CatalogLink
	CImagePath EditorIcon; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	CFixed EditorCursorOffset; //fieldtype: Fixed
	CTerrainLink[] TexSets; //fieldtype: CatalogLink
	CFootprintLink Footprint; //fieldtype: CatalogLink
	CFixed Radius; //fieldtype: Fixed
	CFixed OccludeHeight; //fieldtype: Fixed
	TCliffLevel BoostedCliffLevel; //fieldtype: IntUnsigned
	CCliffLink CliffSet; //fieldtype: CatalogLink
	uint32 NumCellsDown; //fieldtype: IntUnsigned
	uint32 NumCellsAcross; //fieldtype: IntUnsigned
	CString[] HeightCodes; //fieldtype: String
}

class CTerrainTex
{
	CImagePath Texture; //fieldtype: String
	CImagePath Normalmap; //fieldtype: String
	CImagePath Heightmap; //fieldtype: String
	real32 HeightMapOffset; //fieldtype: Float
	real32 HeightMapScale; //fieldtype: Float
	CImagePath EditorIcon; //fieldtype: String
	C2fVector AnimRate; //fieldtype: Unknown
	STerrainDoodad[] DoodadEntry //struct
	{
		CModelLink Model; //fieldtype: CatalogLink
		bool32 RandomRotation; //fieldtype: Unknown
		real32 Probability; //fieldtype: Float
		real32 PlacementRadius; //fieldtype: Float
	}
	CPhysicsMaterialLink PhysicsMaterial; //fieldtype: CatalogLink
}

class CTexture
{
	CTexturePath File; //fieldtype: String
	CIdentifier Prefix; //fieldtype: String
	CTextureSlot Slot; //fieldtype: Unknown
	CTextureProps PropsAdd; //fieldtype: Unknown
	CTextureProps PropsRemove; //fieldtype: Unknown
	CTextureProps PropsSet; //fieldtype: Unknown
	CSoundLink MovieSoundSettings; //fieldtype: CatalogLink
	CSoundLink MovieSoundSettings5dot1; //fieldtype: CatalogLink
	CSoundLink MovieSoundSettingsStereo; //fieldtype: CatalogLink
	CFlags[] Flags; //fieldtype: Flags
}

class CTextureSheet
{
	CImagePath Image; //fieldtype: String
	uint32 Rows; //fieldtype: IntUnsigned
	uint32 Columns; //fieldtype: IntUnsigned
}

class CTile
{
	CImagePath Material; //fieldtype: String
	CImagePath EditorIcon; //fieldtype: String
	CFlags[] Flags; //fieldtype: Flags
	real32 TesselationDistance; //fieldtype: Float
	real32 TileWidthDistance; //fieldtype: Float
	uint32 TileHeightRepetitions; //fieldtype: IntUnsigned
	real32 CapLength; //fieldtype: Float
	real32 DefaultSplineWidth; //fieldtype: Float
	real32 DefaultWingWidth; //fieldtype: Float
}
