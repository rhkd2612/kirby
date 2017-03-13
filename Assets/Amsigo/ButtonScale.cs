using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonScale : MonoBehaviour, IPointerDownHandler
{
    public Vector3 bt_scale;
    public float x, y, z;
    public float tw_x, tw_y, tw_z;
    public float Duration;

    private bool ani;
    private float f_time = 0.0f;
    // Use this for initialization
    void Start()
    {
        tw_x = Mathf.Abs(transform.localScale.x - x);
        tw_y = Mathf.Abs(transform.localScale.y - y);
        tw_z = Mathf.Abs(transform.localScale.z - z);
    }

	// Update is called once per frame
	void Update () {
        if(ani)
        {
            transform.localScale = new Vector3(transform.localScale.x + tw_x/Duration*Time.smoothDeltaTime, transform.localScale.y + tw_y / Duration * Time.smoothDeltaTime, transform.localScale.z + tw_z / Duration * Time.smoothDeltaTime);
            if (f_time > 0.0f)
                f_time -= Time.smoothDeltaTime;
            else
                ani = false;
        }
        else
        {
            f_time = Duration;
        }
	}

    public void OnPointerDown(PointerEventData data)
    {
        ani = true;
    }

    public void OnPointerUp(PointerEventData data)
    {
        Debug.Log(transform.name);
    }
}
