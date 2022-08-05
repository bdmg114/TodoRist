using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class todo_timer : MonoBehaviour
{
    public string Title;
    public int settedTime;
    float time;
    public float leftTime;
    public TMP_Text titleNTimer;
    public bool active;
    public RectTransform bar;
    // Start is called before the first frame update

    private void Start()
    {
        leftTime = settedTime*60;
    }

    public void activate()
    {
        active = !active;
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            time += Time.deltaTime;
            leftTime -= Time.deltaTime;
            titleNTimer.text = Title + "\n(" + ((int)leftTime / 60 % 60).ToString() + "/" + settedTime.ToString() + "min)";
            bar.localScale = new Vector2(1-(leftTime / (settedTime * 60)), bar.localScale.y);
            if (leftTime <= 0)
            {
                active = false;
                titleNTimer.fontStyle = FontStyles.Strikethrough;
                this.enabled = false;
            }
        }
    }
}
