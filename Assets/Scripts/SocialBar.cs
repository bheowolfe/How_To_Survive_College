using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocialBar : MonoBehaviour
{

	public Slider slider;
	public Gradient gradient;
	public Image fill;

	public void SetMaxSocial(int social)
	{
		slider.maxValue = social;
		slider.value = social;

		fill.color = gradient.Evaluate(1f);
	}

    public void SetSocial(int social)
	{
		slider.value = social;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}

}