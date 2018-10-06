using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMotion : MonoBehaviour {

	// Use this for initialization
	public float speed;

	// Update is called once per frame
	void Update () {

		//Hacia adelante
		//si space disparo
				this.transform.Translate(Vector3.up * speed);
		}	
			

	void OnCollisionEnter(Collision collision)

	{
		Debug.Log ("Colision detectada");

		//Buscamos objeto Enemy

		GameObject enemy = collision.collider.gameObject;

		//Eliminamos gameobject encontrado
		GameObject.Destroy(enemy);

		//Eliminamos tambien el misil
		GameObject missile = this.gameObject;
		GameObject.Destroy(missile);
	}

	} 
