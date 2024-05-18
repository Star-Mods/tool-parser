
class CDSP
{
}

class CDSPChorus
{
	real32 Delay; //fieldtype: Float
	real32 Depth; //fieldtype: Float
	real32 DryMix; //fieldtype: Float
	real32 Feedback; //fieldtype: Float
	real32 Rate; //fieldtype: Float
	real32 WetMix1; //fieldtype: Float
	real32 WetMix2; //fieldtype: Float
	real32 WetMix3; //fieldtype: Float
}

class CDSPCompressor
{
	real32 Attack; //fieldtype: Float
	real32 GainMakeUp; //fieldtype: Float
	real32 Release; //fieldtype: Float
	real32 Threshold; //fieldtype: Float
}

class CDSPCustomCompressor
{
	uint32 AttackMs; //fieldtype: IntUnsigned
	real32 Ratio; //fieldtype: Float
	uint32 ReleaseMs; //fieldtype: IntUnsigned
	real32 ThresholdDB; //fieldtype: Float
	real32 MakeUpGainDB; //fieldtype: Float
	uint32 DelayMs; //fieldtype: IntUnsigned
}

class CDSPDistortion
{
	real32 Level; //fieldtype: Float
}

class CDSPEcho
{
	real32 DecayRatio; //fieldtype: Float
	real32 Delay; //fieldtype: Float
	real32 DryMix; //fieldtype: Float
	real32 MaxChannels; //fieldtype: Float
	real32 WetMix; //fieldtype: Float
}

class CDSPFlange
{
	real32 Depth; //fieldtype: Float
	real32 DryMix; //fieldtype: Float
	real32 Rate; //fieldtype: Float
	real32 WetMix; //fieldtype: Float
}

class CDSPHighPass
{
	real32 Cutoff; //fieldtype: Float
	real32 Resonance; //fieldtype: Float
}

class CDSPLimiter
{
	uint32 ReleaseMs; //fieldtype: IntUnsigned
	bool32 UseARC; //fieldtype: Unknown
	real32 ThresholdDB; //fieldtype: Float
	real32 MakeUpGainDB; //fieldtype: Float
	real32 SoftKneeWidthDB; //fieldtype: Float
	uint32 ARCAttackMs; //fieldtype: IntUnsigned
	uint32 ARCReleaseMs; //fieldtype: IntUnsigned
	uint32 ARCMinReleaseMs; //fieldtype: IntUnsigned
	uint32 ARCMaxReleaseMs; //fieldtype: IntUnsigned
	uint32 ARCReleaseSweepMs; //fieldtype: IntUnsigned
}

class CDSPLowPass
{
	real32 Cutoff; //fieldtype: Float
	real32 Resonance; //fieldtype: Float
}

class CDSPLowPassSimple
{
	real32 Cutoff; //fieldtype: Float
}

class CDSPNormalize
{
	real32 FadeTime; //fieldtype: Float
	real32 MaxAmp; //fieldtype: Float
	real32 Threshhold; //fieldtype: Float
}

class CDSPOscillator
{
	EOscillator Type; //enum
	real32 Rate; //fieldtype: Float
}

class CDSPParamEQ
{
	real32 Bandwidth; //fieldtype: Float
	real32 Center; //fieldtype: Float
	real32 Gain; //fieldtype: Float
}

class CDSPPitchShift
{
	uint32 FFTSize; //fieldtype: IntUnsigned
	real32 MaxChannels; //fieldtype: Float
	real32 Pitch; //fieldtype: Float
}

class CDSPReverb
{
	real32 DecayHFRatio; //fieldtype: Float
	real32 DecayTime; //fieldtype: Float
	real32 Density; //fieldtype: Float
	real32 Diffusion; //fieldtype: Float
	real32 DryLevel; //fieldtype: Float
	real32 HFReference; //fieldtype: Float
	real32 LFReference; //fieldtype: Float
	real32 ReflectionsDelay; //fieldtype: Float
	real32 ReflectionsLevel; //fieldtype: Float
	real32 ReverbDelay; //fieldtype: Float
	real32 ReverbLevel; //fieldtype: Float
	real32 Room; //fieldtype: Float
	real32 RoomHF; //fieldtype: Float
	real32 RoomLF; //fieldtype: Float
	real32 RoomRolloffFactor; //fieldtype: Float
}
