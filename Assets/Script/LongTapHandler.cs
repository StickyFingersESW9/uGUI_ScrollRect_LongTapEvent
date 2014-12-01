using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;



public class LongTapHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	public void OnPointerDown( PointerEventData event_data ) {

		Debug.Log( gameObject.name + ".OnPointerDown : " + Time.frameCount );

		is_scrolled = false;

		Invoke( "DelayDown", 1.0f );
	}

	private void DelayDown() {

		if( is_scrolled ) {
			Debug.Log( gameObject.name + ".DelayDown : scrolled " + Time.frameCount );
			return;
		}

		Debug.Log( gameObject.name + ".DelayDown : " + Time.frameCount );
	}

	public void OnPointerUp( PointerEventData event_data ) {

		Debug.Log( gameObject.name + ".OnPointerUp : " + Time.frameCount );

//		CancelInvoke();
	}


	public bool is_scrolled { set; get; }

}
