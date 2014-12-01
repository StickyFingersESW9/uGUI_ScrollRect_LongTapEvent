using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ScrollCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {

		last_scroll_position_ = contents_transform_.anchoredPosition;
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 now_scroll_position = contents_transform_.anchoredPosition;
		float length = (now_scroll_position - last_scroll_position_).sqrMagnitude;

		if( length > float.Epsilon ) {
			foreach( LongTapHandler handler in list_longtap_handler_ ) {
				handler.is_scrolled = true;
			}
		}

		last_scroll_position_ = now_scroll_position;
	}


	[SerializeField]
	private RectTransform contents_transform_ = null;

	private Vector2 last_scroll_position_ = Vector2.zero;

	[SerializeField]
	private List<LongTapHandler> list_longtap_handler_ = null;

}
