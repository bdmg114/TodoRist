using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class auto_height : MonoBehaviour
{
    RectTransform[] rs;
    public float height;
    private void Start()
    {
        setHeight();
    }

    void setHeight()
    {
        rs = GetComponentsInChildren<RectTransform>();
        foreach (RectTransform r in rs)
        {
            if (r.transform.parent == transform)
            {
                height += r.sizeDelta.y;
            }
        }
        GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().sizeDelta.x, height);
    }
}
