
class CMover
{
	CFlags[] Flags; //fieldtype: Flags
	EHeightMap HeightMap; //enum
	EPathMode PathMode; //enum
	SPathingData[] PlacementArray //struct
	{
		CFlags[] Bits; //fieldtype: Flags
	}
	CGameTime RestoreHeightDuration; //fieldtype: Fixed
}

class CMoverAvoid
{
	CFlags[] Flags; //fieldtype: Flags
	EHeightMap HeightMap; //enum
	EPathMode PathMode; //enum
	SPathingData[] PlacementArray //struct
	{
		CFlags[] Bits; //fieldtype: Flags
	}
	CGameTime RestoreHeightDuration; //fieldtype: Fixed
}

class CMoverFlock
{
	CFlags[] Flags; //fieldtype: Flags
	EHeightMap HeightMap; //enum
	EPathMode PathMode; //enum
	SPathingData[] PlacementArray //struct
	{
		CFlags[] Bits; //fieldtype: Flags
	}
	CGameTime RestoreHeightDuration; //fieldtype: Fixed
}

class CMoverMissile
{
	CFlags[] Flags; //fieldtype: Flags
	EHeightMap HeightMap; //enum
	EPathMode PathMode; //enum
	SPathingData[] PlacementArray //struct
	{
		CFlags[] Bits; //fieldtype: Flags
	}
	CGameTime RestoreHeightDuration; //fieldtype: Fixed
	SMotionPhase[] MotionPhases //struct
	{
		EMotionDriverType Driver; //enum
		CMissileAcceleration Acceleration; //fieldtype: Fixed
		CMissileAcceleration AccelerationRange; //fieldtype: Fixed
		CMissileSpeed Speed; //fieldtype: Fixed
		CMissileSpeed SpeedRange; //fieldtype: Fixed
		CMissileSpeed MinSpeed; //fieldtype: Fixed
		CMissileSpeed MaxSpeed; //fieldtype: Fixed
		CFixed Gravity; //fieldtype: Fixed
		CFixed Clearance; //fieldtype: Fixed
		CFixed ClearanceLookahead; //fieldtype: Fixed
		CMissileAcceleration ClearanceAcceleration; //fieldtype: Fixed
		bool32 ClearanceIgnoresTargetProximity; //fieldtype: Unknown
		bool32 IgnoresTerrain; //fieldtype: Unknown
		EMotionTurnType TurnType; //enum
		EMotionActorTrackingType ActorTracking; //enum
		EMotionArrivalTestType ArrivalTestType; //enum
		EMotionBlendType BlendType; //enum
		CPhaseOutro Outro; //fieldtype: Unknown
		EMotionRotationLaunchActorType RotationLaunchActorType; //enum
		EMotionRotationActorType RotationActorType; //enum
		CFixed Timeout; //fieldtype: Fixed
		EMotionThrowRotationType ThrowRotationType; //enum
		C3fVector ThrowVector; //fieldtype: Unknown
		CThrowBand ThrowBandYaw; //fieldtype: Unknown
		CThrowBand ThrowBandPitch; //fieldtype: Unknown
		C3fVector ThrowForward; //fieldtype: Unknown
		bool32 AdaptableParabolaIsUpright; //fieldtype: Unknown
		CVariatorGameFixed AdaptableParabolaClearance; //fieldtype: Unknown
		CFixed[] AdaptableParabolaDistances; //fieldtype: Fixed
		CMissileAcceleration[] AdaptableParabolaAccels; //fieldtype: Fixed
		CYawPitchRoll YawPitchRoll; //fieldtype: Unknown
		CYawPitchRoll YawPitchRollRange; //fieldtype: Unknown
		CYawPitchRoll YawPitchRollAccel; //fieldtype: Unknown
		CYawPitchRoll YawPitchRollAccelRange; //fieldtype: Unknown
		CFangle PowerslideAngle; //fieldtype: Fixed
		CMissileAcceleration PowerslideDecel; //fieldtype: Fixed
		CVariatorGameFixed FlightTime; //fieldtype: Unknown
		CPhaseOutro OutroAltitude; //fieldtype: Unknown
		SMotionOverlayPhase[] Overlays //struct
		{
			CVariatorGameFixed Scale; //fieldtype: Unknown
		}
	}
	SMotionOverlay[] MotionOverlays //struct
	{
		EMotionOverlayType Type; //enum
		EMotionOverlayPolarity Polarity; //enum
		CDataSoupKey PolarityDriver; //fieldtype: String
		C3fVector Axis; //fieldtype: Unknown
		CVariatorGameFixed Wavelength; //fieldtype: Unknown
		CFixed WavelengthChangeProbability; //fieldtype: Fixed
		CFangleRateMissile RevolverSpeed; //fieldtype: Unknown
		CFangleRateMissile RevolverSpeedRange; //fieldtype: Unknown
		CFangleRateMissile RevolverMaxSpeed; //fieldtype: Unknown
		CFangleRateMissile RevolverMaxSpeedRange; //fieldtype: Unknown
		CFangleAccelMissile RevolverAccel; //fieldtype: Unknown
		CFangleAccelMissile RevolverAccelRange; //fieldtype: Unknown
	}
	bool32 RotationIgnoredByUnit; //fieldtype: Unknown
	bool32 RespectUnitHeightAtDestination; //fieldtype: Unknown
}

class CMoverNull
{
	CFlags[] Flags; //fieldtype: Flags
	EHeightMap HeightMap; //enum
	EPathMode PathMode; //enum
	SPathingData[] PlacementArray //struct
	{
		CFlags[] Bits; //fieldtype: Flags
	}
	CGameTime RestoreHeightDuration; //fieldtype: Fixed
}
