
class CShape
{
	CStringLink Name; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
}

class CShapeArc
{
	CStringLink Name; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	CFangleArc Arc; //fieldtype: Fixed
	CFixed Radius; //fieldtype: Fixed
}

class CShapeQuad
{
	CStringLink Name; //fieldtype: String
	TEditorCategories EditorCategories; //fieldtype: String
	CfQuad Quad; //fieldtype: Unknown
}
