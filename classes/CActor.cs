
class CActor
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
}

class CActorBase
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
}

class CActorBearings
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
}

class CActorCamera
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CCameraLink Camera; //fieldtype: CatalogLink
	SActorRequest HostEye //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostEyeSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
}

class CActorModel
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
}

class CActorModelMaterial
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	EActorModelMaterialType MaterialType; //enum
	CFlags[] ModelMaterialFlags; //fieldtype: Flags
}

class CActorQuad
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CActorCreateKey LaunchActor; //fieldtype: String
	real32 LaunchHeight; //fieldtype: Float
	CActorCreateKey CenterActor; //fieldtype: String
	real32 CenterHeight; //fieldtype: Float
	CActorCreateKey ImpactActor; //fieldtype: String
	real32 ImpactHeight; //fieldtype: Float
	CQuad Quad; //fieldtype: Unknown
	real32 Height; //fieldtype: Float
	real32 Width; //fieldtype: Float
	CRange HeightRange; //fieldtype: Unknown
	CFlags[] QuadFlags; //fieldtype: Flags
	SActorQuadDecoration Decoration //struct
	{
		CActorCreateKey Actor; //fieldtype: String
		real32 SpawnInterval; //fieldtype: Float
		real32 TravelSpeed; //fieldtype: Float
		EActorQuadDecorationFunction TravelFunction; //enum
		real32 TravelFunctionParam; //fieldtype: Float
		CFlags[] Flags; //fieldtype: Flags
	}
	real32 OriginHeightLookaheadDistance; //fieldtype: Float
	real32 OriginHeightLookaheadIncrement; //fieldtype: Float
	SActorRequest HostImpact //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostImpactSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
}

class CActorForce
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	SActorRequest Receiver //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	EActorForceField Field; //fieldtype: Unknown
	CVariatorActorReal32 Duration; //fieldtype: Unknown
	CVariatorActorReal32 Magnitude; //fieldtype: Unknown
	CFlags[] ForceFlags; //fieldtype: Flags
}

class CActorForceLineSegment
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	SActorRequest Receiver //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	EActorForceField Field; //fieldtype: Unknown
	CVariatorActorReal32 Duration; //fieldtype: Unknown
	CVariatorActorReal32 Magnitude; //fieldtype: Unknown
	CFlags[] ForceFlags; //fieldtype: Flags
	SActorRequest HostEnd //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostEndSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
}

class CActorBeam
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	SActorRequest HostLaunch //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostLaunchSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	SActorRequest HostImpact //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostImpactSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
}

class CActorRange
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	SActorRangeAbil Abil //struct
	{
		CAbilLink Link; //fieldtype: CatalogLink
		TAbilCmdIndex Index; //fieldtype: IntUnsigned
	}
	CBehaviorLink Behavior; //fieldtype: CatalogLink
	CUnitLink Sight; //fieldtype: CatalogLink
	CWeaponLink Weapon; //fieldtype: CatalogLink
	real32 Range; //fieldtype: Float
	real32 Arc; //fieldtype: Float
	CImagePath Icon; //fieldtype: String
	C2Vector IconScale; //fieldtype: Unknown
	real32 IconArcLength; //fieldtype: Float
	CColor IconTint; //fieldtype: Unknown
	CFlags[] RangeFlags; //fieldtype: Flags
	CFlagArray<e_cliffLevelCompareCount>[] CliffLevelFlags; //fieldtype: Flags
}

class CActorRegion
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CAbilCommand QueryAbilCmd; //fieldtype: Unknown
	CEffectLink QueryEffect; //fieldtype: CatalogLink
	CTargetFilters QueryFilters; //fieldtype: Unknown
	real32 QueryRange; //fieldtype: Float
	CRefKey NotifyRadiusKey; //fieldtype: String
	CRefKey NotifyArcKey; //fieldtype: String
	CRefKey NotifyClosestScaleKey; //fieldtype: String
	CFlags[] RegionFlags; //fieldtype: Flags
}

class CActorSite
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CFlags[] SiteFlags; //fieldtype: Flags
}

class CActorSiteOp
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
}

class CActorSiteOpBase
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
}

class CActorSound
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CSoundLink Sound; //fieldtype: CatalogLink
	CFlags[] SoundFlags; //fieldtype: Flags
	SActorSoundLayer[] Layers //struct
	{
		CSoundLink Sound; //fieldtype: CatalogLink
		uint8[] Chance; //fieldtype: IntUnsigned
		CPitchRange[] Pitch; //fieldtype: Unknown
		EActorSoundValueSource PitchSource; //enum
		CiRange[] PlayDelay; //fieldtype: Unknown
		EActorSoundValueSource PlayDelaySource; //enum
		CVolumeRange[] Volume; //fieldtype: Unknown
		EActorSoundValueSource VolumeSource; //enum
	}
	EActorSoundPlayMode PlayMode; //enum
	int32 LoopCount; //fieldtype: IntSigned
}

class CActorSplat
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CColor Color; //fieldtype: Unknown
	real32 FadeIn; //fieldtype: Float
	real32 FadeOut; //fieldtype: Float
	real32 HoldTime; //fieldtype: Float
	ESplatLayer Layer; //enum
	CModelLink Model; //fieldtype: CatalogLink
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	EActorSplatHeight Height; //enum
}

class CActorAction
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	CActorKey LaunchGuideAlias; //fieldtype: String
	SActorSiteOpsData LaunchSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	CActorCreateKey LaunchSite; //fieldtype: String
	CActorCreateKey LaunchSiteFallback; //fieldtype: String
	SAttachQuery LaunchAttachQuery //struct
	{
		CAttachMethods Methods; //fieldtype: Unknown
		EAttachKeyword Fallback; //enum
	}
	SActorRequest LaunchRequest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorAVPair LaunchAssets //struct
	{
		CModelLink Model; //fieldtype: CatalogLink
		CScaleVector Scale; //fieldtype: Unknown
		CAnimProps AnimProps; //fieldtype: Unknown
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey LaunchModel; //fieldtype: String
	CActorCreateKey LaunchSound; //fieldtype: String
	CActorCreateKey LaunchTerrainSquibModel; //fieldtype: String
	CActorCreateKey LaunchTerrainSquibSound; //fieldtype: String
	SActorActionTerrainSquib[] LaunchTerrainSquibMap //struct
	{
		CModelLink Model; //fieldtype: CatalogLink
		CScaleVector Scale; //fieldtype: Unknown
		CAnimProps AnimProps; //fieldtype: Unknown
		CSoundLink Sound; //fieldtype: CatalogLink
		CPhysicsMaterialLinks TerrainPhysicsMaterial; //fieldtype: Unknown
		real32 DistanceMaxFromTerrainToCreate; //fieldtype: Float
	}
	SActorSiteOpsData ContainerSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	CActorCreateKey ContainerSite; //fieldtype: String
	SAttachQuery ContainerAttachQuery //struct
	{
		CAttachMethods Methods; //fieldtype: Unknown
		EAttachKeyword Fallback; //enum
	}
	SActorAVPair ContainerAssets //struct
	{
		CModelLink Model; //fieldtype: CatalogLink
		CScaleVector Scale; //fieldtype: Unknown
		CAnimProps AnimProps; //fieldtype: Unknown
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey ContainerModel; //fieldtype: String
	CActorCreateKey ContainerSound; //fieldtype: String
	CActorCreateKey ContainerTerrainSquibModel; //fieldtype: String
	CActorCreateKey ContainerTerrainSquibSound; //fieldtype: String
	SActorActionTerrainSquib[] ContainerTerrainSquibMap //struct
	{
		CModelLink Model; //fieldtype: CatalogLink
		CScaleVector Scale; //fieldtype: Unknown
		CAnimProps AnimProps; //fieldtype: Unknown
		CSoundLink Sound; //fieldtype: CatalogLink
		CPhysicsMaterialLinks TerrainPhysicsMaterial; //fieldtype: Unknown
		real32 DistanceMaxFromTerrainToCreate; //fieldtype: Float
	}
	CActorKey Beam; //fieldtype: String
	EActorEffectScope BeamScope; //enum
	CActorKey Missile; //fieldtype: String
	SActorRequest HostImpactSource //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CActorKey ImpactGuideAlias; //fieldtype: String
	SActorSiteOpsData ImpactSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	SActorSiteOpsData ImpactSiteOpsReaction //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	CActorCreateKey ImpactSite; //fieldtype: String
	CActorCreateKey ImpactSiteFallback; //fieldtype: String
	SAttachQuery ImpactAttachQuery //struct
	{
		CAttachMethods Methods; //fieldtype: Unknown
		EAttachKeyword Fallback; //enum
	}
	SAttachQuery ImpactReattachQuery //struct
	{
		CAttachMethods Methods; //fieldtype: Unknown
		EAttachKeyword Fallback; //enum
	}
	SActorSiteOpsData ImpactPointSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	CActorCreateKey ImpactPointSite; //fieldtype: String
	SActorAVCluster[] ImpactMap //struct
	{
		CModelLink Model; //fieldtype: CatalogLink
		CScaleVector Scale; //fieldtype: Unknown
		CAnimProps AnimProps; //fieldtype: Unknown
		CSoundLink Sound; //fieldtype: CatalogLink
		CModelLink ModelReaction; //fieldtype: CatalogLink
		CAnimProps AnimPropsReaction; //fieldtype: Unknown
		CScaleVector ScaleReaction; //fieldtype: Unknown
	}
	CActorCreateKey ImpactModel; //fieldtype: String
	CActorCreateKey ImpactModelReaction; //fieldtype: String
	CActorCreateKey ImpactSound; //fieldtype: String
	SActorPhysicsData[] ImpactPhysics //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorTableKeys1x3 MatchKeys; //fieldtype: Unknown
		int32 AttackModelVariation; //fieldtype: IntSigned
		CAnimProps AttackAnimProps; //fieldtype: Unknown
		CActorCreateKey Physics; //fieldtype: String
		CFlags[] Flags; //fieldtype: Flags
	}
	CActorCreateKey ImpactTerrainSquibModel; //fieldtype: String
	CActorCreateKey ImpactTerrainSquibSound; //fieldtype: String
	SActorActionTerrainSquib[] ImpactTerrainSquibMap //struct
	{
		CModelLink Model; //fieldtype: CatalogLink
		CScaleVector Scale; //fieldtype: Unknown
		CAnimProps AnimProps; //fieldtype: Unknown
		CSoundLink Sound; //fieldtype: CatalogLink
		CPhysicsMaterialLinks TerrainPhysicsMaterial; //fieldtype: Unknown
		real32 DistanceMaxFromTerrainToCreate; //fieldtype: Float
	}
	SActorSiteOpsData DamageSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	SActorSiteOpsData DamageSiteOpsReaction //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	CActorCreateKey DamageSite; //fieldtype: String
	SAttachQuery DamageAttachQuery //struct
	{
		CAttachMethods Methods; //fieldtype: Unknown
		EAttachKeyword Fallback; //enum
	}
	SAttachQuery DamageReattachQuery //struct
	{
		CAttachMethods Methods; //fieldtype: Unknown
		EAttachKeyword Fallback; //enum
	}
	SActorAVCluster[] DamageMap //struct
	{
		CModelLink Model; //fieldtype: CatalogLink
		CScaleVector Scale; //fieldtype: Unknown
		CAnimProps AnimProps; //fieldtype: Unknown
		CSoundLink Sound; //fieldtype: CatalogLink
		CModelLink ModelReaction; //fieldtype: CatalogLink
		CAnimProps AnimPropsReaction; //fieldtype: Unknown
		CScaleVector ScaleReaction; //fieldtype: Unknown
	}
	CActorCreateKey DamageModel; //fieldtype: String
	CActorCreateKey DamageModelReaction; //fieldtype: String
	CActorCreateKey DamageSound; //fieldtype: String
	SActorPhysicsData[] DamagePhysics //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorTableKeys1x3 MatchKeys; //fieldtype: Unknown
		int32 AttackModelVariation; //fieldtype: IntSigned
		CAnimProps AttackAnimProps; //fieldtype: Unknown
		CActorCreateKey Physics; //fieldtype: String
		CFlags[] Flags; //fieldtype: Flags
	}
	CActorCreateKey DamageTerrainSquibModel; //fieldtype: String
	CActorCreateKey DamageTerrainSquibSound; //fieldtype: String
	SActorActionTerrainSquib[] DamageTerrainSquibMap //struct
	{
		CModelLink Model; //fieldtype: CatalogLink
		CScaleVector Scale; //fieldtype: Unknown
		CAnimProps AnimProps; //fieldtype: Unknown
		CSoundLink Sound; //fieldtype: CatalogLink
		CPhysicsMaterialLinks TerrainPhysicsMaterial; //fieldtype: Unknown
		real32 DistanceMaxFromTerrainToCreate; //fieldtype: Float
	}
	CActorAngle AcquisitionYawHalfArc; //fieldtype: Unknown
	CActorAngle AcquisitionPitchHalfArc; //fieldtype: Unknown
	CActorAngle AccuracyHalfArc; //fieldtype: Unknown
	real32 WeaponFireTrackingTimeWindow; //fieldtype: Float
	EActorShieldFlashType ShieldFlashType; //enum
	real32 ShieldRippleScaleFactor; //fieldtype: Float
	CFlags[] ActionFlags; //fieldtype: Flags
	CRefKey AttackAnimSource; //fieldtype: String
	CAnimNameKey AttackAnimName; //fieldtype: String
	CEffectLink ForceCommencementFrom; //fieldtype: CatalogLink
	EActorCombatRevealDurationType CombatRevealDurationType; //fieldtype: Unknown
	real32 Lifetime; //fieldtype: Float
}

class CActorActionOverride
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	CModelLink MissileModel; //fieldtype: CatalogLink
	CModelLink ImpactModel; //fieldtype: CatalogLink
	CModelLink DamageModel; //fieldtype: CatalogLink
}

class CActorArc
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	real32 Angle; //fieldtype: Float
	real32 Radius; //fieldtype: Float
	CAnimProps AngleAnimProps; //fieldtype: Unknown
}

class CActorBeamSimple
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	SActorRequest HostLaunch //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostLaunchSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	SActorRequest HostImpact //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostImpactSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
}

class CActorBeamStandard
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	SActorRequest HostLaunch //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostLaunchSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	SActorRequest HostImpact //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostImpactSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	CBeamLink Beam; //fieldtype: CatalogLink
}

class CActorBlob
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	C2Vector InitScale; //fieldtype: Unknown
	C2Vector MaxScale; //fieldtype: Unknown
	C2Vector ScaleDeltaTime; //fieldtype: Unknown
}

class CActorCameraModel
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	CRefKey Camera; //fieldtype: String
	CModelLink DoFAttenuationStartModel; //fieldtype: CatalogLink
	CModelLink DoFAttenuationEndModel; //fieldtype: CatalogLink
}

class CActorCreep
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	CActorCreateKey FoliageSpawnTarget; //fieldtype: String
	SActorQuerySubjectResponse[] SubjectResponses //struct
	{
		CActorClassFilters Filters; //fieldtype: Unknown
		EActorIntersectType IntersectType; //enum
		CActorTerms Terms; //fieldtype: Unknown
		SActorSendBasics[] OnResponse //struct
		{
			CRefKey Target; //fieldtype: String
			CActorMsgPayloadPtr Send; //fieldtype: Unknown
		}
	}
}

class CActorCutscene
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CCutscenePath FilePath; //fieldtype: String
}

class CActorDoodad
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	CFlagArray<e_actorDoodadFlagCount>[] DoodadFlags; //fieldtype: Flags
	CFlagArray<e_editorFlagCount>[] EditorFlags; //fieldtype: Flags
	CModelLink EditorModel; //fieldtype: CatalogLink
	CAnimProps EditorAnim; //fieldtype: Unknown
	CImagePath EditorIcon; //fieldtype: String
	CTerrainLink[] TexSets; //fieldtype: CatalogLink
	CFacing Facing; //fieldtype: Fixed
	CFangle EditorFacingAlignment; //fieldtype: Fixed
	CFootprintLink Footprint; //fieldtype: CatalogLink
	real32 Radius; //fieldtype: Float
	CRange RandomScaleRange; //fieldtype: Unknown
	CFixed OccludeHeight; //fieldtype: Fixed
	TCliffLevel BoostedCliffLevel; //fieldtype: IntUnsigned
	CFixed[] BoostedHeight; //fieldtype: Fixed
	CImagePath MinimapIcon; //fieldtype: String
	CActorKey MinimapRenderPriority; //fieldtype: String
	C2Vector MinimapSize; //fieldtype: Unknown
	EMinimapShape MinimapShape; //enum
	CColor MinimapColor; //fieldtype: Unknown
	CImagePath MinimapImage; //fieldtype: String
	real32 VisibleOpacity; //fieldtype: Float
	bool8 ShadowWhenTransparent; //fieldtype: Unknown
	real32 VisibleOpacityBlendDuration; //fieldtype: Float
	bool8 IgnoreDurationOnLow; //fieldtype: Unknown
	CFixed NoFlyZoneSoftRadius; //fieldtype: Fixed
	CFixed NoFlyZoneHardRadius; //fieldtype: Fixed
}

class CActorDoodadPreserver
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
}

class CActorFoliageFXSpawner
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	real32 Radius; //fieldtype: Float
	CActorCreateKey SpawnTarget; //fieldtype: String
}

class CActorEditorCamera
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
}

class CActorEditorPoint
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
}

class CActorEventMacro
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
}

class CActorEventMacroRunnable
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] Do //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
}

class CActorForceBox
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	SActorRequest Receiver //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	EActorForceField Field; //fieldtype: Unknown
	CVariatorActorReal32 Duration; //fieldtype: Unknown
	CVariatorActorReal32 Magnitude; //fieldtype: Unknown
	CFlags[] ForceFlags; //fieldtype: Flags
	CVariatorActorReal32 Height; //fieldtype: Unknown
	CVariatorActorReal32 Length; //fieldtype: Unknown
	CVariatorActorReal32 Width; //fieldtype: Unknown
	EActorForceOrigin Origin; //fieldtype: Unknown
}

class CActorForceConeRoundedEnd
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	SActorRequest Receiver //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	EActorForceField Field; //fieldtype: Unknown
	CVariatorActorReal32 Duration; //fieldtype: Unknown
	CVariatorActorReal32 Magnitude; //fieldtype: Unknown
	CFlags[] ForceFlags; //fieldtype: Flags
	SActorRequest HostEnd //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostEndSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	CVariatorActorAngle Angle; //fieldtype: Unknown
	CVariatorActorReal32 Length; //fieldtype: Unknown
}

class CActorForceCylinder
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	SActorRequest Receiver //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	EActorForceField Field; //fieldtype: Unknown
	CVariatorActorReal32 Duration; //fieldtype: Unknown
	CVariatorActorReal32 Magnitude; //fieldtype: Unknown
	CFlags[] ForceFlags; //fieldtype: Flags
	SActorRequest HostEnd //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostEndSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	CVariatorActorReal32 Radius; //fieldtype: Unknown
	CVariatorActorReal32 Length; //fieldtype: Unknown
}

class CActorForceSphere
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	SActorRequest Receiver //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	EActorForceField Field; //fieldtype: Unknown
	CVariatorActorReal32 Duration; //fieldtype: Unknown
	CVariatorActorReal32 Magnitude; //fieldtype: Unknown
	CFlags[] ForceFlags; //fieldtype: Flags
	CVariatorActorReal32 Radius; //fieldtype: Unknown
	bool8 IsHemisphere; //fieldtype: Unknown
	EActorForceDirection Direction; //fieldtype: Unknown
}

class CActorGlobalConfig
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	CActorCreateKey ActorUnitFallback; //fieldtype: String
	CActorCreateKey AttachHarnessActor; //fieldtype: String
	CActorLink AttachHarnessSOpAttach; //fieldtype: CatalogLink
	CActorLink AttachHarnessSOpLocalOffset; //fieldtype: CatalogLink
	CActorLink AttachHarnessSOpRotationExplicit; //fieldtype: CatalogLink
	SActorDeathBodySquib[] BodySquibs //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
		SActorSiteOpsData ModelSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		SAttachQuery ModelAttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
		SActorSiteOpsData SoundSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		SAttachQuery SoundAttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		ESquibType RequiredSquibType; //enum
		bool8 IsFallback; //fieldtype: Unknown
	}
	CModelLink CloakModel; //fieldtype: CatalogLink
	CModelLink CloakModelLow; //fieldtype: CatalogLink
	SActorCloakTransition[] CloakTransitionArray //struct
	{
		SActorCloakState[] StateArray //struct
		{
			CAnimProps Enter; //fieldtype: Unknown
			CAnimProps Loop; //fieldtype: Unknown
		}
	}
	CActorCreateKey CommandUIActor; //fieldtype: String
	CModelLink CreepEngulfmentModel; //fieldtype: CatalogLink
	SActorCreepHeightClass[] CreepHeightClasses //struct
	{
		CActorLabelKey Name; //fieldtype: String
		real32 StartOffset; //fieldtype: Float
		real32 SolidHeight; //fieldtype: Float
		real32 FadeHeight; //fieldtype: Float
	}
	SActorCreepRate[] CreepRates //struct
	{
		CActorLabelKey Name; //fieldtype: String
		real32 Rate; //fieldtype: Float
	}
	CActorKey[] DeathCustomPriorityList; //fieldtype: String
	SActorDeathDataCustom[] DeathCustoms //struct
	{
		CActorCreateKey ActorModel; //fieldtype: String
		CActorCreateKey ActorModelLow; //fieldtype: String
		CAnimProps AnimProps; //fieldtype: Unknown
		CModelLink ModelLink; //fieldtype: CatalogLink
		CSoundLink SoundLink; //fieldtype: CatalogLink
		CSoundLink VoiceLink; //fieldtype: CatalogLink
		SActorDeathBodySquib[] BodySquibs //struct
		{
			CActorLabelKey Name; //fieldtype: String
			CActorCreateKey ActorModel; //fieldtype: String
			CModelLink Model; //fieldtype: CatalogLink
			SActorSiteOpsData ModelSiteOps //struct
			{
				CActorSiteOps Ops; //fieldtype: Unknown
				bool8 HoldPosition; //fieldtype: Unknown
				bool8 HoldRotation; //fieldtype: Unknown
			}
			SAttachQuery ModelAttachQuery //struct
			{
				CAttachMethods Methods; //fieldtype: Unknown
				EAttachKeyword Fallback; //enum
			}
			CActorCreateKey ActorSound; //fieldtype: String
			CSoundLink Sound; //fieldtype: CatalogLink
			SActorSiteOpsData SoundSiteOps //struct
			{
				CActorSiteOps Ops; //fieldtype: Unknown
				bool8 HoldPosition; //fieldtype: Unknown
				bool8 HoldRotation; //fieldtype: Unknown
			}
			SAttachQuery SoundAttachQuery //struct
			{
				CAttachMethods Methods; //fieldtype: Unknown
				EAttachKeyword Fallback; //enum
			}
			ESquibType RequiredSquibType; //enum
			bool8 IsFallback; //fieldtype: Unknown
		}
		CActorLabelKey Name; //fieldtype: String
		CActorTableKeys1x3 PhysicsMatchKeysOrdered; //fieldtype: Unknown
		CActorLabelKey InheritsFrom; //fieldtype: String
		bool8 IsAbstract; //fieldtype: Unknown
	}
	CActorKey MainActor; //fieldtype: String
	CFixed MaxSpeedForSound; //fieldtype: Fixed
	CActorKey[] MinimapRenderPriorityList; //fieldtype: String
	real32 MissileBoundsOptSpeedThreshold; //fieldtype: Float
	CModelLink ModelCacheFallback; //fieldtype: CatalogLink
	CActorKey[] ModelMaterialPriorityList; //fieldtype: String
	uint32 PopulationLimitModel; //fieldtype: IntUnsigned
	CColorHDR RevealTint; //fieldtype: Unknown
	CActorKey SceneActor; //fieldtype: String
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
	SSplatEmitterInitInfo SplatEmitterInit //struct
	{
		C2iVector TextureResolution; //fieldtype: Unknown
		CModelLink ProjectorModel; //fieldtype: CatalogLink
		CImagePath MaskBlobPath; //fieldtype: String
		C2Vector ScaleDeltaTime; //fieldtype: Unknown
		CFixed ScaleUpdateTime; //fieldtype: Fixed
		C2Vector MaxBlobScale; //fieldtype: Unknown
		CColor Tint; //fieldtype: Unknown
		SSplatEmitterMaterialInfo[] MaterialInfo //struct
		{
			uint8 MaterialId; //fieldtype: IntUnsigned
			CFlags[] ReplacementLayers; //fieldtype: Flags
		}
		C4Vector TerrainUVTiling; //fieldtype: Unknown
		real32 MinHeightValue; //fieldtype: Float
	}
}

class CActorOverrides
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorOverrideModel[] ModelOverrides //struct
	{
		CModelLink[] Model; //fieldtype: CatalogLink
		SActorOverrideBlendTime[] Blend //struct
		{
			CAnimProps AnimProps; //fieldtype: Unknown
			real32 BlendIn; //fieldtype: Float
			real32 BlendOut; //fieldtype: Float
		}
		SActorOverrideTransitionBlendTime[] Transition //struct
		{
			EActorAnimTransitionType Type; //enum
			CAnimProps From; //fieldtype: Unknown
			EActorAnimPropMatchType FromMatch; //enum
			CAnimProps To; //fieldtype: Unknown
			EActorAnimPropMatchType ToMatch; //enum
			real32 Blend; //fieldtype: Float
		}
	}
}

class CActorLight
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
}

class CActorLightOmni
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
}

class CActorLightSpot
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
}

class CActorLightModel
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	CRefKey Light; //fieldtype: String
}

class CActorLightOmniModel
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	CRefKey Light; //fieldtype: String
}

class CActorLightSpotModel
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	CRefKey Light; //fieldtype: String
}

class CActorLookAt
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorRequest HostTarget //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostTargetSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	CActorKey Type; //fieldtype: String
	SLookAtType[] Types //struct
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
}

class CActorList
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 IsAutoDestroy; //fieldtype: Unknown
}

class CActorListPerPlayer
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 IsAutoDestroy; //fieldtype: Unknown
}

class CActorPortrait
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	CRefKey FaceFXTarget; //fieldtype: String
	CRefKey AnimTargets; //fieldtype: String
}

class CActorPower
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	CBehaviorLink PowerSource; //fieldtype: CatalogLink
	CActorCreateKey[] VisualArray; //fieldtype: String
}

class CActorProgress
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorProgressStage[] StageArray //struct
	{
		CAnimProps AnimProps; //fieldtype: Unknown
		real32 BlendTime; //fieldtype: Float
		CSoundLink Sound; //fieldtype: CatalogLink
	}
}

class CActorPropertyCurveSet
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
}

class CActorQueryResponse
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorQuerySubject Subject //struct
	{
		CActorClassFilters Filters; //fieldtype: Unknown
		CActorTerms Terms; //fieldtype: Unknown
	}
	SActorQueryResponse[] OnResponse //struct
	{
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
		EActorResponseScope Scope; //enum
	}
}

class CActorRegionArc
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CAbilCommand QueryAbilCmd; //fieldtype: Unknown
	CEffectLink QueryEffect; //fieldtype: CatalogLink
	CTargetFilters QueryFilters; //fieldtype: Unknown
	real32 QueryRange; //fieldtype: Float
	CRefKey NotifyRadiusKey; //fieldtype: String
	CRefKey NotifyArcKey; //fieldtype: String
	CRefKey NotifyClosestScaleKey; //fieldtype: String
	CFlags[] RegionFlags; //fieldtype: Flags
	real32 Angle; //fieldtype: Float
	real32 Radius; //fieldtype: Float
}

class CActorRegionCircle
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CAbilCommand QueryAbilCmd; //fieldtype: Unknown
	CEffectLink QueryEffect; //fieldtype: CatalogLink
	CTargetFilters QueryFilters; //fieldtype: Unknown
	real32 QueryRange; //fieldtype: Float
	CRefKey NotifyRadiusKey; //fieldtype: String
	CRefKey NotifyArcKey; //fieldtype: String
	CRefKey NotifyClosestScaleKey; //fieldtype: String
	CFlags[] RegionFlags; //fieldtype: Flags
	real32 Radius; //fieldtype: Float
}

class CActorRegionCombine
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CAbilCommand QueryAbilCmd; //fieldtype: Unknown
	CEffectLink QueryEffect; //fieldtype: CatalogLink
	CTargetFilters QueryFilters; //fieldtype: Unknown
	real32 QueryRange; //fieldtype: Float
	CRefKey NotifyRadiusKey; //fieldtype: String
	CRefKey NotifyArcKey; //fieldtype: String
	CRefKey NotifyClosestScaleKey; //fieldtype: String
	CFlags[] RegionFlags; //fieldtype: Flags
	CActorCreateKey[] ChildArray; //fieldtype: String
}

class CActorRegionGame
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CAbilCommand QueryAbilCmd; //fieldtype: Unknown
	CEffectLink QueryEffect; //fieldtype: CatalogLink
	CTargetFilters QueryFilters; //fieldtype: Unknown
	real32 QueryRange; //fieldtype: Float
	CRefKey NotifyRadiusKey; //fieldtype: String
	CRefKey NotifyArcKey; //fieldtype: String
	CRefKey NotifyClosestScaleKey; //fieldtype: String
	CFlags[] RegionFlags; //fieldtype: Flags
}

class CActorRegionPolygon
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CAbilCommand QueryAbilCmd; //fieldtype: Unknown
	CEffectLink QueryEffect; //fieldtype: CatalogLink
	CTargetFilters QueryFilters; //fieldtype: Unknown
	real32 QueryRange; //fieldtype: Float
	CRefKey NotifyRadiusKey; //fieldtype: String
	CRefKey NotifyArcKey; //fieldtype: String
	CRefKey NotifyClosestScaleKey; //fieldtype: String
	CFlags[] RegionFlags; //fieldtype: Flags
	C2Vector[] PointArray; //fieldtype: Unknown
}

class CActorRegionQuad
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CAbilCommand QueryAbilCmd; //fieldtype: Unknown
	CEffectLink QueryEffect; //fieldtype: CatalogLink
	CTargetFilters QueryFilters; //fieldtype: Unknown
	real32 QueryRange; //fieldtype: Float
	CRefKey NotifyRadiusKey; //fieldtype: String
	CRefKey NotifyArcKey; //fieldtype: String
	CRefKey NotifyClosestScaleKey; //fieldtype: String
	CFlags[] RegionFlags; //fieldtype: Flags
	CQuad Quad; //fieldtype: Unknown
	real32 Height; //fieldtype: Float
	real32 Width; //fieldtype: Float
}

class CActorRegionWater
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CAbilCommand QueryAbilCmd; //fieldtype: Unknown
	CEffectLink QueryEffect; //fieldtype: CatalogLink
	CTargetFilters QueryFilters; //fieldtype: Unknown
	real32 QueryRange; //fieldtype: Float
	CRefKey NotifyRadiusKey; //fieldtype: String
	CRefKey NotifyArcKey; //fieldtype: String
	CRefKey NotifyClosestScaleKey; //fieldtype: String
	CFlags[] RegionFlags; //fieldtype: Flags
}

class CActorScene
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
}

class CActorSelection
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CColor Color; //fieldtype: Unknown
	real32 FadeIn; //fieldtype: Float
	real32 FadeOut; //fieldtype: Float
	real32 HoldTime; //fieldtype: Float
	ESplatLayer Layer; //enum
	CModelLink Model; //fieldtype: CatalogLink
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	EActorSplatHeight Height; //enum
	C3Vector Alpha; //fieldtype: Unknown
	real32 FallOff; //fieldtype: Float
	real32 InnerBoundaryFallOffRatio; //fieldtype: Float
	real32 InnerBoundaryRatio; //fieldtype: Float
	real32 InnerOffsetRatio; //fieldtype: Float
	real32 InnerWidth; //fieldtype: Float
	real32 OuterWidth; //fieldtype: Float
	real32 HalfHeight; //fieldtype: Float
	real32 Attenuation; //fieldtype: Float
	real32 HostRadiusPercent; //fieldtype: Float
	real32 RotationSpeed; //fieldtype: Float
	uint32 SegmentCount; //fieldtype: IntUnsigned
	real32 SegmentPercentSolid; //fieldtype: Float
	CFlags[] SelectionFlags; //fieldtype: Flags
	CFlags[] SelectionFilter; //fieldtype: Flags
}

class CActorSetQueried
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SAttachQuery AttachQuery //struct
	{
		CAttachMethods Methods; //fieldtype: Unknown
		EAttachKeyword Fallback; //enum
	}
	CActorCreateKey SpawnTarget; //fieldtype: String
	ESquibType RequiredSquibType; //enum
}

class CActorShadow
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CColor Color; //fieldtype: Unknown
	real32 FadeIn; //fieldtype: Float
	real32 FadeOut; //fieldtype: Float
	real32 HoldTime; //fieldtype: Float
	ESplatLayer Layer; //enum
	CModelLink Model; //fieldtype: CatalogLink
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	EActorSplatHeight Height; //enum
	C3Vector Alpha; //fieldtype: Unknown
	real32 FallOff; //fieldtype: Float
	real32 HalfHeight; //fieldtype: Float
	real32 Attenuation; //fieldtype: Float
	real32 HostRadiusPercent; //fieldtype: Float
}

class CActorShield
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	CActorCreateKey Ripple; //fieldtype: String
	real32 ScaleDamageMin; //fieldtype: Float
	real32 ScaleDamageMax; //fieldtype: Float
	real32 RadiusMin; //fieldtype: Float
	real32 RadiusMax; //fieldtype: Float
}

class CActorShieldImpact
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	CActorCreateKey VisualDirectionalFacer; //fieldtype: String
	CActorCreateKey VisualDirectionalHeader; //fieldtype: String
	CActorCreateKey VisualDirectionless; //fieldtype: String
	real32 RadiusMedium; //fieldtype: Float
	real32 RadiusLarge; //fieldtype: Float
	uint32 MaxCountSmall; //fieldtype: IntUnsigned
	uint32 MaxCountMedium; //fieldtype: IntUnsigned
	uint32 MaxCountLarge; //fieldtype: IntUnsigned
}

class CActorSimple
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
}

class CActorSiteBillboard
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CFlags[] SiteFlags; //fieldtype: Flags
	EActorSiteBillboardType BillboardType; //enum
	real32 TowardsCameraDistance; //fieldtype: Float
	bool8 HoldRotation; //fieldtype: Unknown
	bool8 UpdateDriveBearings; //fieldtype: Unknown
}

class CActorSiteMover
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CFlags[] SiteFlags; //fieldtype: Flags
	real32 Acceleration; //fieldtype: Float
	real32 Deceleration; //fieldtype: Float
	real32 Speed; //fieldtype: Float
	real32 SpeedMax; //fieldtype: Float
}

class CActorSiteOrbiter
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CFlags[] SiteFlags; //fieldtype: Flags
	EActorSiteOrbiterType Type; //enum
	CVariatorActorFangle BaseYaw; //fieldtype: Unknown
	CVariatorActorReal32 BaseYawPeriod; //fieldtype: Unknown
	CVariatorActorFangle BasePitch; //fieldtype: Unknown
	CVariatorActorReal32 BasePitchPeriod; //fieldtype: Unknown
	CVariatorActorReal32 BaseRadiusInner; //fieldtype: Unknown
	CVariatorActorReal32 BaseRadiusOuter; //fieldtype: Unknown
	CVariatorActorReal32 BaseRadiusPeriod; //fieldtype: Unknown
	CVariatorActorReal32 EndYawPeriod; //fieldtype: Unknown
	CVariatorActorReal32 EndPitchPeriod; //fieldtype: Unknown
	CVariatorActorReal32 EndRollPeriod; //fieldtype: Unknown
	CVariatorActorReal32 EndRadiusInner; //fieldtype: Unknown
	CVariatorActorReal32 EndRadiusOuter; //fieldtype: Unknown
	CVariatorActorReal32 EndRadiusPeriod; //fieldtype: Unknown
}

class CActorSiteRocker
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CFlags[] SiteFlags; //fieldtype: Flags
	CVariatorActorReal32 Elevation; //fieldtype: Unknown
	CVariatorActorReal32 ElevationPeriod; //fieldtype: Unknown
	CVariatorActorFangle Pitch; //fieldtype: Unknown
	CVariatorActorReal32 PitchPeriod; //fieldtype: Unknown
	CVariatorActorFangle Roll; //fieldtype: Unknown
	CVariatorActorReal32 RollPeriod; //fieldtype: Unknown
}

class CActorSiteOp2DRotation
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
}

class CActorSiteOpAction
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	EActorSiteOpActionLocation Location; //enum
}

class CActorSiteOpAttach
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	SAttachQuery AttachQuery //struct
	{
		CAttachMethods Methods; //fieldtype: Unknown
		EAttachKeyword Fallback; //enum
	}
	SAttachQuery ReattachQuery //struct
	{
		CAttachMethods Methods; //fieldtype: Unknown
		EAttachKeyword Fallback; //enum
	}
	bool8 ForceSoftAttach; //fieldtype: Unknown
	EActorSiteOpAttachSource Source; //enum
}

class CActorSiteOpAttachVolume
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	SActorRequest HostIncoming //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostIncomingSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	bool8 UpwardVisibilityEnhancement; //fieldtype: Unknown
	CActorAngle UpwardVisibilityEnhancementVarianceUp; //fieldtype: Unknown
	CActorAngle UpwardVisibilityEnhancementVarianceDown; //fieldtype: Unknown
}

class CActorSiteOpBanker
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	CActorAngle RollAngleMax; //fieldtype: Unknown
	CActorAngle RollInRate; //fieldtype: Unknown
	CActorAngle RollOutRate; //fieldtype: Unknown
	real32 RollOutRemainderFractionForLevelOff; //fieldtype: Float
}

class CActorSiteOpBankerUnit
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	CVariatorActorAngle RollMax; //fieldtype: Unknown
	CActorAngle RollInActivationAngle; //fieldtype: Unknown
	CVariatorActorAngle RollInArc; //fieldtype: Unknown
	CVariatorActorReal32 RollOutDuration; //fieldtype: Unknown
}

class CActorSiteOpBasic
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	EActorSiteOpBasicType BasicType; //enum
	C3Vector WorldPosition; //fieldtype: Unknown
}

class CActorSiteOpGameCameraFollow
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
}

class CActorSiteOpDeathMotion
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	SActorRequest HostInitial //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostInitialSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	real32 Deceleration; //fieldtype: Float
}

class CActorSiteOpDeltaSum
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	SActorHostedDelta[] Deltas //struct
	{
		CRefKey Subject; //fieldtype: String
		C3Vector LocalOffset; //fieldtype: Unknown
		SAttachQuery AttachQuerySource //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SAttachQuery AttachQueryTarget //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
	}
	CFlags[] DeltaSumFlags; //fieldtype: Flags
}

class CActorSiteOpEffect
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	EActorEffectLocation Location; //enum
	bool8 ZOnly; //fieldtype: Unknown
}

class CActorSiteOpForward
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	C3Vector Forward; //fieldtype: Unknown
	SActorRequest HostForward //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostForwardSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	bool8 Invert; //fieldtype: Unknown
}

class CActorSiteOpHeight
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	EActorHeightSourceType HeightSourceType; //enum
	SActorRequest HostHeight //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
}

class CActorSiteOpHigherOfTerrainAndWater
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	EActorHeightSourceType HeightSourceType; //enum
	real32 ForcedWadingMaxDepth; //fieldtype: Float
	CFlags[] TerrainAndWaterFlags; //fieldtype: Flags
}

class CActorSiteOpHostBearings
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	SActorRequest HostBearings //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostBearingsSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
}

class CActorSiteOpHostedOffset
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	SActorRequest HostOffset //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostOffsetSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
}

class CActorSiteOpIncoming
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	SActorRequest HostImpact //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest HostIncoming //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	EActorIncomingType Type; //enum
	real32 PullBack; //fieldtype: Float
	bool8 FreezePositionAtImpact; //fieldtype: Unknown
}

class CActorSiteOpLocalOffset
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	C3Vector LocalOffset; //fieldtype: Unknown
	CVariatorActorReal32 OverridingLength; //fieldtype: Unknown
	SAccumulatedFixed OverridingLengthExtra //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
}

class CActorSiteOpOrientAttachPointTo
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	SAttachQuery AttachQuery //struct
	{
		CAttachMethods Methods; //fieldtype: Unknown
		EAttachKeyword Fallback; //enum
	}
	EActorSiteOpOrientAttachPointToType Type; //enum
}

class CActorSiteOpPatch
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	CActorAngle PatchAngle; //fieldtype: Unknown
	real32 PatchRadius; //fieldtype: Float
	EActorRadialDistribution Distribution; //enum
	real32 Mean; //fieldtype: Float
	real32 Variance; //fieldtype: Float
}

class CActorSiteOpPersistentOffset
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	SActorRequest HostInitial //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostInitialSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
}

class CActorSiteOpOrbiter
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	EActorSiteOrbiterType Type; //enum
	CVariatorActorFangle BaseYaw; //fieldtype: Unknown
	CVariatorActorReal32 BaseYawPeriod; //fieldtype: Unknown
	CVariatorActorFangle BasePitch; //fieldtype: Unknown
	CVariatorActorReal32 BasePitchPeriod; //fieldtype: Unknown
	CVariatorActorReal32 BaseRadiusInner; //fieldtype: Unknown
	CVariatorActorReal32 BaseRadiusOuter; //fieldtype: Unknown
	CVariatorActorReal32 BaseRadiusPeriod; //fieldtype: Unknown
	CVariatorActorReal32 EndYawPeriod; //fieldtype: Unknown
	CVariatorActorReal32 EndPitchPeriod; //fieldtype: Unknown
	CVariatorActorReal32 EndRollPeriod; //fieldtype: Unknown
	CVariatorActorReal32 EndRadiusInner; //fieldtype: Unknown
	CVariatorActorReal32 EndRadiusOuter; //fieldtype: Unknown
	CVariatorActorReal32 EndRadiusPeriod; //fieldtype: Unknown
}

class CActorSiteOpPhysicsImpact
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	EActorSiteOpPhysicsImpactType Type; //enum
}

class CActorSiteOpRandomPointInCircle
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	real32 Radius; //fieldtype: Float
	EActorRadialDistribution Distribution; //enum
	real32 Mean; //fieldtype: Float
	real32 Variance; //fieldtype: Float
	bool8 RestrictToCircumference; //fieldtype: Unknown
	bool8 ObserveRotation; //fieldtype: Unknown
}

class CActorSiteOpRandomPointInCrossbar
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	real32 HalfWidth; //fieldtype: Float
	EActorCrossbarDistribution Distribution; //enum
	real32 Variance; //fieldtype: Float
}

class CActorSiteOpRandomPointInSphere
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	real32 Radius; //fieldtype: Float
	EActorRadialDistribution Distribution; //enum
	real32 Mean; //fieldtype: Float
	real32 Variance; //fieldtype: Float
	bool8 RestrictToSurface; //fieldtype: Unknown
}

class CActorSiteOpRotationExplicit
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	C3Vector Forward; //fieldtype: Unknown
	C3Vector Up; //fieldtype: Unknown
	bool8 IsLocal; //fieldtype: Unknown
}

class CActorSiteOpRotationRandom
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	CActorAngle YawHalfAngle; //fieldtype: Unknown
	CActorAngle PitchHalfAngle; //fieldtype: Unknown
}

class CActorSiteOpRotationVariancer
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	CActorAngle ForwardAngle; //fieldtype: Unknown
	CActorAngle UpAngle; //fieldtype: Unknown
	bool8 IsUpDominantWhenOrthogonalized; //fieldtype: Unknown
}

class CActorSiteOpRotator
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	C3Vector LocalAxis; //fieldtype: Unknown
	CActorAngle Rate; //fieldtype: Unknown
	EActorSiteOpRotatorType Type; //enum
	CActorAngle InitialAngle; //fieldtype: Unknown
}

class CActorSiteOpRotationSmooth
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	CFangleRate Acceleration; //fieldtype: Unknown
	CFangleRate Deceleration; //fieldtype: Unknown
	CFangleRate MaxSpeed; //fieldtype: Unknown
}

class CActorSiteOpSelectionOffset
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
}

class CActorSiteOpSerpentHead
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	SSerpentAggregate Aggregate //struct
	{
		ESerpentType Type; //enum
		real32 BaseElementLengthMax; //fieldtype: Float
		CActorAngle SegmentRotationRate; //fieldtype: Unknown
		real32 SwimmingUndulationElementLength; //fieldtype: Float
		real32 SwimmingUndulationStartOffset; //fieldtype: Float
		real32 SwimmingUndulationAmplitudePerUnit; //fieldtype: Float
		real32 SwimmingUndulationWavelength; //fieldtype: Float
		real32 SwimmingUndulationIdlePhaseVelocity; //fieldtype: Float
		CActorAngle TurnSmoothingActivationAngleMin; //fieldtype: Unknown
		CActorAngle TurnSmoothingActivationAngleMax; //fieldtype: Unknown
		real32 TurnSmoothingRadiusMax; //fieldtype: Float
		CActorAngle UncoilingWhileIdleRotationRateMin; //fieldtype: Unknown
		CActorAngle UncoilingWhileIdleRotationRateMax; //fieldtype: Unknown
		CFlags[] Flags; //fieldtype: Flags
	}
	SSerpentSegment Segment //struct
	{
		real32 Radius; //fieldtype: Float
	}
}

class CActorSiteOpSerpentSegment
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	CRefKey Head; //fieldtype: String
	SSerpentSegment Segment //struct
	{
		real32 Radius; //fieldtype: Float
	}
}

class CActorSiteOpShadow
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	EActorHeightSourceType HeightSourceType; //enum
	real32 HeightOffset; //fieldtype: Float
	real32 HeightOffsetOnCliff; //fieldtype: Float
	C2Vector[] CliffTests; //fieldtype: Unknown
	C2Vector[] HeightTests; //fieldtype: Unknown
	EActorHeightTestType HeightTestType; //enum
	CFlags[] ShadowFlags; //fieldtype: Flags
}

class CActorSiteOpTether
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	SActorRequest HostTether //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostTetherSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorSiteOpTetherEnableType EnableX; //fieldtype: Unknown
	EActorSiteOpTetherEnableType EnableY; //fieldtype: Unknown
	EActorSiteOpTetherEnableType EnableZ; //fieldtype: Unknown
	real32 XMinimum; //fieldtype: Float
	real32 XMaximum; //fieldtype: Float
	real32 YMinimum; //fieldtype: Float
	real32 YMaximum; //fieldtype: Float
	real32 ZMinimum; //fieldtype: Float
	real32 ZMaximum; //fieldtype: Float
}

class CActorSiteOpTipability
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	CFlags[] TipabilityFlags; //fieldtype: Flags
}

class CActorSiteOpTilter
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	EActorTiltType TiltType; //enum
	real32 TiltAmount; //fieldtype: Float
	real32 AngleRate; //fieldtype: Float
}

class CActorSiteOpUp
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	C3Vector Up; //fieldtype: Unknown
	SActorRequest HostUp //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostUpSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	bool8 Invert; //fieldtype: Unknown
}

class CActorSiteOpZ
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	SActorRequest HostZ //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
}

class CActorSiteOpCursor
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
}

class CActorSiteOpYawLimiter
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	SActorRequest HostYawLimiter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostYawLimiterSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	CActorAngle YawHalfAngle; //fieldtype: Unknown
	CActorAngle ExtraYawAngle; //fieldtype: Unknown
}

class CActorSiteOpPitchLimiter
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 HoldPosition; //fieldtype: Unknown
	bool8 HoldRotation; //fieldtype: Unknown
	SActorRequest HostPitchLimiter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostPitchLimiterSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	CActorAngle PitchHalfAngle; //fieldtype: Unknown
}

class CActorSnapshot
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
}

class CActorStateMonitor
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorStateInfo[] StateArray //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorTerms Terms; //fieldtype: Unknown
	}
	CGameTime StateThinkInterval; //fieldtype: Fixed
}

class CActorSquib
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	SActorAVPair[] Map //struct
	{
		CModelLink Model; //fieldtype: CatalogLink
		CScaleVector Scale; //fieldtype: Unknown
		CAnimProps AnimProps; //fieldtype: Unknown
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey HarnessModel; //fieldtype: String
	CActorCreateKey HarnessSound; //fieldtype: String
}

class CActorBatch
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CActorCreateKey HarnessActor; //fieldtype: String
	SAccumulatedUInt32 Count //struct
	{
		CAccumulatorLink[] AccumulatorArray; //fieldtype: CatalogLink
	}
}

class CActorTerrain
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
}

class CActorTerrainDeformer
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CFootprintLink Footprint; //fieldtype: CatalogLink
	real32 InfluenceRange; //fieldtype: Float
	real32 BlendTime; //fieldtype: Float
	real32 HeightDelta; //fieldtype: Float
	CFlags[] TerrainDeformerFlags; //fieldtype: Flags
	CActorCreateKey FoliageFXDeathSpawnTarget; //fieldtype: String
}

class CActorText
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	real32 TextScale; //fieldtype: Float
	C2Vector MaxSize; //fieldtype: Unknown
	uint32 FixedSize; //fieldtype: IntUnsigned
	EActorTextAlignment AlignH; //enum
	EActorTextAlignment AlignV; //enum
	real32 HeightOffset; //fieldtype: Float
	CColor Color; //fieldtype: Unknown
	CFlags[] Options; //fieldtype: Flags
	CStringLink Text; //fieldtype: String
}

class CActorTurret
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SAttachQuery PitchQuery //struct
	{
		CAttachMethods Methods; //fieldtype: Unknown
		EAttachKeyword Fallback; //enum
	}
	SAttachQuery YawQuery //struct
	{
		CAttachMethods Methods; //fieldtype: Unknown
		EAttachKeyword Fallback; //enum
	}
	SActorRequest TurretBody //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
}

class CActorUnit
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	SActorBaseline[] Baselines //struct
	{
		CAnimProps AnimProps; //fieldtype: Unknown
		real32 BlendIn; //fieldtype: Float
		real32 BlendOut; //fieldtype: Float
	}
	CModelLink BuildModel; //fieldtype: CatalogLink
	SActorDeathData[] DeathArray //struct
	{
		CActorCreateKey ActorModel; //fieldtype: String
		CActorCreateKey ActorModelLow; //fieldtype: String
		CAnimProps AnimProps; //fieldtype: Unknown
		CModelLink ModelLink; //fieldtype: CatalogLink
		CSoundLink SoundLink; //fieldtype: CatalogLink
		CSoundLink VoiceLink; //fieldtype: CatalogLink
		SActorDeathBodySquib[] BodySquibs //struct
		{
			CActorLabelKey Name; //fieldtype: String
			CActorCreateKey ActorModel; //fieldtype: String
			CModelLink Model; //fieldtype: CatalogLink
			SActorSiteOpsData ModelSiteOps //struct
			{
				CActorSiteOps Ops; //fieldtype: Unknown
				bool8 HoldPosition; //fieldtype: Unknown
				bool8 HoldRotation; //fieldtype: Unknown
			}
			SAttachQuery ModelAttachQuery //struct
			{
				CAttachMethods Methods; //fieldtype: Unknown
				EAttachKeyword Fallback; //enum
			}
			CActorCreateKey ActorSound; //fieldtype: String
			CSoundLink Sound; //fieldtype: CatalogLink
			SActorSiteOpsData SoundSiteOps //struct
			{
				CActorSiteOps Ops; //fieldtype: Unknown
				bool8 HoldPosition; //fieldtype: Unknown
				bool8 HoldRotation; //fieldtype: Unknown
			}
			SAttachQuery SoundAttachQuery //struct
			{
				CAttachMethods Methods; //fieldtype: Unknown
				EAttachKeyword Fallback; //enum
			}
			ESquibType RequiredSquibType; //enum
			bool8 IsFallback; //fieldtype: Unknown
		}
	}
	SActorDeathDataCustom[] DeathCustoms //struct
	{
		CActorCreateKey ActorModel; //fieldtype: String
		CActorCreateKey ActorModelLow; //fieldtype: String
		CAnimProps AnimProps; //fieldtype: Unknown
		CModelLink ModelLink; //fieldtype: CatalogLink
		CSoundLink SoundLink; //fieldtype: CatalogLink
		CSoundLink VoiceLink; //fieldtype: CatalogLink
		SActorDeathBodySquib[] BodySquibs //struct
		{
			CActorLabelKey Name; //fieldtype: String
			CActorCreateKey ActorModel; //fieldtype: String
			CModelLink Model; //fieldtype: CatalogLink
			SActorSiteOpsData ModelSiteOps //struct
			{
				CActorSiteOps Ops; //fieldtype: Unknown
				bool8 HoldPosition; //fieldtype: Unknown
				bool8 HoldRotation; //fieldtype: Unknown
			}
			SAttachQuery ModelAttachQuery //struct
			{
				CAttachMethods Methods; //fieldtype: Unknown
				EAttachKeyword Fallback; //enum
			}
			CActorCreateKey ActorSound; //fieldtype: String
			CSoundLink Sound; //fieldtype: CatalogLink
			SActorSiteOpsData SoundSiteOps //struct
			{
				CActorSiteOps Ops; //fieldtype: Unknown
				bool8 HoldPosition; //fieldtype: Unknown
				bool8 HoldRotation; //fieldtype: Unknown
			}
			SAttachQuery SoundAttachQuery //struct
			{
				CAttachMethods Methods; //fieldtype: Unknown
				EAttachKeyword Fallback; //enum
			}
			ESquibType RequiredSquibType; //enum
			bool8 IsFallback; //fieldtype: Unknown
		}
		CActorLabelKey Name; //fieldtype: String
		CActorTableKeys1x3 PhysicsMatchKeysOrdered; //fieldtype: Unknown
		CActorLabelKey InheritsFrom; //fieldtype: String
		bool8 IsAbstract; //fieldtype: Unknown
	}
	SActorDeathDataCustomGroup[] DeathCustomData //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorDeathMembers Members; //fieldtype: Unknown
		CActorTableKeys1x3 Supersedes; //fieldtype: Unknown
		CFixed SyncPassChance; //fieldtype: Fixed
	}
	CActorCreateKey DeathActorModel; //fieldtype: String
	CActorCreateKey DeathActorModelLow; //fieldtype: String
	CActorCreateKey DeathActorSound; //fieldtype: String
	CActorCreateKey DeathActorVoice; //fieldtype: String
	CModelLink EditorModel; //fieldtype: CatalogLink
	CAnimProps EditorAnim; //fieldtype: Unknown
	CActorCreateKey ImpactSoundActor; //fieldtype: String
	CSoundLink ImpactSound; //fieldtype: CatalogLink
	SActorUnitImpactSoundExtras[] ImpactSoundExtras //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		CActorCreateKey SoundActor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	SDamagePastRemainingHealth OverkillByDamagePastRemainingHealth //struct
	{
		CFixed Value; //fieldtype: Fixed
		EActorOverkillTestType TestType; //fieldtype: Unknown
	}
	SDamageOverInterval OverkillByDamageOverInterval //struct
	{
		CFixed Value; //fieldtype: Fixed
		CFixed Interval; //fieldtype: Fixed
		EActorOverkillTestType TestType; //fieldtype: Unknown
	}
	CActorTableKeys1x3 PhysicsMatchKeysOrdered; //fieldtype: Unknown
	CModelLink PlacementModel; //fieldtype: CatalogLink
	CSoundLink PlacementSound; //fieldtype: CatalogLink
	CActorCreateKey PlacementActorModel; //fieldtype: String
	CActorCreateKey PlaceholderActorModel; //fieldtype: String
	CActorCreateKey PortraitActor; //fieldtype: String
	CModelLink PortraitModel; //fieldtype: CatalogLink
	CCameraLink PortraitCamera; //fieldtype: CatalogLink
	CRange RandomScaleRange; //fieldtype: Unknown
	real32 RingRadius; //fieldtype: Float
	CGameTime StandAnimTurnTime; //fieldtype: Fixed
	real32 StandAnimTurnTimeScaleMin; //fieldtype: Float
	STerrainSquib[] TerrainSquibs //struct
	{
		CActorLabelKey GroupName; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		CVariatorActorReal32 MovementDistance; //fieldtype: Unknown
		CVariatorActorReal32 IdlePeriod; //fieldtype: Unknown
		real32 RangeUp; //fieldtype: Float
		real32 RangeUpFade; //fieldtype: Float
		real32 RangeDown; //fieldtype: Float
		real32 RangeDownFade; //fieldtype: Float
		STerrainSquibVisual[] Visuals //struct
		{
			CPhysicsMaterialLink TerrainPhysicsMaterial; //fieldtype: CatalogLink
			CActorCreateKey ActorModel; //fieldtype: String
			CActorCreateKey ActorModelLow; //fieldtype: String
			CModelLink ModelLink; //fieldtype: CatalogLink
			CFlags[] Flags; //fieldtype: Flags
		}
	}
	real32 VarianceWindowStandIntro; //fieldtype: Float
	real32 VarianceWindowStand; //fieldtype: Float
	real32 VarianceWindowWalkIntro; //fieldtype: Float
	real32 VarianceWindowWalk; //fieldtype: Float
	real32 VarianceWindowWalkOutro; //fieldtype: Float
	CGameRate WalkAnimMoveSpeed; //fieldtype: Fixed
	bool8 WalkAnimTimeScalingAsFlyer; //fieldtype: Unknown
	SUnitAbilSound[] AbilSoundArray //struct
	{
		CAbilCommand AbilCmd; //fieldtype: Unknown
		CSoundLink Sound; //fieldtype: CatalogLink
		CSoundLink GroupSound; //fieldtype: CatalogLink
	}
	CStringLink AddonIndicator; //fieldtype: String
	uint32 BarDistance; //fieldtype: IntUnsigned
	int32 BarHeight; //fieldtype: IntSigned
	int32 BarOffset; //fieldtype: IntSigned
	int32 BarWidth; //fieldtype: IntSigned
	CStringLink CantSelectUncontrollableTooltip; //fieldtype: String
	CAbilCommand[] CooldownDisplay; //fieldtype: Unknown
	CDescPath CustomUnitStatusFrame; //fieldtype: Unknown
	C2iVector CustomUnitStatusOffset; //fieldtype: Unknown
	EAttachmentID CustomUnitStatusAttachment; //enum
	CRefKey CustomUnitStatusActor; //fieldtype: String
	SErrorOverride[] ErrorArray //struct
	{
		ECmdResult Error; //enum
		CStringLink Text; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
		CSoundLink GroupSound; //fieldtype: CatalogLink
	}
	CString GlossaryAnim; //fieldtype: String
	SLayerIcon GroupIcon //struct
	{
		CImagePath[] Image; //fieldtype: String
	}
	SLayerIconVariation[] GroupIconVariations //struct
	{
		CImagePath[] Image; //fieldtype: String
		int32 Number; //fieldtype: IntSigned
	}
	CSoundLink[] GroupSoundArray; //fieldtype: CatalogLink
	uint32 GroupSoundThreshold; //fieldtype: IntUnsigned
	CImagePath HeroIcon; //fieldtype: String
	SIconVariation[] HeroIconVariations //struct
	{
		uint32 Number; //fieldtype: IntUnsigned
		CImagePath Image; //fieldtype: String
	}
	CStringLink HighlightTooltip; //fieldtype: String
	CStringLink HighlightSubTooltip; //fieldtype: String
	CStringLink InfoText; //fieldtype: String
	CImagePath LifeArmorIcon; //fieldtype: String
	CImagePath MinimapIcon; //fieldtype: String
	bool8 MinimapIconIsTeamColored; //fieldtype: Unknown
	real32 MinimapIconScale; //fieldtype: Float
	CImagePath MinimapIconBackground; //fieldtype: String
	bool8 MinimapIconBackgroundIsTeamColored; //fieldtype: Unknown
	real32 MinimapIconBackgroundScale; //fieldtype: Float
	CColor MinimapIconBackgroundTintColor; //fieldtype: Unknown
	CColor MinimapIconTintColor; //fieldtype: Unknown
	CActorKey MinimapRenderPriority; //fieldtype: String
	CStringLink MinimapTooltip; //fieldtype: String
	bool8 MinimapFlashWhenAttacked; //fieldtype: Unknown
	bool8 MinimapUseSelfColor; //fieldtype: Unknown
	bool8 MinimapUseSelectionColor; //fieldtype: Unknown
	CDescPath MinimapUnitStatusFrame; //fieldtype: Unknown
	CHerdNodeLink MovementHerdNode; //fieldtype: CatalogLink
	int32 NameOffset; //fieldtype: IntSigned
	CAbilCommand SelectAbilCmd; //fieldtype: Unknown
	CImagePath ShieldArmorIcon; //fieldtype: String
	CActorCreateKey SnapshotActor; //fieldtype: String
	CSoundLink[] SoundArray; //fieldtype: CatalogLink
	CFlagArray<e_unitStatusCount>[] StatusBarFlags; //fieldtype: Flags
	CFlagArray<e_unitStatusGroupCount>[] StatusBarGroups; //fieldtype: Flags
	CFlagArray<e_unitStatusCount>[] StatusBarOn; //fieldtype: Flags
	SStatusColor[] StatusColors //struct
	{
		CColor BackgroundColor; //fieldtype: Unknown
		CColor EmptyColor; //fieldtype: Unknown
		CColor[] ColorArray; //fieldtype: Unknown
	}
	SStatusChargeData StatusChargeData //struct
	{
		CStringLink Text; //fieldtype: String
		CAbilCommand AbilCmd; //fieldtype: Unknown
	}
	SStatusHarvesterData StatusHarvesterData //struct
	{
		CStringLink Text; //fieldtype: String
		CTargetFilters SearchFilters; //fieldtype: Unknown
		CFixed SearchRadius; //fieldtype: Fixed
	}
	STextTagParameters StatusTextInfo //struct
	{
		CStringLink Text; //fieldtype: String
		bool8 TextShadow; //fieldtype: Unknown
		C2iVector Offset; //fieldtype: Unknown
		EAttachmentID Attachment; //enum
		uint32 FontSize; //fieldtype: IntUnsigned
		CColor TextColor; //fieldtype: Unknown
		CColor EdgeColor; //fieldtype: Unknown
		CColor BackgroundColor; //fieldtype: Unknown
		CImagePath BackgroundImage; //fieldtype: String
		bool8 BackgroundImageTiled; //fieldtype: Unknown
	}
	CColorRGB UnitBorderNormalColor; //fieldtype: Unknown
	CColorRGB UnitBorderSubgroupColor; //fieldtype: Unknown
	CFlags[] UnitFlags; //fieldtype: Flags
	CImagePath UnitIcon; //fieldtype: String
	SIconVariation[] UnitIconVariations //struct
	{
		uint32 Number; //fieldtype: IntUnsigned
		CImagePath Image; //fieldtype: String
	}
	CImagePath UnitIconMultiple; //fieldtype: String
	SUnitKillRank[] UnitKillRank //struct
	{
		uint32 MinKills; //fieldtype: IntUnsigned
		CStringLink Text; //fieldtype: String
	}
	CActorCreateKey UnitModelFrameActor; //fieldtype: String
	SVitalColor[] VitalColors //struct
	{
		CColor[] ColorArray; //fieldtype: Unknown
	}
	CStringLink[] VitalNames; //fieldtype: String
	SLayerIcon Wireframe //struct
	{
		CImagePath[] Image; //fieldtype: String
	}
	SLayerIconVariation[] WireframeVariations //struct
	{
		CImagePath[] Image; //fieldtype: String
		int32 Number; //fieldtype: IntSigned
	}
	SLayerIconShield WireframeShield //struct
	{
		CImagePath[] Image; //fieldtype: String
	}
	CColor WireframeShieldColor; //fieldtype: Unknown
	SLayerIconShieldVariation[] WireframeShieldVariations //struct
	{
		CImagePath[] Image; //fieldtype: String
		uint32 Number; //fieldtype: IntUnsigned
	}
	real32 VisibleOpacity; //fieldtype: Float
	real32 VisibleOpacityBlendDuration; //fieldtype: Float
	CButtonLink UnitButton; //fieldtype: CatalogLink
	CButtonLink UnitButtonMultiple; //fieldtype: CatalogLink
}

class CActorUnitRing
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	real32 RingRadius; //fieldtype: Float
}

class CActorMissile
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
	SActorBaseline[] Baselines //struct
	{
		CAnimProps AnimProps; //fieldtype: Unknown
		real32 BlendIn; //fieldtype: Float
		real32 BlendOut; //fieldtype: Float
	}
	CModelLink BuildModel; //fieldtype: CatalogLink
	SActorDeathData[] DeathArray //struct
	{
		CActorCreateKey ActorModel; //fieldtype: String
		CActorCreateKey ActorModelLow; //fieldtype: String
		CAnimProps AnimProps; //fieldtype: Unknown
		CModelLink ModelLink; //fieldtype: CatalogLink
		CSoundLink SoundLink; //fieldtype: CatalogLink
		CSoundLink VoiceLink; //fieldtype: CatalogLink
		SActorDeathBodySquib[] BodySquibs //struct
		{
			CActorLabelKey Name; //fieldtype: String
			CActorCreateKey ActorModel; //fieldtype: String
			CModelLink Model; //fieldtype: CatalogLink
			SActorSiteOpsData ModelSiteOps //struct
			{
				CActorSiteOps Ops; //fieldtype: Unknown
				bool8 HoldPosition; //fieldtype: Unknown
				bool8 HoldRotation; //fieldtype: Unknown
			}
			SAttachQuery ModelAttachQuery //struct
			{
				CAttachMethods Methods; //fieldtype: Unknown
				EAttachKeyword Fallback; //enum
			}
			CActorCreateKey ActorSound; //fieldtype: String
			CSoundLink Sound; //fieldtype: CatalogLink
			SActorSiteOpsData SoundSiteOps //struct
			{
				CActorSiteOps Ops; //fieldtype: Unknown
				bool8 HoldPosition; //fieldtype: Unknown
				bool8 HoldRotation; //fieldtype: Unknown
			}
			SAttachQuery SoundAttachQuery //struct
			{
				CAttachMethods Methods; //fieldtype: Unknown
				EAttachKeyword Fallback; //enum
			}
			ESquibType RequiredSquibType; //enum
			bool8 IsFallback; //fieldtype: Unknown
		}
	}
	SActorDeathDataCustom[] DeathCustoms //struct
	{
		CActorCreateKey ActorModel; //fieldtype: String
		CActorCreateKey ActorModelLow; //fieldtype: String
		CAnimProps AnimProps; //fieldtype: Unknown
		CModelLink ModelLink; //fieldtype: CatalogLink
		CSoundLink SoundLink; //fieldtype: CatalogLink
		CSoundLink VoiceLink; //fieldtype: CatalogLink
		SActorDeathBodySquib[] BodySquibs //struct
		{
			CActorLabelKey Name; //fieldtype: String
			CActorCreateKey ActorModel; //fieldtype: String
			CModelLink Model; //fieldtype: CatalogLink
			SActorSiteOpsData ModelSiteOps //struct
			{
				CActorSiteOps Ops; //fieldtype: Unknown
				bool8 HoldPosition; //fieldtype: Unknown
				bool8 HoldRotation; //fieldtype: Unknown
			}
			SAttachQuery ModelAttachQuery //struct
			{
				CAttachMethods Methods; //fieldtype: Unknown
				EAttachKeyword Fallback; //enum
			}
			CActorCreateKey ActorSound; //fieldtype: String
			CSoundLink Sound; //fieldtype: CatalogLink
			SActorSiteOpsData SoundSiteOps //struct
			{
				CActorSiteOps Ops; //fieldtype: Unknown
				bool8 HoldPosition; //fieldtype: Unknown
				bool8 HoldRotation; //fieldtype: Unknown
			}
			SAttachQuery SoundAttachQuery //struct
			{
				CAttachMethods Methods; //fieldtype: Unknown
				EAttachKeyword Fallback; //enum
			}
			ESquibType RequiredSquibType; //enum
			bool8 IsFallback; //fieldtype: Unknown
		}
		CActorLabelKey Name; //fieldtype: String
		CActorTableKeys1x3 PhysicsMatchKeysOrdered; //fieldtype: Unknown
		CActorLabelKey InheritsFrom; //fieldtype: String
		bool8 IsAbstract; //fieldtype: Unknown
	}
	SActorDeathDataCustomGroup[] DeathCustomData //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorDeathMembers Members; //fieldtype: Unknown
		CActorTableKeys1x3 Supersedes; //fieldtype: Unknown
		CFixed SyncPassChance; //fieldtype: Fixed
	}
	CActorCreateKey DeathActorModel; //fieldtype: String
	CActorCreateKey DeathActorModelLow; //fieldtype: String
	CActorCreateKey DeathActorSound; //fieldtype: String
	CActorCreateKey DeathActorVoice; //fieldtype: String
	CModelLink EditorModel; //fieldtype: CatalogLink
	CAnimProps EditorAnim; //fieldtype: Unknown
	CActorCreateKey ImpactSoundActor; //fieldtype: String
	CSoundLink ImpactSound; //fieldtype: CatalogLink
	SActorUnitImpactSoundExtras[] ImpactSoundExtras //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		CActorCreateKey SoundActor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	SDamagePastRemainingHealth OverkillByDamagePastRemainingHealth //struct
	{
		CFixed Value; //fieldtype: Fixed
		EActorOverkillTestType TestType; //fieldtype: Unknown
	}
	SDamageOverInterval OverkillByDamageOverInterval //struct
	{
		CFixed Value; //fieldtype: Fixed
		CFixed Interval; //fieldtype: Fixed
		EActorOverkillTestType TestType; //fieldtype: Unknown
	}
	CActorTableKeys1x3 PhysicsMatchKeysOrdered; //fieldtype: Unknown
	CModelLink PlacementModel; //fieldtype: CatalogLink
	CSoundLink PlacementSound; //fieldtype: CatalogLink
	CActorCreateKey PlacementActorModel; //fieldtype: String
	CActorCreateKey PlaceholderActorModel; //fieldtype: String
	CActorCreateKey PortraitActor; //fieldtype: String
	CModelLink PortraitModel; //fieldtype: CatalogLink
	CCameraLink PortraitCamera; //fieldtype: CatalogLink
	CRange RandomScaleRange; //fieldtype: Unknown
	real32 RingRadius; //fieldtype: Float
	CGameTime StandAnimTurnTime; //fieldtype: Fixed
	real32 StandAnimTurnTimeScaleMin; //fieldtype: Float
	STerrainSquib[] TerrainSquibs //struct
	{
		CActorLabelKey GroupName; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		CVariatorActorReal32 MovementDistance; //fieldtype: Unknown
		CVariatorActorReal32 IdlePeriod; //fieldtype: Unknown
		real32 RangeUp; //fieldtype: Float
		real32 RangeUpFade; //fieldtype: Float
		real32 RangeDown; //fieldtype: Float
		real32 RangeDownFade; //fieldtype: Float
		STerrainSquibVisual[] Visuals //struct
		{
			CPhysicsMaterialLink TerrainPhysicsMaterial; //fieldtype: CatalogLink
			CActorCreateKey ActorModel; //fieldtype: String
			CActorCreateKey ActorModelLow; //fieldtype: String
			CModelLink ModelLink; //fieldtype: CatalogLink
			CFlags[] Flags; //fieldtype: Flags
		}
	}
	real32 VarianceWindowStandIntro; //fieldtype: Float
	real32 VarianceWindowStand; //fieldtype: Float
	real32 VarianceWindowWalkIntro; //fieldtype: Float
	real32 VarianceWindowWalk; //fieldtype: Float
	real32 VarianceWindowWalkOutro; //fieldtype: Float
	CGameRate WalkAnimMoveSpeed; //fieldtype: Fixed
	bool8 WalkAnimTimeScalingAsFlyer; //fieldtype: Unknown
	SUnitAbilSound[] AbilSoundArray //struct
	{
		CAbilCommand AbilCmd; //fieldtype: Unknown
		CSoundLink Sound; //fieldtype: CatalogLink
		CSoundLink GroupSound; //fieldtype: CatalogLink
	}
	CStringLink AddonIndicator; //fieldtype: String
	uint32 BarDistance; //fieldtype: IntUnsigned
	int32 BarHeight; //fieldtype: IntSigned
	int32 BarOffset; //fieldtype: IntSigned
	int32 BarWidth; //fieldtype: IntSigned
	CStringLink CantSelectUncontrollableTooltip; //fieldtype: String
	CAbilCommand[] CooldownDisplay; //fieldtype: Unknown
	CDescPath CustomUnitStatusFrame; //fieldtype: Unknown
	C2iVector CustomUnitStatusOffset; //fieldtype: Unknown
	EAttachmentID CustomUnitStatusAttachment; //enum
	CRefKey CustomUnitStatusActor; //fieldtype: String
	SErrorOverride[] ErrorArray //struct
	{
		ECmdResult Error; //enum
		CStringLink Text; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
		CSoundLink GroupSound; //fieldtype: CatalogLink
	}
	CString GlossaryAnim; //fieldtype: String
	SLayerIcon GroupIcon //struct
	{
		CImagePath[] Image; //fieldtype: String
	}
	SLayerIconVariation[] GroupIconVariations //struct
	{
		CImagePath[] Image; //fieldtype: String
		int32 Number; //fieldtype: IntSigned
	}
	CSoundLink[] GroupSoundArray; //fieldtype: CatalogLink
	uint32 GroupSoundThreshold; //fieldtype: IntUnsigned
	CImagePath HeroIcon; //fieldtype: String
	SIconVariation[] HeroIconVariations //struct
	{
		uint32 Number; //fieldtype: IntUnsigned
		CImagePath Image; //fieldtype: String
	}
	CStringLink HighlightTooltip; //fieldtype: String
	CStringLink HighlightSubTooltip; //fieldtype: String
	CStringLink InfoText; //fieldtype: String
	CImagePath LifeArmorIcon; //fieldtype: String
	CImagePath MinimapIcon; //fieldtype: String
	bool8 MinimapIconIsTeamColored; //fieldtype: Unknown
	real32 MinimapIconScale; //fieldtype: Float
	CImagePath MinimapIconBackground; //fieldtype: String
	bool8 MinimapIconBackgroundIsTeamColored; //fieldtype: Unknown
	real32 MinimapIconBackgroundScale; //fieldtype: Float
	CColor MinimapIconBackgroundTintColor; //fieldtype: Unknown
	CColor MinimapIconTintColor; //fieldtype: Unknown
	CActorKey MinimapRenderPriority; //fieldtype: String
	CStringLink MinimapTooltip; //fieldtype: String
	bool8 MinimapFlashWhenAttacked; //fieldtype: Unknown
	bool8 MinimapUseSelfColor; //fieldtype: Unknown
	bool8 MinimapUseSelectionColor; //fieldtype: Unknown
	CDescPath MinimapUnitStatusFrame; //fieldtype: Unknown
	CHerdNodeLink MovementHerdNode; //fieldtype: CatalogLink
	int32 NameOffset; //fieldtype: IntSigned
	CAbilCommand SelectAbilCmd; //fieldtype: Unknown
	CImagePath ShieldArmorIcon; //fieldtype: String
	CActorCreateKey SnapshotActor; //fieldtype: String
	CSoundLink[] SoundArray; //fieldtype: CatalogLink
	CFlagArray<e_unitStatusCount>[] StatusBarFlags; //fieldtype: Flags
	CFlagArray<e_unitStatusGroupCount>[] StatusBarGroups; //fieldtype: Flags
	CFlagArray<e_unitStatusCount>[] StatusBarOn; //fieldtype: Flags
	SStatusColor[] StatusColors //struct
	{
		CColor BackgroundColor; //fieldtype: Unknown
		CColor EmptyColor; //fieldtype: Unknown
		CColor[] ColorArray; //fieldtype: Unknown
	}
	SStatusChargeData StatusChargeData //struct
	{
		CStringLink Text; //fieldtype: String
		CAbilCommand AbilCmd; //fieldtype: Unknown
	}
	SStatusHarvesterData StatusHarvesterData //struct
	{
		CStringLink Text; //fieldtype: String
		CTargetFilters SearchFilters; //fieldtype: Unknown
		CFixed SearchRadius; //fieldtype: Fixed
	}
	STextTagParameters StatusTextInfo //struct
	{
		CStringLink Text; //fieldtype: String
		bool8 TextShadow; //fieldtype: Unknown
		C2iVector Offset; //fieldtype: Unknown
		EAttachmentID Attachment; //enum
		uint32 FontSize; //fieldtype: IntUnsigned
		CColor TextColor; //fieldtype: Unknown
		CColor EdgeColor; //fieldtype: Unknown
		CColor BackgroundColor; //fieldtype: Unknown
		CImagePath BackgroundImage; //fieldtype: String
		bool8 BackgroundImageTiled; //fieldtype: Unknown
	}
	CColorRGB UnitBorderNormalColor; //fieldtype: Unknown
	CColorRGB UnitBorderSubgroupColor; //fieldtype: Unknown
	CFlags[] UnitFlags; //fieldtype: Flags
	CImagePath UnitIcon; //fieldtype: String
	SIconVariation[] UnitIconVariations //struct
	{
		uint32 Number; //fieldtype: IntUnsigned
		CImagePath Image; //fieldtype: String
	}
	CImagePath UnitIconMultiple; //fieldtype: String
	SUnitKillRank[] UnitKillRank //struct
	{
		uint32 MinKills; //fieldtype: IntUnsigned
		CStringLink Text; //fieldtype: String
	}
	CActorCreateKey UnitModelFrameActor; //fieldtype: String
	SVitalColor[] VitalColors //struct
	{
		CColor[] ColorArray; //fieldtype: Unknown
	}
	CStringLink[] VitalNames; //fieldtype: String
	SLayerIcon Wireframe //struct
	{
		CImagePath[] Image; //fieldtype: String
	}
	SLayerIconVariation[] WireframeVariations //struct
	{
		CImagePath[] Image; //fieldtype: String
		int32 Number; //fieldtype: IntSigned
	}
	SLayerIconShield WireframeShield //struct
	{
		CImagePath[] Image; //fieldtype: String
	}
	CColor WireframeShieldColor; //fieldtype: Unknown
	SLayerIconShieldVariation[] WireframeShieldVariations //struct
	{
		CImagePath[] Image; //fieldtype: String
		uint32 Number; //fieldtype: IntUnsigned
	}
	real32 VisibleOpacity; //fieldtype: Float
	real32 VisibleOpacityBlendDuration; //fieldtype: Float
	CButtonLink UnitButton; //fieldtype: CatalogLink
	CButtonLink UnitButtonMultiple; //fieldtype: CatalogLink
	SActorRequest HostReturn //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostReturnSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	bool8 IsTentacle; //fieldtype: Unknown
	CActorKey PreHost; //fieldtype: String
}

class CActorMinimap
{
	CActorKey CopySource; //fieldtype: String
	CActorTerms Terms; //fieldtype: Unknown
	CActorKey[] Aliases; //fieldtype: String
	CActorKey[] Macros; //fieldtype: String
	EActorRequestCreateSharing Sharing; //enum
	CFlags[] Flags; //fieldtype: Flags
	CFlags[] Filter; //fieldtype: Flags
	CFlags[] FilterAtCreation; //fieldtype: Flags
	CFlags[] VisibleTo; //fieldtype: Flags
	CFlags[] VisibleToAtCreation; //fieldtype: Flags
	CFlags[] FilterPlayers; //fieldtype: Flags
	CFlags[] VisibleToPlayers; //fieldtype: Flags
	EActorHostedPropInheritType InheritType; //enum
	CFlags[] Inherits; //fieldtype: Flags
	CActorTransferFlags[] AcceptedTransfers; //fieldtype: Flags
	CActorHostedPropTransferFlags[] AcceptedHostedPropTransfers; //fieldtype: Flags
	EFogVisibility FogVisibility; //enum
	TEditorCategories EditorCategories; //fieldtype: String
	EActorPlayerIdSource PlayerIdSource; //fieldtype: Unknown
	SActorRequest Supporter //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	CPreloadLink[] Preload; //fieldtype: CatalogLink
	SActorVisibilityShape VisibilityShape //struct
	{
		CShapeLink Shape; //fieldtype: CatalogLink
	}
	SActorEvent[] Remove //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	SActorEvent[] On //struct
	{
		CActorTerms Terms; //fieldtype: Unknown
		CRefKey Target; //fieldtype: String
		CActorMsgPayloadPtr Send; //fieldtype: Unknown
	}
	bool8 AddToProximitySystem; //fieldtype: Unknown
	SActorRequest HostForProps //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorRequest Host //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOps //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	EActorScopeBearingsTrackingType ScopeBearingsTracking; //enum
	real32 MaxScale; //fieldtype: Float
	CModelLink Model; //fieldtype: CatalogLink
	SActorModelAspectSet[] ModelAspectSets //struct
	{
		CModelLink TriggerModel; //fieldtype: CatalogLink
		SActorModelAspect[] Aspects //struct
		{
			EActorModelAspectPerson Person; //enum
			EActorModelAspectObservingPoV ObservingPoV; //enum
			EActorModelAspectRegardsAs RegardsAs; //enum
			EActorModelAspectDuring During; //enum
			CLabelExpression LabelExpression; //fieldtype: Unknown
			EActorModelAspectObservedPlayerType ObservedPlayerType; //enum
			CIdSetPlayers ObservedPlayerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ObservedPlayerHasTeamId; //fieldtype: Unknown
			EActorModelAspectModelOwnerType ModelOwnerType; //enum
			CIdSetPlayers ModelOwnerHasPlayerId; //fieldtype: Unknown
			CIdSetTeams ModelOwnerHasTeamId; //fieldtype: Unknown
			CLabelExpression ModelOwnerLabelExpression; //fieldtype: Unknown
			EActorModelAspectTest Test; //enum
			CModelLink Model; //fieldtype: CatalogLink
			CSubNameKey Name; //fieldtype: String
		}
	}
	CScaleVector Scale; //fieldtype: Unknown
	real32 AutoScaleFactor; //fieldtype: Float
	real32 AutoScaleFromSelectionFactor; //fieldtype: Float
	real32 AnimBlendTime; //fieldtype: Float
	SActorHostedAttach[] HostedAttaches //struct
	{
		CActorLabelKey Name; //fieldtype: String
		SAttachQuery AttachQuery //struct
		{
			CAttachMethods Methods; //fieldtype: Unknown
			EAttachKeyword Fallback; //enum
		}
		SActorSiteOpsData HostSiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
	}
	EActorSplatHeight InternalSplatHeight; //enum
	SActorRequest HostFor2ndVisibilityTest //struct
	{
		CRefKey Subject; //fieldtype: String
		EActorRequestScope Scope; //enum
		EActorRequestActor Actor; //enum
		CEffectLink Effect; //fieldtype: CatalogLink
		bool8 FailOnNoHost; //fieldtype: Unknown
		bool8 ReachAcrossEffectTrees; //fieldtype: Unknown
	}
	SActorSiteOpsData HostSiteOpsFor2ndVisibilityTest //struct
	{
		CActorSiteOps Ops; //fieldtype: Unknown
		bool8 HoldPosition; //fieldtype: Unknown
		bool8 HoldRotation; //fieldtype: Unknown
	}
	C3Vector LocalOffsetFor2ndVisibilityTest; //fieldtype: Unknown
	CFlags[] ModelFlags; //fieldtype: Flags
	SEventDataFootprint[] EventDataFootprint //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CModelLink Model; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataFootprintActor; //fieldtype: String
	SEventDataSound[] EventDataSound //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorCreateKey Actor; //fieldtype: String
		CSoundLink Sound; //fieldtype: CatalogLink
	}
	CActorCreateKey EventDataSoundActor; //fieldtype: String
	EActorProximity ProximityPosition; //enum
	CActorLabelKey CreepHeightClass; //fieldtype: String
	CActorLabelKey CreepRateGrow; //fieldtype: String
	CActorLabelKey CreepRateShrink; //fieldtype: String
	SActorPhysicsImpactData PhysicsImpactDefault //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	SActorPhysicsImpactData[] PhysicsImpacts //struct
	{
		CActorLabelKey Name; //fieldtype: String
		CActorLabelKey Group; //fieldtype: String
		CActorCreateKey ActorModel; //fieldtype: String
		CModelLink ModelLink; //fieldtype: CatalogLink
		CActorCreateKey ActorSound; //fieldtype: String
		CSoundLink SoundLink; //fieldtype: CatalogLink
		EActorPhysicsImpactRangeType AutoVolumeRange; //enum
		real32 AutoVolumeRangeMin; //fieldtype: Float
		real32 AutoVolumeRangeMax; //fieldtype: Float
		SActorSiteOpsData SiteOps //struct
		{
			CActorSiteOps Ops; //fieldtype: Unknown
			bool8 HoldPosition; //fieldtype: Unknown
			bool8 HoldRotation; //fieldtype: Unknown
		}
		CVariatorActorReal32 OccuranceThrottlingDistance; //fieldtype: Unknown
		real32 OccuranceThrottlingDistanceTimeout; //fieldtype: Float
		CVariatorActorReal32 OccuranceThrottlingPeriod; //fieldtype: Unknown
	}
	uint32 ModelMaterialGlazeDisplayLimit; //fieldtype: IntUnsigned
	CActorKey[] LookAtPriorityList; //fieldtype: String
}
