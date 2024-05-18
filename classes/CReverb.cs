
class CReverb
{
	int32 Room; //fieldtype: IntSigned
	int32 RoomHF; //fieldtype: IntSigned
	int32 RoomLF; //fieldtype: IntSigned
	real32 DecayTime; //fieldtype: Float
	real32 DecayHFRatio; //fieldtype: Float
	int32 Reflections; //fieldtype: IntSigned
	real32 ReflectionsDelay; //fieldtype: Float
	int32 Reverb; //fieldtype: IntSigned
	real32 ReverbDelay; //fieldtype: Float
	real32 HFReference; //fieldtype: Float
	real32 LFReference; //fieldtype: Float
	real32 RoomRolloffFactor; //fieldtype: Float
	real32 Diffusion; //fieldtype: Float
	real32 Density; //fieldtype: Float
	real32[] SpeakerMix; //fieldtype: Float
}
