using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FollowMouse : MonoBehaviour {

    RectTransform rectTransform;
    public RectTransform child;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        child.sizeDelta = new Vector2(Screen.width, Screen.height);

        Vector3 newPos = Input.mousePosition;
        newPos.x -= rectTransform.rect.width * 0.5f;
        newPos.y -= rectTransform.rect.height * 0.5f;
        rectTransform.position = newPos;
        child.position = Vector3.zero;// new Vector3(-Input.mousePosition.x, -Input.mousePosition.y, 0);
 	}
}
