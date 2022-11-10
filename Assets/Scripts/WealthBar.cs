using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WealthBar : MonoBehaviour
{

	public Slider slider;
	public Gradient gradient;
	public Image fill;

	public void SetMaxWealth(int wealth)
	{
		slider.maxValue = wealth;
		slider.value = wealth;

		fill.color = gradient.Evaluate(1f);
	}

    public void SetWealth(int wealth)
	{
		slider.value = wealth;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}

}