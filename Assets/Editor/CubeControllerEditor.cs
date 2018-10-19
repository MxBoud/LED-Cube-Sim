using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(CubesController))]
public class ObjectBuilderEditor : Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		CubesController cubesController = (CubesController)target;
		if(GUILayout.Button("PlaceCubes"))
		{
			cubesController.PlaceCubes();
		}
	}
}
