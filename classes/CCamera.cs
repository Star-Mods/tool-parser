
class CCamera
{
	real32[] ParamInitial; //fieldtype: Float
	SCameraZoom[] ZoomTable //struct
	{
		SCameraParam[] Param //struct
		{
			bool8 Modify; //fieldtype: Unknown
			real32 Value; //fieldtype: Float
		}
	}
	SCameraZoom[] ZoomTableObserver //struct
	{
		SCameraParam[] Param //struct
		{
			bool8 Modify; //fieldtype: Unknown
			real32 Value; //fieldtype: Float
		}
	}
	uint32 ZoomDefault; //fieldtype: IntUnsigned
	SCameraSmooth[] ParamSmooth //struct
	{
		real32 SmoothTimeMin; //fieldtype: Float
		real32 SmoothTimeMax; //fieldtype: Float
		real32 DisplacementMin; //fieldtype: Float
		real32 VelocityMax; //fieldtype: Float
	}
	SCameraSmooth TargetSmooth //struct
	{
		real32 SmoothTimeMin; //fieldtype: Float
		real32 SmoothTimeMax; //fieldtype: Float
		real32 DisplacementMin; //fieldtype: Float
		real32 VelocityMax; //fieldtype: Float
	}
	real32 FieldOfViewMin; //fieldtype: Float
	real32 FieldOfViewMax; //fieldtype: Float
	real32 FieldOfViewIncrement; //fieldtype: Float
	real32 DistanceMin; //fieldtype: Float
	real32 DistanceMax; //fieldtype: Float
	real32 DistanceIncrement; //fieldtype: Float
	real32 PitchMin; //fieldtype: Float
	real32 PitchMax; //fieldtype: Float
	real32 PitchIncrement; //fieldtype: Float
	real32 YawLeft; //fieldtype: Float
	real32 YawRight; //fieldtype: Float
	real32 YawMin; //fieldtype: Float
	real32 YawMax; //fieldtype: Float
	real32 YawIncrement; //fieldtype: Float
	real32[] MaxScrollRate; //fieldtype: Float
	real32[] MaxScrollDistance; //fieldtype: Float
	real32[] VerticalScrollRateMultiplier; //fieldtype: Float
	real32[] ScrollAccelerationPeriod; //fieldtype: Float
	real32[] ScrollDecelerationPeriod; //fieldtype: Float
	real32[] ForwardScale; //fieldtype: Float
	real32[] StrafeScale; //fieldtype: Float
	real32 RotateScale; //fieldtype: Float
	CRange FollowOffsetUpdateBandX; //fieldtype: Unknown
	CRange FollowOffsetUpdateBandY; //fieldtype: Unknown
	real32 FollowResetDecayDuration; //fieldtype: Float
	real32 FollowResetDecayFactor; //fieldtype: Float
	real32 FollowResetJumpDelay; //fieldtype: Float
	real32 FollowResetJumpDistance; //fieldtype: Float
	real32 FollowResetTimeoutNormal; //fieldtype: Float
	real32 FollowResetTimeoutLeashed; //fieldtype: Float
	real32 FollowResetTimeoutUnleashed; //fieldtype: Float
	CRect FollowScrollLeash; //fieldtype: Unknown
	real32 FollowScrollLimit; //fieldtype: Float
	uint8 BorderSizeX; //fieldtype: IntUnsigned
	uint8 BorderSizeY; //fieldtype: IntUnsigned
	real32 SmartPanJumpDistance; //fieldtype: Float
	real32 SmartPanSkipDistance; //fieldtype: Float
	real32 HeightDisplacementFactor; //fieldtype: Float
	real32 HeightDisplacementPitchMin; //fieldtype: Float
	real32 HeightDisplacementPitchMax; //fieldtype: Float
	real32 HeightDisplacementMax; //fieldtype: Float
	ECameraHeightMap HeightMap; //enum
}
