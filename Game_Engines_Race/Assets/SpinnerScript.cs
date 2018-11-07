using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.Assertions.Comparers;


public class SpinnerScript : MonoBehaviour {

	public GameObject EndPiece;
	
	[Header("Position")]
	public float Elevation;
	public float Radius;
	
	[Header("Movement")]
	public float RotationSpeed;
	public float Offset;
	private float theta;

	[Space] public bool SinElevation;
	private float elevationTheta;
	public float ElevationRange;
	public float ElevationChangeSpeed;

	[Header("Visual")] public bool ShowLine;
	private LineRenderer LR;

	[Header("Randomisation")]
	public bool RandomiseSpeed;
	public float MinSpeed;
	public float MaxSpeed;

	

	// Use this for initialization
	void Start () {
		
		
		
		
		EndPiece.transform.localPosition = new Vector3(Radius, Elevation, 0f).normalized * Radius;
		theta = Offset;

		if (ShowLine) {

			LR = GetComponent<LineRenderer>();
UpdateLine();


		}
		



	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		transform.rotation = Quaternion.AngleAxis(theta, transform.up);

		theta += (RotationSpeed * Time.deltaTime);


		if (SinElevation) {

			float newElevation =  Elevation + (ElevationRange * Mathf.Sin(elevationTheta)); 
			
			
			

			EndPiece.transform.localPosition = new Vector3(Radius, newElevation, 0f).normalized * Radius;


			elevationTheta += (ElevationChangeSpeed * Time.deltaTime);

		}

		if (ShowLine) {

			UpdateLine();
			

		}



	}


	void UpdateLine() {


		LR.positionCount = 2;
		LR.SetPosition(0, transform.position); 
		LR.SetPosition(1, EndPiece.transform.position);




	}

}
