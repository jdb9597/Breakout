using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SliderController : MonoBehaviour
{
    public Slider mySlider;
    public int mySliderValue;
    void Awake()
    {
        mySliderValue = Mathf.RoundToInt(mySlider.GetComponent<Slider>().value);
        DontDestroyOnLoad(this.gameObject);
    }
}