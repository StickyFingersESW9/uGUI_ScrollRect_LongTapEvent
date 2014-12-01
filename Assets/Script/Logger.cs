using UnityEngine;
using System.Collections;



public class Logger : MonoBehaviour {

	public void OnPointerDown() {

		Debug.Log( gameObject.name + ".OnPointerDown : " + Time.frameCount );
	}
}
