
class CObjective
{
	CStringLink Name; //fieldtype: String
	CStringLink Description; //fieldtype: String
	EObjectiveType Type; //enum
	int32 RequiredCount; //fieldtype: IntSigned
	int32[] RewardArray; //fieldtype: IntSigned
	CUserReference UserReference; //fieldtype: Unknown
}
