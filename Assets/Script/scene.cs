using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class scene : MonoBehaviour {

	// Use this for initialization
	void Start () {

		List<int> list_before = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
		List<int> list_after = new List<int>() { 4, 5, 6, 7, 8, 9 };

		IEnumerable<int> list_except = list_before.Except( list_after );
		foreach( int i in list_except ) {
			Debug.Log( i );
		}

		Debug.Log( "-----+-----+-----+-----+-----" );

		IEnumerable<int> list_except2 = list_after.Except( list_before );
		foreach( int i in list_except2 ) {
			Debug.Log( i );
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
