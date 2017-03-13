using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TweenAlpha : MonoBehaviour {

    #region TweenAlpha...
    #region Variables
    private bool play;
    private bool fade; //fade가 false면 페이드아웃,fade가 true면 페이드인
    private float f_alpha;
    private float f_time;

    public float Begin_Alpha = 0.0f; //시작시 투명도
    public float End_Alpha = 0.0f; //끝났을때 투명도
    public float Duration = 0.0f; //지속시간
    #endregion
    // Use this for initialization
    void OnEnable () {

        //페이드인을 해야하는지 페이드아웃을 해야하는지 체크한다.
        #region check_in_or_out
        if (Begin_Alpha < End_Alpha)
            fade = false;
        else
            fade = true;
        #endregion

        //알파값을 새팅한다
        #region setting_Alpha_color
        if (!fade)
        {
            f_alpha = End_Alpha - Begin_Alpha;
            this.GetComponent<Image>().color = new Color(this.GetComponent<Image>().color.r,
                                                         this.GetComponent<Image>().color.b,
                                                         this.GetComponent<Image>().color.g,
                                                         Begin_Alpha);
        }
        else if (fade)
        {
            f_alpha = Begin_Alpha - End_Alpha;
            this.GetComponent<Image>().color = new Color(this.GetComponent<Image>().color.r,
                                                         this.GetComponent<Image>().color.b,
                                                         this.GetComponent<Image>().color.g,
                                                         Begin_Alpha);
        }
        #endregion

        //나머지 새팅
        #region The Others Setting
        f_time = Duration;
        play = true;
        #endregion
    }
    // Update is called once per frame
    void Update () {

        #region Update_Fade
        if (play)
        {
            if(!fade) //페이드인
            {
                if (this.GetComponent<Image>().color.a >= End_Alpha)
                {
                    play = false;
                }
                else
                {
                    this.GetComponent<Image>().color = new Color(this.GetComponent<Image>().color.r,
                                                            this.GetComponent<Image>().color.b,
                                                            this.GetComponent<Image>().color.g,
                                                            this.GetComponent<Image>().color.a + (f_alpha / Duration) * Time.deltaTime);
                }
            }
            else if(fade) //페이드아웃
            {
                if (this.GetComponent<Image>().color.a <= End_Alpha)
                {
                    play = false;
                }
                else
                {
                    this.GetComponent<Image>().color = new Color(this.GetComponent<Image>().color.r,
                                                            this.GetComponent<Image>().color.b,
                                                            this.GetComponent<Image>().color.g,
                                                            this.GetComponent<Image>().color.a - (f_alpha / Duration) * Time.deltaTime);
                }
            }
        }
        #endregion
    }
    #endregion
}
