using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate( 0, 0, 1);

		//si presiono tecla izquierda se mueve hacia la izquierda
		if (Input.GetKey(KeyCode.LeftArrow)) {
			this.transform.Translate(Vector3.left);
		}

		//si presiono tecla arriba se mueve hacia arriba
		if (Input.GetKey(KeyCode.UpArrow)) {
			this.transform.Translate(Vector3.up);
		}

		//si presiono tecla derecha se mueve hacia la derecha
		if (Input.GetKey(KeyCode.RightArrow)) {
			this.transform.Translate(Vector3.right);
		}

		//si presiono tecla abajo se mueve hacia abajo
		if (Input.GetKey(KeyCode.DownArrow)) {
			this.transform.Translate(Vector3.down);
		}

		//si space disparo
		if (Input.GetKeyDown(KeyCode.Space))
		{

			GameObject newMissile =  GameObject.Instantiate(Resources.Load("Bullets/Missile") as GameObject);
				
			GameObject ShootPivot = GameObject.Find("Fighter/ShootPivot");

			newMissile.transform.SetParent (ShootPivot.transform);

			newMissile.transform.localPosition = Vector3.zero;

			newMissile.transform.SetParent (null);

		}	

			}
}
