using UnityEngine;
using System.Collections;

public class BoostLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider col)
	{
		if (col.name == "Player")
		{
			PlayerLoop pLoop = col.GetComponent<PlayerLoop>();
			pLoop.AddSpeedBoost(4.5f);
			Debug.Log("SPEED BOOST!");
			
			pLoop.numSpeedBoostersHit++; 
			
			for(int i = 0; i < transform.parent.GetChildCount(); i++)
			{
				GameObject go = transform.parent.GetChild(i).gameObject;
				go.renderer.material.color = Color.blue;
			}

			GA.API.Design.NewEvent("Boost:Speed",transform.position); 

		}
	}
}
