
class CCliff
{
	CCliffMeshLink CliffMesh; //fieldtype: CatalogLink
	CModelPath CliffMaterial; //fieldtype: String
	CImagePath EditorIcon; //fieldtype: String
	uint8 Scale; //fieldtype: IntUnsigned
}

class CCliffMesh
{
	CModelPath ModelPath; //fieldtype: String
	real32[] CliffHeights; //fieldtype: Float
	bool32 WeldNormals; //fieldtype: Unknown
}
