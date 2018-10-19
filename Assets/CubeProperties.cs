using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeProperties : MonoBehaviour {
	public Shader cubeShader; 
	Renderer cubeRenderer; 
	//Material cubeMaterial; 

	// Use this for initialization
	void Awake () {
		//cubeShader = new Shader (); 
		//cubeMaterial = new Material(cubeShader);
		cubeRenderer = GetComponent<Renderer>();
		cubeRenderer.material = new Material(cubeShader);
		cubeRenderer.material.color = Color.blue; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SetColor(Color color) {
		cubeRenderer.material.color = color; 
	}
}
