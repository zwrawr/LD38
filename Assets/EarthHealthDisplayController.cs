using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EarthHealthDisplayController : MonoBehaviour {

    float h = 1f;

    private RectTransform GreenPannel;
    private RectTransform RedPannel;

    float init_width;

	// Use this for initialization
	void Start () {

        GreenPannel = this.transform.GetChild(0).GetComponent<RectTransform>();
        RedPannel = GreenPannel.transform.GetChild(0).GetComponent<RectTransform>();

        init_width = 600;// RedPannel.rect.xMin;
        //Debug.Log( "Init width : " + init_width);
    }

    // Update is called once per frame
    void Update () {
	
	}

    public void setHealthPercentage( float h) {

        h = Mathf.Max(0, Mathf.Min(1, h));

        if (h != this.h) {
            this.h = h;

            float width = GreenPannel.rect.width;

            RedPannel.offsetMin = new Vector2(init_width * h, RedPannel.offsetMin.y);
        }
    }
}
