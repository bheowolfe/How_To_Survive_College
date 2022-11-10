using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcademicBar : MonoBehaviour
{

	public Slider slider;
	public Gradient gradient;
	public Image fill;

	public void SetMaxAcademic(int academic)
	{
		slider.maxValue = academic;
		slider.value = academic;

		fill.color = gradient.Evaluate(1f);
	}

    public void SetAcademic(int academic)
	{
		slider.value = academic;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}

}