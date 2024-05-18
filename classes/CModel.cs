
class CModel
{
	CModelPath Model; //fieldtype: String
	CModelLink LowQualityModel; //fieldtype: CatalogLink
	CAnimsPath[] RequiredAnims; //fieldtype: String
	CAnimsPath[] OptionalAnims; //fieldtype: String
	SAnimFile[] RequiredAnimsEx //struct
	{
		CAnimsPath FilePath; //fieldtype: String
		CFlags[] Flags; //fieldtype: Flags
	}
	SAnimAlias[] AnimAliases //struct
	{
		CAnimProps Anim; //fieldtype: Unknown
		CAnimProps Alias; //fieldtype: Unknown
	}
	real32 AnimBlendTime; //fieldtype: Float
	real32 AnimSpeed; //fieldtype: Float
	SAttachProps[] AttachProps //struct
	{
		EAttachmentID Id; //enum
		TAttachPropIndex[] Keys; //fieldtype: IntSigned
		ESquibType SquibType; //enum
		real32 WeightExplicit; //fieldtype: Float
		real32 WeightFactor; //fieldtype: Float
		real32 RadiusTarget; //fieldtype: Float
		real32 RadiusShield; //fieldtype: Float
	}
	TEditorCategories EditorCategories; //fieldtype: String
	SModelDataEvent[] Events //struct
	{
		int32 Variation; //fieldtype: IntSigned
		CAnimProps Anim; //fieldtype: Unknown
		CIdentifier Name; //fieldtype: String
		EModelEvent Type; //enum
		real32 Time; //fieldtype: Float
		EAttachmentID Attachment; //enum
		CIdentifier Payload; //fieldtype: String
		EModelQuality ModelQuality; //enum
	}
	CFacialPath FacialController; //fieldtype: String
	CFlags[] Flags; //fieldtype: Flags
	real32 FuzzyGeometryPadding; //fieldtype: Float
	CImagePath Image; //fieldtype: String
	CLightLink Lighting; //fieldtype: CatalogLink
	EOcclusion Occlusion; //enum
	real32 OccludingOpacity; //fieldtype: Float
	EPausedParticleSystemBehavior PausedParticleSystemBehavior; //enum
	SPhysicsMaterialMapping[] PhysicsMaterialMappings //struct
	{
		EPhysicsMaterial PhysicsMaterialInnate; //enum
		CPhysicsMaterialLink PhysicsMaterialOverride; //fieldtype: CatalogLink
	}
	CPhysicsMaterialLink PhysicsMaterialOverride; //fieldtype: CatalogLink
	real32 PhysicsGravityFactor; //fieldtype: Float
	real32 PhysicsForceFactor; //fieldtype: Float
	CVariatorActorReal32 PhysicsDeathMotionFactor; //fieldtype: Unknown
	CString PlanetPanelCamera; //fieldtype: String
	uint8 Priority; //fieldtype: IntUnsigned
	real32 Radius; //fieldtype: Float
	real32 RadiusLoose; //fieldtype: Float
	uint32 Quality; //fieldtype: IntUnsigned
	C3Vector PortraitOffset; //fieldtype: Unknown
	C3Vector ScaleMax; //fieldtype: Unknown
	C3Vector ScaleMin; //fieldtype: Unknown
	uint32 SelectionLayer; //fieldtype: IntUnsigned
	C3Vector SelectionOffset; //fieldtype: Unknown
	real32 SelectionRadius; //fieldtype: Float
	real32 ShadowRadius; //fieldtype: Float
	ESquibType SquibTypeDefault; //enum
	CString TechPurchaseCamera; //fieldtype: String
	real32 TechPurchaseSpeed; //fieldtype: Float
	real32 Tipability; //fieldtype: Float
	real32 TipabilityLength; //fieldtype: Float
	real32 TipabilityWidth; //fieldtype: Float
	CActorAngle TipabilityBlendRate; //fieldtype: Unknown
	CActorAngle TipabilityPitchMax; //fieldtype: Unknown
	CActorAngle TipabilityRollMax; //fieldtype: Unknown
	C3Vector BoundingBoxPadding; //fieldtype: Unknown
	CTextureProps TextureAppliedGroups; //fieldtype: Unknown
	STextureDeclare[] TextureDeclares //struct
	{
		CIdentifier Prefix; //fieldtype: String
		CTextureSlot Slot; //fieldtype: Unknown
		STextureNameAdaption[] Adaptions //struct
		{
			CIdentifier TriggerOnSubstring; //fieldtype: String
			CTextureSlot Slot; //fieldtype: Unknown
			CTextureProps PropsAdd; //fieldtype: Unknown
			CTextureProps PropsRemove; //fieldtype: Unknown
			CTextureProps PropsSet; //fieldtype: Unknown
			bool8 AppliesToInnate; //fieldtype: Unknown
			bool8 AppliesToFile; //fieldtype: Unknown
		}
	}
	STextureInfo[] TextureInfos //struct
	{
		CTextureSlot Slot; //fieldtype: Unknown
		CTextureExpression Expression; //fieldtype: Unknown
		uint32 Probability; //fieldtype: IntUnsigned
	}
	STextureExpressionSpec[] TextureExpressionsForEditor //struct
	{
		CTextureSlot Slot; //fieldtype: Unknown
		CTextureExpression Expression; //fieldtype: Unknown
	}
	STextureMatchSpec[] TextureMatchesForEditor //struct
	{
		CTextureSlot Slot; //fieldtype: Unknown
		CTextureSlot Source; //fieldtype: Unknown
	}
	CString UnitGlossaryCamera; //fieldtype: String
	uint8 UnitGlossaryVariation; //fieldtype: IntUnsigned
	uint32 UnitGlossaryTeamColorIndex; //fieldtype: IntUnsigned
	uint32 VariationCount; //fieldtype: IntUnsigned
	SModelVariation[] Variations //struct
	{
		int32 Number; //fieldtype: IntSigned
		uint32 Probability; //fieldtype: IntUnsigned
		real32 Radius; //fieldtype: Float
		real32 RadiusLoose; //fieldtype: Float
		real32 PhysicsForceFactor; //fieldtype: Float
		CVariatorActorReal32 PhysicsDeathMotionFactor; //fieldtype: Unknown
		CTextureProps TextureAppliedGroups; //fieldtype: Unknown
		STextureExpressionSpec[] TextureExpressionsForEditor //struct
		{
			CTextureSlot Slot; //fieldtype: Unknown
			CTextureExpression Expression; //fieldtype: Unknown
		}
		STextureMatchSpec[] TextureMatchesForEditor //struct
		{
			CTextureSlot Slot; //fieldtype: Unknown
			CTextureSlot Source; //fieldtype: Unknown
		}
	}
	CGameRate WalkAnimMoveSpeed; //fieldtype: Fixed
	CGameRate RunAnimMoveSpeed; //fieldtype: Fixed
	CGameRate RunAnimMoveSpeedThreshold; //fieldtype: Fixed
}

class CModelFoliage
{
	CModelPath Model; //fieldtype: String
	CModelLink LowQualityModel; //fieldtype: CatalogLink
	CAnimsPath[] RequiredAnims; //fieldtype: String
	CAnimsPath[] OptionalAnims; //fieldtype: String
	SAnimFile[] RequiredAnimsEx //struct
	{
		CAnimsPath FilePath; //fieldtype: String
		CFlags[] Flags; //fieldtype: Flags
	}
	SAnimAlias[] AnimAliases //struct
	{
		CAnimProps Anim; //fieldtype: Unknown
		CAnimProps Alias; //fieldtype: Unknown
	}
	real32 AnimBlendTime; //fieldtype: Float
	real32 AnimSpeed; //fieldtype: Float
	SAttachProps[] AttachProps //struct
	{
		EAttachmentID Id; //enum
		TAttachPropIndex[] Keys; //fieldtype: IntSigned
		ESquibType SquibType; //enum
		real32 WeightExplicit; //fieldtype: Float
		real32 WeightFactor; //fieldtype: Float
		real32 RadiusTarget; //fieldtype: Float
		real32 RadiusShield; //fieldtype: Float
	}
	TEditorCategories EditorCategories; //fieldtype: String
	SModelDataEvent[] Events //struct
	{
		int32 Variation; //fieldtype: IntSigned
		CAnimProps Anim; //fieldtype: Unknown
		CIdentifier Name; //fieldtype: String
		EModelEvent Type; //enum
		real32 Time; //fieldtype: Float
		EAttachmentID Attachment; //enum
		CIdentifier Payload; //fieldtype: String
		EModelQuality ModelQuality; //enum
	}
	CFacialPath FacialController; //fieldtype: String
	CFlags[] Flags; //fieldtype: Flags
	real32 FuzzyGeometryPadding; //fieldtype: Float
	CImagePath Image; //fieldtype: String
	CLightLink Lighting; //fieldtype: CatalogLink
	EOcclusion Occlusion; //enum
	real32 OccludingOpacity; //fieldtype: Float
	EPausedParticleSystemBehavior PausedParticleSystemBehavior; //enum
	SPhysicsMaterialMapping[] PhysicsMaterialMappings //struct
	{
		EPhysicsMaterial PhysicsMaterialInnate; //enum
		CPhysicsMaterialLink PhysicsMaterialOverride; //fieldtype: CatalogLink
	}
	CPhysicsMaterialLink PhysicsMaterialOverride; //fieldtype: CatalogLink
	real32 PhysicsGravityFactor; //fieldtype: Float
	real32 PhysicsForceFactor; //fieldtype: Float
	CVariatorActorReal32 PhysicsDeathMotionFactor; //fieldtype: Unknown
	CString PlanetPanelCamera; //fieldtype: String
	uint8 Priority; //fieldtype: IntUnsigned
	real32 Radius; //fieldtype: Float
	real32 RadiusLoose; //fieldtype: Float
	uint32 Quality; //fieldtype: IntUnsigned
	C3Vector PortraitOffset; //fieldtype: Unknown
	C3Vector ScaleMax; //fieldtype: Unknown
	C3Vector ScaleMin; //fieldtype: Unknown
	uint32 SelectionLayer; //fieldtype: IntUnsigned
	C3Vector SelectionOffset; //fieldtype: Unknown
	real32 SelectionRadius; //fieldtype: Float
	real32 ShadowRadius; //fieldtype: Float
	ESquibType SquibTypeDefault; //enum
	CString TechPurchaseCamera; //fieldtype: String
	real32 TechPurchaseSpeed; //fieldtype: Float
	real32 Tipability; //fieldtype: Float
	real32 TipabilityLength; //fieldtype: Float
	real32 TipabilityWidth; //fieldtype: Float
	CActorAngle TipabilityBlendRate; //fieldtype: Unknown
	CActorAngle TipabilityPitchMax; //fieldtype: Unknown
	CActorAngle TipabilityRollMax; //fieldtype: Unknown
	C3Vector BoundingBoxPadding; //fieldtype: Unknown
	CTextureProps TextureAppliedGroups; //fieldtype: Unknown
	STextureDeclare[] TextureDeclares //struct
	{
		CIdentifier Prefix; //fieldtype: String
		CTextureSlot Slot; //fieldtype: Unknown
		STextureNameAdaption[] Adaptions //struct
		{
			CIdentifier TriggerOnSubstring; //fieldtype: String
			CTextureSlot Slot; //fieldtype: Unknown
			CTextureProps PropsAdd; //fieldtype: Unknown
			CTextureProps PropsRemove; //fieldtype: Unknown
			CTextureProps PropsSet; //fieldtype: Unknown
			bool8 AppliesToInnate; //fieldtype: Unknown
			bool8 AppliesToFile; //fieldtype: Unknown
		}
	}
	STextureInfo[] TextureInfos //struct
	{
		CTextureSlot Slot; //fieldtype: Unknown
		CTextureExpression Expression; //fieldtype: Unknown
		uint32 Probability; //fieldtype: IntUnsigned
	}
	STextureExpressionSpec[] TextureExpressionsForEditor //struct
	{
		CTextureSlot Slot; //fieldtype: Unknown
		CTextureExpression Expression; //fieldtype: Unknown
	}
	STextureMatchSpec[] TextureMatchesForEditor //struct
	{
		CTextureSlot Slot; //fieldtype: Unknown
		CTextureSlot Source; //fieldtype: Unknown
	}
	CString UnitGlossaryCamera; //fieldtype: String
	uint8 UnitGlossaryVariation; //fieldtype: IntUnsigned
	uint32 UnitGlossaryTeamColorIndex; //fieldtype: IntUnsigned
	uint32 VariationCount; //fieldtype: IntUnsigned
	SModelVariation[] Variations //struct
	{
		int32 Number; //fieldtype: IntSigned
		uint32 Probability; //fieldtype: IntUnsigned
		real32 Radius; //fieldtype: Float
		real32 RadiusLoose; //fieldtype: Float
		real32 PhysicsForceFactor; //fieldtype: Float
		CVariatorActorReal32 PhysicsDeathMotionFactor; //fieldtype: Unknown
		CTextureProps TextureAppliedGroups; //fieldtype: Unknown
		STextureExpressionSpec[] TextureExpressionsForEditor //struct
		{
			CTextureSlot Slot; //fieldtype: Unknown
			CTextureExpression Expression; //fieldtype: Unknown
		}
		STextureMatchSpec[] TextureMatchesForEditor //struct
		{
			CTextureSlot Slot; //fieldtype: Unknown
			CTextureSlot Source; //fieldtype: Unknown
		}
	}
	CGameRate WalkAnimMoveSpeed; //fieldtype: Fixed
	CGameRate RunAnimMoveSpeed; //fieldtype: Fixed
	CGameRate RunAnimMoveSpeedThreshold; //fieldtype: Fixed
	EFoliageLayer Layer; //enum
	real32 SpringDampening; //fieldtype: Float
	real32 SpringStrength; //fieldtype: Float
	real32 DragCoefficient; //fieldtype: Float
	real32 WindInfluence; //fieldtype: Float
	bool32 ForceNormalsUp; //fieldtype: Unknown
	real32 RandomDeviation; //fieldtype: Float
	real32 Flexibility; //fieldtype: Float
}
