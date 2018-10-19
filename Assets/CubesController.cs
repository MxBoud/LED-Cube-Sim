using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesController : MonoBehaviour {
	public GameObject cube; 
	public GameObject cubesContainer; 
	public CubeProperties[,,] cubeStates; 

	public int xDim;
	public int yDim;
	public int zDim; 

	// Use this for initialization
	void Start () {
		UpdateCubeStates ();
		PlaceCubes ();
		SnakeTick (); 
		
	}

	void UpdateCubeStates(){
		
		cubeStates = new CubeProperties[xDim,yDim,zDim]; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void PlaceCubes() {
		//Destroy existing cubes 
		//while(cubesContainer.transform.childCount >0 ) {
			
			//DestroyImmediate(cubesContainer.transform.GetChild(0).gameObject); 
		//}
		for (int i = 0; i < xDim; i++) {
			for (int j = 0; j < yDim; j++) {
				for (int k = 0; k < zDim; k++) {
					GameObject newCube = Instantiate(cube,new Vector3((float) i, (float) j,(float) k),Quaternion.identity,cubesContainer.transform);
					cubeStates [i,j,k]= newCube.GetComponent<CubeProperties>();
					cubeStates [i,j,k].SetColor (Color.green);
				}
			}

				
		}

	}
	public void SnakeTick() {
		cubeStates [Random.Range(0,xDim),Random.Range(0,yDim),Random.Range(0,yDim)].SetColor (Color.red);
	}

}

public class Snake {
	public int x; 
	public int y;
	public int z; 

	public enum direction {x,y,z,mx,my,mz

		}
	direction dir = direction.mx; 

		

}
